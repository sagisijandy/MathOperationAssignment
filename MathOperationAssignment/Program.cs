using System;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations(); // instantiate the class

            math.MathOperation(5, 2); // call the method, passing in two numbers
            math.MathOperation(num2: 2, num1: 5); // call the method, specifying the parameters by name
        }
    }
}

   