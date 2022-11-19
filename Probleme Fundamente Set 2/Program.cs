using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Fundamente_Set_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce-ti un numar de la 1 la 17 pentru a selecta problema dorita");
            switch (Console.ReadLine())
            {
                case "1":
                    P1();
                    break;
                case "2":
                    P2();
                    break;
                case "3":
                    P3();
                    break;
                case "4":
                    P4();
                    break;
                case "5":
                    P5();
                    break;
                case "6":
                    P6();
                    break;
                case "7":
                    P7();
                    break;
                case "8":
                    P8();
                    break;
                case "9":
                    P9();
                    break;
                case "10":
                    P10();
                    break;
                case "11":
                    P11();
                    break;
                case "12":
                    P12();
                    break;
                case "13":
                    P13();
                    break;
                case "14":
                    P14();
                    break;
                case "15":
                    P15();
                    break;
                case "16":
                    P16();
                    break;
                case "17":
                    P17();
                    break;

            }
        }
        /// <summary>
        /// 17.Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 
        /// </summary>
        private static void P17()
        {
            int n, a, counter, incuib, incuibmax;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti numere din secventa.Secventa trebuie sa contina doar 0 si 1");
            counter = 0;
            incuib = 0;
            incuibmax = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());

                if (a == 0)
                {
                    counter++;
                }
                if (a == 1)
                {
                    counter--;
                }
                if (counter < 0)
                {
                    Console.WriteLine("Nu este o secventa de paranteze corecta");
                }
                Console.WriteLine(counter);
                if (counter > 1 && a == 0)
                {
                    incuib++;
                }
                Console.WriteLine(incuib);
                if (incuib > incuibmax)
                {
                    incuibmax = incuib;
                }
                if (counter == 0)
                {
                    incuib = 0;
                }

            }
            if (counter > 0)
            {
                Console.WriteLine("Nu este o secventa de paranteze corecta");
            }
            if (counter == 0)
            {
                Console.WriteLine($"Secventa este corecta si gradul de incuibare este {incuibmax}");
            }
        }
        /// <summary>
        /// 16.O secventa bitonica rotita este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
        /// </summary>
        private static void P16()
        {

        }
        /// <summary>
        /// 15.O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica.
        /// </summary>
        private static void P15()
        {
            int n, a, previous = 0;
            bool este_bitonica = false, este_crescatoare = false;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti secventa:");
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    previous = a;
                }
                if (!este_bitonica)
                {
                    if (i > 0 && previous < a)
                    {
                        este_crescatoare = true;
                    }
                    if (previous > a)
                    {
                        este_bitonica = true;
                    }
                }

                if (este_bitonica)
                {
                    if (previous < a)
                    {
                        Console.WriteLine("Secventa nu este bitonica");
                        return;
                    }
                }
                previous = a;
            }
            if (este_crescatoare && este_bitonica)
            {
                Console.WriteLine("Secventa este bitonica");
                return;
            }
            Console.WriteLine("Secventa nu este bitonica");


        }
        /// <summary>
        /// 14.O secventa monotona rotita este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. 
        /// </summary>
        private static void P14()
        {
            int n, a, previous, primul, ultimul, counterplus, counterminus;
            previous = 0;
            primul = 0;
            ultimul = 0;
            counterplus = 0;
            counterminus = 0;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            if (n == 3)
            {
                Console.WriteLine("Orice secventa de 3 numere poate fi monotona rotita. Introduce-ti o secventa mai lunga");
                return;
            }
            Console.WriteLine("Introduce-ti secventa:");
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    primul = a;
                    previous = a;
                }
                if (i == n - 1)
                {
                    ultimul = a;
                }

                if (previous < a)
                    counterplus++;
                if (previous > a)
                    counterminus++;
                previous = a;

            }
            if (counterminus == 1)
            {
                if (ultimul < primul)
                {
                    Console.WriteLine("Secventa este crescatoare monoton rotita");
                    return;
                }
            }
            if (counterminus == 0 && counterplus >= 1)
            {
                Console.WriteLine("Secventa este monoton crescatoare");
                return;
            }
            if (counterplus == 1)
            {
                if (ultimul > primul)
                {
                    Console.WriteLine("Secventa este descrescatoare monoton rotita");
                    return;
                }
            }
            if (counterplus == 0 && counterminus >= 1)
            {
                Console.WriteLine("Secventa este monoton descrescatoare");
                return;
            }
            Console.WriteLine("Secventa nu este monotona rotita");

        }
        /// <summary>
        /// 13.O secventa crescatoare rotita este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
        /// </summary>
        private static void P13()
        {
            int n, a, previous, primul, ultimul, counteregal, counterminus;
            previous = 0;
            primul = 0;
            ultimul = 0;
            counteregal = 0;
            counterminus = 0;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti secventa:");
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    previous = a;
                    primul = a;
                }
                if (i == n - 1)
                {
                    ultimul = a;
                }

                if (previous == a)
                    counteregal++;
                if (previous > a)
                    counterminus++;
                previous = a;
            }
            if (counteregal != 1)
            {
                Console.WriteLine("Secventa nu este crescatoare rotita");
                return;
            }
            if (counterminus == 0)
            {
                Console.WriteLine("Secventa este crescatoare");
                return;
            }
            if (counterminus == 1)
            {
                if (ultimul < primul)
                {
                    Console.WriteLine("Secventa este crescatoare rotita");
                    return;
                }
            }
            Console.WriteLine("Secventa nu este crescatoare rotita");
        }

        /// <summary>
        /// 12.Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
        /// </summary>
        private static void P12()
        {
            int n, a, counternr, countergr;
            Console.WriteLine("Cate numere sunt in secventa? Secventa trebuie sa se termine obligatoriu cu cifra 0");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti secventa");
            counternr = 0;
            countergr = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a != 0)
                {
                    counternr++;
                }
                if (i == n - 1 && a != 0)
                {
                    Console.WriteLine("Secventa trebuie sa se termine obligatoriu cu cifra 0");
                    return;
                }
                if (a == 0 && counternr != 0)
                {
                    countergr++;
                    counternr = 0;
                }
            }
            Console.WriteLine($"Secventa contine {countergr} grup(uri) de numere diferite de zero");
        }
        /// <summary>
        /// 11.Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
        /// </summary>
        private static void P11()
        {
            int n, a, invers, s;
            invers = 0;
            s = 0;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti secventa");
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                while (a != 0)
                {
                    invers = invers * 10 + (a % 10);
                    a /= 10;
                }
                s += invers;
                invers = 0;
            }
            Console.WriteLine($"Suma inverselor este {s}");
        }
        /// <summary>
        /// 10.Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        /// </summary>
        private static void P10()
        {
            int a, n, previous, counteregal, countermax;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti secventa");
            previous = int.Parse(Console.ReadLine());
            counteregal = 0;
            countermax = 0;
            for (int i = 0; i < n - 1; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a == previous)
                {
                    counteregal++;
                    if (counteregal > countermax)
                    {
                        countermax = counteregal;
                    }
                }
                if (a != previous)
                    counteregal = 0;
                previous = a;
            }
            Console.WriteLine($"Numarul maxim de numerere consecutive egale din secventa este {countermax + 1}");
        }
        /// <summary>
        /// 9.Sa se determine daca o secventa de n numere este monotona.
        /// </summary>
        private static void P9()
        {
            int a, n, previous, counterplus, counterminus;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti secventa");
            counterplus = 0;
            counterminus = 0;

            previous = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    previous = a;
                }

                if (previous <= a)
                    counterplus++;
                if (previous >= a)
                    counterminus++;
                previous = a;
            }
            if (counterplus == n)
            {
                Console.WriteLine("Secventa este monoton crescatoare");
                return;
            }
            if (counterminus == n)
            {
                Console.WriteLine("Secventa este monoton descrescatoare");
                return;
            }
            else
            {
                Console.WriteLine("Secventa nu este monotona");
            }
        }
        /// <summary>
        /// 8.Determianti al n-lea numar din sirul lui Fibonacci.
        /// </summary>
        private static void P8()
        {
            ulong n1, n2, nr;
            int n;
            Console.WriteLine("Al catelea numar din sirul Fibonacci il doriti?");
            n = int.Parse(Console.ReadLine());
            n1 = 0;
            n2 = 1;
            nr = 1;
            if (n == 1)
            {
                Console.WriteLine("0");
            }
            if (n == 2)
            {
                Console.WriteLine("1");
            }
            for (int i = 3; i <= n; i++)
            {
                nr = n1 + n2;
                n1 = n2;
                n2 = nr;
            }
            Console.WriteLine($"Termenul {n} al sirului Fibonacci este {nr}");
        }
        /// <summary>
        /// 7.Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        /// </summary>
        private static void P7()
        {
            int n, a, min, max;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti secventa");
            min = int.MaxValue;
            max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (max < a)
                {
                    max = a;
                }
                if (min > a)
                {
                    min = a;
                }
            }
            Console.WriteLine($"Mininul este {min} si maximul este {max}");
        }
        /// <summary>
        /// 6.Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        /// </summary>
        private static void P6()
        {
            int n, a, previous;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti secventa");
            previous = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    previous = a;
                }
                if (previous > a)
                {
                    Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare");
                    return;
                }
                previous = a;
            }
            Console.WriteLine("Numerele din secventa sunt in ordine crescatoare");

        }
        /// <summary>
        /// 5.Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 
        /// </summary>
        private static void P5()
        {
            int n, a, counter;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti secventa de numere");
            counter = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a == i)
                {
                    counter++;
                }
            }
            Console.WriteLine($"{counter} elemente din secventa sunt egale cu pozitia pe care apar in secventa");
        }
        /// <summary>
        /// 4.Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
        /// </summary>
        private static void P4()
        {
            int n, nr, a, counter;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Care este numarul carui pozitie doriti sa o gasiti?");
            nr = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti secventa de numere");
            counter = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a == nr)
                {
                    Console.WriteLine($"Numarul {nr} se afla in pozitia {i}");
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("-1");
            }
        }
        /// <summary>
        /// 3.Calculati suma si produsul numerelor de la 1 la n. 
        /// </summary>
        private static void P3()
        {
            int n, suma, produs;
            Console.WriteLine("Cat este limita superioara n?");
            n = int.Parse(Console.ReadLine());
            suma = 0;
            produs = 1;
            for (int i = 1; i < n; i++)
            {
                suma += i;
                produs *= i;
            }
            Console.WriteLine($"Suma numerelor pana la {n} este {suma} si produsul este {produs}");
        }
        /// <summary>
        /// 2.Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        /// </summary>
        private static void P2()
        {
            int a, n, counter_poz, counter_neg, counter_zero;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            counter_poz = 0;
            counter_neg = 0;
            counter_zero = 0;
            Console.WriteLine("Introduce-ti numerele");
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    counter_zero++;
                }
                if (a < 0)
                {
                    counter_neg++;
                }
                if (a >= 1)
                {
                    counter_poz++;
                }
            }
            Console.WriteLine($"In secventa sunt {counter_zero} cifre 0, {counter_poz} numere pozitive si {counter_neg} numere negative");
        }
        /// <summary>
        /// 1.Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        /// </summary>
        private static void P1()
        {
            int n, a, counter;
            Console.WriteLine("Cate numere sunt in secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti numerele");
            counter = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"In secventa sunt {counter} numere pare");
        }
    }

}
        
    

