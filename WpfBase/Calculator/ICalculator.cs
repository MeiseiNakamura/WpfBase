using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculator
    {
        string Number { get; }
        string Operator { get; }
        void AddNumber(int num);
        void Add();
        void Substract();
        void Multiple();
        void Divide();
        void Enter();
    }
}
