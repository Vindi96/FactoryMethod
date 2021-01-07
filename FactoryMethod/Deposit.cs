using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
   public class Deposit:IAction
    {
        public void Action(double a)
        {
            Console.WriteLine("Great! you have deposited Rs." + a);
        }
    }
}
