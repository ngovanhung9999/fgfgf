using System;
using System.Text;
namespace Event2
{
    public delegate void NumberInputEvent(int i);
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

    public class SubscriberA
    {
        public void Subscriber(NumberInput numberInput)
        {
            numberInput.InputEvent = Sqrt;
        }

        public void Sqrt(int number)
        {
            Console.WriteLine($"căn bật hai của {number} là {Math.Sqrt(number)}");
        }

    }

    public class SubscriberB
    {
        public void Subscriber(NumberInput numberInput)
        {
            numberInput.InputEvent = Square;
        }

        public void Square(int number)
        {
            Console.WriteLine($"căn bật hai của {number} là {number * number}");
        }

    }

    public class NumberInput
    {
        public NumberInputEvent InputEvent { get; set; }
        private int _Number;

        public int Number
        {
            get => _Number;
            set
            {
                _Number = value;
                InputEvent?.Invoke(_Number);
            }
        }

        public void InputNumber()
        {
            Console.Write("Nhập số:");
            string strNumber = Console.ReadLine();
            int number;
            Int32.TryParse(strNumber, out number);
            _Number = number;
            InputEvent?.Invoke(Number);
        }
    }

}
