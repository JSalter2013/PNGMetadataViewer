namespace PNGMetadataViewer
{
    partial class PNGMetadataViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox = new PictureBox();
            promptMenuStrip = new ContextMenuStrip(components);
            copyPromptMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            formTableLayoutPanel = new TableLayoutPanel();
            clearButton = new Button();
            promptsTableLayoutPanel = new TableLayoutPanel();
            promptGroupBox = new GroupBox();
            promptBox = new TextBox();
            negativeGroupBox = new GroupBox();
            negativePromptBox = new TextBox();
            modelMetadataGroupBox = new GroupBox();
            modelMetadataGridView = new DataGridView();
            imageMetadataGroupBox = new GroupBox();
            imageMetadataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            promptMenuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            formTableLayoutPanel.SuspendLayout();
            promptsTableLayoutPanel.SuspendLayout();
            promptGroupBox.SuspendLayout();
            negativeGroupBox.SuspendLayout();
            modelMetadataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modelMetadataGridView).BeginInit();
            imageMetadataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageMetadataGridView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.FromArgb(46, 62, 80);
            pictureBox.BackgroundImage = Properties.Resources.DropImageHere;
            pictureBox.BackgroundImageLayout = ImageLayout.Center;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.InitialImage = null;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(784, 874);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // promptMenuStrip
            // 
            promptMenuStrip.ImageScalingSize = new Size(20, 20);
            promptMenuStrip.Items.AddRange(new ToolStripItem[] { copyPromptMenuItem });
            promptMenuStrip.Name = "contextMenuStrip1";
            promptMenuStrip.Size = new Size(170, 30);
            // 
            // copyPromptMenuItem
            // 
            copyPromptMenuItem.Image = Properties.Resources.favicon;
            copyPromptMenuItem.Name = "copyPromptMenuItem";
            copyPromptMenuItem.Size = new Size(169, 26);
            copyPromptMenuItem.Text = "Copy Prompt";
            copyPromptMenuItem.Click += copyPromptMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 990);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1581, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(133, 20);
            toolStripStatusLabel.Text = "Waiting for input....";
            // 
            // formTableLayoutPanel
            // 
            formTableLayoutPanel.AllowDrop = true;
            formTableLayoutPanel.ColumnCount = 2;
            formTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            formTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            formTableLayoutPanel.Controls.Add(clearButton, 0, 1);
            formTableLayoutPanel.Controls.Add(promptsTableLayoutPanel, 1, 0);
            formTableLayoutPanel.Controls.Add(pictureBox, 0, 0);
            formTableLayoutPanel.Dock = DockStyle.Fill;
            formTableLayoutPanel.Location = new Point(0, 0);
            formTableLayoutPanel.Name = "formTableLayoutPanel";
            formTableLayoutPanel.RowCount = 2;
            formTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 88.8888855F));
            formTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            formTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            formTableLayoutPanel.Size = new Size(1581, 990);
            formTableLayoutPanel.TabIndex = 2;
            formTableLayoutPanel.DragDrop += formTableLayoutPanel_DragDrop;
            formTableLayoutPanel.DragEnter += formTableLayoutPanel_DragEnter;
            // 
            // clearButton
            // 
            clearButton.Dock = DockStyle.Fill;
            clearButton.FlatAppearance.BorderColor = SystemColors.WindowText;
            clearButton.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(3, 883);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(784, 104);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // promptsTableLayoutPanel
            // 
            promptsTableLayoutPanel.AutoSize = true;
            promptsTableLayoutPanel.ColumnCount = 1;
            promptsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            promptsTableLayoutPanel.Controls.Add(promptGroupBox, 0, 0);
            promptsTableLayoutPanel.Controls.Add(negativeGroupBox, 0, 1);
            promptsTableLayoutPanel.Controls.Add(modelMetadataGroupBox, 0, 2);
            promptsTableLayoutPanel.Controls.Add(imageMetadataGroupBox, 0, 3);
            promptsTableLayoutPanel.Dock = DockStyle.Fill;
            promptsTableLayoutPanel.Location = new Point(793, 3);
            promptsTableLayoutPanel.Name = "promptsTableLayoutPanel";
            promptsTableLayoutPanel.RowCount = 4;
            formTableLayoutPanel.SetRowSpan(promptsTableLayoutPanel, 2);
            promptsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            promptsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            promptsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            promptsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            promptsTableLayoutPanel.Size = new Size(785, 984);
            promptsTableLayoutPanel.TabIndex = 6;
            // 
            // promptGroupBox
            // 
            promptGroupBox.Controls.Add(promptBox);
            promptGroupBox.Dock = DockStyle.Fill;
            promptGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            promptGroupBox.Location = new Point(3, 3);
            promptGroupBox.Name = "promptGroupBox";
            promptGroupBox.Size = new Size(779, 190);
            promptGroupBox.TabIndex = 4;
            promptGroupBox.TabStop = false;
            promptGroupBox.Text = "Prompt";
            // 
            // promptBox
            // 
            promptBox.ContextMenuStrip = promptMenuStrip;
            promptBox.Dock = DockStyle.Fill;
            promptBox.Font = new Font("Segoe UI", 9F);
            promptBox.Location = new Point(3, 23);
            promptBox.Multiline = true;
            promptBox.Name = "promptBox";
            promptBox.Size = new Size(773, 164);
            promptBox.TabIndex = 1;
            // 
            // negativeGroupBox
            // 
            negativeGroupBox.Controls.Add(negativePromptBox);
            negativeGroupBox.Dock = DockStyle.Fill;
            negativeGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            negativeGroupBox.Location = new Point(3, 199);
            negativeGroupBox.Name = "negativeGroupBox";
            negativeGroupBox.Size = new Size(779, 190);
            negativeGroupBox.TabIndex = 5;
            negativeGroupBox.TabStop = false;
            negativeGroupBox.Text = "Negative Prompt";
            // 
            // negativePromptBox
            // 
            negativePromptBox.ContextMenuStrip = promptMenuStrip;
            negativePromptBox.Dock = DockStyle.Fill;
            negativePromptBox.Font = new Font("Segoe UI", 9F);
            negativePromptBox.Location = new Point(3, 23);
            negativePromptBox.Multiline = true;
            negativePromptBox.Name = "negativePromptBox";
            negativePromptBox.Size = new Size(773, 164);
            negativePromptBox.TabIndex = 3;
            // 
            // modelMetadataGroupBox
            // 
            modelMetadataGroupBox.Controls.Add(modelMetadataGridView);
            modelMetadataGroupBox.Dock = DockStyle.Fill;
            modelMetadataGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            modelMetadataGroupBox.Location = new Point(3, 395);
            modelMetadataGroupBox.Name = "modelMetadataGroupBox";
            modelMetadataGroupBox.Size = new Size(779, 289);
            modelMetadataGroupBox.TabIndex = 6;
            modelMetadataGroupBox.TabStop = false;
            modelMetadataGroupBox.Text = "Model Metadata";
            // 
            // modelMetadataGridView
            // 
            modelMetadataGridView.AllowUserToAddRows = false;
            modelMetadataGridView.AllowUserToDeleteRows = false;
            modelMetadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            modelMetadataGridView.BackgroundColor = Color.White;
            modelMetadataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            modelMetadataGridView.Dock = DockStyle.Fill;
            modelMetadataGridView.Location = new Point(3, 23);
            modelMetadataGridView.Name = "modelMetadataGridView";
            modelMetadataGridView.RowHeadersVisible = false;
            modelMetadataGridView.RowHeadersWidth = 51;
            modelMetadataGridView.Size = new Size(773, 263);
            modelMetadataGridView.TabIndex = 8;
            // 
            // imageMetadataGroupBox
            // 
            imageMetadataGroupBox.Controls.Add(imageMetadataGridView);
            imageMetadataGroupBox.Dock = DockStyle.Fill;
            imageMetadataGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            imageMetadataGroupBox.Location = new Point(3, 690);
            imageMetadataGroupBox.Name = "imageMetadataGroupBox";
            imageMetadataGroupBox.Size = new Size(779, 291);
            imageMetadataGroupBox.TabIndex = 7;
            imageMetadataGroupBox.TabStop = false;
            imageMetadataGroupBox.Text = "Image Metadata";
            // 
            // imageMetadataGridView
            // 
            imageMetadataGridView.AllowUserToAddRows = false;
            imageMetadataGridView.AllowUserToDeleteRows = false;
            imageMetadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            imageMetadataGridView.BackgroundColor = Color.White;
            imageMetadataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            imageMetadataGridView.Dock = DockStyle.Fill;
            imageMetadataGridView.Location = new Point(3, 23);
            imageMetadataGridView.Name = "imageMetadataGridView";
            imageMetadataGridView.RowHeadersVisible = false;
            imageMetadataGridView.RowHeadersWidth = 51;
            imageMetadataGridView.Size = new Size(773, 265);
            imageMetadataGridView.TabIndex = 9;
            // 
            // PNGMetadataViewerForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1581, 1016);
            Controls.Add(formTableLayoutPanel);
            Controls.Add(statusStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PNGMetadataViewerForm";
            Text = "ComfyUI PNG Metadata Viewer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            promptMenuStrip.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            formTableLayoutPanel.ResumeLayout(false);
            formTableLayoutPanel.PerformLayout();
            promptsTableLayoutPanel.ResumeLayout(false);
            promptGroupBox.ResumeLayout(false);
            promptGroupBox.PerformLayout();
            negativeGroupBox.ResumeLayout(false);
            negativeGroupBox.PerformLayout();
            modelMetadataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)modelMetadataGridView).EndInit();
            imageMetadataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageMetadataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox;
        private ContextMenuStrip promptMenuStrip;
        private ToolStripMenuItem copyPromptMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private TableLayoutPanel formTableLayoutPanel;
        private Button clearButton;
        private TableLayoutPanel promptsTableLayoutPanel;
        private GroupBox promptGroupBox;
        private TextBox promptBox;
        private GroupBox negativeGroupBox;
        private TextBox negativePromptBox;
        private GroupBox modelMetadataGroupBox;
        private DataGridView modelMetadataGridView;
        private GroupBox imageMetadataGroupBox;
        private DataGridView imageMetadataGridView;
    }
}
