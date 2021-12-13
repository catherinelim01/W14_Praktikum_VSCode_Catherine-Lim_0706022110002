using System;

namespace W14_Praktikum_VSCode_Catherine_Lim_0706022110002
{
    class Program
    {
        public static void Catherine()
        {
            Console.WriteLine("Praktikum Week 14\nCatherine Lim_0706022110002\n");
        }
        public static long InputUser()
        {
            Console.Write("Input: ");
            long inputAngka = Convert.ToInt32(Console.ReadLine());
            return inputAngka;
        }
        static void Main(string[] args)
        {
            Catherine();
            long jumlahFaktor, pengecekBilangan;
            long inputUser = InputUser();
            jumlahFaktor = 0;
            pengecekBilangan = 1;
            do
            {
                if (inputUser % pengecekBilangan == 0)
                {
                    jumlahFaktor = jumlahFaktor + 1;
                }
                pengecekBilangan = pengecekBilangan + 1;
            }
            while (pengecekBilangan <= inputUser);
            if (jumlahFaktor == 2)
            {
                long maks, y, faktor;
                maks = inputUser * inputUser;
                long variableYangDiCek = 1;
                long hitungAngkaPrint = 0;
                int n = 1;
                while (n <= maks)
                {
                    faktor = 0;
                    for (y = variableYangDiCek; y >= 1; y--)
                    {
                        if (variableYangDiCek % y == 0)
                        {
                            faktor++;
                        }
                    }
                    if (faktor == 2)
                    {
                        Console.Write("{0,5}" + " ", variableYangDiCek);
                        if (n % inputUser == 0)
                        {
                            Console.WriteLine();
                        }
                        hitungAngkaPrint++;
                        n++;
                    }
                    variableYangDiCek++;
                }
            }
            else
            {
                long maks, y, faktor;
                maks = inputUser * inputUser;
                long variableYangDiCek = 1;
                long hitungAngkaPrint = 0;
                int n = 1;
                while (n <= maks)
                {
                    faktor = 0;
                    for (y = variableYangDiCek; y >= 1; y--)
                    {
                        if (variableYangDiCek % y == 0)
                        {
                            faktor++;
                        }
                    }
                    if (faktor != 2)
                    {
                        Console.Write("{0,5}"+ " ", variableYangDiCek);
                        if (n % inputUser == 0)
                        {
                            Console.WriteLine();
                        }
                        hitungAngkaPrint++;
                        n++;
                    }
                    variableYangDiCek++;
                }
            
            }
        }
    }
}
