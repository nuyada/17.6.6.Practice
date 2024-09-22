using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._6._6.Practice
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(Account account)
        {
            IInterestCalculator calculator;
            if (account.Type == "Обычный")
            {
                calculator = new OrdinaryAccountInterestCalculator();
                
            }
            else if(account.Type == "Зарплатный")
            {
                calculator = new SalaryAccountInterestCalculator();
                
            }
            else
            {
                throw new ArgumentException("Неизвестный тип учетной записи");
            }

            calculator.CalculateInterest(account);
        }
    }
}
