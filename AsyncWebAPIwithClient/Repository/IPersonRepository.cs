using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncWebAPIwithClient.Repository
{
    public interface IPersonRepository<T, in TPK> where T : class
    {
        IEnumerable<T> Get();
        T Get(TPK id);
        IEnumerable<T> Add(T obj);
        IEnumerable<T> Update(TPK id, T obj);
        IEnumerable<T> Delete(TPK id);
    }
}
