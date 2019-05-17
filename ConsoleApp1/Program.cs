using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 150; i++)
            {
                Console.Write(i + ": ");
                Console.WriteLine(ChangeCash(i));
            }
            Console.ReadLine();

        }
        static Cash ChangeCash(int cash)
        {
            var r = new Cash();
            var aux = cash;
            int temp = 0;
            if (aux >= 10)
            {
                r.Ten = aux / 10;
                aux = aux % 10;
                if (aux == 1 || (aux % 2 < 2 && aux % 2 > 0))
                {
                    aux = aux + 10;
                    r.Ten -= 1;
                }
            }
            if (aux >= 5)
            {
                r.Five = aux / 5;
                temp = aux;
                aux = aux % 5;
                if (aux == 1 || temp % 2 == 0 || (aux % 2 < 2 && aux % 2 > 0))
                {
                    r.Five -= 1;
                    aux = aux + 5;
                }
            }
            if (aux >= 2)
            {
                r.Two = aux / 2;
                aux = aux % 2;
            }
            if (aux != 0)
            {
                return null;
            }
            return r;
        }
    }
    class Cash
    {
        public int Two { get; set; }
        public int Five { get; set; }
        public int Ten { get; set; }
        public override string ToString()
        {
            return "Ten:" + Ten + ", Five:" + Five + ", Two:" + Two;
        }
    }

}
