using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EasyWeb.Data
{
    public interface IRepositoryBase<T> where T: class
    {
        IEnumerable<T> GetItems();
        T GetItem(Expression<Func<T, bool>> condition);
        IEnumerable<T>GetItems(Expression<Func<T, bool>> condition);

        void AddItem(T entity);
        void AddItems(IEnumerable<T> entities);

        void DeleteItem(int id);
        void DeleteItems(IEnumerable<T> entities);

        void UpdateItem(T entity);
        T FindItemById(int id);

        IEnumerable<T> GetDataPaging(Expression<Func<T, bool>> where, int total, int currentPage, int pageSize, string[] includes = null);

    }
}
