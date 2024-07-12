//divided programmm method
/*namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6, b = 2;

           float dividedValue= division(a, b);
            Console.WriteLine(dividedValue);

            static float division(int a, int b)
            {
                float divided = a / b;
                return divided;
            }
        }
    }
}
*/



//-------------------------------Even Odd method



/*namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (evenOddChecker(2) == true)
            {
                Console.WriteLine("the given number is even");
            }
            else
            {
                Console.WriteLine("the given number is Odd");
            }


        }

       static bool evenOddChecker(int num)
        {
            if(num%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}*/


//-------------------------------swapping two numbers without thrid variable

/*namespace firstApp
{
    internal class program
    {
        static void Main(string[] args)
        {
            int a=6; int b=7;
            swapper(a, b);
          

            static int[] swapper(int a, int b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                int[] arr = { a, b };
                Console.WriteLine("a="+arr[0]+ "and b = "+arr[1] );
                return arr ;

            }
        }
    }
}
*/


//-----------------------------Palindrom-----------------------



namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "madam";
          Console.WriteLine(  isPalindrom(value));

        }

        static bool isPalindrom(string value)
        {
            bool palindrom=false;
            for(int i=0;i<value.Length/2;i++)
            {
                if (value[i] == value[value.Length - i - 1])
                {
                    palindrom = true;
                    continue;
                    
                }
                else
                {
                    palindrom = false;
                    
                }
            }
            return palindrom;
        }

    }
}


//class and objects




/*namespace FirstApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Car obj1 = new Car();
            Car obj2=new Car();

            Console.WriteLine(obj1.Color);
            Console.WriteLine(obj2.Color="black");

            normalClass objn = new normalClass();

            Console.WriteLine(objn.stoolColor="blackMate");
            Console.WriteLine();

        }
    
    }

}
(*/

/*
namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args) 
            {
            Console.WriteLine("please Enter your name");
            string name=Console.ReadLine();

            Console.WriteLine(name);
            }
    }
}
*/


/*namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread th1 = new Thread(() => { for (int i = 0; i < 10; i++) { Console.WriteLine("hello from thread 1");} });
            Thread th2 = new Thread(() => { for (int i = 0; i < 10; i++) { Console.WriteLine("hello from thread 2");} });
            Thread th3 = new Thread(() => { for (int i = 0; i < 10; i++) { Console.WriteLine("hello from thread 3"); } });

            th1.Start();
            th2.Start();
            th3.Start();

        }

        
    }
}
*/


/*namespace FirstApp
{
    public class Program
    {
        static void Main(String[] args)
        {
            String Name = "shahmeer";
          //  Name = "\"" + Name + "\"";
            Console.WriteLine(Name);
        }
        static string StringConv(this string str)
        {
            return "\"" + str + "\"";

        }
    }
}
*/