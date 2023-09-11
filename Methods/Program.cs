namespace Methods;

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
        WriteSomething();
        WriteSomethingSpecific("I am an argument and called from a method");
        Console.WriteLine(Add(15, 31));
        Console.WriteLine(Multiply(20, 3));
        Console.WriteLine(Divide(25, 13));
        Console.Read();
        //Method Body
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
}

