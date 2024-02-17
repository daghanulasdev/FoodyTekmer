﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerDataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Delete(T t);
        void Insert(T t);
        void Update(T t);
        T GetById(int id);
        List<T> GetList();

    }
}
