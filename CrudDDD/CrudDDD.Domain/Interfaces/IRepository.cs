using CrudDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudDDD.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);
        void Update(T obj);
        void Remmove(int id);
        T Select(int id);
        IList<T> SelectAll();
    }
}
