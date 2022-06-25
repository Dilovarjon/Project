using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bank bank = new Bank();
            bank.Register();*/
            Data_Collection data_Collection = new Data_Collection();
            data_Collection.Registration();
            data_Collection.Data_Usage();
        }
    }
}
