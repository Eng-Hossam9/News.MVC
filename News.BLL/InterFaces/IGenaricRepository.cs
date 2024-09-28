using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.BLL.InterFaces
{
    public interface IGenaricRepository<T>
    {
        IEnumerable<T> GetAll();
        T?  GetSpacific (int? id);
        int Add(T model);
        int Update(T model);
        int Delete(T model);
        int DeletebYiD(int? id);
    }
}
