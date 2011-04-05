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
    abstract class Decorator : Handler
    {
        protected Handler handler;

        public Handler Handler
        {
            get { return this.handler; }
            set { this.handler = value; }
        }

        public override String Process(String str)
        {
            if (handler != null)
                return handler.Process(str);
            return "";
        }
    }

    class RoundDecorator : Decorator
    {
        public override String Process(String str)
        {
            return (Math.Round(Double.Parse(base.Process(str)), 2)).ToString();;
        }
    }

    class ExpNotationDecorator : Decorator
    {
        public override String Process(String str)
        { 
            return Double.Parse(base.Process(str)).ToString("e" + (base.Process(str).Length-2).ToString());
        }
    }

    class CurrencyNameDecorator : Decorator
    {
        public override string Process(string str)
        {
            String[] input = str.Split(' ');
            return base.Process(str) + " " + input[input.Length - 1].ToUpper();
        }
    }
}
