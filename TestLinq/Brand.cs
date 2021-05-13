using System;

namespace TestLinq
{
    class Brand
    {
        public string Name { set; get; }
        public int ID { set; get; }
        public override string ToString()
           => $"{ID} {Name}";
    }
}