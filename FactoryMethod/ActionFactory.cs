using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
   public class ActionFactory
    {
        public IAction GetUserAction(String type)
        {
            IAction obj = null;
            if (type.ToLower().Equals("deposit"))
            {
                obj = new Deposit();

            }
            else if (type.ToLower().Equals("withdraw"))
            {
                obj = new Withdraw();
            }
            else
            {
                Console.WriteLine("Sorry Action can not be done");
            }
            return obj;

        }
    }
}
