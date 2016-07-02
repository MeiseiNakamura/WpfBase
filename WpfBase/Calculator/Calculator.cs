using System;

namespace Calculator
{
    public class Calculator
    {
        private string _number1;
        private string _number2;
        private string _answer;
        private int i;

        public string Number
        {
            get
            {
                switch (i)
                {
                    case 1:
                        return _number1;
                    case 2:
                        return _number2;
                    case 3:
                        return _answer;
                    default:
                        return "0";
                }
            }
        }

        public string Operator { get; private set; }


        public Calculator()
        {
            Initialize();
        }

        public void AddNumber(int number)
        {
            if (i == 1 || i == 3)
            {
                if (string.IsNullOrEmpty(Operator))
                {
                    i = 1;
                    if (_number1 == "0")
                    {
                        _number1 = number.ToString();
                    }
                    else
                    {
                        _number1 += number.ToString();
                    }
                }
                else
                {
                    i = 2;
                }
            }
            if (i == 2)
            {
                if (_number2 == "0")
                {
                    _number2 = number.ToString();
                }
                else
                {
                    _number2 += number.ToString();
                }
            }
        }

        public void Add()
        {
            SuccessionOperate();
            Operator = "+";
        }

        public void Substract()
        {
            SuccessionOperate();
            Operator = "-";
        }

        public void Multiple()
        {
            SuccessionOperate();
            Operator = "*";
        }

        public void Divide()
        {
            SuccessionOperate();
            Operator = "/";
        }

        public void Enter()
        {
            switch (Operator)
            {
                case "+":
                    _answer = (double.Parse(_number1) + double.Parse(_number2)).ToString();
                    break;
                case "-":
                    _answer = (double.Parse(_number1) - double.Parse(_number2)).ToString();
                    break;
                case "*":
                    _answer = (double.Parse(_number1) * double.Parse(_number2)).ToString();
                    break;
                case "/":
                    _answer = (double.Parse(_number1) / double.Parse(_number2)).ToString();
                    break;
                default:
                    Initialize();
                    return;
            }
            _number1 = "0";
            _number2 = "0";
            Operator = "";
            i = 3;
        }
        private void Initialize()
        {
            _number1 = "0";
            _number2 = "0";
            _answer = "0";
            i = 1;
        }
        private void SuccessionOperate()
        {
            if (i == 2 || i == 3)
            {
                if (i == 2)
                {
                    Enter();
                }
                _number1 = _answer;
            }
        }
    }
}