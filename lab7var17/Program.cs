using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7var17
{
    class Program
    {
		static void Main(string[] args)
		{
			string word, line;
			Console.WriteLine("Введите слово для поиска: ");
			word = Console.ReadLine();
			StreamReader fin = new StreamReader("text.txt");
			int count = 0;
			while (!fin.EndOfStream)
			{
				int index = 0;
				line = fin.ReadLine();
				Console.WriteLine(line);
				while (true)
				{
					index = line.IndexOf(word, index);
					if (index != -1)
					{
						if (!char.IsLetter(line, index-1) && !char.IsLetter(line, index+word.Length)) 
						count++;
						index++;
					}
					else {
						break;
					}
					
				}
				Console.WriteLine("Кол-во найденного слова:" + count + "\n");
				count = 0;
			}
			Console.ReadLine();
		}
	}

}