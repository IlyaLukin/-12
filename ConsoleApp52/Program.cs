using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    class Program
    {
        public static Random rnd = new Random();
        public static int count1 = 0, count2 = 0, count11 = 0, count22 = 0;
        static void InputSort(int[] array)
        {
            count1 = 0;
            count11 = 0;
            for (int j = 1; j < array.Length; j++)
            {
                int k = array[j];
                int i = j - 1;
                while (i >= 0 && array[i] > k)
                {
                    array[i + 1] = array[i];
                    i--;
                    count1++;
                    count11++;
                }
                array[i + 1] = k;
            }
        }

        static void CountingSort(int[] array)
        {
            count2 = 0;
            count22 = 0;
            int maxValue = array.Max<int>();
            int[] c = new int[maxValue + 1];
            for (int i = 1; i < array.Length + 1; i++)
            {
                c[array[i - 1]]++;
            }
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 0) c[i] = -1;
                else continue;
            }
            int j = 0;
            for (int i = 0; i < c.Length; i++)
            {
                do
                {
                    if (c[i] == -1) continue;
                    else
                    {
                        array[j] = i;
                        c[i]--;
                        j++;
                        count22++;
                    }
                    count2++;
                } while (c[i] > 0);
            }

        }
        static void print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void print(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void makeRand(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
            }
        }
        static void print1(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
          
            print("Сортирвока методом вставки");
            int[] array1 = { 10, 20, 30, 40, 50 };
            int[] array2 = { -9, 8, 7, 6, -5, 4, -3, 2, 1, 0 };
            int[] array3 = new int[10];
            makeRand(array3);
           
            print1("Массив 1: Упорядоченный по возрастанию");
                            print(array1);
                            print1("Массив 1: После сортировки вставкой");
                            InputSort(array1);
                            print(array1);
                            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {count1}");
                            Console.WriteLine($"Количество пересылок в 1-ой сортировке = {count11}");
                          

                     
                            print1("\nМассив 2: Упорядоченный по убыванию");
                            print(array2);
                            print1("Массив 2: После сортировки вставкой");
                            InputSort(array2);
                            print(array2);
                            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {count1}");
                            Console.WriteLine($"Количество пересылок в 1-ой сортировке = {count11}");
                           

                      
                            print1("\nМассив 3: Не упорядоченный");
                            print(array3);
                            print1("Массив 3: После сортировки вставкой");
                            InputSort(array3);
                            print(array3);
                            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {count1}");
                            Console.WriteLine($"Количество пересылок в 1-ой сортировке = {count11}");
            
                    
                    print("\nСортирвока методом подсчёта");
                    int[] array4 = { 10, 20, 30, 40, 50 };
                    int[] array5 = { 8, 7, 1, 0 };
                    int[] array6 = new int[10];
                    makeRand(array6);

                            print1("Массив 1: Упорядоченный по возрастанию");
                            print(array4);
                            print1("Массив 1: После сортировки подсчета");
                            CountingSort(array4);
                            print(array4);
                            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {count2}");
                            Console.WriteLine($"Количество пересылок в 1-ой сортировке = {count22}");
                     
                            print1("\nМассив 2: Упорядоченный по убыванию");
                            print(array5);
                            print1("Массив 2: После сортировки подсчета");
                            CountingSort(array5);
                            print(array5);
                            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {count2}");
                            Console.WriteLine($"Количество пересылок в 1-ой сортировке = {count22}");
                      
                            print1("\nМассив 3: Не упорядоченный");
                            print(array6);
                            print1("Массив 3: После сортировки подсчета");
                            CountingSort(array6);
                            print(array6);
                            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {count2}");
                            Console.WriteLine($"Количество пересылок в 1-ой сортировке = {count22}");
            Console.ReadKey();
                   
        }

    }

     
}

