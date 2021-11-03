using System;

namespace concat_interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphebet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";     //Length
            Console.WriteLine("The length of the txt string is: " + alphebet.Length);

            string Name = "Mohamed Sulaiman";
            Console.WriteLine(Name.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(Name.ToLower());   // Outputs "hello world"

            string firstName = "Mohamed "; //String Concatenation
            string lastName = "Sulaiman";
            string name = firstName + lastName;
            Console.WriteLine(name);

            string fName = "Mohamed ";
            string lName = "Lukman";
            string names = string.Concat(fName, lName);
            Console.WriteLine(names);

            string Name1 = "Nazi"; //String Interpolation
            string Name2 = "bullah";
            string name1 = $"My full name is: {Name1} {Name2}";
            Console.WriteLine(name1);

            string myString = "Hello";// Access String : to print The Letter 
            Console.WriteLine(myString[0]);// output is H

            string mystring = "Hello";
            Console.WriteLine(mystring.IndexOf("e"));  // Outputs "1"

            string name3 = "John Doe";
            // Location of the letter D
            int charPos = name3.IndexOf("D");
            // Get last name
            string last = name3.Substring(charPos);
            Console.WriteLine(last);

            string txt = "We are the so-called \"Vikings\" from the north."; //To enter "" inside a "" we should use \"

            string txt1 = "Hello\nWorld!";// to print in new line \n and \t- for tab \b- backspace
            Console.WriteLine(txt1);
        }
    }
}
