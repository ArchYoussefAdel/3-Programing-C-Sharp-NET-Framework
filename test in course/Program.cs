using System;

class MyClass
{
    public static void Main()
    {



        //variable declaration
        // is named location in the memory that hold a value can be changed
        // byte  

        /* 
         * 
         * is named location in the memory that hold a value can be changed
         * 
         * 
         * D.T      size        comment
         * byte     1           0>>255 int
         * sbyte    1           -128>>127
         * short    2           -32768>>32767
         * ushort   2           0>>65535
         * int      4           -ev>>+ev
         * uint     4           0>> +ev
         * long     8           -ev>> +ev
         * ulong    8           0>> +ev
         * 
         * float    4           7 decimal
         * douvle   8           15 decimal
         * decimal  10          23 decimal
         * 
         * bool                 ture/false
         * char     2           unicode
         * string               only reference type others are value type
         * --------------------------------
         *              data type
         * value type                   referance type
         *     x= (5)                       x=refrance
         *                                  x=5 some where els
         * ------------------------------------------------------
         * varibale decliration
         * data_type var_namr
         * 
         * ex:
         * int x = un initailized variable
         * char ch = 'a;
         * 
         * float m, n = 2.3, z = multi initialize valued
         * ---------------------------------------------------
         * Name:
         * collection of charachters , numbers , _
         * can't start with number
         * can't be one of the reversed word
         * name express what it perform
         * then name start with Capital letter
         * if the name consists of more than one part each part start with capital letter (and/or) sperated with _
         * 
         * Reversed words:
         * start with small letters
         * ---------------------------------
         * expression:
         * input statement
         * read data from user
         * must have variables to read and store in memory
         * Console.Readline();     //reads string only !!!
         * Console.Read();     //reads char only !!!
         * 
         * 
         * ex:
         * string str = Console.Readline();
         * 
         * ex:
         * int x;
         * string s;
         * s=Console.Readline();
         * x=int.Parse(s);
         * 
         * x=int.Parse(Console.Readline());
         * 
         * output statement:
         * Console.Write();         //write line
         * Console.Writeline();     //write line + break line
         * 
         * ex: for constant value
         * Console.Write("Welcome");         
         * Console.Write(17);         
         * 
         * ex: variable value
         * float m =2.4;
         * Console.WriteLine(m);
         * 
         * ex: comination of both constant and variable
         * Console.Writeline("The value of {0}+{1}",m,m+m);
         *   
         * Console.Writeline($"The value of {m}+{m}={m+m}");
         * 
         * Console.Writeline("The value of" m +"+"+ (m+m)); //too hard not needed
         * 
         * the value of 2.4+2.4=4.8
         * 
         * 
         * operation
         * control statement
         * 
         * ------------------2nd day-------------------------
         * operations
         * mathematical operation
         * +,-,*,/,%
         * Relational operatioms
         * <,>,<=,>=,==,!=
         * Logical operators
         * &&,||,!
         * 
         * &&
         * true+true=true
         * true+false=false
         * false+false=false
         * 
         * 
         * ||
         * true or true=true
         * true or false=true 
         * false+false=false
         * 
         * !
         * ¡true=false
         * ¡false=true
         * 
         * 
         * increment\decrement
         * ++,--
         * 
         * clarr
         * {
         * puplic static voic()
         * {
         * int x = 10
         * int y;
         * 
         * pre-incremnt
         * y=++x; = assin y=x   (2nd)
         *          incerement x = x+1 (1st)
         *          
         * consle.writeline($"x={x}";
         * consle.writeline($"y={y}";
         *result =   x=11,  y=11
         * 
         * 
         * post-increment
         * y=x++; = assin y=x   (1st)
         *          incerement x = x+1 (2nd)
         *          
         * consle.writeline($"x={x}";
         * consle.writeline($"y={y}";
         * result=  x=11 ,   y=10
         * {
         * {
         * 
         * ------------------------------------------------
         * 
         * assignment operator shorthand
         * =,+=,-=,*=,/=,%=
         * 
         * x += 3  ===> x=x+3
         * 
         * x=3+4*5;
         * right side = 23 (temperary area)
         * then the = takes both side
         * 
         * any operation has a value
         *------------------------------------ 
         *
         *x=y=z=7
         *
         *all operation happens from left to right except = operator the othere way
         *
         *assiment operation is not an operation
         *
         *x+1 = x (equation not assignment)
         * 
         * the highest priority is for brackt () in operation
         * 
         * -------------------------------------
         * control statement
         * 
         * -branshing(selection,conditional)statement
         * if statement
         * 
         * if(condition)
         * {
         * statement to be excuted
         * when condition is true
         * if not true then continuo as nothing happend
         * }
         * 
         * ex;
         *if num odd multi by 2 then print other wise print
         *
         *{
         *int Num;
         *class test
            puNic statc void Main()
            int Num;
            Console .Write("Enter a number. ");
            Num = int.Parse(Console .ReadLine()),
            int Rem;
            Rem = Num % 2;
            if(Rem != 0)
        {
            Num = Num *2;
        }
            Console .Write($"value={Num}");
         *}
         *
         *
         *if - else
         *
         * if(condition)
         * {
         * statement to be excuted
         * when condition is true
         * if not true then continuo as nothing happend
         * }
         *else
         *{
         *statement to be excuted
         * when condition is not true (false)
         * if not true then continuo as nothing happend
         *}
         *
         *ex;
         *read a gread
         *if grade > 60 then pass 
         *otherwise fale
         *
         *class test
public static void Main()
int Grade;
Console.Write("Enter Grade: ");
Grade=int.Parse(Console.ReadLine());
if(Grade>=60)
        {
Console.WriteLine("Pass");
        }
else
        {
Console.WriteLine("Fail");
        }
         * 
         * 
         * bad example cuas transilates litirly
         * class test
public static void Main()
int Grade;
Console.Write("Enter Grade: 't);
Grade=int.Parse(Console.ReadLine());
if(Grade >= 90)
Console.WriteLine("A");
if(Grade 80)
Console.WriteLine('B");
if(Grade 60)
Console.WriteLine('C");
else
Console.WriteLine('Fail");
         *
         *
         * better example cuas transilates logacliy
         * 
         * int Grade;
Console.WriteC'Enter Grade: ");
Grade=int.Parse(Console.ReadLine());
if(Grade >= 90)
Console.WriteLine("A");
if(Grade >= 80 && Grade < 90)
Console.WriteLine('B");
if(Grade 60 Grade < 80)
Console.WriteLine('C");
if(Grade < 60)
Console.WriteLine('Fail");
         *
         *
         * 
         * 
         * Nested
         * class test
public static void Main()
int Grade;
Console.Write('Enter Grade:
Grade=int.Parse(Console.ReadLine());
if(Grade 90)
Console.WriteLine("A");
else

O if(Grade >= 80)
if(Grade >= 60)
         * -------------------------------------Day 3-----------------------------
         * 
         * 
         * 
         * 
         * 
         * 
         */
        //branching
        //switch ... case


        ////int Num = 0;
        ////Console.WriteLine("Enter a Num");
        ////Num = int.Parse(Console.ReadLine());
        ////switch (Num)
        ////{
        ////    case 1:
        ////        Console.WriteLine("One");
        ////        break;
        ////    case 2:
        ////        Console.WriteLine("Two");
        ////        break;
        ////    case 3:
        ////        Console.WriteLine("Three");
        ////        break;
        ////    default:
        ////        Console.WriteLine("out of range");
        ////        break;

        //-----------iteration (looping) statement
        //for loop: better used  when you know how many time you will itirate

        /*for(initalize statement : conditional statement cheks every time : update statement)
        {
        statement to be repeted
        when condition is true
        }


        */

        //ex: write a program that sums num from 1 to 100

        ////int Sum;
        ////int Count;

        ////for (Count = 1, Sum = 0; Count <= 100; Count++)
        ////{
        ////    Sum = Sum + Count;  //Sum += Count

        ////}
        ////Console.WriteLine($"Sum={Sum}");
        //--------OR------------

        ////int Sum;
        ////int Count;
        ////Count = 1;
        ////Sum = 0;

        ////for (  ; Count <= 100; Count++)
        ////{
        ////    Sum = Sum + Count;  //Sum += Count

        ////}
        ////Console.WriteLine($"Sum={Sum}");
        ///   //--------OR------------
        // update statement empty
        ////int Sum;
        ////int Count;
        ////Count = 1;
        ////Sum = 0;

        ////for (; Count <= 100;)
        ////{
        ////    Sum = Sum + Count;  //Sum += Count
        ////    Count++;
        ////}
        ////Console.WriteLine($"Sum={Sum}");
        ///   //--------OR------------
        // conditional statement empty(infinite loop)
        ////int Sum;
        ////int Count;
        ////Count = 1;
        ////Sum = 0;

        ////for (  ; ;)
        ////{
        ////    Sum = Sum + Count;  //Sum += Count
        ////    Count++
        ////}
        ////Console.WriteLine($"Sum={Sum}");
        ///
        /*
         * use the while loop when you don't know how many time you will itirate
         * 
         *   ////int Sum;
            ////int Count;
            ////Count = 1;
            ////Sum = 0;

            ////while ( Count <= 100 )
            ////{
            ////    Sum = Sum + Count;  //Sum += Count
            ////    Count++
            ////}
            ////Console.WriteLine($"Sum={Sum}");

        
        ----------------------do while
        
        do
        {
        statement to be to be true

        }While(condition)
        {

        }
        -----------------------Day 4-------------------
        method

        return_type method_name (prameter_List)
        {
        method implementation //method code
        }
        
        example:
        method that print "welcome"

        class test
        {
            puplic static void PrintMsg()
            {
                console.writeline("welcome") 
            }
            puplic static void Main()
            {
                PrintMsg() 
            {
        }

        ex:

        write a method that sums 2 numbers

  class Test
{
    public static void PrintSum(int x, int y)
    {
        int z;
        z = x + y;

        Console.WriteLine($"total={z}");
    }
    public static void Main()
    {
        int a = 1;
        int b = 5;
        PrintSum(a, b);
        {
        }
    }

        // return statement to termenate the method 

        i can't create method inside method 
        but i can call method inside a method

}



        --------------Day 5-----------------
        any returns; in method returns one value only 



        ref         |       out
 uninitialized      |   initialized
      Main()        |       Main()
     initialized    |   uninitialized
      

        class MyClass
        {
            puplic static void Swap(ref int x, ref int y)
            {
                int temp;
                temp = x;
                x=y;
                y=temp
            }
            }
            puplic static void Main()
            {
                int a=3, b=4;
                Swap(ref a,ref b);
                Console.WriteLine($"A={a}");
                Console.WriteLine($"B={b}");
            }
        }

        //Out Parameter must be initialized

           class MyClass
        {
            puplic static float calc(int a, int b, out int x)
            {
                x=a+b;
                return(x/2);
            }
            puplic static void Main()
            {
                int l=3 ,m=4,s;
                float avg;
                av=calc(l,m,out s);
            }
        }

        //Recursion

             class MyClass
        {
         puplic static void Main()
            {
                long val;
                val=Fact(4);
            }
            puplic static void Fact(int m)
            {
                long result;
                if(m>1);
                {
                    result=m*Fac(m-1);
                }
                return result;
        }
        --------------------
        public static long Fact(int m)
        {
        long result=1;
        for(int i=1;i>=1;i--)
        {
        result=result*i;
        }
        return result;
        }

        loop                recursion
        16 byts             48 byts
        19 instruction      32 instruction

                */
    }
}


