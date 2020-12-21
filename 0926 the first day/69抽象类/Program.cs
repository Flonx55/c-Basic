﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //当父类中的方法不知道如何去实现的时候,可以考虑将父类写成抽象类,方法写成抽象法

            //狗狗会叫 猫咪会叫

            //Animal a = new Animal();//抽象类不能创建对象

            Animal a = new Cat();
            a.Bark();           
            Console.ReadKey();
        }
    }
    public abstract class Animal
    {
        public abstract void Bark();//干脆就没有方法体 //让子类重写来实现多态

        //public void Test()
        //{
        //    //空实现
        //}     
    }
    public class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗狗汪汪的叫");
        }
    }
   public class Cat:Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵的叫");
        }
    }
    

    //抽象类成员必须标记位abstract,并且不能有任何实现
    //抽象成员必须在抽象类中
    //抽象类不能被实例化
    //子类继承抽象类后,必须把父类中的所有抽象成员都重写(除非子类也是一个抽象类,则可以不重写)
    //抽象成员的访问修饰符不能是private
    //在抽象类可以包含实例成员
    //并且抽象类的实例成员可以不被子类实现
    //抽象类是有构造函数,但是不能被实例化
    //   如果父类的抽象方法中有参数,那么,继承这个抽象父类的子类在重写父类的方法的时候必须传入对应的参数
    //如果抽象父类的抽象方法中有返回值,那么子类在重写这个抽象方法的时候,也必须要传入返回值
    //   如果父类中的方法有默认的实现,并且父类需要被实例化,这时可以考虑将父类定义成一个普通类,用虚方法来实现
    //多态,如果父类中的方法没有默认实现,父类也不需要被实例化,则可以将该类定义为抽象类




}
