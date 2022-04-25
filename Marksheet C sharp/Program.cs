using System;
namespace MARKSHEET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Rollno");
            string roll = Console.ReadLine();
            Console.WriteLine("Enter your class");
            string standard = Console.ReadLine();
            Console.WriteLine("Enter your Hindi number");
            int H = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your English number");
            int E = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Math Marks");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Chemistry marks");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Physics marks");
            int P = int.Parse(Console.ReadLine());
            int add = H + E + M + C + P;
            int per = add * 100 / 500;

            Console.WriteLine("..........Marksheet.........");
            Console.WriteLine("Your obtain marks are {0}",add);
            Console.WriteLine("your percantage is {0}",per);
            Console.WriteLine("your name is {0}",name);
            Console.WriteLine("your rollno is {0}",roll);
            Console.WriteLine("your class is {0}",standard);

            if(per >=80)
            {
                Console.WriteLine("Grade is A+ ->Papa happy hai");

            }
            else if (per >=70)
            {
                Console.WriteLine("Grade is A ->Papa thode Happy hai");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Grade is B -> Papa happy nhi but aacha hai");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Grade is C -> Mummy ne papa se bacha liya");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Grade is D");
            }
            else
            {
                Console.WriteLine("This student is Fail -> Papa ne Aapke liye Lath tyair kar liya hai");
            }


            Console.ReadLine();
        }
        
        
    }
}