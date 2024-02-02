using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    internal class Class1
    {
        double  v1 , e1 , tt1 , tt2;

        public Class1(){}

        public Class1(double v1) 
        {
         this.v1 = v1;
        }
        public void opc() 
        {
            Console.WriteLine("Divisas");
            Console.WriteLine("1.op Vender");
            Console.WriteLine("2.op comprar");
            Console.WriteLine("3.op Salir");
        }

        public void opc2() 
        {
            Console.WriteLine("Vender");
            Console.WriteLine("1.op Dolares");
            Console.WriteLine("2.op Euros");
        }

        public void opc3()
        {
            Console.WriteLine("Comprar");
            Console.WriteLine("1.op Dolares");
            Console.WriteLine("2.op Euros");
        }

        public double venderD(double v1) 
        {
            return v1 * 36.10;
            Console.WriteLine("Cordobas " + v1); 
        }

        public double venderE(double e1) 
        {
            tt1 = e1 * 1.0350;
            tt2 = tt1 * 36.10;
            return  tt2;
        }

        public int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.Write(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("////////////////////////////////////");
                    Console.WriteLine("No se aceptan letras", error.Message);
                    Console.WriteLine("////////////////////////////////////");
                    opc();
                }
            } while (v == 0);
            return num;
        }


    }
    
}
