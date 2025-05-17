using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace facemsoft1
{
    class Program
    {   
        struct Structura1
        {
            public int valoare;
        }
        class Clasa1
        {
            public int valoare = 0;
            public Clasa1 Clone()
            {
                Clasa1 x = new Clasa1();
                x.valoare = this.valoare;
                return x;
            }
        }

        static void Main(string[] args)
        {
            //Structura1 s1;
            //s1.valoare = 0;
            //Structura1 s2 = s1;
            //s2.valoare = 13;

            //Clasa1 c1;//nu se apeleaza constr
            //c1 = new Clasa1();//se apeleaza
            ////Clasa1 c2 = c1;//clase de tip referential, acu pointeaza spre aceeasi memorie
            //Clasa1 c2 = c1.Clone();
            //c2.valoare =13;
            //Console.WriteLine("Valorile din strucruea sunt: {0},{1}", s1.valoare, s2.valoare);
            //Console.WriteLine("Valorile din clasa sunt: {0},{1}", c1.valoare, c2.valoare);
            //Console.ReadLine();
            int[] vector;
            vector = new int[3];
            vector = new int[5];
        }
    }
}
