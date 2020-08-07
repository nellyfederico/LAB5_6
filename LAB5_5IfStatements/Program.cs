using System;

namespace LAB5_5IfStatements
{
    class Program
    {
    public struct Customer
    {
         public string first_name;
         public string last_name;
         public int age;
         public bool Membership;
        }
        static void Main(string[] args)
        {
        
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.first_name = "Ryan";
            customer1.last_name = "Sloan";
            customer1.age = 20;
            customer1.Membership = false;

            customer2.first_name = "Maggie";
            customer2.last_name = "Green";
            customer2.age = 30;
            customer2.Membership = false;

            customer3.first_name = "Avery";
            customer3.last_name = "Ford";
            customer3.age = 45;
            customer3.Membership = true;

            Customer[] TotalCustomers = { customer1, customer2, customer3 };

            for (int i = 0; i < TotalCustomers.Length; i++)
            {
                if (TotalCustomers[i].age < 21)
                {
                    Console.WriteLine(TotalCustomers[i].first_name + " " + TotalCustomers[i].last_name + " cannot place an order");
                }
                else
                {
                    Console.WriteLine(TotalCustomers[i].first_name + " " + TotalCustomers[i].last_name + " can place an order");
                }

                if (TotalCustomers[i].Membership == true)
                {
                    Console.WriteLine(TotalCustomers[i].first_name + " " + TotalCustomers[i].last_name + " has a premium membership.");
                }
                else
                {
                    Console.WriteLine(TotalCustomers[i].first_name + " " + TotalCustomers[i].last_name + " is a standard membership.");
                }




            }
        }
    }
}
