using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace tarefa3

{

    class Program

    {



        //autor:Joelson Morais



        static void sair()

        {



            Environment.Exit(0);



        }





        static void menu()

        {





            int men;









            Console.WriteLine("_____Calculadora de Equações_____");

            Console.WriteLine("|1)-1 grau"); Console.WriteLine("\t\t\t\t|");

            Console.WriteLine("|2)-2 grau"); Console.WriteLine("\t\t\t\t|");

            Console.WriteLine("|3)-sair"); Console.WriteLine("\t\t\t\t|");

            Console.WriteLine("|"); Console.WriteLine("\t\t\t\t|");

            Console.WriteLine("|"); Console.WriteLine("\t\t\t\t|");



            men = int.Parse(Console.ReadLine());



            switch (men)

            {





                case 1:



                    grau1();

                    break;







                case 2:



                    grau2();



                    break;



                case 3:



                    sair();



                    break;



                default:



                    Console.WriteLine("Opção não encontrada");



                    break;











            }





        }

        static int grau2()

        {





            double a, b, c, d, x1, x2;

            Console.WriteLine("Equação 2º Grau");

            Console.Write(" Valor de a : ");

            a = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.Beep();

            Console.WriteLine("o valor A foi salvo");

            Console.Write(" Valor de b : ");

            b = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.Beep();

            Console.WriteLine("o valor B foi salvo");

            Console.Write(" Valor de c : ");

            c = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.Beep();

            Console.WriteLine("o valor C foi salvo");



            Console.Clear();

            Console.WriteLine("SOLUÇÃO:");

            Console.Beep();

            Console.WriteLine(a + "x² + " + b + "x + " + c + "=0");

            d = b * b - 4 * a * c;

            if (d > 0)

            {

                Console.WriteLine("Existem duas raizes reais");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);

                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine("x1'= " + x1);

                Console.WriteLine("x2''= " + x2);

            }

            else if (d == 0)

            {

                Console.WriteLine("Existem duas raizes reais e iguais.");

                x1 = -b / (a * 2);

                Console.WriteLine("x'=x''= " + x1);

            }

            else

            {

                Console.WriteLine("Nao existem raizes reais");

            }





            return 1;







        }



        static int grau1()
        {







            double A, B, C, D;





            Console.WriteLine("Entre com o 'a' da equao ax + b = 0:");

            A = double.Parse(Console.ReadLine());



            Console.Clear();

            Console.Beep();

            Console.WriteLine("o valor A foi salvo");



            Console.WriteLine("\nEntre com o 'b' da equação ax + b = 0:");

            B = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.Beep();

            Console.WriteLine("o valor B foi salvo");

            Console.Clear();



            Console.WriteLine("Solução:");

            C = B - (2 * B);

            D = C / A;





            Console.WriteLine("\nA raiz da equação : " + D);





            return 2;

        }



        static void Main(string[] args)

        {



            menu();



            Console.ReadKey();





        }











    }

}

