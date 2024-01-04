using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics;
using System.Security.Policy;
using System.Resources;
using System.Xml.XPath;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace FP_SETURI
{
    internal class SET_3
    {
        /// <summary>
        ///  Calculati suma elementelor unui vector de n numere citite de la tastatura. 
        ///  Rezultatul se va afisa pe ecran.
        /// </summary>
        public static void _1()
        {
            string[] arrStr; int[] arr; int sum = 0;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            Console.WriteLine($"Suma numerelor din vector este {sum}.");
        }

        /// <summary>
        ///  Se da un vector cu n elemente si o valoare k. 
        ///  Se cere sa se determine prima pozitie din vector pe care apare k. 
        ///  Daca k nu apare in vector rezultatul va fi -1.
        /// </summary>
        public static void _2()
        {
            string[] arrStr; int[] arr; int k, position; bool notPresent = true;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            Console.WriteLine("Tastati valoarea k:");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == k)
                {
                    position = i;
                    notPresent = false;
                    Console.WriteLine($"Numarul {k} se afla pe pozitia {position} in vector.");
                    break;
                }
            }
            if (notPresent)
                Console.WriteLine($"Numarul {k} nu a fost gasit in vector.");
        }

        /// <summary>
        ///  Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. 
        ///  Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).
        /// </summary>
        public static void _3()
        {
            string[] arrStr; int[] arr; int max = 0, min = 0, minPos = 0, maxPos = 0;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxPos = i;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    minPos = i;
                }
            }
            Console.WriteLine($"Pozitiile la care se afla cel mai mic numar {min} si cel mai mare numar {max}, sunt {minPos}, respectiv {maxPos}.");
        }

        /// <summary>
        ///  Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si 
        ///  de cate ori apar acestea. 
        /// </summary>
        public static void _4()
        {
            string[] arrStr; int[] arr; int max = 0, min, minPresent = 0, maxPresent = 0;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max == arr[i])
                    maxPresent++;

                if (min == arr[i])
                    minPresent++;

                if (arr[i] > max)
                {
                    max = arr[i];
                    maxPresent = 1;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    minPresent = 1;
                }
            }
            Console.WriteLine($"Cel mai mic numar {min} si cel mai mare numar {max} si apar de {minPresent} ori, respectiv {maxPresent} ori.");
        }

        /// <summary>
        ///  Se da un vector cu n elemente, o valoare e si o pozitie din vector k. 
        ///  Se cere sa se insereze valoarea e in vector pe pozitia k. 
        ///  Primul element al vectorului se considera pe pozitia zero. 
        /// </summary>
        public static void _5()
        {
            string[] arrStr; int[] arr; int e, k; bool isInserted = false;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length + 1];

            Console.WriteLine("Tastati valoarea numarului de insertat:");
            e = int.Parse(Console.ReadLine());

            Console.WriteLine("Tastati pozitia unde sa fie insertat:");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrStr.Length + 1; i++)
            {
                if (i == k)
                {
                    arr[k] = e;
                    isInserted = true;
                    continue;
                }
                if (isInserted)
                    arr[i] = int.Parse(arrStr[i - 1]);
                else
                    arr[i] = int.Parse(arrStr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");

            Console.WriteLine();
        }

        /// <summary>
        ///  Se da un vector cu n elemente si o pozitie din vector k. 
        ///  Se cere sa se stearga din vector elementul de pe pozitia k. 
        ///  Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
        /// </summary>
        public static void _6()
        {
            string[] arrStr; int[] arr; int k; bool isDeleted = false;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length - 1];

            Console.WriteLine("Tastati pozitia de sters:");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrStr.Length; i++)
            {
                if (i == k)
                {
                    isDeleted = true;
                    continue;
                }
                if (isDeleted)
                    arr[i - 1] = int.Parse(arrStr[i]);
                else
                    arr[i] = int.Parse(arrStr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");

            Console.WriteLine();
        }

        /// <summary>
        ///  Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. 
        ///  Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        /// </summary>
        public static void _7()
        {
            string[] arrStr; int[] arr;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            for (int i = arrStr.Length - 1, j = 0; i >= 0; i--, j++)
                arr[j] = int.Parse(arrStr[i]);

            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        ///  Rotire. Se da un vector cu n elemente. 
        ///  Rotiti elementele vectorului cu o pozitie spre stanga. 
        ///  Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
        /// </summary>
        public static void _8()
        {
            string[] arrStr; int[] arr; int last;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            last = int.Parse(arrStr[0]);

            for (int i = 0; i < arrStr.Length - 1; i++)
                arr[i] = int.Parse(arrStr[i + 1]);

            arr[arr.Length - 1] = last;

            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        ///  Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
        /// </summary>
        public static void _9()
        {
            string[] arrStr; int[] arr, temp; int k;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            Console.WriteLine("Tastati cu cate pozitii sa se mute la stanga vectorul:");
            k = int.Parse(Console.ReadLine());

            temp = new int[k];

            for (int i = 0; i < k; i++)
                temp[i] = int.Parse(arrStr[i]);

            for (int i = 0, j = k; i < arrStr.Length - k; i++, j++)
                arr[i] = int.Parse(arrStr[j]);

            for (int i = arrStr.Length - k, j = 0; i < arrStr.Length; i++, j++)
                arr[i] = temp[j];

            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        ///  Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. 
        ///  Se cere sa se determine pozitia unui element dat k. 
        ///  Daca elementul nu se gaseste in vector rezultatul va fi -1. 
        /// </summary>
        public static void _10()
        {
            string[] arrStr; int[] arr; int k, mid, min, max;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            Console.WriteLine("Tastati valoarea k:");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            min = 0;
            max = arr.Length - 1;

            while (min <= max)
            {
                mid = min + (max - min) / 2;
                if (k == arr[mid])
                {
                    Console.WriteLine($"Numarul {k} a fost gasit in vector la pozitia {mid}.");
                    return;
                }
                if (k > arr[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            Console.WriteLine($"Numarul {k} nu a fost gasit in vector.");
        }

        /// <summary>
        ///  Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau 
        ///  egale cu n (ciurul lui Eratostene). 
        /// </summary>
        public static void _11()
        {
            int n; int[] arr;

            Console.WriteLine("Tastati valoarea n:");
            n = int.Parse(Console.ReadLine());
            arr = new int[n + 1];

            for(int i = 0; i <= n; i++)
                arr[i] = i;

            for(int i = 2; i * i <= n; i++)
            {
                if (arr[i] != 0)
                {
                    for(int j = i * i; j <= n; j += i)
                        arr[j] = 0;
                }
            }
            for(int i = 2; i <= n; i++)
                if (arr[i] != 0)
                    Console.Write($"{arr[i]} ");
        }

        /// <summary>
        ///  Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
        /// </summary>
        public static void _12()
        {
            string[] arrStr; int[] arr; int min, temp;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            for(int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for(int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[min])
                        min = j;

                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            for(int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        ///  Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.
        /// </summary>
        public static void _13()
        {
            string[] arrStr; int[] arr;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            for (int i = 1; i < arr.Length; i++)
            {
                int currentVal = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > currentVal)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = currentVal;
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        ///  Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. 
        ///  (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - 
        ///  se va face o singura parcugere a vectorului). 
        /// </summary>
        public static void _14()
        {
            string[] arrStr; int[] arr; int temp, zeroPosition = 0;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    temp = arr[i];
                    arr[i] = arr[zeroPosition];
                    arr[zeroPosition] = temp;
                    zeroPosition++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        ///  Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 
        /// </summary>
        public static void _15()
        {
            string[] arrStr; List<int> arr;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new List<int>();

            for (int i = 0; i < arrStr.Length; i++)
                arr.Add(int.Parse(arrStr[i]));

            for(int i = 0; i < arr.Count - 1; i++)
                for(int j = i + 1; j < arr.Count; j++)
                    if (arr[i] == arr[j])
                        arr.RemoveAt(j);

            for (int i = 0; i < arr.Count; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        ///  Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
        /// </summary>
        public static void _16()
        {
            string[] arrStr; int[] arr; int cmmdc;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            cmmdc = arr[0];

            for(int i = 0; i < arr.Length; i++)
            {
                cmmdc = gcd(cmmdc, arr[i]);
                if(cmmdc == 1)
                    break;
            }
            Console.WriteLine($"Cel mai mare divizor comun al elementelor din vector, este {cmmdc}.");
        }

        public static int gcd(int a, int b)
        {
            int r;
            while (a % b > 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return b;
        }
    
        /// <summary>
        ///  Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si 
        ///  sa se afiseze numarul n in baza b.
        /// </summary>
        public static void _17()
        {
            int n, b, d; Stack<int> num = new Stack<int>();
            Console.WriteLine("Tastati un numar n in baza 10:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Tastati baza in care sa se converteasca numarul n:");
            b = int.Parse(Console.ReadLine());

            if(b > 16)
            {
                Console.WriteLine("Baza de conversie este prea mare.");
                return;
            }

            while(n > 0)
            {
                num.Push(n % b);
                n /= b;
            }

            while(num.Count > 0)
            {
                d = num.Pop();
                if(d < 10)
                    Console.Write(d);
                else
                {
                    switch (d)
                    {
                        case 10: Console.Write("A"); break;
                        case 11: Console.Write("B"); break;
                        case 12: Console.Write("C"); break;
                        case 13: Console.Write("D"); break;
                        case 14: Console.Write("E"); break;
                        case 15: Console.Write("F"); break;
                    }
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        ///  Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. 
        ///  Cel mai putin semnificativ coeficient este pe pozitia zero in vector. 
        ///  Se cere valoarea polinomului intr-un punct x.
        /// </summary>
        public static void _18()
        {
            string[] qStr; int[] q; double x, result = 0;
            Console.WriteLine("Tastati coeficientii polinomului, separandu i printr un spatiu:");
            qStr = Console.ReadLine().Split(' ');
            q = new int[qStr.Length];

            Console.WriteLine("Tastati punctul x:");
            Console.Write("x=");
            x = double.Parse(Console.ReadLine());

            for (int i = 0; i < qStr.Length; i++)
                q[i] = int.Parse(qStr[i]);

            for(int i = 0; i < q.Length; i++)
                result += q[i] * Math.Pow(x, i);

            Console.WriteLine($"{result}");
        }

        /// <summary>
        ///  Se da un vector s (vectorul in care se cauta) si un vector p 
        ///  (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. 
        ///  Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. 
        ///  (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 
        /// </summary>
        public static void _19()
        {
            string[] arrStr; int[] s, p; bool contains; int count = 0;
            Console.WriteLine("Tastati numerele vectorului s, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            s = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
                s[i] = int.Parse(arrStr[i]);

            Console.WriteLine("Tastati numerele vectorului p, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            p = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
                p[i] = int.Parse(arrStr[i]);

            for(int i = 0; i < s.Length - p.Length + 1; i++)
            {
                contains = true;
                if (s[i] == p[0])
                {
                    for(int j = 1, k = i + 1; j < p.Length; j++, k++) 
                    {
                        if (s[k] != p[j])
                        {
                            contains = false;
                            continue;
                        }
                    }
                    if(contains)
                        count++;
                }
            }
            if(count == 0)
                Console.WriteLine("Vectorul s nu contine vectorul p, in totalitate, niciodata.");
            else
                Console.WriteLine($"Vectorul p apare in vectorul s de {count} ori.");
        }

        /// <summary>
        ///  Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. 
        ///  Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt 
        ///  astfel incat margelele suprapuse au aceeasi culoare. 
        ///  Siragurile de margele se pot roti atunci cand le suprapunem. 
        /// </summary>
        public static void _20()
        {
            string[] arrStr; int[] s1, s2; int count = 0;
            Console.WriteLine("Tastati numerele vectorului s, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            s1 = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
                s1[i] = int.Parse(arrStr[i]);

            Console.WriteLine("Tastati numerele vectorului p, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            s2 = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
                s2[i] = int.Parse(arrStr[i]);



            Console.WriteLine($"Numarul de suprapuneri a unui sirag peste celalalt, este {count}.");
        }

        /// <summary>
        ///  Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica 
        ///  (care ar trebui sa apara primul in dictionar). 
        /// </summary>
        public static void _21()
        {
            string[] v1, v2;  int result;
            Console.WriteLine("Tastati elementele vectorului v1, separandu le printr un spatiu:");
            v1 = Console.ReadLine().Split(' ');

            Console.WriteLine("Tastati elementele vectorului v2, separandu le printr un spatiu:");
            v2 = Console.ReadLine().Split(' ');

            result = lexicographicOrder(v1, v2);

            printResult(result);
        }

        public static int lexicographicOrder(string[] v1, string[] v2)
        {
            int result = 0;
            for (int i = 0; i < v1.Length && i < v2.Length; i++)
            {
                for (int j = 0; j < v1[i].Length && j < v2[i].Length; j++)
                {
                    if ((int)v1[i][j] != (int)v2[i][j])
                    {
                        result = (int)v1[i][j] - (int)v2[i][j];
                        return result;
                    }
                }
                if (result == 0 && v1[i].Length != v2[i].Length)
                {
                    result = v1[i].Length - v2[i].Length;
                    return result;
                }
            }

            if (result == 0 && v1.Length != v2.Length)
            {
                result = v1.Length - v2.Length;
                return result;
            }
            return result;
        }

        public static void printResult(int result)
        {
            if (result < 0)
                Console.WriteLine("Din punct de vedere lexicografic, vectorul v1 este primul, urmat de v2.");
            else if (result > 0)
                Console.WriteLine("Din punct de vedere lexicografic, vectorul v2 este primul, urmat de v1.");
            else
                Console.WriteLine("Din punct de vedere lexicografic, vectorii sunt identici.");
        }

        /// <summary>
        ///  Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, 
        ///  si diferentele v1-v2 si v2-v1 
        ///  (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise 
        ///  o singura data in rezultat. 
        /// </summary>
        public static void _22()
        {
            List<string> v1 = new List<string>(), v2 = new List<string>();
            Console.WriteLine("Tastati elementele vectorului v1, separandu le printr un spatiu:");
            v1 = Console.ReadLine().Split(' ').ToList();

            Console.WriteLine("Tastati elementele vectorului v2, separandu le printr un spatiu:");
            v2 = Console.ReadLine().Split(' ').ToList();

            PrintMultimi(intersectia(v1, v2), 0);
            PrintMultimi(reuniune(v1, v2), 1);

            diferente(v1, v2);
        }

        private static void PrintMultimi(List<string>result, int type)
        {
            switch(type)
            {
                case 0:
                    Console.WriteLine("Intersectia dintre cei doi vectori este:");
                    break;
                case 1:
                    Console.WriteLine("Reuniunea dintre cei doi vectori este:");
                    break;
                case 2:
                    Console.WriteLine("Multimea diferentei V1 - V2 este:");
                    break;
                case 3:
                    Console.WriteLine("Multimea diferentei V2 - V1 este:");
                    break;
            }
            for (int i = 0; i < result.Count; i++)
                Console.Write($"{result[i]} ");
            Console.WriteLine();
        }
        
        public static List<string> intersectia(List<string> v1, List<string> v2)
        {
            List<string> result = new List<string>();
            List<string> smallest, largest;
            if (v1.Count >= v2.Count)
            {
                largest = v1;
                smallest = v2;
            }
            else
            {
                largest = v2;
                smallest = v1;
            }
            for (int i = 0; i < smallest.Count; i++)
                if (largest.Contains(smallest[i]) && !result.Contains(smallest[i]))
                    result.Add(smallest[i]);
            return result;
        }

        public static List<string> reuniune(List<string> v1, List<string> v2)
        {
            List<string> result = new List<string>();
            List<string> smallest, largest;
            if (v1.Count >= v2.Count)
            {
                largest = v1;
                smallest = v2;
            }
            else
            {
                largest = v2;
                smallest = v1;
            }

            for (int i = 0; i < largest.Count; i++)
            {
                if (!result.Contains(largest[i]))
                    result.Add(largest[i]);

                if (i < smallest.Count)
                    if (!result.Contains(smallest[i]))
                        result.Add(smallest[i]);
            }
            return result;
        }

        public static void diferente(List<string> v1, List<string> v2)
        {
            List<string> result1 = new List<string>();
            List<string> result2 = new List<string>();
            List<string> smallest, largest;

            if (v1.Count >= v2.Count)
            {
                largest = v1;
                smallest = v2;
            }
            else
            {
                largest = v2;
                smallest = v1;
            }

            for (int i = 0; i < largest.Count; i++)
            {
                if (!smallest.Contains(largest[i]) && !result1.Contains(largest[i]))
                    result1.Add(largest[i]);

                if (i < smallest.Count)
                    if (!largest.Contains(smallest[i]) && !result2.Contains(smallest[i]))
                        result2.Add(smallest[i]);
            }

            //sorting function added for the 23rd exercise
            PrintMultimi(SortIntegers(result1), 2);
            PrintMultimi(SortIntegers(result2), 3);
        }

        /// <summary>
        ///  Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2 
        ///  sunt in ordine strict crescatoare.
        /// </summary>
        /// NEINTELEGAND DIFERENTA DINTRE CERINTELE EXERCITIILOR 22 SI 23, AM FACUT O FUNCTIE DE SORTARE SI AM APLICAT O EXERCITIULUI 23..
        public static void _23()
        {
            List<string> v1 = new List<string>(), v2 = new List<string>();
            Console.WriteLine("Tastati elementele vectorului v1, separandu le printr un spatiu:");
            v1 = Console.ReadLine().Split(' ').ToList();

            Console.WriteLine("Tastati elementele vectorului v2, separandu le printr un spatiu:");
            v2 = Console.ReadLine().Split(' ').ToList();

            List<string> resultISorted = SortIntegers(intersectia(v1, v2));
            PrintMultimi(resultISorted, 0);
            List<string> resultRSorted = SortIntegers(reuniune(v1, v2));
            PrintMultimi(resultRSorted, 1);

            diferente(v1, v2);
        }

        private static List<string> SortIntegers(List<string> result)
        {
            List<int> sortingList = new List<int>();
            foreach (string str in result)
                sortingList.Add(int.Parse(str));
            sortingList.Sort();
            List<string> sortedList = new List<string>();
            foreach(int num in sortingList)
                sortedList.Add(num.ToString());
            return sortedList;
        }

        /// <summary>
        ///  Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca 
        ///  vectori cu valori binare 
        ///  (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
        /// </summary>
        public static void _24()
        {
            List<string> v1 = new List<string>(), v2 = new List<string>();
            Console.WriteLine("Tastati elementele vectorului v1, separandu le printr un spatiu:");
            v1 = Console.ReadLine().Split(' ').ToList();

            Console.WriteLine("Tastati elementele vectorului v2, separandu le printr un spatiu:");
            v2 = Console.ReadLine().Split(' ').ToList();

            Console.WriteLine("Intersectia dintre cei doi vectori este:");
            Console.WriteLine(intersectiaBin(v1, v2));
            Console.WriteLine("Reuniunea dintre cei doi vectori este:");
            Console.WriteLine(reuniuneBin(v1, v2));
            Console.WriteLine("Multimea diferentei V1 - V2 este:");
            Console.WriteLine(diferentaBin(v1, v2));
            Console.WriteLine("Multimea diferentei V2 - V1 este:");
            Console.WriteLine(diferentaBin(v2, v1));
        }

        private static int BinToDec(List<string> v)
        {
            string vStr = string.Join("", v);
            int num = Convert.ToInt32(vStr, 2);

            return num;
        }

        public static string intersectiaBin(List<string> v1, List<string> v2)
        {
            v1.Reverse();
            v2.Reverse();
            int num1 = BinToDec(v1);
            int num2 = BinToDec(v2);
            int num;
            if(num1 > num2)
                num = num1 & num2;
            else num = num2 & num1;
            string result = Convert.ToString(num, 2);
            char[] res = result.ToCharArray();
            Array.Reverse(res);

            return new string(res);
        }

        public static string reuniuneBin(List<string> v1, List<string> v2)
        {
            int num1 = BinToDec(v1);
            int num2 = BinToDec(v2);
            int num;
            if (num1 > num2)
                num = num1 | num2;
            else num = num2 | num1;

            string result = Convert.ToString(num, 2);
            char[] res = result.ToCharArray();
            Array.Reverse(res);

            return new string(res);
        }

        public static char[] diferentaBin(List<string> v1, List<string> v2)
        {
            int num1 = BinToDec(v1);
            int num2 = BinToDec(v2);
            int numXOR = num1 ^ num2;
            int numFin1 = numXOR & num1;

            string result1 = Convert.ToString(numFin1, 2);
            char[] res1 = result1.ToCharArray();
            Array.Reverse(res1);

            return res1;
        }

        /// <summary>
        ///  (Interclasare) Se dau doi vector sortati crescator v1 si v2. 
        ///  Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. 
        ///  Sunt permise elemente duplicate. 
        /// </summary>
        public static void _25()
        {
            string[] arrStr; List<int> v1 = new List<int>(), v2 = new List<int>(), v3 = new List<int>(); int v1Idx = 0, v2Idx = 0;
            Console.WriteLine("Tastati elementele vectorului v1, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            for (int i = 0; i < arrStr.Length; i++)
                v1.Add(int.Parse(arrStr[i]));

            Console.WriteLine("Tastati elementele vectorului v2, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            for(int i = 0; i < arrStr.Length; i++)
                v2.Add(int.Parse(arrStr[i]));

            for (int i = 0, j = 0; i < v1.Count && j < v2.Count;)
            {
                if (v1[i] <= v2[j])
                {
                    v3.Add(v1[i]);
                    i++;
                    v1Idx = i;
                }
                else
                {
                    v3.Add(v2[j]);
                    j++;
                    v2Idx = j;
                }
            }
            if(v1Idx == v1.Count)
                for (int j = v2Idx; j < v2.Count; j++)
                    v3.Add(v2[j]);
            else
                for (int i = v1Idx; i < v1.Count; i++)
                    v3.Add(v1[i]);

            for (int i = 0; i < v3.Count; i++)
                Console.Write($"{v3[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        ///  Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare 
        ///  sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). 
        ///  Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 
        /// </summary>
        public static void _26()
        {
            string arrStr; List<int> nr1 = new List<int>(), nr2 = new List<int>(), result = new List<int>(); int carry = 0, nrIdx = 0;
            Console.WriteLine("Tastati un numar foarte mare:");
            arrStr = Console.ReadLine();
            for (int i = arrStr.Length - 1; i >= 0; i--)
                nr1.Add(int.Parse(arrStr[i].ToString()));

            Console.WriteLine("Tastati un numar foarte mare:");
            arrStr = Console.ReadLine();
            for (int i = arrStr.Length - 1; i >= 0; i--)
                nr2.Add(int.Parse(arrStr[i].ToString()));

            for(int i = 0; i < nr1.Count && i < nr2.Count; i++)
            {
                nrIdx = i;
                if ((nr1[i] + nr2[i] + carry) < 10)
                {
                    result.Add(nr1[i] + nr2[i] + carry);
                    carry = 0;
                }
                else
                {
                    result.Add((nr1[i] + nr2[i] + carry) % 10);
                    carry = (nr1[i] + nr2[i] + carry) / 10;
                }
            }

            while(nrIdx < nr2.Count)
            {
                if ((nr2[nrIdx] + carry) < 10)
                {
                    result.Add(nr2[nrIdx] + carry);
                    carry = 0;
                }
                else
                {
                    result.Add((nr2[nrIdx] + carry) % 10);
                    carry = (nr2[nrIdx] + carry) / 10;
                }
                nrIdx++;
            }

            while (nrIdx < nr1.Count)
            {
                if ((nr1[nrIdx] + carry) < 10)
                {
                    result.Add(nr1[nrIdx] + carry);
                    carry = 0;
                }
                else
                {
                    result.Add((nr1[nrIdx] + carry) % 10);
                    carry = (nr1[nrIdx] + carry) / 10;
                }
                nrIdx++;
            }

            for (int i = result.Count - 1; i >= 0; i--)
                Console.Write($"{result[i]}");
            Console.WriteLine();
        }

        /// <summary>
        ///  Se da un vector si un index in vectorul respectiv. 
        ///  Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. 
        /// </summary>
        public static void _27()
        {
            string[] arrStr; int[] arr; int index;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            Console.WriteLine("Tastati pozitia din vector dorita sa se afle dupa sortare:");
            index = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            for(int i = 1; i < arr.Length; i++)
            {
                int currentVal = arr[i];
                int j = i - 1;
                while(j >= 0 && arr[j] > currentVal)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = currentVal;
            }

            Console.WriteLine($"Dupa sortare, valoare de pe pozitia {index}, este {arr[index]}");
        }

        /// <summary>
        ///  Quicksort. Sortati un vector folosind metoda QuickSort. 
        /// </summary>
        public static void _28()
        {
            string[] arrStr; int[] arr;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            quickSort(arr, 0, arr.Length - 1);
            
            for(int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        public static void swap(int[] arr, int j, int i)
        {
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }

        public static int partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int j = start - 1;
            for(int i = start; i < end; i++)
            {
                if (arr[i] < pivot)
                {
                    j++;
                    swap(arr, j, i);
                }
            }
            swap(arr, j + 1, end); return (j + 1);
        }

        public static void quickSort(int[] arr, int start, int end)
        {
            if(start < end)
            {
                int pivotIdx = partition(arr, start, end);

                quickSort(arr, start, pivotIdx - 1);
                quickSort(arr, pivotIdx + 1, end);
            }
        }

        /// <summary>
        ///  MergeSort. Sortati un vector folosind metoda MergeSort.
        /// </summary>
        public static void _29()
        {
            string[] arrStr; int[] arr;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            sort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        public static void merge(int[] arr, int min, int mid, int max)
        {
            int[] arrMin = new int[mid - min + 1]; 
            int[] arrMax = new int[max - mid];

            for(int k = 0; k < arrMin.Length; k++)
                arrMin[k] = arr[min + k];
            for(int l = 0; l < arrMax.Length; l++)
                arrMax[l] = arr[mid + 1 + l];

            int i = 0; int j = 0;
            int numIdx = min;
            while(i < arrMin.Length && j < arrMax.Length)
            {
                if (arrMin[i] <= arrMax[j])
                {
                    arr[numIdx] = arrMin[i];
                    i++;
                }
                else
                {
                    arr[numIdx] = arrMax[j];
                    j++;
                }
                numIdx++;
            }

            while(i < arrMin.Length)
            {
                arr[numIdx] = arrMin[i];
                i++; numIdx++;
            }
            while (j < arrMax.Length)
            {
                arr[numIdx] = arrMax[j];
                j++; numIdx++;
            }
        }

        public static void sort(int[] arr, int min, int max)
        {
            if(min < max) 
            {
                int mid = min + (max - min) / 2;

                sort(arr, min, mid);
                sort(arr, mid + 1, max);

                merge(arr, min, mid, max);
            }
        }
        /// <summary>
        ///  Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, 
        ///  unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. 
        ///  Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare 
        ///  iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 
        /// </summary>
        public static void _30()
        {
            string[] arrStr; int[] arr, pond; 
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            Console.WriteLine("Tastati ponderile fiecarui element din vectorul anterior:");
            arrStr = Console.ReadLine().Split(' ');
            pond = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                pond[i] = int.Parse(arrStr[i]);

            for (int i = 1; i < arr.Length; i++)
            {
                int currentVal = arr[i];
                int currentPond = pond[i];
                int j = i - 1;
                while (j >= 0 && (arr[j] > currentVal || (arr[j] == currentVal && pond[j] < currentPond)))
                {
                    arr[j + 1] = arr[j];
                    pond[j + 1] = pond[j];
                    j--;
                }
                arr[j + 1] = currentVal;
                pond[j + 1] = currentPond;
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        ///  (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate 
        ///  daca mai mult de n/2 din valorile vectorului sunt egale cu 
        ///  m(prin urmare, daca un vector are element majoritate acesta este unui singur).  
        ///  Sa se determine elementul majoritate al unui vector(daca nu exista atunci se va afisa<nu exista>). 
        ///  (incercati sa gasiti o solutie liniara).
        /// </summary>
        public static void _31()
        {
            string[] arrStr; int[] arr; int m = 0; Dictionary<int, int> dict = new Dictionary<int, int>(); bool hasM = false;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            arrStr = Console.ReadLine().Split(' ');
            arr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                arr[i] = int.Parse(arrStr[i]);

            for(int i = 0; i < arr.Length; i++)
                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], 0);

            for (int i = 0; i < arr.Length; i++)
            {
                dict[arr[i]]++;
                if (dict[arr[i]] >= (arr.Length / 2 + 1))
                {
                    m = arr[i];
                    hasM = true;
                    break;
                }
            }
            if (hasM)
                Console.WriteLine($"Vectorul are element majoritate, iar acesta este {m}.");
            else
                Console.WriteLine($"Vectorul nu are element majoritate.");
        }
    }
}
