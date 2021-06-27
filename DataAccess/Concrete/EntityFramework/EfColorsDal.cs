using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorsDal : EfEntityRespositoryBase<Color, RentcarContext>, IColorsDal
    {
        

            //using (RentcarContext context = new RentcarContext())
            //{
            //    var result = from c in context.Cars
            //                 join b in context.Brands
            //                 on c.BrandId equals b.BrandId
            //                 join co in context.Colors
            //                 on c.ColorId equals co.ColorId
            //                 select new CarDetailDto
            //                 {
            //                     CarId = c.Id,
            //                     CarName = c.Description,
            //                     BrandName = b.BrandName,
            //                     ColorName = co.ColorName,
            //                     DailyPrice = c.DailyPrice
            //                 };
            //    return result.ToList();
            //}
        //}

        //public void Delete(Color entity)
        //{
        //    using (RentcarContext context = new RentcarContext())
        //    {
        //        //var deletedEntity = context.Entry(entity);
        //        //deletedEntity.State = EntityState.Deleted;

        //        context.Colors.Remove(context.Colors.SingleOrDefault(p => p.ColorId == entity.ColorId));
        //        context.SaveChanges();

        //    }
        //}

        

        //public List<Color> GetByAll(Expression<Func<Color, bool>> filter = null)
        //{
        //    using (RentcarContext context = new RentcarContext())
        //    {
        //        return filter == null ? context.Set<Color>().ToList() :
        //            context.Set<Color>().Where(filter).ToList();
        //        // return context.Cars.ToList();
        //    } 
        //}

        //public Color GetById(int Id)//Expression<Func<Car, bool>> filter)
        //{
        //    using (RentcarContext context = new RentcarContext())
        //    {
        //        return context.Set<Color>().SingleOrDefault(p => p.ColorId == Id);
        //        //return context.where
        //    }
        //}

        //public Color GetById(Expression<Func<Color, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Color entity)
        //{
        //    using (RentcarContext context = new RentcarContext())
        //    {
        //        //var updatedEntity = context.Entry(entity);
        //        //updatedEntity.State = EntityState.Modified;
        //        var productToUpdate = context.Set<Color>().SingleOrDefault(p => p.ColorId == entity.ColorId);
        //        productToUpdate.ColorName = entity.ColorName;
        //        productToUpdate.ColorId = entity.ColorId;
               
        //        //context.Cars.Update(entity);
        //        context.SaveChanges();
        //    }
        //}
    }
}
