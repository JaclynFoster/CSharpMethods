﻿namespace Methods;

class Program
{
    //<Access Specifier> <Return Type> <Method Name>(Parameter List)
    //Access Specifier- determines visibility of a variable or a method from another class
    //Return Type- method may return a value. The return type is the data type of the value the method returns. If the method is not returning
    //any values return type is void
    //Method name-unique identifier and is case sensitive cannot be the same as any other identifier declared in the class
    //Parameter List- enclosed between parenthesis used to pass and receive data from a method. referes to the type, order, and number of the
    //params in a method. Params are optional 
    static void Main(string[] args)
    {

        //Operators:
        int opNum1 = 5;
        int opNum2 = 3;
        int opNum3;

        //unary operators:
        opNum3 = -opNum1;
        Console.WriteLine("opNum3 is {0}", opNum3);

        bool isCloudy = true;
        Console.WriteLine("Is it cloudy? {0}", !isCloudy);

        //increment operators:
        int newNum = 0;
        newNum++;
        Console.WriteLine(newNum);
        //post-increment
        Console.WriteLine("newNum is {0}", newNum++); //increments after
        //pre-increment
        Console.WriteLine("newNum is {0}", ++newNum); //increments before;

        //decrement operators:
        int decNum = 0;
        decNum--;
        Console.WriteLine(decNum);
        //post-decrement
        Console.WriteLine("decNum is {0}", newNum++); //decrements after
        //pre-decrement
        Console.WriteLine("decNum is {0}", ++newNum); //decrements before;

        //== operator is comparison
        //conditional operators && ||


        //Try/Catch/Finally example:

        int tryNum1 = 5;
        int tryNum2 = 0;
        int tryResult;
        try
        {
            tryResult = tryNum1 / tryNum2;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }

        Console.WriteLine("Please Enter a Number:");
        string userInput = Console.ReadLine();
        try
        {
            int userInputInt = int.Parse(userInput);
        }
        catch (FormatException)
        {
            Console.WriteLine("Format exception. Please enter correct type.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow Exception. The number is too long or too short for int32.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("ArgumentNullException. The value was empty(null).");
        }
        finally
        {
            Console.WriteLine("This will be called anyways.");
        }
        Console.WriteLine(Calculate());
        

        string friend1 = "Chris";
        string friend2 = "Kim";
        string friend3 = "Stephanie";

        GreetFriend(friend1, friend2, friend3);
  

        WriteSomething();
        WriteSomethingSpecific("I am an argument and called from a method");
        Console.WriteLine(Add(15, 31));
        Console.WriteLine(Multiply(20, 3));
        Console.WriteLine(Divide(25, 13));
        Console.Read();
        //Method Body
        Console.ReadKey();
    }

    public static void GreetFriend(string friendName, string friendName2, string friendName3)
    {
        Console.WriteLine("Hi " + friendName + " , my friend!");
        Console.WriteLine("Hi " + friendName2 + " , my friend!");
        Console.WriteLine("Hi " + friendName3 + " , my friend!");
    }

    public static void WriteSomething() //access modifier (static) return type method name
    {
        Console.WriteLine("I am called from a method");
        //Console.Read();
    }

    public static void WriteSomethingSpecific(string myText)
    {
        Console.WriteLine(myText);
        //Console.Read();
    }

    public static int Add(int num1, int num2)
    {
     
        return num1 + num2;
    }

    public static int Multiply(int multiple1, int multiple2)
    {
        return multiple1 * multiple2;
    }

    public static double Divide (double num1, double num2)
    {
        return num1 / num2; 
    }

    public static int Calculate()
    {
        Console.WriteLine("Please enter the first number");
        string numberInput = Console.ReadLine();

        Console.WriteLine("Please enter second number");
        string number2Input = Console.ReadLine();

        int number1 = int.Parse(numberInput);
        int number2 = int.Parse(number2Input);

        int result = number1 + number2;
        return result;
    }

    //Try/Catch and Finally:

}

