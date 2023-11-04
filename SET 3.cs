using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FP_SETURI
{
    internal class SET_3
    {
        /// <summary>
        /// Calculati suma elementelor unui vector de n numere citite de la tastatura. 
        /// Rezultatul se va afisa pe ecran.
        /// </summary>
        public static void _1()
        {
            string[] numereStr; int[] num; int sum = 0;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            for (int i = 0; i < numereStr.Length; i++)
            {
                num[i] = int.Parse(numereStr[i]);
            }

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine($"Suma numerelor din vector este {sum}.");
        }

        /// <summary>
        /// Se da un vector cu n elemente si o valoare k. 
        /// Se cere sa se determine prima pozitie din vector pe care apare k. 
        /// Daca k nu apare in vector rezultatul va fi -1.
        /// </summary>
        public static void _2()
        {
            string[] numereStr; int[] num; int k, position; bool nuApare = true;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            Console.WriteLine("Tastati valoarea k:");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < numereStr.Length; i++)
            {
                num[i] = int.Parse(numereStr[i]);
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == k)
                {
                    position = i;
                    nuApare = false;
                    Console.WriteLine($"Numarul {k} se afla pe pozitia {position} in vector.");
                    break;
                }
            }
            if (nuApare)
            {
                Console.WriteLine($"Numarul {k} nu a fost gasit in vector.");
            }
        }

        /// <summary>
        /// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. 
        /// Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).
        /// </summary>
        public static void _3()
        {
            string[] numereStr; int[] num; int max = 0, min = 0, minPos = 0, maxPos = 0;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            for (int i = 0; i < numereStr.Length; i++)
            {
                num[i] = int.Parse(numereStr[i]);
            }
            min = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                    maxPos = i;
                }
                if (num[i] < min)
                {
                    min = num[i];
                    minPos = i;
                }
            }
            Console.WriteLine($"Pozitiile la care se afla cel mai mic numar {min} si cel mai mare numar {max}, sunt {minPos}, respectiv {maxPos}.");
        }

        /// <summary>
        /// Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si 
        /// de cate ori apar acestea. 
        /// </summary>
        public static void _4()
        {
            string[] numereStr; int[] num; int max = 0, min, minPresent = 0, maxPresent = 0;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            for (int i = 0; i < numereStr.Length; i++)
            {
                num[i] = int.Parse(numereStr[i]);
            }
            min = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (max == num[i])
                {
                    maxPresent++;
                }
                if (min == num[i])
                {
                    minPresent++;
                }
                if (num[i] > max)
                {
                    max = num[i];
                    maxPresent = 1;
                }
                if (num[i] < min)
                {
                    min = num[i];
                    minPresent = 1;
                }
            }
            Console.WriteLine($"Cel mai mic numar {min} si cel mai mare numar {max} si apar de {minPresent} ori, respectiv {maxPresent} ori.");
        }

        /// <summary>
        /// Se da un vector cu n elemente, o valoare e si o pozitie din vector k. 
        /// Se cere sa se insereze valoarea e in vector pe pozitia k. 
        /// Primul element al vectorului se considera pe pozitia zero. 
        /// </summary>
        public static void _5()
        {
            string[] numereStr; int[] num; int e, k; bool isInserted = false;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length + 1];

            Console.WriteLine("Tastati valoarea numarului de insertat:");
            e = int.Parse(Console.ReadLine());

            Console.WriteLine("Tastati pozitia unde sa fie insertat:");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < numereStr.Length + 1; i++)
            {
                if (i == k)
                {
                    num[k] = e;
                    isInserted = true;
                    continue;
                }
                if (isInserted)
                {
                    num[i] = int.Parse(numereStr[i - 1]);
                }
                else
                {
                    num[i] = int.Parse(numereStr[i]);
                }
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Se da un vector cu n elemente si o pozitie din vector k. 
        /// Se cere sa se stearga din vector elementul de pe pozitia k. 
        /// Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
        /// </summary>
        public static void _6()
        {
            string[] numereStr; int[] num; int k; bool isDeleted = false;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length - 1];

            Console.WriteLine("Tastati pozitia de sters:");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < numereStr.Length; i++)
            {
                if (i == k)
                {
                    isDeleted = true;
                    continue;
                }
                if (isDeleted)
                {
                    num[i - 1] = int.Parse(numereStr[i]);
                }
                else
                {
                    num[i] = int.Parse(numereStr[i]);
                }
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. 
        /// Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        /// </summary>
        public static void _7()
        {
            string[] numereStr; int[] num;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            for (int i = numereStr.Length - 1, j = 0; i >= 0; i--, j++)
            {
                num[j] = int.Parse(numereStr[i]);
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Rotire. Se da un vector cu n elemente. 
        /// Rotiti elementele vectorului cu o pozitie spre stanga. 
        /// Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
        /// </summary>
        public static void _8()
        {
            string[] numereStr; int[] num; int last;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            last = int.Parse(numereStr[0]);

            for (int i = 0; i < numereStr.Length - 1; i++)
            {
                num[i] = int.Parse(numereStr[i + 1]);
            }
            num[num.Length - 1] = last;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
        /// </summary>
        public static void _9()
        {
            string[] numereStr; int[] num, temp; int k;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            Console.WriteLine("Tastati cu cate pozitii sa se mute la stanga vectorul:");
            k = int.Parse(Console.ReadLine());

            temp = new int[k];

            for (int i = 0; i < k; i++)
            {
                temp[i] = int.Parse(numereStr[i]);
            }
            for (int i = 0, j = k; i < numereStr.Length - k; i++, j++)
            {
                num[i] = int.Parse(numereStr[j]);
            }
            for (int i = numereStr.Length - k, j = 0; i < numereStr.Length; i++, j++)
            {
                num[i] = temp[j];
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. 
        /// Se cere sa se determine pozitia unui element dat k. 
        /// Daca elementul nu se gaseste in vector rezultatul va fi -1. 
        /// </summary>
        public static void _10()
        {
            string[] numereStr; int[] num; int k, mid, min, max;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            Console.WriteLine("Tastati valoarea k:");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < numereStr.Length; i++)
            {
                num[i] = int.Parse(numereStr[i]);
            }

            min = 0;
            max = num.Length - 1;

            while (min <= max)
            {
                mid = min + (max - min) / 2;

                if (k == num[mid])
                {
                    Console.WriteLine($"Numarul {k} a fost gasit in vector la pozitia {mid}.");
                    return;
                }
                if (k > num[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            Console.WriteLine($"Numarul {k} nu a fost gasit in vector.");
        }

        /// <summary>
        /// Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau 
        /// egale cu n (ciurul lui Eratostene). 
        /// </summary>
        public static void _11()
        {
            int n; int[] num;

            Console.WriteLine("Tastati valoarea n:");
            n = int.Parse(Console.ReadLine());
            num = new int[n + 1];

            for(int i = 0; i <= n; i++)
            {
                num[i] = i;
            }

            for(int i = 2; i * i <= n; i++)
            {
                if (num[i] != 0)
                {
                    for(int j = i * i; j <= n; j += i)
                    {
                        num[j] = 0;
                    }
                }
            }
            for(int i = 2; i <= n; i++)
            {
                if (num[i] != 0)
                {
                    Console.Write($"{num[i]} ");
                }
            }
        }

        /// <summary>
        /// Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
        /// </summary>
        public static void _12()
        {
            string[] numereStr; int[] num; int min, temp;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            for (int i = 0; i < numereStr.Length; i++)
            {
                num[i] = int.Parse(numereStr[i]);
            }

            for(int i = 0; i < num.Length - 1; i++)
            {
                min = i;
                for(int j = i + 1; j < num.Length; j++)
                {
                    if (num[j] < num[min])
                    {
                        min = j;
                    }
                }
                temp = num[i];
                num[i] = num[min];
                num[min] = temp;
            }

            for(int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
        }

        /// <summary>
        /// Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.
        /// </summary>
        public static void _13()
        {
            string[] numereStr; int[] num; int temp;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            for (int i = 0; i < numereStr.Length; i++)
            {
                num[i] = int.Parse(numereStr[i]);
            }

            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] > num[i + 1])
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (num[j - 1] > num[j])
                        {
                            temp = num[j - 1];
                            num[j - 1] = num[j];
                            num[j] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
        }

        /// <summary>
        /// Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. 
        /// (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - 
        /// se va face o singura parcugere a vectorului). 
        /// </summary>
        public static void _14()
        {
            string[] numereStr; int[] num; int temp, last;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            for (int i = 0; i < numereStr.Length; i++)
            {
                num[i] = int.Parse(numereStr[i]);
            }
            last = num.Length - 1;

            for(int i = 0; i < num.Length; i++)
            {

            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
        }

        /// <summary>
        /// Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 
        /// </summary>
        public static void _15()
        {
            string[] numereStr; List<int> num;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new List<int>();

            for (int i = 0; i < numereStr.Length; i++)
            {
                num.Add(int.Parse(numereStr[i]));
            }

            for(int i = 0; i< num.Count - 1; i++)
            {
                for(int j = i + 1; j < num.Count; j++)
                {
                    if (num[i] == num[j])
                    {
                        num.RemoveAt(j);
                    }
                }
            }

            for (int i = 0; i < num.Count; i++)
            {
                Console.Write($"{num[i]} ");
            }
        }

        /// <summary>
        /// Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
        /// </summary>
        public static void _16()
        {
            string[] numereStr; int[] num; int cmmdc;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            for (int i = 0; i < numereStr.Length; i++)
            {
                num[i] = int.Parse(numereStr[i]);
            }

            cmmdc = num[0];

            for(int i = 0; i < num.Length; i++)
            {
                cmmdc = gcd(cmmdc, num[i]);

                if(cmmdc == 1)
                {
                    break;
                }
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
        /// Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si 
        /// sa se afiseze numarul n in baza b.
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
                {
                    Console.Write(d);
                }
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
        /// Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. 
        /// Cel mai putin semnificativ coeficient este pe pozitia zero in vector. 
        /// Se cere valoarea polinomului intr-un punct x.
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
            {
                q[i] = int.Parse(qStr[i]);
            }

            for(int i = 0; i < q.Length; i++)
            {
                result += q[i] * Math.Pow(x, i);
            }

            Console.WriteLine($"{result}");
        }

        /// <summary>
        /// Se da un vector s (vectorul in care se cauta) si un vector p 
        /// (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. 
        /// Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. 
        /// (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 
        /// </summary>
        public static void _19()
        {
            string[] numereStr; int[] s, p; bool contains; int count = 0;
            Console.WriteLine("Tastati numerele vectorului s, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            s = new int[numereStr.Length];
            for (int i = 0; i < numereStr.Length; i++)
            {
                s[i] = int.Parse(numereStr[i]);
            }

            Console.WriteLine("Tastati numerele vectorului p, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            p = new int[numereStr.Length];
            for (int i = 0; i < numereStr.Length; i++)
            {
                p[i] = int.Parse(numereStr[i]);
            }

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
                    {
                        count++;
                    }
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Vectorul s nu contine vectorul p, in totalitate, niciodata.");
            }
            else
            {
                Console.WriteLine($"Vectorul p apare in vectorul s de {count} ori.");
            }
        }

        /// <summary>
        /// Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. 
        /// Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt 
        /// astfel incat margelele suprapuse au aceeasi culoare. 
        /// Siragurile de margele se pot roti atunci cand le suprapunem. 
        /// </summary>
        public static void _20()
        {

        }

        /// <summary>
        /// Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica 
        /// (care ar trebui sa apara primul in dictionar). 
        /// </summary>
        public static void _21()
        {

        }

        /// <summary>
        /// Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, 
        /// si diferentele v1-v2 si v2 -v1 
        /// (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise 
        /// o singura data in rezultat. 
        /// </summary>
        public static void _22()
        {

        }

        /// <summary>
        /// Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2 
        /// sunt in ordine strict crescatoare.
        /// </summary>
        public static void _23()
        {

        }

        /// <summary>
        /// Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca 
        /// vectori cu valori binare 
        /// (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
        /// </summary>
        public static void _24()
        {

        }

        /// <summary>
        /// (Interclasare) Se dau doi vector sortati crescator v1 si v2. 
        /// Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. 
        /// Sunt permise elemente duplicate. 
        /// </summary>
        public static void _25()
        {

        }

        /// <summary>
        /// Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare 
        /// sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). 
        /// Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 
        /// </summary>
        public static void _26()
        {

        }

        /// <summary>
        ///  Se da un vector si un index in vectorul respectiv. 
        ///  Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. 
        /// </summary>
        public static void _27()
        {

        }

        /// <summary>
        /// Quicksort. Sortati un vector folosind metoda QuickSort. 
        /// </summary>
        public static void _28()
        {

        }

        /// <summary>
        /// MergeSort. Sortati un vector folosind metoda MergeSort.
        /// </summary>
        public static void _29()
        {

        }

        /// <summary>
        /// Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, 
        /// unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. 
        /// Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare 
        /// iar pentru doua valori egale din E, 
        /// cea cu pondere mai mare va fi prima. 
        /// </summary>
        public static void _30()
        {

        }

        /// <summary>
        /// 
        ///(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate 
        ///daca mai mult de n/2 din valorile vectorului sunt egale cu 
        /// m(prin urmare, daca un vector are element majoritate acesta este unui singur).  
        /// Sa se determine elementul majoritate al unui vector(daca nu exista atunci se va afisa<nu exista>). 
        /// (incercati sa gasiti o solutie liniara).
        /// </summary>
        public static void _31()
        {

        }
    }
}
