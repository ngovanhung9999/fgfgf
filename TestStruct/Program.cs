using System;

namespace TestStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate point = new Coordinate(50, 78, null);
            //Coordinate point = null;
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            Console.WriteLine(point.sum());
        }
    }
    struct Coordinate:Hung
    {
        private int _x;
        private int _y;

        public string str;
        public Coordinate(int x, int? y, string str)
        {

            this._x = x;
            if (y != null)
            {
                this._y = (int)y;
            }
            else
            {
                this._y = 0;
            }
            this.str = str ?? "hung ngo";
            //this.str=str;
            //this.str=this.str?.ToUpper();
        }

        public int x
        {
            get { return _x; }
            set { _x = value; }
        }

        public int y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int sum()
        {
            throw new NotImplementedException();
        }
    }

    interface  Hung{
        int sum();
    }
    
}
