using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Amount");
            String input = Console.ReadLine();

            double money;
            bool result = Double.TryParse(input, out money);

            if (!result)
            {
                Console.WriteLine("Sorry Try again");

                return;
            }

            Console.WriteLine("Enter the needed action(Deposit or Wirhdrow) ");
            ActionFactory AF = new ActionFactory();
            IAction obj=AF.GetUserAction(Console.ReadLine());
            obj.Action(money);


            

           



            
        }
    }
}
