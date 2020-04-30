using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_20192_P1_4_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int alas, tinggi, keliling, luas, hipotenusa;

            Console.Clear();

            Console.WriteLine("PROGRAM PERHITUNGAN SEGITIGA SIKU-SIKU");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
            Console.WriteLine("a. Hitung Luas ");
            Console.WriteLine("b. Hitung Keliling ");
            Console.WriteLine("c. Hitung Hipotenusa ");
            Console.WriteLine("d. Keluar ");
            Console.Write("\nMenu Pilihan : ");
            char pilih = Convert.ToChar(Console.ReadLine());

            switch (pilih)
            {
                case 'a':
                    Console.WriteLine("\n-------------------------------------");
                    Console.WriteLine("LUAS SEGITIGA");
                    Console.Write("Masukkan alas : ");
                    alas = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukkan tinggi : ");
                    tinggi = Convert.ToInt16(Console.ReadLine());

                    luas = alas * tinggi / 2;
                    Console.WriteLine("Luas segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, luas);
                    break;
                case 'b':
                    Console.WriteLine("\n-------------------------------------");
                    Console.WriteLine("KELILING SEGITIGA");
                    Console.Write("Masukkan alas : ");
                    alas = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukkan tinggi : ");
                    tinggi = Convert.ToInt16(Console.ReadLine());

                    hipotenusa = Convert.ToInt16(Math.Sqrt(Math.Pow(alas, 2) + Math.Pow(tinggi, 2)));
                    keliling = alas + tinggi + hipotenusa;
                    Console.WriteLine("Keliling segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, keliling);
                    break;
                case 'c' :
                    Console.WriteLine("\n-------------------------------------");
                    Console.WriteLine("KELILING SEGITIGA");
                    Console.Write("Masukkan alas :");
                    alas = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukkan tinggi :");
                    tinggi = Convert.ToInt16(Console.ReadLine());

                    hipotenusa = Convert.ToInt16(Math.Sqrt(Math.Pow(alas, 2) + Math.Pow(tinggi, 2)));
                    Console.WriteLine("Panjang hipotenusa segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, hipotenusa);
                    break;
                case 'd' :
                    break;
            }
        }
    }
}