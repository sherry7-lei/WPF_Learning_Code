using ComplexMvvmDemo.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexMvvmDemo.Services
{
    internal interface IDataServices
    {
        // 通过读取/Data/Data.xml文件，将菜单存储在Lish<Dish>中
        List<Dish> GetAllDishes();
    }
}
