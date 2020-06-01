using System;

namespace wcWinAnalog
{
    public class WcUtil
    {
        private wcSettings Settings;

        public WcUtil(wcSettings settings)
        {
            Settings = settings;
        }

        public void Start()
        {
            wcCounter counter = new wcCounter();
            string output = "";

            foreach (var path in Settings.Paths)
            {
                counter.Run(path);

                // 1 case: w/o any flags
                if (Settings.Flags.Count == 0)
                {
                    output += $"{counter.lcount} {counter.wcount} {counter.bcount} {Settings.Paths[0]}";
                }
                // 2 case: user's set of flags
                else
                {
                    if (Settings.Flags.Contains("l")) output += $" {counter.lcount}";
                    if (Settings.Flags.Contains("w")) output += $" {counter.wcount}";
                    if (Settings.Flags.Contains("c")) output += $" {counter.bcount}";
                    output += $" {path}";
                }

                Console.WriteLine(output);
                output = "";
            }
        }
    }
}