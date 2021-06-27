using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //ColorTest();
            //BrandTest();

            GetCarDetailsTest();

        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarsDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0}{1}{2}{3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandsDal());

            //brandManager.Add(new Brand { BrandName="Aston Martin"});
            // brandManager.Update(new Brand { BrandId = 3, BrandName = "Bugatti" });
            //brandManager.Delete(new Brand { BrandId = 9 });

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("{0}  / {1}", brand.BrandId, brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorsDal());

            //colorManager.Update(new Color { ColorId = 2, ColorName = "Kahverengi" });
            //colorManager.Add(new Color {ColorName="Kırmızı" });// ıd otomatik verildiği için id yazmadık

            //colorManager.Delete(new Color { ColorId = 11 });

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("{0} / {1}", color.ColorId, color.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarsDal());

            foreach (var item in carManager.GetCarByColorId(6))
            {
                Console.WriteLine(item.Description);
            }
            
            foreach (var item in carManager.GetCarByBrandId(1))
            {
                Console.WriteLine(item.Description);
            }
            
            //carManager.Add(new Car
            //{
            //    //Id = 2,
            //    BrandId = 3,
            //    ColorId = 6,
            //    ModelYear = 2020,
            //    Description = "Renault Clio",
            //    DailyPrice = 150

            //});

            //);

            //carManager.Update(new Car
            //{
            //    Id = 3,
            //    BrandId = 5,
            //    ColorId = 3,
            //    ModelYear = 2005,
            //    Description = "Renault Clio",
            //    DailyPrice = 100

            //}

            //);
            //carManager.Delete(new Car
            //{
            //    Id = 2,


            //}

            //);

            //foreach (var car in carManager.GetByAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
        }
    }
}
