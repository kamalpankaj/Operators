using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic Operators
            //Variable declaration for Arithmetic Operators
            double FirstNumber = 14.40, SecondNumber = 4.60, RESULT;
            int Num1 = 26, Num2 = 4;
            //Variable declaration for  Relational Operators
            bool  result;
            int Num3 = 10, Num4 = 20;
            
            //Addition operator
            RESULT = FirstNumber + SecondNumber;
            Console.WriteLine("FirstNumber {0} + SecondNumber {1} = {2}",FirstNumber,SecondNumber,RESULT);

            //Subtraction operator
            RESULT = FirstNumber - SecondNumber;
            Console.WriteLine("FirstNumber {0} - SecondNumber {1} = {2}", FirstNumber, SecondNumber, RESULT);

            //Multiplication operator
            RESULT = FirstNumber * SecondNumber;
            Console.WriteLine("FirstNumber {0} * SecondNumber {1} = {2}", FirstNumber, SecondNumber, RESULT);

            //Multiplication operator
            RESULT = FirstNumber * SecondNumber;
            Console.WriteLine("FirstNumber {0} * SecondNumber {1} = {2}", FirstNumber, SecondNumber, RESULT);

            //Division operator
            RESULT = FirstNumber / SecondNumber;
            Console.WriteLine("FirstNumber {0} / SecondNumber {1} = {2}", FirstNumber, SecondNumber, RESULT);

            //Increment operator increases Integer Value by one
            Console.WriteLine("Value of FirstNumbetr{0}", FirstNumber);
            RESULT = ++FirstNumber;
            Console.WriteLine("Increment Operator Value of FirstNumber {0}", RESULT);

            //Decrement operator decreases integer value by one
            Console.WriteLine("Value of SecondNumber {0}",SecondNumber);
            RESULT = --SecondNumber;
            Console.WriteLine("Decrement operator Value of SecondNumber {0}", RESULT);

            //Modulo operator
            RESULT = Num1 % Num2;
            Console.WriteLine("Num1 {0} % Num2 {1} = {2}", Num1, Num2, RESULT);

            // Relational Operators

            //Equal to
            result = (Num3 == Num4);
            Console.WriteLine("{0} == {1} returns {2}", Num3, Num4, result);

            //Greater than
            result = (Num3 > Num4);
            Console.WriteLine("{0} > {1} returns {2}", Num3, Num4, result);

            //Less than
            result = (Num3 < Num4);
            Console.WriteLine("{0} < {1} returns {2}", Num3, Num4, result);

            //Greater than or equal to
            result = (Num3 >= Num4);
            Console.WriteLine("{0} >= {1} returns {2}", Num3, Num4, result);

            //Less than or equal to
            result = (Num3 <= Num4);
            Console.WriteLine("{0} <= {1} returns {2}", Num3, Num4, result);

            //Not equal to
            result = (Num3 != Num4);
            Console.WriteLine("{0} != {1} returns {2}", Num3, Num4, result);

           logicaloperators logicaloperators = new logicaloperators();
            logicaloperators.logicakoperators();

            Console.ReadKey();
        }
    }
}


