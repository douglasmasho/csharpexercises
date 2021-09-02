using System;

namespace SalesTransactionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesTransaction sale1 = new SalesTransaction("Douglas", 2000, 0.2);
            SalesTransaction sale2 = new SalesTransaction("Farai", 1000, 0.1);
            SalesTransaction sale3 = sale1 + sale2;

            Console.WriteLine($"Sale 1: Salesperson: {sale1.getName()} \n Amount: {sale1.getAmount()} Commission: {sale1.getCommission()}");
            Console.WriteLine("..................................");
            Console.WriteLine($"Sale 2: Salesperson: {sale2.getName()} \n Amount: {sale2.getAmount()} Commission: {sale2.getCommission()}");
            Console.WriteLine("..................................");
            Console.WriteLine($"Sale 3: Salesperson: {sale3.getName()} \n Amount: {sale3.getAmount()}");


        }
    }
}
