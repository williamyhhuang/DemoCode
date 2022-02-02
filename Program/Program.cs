using DemoCode.DesignPattern.Factory;
using DemoCode.DesignPattern.Observer;
using DemoCode.DesignPattern.Strategy;
using DemoCode.DesignPattern.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoCode.DesignPattern.Visitor.OriginVisitor;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // 將想測試的程式碼移除註解即可

            // TemplateMethod
            /*
            var dish = new DemoCode.DesignPattern.TemplateMethod.ChineseDish("辣炒牛肉空心菜");
            
            dish.Prepare();
            dish.Cook();
            dish.SetDish();
            dish.Done();
            */

            // Strategy
            /*
            var dish = new ChineseDish("辣炒牛肉空心菜");
            var cook = new Cooking(dish);

            cook.Prepare();
            cook.Cook();
            cook.SetDish();
            cook.Done();
            */

            // Factory
            /*
            IFactory factory = new Factory();

            IToy toy1 = factory.Make("KingKong");
            IToy toy2 = factory.Make("Gozilla");

            Console.WriteLine($"Toy I made is: {toy1.ToyName}");
            Console.WriteLine($"Toy I made is: {toy2.ToyName}");
            */

            // Observer
            /*
            ISubject newsCenter = new NewsCenter();

            IObserver reader1 = new Reader("Jack", CategoryEnum.Politics);
            IObserver reader2 = new Reader("Lily", CategoryEnum.Sports);

            newsCenter.RegisterObserver(reader1);
            newsCenter.RegisterObserver(reader2);

            News news1 = new News() { Category = CategoryEnum.Sports, Author = "Leo", Title = "2021東京奧運" };
            News news2 = new News() { Category = CategoryEnum.Politics, Author = "Jerry", Title = "莫德納疫苗抵台" };

            newsCenter.AddNews(news1);
            newsCenter.AddNews(news2);
            */

            // Adapter
            /*
            Console.WriteLine("Adapter 模式:");
            CatAdapter catAdapter = new CatAdapter(new Dog());
            catAdapter.Meow();

            Console.WriteLine("類別形式的 Adapter 模式:");
            CatAdapterClassType catAdapterClassType = new CatAdapterClassType();
            catAdapterClassType.Meow();
            */

            // OriginVisitor
            var bus = new Bus(1000, 20, true);
            var motor = new Motor(100, 2, false);

            var visitor = new Visitor();
            bus.Accept(visitor);
            motor.Accept(visitor);

            Console.Read();
        }
    }
}
