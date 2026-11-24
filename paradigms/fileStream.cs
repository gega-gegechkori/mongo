using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


public class fileStream
{
    public int metodi()
    {
        byte[] masivi = new byte[5];
        FileStream file = new FileStream("nigga.txt", FileMode.Open);
        int wakitxuli = file.Read(masivi, 0, 5);
        byte min = masivi[0];

        for (int i = 0; i < wakitxuli; i++)
        {

            if (min > masivi[i])
            {
                min = masivi[i];
            }
        }
        file.Seek(0, SeekOrigin.End);
        file.WriteByte(min);
        file.Close();

        return min;


    }
}

