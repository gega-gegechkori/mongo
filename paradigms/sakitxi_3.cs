using System;
using System.Collections.Generic;
using System.Text;

    public class sakitxi_3
    {
     public string function()
    {
        int[] masivi = new int[100];
        int[] count = new int[101];
        System.Random rand = new System.Random();

        for(int i = 0; i < masivi.Length; i++)
        {
            masivi[i] = rand.Next(1, 101);
            count[masivi[i]]++;
        }
      
        string shedegi = "";
        for (int i = 1;i <= 100; i++)
        {
            if (count[i] > 0)
            {
                shedegi += $"ricxvi {i} gvxvdeba {count[i]}-jer"+"\n";
            }
        }
        return shedegi;
    }



    }
