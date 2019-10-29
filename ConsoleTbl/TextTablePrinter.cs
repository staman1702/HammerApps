using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTbl
{
    public class TextTablePrinter
    {
        private readonly string[] titles;
        private readonly List<int> lengths;
        private readonly List<string[]> rows = new List<string[]>();

        public TextTablePrinter(params string[] titles)
        {
            this.titles = titles;
            lengths = titles.Select(t => t.Length).ToList();
        }

        public void AddRow(params object[] row)
        {
            if (row.Length != titles.Length)
            {
                throw new System.Exception($"Added row length [{row.Length}] is not equal to title row length [{titles.Length}]");
            }
            rows.Add(row.Select(o => o.ToString()).ToArray());
            for (int i = 0; i < titles.Length; i++)
            {
                if (rows.Last()[i].Length > lengths[i])
                {
                    lengths[i] = rows.Last()[i].Length;
                }
            }
        }

        public void Print()
        {
            lengths.ForEach(l => System.Console.Write("+" + new string('-', l)));
            System.Console.WriteLine("+");

            string line = "";
            for (int i = 0; i < titles.Length; i++)
            {                
                line += "|" + titles[i].PadRight(lengths[i]);                
            }
            System.Console.WriteLine(line + "|");

            lengths.ForEach(l => System.Console.Write("+" + new string('-', l)));
            System.Console.WriteLine("+");

            foreach (var row in rows)
            {

                line = "";
                for (int i = 0; i < row.Length; i++)
                {
                    
                    if (i == (row.Length - 1))
                    {
                        line += "|" + row[i].PadLeft((lengths[i] - 1)/ 2)
                                            .PadRight(lengths[i]);
                    }
                    
                    else
                    {
                        line += "|" + row[i].PadRight(lengths[i]);
                    }
                }
                System.Console.WriteLine(line + "|");

                lengths.ForEach(l => System.Console.Write("+" + new string('-', l)));
                System.Console.WriteLine("+");
            }

        }
    }
}
