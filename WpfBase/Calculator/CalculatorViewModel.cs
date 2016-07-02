using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfBase;

namespace Calculator
{
    class CalculatorViewModel : ViewModelBase
    {
        private Calculator _model = new Calculator();
        public string NumberText
        {
            get { return _model.Number; }
        }
        public string OperatorText
        {
            get { return _model.Operator; }
        }
        public ICommand AddNumberCommand
        {
            get
            {
                return new SimpleCommand(param =>
                {
                    _model.AddNumber(int.Parse(param.ToString()));
                    OnPropertyChanged("NumberText");
                    OnPropertyChanged("OperatorText");
                });
            }
        }
        public ICommand AddCommand
        {
            get
            {
                return new SimpleCommand(param =>
          {
              _model.Add();
              OnPropertyChanged("NumberText");
              OnPropertyChanged("OperatorText");
          });
            }
        }
        public ICommand SubCommand
        {
            get
            {
                return new SimpleCommand(param =>
                {
                    _model.Substract();
                    OnPropertyChanged("NumberText");
                    OnPropertyChanged("OperatorText");
                });
            }
        }
        public ICommand MultipleCommand
        {
            get
            {
                return new SimpleCommand(param =>
                {
                    _model.Multiple();
                    OnPropertyChanged("NumberText");
                    OnPropertyChanged("OperatorText");
                });
            }
        }
        public ICommand DivideCommand
        {
            get
            {
                return new SimpleCommand(param =>
                {
                    _model.Divide();
                    OnPropertyChanged("NumberText");
                    OnPropertyChanged("OperatorText");
                });
            }
        }
        public ICommand Enter
        {
            get
            {
                return new SimpleCommand(param =>
                {
                    _model.Enter();
                    OnPropertyChanged("NumberText");
                    OnPropertyChanged("OperatorText");
                });
            }
        }
    }
}
