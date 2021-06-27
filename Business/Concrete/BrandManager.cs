using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandsDal _brandsDal;

        public BrandManager(IBrandsDal brandsDal)
        {
            _brandsDal = brandsDal;
        }

        public void Add(Brand brand)
        {
            _brandsDal.Add(brand);
        }

       
        public void Delete(Brand brand)
        {
            _brandsDal.Delete(brand);
        }

       

        public List<Brand> GetAll()
        {
            return _brandsDal.GetByAll();
        }

        public void Update(Brand brand)
        {
            _brandsDal.Update(brand);
        }

     
    }
}
