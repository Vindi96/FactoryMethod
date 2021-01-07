using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
   public class Withdraw:IAction
    {
        public void Action(double a)
        {
            Console.WriteLine("Take your money Rs." + a);
        }
    }
}
