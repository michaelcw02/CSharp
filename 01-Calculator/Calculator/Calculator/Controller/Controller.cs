using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    class Controller
    {
        private MainWindow View { set; get; }
        enum Numbers        { ZERO, ONE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE }
        string Current      { get; set; }
        string Operation    { get; set; }
        Boolean hasOperation { get; set; }
        double? Stored;

        public Controller (MainWindow view)
        {
            View = view;
            Current = "0";
            Operation = "None";
            Stored = null;
            setTextBoxValue(Current);
        }


        public void setTextBoxValue(string value)
        {
            View.textBox.Text = value;
        }

        public void enteredValue(string value)
        {
            Numbers num;
            if(Enum.TryParse(value, true, out num))
            {
                Current = (hasOperation) ? ((int)num).ToString() : Current + (int)num;
                setTextBoxValue(Current);
                return;
            }
            switch(value)
            {
                case "COMMA":
                    Current += ".";
                    setTextBoxValue(Current);
                    break;
                case "CLEAR_ENTRY":
                    Current = "0";
                    setTextBoxValue(Current);
                    break;
                case "CLEAR":
                    Console.WriteLine("CLEAR");
                    Current = "0";
                    Stored = 0;
                    Operation = "None";
                    hasOperation = false;
                    Stored = null;
                    setTextBoxValue(Current);
                    break;
                case "PLUS":
                case "MINUS":
                case "MULTIPLIED":
                case "DIVIDED":
                    Operation = value;
                    prepOperation(Double.Parse(Current));
                    hasOperation = true;
                    break;
                case "EQUALS":
                    double r = (Stored == null) ? doOperation(Stored ?? default(double), Double.Parse(Current), Operation) 
                                                : doOperation(Double.Parse(Current), Double.Parse(Current), Operation);
                    setTextBoxValue(r.ToString());
                    Current = r.ToString();
                    Stored = null;
                    hasOperation = false;
                    break;
                default:
                    break;
            }
            
        }

        public void prepOperation(double current)
        {
            Stored = (Stored != null) ? doOperation(Stored ?? default(double), current, Operation) : current;
            setTextBoxValue(Stored.ToString());
        }

        public double doOperation(double first, double second, string operation)
        {
            double result;
            switch(operation)
            {
                case "PLUS":
                    result = first + second;
                    break;
                case "MINUS":
                    result = first - second;
                    break;
                case "MULTIPLIED":
                    result = first * second;
                    break;
                case "DIVIDED":
                    //exception of dividing by 0
                    result = first / second;
                    break;
                default:
                    Console.WriteLine("Operation not created yet");
                    result = -1;
                    break;
            }
            return result;
        }

    }

}
