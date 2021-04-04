﻿using System;
using DemoCode.DesignPattern.Factory;

namespace DemoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // 將想測試的程式碼移除註解即可

            // TemplateMethod
            /*
            var dish = new DesignPattern.TemplateMethod.ChineseDish("辣炒牛肉空心菜");
            
            dish.Prepare();
            dish.Cook();
            dish.SetDish();
            dish.Done();
            */

            // Strategy
            /*
            var dish = new DesignPattern.Strategy.ChineseDish("辣炒牛肉空心菜");
            var cook = new DesignPattern.Strategy.Cooking(dish);

            cook.Prepare();
            cook.Cook();
            cook.SetDish();
            cook.Done();
            */

            // Factory
            IFactory factory = new Factory();

            IToy toy1 = factory.Make("KingKong");
            IToy toy2 = factory.Make("Gozilla");

            Console.WriteLine($"Toy I made is: {toy1.ToyName}");
            Console.WriteLine($"Toy I made is: {toy2.ToyName}");
        }
    }
}
