using System;

namespace Aula3
{
    class Program
    {
        class Att {
            public void ex6() {
                int num1 = 0;
                int num2 = 0;
                int result = 0;
                do {
                    if (num2 == 0)
                    {
                        num2 = 1;
                        result = num1 + num2;
                    }
                    else
                    {
                        result = num1 + num2;
                        num1 = num2;
                        num2 = result;
                    }
                    Console.Write($"{result} ");
                } while (result <= 100);
                Console.WriteLine();
            }

            public void ex7(int x) {
                int i = x;
                while (i > 1) {
                    if(i % 2 == 0){
                        i /= 2;
                    }
                    else{
                        i = i * 3 + 1;
                    }
                    if(i == 1){
                        Console.WriteLine($"{i}");
                    }
                    else{
                        Console.Write($"{i} -> ");
                    }
                }
            }

            public void ex8(int n){
                for(int i = 1; i <= n; i++){
                    for(int j = 1; j <= i; j++){
                        Console.Write($"{i * j} ");
                    }
                    Console.WriteLine();
                }
            }

            public void ex9(){
                int num1 = 0;
                int num2 = 0;
                do{
                    if(num2 == 0){
                        num2 = 1;
                        Console.Write($"{num2} ");
                    }else{
                        Console.Write($"{num1 + num2} ");
                        num2 = num1 + num2;
                        num1 = num2 - num1;
                    }
                }while (num2 <= 100);
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Att control = new Att();
            int ex = 0;
            do{
                Console.WriteLine("Welcome to Class 3 in C#");
                Console.WriteLine("Please select a exercise to run");
                Console.WriteLine("If you want to exit the app insert -1");
                Console.WriteLine("6 - Fibonacci");
                Console.WriteLine("7 - Sequence");
                Console.WriteLine("8 - Table");
                Console.WriteLine("9 - Fibonacci");
                Console.Write("Which exercise? ");
                ex = Convert.ToInt32(Console.ReadLine());

                switch (ex){
                    case 6:
                        control.ex6();
                        break;

                    case 7:
                        Console.Write("Insert a number: ");
                        control.ex7(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 8:
                        Console.Write("Insert a number: ");
                        control.ex8(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 9:
                        control.ex9();
                        break;

                    case -1:
                        Console.WriteLine("Ending the app....");
                        break;

                    default:
                        Console.WriteLine("Entrada inválida!");
                        Console.WriteLine("Digite qualquer coisa para continuar...");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (ex != -1);
        }
    }
}
