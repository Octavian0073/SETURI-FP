﻿using System;
using System.Collections.Generic;
using System.Linq;
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

            for (int i = 0 ; i < num.Length; i++)
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
            if(nuApare)
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
                if(max == num[i])
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
            num = new int[numereStr.Length+1];

            Console.WriteLine("Tastati valoarea numarului de insertat:");
            e = int.Parse(Console.ReadLine());

            Console.WriteLine("Tastati pozitia unde sa fie insertat:");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < numereStr.Length+1; i++)
            {
                if(i == k)
                {
                    num[k] = e;
                    isInserted = true;
                    continue;
                }
                if(isInserted)
                {
                    num[i] = int.Parse(numereStr[i-1]);
                } 
                else
                {
                    num[i] = int.Parse(numereStr[i]);
                }
            }

            for(int i = 0; i < num.Length; i++)
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
            string[] numereStr; int[] num; int k;
            Console.WriteLine("Tastati numerele vectorului, separandu le printr un spatiu:");
            numereStr = Console.ReadLine().Split(' ');
            num = new int[numereStr.Length];

            Console.WriteLine("Tastati pozitia de sters:");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < numereStr.Length; i++)
            {
                if (i == k)
                {
                    num.
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
        /// Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. 
        /// Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        /// </summary>
        public static void _7()
        {


        }

        /// <summary>
        /// Rotire. Se da un vector cu n elemente. 
        /// Rotiti elementele vectorului cu o pozitie spre stanga. 
        /// Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
        /// </summary>
        public static void _8()
        {

        }

        /// <summary>
        /// Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
        /// </summary>
        public static void _9()
        {

        }

        /// <summary>
        /// Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. 
        /// Se cere sa se determine pozitia unui element dat k. 
        /// Daca elementul nu se gaseste in vector rezultatul va fi -1. 
        /// </summary>
        public static void _10()
        {

        }

        /// <summary>
        /// Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau 
        /// egale cu n (ciurul lui Eratostene). 
        /// </summary>
        public static void _11()
        {

        }

        /// <summary>
        /// Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
        /// </summary>
        public static void _12()
        {

        }

        /// <summary>
        /// Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.
        /// </summary>
        public static void _13()
        {

        }

        /// <summary>
        /// Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. 
        /// (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - 
        /// se va face o singura parcugere a vectorului). 
        /// </summary>
        public static void _14()
        {

        }

        /// <summary>
        /// Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 
        /// </summary>
        public static void _15()
        {

        }

        /// <summary>
        /// Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
        /// </summary>
        public static void _16()
        {

        }

        /// <summary>
        /// Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si 
        /// sa se afiseze numarul n in baza b.
        /// </summary>
        public static void _17()
        {

        }

        /// <summary>
        /// Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. 
        /// Cel mai putin semnificativ coeficient este pe pozitia zero in vector. 
        /// Se cere valoarea polinomului intr-un punct x.
        /// </summary>
        public static void _18()
        {

        }

        /// <summary>
        /// Se da un vector s (vectorul in care se cauta) si un vector p 
        /// (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. 
        /// Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. 
        /// (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 
        /// </summary>
        public static void _19()
        {

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
