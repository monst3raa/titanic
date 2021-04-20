using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Titanic
{
    class asd
    {
        public string knév { get; set; }
        public int eltűnt { get; set; }
        public int túlélő { get; set; }

        public asd(string s)
        {
            knév = s.Split(';')[0]; 
            túlélő = int.Parse(s.Split(';')[1]);
            eltűnt = int.Parse(s.Split(';')[2]);
        }
       
    }
    class titanic
    {
        static void Main(string[] args)
        {
            List<Titanic> titanic = new List<Titanic>();
            var sr = new StreamReader(@"titanic1", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                titanic.Add(new Titanic(sr.ReadLine()));
            }
            Console.WriteLine("2. feladat: {0} db", titanic.Length);

            int utasokszáma = 0;
            foreach (var i in Titanic) utasokszáma += i.upk;
            Console.WriteLine("3. feladat: {0} fő", utasokszáma);
        }
    }
}
