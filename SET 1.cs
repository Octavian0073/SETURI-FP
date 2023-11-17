using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace FP_SETURI
{
    internal class SET_1
    {
        /// <summary>
        ///  Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        /// </summary>
        public static void _1()
        {
            int a, b, x;
            Console.WriteLine("Tastati doua numere a, respectiv b:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            x = -b / a;
            Console.WriteLine($"x= {x}");
        }

        /// <summary>
        ///  Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. 
        ///  Tratati toate cazurile posibile. 
        /// </summary>
        public static void _2()
        {
            double a, b, c, x1, x2, delta;
            Console.WriteLine("Tastati trei numere a, b, respectiv c:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"x1= {x1}");
            Console.WriteLine($"x2= {x2}");
        }

        /// <summary>
        ///  Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
        /// </summary>
        public static void _3()
        {
            int n, k;
            Console.WriteLine("Tastati doua numere n, respectiv k:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            if((n % k) == 0)
                Console.WriteLine("n se divide la k");
            else
                Console.WriteLine("n nu se divide la k");
        }

        /// <summary>
        ///  Detreminati daca un an y este an bisect.
        /// </summary>
        public static void _4()
        {
            int y;
            Console.WriteLine("Tastati un an y:");
            Console.Write("y=");
            y = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(y))
                Console.WriteLine($"Anul {y} este un an bisect.");
            else
                Console.WriteLine($"Anul {y} nu este un an bisect.");
        }

        public static void _4Prim()
        {
            int y;
            Console.WriteLine("Tastati un an y:");
            Console.Write("y=");
            y = int.Parse(Console.ReadLine());
            if (y % 4 == 0)
            {
                if (y % 100 == 0)
                {
                    if (y % 400 == 0)
                    {
                        Console.WriteLine($"Anul {y} este un an bisect.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Anul {y} nu este un an bisect.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine($"Anul {y} este un an bisect.");
                    return;
                }
            }
            else
                Console.WriteLine($"Anul {y} nu este un an bisect.");
        }
        /// <summary>
        ///  Extrageti si afisati a k-a cifra de la sfarsitul unui numar.
        ///  Cifrele se numara de la dreapta la stanga.
        /// </summary>
        public static void _5()
        {
            int n, p = 0, k, nr;
            Console.WriteLine("Tastati un numar:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Tastati un k reprezentand pozitia unei cifre din numar:");
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            nr = n;

            if(n == 0)
            {
                Console.WriteLine("n = 0");
                return;
            }

            for(int i = 0; i < k; i++)
            {
                p = nr % 10;
                nr /= 10;
            }
            Console.WriteLine($"A {k}-a cifra din {n} este {p}.");
        }

        /// <summary>
        ///  Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        /// </summary>
        public static void _6()
        {
            int a, b, c;
            Console.WriteLine("Tastati trei numere a, b, respectiv c:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            if(a + b > c && b + c > a && a + c > b)
                Console.WriteLine("a, b si c, pot forma un triunghi.");
            else
                Console.WriteLine("a, b si c, nu pot forma.");
        }

        /// <summary>
        ///  (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.Se cere sa se inverseze valorile lor. 
        /// </summary>
        public static void _7()
        {
            int a, b, c;
            Console.WriteLine("Tastati doua numere a, respectiv b:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
        }

        /// <summary>
        ///  (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        ///  Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
        /// </summary>
        public static void _8()
        {
            int a, b;
            Console.WriteLine("Tastati doua numere a, respectiv b:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
        }
        
        /// <summary>
        ///  Afisati toti divizorii numarului n.
        /// </summary>
        public static void _9()
        {
            int n;
            Console.WriteLine("Tastati un numar n:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
                if(n % i == 0)
                    Console.WriteLine(i);
        }

        /// <summary>
        ///  Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        public static void _10()
        {
            int n; bool isPrime = true;
            Console.WriteLine("Tastati un numar n:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            if(n <= 1)
            {
                Console.WriteLine($"{n} nu este un numar prim");
                return;
            }
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime)
                Console.WriteLine($"{n} este un numar prim.");
            else
                Console.WriteLine($"{n} nu este un numar prim");
        }

        /// <summary>
        ///  Afisati in ordine inversa cifrele unui numar n.
        /// </summary>
        private static void _11()
        {
            string n;
            Console.WriteLine("Tastati un numar n:");
            Console.Write("n=");
            n = Console.ReadLine();

            for(int i = n.Length - 1; i >= 0; i--)
                Console.Write($"{n[i]}");
            Console.WriteLine();
        }

        /// <summary>
        ///  Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
        /// </summary>
        public static void _12()
        {
            int min, max, n, countDivisors = 0;
            Console.WriteLine("Tastati trei numere n, min, respectiv max:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("min=");
            min = int.Parse(Console.ReadLine());
            Console.Write("max=");
            max = int.Parse(Console.ReadLine());

            for(int i = min; i <= max; i++)
                if(n % i == 0)
                    countDivisors++;

            Console.WriteLine($"Numarul de divizori ai lui {n} din intervalul [{min}, {max}] este {countDivisors}.");
        }

        /// <summary>
        ///  Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        public static void _13()
        {
            int y1, y2, countLeapYears = 0;
            Console.WriteLine("Tastati doi ani, y1, respectiv y2:");
            Console.Write("y1=");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("y2=");
            y2 = int.Parse(Console.ReadLine());

            for(int i = y1; i <= y2; i++)
            {
                if(i % 4 == 0) 
                {
                    if(i % 100 == 0)
                        if(i % 400 == 0)
                            countLeapYears++;
                    else
                        countLeapYears++;
                }
            }
            Console.WriteLine($"Sunt {countLeapYears} ani bisecti intre anii {y1} si {y2}.");
        }

        /// <summary>
        ///  Determianti daca un numar n este palindrom. 
        ///  (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.
        /// </summary>
        private static void _14()
        {
            string n; bool isPalindrom = true;
            Console.WriteLine("Tastati un numar n:");
            Console.Write("n=");
            n = Console.ReadLine();

            for (int i = 0, j = n.Length - 1; i <= n.Length / 2; i++, j--)
                if (n[i] != n[j])
                    isPalindrom = false;

            if(isPalindrom)
                Console.WriteLine($"Numarul {n} este un numar palindrom.");
            else
                Console.WriteLine($"Numarul {n} nu este un numar palindrom.");
        }

        /// <summary>
        ///  Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
        /// </summary>
        public static void _15()
        {
            int a, b, c, temp; bool hasSwapped; 
            Console.WriteLine("Tastati trei numere a, b, respectiv c:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            int[] arr = { a, b, c };

            //Array.Sort(arr, (x, y) => x - y);
            //OR

            for(int i = 0; i < arr.Length - 1; i++)
            {
                hasSwapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        hasSwapped = true;
                    }
                }
                if(!hasSwapped)
                    break;
            }

            for(int i = 0; i < arr.Length; i++)
                Console.Write($" {arr[i]}");
            Console.WriteLine();
        }

        /// <summary>
        ///  Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        /// </summary>
        public static void _16()
        {
            int a, b, c, d, e, temp;
            Console.WriteLine("Tastati cinci numere a, b, c, d, respectiv e:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            Console.Write("d=");
            d = int.Parse(Console.ReadLine());
            Console.Write("e=");
            e = int.Parse(Console.ReadLine());

            if(a > b)
            {
                temp = a; 
                a = b; 
                b = temp; 
            }
            if(b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if(c > d)
            {
                temp = c;
                c = d;
                d = temp;
            }
            if(d > e)
            {
                temp = d;
                d = e;
                e = temp;
            }
            if(a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if(b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if(c > d)
            {
                temp = c;
                c = d;
                d = temp;
            }
            if(a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if(b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if(a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            Console.Write($"{a} {b} {c} {d} {e}");
            Console.WriteLine();
        }

        /// <summary>
        ///  Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. 
        ///  Folositi algoritmul lui Euclid. 
        /// </summary>
        public static void _17()
        {
            int a, b, cmmdc, cmmmc;
            Console.WriteLine("Tastati doua numere a, respectiv b:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            if(a == 0)
            {
                Console.WriteLine($"CMMDC al numerelor {a} si {b} este {b}.");
                return;
            }
            if (b == 0)
            {
                Console.WriteLine($"CMMDC al numerelor {a} si {b} este {a}.");
                return;
            }

            cmmdc = gcd(a, b);
            cmmmc = a * b / cmmdc;
            Console.WriteLine($"Cel mai mare divizor comun este {cmmdc}, iar cel mai mic multiplu comun este {cmmmc}.");
        }
        public static int gcd(int a, int b)
        {
            int r;
            while( a % b > 0)
            {
                r = a % b;
                a = b; 
                b = r;
            }
            return b;
        }

        /// <summary>
        ///  Afisati descompunerea in factori primi ai unui numar n.  
        ///  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2.
        /// </summary>
        public static void _18()
        {
            List<int> primeFactors = new List<int>();
            int n;
            Console.WriteLine("Tastati un numar n:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            if(n <= 1)
                return;

            for (int i = 2; n > 1;)
            {
                if (n % i == 0)
                {
                    n /= i;
                    primeFactors.Add(i);
                    i = 2;
                }
                else
                    i++;
            }
            Console.WriteLine(_18displayPrimeFactors(primeFactors));
        }
        private static string _18displayPrimeFactors(List<int> primeFactors)
        {
            int factor, factorsCount = 0;
            string decomposedN = $"";

            for (int i = 0; i < primeFactors.Count; i++)
            {
                factor = primeFactors[i];
                factorsCount++;

                if( i == primeFactors.Count -1)
                {
                    decomposedN += $"{factor}^{factorsCount} ";
                    return decomposedN;
                }
                if (primeFactors[i] != primeFactors[i+1])
                {
                    decomposedN += $"{factor}^{factorsCount} x ";
                    factorsCount = 0;
                } 
            }
            return decomposedN;
        }

        /// <summary>
        ///  Determinati daca un numar e format doar cu 2 cifre care se pot repeta. 
        ///  De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.
        /// </summary>
        public static void _19()
        {
            List<char> number = new List<char>();
            string n;
            Console.WriteLine("Tastati un numar n:");
            Console.Write("n=");
            n = Console.ReadLine();

            for(int i = 0; i < n.Length; i++) 
                if (!number.Contains(n[i])) 
                    number.Add(n[i]);
            
            if (number.Count == 2)
                Console.WriteLine($"Numarul {n} este un numar compus din 2 cifre care se tot repeta.");
            else
                Console.WriteLine($"Numarul {n} nu este un numar compus din 2 cifre care se tot repeta.");
        }

        /// <summary>
        ///  Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). 
        ///  Exemplu: 13/30 = 0.4(3). 
        ///  (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs)
        ///  O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si
        ///  n sunt mai mari sau egale decat 0
        ///  O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
        ///  O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si
        ///  cu alte numere prime diferite de 2 si 5. 
        /// </summary>
        public static void _20()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
        /// </summary>
        public static void _21()
        {
            int minim = 1, maxim = 2024, m;
            string response;

            while(maxim - minim > 1)
            {
                m = minim + (maxim - minim) / 2;

                Console.WriteLine($"Este numarul mai mare sau egal decat {m}.");
                response = Console.ReadLine();
                
                if (response.ToLower() == "da")
                    minim = m;
                else 
                    maxim = m - 1;
            }

            Console.WriteLine($"Este numarul tau mai mare sau egal decat {maxim}?");
            response = Console.ReadLine();

            if(response.ToLower() == "da")
                Console.WriteLine($"Numarul este {maxim}.");
            else
                Console.WriteLine($"Numarul este {minim}.");
        }
    }
}
