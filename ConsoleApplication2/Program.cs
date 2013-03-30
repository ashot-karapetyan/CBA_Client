using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            CBA.GateSoapClient  client = new  CBA.GateSoapClient ( );
            client.Open();
            CBA.ExchangeRates rates = client.ExchangeRatesByDate(DateTime.Today );
            foreach (var rate in rates.Rates)
            {
                Console.WriteLine(rate.ISO + "  " + rate.Rate + " for " + rate.Amount); 
            
            }
            Console.ReadLine();
                
   
        }
    }
}
