using BankingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Account MyAccount;
            MyAccount = new Account();
            MyAccount.Name = "dani";
            Console.WriteLine ("MyAcount.name={0}" ,MyAccount.Name);

        }
    }
}
