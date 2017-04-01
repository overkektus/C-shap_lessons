using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface IAccount
{
        int CurrentSum { get; } // текущая сумма на счету
        void Put(int sum); // положить денги на счет
        void Withdraw(int sum); // взять со счета
        int Percentage { get; } // процент начислений
}
}
