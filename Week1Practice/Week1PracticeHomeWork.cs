using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARING VARIABLES
            // 1. Declare a string variable called "myName" and set it equal to your name
            string myName = "Tyler";
            // 2. Declare a number varible called "myAge" and set it equal to your age
            int myAge = 20;
            // 3. Declare a boolean value called "myBool" and set it equal to true or false;
            bool myBool = true;
            // 4. Declare a new list of strings called "productsList" and set it equal to "basketball", "baseball glove", "tennis shoes", "hockey puck"

            // PRINTING VARIABLES TO THE CONSOLE USING CONSOLE.WRITELINE()
            // 1. Print your name to the console using the format: "My name is <myName> and I'm a beast of a programmer"
            Console.WriteLine("My name is " + myName + " and I'm a beast of a programmer");
            // 2. Print out your age to the console using the format: "I am <myAge> years awesome."
            Console.WriteLine("I am " + myAge + " years awesome.");
            // 3. Print out your boolean value using the format: "I set my boolean value equal to <myBool>"
            Console.WriteLine("I set my boolean value equal to " + myBool);
            // 4. Using a For loop, print out each value in productsList.
           
            // FOR LOOP PRACTICE
            // 1. Create a for loop that prints out the numbers 1 to 10.
            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine(i);
            }
            // 2. Create a for loop that prints out the numbers 10 to 1.
            for (int i = 10; i >= 1; i = i - 1)
            {
                Console.WriteLine(i);
            }
            // 3. Create a for loop that prints out the numbers 10 to 30, only printing the even numbers
            for (int i = 10; i <= 30; i = i + 2)
            {
                Console.WriteLine(i);
            }
            // 4. Create a for loop that prints out the numbers 100 to 75, only printing every 5th number (100, 95, 90, 85, 80, 75)
            for (int i = 100; i >= 75; i = i - 5)
            {
                Console.WriteLine(i);
            }

            // WHILE LOOP PRACTICE
            // 1. Create a while loop that prints out the numbers from 1 to 10.
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j = j + 1;
            }
            // 2. Create a while loop that prints out the numbers from 10 to 1.
            int t = 10;
            while (t >= 1)
            {
                Console.WriteLine(t);
                t = t - 1;
            }
            // 3. Create a while loop that prints out the numbers from 15 to 30, only printing the even numbers
            int f = 16;
            while (f <= 30)
            {
                Console.WriteLine(f);
                f = f + 2;
            }
            // 4. Create a while loop that prints out the numbers from 100 to 75, only printing every 5th number (100, 95, 90, 85, 80, 75)
            int a = 100;
            while (a >= 75)
            {
                Console.WriteLine(a);
                a = a - 5;
            }
            // 5. Create a while loop that prints out the numbers from 1 to 10 until it reaches one that is divisible by 4.
            int c = 1;
            while (c % 4 != 0)
            {
                Console.WriteLine(c);
                c = c + 1;
            }
     //2
    Greeting("Geronimo Jackson");
     //3
    Greeting(myName);
    //5
    DoubleIt(1337);
    //6
    DoubleIt(myAge);
    //8
    Multiply(2, 8);
    //9
    Multiply(3, myAge);
    //11
    LoopThis(20, 30);
    //12
    LoopThis(0, myAge);
    //14
    SuperLoop(0, 100, 15);
    //15
    SuperLoop(0, 200, myAge);
       
    //2
    Console.WriteLine(NewGreeting("Neil de Grasse Tyson"));
    //3
    Console.WriteLine(NewGreeting(myName));  
    //5
    Console.WriteLine("10 tripled is " + TripleIt(10));
    //6
    Console.WriteLine("My age tripled is " + TripleIt(myAge));
    //8
    Console.WriteLine(RealMultiply(5, 10));
    //9
    Console.WriteLine(RealMultiply(2, myAge));

    //1
    SuperLoop(RealMultiply(1, 5), TripleIt(myAge), myAge - 10);
    //2
    SuperLoop(RealMultiply(1, TripleIt(3)), TripleIt(RealMultiply(myAge, 7)), TripleIt(myAge - RealMultiply(2, 4)));
        
        }
    
            // PUTTING IT TOGETHER
            // Use either FOR or WHILE loops to accomplish the following:
            // 1. Print out the number of letters in your name using the format: "My name, <myName>, has <number of letters> in it."
            // 2. Print out the number of items in your list using the format: "My product list has <number of items> in it."
            // 3. Print out the number of letters of each item in productsList using the format: "<product> has <number of letters> in it."
            // DECLARING AND CALLING FUNCTIONS
          
            // 2. Call the Greeting function by passing in "Geronimo Jackson" as your parameter.
            // 3. Call the Greeting function by passing in myName as your parameter.
             
        
            // 5. Call your DoubleIt Function by passing in 1337 as your parameter.      
            // 6. Call your DoubleIt function by passing in myAge as your parameter.

            // 8. Call your Multiply function by passing in 2 and 8 as your parameters.       
            // 9. Call your Multiply function by passing in 3 and myAge as your parameters.

           
            // 11. Call your LoopThis function by passing in 20 and 30 as your parameters.
            // 12. Call your LoopThis function by passing in 0 and myAge as your parameters.

             
            //      You will need to track how many times the loop has been executed in a variable called "loopCount".
            //      This function will print out: 
            //          a. "I'm looping from <startNum> to <endNum>, incrementing <increment> each time"  
            //          b. The numbers from startNum to endNum, one per line.
            //          c. "That loop was craaaaaazy, we looped X times"
            // 14. Call your SuperLoop function by passing in 0, 100, and 15 as your parameters.
            // 15. Call your SuperLoop function by passing in 0, 200, and myAge as your parameters.

            //DECLARING AND CALLING RETURN FUNCTIONS
            
            // 2. Using your NewGreeting function as the parameter for Console.WriteLine(), call your NewGreeting function using the parameter "Neil deGrasse-Tyson"
            //          EX: Console.WriteLine(FunctionCall("myParameter"));
            // 3. Using your NewGreeting function as the parameter for Console.WriteLine(), call your NewGreeting function using the parameter myName.
            
           
            // 5. Using your TripleIt function as part of the parameter for Console.WriteLine(), 
            //      call your TripleIt function using the parameter of 10 to print out "10 tripled is <TripleIt Function Call>"
        
            // 6. Using your TripleIt function as part of the parameter for Console.WriteLine(), 
            //      call your TripleIt function using the parameter of myAge to print out "<myAge> tripled is <TripleIt Function Call>"

            
            // 8. Using your RealMultiply function as part of the parameter for Console.WriteLine(), 
            //      call your RealMultiply function using the parameter of 5 and 10 to print out the returned value from your function.
            // 9. Using your RealMultiply function as part of the parameter for Console.WriteLine(), 
            //      call your RealMultiply function using the parameter of 2 and myAge to print out the returned value from your function.

            //FUNCTION CALL MADNESS!
            // 1. Call your SuperLoop function using the following parameters:
            //      startNum = Call RealMultiply with the parameters 1, 5
            //      endNum = Call TripleIt with the parameter myAge
            //      increment = Call TripleIt with the parameter of myAge minus 10

            // 2. Call your SuperLoop function using the following parameters:
            //      startNum = Call RealMultiply with the parameters 1, and TripleIt with the parameter of 3.
            //      endNum = Call TripleIt with the parameter RealMultiply with the parameters: myAge, 7
            //      increment = Call TripleIt with the parameter of myAge minus RealMultiply with the parameters 2, 4.

            //START -- FUNCTION DECLARATIONS 
     // 1. Create a function called "Greeting" that takes one string parameter called "name".  This function will print "Hello <name>"
            static void Greeting(string name)
            {
                Console.WriteLine("Hello " + name);
            }
    
    // 4. Create a function called "DoubleIt" that takes one integer parameter called "number".  This function will print "<number> doubled is <number * 2>"
      static void DoubleIt(int number)
        {
            Console.WriteLine(number + " doubled is " + (number * 2));
        }
   
    // 7. Create a function called "Multiply" that takes two integer parameters called "num1" and "num2".  This function will print "<num1> times <num2> is <num1 * num2>"
        static void Multiply(int num1, int num2)
    {
        Console.WriteLine(num1 + " times " + num2 + " is " + num1 * num2);
    }

    
     // 10. Create a function called "LoopThis" that takes two integer parameters called "startNum" and "endNum".  
            //      This function will print out: 
            //          a. "I'm looping from <startNum> to <endNum>." 
            //          b. The numbers from startNum to endNum, one per line.
        static void LoopThis(int startNum, int endNum)
    {
        Console.WriteLine("I'm looping from " + startNum + " to " + endNum);
    }


     // 13. Create a function called "SuperLoop" that takes three integer parameters called "startNum", "endNum", and "increment".
        static void SuperLoop(int startNum, int endNum, int increment)
        {
            int loopCount = 0;
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum + " incrementing by " + increment + " each time.");
            for (int i = startNum; i = endNum; i = increment)
            {
                loopcount++;
                Console.WriteLine(i);
            }
            Console.WriteLine("That loop was craaaaazy, we looped " + loopcount + " this many times.");
        }
   



    // 1. Create a function called "NewGreeting" that takes one string parameter called "name".  This function will return a string in the format of "Hello, <name>"
    static void NewGreeting(string name)
    {
        Console.WriteLine("Hello, " + name);
    }

     // 4. Create a function called "TripleIt" that takes one integer parameter called "number".  This function will return the number times 3.
    static void TripleIt(int number)
    {
    Console.WriteLine(number * 3);

    }

        // 7. Create a function called "RealMultiply" that takes two integer parameters called "num1", and "num2".  This function will return the num1 * num2.
        static void RealMultiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
  
    //Example function declaration
        static void MyFunction(string myParameter)
        {
            //Code block
        }
    
        //END   -- FUNCTION DECLARATIONS 

        }


       
}    