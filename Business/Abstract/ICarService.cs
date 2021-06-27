using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetByAll();
        List<Car> GetCarByBrandId(int id);
        List<Car> GetCarByColorId(int id);
        void Add(Car car);
        void Update(Car car);
        void  Delete(Car car);

        List<CarDetailsDto> GetCarDetails();
    }
}
