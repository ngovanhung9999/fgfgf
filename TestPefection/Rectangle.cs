using System;

namespace TestPefection
{
    [DeBugInfo(45, "Tran Nam", "2/8/2016", Message = "Kieu tra ve khong hop le")]
    [DeBugInfo(49, "Minh Chinh", "10/10/2016", Message = "Bien khong duoc su dung")]

    class Rectangle
    {
        //cac bien thanh vien
        protected double chieu_dai;
        protected double chieu_rong;
        public Rectangle(double l, double w)
        {
            chieu_dai = l;
            chieu_rong = w;
        }
        [DeBugInfo(55, "Tran Nam", "2/8/2016", Message = "Kieu tra ve khong hop le")]
        public double tinhDienTich()
        {
            return chieu_dai * chieu_rong;
        }
        [DeBugInfo(56, "Minh Chinh", "19/10/2016")]
        public void Display()
        {
            Console.WriteLine("Chieu dai: {0}", chieu_dai);
            Console.WriteLine("Chieu rong: {0}", chieu_rong);
            Console.WriteLine("Dien tich: {0}", tinhDienTich());
        }
    }
}