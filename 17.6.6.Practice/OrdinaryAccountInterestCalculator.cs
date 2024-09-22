using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._6._6.Practice
{
    // Стратегия для обычного аккаунт
    public class OrdinaryAccountInterestCalculator : IInterestCalculator
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}
