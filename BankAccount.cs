/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Lab Nine 2020
 * 
 * ############################# */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNine
{
    public class BankAccount
    {
        public decimal Balance { get; set; }
        public decimal OverdraftLimit { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            decimal availableFunds = Balance + OverdraftLimit;
            if (amount <= availableFunds)//ensuring there is enough money
            {
                Balance -= amount;
            }
        }
    }
}
