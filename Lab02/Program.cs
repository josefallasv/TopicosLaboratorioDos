using Lab02.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        private static string input;
        private static string input2;
        private static string input3;
        private static string input4;
        private static double num1;
        private static double num2;
        private static double num3;
        private static double num4;
        private static int id;

        static void Main(string[] args)
        {
            Console.Out.WriteLine("Lab 02");
            Console.Out.WriteLine("Digite cualquier tecla para iniciar.");
            Console.WriteLine();
            Console.ReadKey();
            Console.Out.WriteLine("Digite numero del identificador de la operacion que desea realizar:\n" +
                                  "Calculadora basica \n" +
                                  "(1) - Suma \n" +
                                  "(2) - Resta \n" +
                                  "(3) - Multiplicacion \n" +
                                  "(4) - Division \n" +
                                  "\n" +
                                  "Calculadora cientifica \n" +
                                  "(5) - Potencia \n" +
                                  "(6) - Logaritmo \n" +
                                  "(7) - Raiz cuadrada \n" +
                                  "(8) - Factorial \n" +
                                  "(9) - Seno \n" +
                                  "(10) - Coseno \n" +
                                  "(11) - Tangente \n" +
                                  "\n" +
                                  "Calculadora financiera \n" +
                                  "(12) - Interes simple \n" +
                                  "(13) - Interes compuesto \n" +
                                  "(14) - Conversion USD a CRC \n" +
                                  "(15) - Conversion CRC a USD \n" +
                                  "\n");
            input = Console.In.ReadLine();
            bool flag = false;
            while (!flag)
            {
                if (Int32.TryParse(input, out id))
                {
                    if ((id < 1) || (id >= 16))
                    {
                        Console.WriteLine("Opcion no valida, intelo de nuevo.");
                        input = Console.In.ReadLine();
                    }
                    else
                    {
                        flag = true;
                    }
                }
                else
                {
                    Console.WriteLine("Opcion no valida, intelo de nuevo.");
                    input = Console.In.ReadLine();
                }
            }
            Console.Clear();
            switch (id)
            {
                case 1:
                    Console.WriteLine("Suma \n" +
                                      "\n"+
                                      "Digite el primer numero:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    flag = false;
                    Console.WriteLine("Digite el segundo numero:");
                    input2 = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input2, out num2))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: {0} + {1} = {2}",num1,num2, Basic.Addition(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("Resta \n" +
                                      "\n" +
                                      "Digite el primer numero:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    flag = false;
                    Console.WriteLine("Digite el segundo numero:");
                    input2 = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input2, out num2))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: {0} - {1} = {2}", num1, num2, Basic.Subtraction(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplicacion \n" +
                                      "\n" +
                                      "Digite el primer numero:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    flag = false;
                    Console.WriteLine("Digite el segundo numero:");
                    input2 = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input2, out num2))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: {0} x {1} = {2}", num1, num2, Basic.Multiplication(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("Division \n" +
                                      "\n" +
                                      "Digite el primer numero:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    flag = false;
                    Console.WriteLine("Digite el segundo numero:");
                    input2 = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input2, out num2))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: {0} / {1} = {2}", num1, num2, Basic.Division(num1, num2));
                    break;
                case 5:
                    Console.WriteLine("Potencia \n" +
                                      "\n" +
                                      "Digite el numero:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    flag = false;
                    Console.WriteLine("Digite la potencia:");
                    input2 = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input2, out num2))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: {0} ^ {1} = {2}", num1, num2, Scientific.Potency(num1, num2));
                    break;
                case 6:
                    Console.WriteLine("Logaritmo \n" +
                                      "\n" +
                                      "Digite la base:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num2))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    flag = false;
                    Console.WriteLine("Digite el argumento:");
                    input2 = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input2, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: Log{0} {1} = {2}", num2, num1, Scientific.Logarithm(num1, num2));
                    break;
                case 7:
                    Console.WriteLine("Raiz cuadrada \n" +
                                      "\n" +
                                      "Digite el numero:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: √ {0} = {1}", num1, Scientific.SquareRoot(num1));
                    break;
                case 8:
                    Console.WriteLine("Factorial \n" +
                                      "\n" +
                                      "Digite el numero:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: !{0} = {1}", num1, Scientific.Factorial(num1));
                    break;
                case 9:
                    Console.WriteLine("Seno \n" +
                                      "\n" +
                                      "Digite el angulo:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: \n" +
                                          "Radianes = {0} \n" +
                                          "Grados = {1}º",
                                          Scientific.SineRadian(num1), Scientific.SineDegrees(num1));
                    break;
                case 10:
                    Console.WriteLine("Coseno \n" +
                                      "\n" +
                                      "Digite el angulo:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: \n" +
                                          "Radianes = {0} \n" +
                                          "Grados = {1}º",
                                          Scientific.CosineRadian(num1), Scientific.CosineDegrees(num1));
                    break;
                case 11:
                    Console.WriteLine("Tangente \n" +
                                      "\n" +
                                      "Digite el angulo:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: \n" +
                                          "Radianes = {0} \n" +
                                          "Grados = {1}º",
                                          Scientific.TangentRadian(num1), Scientific.TangentDegrees(num1));
                    break;
                case 12:
                    Console.WriteLine("Interes simple \n" +
                                      "\n" +
                                      "Digite la cantidad:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    flag = false;
                    Console.WriteLine("Digite la tasa de interes:");
                    input2 = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input2, out num2))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.WriteLine("Digite la cantidad de años:");
                    input3 = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input3, out num3))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: {0} \n", Financial.SimpleInterest(num1, num2, num3));
                    break;
                case 13:
                    Console.WriteLine("Interes compuesto \n" +
                                      "\n" +
                                      "Digite la cantidad:");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    flag = false;
                    Console.WriteLine("Digite la tasa de interes:");
                    input2 = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input2, out num2))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.WriteLine("Digite numero de veces por año:");
                    input3 = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input3, out num3))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.WriteLine("Digite la cantidad de años:");
                    input4 = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input4, out num4))
                        {
                            Console.WriteLine("Numero no valido, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: {0} \n", Financial.CompoundInterest(num1, num2, num3, num4));
                    break;
                case 14:
                    Console.WriteLine("Conversion USD a CRC \n" +
                                      "\n" +
                                      "Digite la cantidad ($)");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Cantidad no valida, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: USD ${0} en CRC = ₡{1}", num1, Financial.ConvertUSDtoCRC(num1));
                    break;
                case 15:
                    Console.WriteLine("Conversion CRC a USD \n" +
                                      "\n" +
                                      "Digite la cantidad (₡):");
                    input = Console.In.ReadLine();
                    flag = false;
                    while (!flag)
                    {
                        if (!Double.TryParse(input, out num1))
                        {
                            Console.WriteLine("Cantidad no valida, intelo de nuevo.");
                            input = Console.In.ReadLine();
                        }
                        flag = true;
                    }
                    Console.Clear();
                    Console.Out.WriteLine("Resultado: CRC ₡{0} en USD = $ {1}", num1, Financial.ConvertCRCtoUSD(num1));
                    break;
            }
            Console.ReadKey();
        }
    }
}
