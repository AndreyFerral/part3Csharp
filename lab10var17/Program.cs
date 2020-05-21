using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct ZNAK : IComparable
{
	public string fam;
	public string znak;
	public int[] bdate;
	public int CompareTo(Object obj)
	{
		ZNAK temp = (ZNAK)obj;
		return String.Compare(znak, temp.znak);
	}

};

namespace Lab10 {
    class lab10
    {
        static void Main(string[] args)
        {
			int n;
			Console.Write("Введите количество структур znak: ");
			while (!int.TryParse(Console.ReadLine(), out n)) 
				Console.WriteLine("Неверные данные!");			
			ZNAK[] znak = new ZNAK[n];

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(i + 1); Console.Write("1) Введите фамилию и инициалы: "); znak[i].fam = Console.ReadLine();
				Console.Write("2) Введите знак зодиака: "); znak[i].znak = Console.ReadLine();
				Console.Write("3) Введите дату рождения: ");
				znak[i].bdate = new int[3];
				while (!int.TryParse(Console.ReadLine(), out znak[i].bdate[0])) Console.WriteLine("Неверные данные!");
				Console.Write("4) Введите месяц рождения: ");
				while (!int.TryParse(Console.ReadLine(), out znak[i].bdate[1])) Console.WriteLine("Неверные данные!");
				Console.Write("5) Введите год рождения: ");
				while (!int.TryParse(Console.ReadLine(), out znak[i].bdate[2])) Console.WriteLine("Неверные данные!");			
			}
			Console.WriteLine();

			Array.Sort(znak);
			Console.WriteLine("Записи упорядоченные по знаку зодиака:\n");
			foreach(ZNAK i in znak)
			{
				Console.WriteLine("Фамилия и инициалы: " + i.fam);
				Console.WriteLine("Знак зодиака: " + i.znak);
				Console.WriteLine("День рождения: " + i.bdate[0]);
				Console.WriteLine("Месяц рождения: " + i.bdate[1]);
				Console.WriteLine("Год рождения: " + i.bdate[2] + "\n");
			}

			Console.Write("\nИнформации о людях рожденных в введеный месяц\n");
			while (true)
			{
				Console.Write("Введите месяц рождения или 0 для окончания:\n");
				int Month;
				while (!int.TryParse(Console.ReadLine(), out Month))
					Console.WriteLine("Неверные данные!");
				if (0 == Month) break;

				bool not_found = false;
				for (int i = 0; i < n; i++) {
					if (znak[i].bdate[1] == Month)	{
						Console.WriteLine("Фамилия и инициалы: " + znak[i].fam);
						Console.WriteLine("Знак зодиака: " + znak[i].znak);
						Console.WriteLine("День рождения: " + znak[i].bdate[0]);
						Console.WriteLine("Месяц рождения: " + znak[i].bdate[1]);
						Console.WriteLine("Год рождения: " + znak[i].bdate[2] + "\n");
						not_found = true;
					}
				}
				Console.WriteLine();
				if (not_found == false) Console.WriteLine("Таких работников нет!\n");
			}			
		}
	}
}
