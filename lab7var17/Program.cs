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
			try
			{
				StreamReader sw = new StreamReader("text.txt");
				char[] buf = sw.ReadToEnd().ToCharArray();
				string str = "that";
				char[] word = str.ToCharArray();
				bool first = true;
				for (int i = 0, n = 0; i < buf.Length; ++i)
				{
					if (buf[i] == '.' || buf[i] == '!' || buf[i] == '?') {
						for (int j = first ? n + 1 : n; j <= i; ++j) {
							first = false;
							Console.Write(buf[j]);
							n = i + 1;
							
						}
						
						Console.WriteLine("");
						Console.WriteLine("secur");
					if (buf[i] == word[i]) { Console.WriteLine("secur sdfdsfsd"); }
					}
				}
				sw.Close();
			}
			catch (Exception ex) { Console.WriteLine(ex.Message); };
			Console.ReadKey();
		}
	}

}