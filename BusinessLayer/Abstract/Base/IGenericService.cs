using System.Collections.Generic;

namespace BusinessLayer.Abstract.Base
{
    public interface IGenericService<T> where T : class, new()
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        T GetById(int id);
        List<T> GetListAll();
    }
}
