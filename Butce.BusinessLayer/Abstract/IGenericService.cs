﻿using Butce.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Butce.EntityLayer.Entities;
namespace Butce.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {

        void TAdd(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        T TGetByID(int id);
        List<T> TGetAll();
    }
}
