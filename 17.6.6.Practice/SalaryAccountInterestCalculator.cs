using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._6._6.Practice
{
    // Стратегия для зарплатного аккаунта
    public class SalaryAccountInterestCalculator : IInterestCalculator
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
