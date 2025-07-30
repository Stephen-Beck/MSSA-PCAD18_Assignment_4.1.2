/*
Create an interface named ICalculator with methods add, subtract, divide, and multiply.

Implement them in a class: MyMath
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._2
{
    public interface ICalculator
    {
        double Add(double num1, double num2);
        double Subtract(double num1, double num2);
        double Divide(double num1, double num2);
        double Multiply(double num1, double num2);
    }
}
