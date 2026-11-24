using System;
using System.Collections.Generic;
using System.Text;

namespace ForMidterm
{
    internal class fileStream4
    {
        public void metodi5()
        {
            FileStream file = new FileStream("nigga.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);

            FileStream file1 = new FileStream("nigga1.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);

            string striqoni = reader.ReadLine();

            while (striqoni != null)
            { 
                writer.WriteLine(striqoni);
                striqoni = reader.ReadLine();
            }

            reader.Close();
            file.Close();
         
            writer.Close();
            file1.Close();

        }

    }
}
