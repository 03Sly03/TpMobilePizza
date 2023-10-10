using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using TpMobilePizza.Models;

namespace TpMobilePizza.Services
{
    public interface IMyPizzaService
    {
        bool Delete(int id);
        List<MyPizza> GetAll();
        List<MyPizza> GetAll(Expression<Func<MyPizza, bool>> predicate);
        MyPizza GetById(Expression<Func<MyPizza, bool>> predicate);
        MyPizza GetById(int id);
        void Post(MyPizza myPizza);
        void Update(MyPizza myPizza);
    }
}