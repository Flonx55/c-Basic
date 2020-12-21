﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10方法
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            方法的参数：
            1）值参数：不含任何修饰符，当向方法传递参数时，编译程序给实参的值做一份拷贝，并且将此拷贝传递给该方法，
            被调用的方法不会修改内存中实参的值，所以使用值参数时可以保证实际值的安全性。在调用方法时，如果形参的类型
            是值参数的话，调用的实参的表达式必须保证是正确的值的表达式
            2）引用型参数：以ref修饰符声明的参数属于引用型参数。引用型参数本身并不创建新的存储空间，而是将实参的存储地址
            传递给形参，所以对形参的修改会影响原来实参的值。在调用方法前，引用型实参必须被初始化，同时在调用方法时，对应
            引用型参数的实参也必须使用ref修饰
            3）输出参数：以out修饰符声明的参数属于输出参数。与引用型参数类似，输出型参数也不开辟新的内存区域。它与引用型参数
            的差别在于，调用方法前无需对变量进行初始化。输出型参数用于传递方法返回的数据，out修饰符后应跟随与形参的类型相同
            的类型，用来声明在方法返回后传递的变量经过了初始化
            4）数组型参数：以params修饰符声明的参数属于数组型参数。params关键字可以指定在参数数目可变处采用数组参数。数组参数
            的类型必须是一维数组，而且必须是形参表中的最后一个参数，在方法的声明中只允许一个params关键字。有数组型参数就不能
            再有ref和out修饰符
            
            
            */
        }
    }
}
