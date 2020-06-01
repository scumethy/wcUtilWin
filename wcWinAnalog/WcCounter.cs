using System.IO;

namespace wcWinAnalog
{
    public class wcCounter
    {
        public long wcount;
        public long lcount;
        public long bcount;
        
        public void Run(string path)
        {
            wcount = 0; lcount = 0; bcount = 0;
            using (StreamReader fs = new StreamReader(path))
            {
                string line = fs.ReadLine();
                while (line != null)
                {
                    wcount += line.Split(',', ' ', '.', '!', '?', ':', ';').Length;
                    bcount += line.Length;
                    lcount++;
                    line = fs.ReadLine();
                }
                bcount += lcount * 2;
            }
        } 
    }
}