using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_SETURI
{
    internal class SET_2
    {
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        /// </summary>
        public static void _1()
        {
            int n, i, countEvens = 0;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("i=");
            i = int.Parse(Console.ReadLine());

            for(int j = 0; j < i; j++) 
            {
                Console.WriteLine("Introduceti un numar din secventa:");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0)
                    countEvens++;
            }
            Console.WriteLine($"Sunt {countEvens} numere pare in secventa data.");
        }

        public static void _1Prim()
        {
            //daca numerele sunt consecutive
            int first, last, evens = 0;
            Console.WriteLine("Tastati primul si ultimul numar din secventa:");
            Console.Write("first=");
            first = int.Parse(Console.ReadLine());
            Console.Write("last=");
            last = int.Parse(Console.ReadLine());

            if (first % 2 == 0 && last % 2 == 0)
                evens = 1 + (last - first) / 2;

            if (first % 2 != 0 && last % 2 != 0)
                evens = (last - first) / 2;

            if(first % 2 == 0 && last % 2 != 0)
                evens = 1 + (last - first - 1) / 2;

            if(first % 2 != 0 && last % 2 == 0)
                evens = 1 + (last - first - 1) / 2;

            Console.WriteLine($"Sunt {evens} numere pare in secventa data.");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        /// </summary>
        public static void _2()
        {
            int n, i, countPositive = 0, countZero = 0, countNegatives = 0;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("i=");
            i = int.Parse(Console.ReadLine());

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("Introduceti un numar din secventa:");
                n = int.Parse(Console.ReadLine());

                if (n > 0)
                    countPositive++;
                if (n == 0)
                    countZero++;
                if (n < 0)
                    countNegatives++;
            }
            Console.WriteLine($"Sunt {countPositive} numere pozitive, {countNegatives} numere negative si {countZero} zerouri in secventa data.");
        }

        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n.
        /// </summary>
        public static void _3()
        {
            int n, sum = 0, product = 1;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            sum = n * (n + 1)/2;
            for(int i = 1; i <= n; i++)
                product *= i;

            Console.WriteLine($"Suma numerelor de la 1 la n este {sum}, iar produsul lor este {product}.");
        }

        /// <summary>
        /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
        /// Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
        /// </summary>
        public static void _4()
        {
            int n, a, x, p = 0;
            bool isPresent = false;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Tastati numarul a carui pozitie trebuie determinata:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());

            for (int i = 0;  i < n; i++)
            {
                Console.WriteLine("Introduceti un numar din secventa:");
                x = int.Parse(Console.ReadLine());

                if(x == a)
                {
                    p = i;
                    isPresent = true;
                }
            }
            if(isPresent)
                Console.WriteLine($"Numarul {a} se afla la pozitia {p}.");
            else
                Console.WriteLine($"Numarul {a} nu se afla in secventa.");
        }

        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
        /// Se considera ca primul element din secventa este pe pozitia 0. 
        /// </summary>
        public static void _5()
        {
            int n, a = 0, x;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti un numar din secventa:");
                x = int.Parse(Console.ReadLine());

                if (x == i)
                    a++;
            }
            Console.WriteLine($"Sunt {a} numere care se afla pe pozitia.");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        /// </summary>
        public static void _6()
        {
            int n, x, y = 0;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti un numar din secventa:");
                x = int.Parse(Console.ReadLine());

                if (x >= y) 
                    y = x; 
                else
                    Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare.");
            }
            Console.WriteLine("Numerele din secventa sunt in ordine crescatoare.");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        /// </summary>
        public static void _7()
        {
            int n, min = 0, max = 0, x;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti un numar din secventa:");
                x = int.Parse(Console.ReadLine());

                if(i == 0)
                    min = x;
                if (x >= max)
                    max = x;
                if(x <= min)
                    min = x;
            }
            Console.WriteLine($"Cel mai mic numar din secventa este {min}, iar cel mai mare este {max}.");
        }

        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. 
        /// Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>
        public static void _8()
        {
            int n, f1 = 0, f2 = 1, x = 0;
            Console.WriteLine("Tastati numarul pozitiei din sirul lui Fibonacci, pe care doriti sa o aflati:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                x = f1 + f2;
                f1 = f2;
                f2 = x;
                Console.Write(x);
            }
            Console.WriteLine($"Al {n} lea numar din sirul lui Fibonacci, este {x}.");
        }

        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. 
        /// Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        /// </summary>
        public static void _9()
        {
            int n, x, y, counterForEquals = 2;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar din secventa:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar din secventa:");
            y = int.Parse(Console.ReadLine());

            while(x == y)
            {
                Console.WriteLine("Introduceti un numar din secventa:");
                y = int.Parse(Console.ReadLine());
                counterForEquals++;
            }

            if(x <= y)
            {
                x = y;
                for (int i = 0; i < n - counterForEquals; i++)
                {
                    Console.WriteLine("Introduceti un numar din secventa:");
                    y = int.Parse(Console.ReadLine());

                    if (x <= y)
                        x = y;
                    else
                    {
                        Console.WriteLine($"Secventa nu este monotona.");
                        return;
                    }
                }
                Console.WriteLine($"Secventa este monoton crescatoare.");
            } 
            else
            {
                x = y;
                for (int i = 0; i < n - counterForEquals; i++)
                {
                    Console.WriteLine("Introduceti un numar din secventa:");
                    y = int.Parse(Console.ReadLine());

                    if (x >= y)
                        x = y;
                    else
                    {
                        Console.WriteLine($"Secventa nu este monotona.");
                        return;
                    }
                }
                Console.WriteLine($"Secventa este monoton descrescatoare.");
            }
        }

        /// <summary>
        /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        /// </summary>
        public static void _10()
        {
            int n, x, y = 0, maxim = 0, consecutive = 1;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                x = y;
                Console.WriteLine("Introduceti un numar din secventa:");
                y = int.Parse(Console.ReadLine());

                if(y == x)
                    consecutive++;
                else
                {
                    if(consecutive > maxim)
                    {
                        maxim = consecutive;
                        consecutive = 1;
                    }
                }
            }
            Console.WriteLine($"Cel mai mare numar de numere consecutive din secventa, este de {maxim} numere.");
        }

        /// <summary>
        /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
        /// </summary>
        public static void _11()
        {
            int n; double x, sum = 0;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti un numar din secventa:");
                x = int.Parse(Console.ReadLine());

                x = 1 / x;
                sum += x;
            }
            Console.WriteLine($"Suma inverselor numerelor din secventa, este {sum}.");
        }

        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
        /// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. 
        /// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        /// </summary>
        public static void _12()
        {
            Console.WriteLine("Asum ca in cazul de fata, un grup poate sa insemne si o cifra diferita de 0 intre 2 zerouri (nu neaparat 2 sau mai multe).");
            int n, x, nrGrupuri = 0,consecutive = 0;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti un numar din secventa:");
                x = int.Parse(Console.ReadLine());

                if(x != 0)
                    consecutive++;
                else
                {
                    if(consecutive != 0) //daca un grup se refera la cel putin 2 cifre dintre 0 uri, atunci am fi completat cu '&& consecutive >= 2'
                    {
                        nrGrupuri++;
                        consecutive = 0;
                    }
                }
            }
            if(nrGrupuri > 0)
                Console.WriteLine($"Numarul de grupuri din secventa este de {nrGrupuri}.");
            else
                Console.WriteLine($"Nu sunt grupuri.");
        }

        /// <summary>
        /// O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau 
        /// poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive 
        /// (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). 
        /// Determinati daca o secventa de n numere este o secventa crescatoare rotita.
        /// </summary>
        public static void _13()
        {
            int n, first, x, y = 0; bool hasPassed = false, isNotCR = false;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar din secventa:");
            first = int.Parse(Console.ReadLine());
            y = first;

            for (int i = 0; i < n - 1; i++)
            {
                x = y;
                Console.WriteLine("Introduceti un numar din secventa:");
                y = int.Parse(Console.ReadLine());

                if(y < x && hasPassed == true || first < y && hasPassed == true)
                    isNotCR = true;

                if(y < x && hasPassed == false)
                    hasPassed = true;
            }
            if(isNotCR)
                Console.WriteLine("Secventa nu e crescatoare rotita.");
            else
                Console.WriteLine("Secventa e crescatoare rotita.");
        }

        /// <summary>
        /// O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata 
        /// intr-o secventa montona prin rotiri succesive. 
        /// Determinati daca o secventa de n numere este o secventa monotona rotita.
        /// </summary>
        public static void _14()
        {
            int n, first, second, x, y = 0; bool hasPassed = false, isNotMR = false;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar din secventa:");
            first = int.Parse(Console.ReadLine());
            x = first;

            do
            {
                Console.WriteLine("Introduceti un numar din secventa:");
                second = int.Parse(Console.ReadLine());
                y = second;
            } while (y == x);

            if(y > x)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if(i != 0)
                    {
                        x = y;
                        Console.WriteLine("Introduceti un numar din secventa:");
                        y = int.Parse(Console.ReadLine());
                    }

                    if (y < x && hasPassed == true || first < y && hasPassed == true)
                        isNotMR = true;

                    if (y < x && hasPassed == false)
                        hasPassed = true;
                }
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (i != 0)
                    {
                        x = y;
                        Console.WriteLine("Introduceti un numar din secventa:");
                        y = int.Parse(Console.ReadLine());
                    }

                    if (y > x && hasPassed == true || first > y && hasPassed == true)
                        isNotMR = true;

                    if (y > x && hasPassed == false)
                        hasPassed = true;
                }
            }
            if (isNotMR)
                Console.WriteLine("Secventa nu e monotona rotita.");
            else
                Console.WriteLine("Secventa e monotona rotita.");
        }

        /// <summary>
        /// O secventa bitonica este o secventa de numere care incepe monoton crescator 
        /// si continua monoton descrecator. 
        /// De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. 
        /// Sa se determine daca este bitonica.
        /// </summary>
        public static void _15()
        {
            int n, x, y = 0; bool hasPassed = false, isNotBit = false;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar din secventa:");
            y = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                x = y;
                Console.WriteLine("Introduceti un numar din secventa:");
                y = int.Parse(Console.ReadLine());

                if (y > x && hasPassed == true)
                    isNotBit = true;

                if (y < x && hasPassed == false)
                    hasPassed = true;
            }
            if (isNotBit)
                Console.WriteLine("Secventa nu e bitonica.");
            else
                Console.WriteLine("Secventa e bitonica.");
        }

        /// <summary>
        /// O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata 
        /// intr-o secventa bitonica prin rotiri succesive
        /// (rotire = primul element devine ultimul). 
        /// Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
        /// </summary>
        public static void _16()
        {
            int n, first, x, y = 0; bool hasPassed1 = false, hasPassed2= false, isNotBitR = false;
            Console.WriteLine("Tastati numarul de numere din secventa:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar din secventa:");
            first = int.Parse(Console.ReadLine());
            y = first;

            for (int i = 0; i < n - 1; i++)
            {
                x = y;
                Console.WriteLine("Introduceti un numar din secventa:");
                y = int.Parse(Console.ReadLine());

                if(y > x && hasPassed1 == false && hasPassed2 == false)
                    hasPassed1 = true;
                if (y < x && hasPassed1 == true && hasPassed2 == false)
                    hasPassed2 = true;
                if (y > x && hasPassed1 == true && hasPassed2 == true)
                    isNotBitR = true;
            }
            if (isNotBitR)
                Console.WriteLine("Secventa nu e bitonica rotita.");
            else
                Console.WriteLine("Secventa e bitonica rotita.");
        }

        /// <summary>
        /// Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. 
        /// Determinati daca secventa reprezinta o secventa de paranteze corecta si,  
        /// daca este, determinati nivelul maxim de incuibare a parantezelor. 
        /// De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 
        /// este incorecta.
        /// </summary>
        public static void _17()
        {
            string sequence, pharenthesis = "01"; int nestLevel = 0, totalOpened = 0, openedNow = 0, totalClosed = 0; bool isIncorrect = false;
            Console.WriteLine("Tastati secventa:");
            sequence = Console.ReadLine().Replace(" ", "");

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == pharenthesis[0])
                {
                    totalOpened++;
                    openedNow++;
                    if(openedNow > nestLevel)
                        nestLevel = openedNow;
                } 
                else
                {
                    totalClosed++;
                    openedNow--;
                }

                if (totalClosed > totalOpened)
                {
                    isIncorrect = true;
                    break;
                }
                if (i == sequence.Length - 1 && totalOpened != totalClosed)
                {
                    isIncorrect = true;
                    break;
                }
            }
            if(isIncorrect)
                Console.WriteLine($"Secventa nu este corecta!");
            else
                Console.WriteLine($"Secventa este corecta! Nivelul de incuibare al secventei este de {nestLevel} nivele.");
        }
    }
}
