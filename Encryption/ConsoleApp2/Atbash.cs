using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Atbash : IChiper
    {
        string alf = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        string alfphabet = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";
        string numbers = "0123456789";
        public string Encode(string unencrypted)
        {
            int key; //количество сдвигов
            string encrypted = "";
            for (int i = 0; i < unencrypted.Length; i++)
            {                
                for (int j = 0; j < alfphabet.Length; j++)
                {
                    key = 33;
                    if (unencrypted[i] == alfphabet[j])
                    {
                        if (unencrypted[i] == alfphabet[j])
                        {
                            int temp = 2 * key - j;
                            if (temp % 2 == 0)
                            {
                                temp -= 2;
                            }
                            encrypted += alfphabet[temp];
                            continue;
                        }
                    }
                }
                for (int j = 0; j < alf.Length; j++)
                {
                    key = 26;
                    if (unencrypted[i] == alf[j])
                    {
                        int temp = 2 * key - j; 
                        if (temp % 2 == 0)
                        {
                            temp -= 2;
                        }
                        encrypted += alf[temp];
                        continue;
                    }
                } 
                for (int j = 0; j < numbers.Length; j++)
                {
                    key = 10;
                    if (unencrypted[i] == numbers[j])
                    {
                        int temp = key - j - 1;
                        encrypted += numbers[temp];
                        continue;
                    }
                }
                if (!alf.Contains(unencrypted[i]) && !alfphabet.Contains(unencrypted[i]) && !numbers.Contains(unencrypted[i])) // эти знаки печатаются без зашифровки
                {
                    encrypted += unencrypted[i];
                }
            }            
            return encrypted;
        }
        public string Decode(string unencrypted)
        {
            return Encode(unencrypted);            
        }
    }
}
