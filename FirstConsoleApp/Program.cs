




        Console.Write("Print Hello, World! and wait on the same line");
        //printf
        Console.WriteLine("After Printing  this it will come next line....");


        object o = 93333.44f;
        o = "Jack";
        //Every data type inherits from object data type. Object is the parent of all data types.
        //Object being the biggest data type it can store anything
        //Int32 its a datatype in terms of framework
        int i = 100;
        Console.WriteLine("The minimum value of integer= " + int.MinValue);
        Console.WriteLine("The maximum value of integer=" + int.MaxValue);
        //It is a datatype which has a name "int" in C#, In vb.net int means "Integer"

        short r;

        long k;
        Console.WriteLine("The minimum value of Long= " + long.MinValue);
        Console.WriteLine("The maximum value of Long=" + long.MaxValue);


        string s = "Hello";
        float price = 41.19f;
        Console.WriteLine("The min value of float=" + float.MinValue);
        Console.WriteLine("The max value of float=" + float.MaxValue);

        //for engg calculations use double
        double totalPrice = 322324.42d;
        Console.WriteLine("The min value of Double=" + double.MinValue);
        Console.WriteLine("The max value of Double=" + double.MaxValue);
        char c = 'A';
        DateTime dt = new DateTime(2024, 10, 4);

        //for financial,monetary calculation use decimal
        decimal unitPrice;

        Console.WriteLine("The min value of Decimal=" + decimal.MinValue);
        Console.WriteLine("The max value of Decimal=" + decimal.MaxValue);

        //Any numerical value want to store in string, use ToString() on the variable name.

        string StoreValueofI = i.ToString();



        Console.WriteLine(i);
        Console.WriteLine(s);
        Console.WriteLine(price);
        Console.WriteLine(totalPrice);
        Console.WriteLine(c);



        Console.Read();
    



/*This is  
 * multi line
 * a comment*/

