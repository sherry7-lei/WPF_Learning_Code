using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexMvvmDemo.Services
{
    internal interface IOrderServices
    {
        // 将点菜结果输出到文本文件中
        void PlaceOrder(List<string> dishes);
    }
}
