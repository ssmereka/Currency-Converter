/* Project 2 CIS 476 Design Patterns
 * By Scott Smereka
 * Problem 2
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrencyConverter
{
    abstract class Handler
    {
        protected Handler successor;
        public Handler Successor
        {
            get { return this.successor;   }
            set { this.successor = value;  }
        }

        public abstract String Process(String str); 
    }

    class USDHandler : Handler
    {
        public override String Process(String conversion)
        {
            Double convFactor = 1.4222;
            String[] str = conversion.Split(' ');
            if (str.Length == 4)
            {
                if ((str[1].ToLower() + str[2].ToLower() + str[3].ToLower()) == "eurotousd")
                    return (Double.Parse(str[0]) * convFactor).ToString();
            }
            return Successor.Process(conversion);
        }
    }

    class CADHandler : Handler
    {
        public override String Process(String conversion)
        {
            Double convFactor = 1.3697;
            String[] str = conversion.Split(' ');
            if (str.Length == 4)
            {
                if ((str[1].ToLower() + str[2].ToLower() + str[3].ToLower()) == "eurotocad")
                    return (Double.Parse(str[0]) * convFactor).ToString();
            }
            return Successor.Process(conversion);
        }
    }

    class AUDHandler : Handler
    {
        public override String Process(String conversion)
        {
            Double convFactor = 1.3688;
            String[] str = conversion.Split(' ');
            if (str.Length == 4)
            {
                if ((str[1].ToLower() + str[2].ToLower() + str[3].ToLower()) == "eurotoaud")
                    return (Double.Parse(str[0]) * convFactor).ToString();
            }
            return Successor.Process(conversion);
        }
    }

    class ErrorHandler : Handler
    {
        public override String Process(string str)
        {
            throw new NotImplementedException();
        }
    }
}
