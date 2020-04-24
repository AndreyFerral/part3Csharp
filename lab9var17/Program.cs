using System;
using System.Collections;
namespace ConsoleApplicationl {
class Monster {
        public Monster(int health, int ammo, string name)
        {
            this.health = health; 
            this.ammo = ammo;
        }
        public int Ammo
        {
            get { return ammo; }
            set { if (value > 0) ammo = value;
            else ammo = 0;
            }
        }
        public string Name
        {
        get { return name; }
        }
        
        virtual public void Passport()
            { 
            Console.WriteLine("Monster {0} \t health = {1} ammo = {2}", name, health, ammo ); 
        }
        public class SortByName : IComparer //
        {
            int IComparer.Compare(object obi, object ob2)
            {
                Monster ml = (Monster)obi;
                Monster m2 = (Monster)ob2;
                return String.Compare(ml.Name, m2.Name);
            }
        }
        public class SortByAmmo : IComparer //
        {
            int IComparer.Compare(object obi, object ob2)
            {
                Monster ml = (Monster)obi;
                Monster m2 = (Monster)ob2;
                if(ml.Ammo > m2.Ammo) return 1;
                if(ml.Ammo<m2.Ammo) return -1;
                return 0;
            }
        }

        string name;
        int health, ammo;
}



    class Classl
    {
        static void Main()
            {
            const int n = 3;
            Monster[] stado = new Monster[n];
            stado[0] = new Monster( 50, 50, "Вася" );
            stado[1] = new Monster( 80, 80, "Петя" );
            stado[2] = new Monster( 40, 10, "Маша" );

            Console.WriteLine( "Сортировка по имени:" );
            Array.Sort(stado, new Monster.SortByName() );
            foreach (Monster elem in stado ) elem.Passport();

            Console.WriteLine( "Сортировка по вооружению:" );
            Array.Sort(stado, new Monster.SortByAmmo() );
            foreach (Monster elem in stado ) elem.Passport();
        }
    }
}