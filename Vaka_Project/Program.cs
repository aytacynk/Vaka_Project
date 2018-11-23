using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vaka_Project.Models;

namespace Vaka_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate coor = new Coordinate();
            Console.Write("Düzlemin MAX x değerini giriniz : ");
            coor.Max_X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Düzlemin MAX y değerini giriniz : ");
            coor.Max_Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDüzelemin Maximum Değerleri : ({0})", coor);
            Console.WriteLine();

            for (int i = 1; i <= 2; i++)
            {
                Robotic robotic = new Robotic();
                Console.Write("{0}. Robotik Gezginin X değerini giriniz : ", i);
                robotic.X = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0}. Robotik Gezginin Y değerini giriniz : ", i);
                robotic.Y = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0}. Robotik Gezginin Yönünün değerini giriniz : ", i);
                robotic.Direction = Console.ReadLine().ToUpper();
                Console.WriteLine("\n{0}. Robotic konumu ve Yönü  : ({0} {1} {2})", robotic.X, robotic.Y, robotic.Direction);
                robotic.RoboticDirection(robotic);
                Console.WriteLine();
                Console.Write("Lütfen Tüm Yönlendirmelerinizi tek tek giriniz ve çıkmak için 'ESC' Tuşuna basınız\n\n");

                List<char> inputList = new List<char>();
                int k = 1;
                for (; ; )
                {
                    basaDon:
                    Console.Write(k + ". Yönlendimeyi giriniz : ");
                    ConsoleKeyInfo c = Console.ReadKey();
                    string C = c.KeyChar.ToString();
                    if (c.Key == ConsoleKey.Escape)
                    {
                        Console.Write("Çıktınız...");
                        break;
                    }
                    else if (C == "L" || C == "l" || C == "m" || C == "M" || C == "r" || C == "R")
                        inputList.Add(Convert.ToChar(c.Key));
                    else
                    {
                        Console.WriteLine(" 'L','M' ya da 'R' harflerini kullanınız.");
                        goto basaDon;
                    }
                    k++;
                    Console.WriteLine();
                }
                Console.Write("\n\nTüm Yönlendirmeleriniz : ");
                foreach (char item in inputList)
                    Console.Write(item);
                Console.WriteLine("\nYeni yönünüz hesaplanıyor...");
                Thread.Sleep(2000);
                string result = "";
                foreach (char item in inputList)
                    result = robotic.FindNewDirection(item, coor.Max_X, coor.Max_Y);
                Console.WriteLine(result + "\n");
            }
            Console.Read();
        }
    }
}
