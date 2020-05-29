using CommandLineParser.Arguments;

namespace wcWinAnalog
{
    public class ParsingTarget
    {
        [SwitchArgument('l', "lines", false, Description = "Print the newline counts.")]
        public bool fLines;

        [SwitchArgument('w', "words", false, Description = "Print the word counts.")]
        public bool fWords;

        [SwitchArgument('c', "bytes", false, Description = "Print the byte counts.")]
        public bool fVolume;

        [SwitchArgument('m', "chars", false, Description = "Print the character counts.")]
        public bool fSymbols;
    }

    class Program
    {
        static void Main(string[] args)
        {
            CommandLineParser.CommandLineParser parser = new CommandLineParser.CommandLineParser();
            ParsingTarget p = new ParsingTarget();

            parser.ExtractArgumentAttributes(p);
            parser.ParseCommandLine(args);
            parser.AdditionalArgumentsSettings.AcceptAdditionalArguments = true;
            string[] paths = parser.AdditionalArgumentsSettings.AdditionalArguments;

            wcSettings currentSettings = new wcSettings(p, paths);
            WcUtil util = new WcUtil(currentSettings);
            util.Start();
        }
    }
}