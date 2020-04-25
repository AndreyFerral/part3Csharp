using System;
using System.Dynamic;
using System.Linq;
using System.Collections;

namespace lab8var17 {
    class Program {			
        
        class Tovar {
            public string nameTovar;
            public string nameMagaz;
            public int costTovar = 0;

            public void GetTovar()
            {
                Console.WriteLine("\tНазвание товара: " + nameTovar);
                Console.WriteLine("\tНазвание магазина: " + nameMagaz);
                Console.WriteLine("\tСтоимость товара: " + costTovar + " руб" + "\n");
            }
            public Tovar() {
                nameTovar = "";
                nameMagaz = "";
                costTovar = 0;
            }
            public Tovar(string nameT, string nameM, int cost) : this()
            {
                nameTovar = nameT;
                nameMagaz = nameM;
                costTovar = cost;
            }

            public int GetCost()
            {
                return costTovar;
            }
            public class SortByCost : IComparer //
            {
                int IComparer.Compare(object ob1, object ob2)
                {
                    Tovar ml = (Tovar)ob1;
                    Tovar m2 = (Tovar)ob2;
                    if (ml.costTovar > m2.costTovar) return 1;
                    if (ml.costTovar < m2.costTovar) return -1;
                    return 0;
                }
            } // сортировка по цене
            public class SortByNameT : IComparer //
            {
                int IComparer.Compare(object ob1, object ob2)
                {
                    Tovar ml = (Tovar)ob1;
                    Tovar m2 = (Tovar)ob2;
                    return String.Compare(ml.nameTovar, m2.nameTovar);
                }
            } // сортировка по товару
            public class SortByNameM : IComparer //
            {
                int IComparer.Compare(object ob1, object ob2)
                {
                    Tovar ml = (Tovar)ob1;
                    Tovar m2 = (Tovar)ob2;
                    return String.Compare(ml.nameMagaz, m2.nameMagaz);
                }
            } // сортировка по магазину

            public static string operator +(Tovar obj, Tovar obj1)
            {
                int sum = obj.costTovar + obj1.costTovar;
                return sum + " руб";
            }
        }

        class Sklad
        {
            private Tovar[] tovar;
            private int length = 0;
            public Sklad(Tovar[] x)
            {
                tovar = new Tovar[x.Length];
                for (int i = 0; i < x.Length; i++)
                {
                    tovar[i] = x[i];
                }
                length = x.Length;
            }
            public int Length
            {
                get { return length; }
            }
            public void OutputElements()
            {
                for (int i = 0; i < tovar.Length; i++)
                {
                    tovar[i].GetTovar(); 
                }
            }
            public Tovar FindID(int id1)
            { 
                return tovar[id1-1]; 
            }          
            public Tovar this[int i] 
            {
                get { return tovar[i]; }
                set { tovar[i] = value; }
            }// индексатор
            public void FindTovar(string name) 
            {
                bool proverka = false;
                for (int i = 0; i < tovar.Length; i++)
                {
                    if (tovar[i].nameTovar == name)
                    {
                        Console.WriteLine("Товар найден! Информация о товаре: ");
                        tovar[i].GetTovar();
                        proverka = true;
                    }
                }
                if (!proverka) Console.WriteLine("Товар не найден!");
            } // Найти товар по названию
            public void SortCost()
            {
                Console.WriteLine("Сортировка по цене товара:");
                Array.Sort(tovar, new Tovar.SortByCost());
            } // сортировка по цене
            public void SortNameT()
            {
                Console.WriteLine("Сортировка по названию товара:");
                Array.Sort(tovar, new Tovar.SortByNameT());
            } // сортировка по товару
            public void SortNameM()
            {
                Console.WriteLine("Сортировка по названию магазина:");
                Array.Sort(tovar, new Tovar.SortByNameM());
            } // сортировка по магазину
        }




        static void Main(string[] args) {

            Sklad sklad = new Sklad(new Tovar[] { 
                new Tovar("Капуста", "Магазин2", 151), 
                new Tovar("Морковь", "Магазин1", 1), 
                new Tovar("Лук", "Магазин3", 51) 
            });
            Console.WriteLine("Вывести все элементы");
            sklad.OutputElements();

            Console.WriteLine("Найти товар с id1");
            sklad.FindID(1).GetTovar();

            Console.WriteLine("Найти товар с названием `Капуста` и `Отсутствует`");
            sklad.FindTovar("Капуста"); 
            sklad.FindTovar("Отсутствует");

            Console.WriteLine("Сортировка: ");
            sklad.OutputElements();
            sklad.SortNameM();
            sklad.OutputElements();

            sklad.SortNameT();
            sklad.OutputElements();

            sklad.SortCost();
            sklad.OutputElements();

            Console.WriteLine("Перегруженный оператор + \nСложение 2го и 3го товара: ");
            Console.WriteLine("\t"+(sklad[1] + sklad[2]));
            Console.WriteLine("Сложение 1го и 3го товара: ");
            Console.WriteLine("\t" + (sklad[0] + sklad[2]));
        }
    }
}
