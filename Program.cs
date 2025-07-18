using System; 

namespace CalculatorOperations 

{
    class Calci
    {
        static void Main(string[] args)
          
            {
                int a;
                int b;
                char op;
                Console.WriteLine("Enter the first number: ");
                 a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                 b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose an operation: +, -, *,/");
                 op = Convert.ToChar(Console.ReadLine());

                switch (op)
                {
                    case '+':
                    Console.WriteLine($"res: {a + b}");
                    break;
                    case '-':
                    Console.WriteLine($"res: {a - b}");
                    break;
                    case '*':
                    Console.WriteLine($"res: {a * b}");
                    break;
                    case '/':
                    Console.WriteLine($"res:{a/b}");
                    break;


               /* int a ;
                int b ;
                 Console.WriteLine("Enter the first number : ");
                a =  Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Enter the second number : ");
                b =  Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sum of 2 numbers : " + (a+b));
                Console.ReadKey();


                char ch='B';
                Console.WriteLine("Char:" + ch);
                Console.WriteLine("Equivalent Number:" + (byte) ch);
                Console.WriteLine("Min and max value size :" +(int)char.MinValue+" "+(int)char.MaxValue);
                Console.WriteLine("char size : " + sizeof(char));
                  Console.ReadKey();  
                
              */


            }
        }}


    }

