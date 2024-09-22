using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._6._6.Practice
{
    // Интерфейс для стратегии расчета процентной ставки
    public interface IInterestCalculator
    {
        void CalculateInterest(Account account);
    }
}
