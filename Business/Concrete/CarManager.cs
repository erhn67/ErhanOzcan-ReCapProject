using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarsDal _carDal;

        public CarManager(ICarsDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);

        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);

        }

        public List<Car> GetByAll()
        {
            return _carDal.GetByAll();
        }


        public List<Car> GetCarByBrandId(int id)
        {
            return _carDal.GetByAll(b => b.BrandId == id);
        }

        public List<Car> GetCarByColorId(int id)
        {
            return _carDal.GetByAll(c => c.ColorId == id);
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
