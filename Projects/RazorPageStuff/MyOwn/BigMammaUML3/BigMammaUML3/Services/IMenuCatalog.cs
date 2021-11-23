using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigMammaUML3.Models;

namespace BigMammaUML3.Services
{
    interface IMenuCatalog
    {
        void Add(MenuItem aMenuItem);
        MenuItem Search(int number);
        void Delete(int number);
        void Update(int number, MenuItem theMenuItem);
        List<MenuItem> FindAllDeepPan();
        List<MenuItem> FindAllNonAlcoholic();
        List<MenuItem> MostExpensiveMenuItem();
        List<MenuItem> GetAll();
    }
}
