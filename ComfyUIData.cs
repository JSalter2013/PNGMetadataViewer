namespace PNGReaderTest
{
    public class ComfyUIData
    {
        public int last_node_id { get; set; }
        public int last_link_id { get; set; }
        public Node[] nodes { get; set; }
        public object[][] links { get; set; }
        public object[] groups { get; set; }
        public Config config { get; set; }
        public Extra extra { get; set; }
        public float version { get; set; }
    }

    public class Config
    {
    }

    public class Extra
    {
    }

    public class Node
    {
        public int id { get; set; }
        public string type { get; set; }
        public float[] pos { get; set; }
        public object size { get; set; }
        public Flags flags { get; set; }
        public int order { get; set; }
        public int mode { get; set; }
        public Input[] inputs { get; set; }
        public Output[] outputs { get; set; }
        public Properties properties { get; set; }
        public object[] widgets_values { get; set; }
    }

    public class Flags
    {
    }

    public class Properties
    {
        public string NodenameforSR { get; set; }
    }

    public class Input
    {
        public string name { get; set; }
        public string type { get; set; }
        public int link { get; set; }
    }

    public class Output
    {
        public string name { get; set; }
        public string type { get; set; }
        public int[] links { get; set; }
        public int slot_index { get; set; }
        public int shape { get; set; }
    }

}
