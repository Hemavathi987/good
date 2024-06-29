

namespace demo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number ");
            int b= Convert.ToInt32(Console.ReadLine());
            //Arithmetic
            Console.WriteLine("  12345678  ");
            Console.WriteLine("*******Arithmetic******");
            Console.WriteLine("Addition ="+ (a+b));//addition
            Console.WriteLine("Subtraction ="+ (a-b));//subtraction
            Console.WriteLine("Multiplication ="+ a*b);//multiplication
            Console.WriteLine("Division ="+ (a/b));//Division
            Console.WriteLine("Modulus ="+(a%b));//Modulus
            Console.WriteLine("Incremene =" + (++a));//increment
            Console.WriteLine("Decrement =" + (b--));//Decrement
            Console.WriteLine("    ");
            //Comparision 
            Console.WriteLine("*******Comparision******");
            Console.WriteLine("less than ="+(a<b));//Less than
            Console.WriteLine("greater than ="+(a>b));//Greater than
            Console.WriteLine("Equals ="+(a==b));//Equals
            Console.WriteLine("less than or equal =" + (a <=b));//Less than or equals
            Console.WriteLine("Greater than or equal ="+(a>=b));//Greater than or equal
            Console.WriteLine("Not equal ="+(a!=b));// not equal
            //Logical
            Console.WriteLine("    ");
            Console.WriteLine("*******Logical******");
            Console.WriteLine("AND ="+ (2<a && 3>b));//AND
            Console.WriteLine("OR =" + (3 > a || 5 < b));//OR
            Console.WriteLine("NOT =" + !(5 > a && 7 < b));//NOT
            //Data types
            Console.WriteLine("    ");
            Console.WriteLine("*******Datatype******");
            int X = 1097542357;
            String str = "Hema";
            Char ch= 'H';
            bool allok= false;
            Console.WriteLine("Int Type="+X);
            Console.WriteLine("String type="+str);
            Console.WriteLine( "Character type="+ch);
            Console.WriteLine("Boolean type="+allok);   




        }
    }
}