using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calculator
    {
         public double firstNumber;
         public double secondNumber;
         public double result;
         public string operation;
        

         public void calculate()
         {
             switch (operation)
             {
                 case "+":
                     result = firstNumber + secondNumber;
                     break;
                case "-":
                     result = firstNumber - secondNumber;
                     break;
                 case "x":
                     result = firstNumber * secondNumber;
                     break;
                 case "÷":
                     result = firstNumber / secondNumber;
                     break;
             }
         }
    }
}

