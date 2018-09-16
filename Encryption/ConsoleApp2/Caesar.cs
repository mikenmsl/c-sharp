using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Caesar : IChiper
    {        
        string alf = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        string alfphabet = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";
        string numbers = "0123456789";
        public string Encode(string unencrypted)
        {
            const int key = 3;
            string encrypted = "";
            for (int i = 0; i < unencrypted.Length; i++)
            {
                for (int j = 0; j < alfphabet.Length; j++)
                {
                    if (unencrypted[i] == alfphabet[j])
                    {
                        int temp = j + key * 2;
                        while (temp >= alfphabet.Length)
                            temp -= alfphabet.Length;
                        encrypted += alfphabet[temp];
                        continue;
                    }                    
                }
                for (int j = 0; j < alf.Length; j++)
                {
                    if (unencrypted[i] == alf[j])
                    {
                        int temp = j + 2 * key;
                        while (temp >= alf.Length)
                            temp -= alf.Length;
                        encrypted += alf[temp];
                        continue;
                    }
                }
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (unencrypted[i] == numbers[j])
                    {
                        int temp = j + key;
                        while (temp >= numbers.Length)
                            temp -= numbers.Length;
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
            int key = 6;
            string encrypted = "";
            for (int i = 0; i < unencrypted.Length; i++)
            {
                for (int j = 0; j < alfphabet.Length; j++)
                {
                    if (unencrypted[i] == alfphabet[j])
                    {
                        int temp = j + alfphabet.Length - key;
                        while (temp >= alfphabet.Length)
                            temp -= alfphabet.Length;
                        encrypted += alfphabet[temp];
                        continue;
                    }
                }
                for (int j = 0; j < alf.Length; j++)
                {
                    if (unencrypted[i] == alf[j])
                    {
                        int temp = j + alf.Length - key;
                        while (temp >= alf.Length)
                            temp -= alf.Length;
                        encrypted += alf[temp];
                        continue;
                    }
                }
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (unencrypted[i] == numbers[j])
                    {
                        int temp = j + 3;
                        while (temp >= numbers.Length)
                            temp -= numbers.Length;
                        encrypted += numbers[temp];
                        continue;
                    }
                }                
            }
            return encrypted;
        }
    }        
}

