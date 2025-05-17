using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net.Configuration;
namespace facemsoft2
{
    class Program
    {class Persoana
        {
            int id;
            string nume;
            DateTime data_nasterii;

            public int Id { get => id; set => id = value; }
            public string Nume { get => nume; set => nume = value; }
            public DateTime Data_nasterii { get => data_nasterii; set => data_nasterii = value; }
        }
        static void Main(string[] args)
        {
            int[] v = new int[5];
            for(int i=0;i<v.Length;i++)
            {
                Console.Write("v[{0}]=", i);
                v[i] =Int32.Parse( Console.ReadLine());
            }
            Array.Sort(v);
            foreach(int x in v)
                Console.Write("{0}; ",x);
            Console.ReadLine();
            int[,] m = new int[2, 5];
            int[] w = new int[7];
            v.CopyTo(w, 2);//
            foreach (int x in w)
                Console.Write("{0}; ", x);
            int k = 0;
            foreach(var x in v)
            {
                m[0, k] = x;
                m[1, k] = -x;
                k++;
            }
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write("{0} ", m[i, j]);
                }
                Console.WriteLine();
            }
            Persoana[] vector_pers = new Persoana[5];
             k = 0;
            foreach(int x in v)
            {
                vector_pers[k] = new Persoana();
                vector_pers[k].Id = x;
                Console.WriteLine("Numele pt id ul {0}", x);
               vector_pers[k].Nume= Console.ReadLine();
                vector_pers[k].Data_nasterii = DateTime.Today;
                k++;
            }
            List<Persoana> lista = new List<Persoana>();
            lista.InsertRange(0, vector_pers);
            foreach(Persoana p in lista)
            {
                Console.WriteLine(p.Nume);
            }
        }
    }
}
