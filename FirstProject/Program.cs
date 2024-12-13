namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Write a program that allows the user to enter a number then print it
            Console.WriteLine("Enter Value");
            string x= Console.ReadLine();
            Console.WriteLine("User Enter :");
            Console.WriteLine(x);



            #endregion

            # region 2-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int f, m;
            f = 5;
            m = 10;
            Console.WriteLine("F =");
            Console.WriteLine(f);
            Console.WriteLine("m =");
            Console.WriteLine(m);

            f = m;
            Console.WriteLine("After equal F =");
            Console.WriteLine(f);
            Console.WriteLine("After equal m =");
            Console.WriteLine(m);
            f = 20;
            Console.WriteLine("After change in value f, F =");
            Console.WriteLine(f);
            Console.WriteLine("After chnge in value f , m =");
            Console.WriteLine(m);
            #endregion

            #region 3-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            Pointt pt1=new Pointt();
            Pointt pt2=new Pointt();
            pt1.x = 2;
            pt1.y = 4;
            
            pt2.x = 5;
            pt2.y = 6;

            Console.WriteLine("pt1 x ,y");
            Console.WriteLine(pt1.x);
            Console.WriteLine(pt1.y);
            Console.WriteLine("pt2 x ,y");
            Console.WriteLine(pt2.x);
            Console.WriteLine(pt2.y);

            pt1 = pt2;
            Console.WriteLine("After Equal pt1 x ,y");
            Console.WriteLine(pt1.x);
            Console.WriteLine(pt1.y);
            Console.WriteLine("After Equal pt2 x ,y");
            Console.WriteLine(pt2.x);
            Console.WriteLine(pt2.y);

            pt2.x = 100;
            Console.WriteLine("After change value pt2.x : pt1 x ,y");
            Console.WriteLine(pt1.x);
            Console.WriteLine(pt1.y);
            Console.WriteLine("After change value pt2.x:  x ,y");
            Console.WriteLine(pt2.x);
            Console.WriteLine(pt2.y);
            #endregion
        }
    }
}
