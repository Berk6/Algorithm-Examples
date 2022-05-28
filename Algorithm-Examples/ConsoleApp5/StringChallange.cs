using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class StringChallange
    {/// <summary>
    /// Girilen bir metinsel ifadenin içinde bulunan küçük harfli karakterleri büyük,büyük harfli karakterleri ise küçük yapan ve kelime içinde 2 tane sayı varsa yerlerini değiştiren metot
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
        public  string StringChallengeMethod(string str)
        {
            char[] total = new char[str.Length];
            string realTotal = "";
            int counter = 0;
            int temp = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    total[i] = char.ToLower(str[i]);
                }
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    total[i] = char.ToUpper(str[i]);
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    total[i] = str[i];
                    counter++;
                    if (counter == 1)
                    {
                        temp = i;
                    }
                    if (counter == 2)
                    {
                        char a = total[temp];
                        total[temp] = total[i];
                        total[i] = a;
                    }
                }
                else if (str[i] == ' ')
                {
                    counter = 0;
                    total[i] = str[i];
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                realTotal += total[i];
            }
            return realTotal;
        }
    }
}
