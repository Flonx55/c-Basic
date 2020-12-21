﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //显示实现接口就是为了解决方法的重名的问题
            IFlyable fly = new Bird();
            fly.Fly();
            Bird bird = new Bird();
            bird.Fly();
            Console.ReadKey();
        }
    }
    public class Bird:IFlyable 
    {
        public void Fly()
        {
            Console.WriteLine("鸟会飞");
        }
        /// <summary>
        /// 显示实现接口
        /// </summary>
        void IFlyable.Fly()//接口里面默认public 类里面默认private
        {
            Console.WriteLine("我是接口的飞");
        }
    }
    public interface IFlyable
    {
        void Fly();
    }
}
