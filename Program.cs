internal class Program
{
    private static void Main(string[] args)
    {
        // all my variables
        float myFloat = 69f;
        float floatPT2 = 0f;
        float result = 0f;
        Random rando = new Random();
        int anInt = rando.Next(1, 69);
        //this is a try catch statement
        try
        {
            result = Divide(myFloat, floatPT2);
        }
        catch (Exception e) 
        { 
            Console.WriteLine(e.Message);
            Console.WriteLine("enter a number other than zero tard");
            floatPT2 = (float)Convert.ToDouble(Console.ReadLine());
            //this is another try catch statement
            try
            {
                result = Divide(myFloat, floatPT2);
            }
            catch(Exception e2)
            {
               Console.WriteLine(e2.Message);
            }
            
        }

        finally { Console.WriteLine("im done the result is " + result); }
        //and anotha one
        try
        {
            checkAge(anInt);
        }
        catch (Exception e) 
        {
        Console.WriteLine("you not old enough dumb dumb");
        }
    }
    static float Divide(float x, float y)
    {
        //Thank god we are back to if else statements :)
        if(y == 0)
        {
            throw new DivideByZeroException();
        }
        else
        {
            return x / y;
        }
    }
    static void checkAge(int age)
    {
        //I missed these so much
        if(age >= 17)
        {
            Console.WriteLine($"You are {age}, you can play M games");
        }
        else
        {
            throw new ArgumentException();
        }
    }
}