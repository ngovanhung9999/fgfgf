using System;
using System.Text;
namespace Event2
{
    //public delegate void NumberInputEvent(int i);
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            NumberInput number = new NumberInput();
            SubscriberA subA = new SubscriberA();
            SubscriberB subB = new SubscriberB();

            subA.Subscriber(number);
            subB.Subscriber(number);
            number.InputNumber();
        }
    }
    //subscribers
    public class SubscriberA
    {
        public void Subscriber(NumberInput numberInput)
        {
            numberInput.InputEvent += Sqrt;
        }

        public void Sqrt(Object obj, NumberInputEventArgs e)
        {
            Console.WriteLine($"căn bật hai của {e.Number} là {Math.Sqrt(e.Number)}");
        }

    }
    //subscribers
    public class SubscriberB
    {
        public void Subscriber(NumberInput numberInput)
        {
            numberInput.InputEvent += Square;
        }

        public void Square(Object obj, NumberInputEventArgs e)
        {
            Console.WriteLine($"căn bật hai của {e.Number} là {e.Number * e.Number}");
        }
    }


    //publisher 
    public class NumberInput
    {
        //public NumberInputEvent InputEvent { get; set; }
        public event EventHandler<NumberInputEventArgs> InputEvent;
        private int _Number;

        public int Number
        {
            get => _Number;
            set
            {
                _Number = value;
                InputEvent?.Invoke(this, new NumberInputEventArgs(_Number));
            }
        }

        public void InputNumber()
        {
            Console.Write("Nhập số:");
            string strNumber = Console.ReadLine();
            int number;
            Int32.TryParse(strNumber, out number);
            _Number = number;
            InputEvent?.Invoke(this, new NumberInputEventArgs(_Number));
        }
    }
    public class NumberInputEventArgs : EventArgs
    {
        public int Number { get; }
        public NumberInputEventArgs(int number)
        {
            Number = number;
        }
    }

}
