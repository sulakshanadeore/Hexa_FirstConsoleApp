using System.Globalization;
using System.Runtime.CompilerServices;

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

        //NestedIFElseExample();

        //int _StatusCode = 2;
        //object _obj = 133;
        //int _no2 = 39;

        //switch (_obj)
        //{
        //    case string s:
        //     Console.WriteLine("Its a string....");
        //        break;

        //        case int i:
        //        Console.WriteLine("Its a integer");
        //        break;
        //    default:
        //        break;
        //}


        // switchCaseExample();
        //Find all even nos in 0 to 30
        //int i;

        //for (i=0; i<100;i++)
        //{
        //    if (i < 30)
        //    {

        //        if (i % 2 == 0)
        //            Console.WriteLine(i);
        //    }

        //}


        //int i = 0;
        //while (i < 30)
        //{
        //    if(i%2==0)
        //        Console.WriteLine(i);

        //    i++;
        //}


        //int i = 0;
        //do
        //{
        //    if (i%2==0)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    i++; 


        //} while (i < 30);

        //DoWhileExample();

        //Console.WriteLine("Enter a float number");
        //float _no1=Convert.ToSingle(Console.ReadLine());

        //Console.WriteLine(_no1);//direct print
        //Console.WriteLine("The number = " + _no1);//concat string with number
        //Console.WriteLine($"The number = {_no1}");//string interpolation
        //Console.WriteLine("The number= {0}", _no1); //placeholder
        //Console.WriteLine("-------------------------------------");
        //Console.WriteLine("Enter first number");
        //int fno=Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter second number");
        //int sno=Convert.ToInt32(Console.ReadLine());

        //int ans = fno + sno;
        //Console.WriteLine();
        //Console.WriteLine("The addition answer of {0} + {1}={2}",fno,sno,ans);
        //Console.WriteLine($"The addition answer of {fno} + {sno}={ans}");


        //Console.WriteLine("-----------------------------------");

        //WorkingInputOutput();

        //   string s = "Hello";
        //  // object s1 = s.Clone();//shallow copy, ie it points to string s;
        //   //Console.WriteLine("The value in s1= "  + s1);
        //   Console.WriteLine("The value in s= " + s);
        //   string s1 = "Hello";
        //   int i=s.CompareTo(s1);
        //   Console.WriteLine(i);
        //   int j=string.Compare(s,s1);//case difference and culture differene is considered here
        //   Console.WriteLine(j);
        //int k  = string.CompareOrdinal(s, s1);//ignore the case and culture difference
        //   Console.WriteLine(k);
        //  bool ans= s.Equals(s1);
        //   Console.WriteLine(ans);


        //  string pwd = "pass@123";
        //  Console.WriteLine("Enter password");
        //  string userpwd=Console.ReadLine();
        //int p=pwd.CompareTo(userpwd);
        //  if (p == 0)
        //  {
        //      Console.WriteLine("PAssword match");

        //  }
        //  else {

        //      Console.WriteLine("Passwords donot match");
        //  }







        //bool samepwd=pwd.Equals(userpwd);
        //if (samepwd) 
        //{
        //    Console.WriteLine("Passwords match");

        //}
        //else
        //{
        //    Console.WriteLine("Passwords donot match");
        //}



        //string concatenatedString=string.Concat(1 , 2);
        //   Console.WriteLine(concatenatedString);

        //string name = "John";
        //int age = 20;
        //string details=string.Format("Hello {0}, and my age is {1}", name, age);
        //Console.WriteLine(details);


        //double unitPrice = 23432.33;
        //int p = 70;
        //string s = string.Format("The price={0:C}", unitPrice);
        //string pf = string.Format("The price={0:P}", p);
        //Console.WriteLine(s);
        //Console.WriteLine(pf);

        //string username = "";
        //bool ans=string.IsNullOrEmpty(username);
        //Console.WriteLine(ans);

       DateTime dt= DateTime.Now;
        Console.WriteLine(dt);//current date and time
        int daysInMonth=DateTime.DaysInMonth(dt.Year,dt.Month);
        Console.WriteLine(daysInMonth);
        DateTime after10days=dt.AddDays(10);
        Console.WriteLine(after10days);
       bool ans= DateTime.IsLeapYear(dt.Year);
        Console.WriteLine(ans);














        //Read/ReadLine/ReadKey
        Console.ReadKey();

    }

    private static void WorkingInputOutput()
    {
        Console.WriteLine("enter first name");
        var name = Console.ReadLine();
        Console.WriteLine("enter Birth date");
        DateTime birthday = Convert.ToDateTime(Console.ReadLine());

        Console.WriteLine($"The details entered are, the firstname is {name} and the Age is {birthday}");
        Console.WriteLine("The details entered are, the firstname is {0} and the Age is {1}", name, birthday);

        //Console.WriteLine(fno);
        //Console.WriteLine(sno);
        //Console.WriteLine(ans);
    }

    private static void DoWhileExample()
    {
        string ans = "No";
        char userAns = 'N';
        do
        {
            Console.WriteLine("Enter a number");
            int _no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do u want to continue? Y/Yes");
            ans = Console.ReadLine();
            if (ans.Length == 1)
            {
                userAns = Convert.ToChar(ans);
                if (userAns == 'N' || ans == "No")
                {
                    Environment.Exit(1);
                }
                else
                    userAns = 'Y';
            }
            else if (ans.Length > 1)
            {
                if (ans == "No")
                {
                    Environment.Exit(1);
                }
                else
                    ans = "Yes";

            }
            else
            {
                ans = "No";
                userAns = 'N';
            }


        }
        while (ans == "Yes" || userAns == 'Y');
    }

    private static void switchCaseExample()
    {
        int _day = 3;
        switch (_day)
        {
            case 1 or 7:
                Console.WriteLine("its weekend");
                break;
            case > 5:
                Console.WriteLine("its weekend");
                break;
            case < 1 or > 7:
                Console.WriteLine("Invalid day");
                break;
            default:
                Console.WriteLine("Its a week day");
                break;
        }
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