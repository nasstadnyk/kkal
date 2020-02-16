using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkal
{
    class FileReader
    {
        public static void Reader(OpenFileDialog openFileDialog1)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            foreach (string str in System.IO.File.ReadAllLines(filename))
            {
                Thickener th = new Thickener();
                string[] words = str.Split(new char[] { '$' });
                th.Name = words[0];
                // th.date_use = Convert.ToDateTime(words[4]);
                th.Min_thickener = Convert.ToInt64(words[1]);
                th.Max_thickener = Convert.ToInt64(words[2]);
                th.Price = Convert.ToInt64(words[3]);
                Manufacture.thickeners.Add(th);
            }
        }
    }
}
