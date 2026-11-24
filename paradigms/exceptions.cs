using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ForMidterm
{
    internal class exceptions
    {
        public void gamonaklisi(string message)
        {
            int []masivi = new int[] {1,2,3,4,5,6};
           
                FileStream file = new FileStream("nigga1.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);

                try
                {
                    for (int i = 0; i < masivi.Length; i++)
                {
                    writer.Write(masivi[i]);
                }
            }
            catch (IOException)
            {
                message = "file read problem!";
            }
            writer.Close();
            file.Close();
        }
    }
}
