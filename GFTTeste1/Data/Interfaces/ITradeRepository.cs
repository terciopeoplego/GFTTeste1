using GFTTeste1.Entity;
using System.Collections.Generic;

namespace GFTTeste1.Data.Interfaces
{
    public interface ITradeRepository
    {
        List<Category> GetAllCategory();
        Category AddCategory(string name, string sector, double initialvalue, double finalvalue);
        int RemoveCategory(Category category);
        int UpdateCategory(Category category);
        bool SaveChanges();
    }
}