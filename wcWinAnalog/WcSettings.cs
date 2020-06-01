using System;
using System.Collections.Generic;
using System.Linq;

namespace wcWinAnalog
{
    public class wcSettings
    {
        public List<String> Flags { get; set; }
        public List<String> Paths { get; set; }

        public wcSettings(ParsingTarget p, string[] paths)
        {
            Flags = FlagsToArray(p);
            Paths = paths.ToList();
        }

        private static List<String> FlagsToArray(ParsingTarget p)
        {
            List<String> flags = new List<string>();

            if (p.fVolume) flags.Add("c");
            if (p.fLines) flags.Add("l");
            if (p.fWords) flags.Add("w");

            return flags;
        }
    }
}