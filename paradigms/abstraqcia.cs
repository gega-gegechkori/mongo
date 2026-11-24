using System;
using System.Collections.Generic;
using System.Text;


   public abstract class abstraqcia
    {
    public abstract int Metodi_1(int[,]masivi);
        
    }

    public class  Memkvidre : abstraqcia
    {
    public override int Metodi_1(int[,] masivi)
    {
        int sum=0;
        int rows = masivi.GetLength(0);
        int cols = masivi.GetLength(1);
        
        for (int i = 0; i < rows; i++) {
         for (int j = 0; j < cols; j++){
                if (masivi[i, j] % 3 == 0)
                {
                    sum += masivi[i, j];
                }
            }
        }
        return sum;
    }


    }

