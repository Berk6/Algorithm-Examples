using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class TotalNumber
    {/// <summary>
    /// Girilen string ifadenin içinde bulunan sayıları toplar.
    /// </summary>
    /// <param name="letter"></param>
    /// <returns></returns>
        public int TotalNumberCalculator(string letter)
        {
            string b = "0";
            int counter = 0;
            int toplam = 0;
            for (int i = 0; i < letter.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (letter[i].ToString() == j.ToString())
                    {
                        b += letter[i];
                        counter = 1;
                        break;
                    }
                }
                if (counter == 0)
                {
                    toplam += int.Parse(b);
                    b = "0";
                }
                counter = 0;
            }
            return toplam;
        }
    }
}
