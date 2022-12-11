﻿using Busines.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;   
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();    
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c =>c.BrandId == id); 
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c=> c.ColorId == id);
        }
    }
}
