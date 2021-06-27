using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarsDal// : //ICarsDal
    {
        List<Car> _car;

        public InMemoryCarsDal()
        {
            _car = new List<Car> {

                new Car{Id=1, BrandId=1, ColorId=1, ModelYear= 2015, DailyPrice=200, Description="Opel"},
                new Car{Id=2, BrandId=1, ColorId=3, ModelYear= 2017, DailyPrice=250, Description="Renault"},
                new Car{Id=3, BrandId=2, ColorId=6, ModelYear= 2016, DailyPrice=300, Description="Hyundai"},
                new Car{Id=4, BrandId=2, ColorId=5, ModelYear= 2013, DailyPrice=350, Description="Nissan"},
                new Car{Id=5, BrandId=3, ColorId=7, ModelYear= 2015, DailyPrice=250, Description="BMW"},
                new Car{Id=6, BrandId=4, ColorId=8, ModelYear= 2020, DailyPrice=150, Description="Audi"},
            
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);

            Console.WriteLine(car.Id + " nolu " + car.Description + " özellikli " + car.ModelYear + " Model yılı olan araç eklendi.");
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove( carToDelete);
            Console.WriteLine(carToDelete.Id + "ye sahip araç silindi.");
        }

        public List<Car> GetByAll()
        {
            return _car;
        }

        public List<Car> GetByAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _car.Where(c => c.Id == carId).ToList();
            
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updateToCar = _car.SingleOrDefault(c => c.Id == car.Id);
            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.ModelYear = car.ModelYear;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;

        }
    }
}
