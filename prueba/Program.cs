// See https://aka.ms/new-console-template for more information

using prueba;

public class p 
{
    public static void Main(string [] args) 
    {
      Class1 r = new Class1();

        int op , op2 ;
        double cd, td;

        do 
        {

            do
            {
                Console.WriteLine("//////////////////////");
                r.opc();
                op = r.validar("Seleccione una opcion: ");
                Console.WriteLine("//////////////////////");

            } while (op < 0 || op > 3);

            switch (op) 
            {
                case 1: 
                    {
                        do
                        {
                            Console.WriteLine("//////////////////////");
                            r.opc2();
                            op2 = r.validar("Seleccione una opcion: ");
                            Console.WriteLine("//////////////////////");

                        } while (op < 0 || op > 3);

                        switch (op2) 
                        {
                          case 1: 
                                {
                                    do
                                    {
                                        Console.WriteLine("DOLARES");
                                        cd = r.validar("Ingrese la cantidad a vender: ");
                                    } while (cd < 0 || cd > 50);
                                    td = r.venderD(cd);
                                    Console.WriteLine("Dolares ingresados: "+ cd);
                                    Console.WriteLine("la cantidad en cordobas es " + td);
                                    
                                  
                                }
                                break;

                            case 2:
                                {
                                    do
                                    {
                                        Console.WriteLine("Euros");
                                        cd = r.validar("Ingrese la cantidad a vender: ");
                                    } while (cd < 0 || cd > 50);
                                    td = r.venderE(cd);
                                    Console.WriteLine("Euros ingresados: " + cd);
                                    Console.WriteLine("la cantidad en cordobas es " + td);


                                }
                                break;
                        }
                    }
                    break;
                    case 2: 
                    {
                        do
                        {
                            Console.WriteLine("//////////////////////");
                            r.opc3();
                            op2 = r.validar("Seleccione una opcion: ");
                            Console.WriteLine("//////////////////////");

                        } while (op2 < 0 || op2 > 3);

                        switch (op2)
                        {
                            case 1:
                                {
                                    do
                                    {
                                        Console.WriteLine("DOLARES");
                                        cd = r.validar("Ingrese la cantidad a Comprar: ");
                                    } while (cd < 0);
                                    td = r.venderD(cd);
                                    Console.WriteLine("Dolares ingresados: " + cd);
                                    Console.WriteLine("la cantidad en cordobas es " + td);


                                }
                                break;
                        }
                    }
                    break;
            }



        } while (true);
    }
}
