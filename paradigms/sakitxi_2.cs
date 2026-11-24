using System;
using System.Collections.Generic;
using System.Text;

    public class sakitxi_2
    {
    public string randomMatrix(int rows, int columns)
    {
       
        System.Random random = new System.Random();
        int[,] masivi = new int[rows, columns];
        string shedegi = " ";

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                masivi[i, j] = random.Next(7, 28);
                shedegi+= masivi[i, j].ToString()+" ";

            }
            shedegi += "\n";
        }
        return shedegi;
    }
    }
