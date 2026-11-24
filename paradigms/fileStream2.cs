using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ForMidterm
{
    internal class fileStream2
    {
        public string metodi1()
        {
            string label=" ";
            char[] masivi = new char[10];
            FileStream file = new FileStream("nigga.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            int wakitxuli = reader.Read(masivi, 0, 10);
            for(int i = 0; i < wakitxuli; i++)
            {
                label += masivi[i];
            }
            FileStream file2 = new FileStream("nigga1.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file2);
               
                writer.Write(masivi, 0, wakitxuli);
                writer.Close();
                file2.Close();



            return label;
        }
    }
}
