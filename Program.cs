using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace binaris_valogatas
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("szoveg.txt", FileMode.Create);
            StreamWriter fileKi = new StreamWriter(file);
            string sor = string.Empty;
            int kod = 0;
            int vmi = ' ';

            Console.Write("Mi legyen a kód: ");
            kod = Convert.ToInt32(Console.ReadLine());
            do
            {
                sor = Console.ReadLine();
                if (sor != "")
                {
                    for (int i = 0; i < sor.Length; i++) { 
                        vmi = sor[i];
                        vmi ^= kod;
                        fileKi.Write((char)vmi); 
                    }
                    fileKi.Write("\n");
                }
            } while (sor != "");

            fileKi.Close();
            file.Close();
            Console.WriteLine("Vége");
            Console.ReadLine();
        }
    }
}
