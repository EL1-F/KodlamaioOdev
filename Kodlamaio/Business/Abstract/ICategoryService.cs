﻿using Kodlamaio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Business.Abstract;

public interface ICategoryService
{
    List<Category> GetAll();
    void Add(Category category);
    void Update(Category category);
    void Delete(Category category);
}
