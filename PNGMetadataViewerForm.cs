using PNGReaderTest;
using SixLabors.ImageSharp;
using System.Data;
using System.Text.Json;
using Image = SixLabors.ImageSharp.Image;

namespace PNGMetadataViewer
{
    public partial class PNGMetadataViewerForm : Form
    {
        protected bool validData;

        string path;
        protected List<object> textValues;
        protected Image image;
        protected Thread getImageThread;

        public PNGMetadataViewerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formTableLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            string filename;

            validData = GetFilename(out filename, e);
            if (validData)
            {
                path = filename;
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array? data = e.Data.GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }

        private void formTableLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (validData)
            {
                clearAll();

                while (getImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }

                pictureBox.Image = ImageExtensions.ToNetImage(image.ToArray());

                imageMetadataGridView.DataSource = MakeImageMetadataTable(image);

                var pngTextData = image.Metadata.GetPngMetadata().TextData;

                if (pngTextData.Count == 1)
                {
                    toolStripStatusLabel.Text = $"Automatic1111 Generated PNG: {path}";

                    // Probably Automatic111
                    var promptsData = image.Metadata.GetPngMetadata().TextData[0].Value.Split("\n");

                    promptBox.Text = promptsData[0];
                    negativePromptBox.Text = promptsData[1].Replace("Negative prompt:", string.Empty);

                    var modelData = promptsData[2].Split(',', StringSplitOptions.TrimEntries);
                    modelMetadataGridView.DataSource = MakeAutomatic1111DataTable(modelData);
                }
                else if (pngTextData.Count > 1)
                {
                    toolStripStatusLabel.Text = $"ComfyUI Generated PNG: {path}";

                    // Probably ComfyUI
                    var comfyUIMetadata = JsonSerializer.Deserialize<ComfyUIData>(pngTextData[1].Value);

                    if (comfyUIMetadata == null)
                    {
                        MessageBox.Show("Could not load ComfyUI Metadata", "Error");
                    }
                    else
                    {
                        modelMetadataGridView.DataSource = MakeComfyUIKSamplerDataTable(comfyUIMetadata);

                        textValues = comfyUIMetadata.nodes.Where(x => x.type.Equals("CLIPTextEncode")).SelectMany(x => x.widgets_values).ToList();

                        promptBox.Text = textValues.Count() > 0 ? textValues[1]?.ToString() : string.Empty;
                        negativePromptBox.Text = textValues.Count() > 0 ? textValues[0].ToString() : string.Empty;
                    }
                }
                else
                {
                    // No TextData

                    toolStripStatusLabel.Text = $"No text data found in PNG: {path}";
                }
            }
        }
        protected void LoadImage()
        {
            image = Image.Load(path);
        }

        private DataTable MakeComfyUIKSamplerDataTable(ComfyUIData data)
        {
            var table = new DataTable();

            table.Columns.Add(new DataColumn("Key", typeof(string)));
            table.Columns.Add(new DataColumn("Value", typeof(string)));

            var ksamplerFields = new[] { "Seed", "Control After Generate", "Steps", "CFG", "Sampler Name", "Scheduler", "Denoise" };

            var checkpointLoader = data.nodes.Where(x => x.type.Contains("CheckpointLoaderSimple")).Select(x => x.widgets_values).FirstOrDefault();
            table.Rows.Add("Model Name", checkpointLoader != null ? checkpointLoader[0] ?? "Unknown" : "Unknown");

            var loraLoader = data.nodes.Where(x => x.type.Equals("LoraLoader")).SelectMany(x => x.widgets_values).ToList();
            table.Rows.Add("LORA Name", loraLoader?.Count != 0 ? loraLoader?[0] : "None");

            int i = 0;

            foreach (var ksamplerItem in data.nodes.Where(x => x.type.Equals("KSampler")).Select(x => x.widgets_values).SelectMany(x => x))
            {
                table.Rows.Add(ksamplerFields[i++], ksamplerItem);
            }

            return table;
        }

        private DataTable MakeAutomatic1111DataTable(string[] data)
        {
            var table = new DataTable();

            table.Columns.Add(new DataColumn("Key", typeof(string)));
            table.Columns.Add(new DataColumn("Value", typeof(string)));

            foreach (var item in data)
            {
                var k = item.Split(':');
                table.Rows.Add(k[0], k[1]);
            }

            return table;
        }

        private DataTable MakeImageMetadataTable(Image image)
        {
            var table = new DataTable();

            table.Columns.Add(new DataColumn("Key", typeof(string)));
            table.Columns.Add(new DataColumn("Value", typeof(string)));

            table.Rows.Add("Height", image.Height);
            table.Rows.Add("Width", image.Width);
            table.Rows.Add("AlphaRepresentation", image.PixelType.AlphaRepresentation?.ToString());
            table.Rows.Add("BitsPerPixel", image.PixelType.BitsPerPixel);
            table.Rows.Add("DefaultMimeType", image.Metadata.DecodedImageFormat?.DefaultMimeType);
            table.Rows.Add("Name", image.Metadata.DecodedImageFormat?.Name);
            table.Rows.Add("ColorType", image.Metadata.GetPngMetadata().ColorType);
            table.Rows.Add("FramesCount", image.Frames.Count());

            return table;
        }

        private void copyPromptMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem? item = sender as ToolStripItem;
            if (item != null)
            {
                ContextMenuStrip? owner = item.Owner as ContextMenuStrip;
                if (owner != null && !string.IsNullOrEmpty(owner.SourceControl?.Text))
                {
                    Clipboard.SetText(owner.SourceControl.Text, TextDataFormat.Text);
                    toolStripStatusLabel.Text = "Copied...";
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            pictureBox.Image = null;
            promptBox.Text = string.Empty;
            negativePromptBox.Text = string.Empty;
            modelMetadataGridView.DataSource = null;
            imageMetadataGridView.DataSource = null;
            toolStripStatusLabel.Text = "Waiting for input...";
        }
    }
}
