/*using System;

namespace Add_Two_Numbers
{
    class Add
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1:");
            Console.WriteLine("Enter Number 2:");
            int Number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2:");
            int Number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Number1+Number2);
        }
    }
}

--------------------------------------------------------------------------------------------------------------------------------------------------

using System;

namespace MyApplication
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y:");
            int y = Convert.ToInt32(Console.ReadLine()); ;

            int sum = x + y;
            Console.WriteLine("sum=" + sum);
          
        }
    }
}

---------------------------------------------------------------------------------------------------------------------------------

using System;

namespace MyApplication
{
    class Car
    {
        // string color = "red";
        int color = 5;
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}

-------------------------------------------------------------------------------------------------------------------------------------

using System;


namespace MyApplication
{
    class Car
    {
        public string color = "red";
    }
}

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}

--------------------------------------------------------------------------------------------------------------------------------
//To print in Upper and lower case


using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"
        }
    }
}


-----------------------------------------------------------------------------------------------------------------------------------------
//Print the letter from where ever we want

using System;

namespace GetLastName
{
    class LastName
    {
        static void Main()
        {
            // Full name
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("h");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);
        }
    }
}


--------------------------------------------------------------------------------------------------------------------------------------------------------
//If,Else,If-Else


using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
        }
    }
}


-----------------------------------------------------------------------------------------------------------------------------------
//Ternary Operator


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = 20;
      string result = (time < 18) ? "Good day." : "Good evening.";
      Console.WriteLine(result);
    }
  }
}


------------------------------------------------------------------------------------------------------------------------------------
//Switch
*/
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int day = 4;
      switch (day) 
      {
        case 1:
          Console.WriteLine("Monday");
          break;
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        case 4:
           if(day < 4)
          {
            Console.WriteLine("It is Thursday");
          }
          else
          {
            Console.WriteLine("It is not Thursday");
          }
          break;
        case 5:
          Console.WriteLine("Friday");
          break;
        case 6:
          Console.WriteLine("Saturday");
          break;
        case 7:
          Console.WriteLine("Sunday");
          break;
        default:
           Console.WriteLine("It was not a day");
           break;

      }    
    }
  }
}
/*
-------------------------------------------------------------------------------------------------------------------------------------------------
//While

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      while (i < 5) 
      {
        Console.WriteLine(i);
        i++;
      }
    }
  }
}

//Do While

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      do 
      {
        Console.WriteLine(i);
        i++;
      }
      while (i > 5);
    }
  }
}

-------------------------------------------------------------------------------------------------------------------------------------
//For

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i <= 10; i = i + 2)
      {
        Console.WriteLine(i);
      }    
    }
  }
}

//Foreach

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
     
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      foreach (string i in cars) 
      {
        Console.WriteLine(i);
      }   
    }
  }
}

----------------------------------------------------------------------------------------------------------------------------------------


using System;

namespace Ifelse
{
 class If
 {
   static void Main(string[] args)
   {
            int number = 9;
            if (number < 5)
            {
                Console.WriteLine("The number is less than 5");
            }
            else if (number > 5)
            {
                Console.WriteLine("The number is greater than 5");
            }
            else if (number == 5)
            {
                Console.WriteLine("The number is equal to 5");
            }
            else
            {
                Console.WriteLine("The number is:" + number);
            }
        }
 }
}


-------------------------------------------------------------------------------------------------------------------------------------------------------


using System;

namespace Sulaiman
{
    class Sulai
    {
       
        static void MyMethod(string name)
        {
            Console.WriteLine(name + " It is My Method Code");
        }
        static void Main(string [] args)
        {
            MyMethod("nazi");
        }
    }
}

--------------------------------------------------------------------------------------------------------------------------------------------



using System;

namespace FullThrottle
{
    // The class
    class MyClass
    {
        // Class members
        string color = "red";        // field
        int maxSpeed = 200;          // field
      

        static void Main (string [] args)
        {
            MyClass myObj1 = new MyClass();
            Console.WriteLine(myObj1.color);

           // MyClass myObj2 = new MyClass();
            Console.WriteLine(myObj1.maxSpeed);

            Console.WriteLine("The car is going as fast as it can!");
        }

    }
}

---------------------------------------------------------------------------------------------------------------------------



//Call the Method

using System;

namespace MyApplication
{
    class Car
    {
        string color;                 // field
        int maxSpeed;                 // field
        public void Sulaiman()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.Sulaiman();  // Call the method
        }
    }
}

-------------------------------------------------------------------------------------------------------------------------------



//Constructors

using System;

namespace MyApplication
{
    // Create a Car class
    class Car
    {
        public string model;  // Create a field

        // Create a class constructor for the Car class
        public Car()
        {
            model = "Mustang"; // Set the initial value for model
        }

        static void Main(string[] args)
        {
            Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford.model);  // Print the value of model
        }
    }
}


//filename: Car.cs
using System;

namespace MyApplication
{
    class Car
    {
        public string model;

        // Create a class constructor with a parameter
        public Car(string modelName)
        {
            model = modelName;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang");
            Console.WriteLine(Ford.model);
        }
    }
}

----------------------------------------------------------------------------------------------------------



//Inheritance

using System;

namespace Inheritance
{

    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}
-----------------------------------------------------------------------------------------------------------------------------------------------------------



//Polymorphism

using System;

namespace MyApplication
{
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}

--------------------------------------------------------------------------------------------------------------------

//Abstraction

using System;

namespace MyApplication
{
  // Abstract class
  abstract class Animal
  {
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
      Console.WriteLine("Zzz");
    }
  }
  
  // Derived class (inherit from Animal)
  class Pig : Animal
  {
    public override void animalSound()
    {
      // The body of animalSound() is provided here
      Console.WriteLine("The pig says: wee wee");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Pig myPig = new Pig();  // Create a Pig object
      myPig.animalSound();
      myPig.sleep();
    }
  }
}

------------------------------------------------------------------------------------------------------------------------------

//Interface

using System;

namespace MyApplication
{
  interface IFirstInterface
  {
    void myMethod(); // interface method
  }

  interface ISecondInterface
  {
    void myOtherMethod(); // interface method
  }

  // Implement multiple interfaces
  class DemoClass : IFirstInterface, ISecondInterface
  {
    public void myMethod()
    {
      Console.WriteLine("Some text..");
    }
    public void myOtherMethod()
    {
      Console.WriteLine("Some other text...");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      DemoClass myObj = new DemoClass();
      myObj.myMethod();
      myObj.myOtherMethod();
    }
  }
}

-------------------------------------------------------------------------------------------------------------------------------------




//Enums

using System;

namespace MyApplication
{
    enum Level
    {
        Low,
        Medium,
        High
    }
    class Program
    {
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }
    }
}

//Enums using int

using System;

namespace MyApplication
{
    class Program
    {
        enum Months
        {
            January,    // 0
            February,   // 1
            March = 6,    // 6
            April,      // 7
            May,        // 8
            June,       // 9
            July        // 10
        }
        static void Main(string[] args)
        {
            int myNum = (int)Months.April;
            Console.WriteLine(myNum);
        }
    }
}

-----------------------------------------------------------------------------------------------------------------------------



//Files

using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "I am Mohamed";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content
        }
    }
}

--------------------------------------------------------------------------------------------------------------------------------------

*/