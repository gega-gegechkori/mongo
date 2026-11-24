using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ForMidterm
{
    internal class fileStream3
    {
        public void metodi3()
        {
            string []striqonebi = new string[] 
            {"striqoni 1",
            "striqoni 2",
            "striqoni 3"
            };
            FileStream file = new FileStream("nigga.txt", FileMode.Create);
            StreamWriter sr = new StreamWriter(file);
            

            for (int i = 0; i < striqonebi.Length; i++)
            {
                 sr.WriteLine(striqonebi[i]);
            }
            sr.Close();
            file.Close();

        }
    }
}
