using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    //intent
    //encapsulate a family of algorithm claeed thorugha ccommon interface
    //algorithm change seperate from class
    //seperate calculations with delivery
    //we wnat open and close therefore not have to change a class when adding calculations
    //implementation
    //create classes for each calculation
    //common interface for each strategy
    //or use delegate and func or actions

 //   Define a family of algorithms, encapsulate each one, and make them interchangeable.

//Strategy lets the algorithm vary independently from the clients that use it.

//Capture the abstraction in an interface, bury implementation details in derived classes

//A bind once behavioral pattern.
    public class StrategyPattern
    {
        ICalculate<double, double> Calculator;

        void SetCalculator(ICalculate<double, double> calc)
        {
            Calculator = calc;
        }

        double Calculate(double input)
        {
           return Calculator.Calculate(input);
        }


    }
}
