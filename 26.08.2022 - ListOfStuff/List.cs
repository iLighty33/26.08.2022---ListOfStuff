using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._08._2022___ListOfStuff
{
    internal class List
    {
        private int v;

        string Vvod(string text)
        {
            Console.Write(text);
            return Console.ReadLine();

        }

        public static int Vvod_quantity(string text)
        {
            try
            {
                Console.Write(text);
                return int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Вы ввели что-то не то, попробуйте заново.");
                return Vvod_quantity(text);
            }

        }


        public List(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public List(int v)
        {
            this.v = v;
        }

        public int Id { get; set; }

        public string Name { get; set; }


    }
}



