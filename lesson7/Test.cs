using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class Test
    {
    }

    class Automobile
    {
        public string name { get; set; }
        public string mark { get; set; }
        public string type { get; set; }
        public double engine_capacity { get; set; }

        public Automobile()
        {
            this.name = "None";
            this.mark = "None";
            this.type = "None";
            this.engine_capacity = 0;
        }

        public Automobile(string name, string mark, string type, double engine_capacity)
        {
            this.name = name;
            this.mark = mark;
            this.type = type;
            this.engine_capacity = engine_capacity;
        }
    }

    class BMW_X5 : Automobile
    {
        public BMW_X5()
        {
            this.name = "BMW X5M60i Sports";
            this.mark = "BMW";
            this.type = "Sport car";
            this.engine_capacity = 4.4;
        }
    }

    class Audi_A8 : Automobile
    {
        public Audi_A8()
        {
            this.name = "Audi A8 4.2 FSI quattro Tiptronic";
            this.mark = "Audi";
            this.type = "Sedan";
            this.engine_capacity = 4.2;
        }
    }

    class Hyundai_Solaris : Automobile
    {
        public Hyundai_Solaris()
        {
            this.name = "Hyundai Solaris 2020 2-Generation";
            this.mark = "Hyundai";
            this.type = "Sedan";
            this.engine_capacity = 1.6;
        }
    }
}