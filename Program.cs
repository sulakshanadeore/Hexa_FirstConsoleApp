internal class Program
{
    private static void Main(string[] args)
    {
        const float PI = 3.14f;


        //Variable name should start with a char.
        //variable name should start with a _.
        //Microsoft convention



        //int _age = 10;

        //_age = AcceptAgeFromUser();

        //CheckAgeInRangeOrNot(_age);

        NestedIFElseExample();













        //Read/ReadLine/ReadKey
        Console.ReadKey();

    }

    private static void NestedIFElseExample()
    {
        int _no1 = 6;
        int _no2 = 39;

        if (_no1 > 5)
        {

            if (_no2 > 15)
            {

                Console.WriteLine("No1 is > 5 and No2 is >15 ");
                if (_no2 > 20 && _no2 < 39)
                {
                    Console.WriteLine("No1 is > 5 and No2 is >20");

                }
                else if (_no2 > 30 && _no2 < 50)
                {
                    Console.WriteLine("No1 is in the range of 30 to 49");
                }
                else
                {
                    Console.WriteLine("Not in range, its greater than 50");
                }
            }
            else
            {
                Console.WriteLine("no1 is > 5 but no2 is not greater than 15");
            }
        }
        else
        {
            Console.WriteLine("No1 is not greater than 5");
        }
    }

    /// <summary>
    /// Accept age from the user as a integer
    /// </summary>
    /// <returns>int</returns>

    private static int AcceptAgeFromUser()
    {
        int _age;
        Console.WriteLine("Enter age");
        _age = Convert.ToInt32(Console.ReadLine());
        return _age;
    }

    /// <summary>
    /// Check that the age is not >=10 and not <20 and not a negative or a zero
    /// </summary>
    /// <param name="_age"></param>
    private static void CheckAgeInRangeOrNot(int _age)
    {
        if (!(_age >= 10) && !(_age < 20) && !(_age <= 0))
        {
            Console.WriteLine("Age is smaller 10 and greater than 20");
            Console.WriteLine("greater than zero...");
        }
        else
        {
            Console.WriteLine("Age should be greater than 0 ....");
            Console.WriteLine("Another here.....");
        }
    }
}