using CommandLine;

namespace Dirmap {

    /// <summary>
    /// Options class to use as cli args options
    /// </summary>
    public sealed class Options {
        [Option('t', "target", Required = false, HelpText = "Set target directory.")] 
        public string Target { get; set; }
        
        [Option('d', "depth", Required = false, HelpText = "Set tree depth.")]
        public int Depth { get; set; }
    }
}