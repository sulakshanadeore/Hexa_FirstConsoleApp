﻿using System;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        String s = "welcome";
        string s1 = "HEllo";
        string s2 = " World";
        string s3 = s1 + s2 + s;

        Console.WriteLine(s3);
        Console.WriteLine("---------------");
        StringBuilder sb = new StringBuilder("Welcome");
        sb.Append("Hello");
        sb.Append(" World");
        Console.WriteLine(sb.ToString());


        //anonymous type: new
        //read only 
        //automatically created
        //Inferred from the initialization
        //Cannot be used as method parameter or return type

        var empData = new {name="Sachin",city="Pune",age=43 };
        Console.WriteLine(empData.name);
        Console.WriteLine(empData.age);
        Console.WriteLine(empData.city);
        //empData.name = "Vinita";
        string pname=empData.name;




        //if (args.Length > 0)
        //{
        //    foreach (string arg in args)
        //    {
        //        Console.WriteLine(arg);
        //        Console.WriteLine("---------");

        //    }


        //}
        Console.Read();
    }
}

//struct --int,float,double,decimal, datetime
//class--Object
//using System.Drawing;


//var unitPrice = 90.76f;
////unitPrice = 22342.333d;=== not allowed

//dynamic qtyInStock = 100;
//Console.WriteLine(qtyInStock);
//qtyInStock = "110 kgs";
//Console.WriteLine(qtyInStock);
//qtyInStock = false;
//Console.WriteLine(qtyInStock);

//bool isAvailable=false;
//Console.WriteLine(isAvailable);
//Color favColor = Color.Magenta;
//Nullable<Color> nonFavColor = null;
//Color? backcolor = Color.Red;
//Color defaultValue=backcolor.GetValueOrDefault();
//Console.WriteLine("BAckground color=" + defaultValue);

//Two types of data types:
//    1) Value: struct,enums
//    2) Reference: everything other than struct and enum

//Value types are stored on the stack
//Reference types are always store on the heap

//Value types cannot be assigned a null value
//Reference types can be assigned a null value

//Nullable<int> i = null;
//int? j = null;

//string name = null;





//int i=100000;
//double price = i + (i*.24);
//Console.WriteLine(price);
//string s = "17833";
//double s1 = Convert.ToDouble(i);
////string cannot be assigned to any numeric data types, then convert the string to double, or decimal or int or the
////datatype which u want to put it
//Decimal d1 = Convert.ToDecimal(s);
//i = Convert.ToInt32(s);

//string s2 = price.ToString();


//string s3 = "11abc";

////float f1=float.Parse(s3);
////float f1 = Convert.ToSingle(s3);

//float.TryParse(s3, out float f1);

//Console.WriteLine(f1);


////int p1=Int32.Parse(s3);

////float p2 = 11.4f;
////int p3 = Int32.Parse(p2);//can only convert/parse a string to a int
////int someValue=Convert.ToInt32(p2);//possible



////Console.WriteLine("Enter a radius");
////double radius =Convert.ToDouble(Console.ReadLine());

////Console.WriteLine("The data type of radius= "  + radius.GetType());
////Console.WriteLine("The value in  radius =" + radius);
////double area=3.14*radius*radius;
////Console.WriteLine("Area of circle= " + area);

//Console.WriteLine("The default date format= " + DateTime.Now) ;
//Console.WriteLine("Enter a date");
//DateTime joiningDate=Convert.ToDateTime(Console.ReadLine());
//Console.WriteLine(joiningDate);






//Console.ReadLine();





//Console.Write("Print Hello, World! and wait on the same line");
////printf
//Console.WriteLine("After Printing  this it will come next line....");


//object o = 93333.44f;
//o = "Jack";
////Every data type inherits from object data type. Object is the parent of all data types.
////Object being the biggest data type it can store anything
////Int32 its a datatype in terms of framework
//int i = 100;
//Console.WriteLine("The minimum value of integer= " + int.MinValue);
//Console.WriteLine("The maximum value of integer=" + int.MaxValue);
////It is a datatype which has a name "int" in C#, In vb.net int means "Integer"

//short r;

//long k;
//Console.WriteLine("The minimum value of Long= " + long.MinValue);
//Console.WriteLine("The maximum value of Long=" + long.MaxValue);


//string s = "Hello";
//float price = 41.19f;
//Console.WriteLine("The min value of float=" + float.MinValue);
//Console.WriteLine("The max value of float=" + float.MaxValue);

////for engg calculations use double
//double totalPrice = 322324.42d;
//Console.WriteLine("The min value of Double=" + double.MinValue);
//Console.WriteLine("The max value of Double=" + double.MaxValue);
//char c = 'A';
//DateTime dt = new DateTime(2024, 10, 4);

////for financial,monetary calculation use decimal
//decimal unitPrice;

//Console.WriteLine("The min value of Decimal=" + decimal.MinValue);
//Console.WriteLine("The max value of Decimal=" + decimal.MaxValue);

////Any numerical value want to store in string, use ToString() on the variable name.

//string StoreValueofI = i.ToString();



//Console.WriteLine(i);
//Console.WriteLine(s);
//Console.WriteLine(price);
//Console.WriteLine(totalPrice);
//Console.WriteLine(c);



//Console.Read();




/*This is  
 * multi line
 * a comment*/

