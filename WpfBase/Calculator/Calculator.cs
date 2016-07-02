using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator : ICalculator
    {
        public string Number
        {
            get
            {

                switch (_i)
                {
                    case 1:
                        return _number1.ToString();
                    case 2:
                        return _number2.ToString();
                    case 3:
                        return answer.ToString();
                    default:
                        return "";
                }

            }
        }

        public string Operator
        {
            get; private set;
        }

        public void Add()
        {
            if (_i == 2)
            {
                Enter();
                _number2 = 0;
                _number1 = (int)answer;
            }
            _i = 2;
            Operator = "+";
        }

        public void AddNumber(int num)
        {
            switch (_i)
            {
                case 1:
                    _number1 = int.Parse(_number1.ToString() + num.ToString());
                    break;
                case 2:
                    _number2 = int.Parse(_number2.ToString() + num.ToString());
                    break;
            }
        }
        private int _number1;
        private int _number2;
        private int _i = 1;
        private double answer;

        public void Divide()
        {
            if (_i == 2)
            {
                Enter();
                _number2 = 0;
                _number1 = (int)answer;
            }
            _i = 2;
            Operator = "/";
        }

        public void Enter()
        {
            switch (Operator)
            {
                case "+":
                    answer = _number1 + _number2;
                    break;
                case "/":
                    answer = (double)_number1 / _number2;
                    break;
                case "-":
                    answer = _number1 - _number2;
                    break;
                case "*":
                    answer = _number1 * _number2;
                    break;
                
            }

            _i = 3;
        }

        public void Multiple()
        {
            if (_i == 2)
            {
                Enter();
                _number2 = 0;
                _number1 = (int)answer;
            }
            _i = 2;
            Operator = "*";
        }

        public void Substract()
        {
            if (_i == 2)
            {
                Enter();
                _number2 = 0;
                _number1 = (int)answer;
            }
            _i = 2;
            Operator = "-";
        }
    }
}
