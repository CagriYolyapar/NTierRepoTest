using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPattern.UnitOfWorks.IntRep
{
    public interface IRepository<T>
    {
        List<T> GetActive();
        List<T> GetPassives();
        List<T> GetUpdateds();
        List<T> GetAll();



        void Add(T item);
        void Delete(T item);
        void Update(T item);
        void SpecialDelete(int id);



        
    }
}
   
