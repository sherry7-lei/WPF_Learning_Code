using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexMvvmDemo.Modles
{
    // 属性：菜品
    internal class Dish
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Comment { get; set; }
        public double Score { get; set; }
    }
}
