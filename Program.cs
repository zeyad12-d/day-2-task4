using System.ComponentModel.Design;

namespace day2_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "Enter Number Between, 2 , and , 9 ,");
            int num=int.Parse( Console.ReadLine() );
            
                    int ruelt = 0;
                if (num >= 2 && num <= 9)

                { 
                    for (int i = 0; i < num; i++)
                    {
                    ruelt= num * i;
                    Console.WriteLine($"the num is {num} * {i} = {ruelt} ");
                    }
                }
            

                else
                {
                    Console.WriteLine(" is out of rang");
                }
            }


            
        }
    }
}
