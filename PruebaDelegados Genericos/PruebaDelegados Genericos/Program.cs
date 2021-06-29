using System;

namespace PruebaDelegados_Genericos
{
    class Program
    {
        public delegate void MiDelegadoGenerico<T>(T p);
        static void Main(string[] args)
        {
            MiDelegadoGenerico<string> delCadena = new MiDelegadoGenerico<string>(HandlerCadena);
            delCadena("DC");

            MiDelegadoGenerico<double> delDouble = new MiDelegadoGenerico<double>(HandlerDouble);
            delDouble(2.5555);

            Action<string> action = new Action<string>(HandlerAction);
            Action<string, double> action2 = new Action<string, double>(HandlerAction2);
            action2("AA", 2.0);
            Console.ReadLine();

        }

        private static void HandlerAction2(string p1, double p2)
        {
            Console.WriteLine("Cadena " + p1 + " " +p2);
        }

        private static void HandlerAction(string obj)
        {
            throw new NotImplementedException();
        }

        private static void HandlerDouble(double p)
        {
            Console.WriteLine("Cadena " + p);
        }

        private static void HandlerCadena(string p)
        {
            Console.WriteLine("Double " + p);
            
        }
    }
}
