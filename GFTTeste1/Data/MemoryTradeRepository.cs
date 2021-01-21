using GFTTeste1.Data.Interfaces;
using GFTTeste1.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GFTTeste1.Data
{
    public class MemoryTradeRepository : ITradeRepository
    {
        List<Category> memoryCategories;

        public MemoryTradeRepository()
        {
            this.memoryCategories = new List<Category> {
                new Category{ Id=1, Name= "LOWRISK", Sector = "Public", InitialValue=0, FinalValue=1000000 },
                new Category{ Id=2, Name= "MEDIUMRISK", Sector = "Public", InitialValue=1000000, FinalValue=Double.MaxValue },
                new Category{ Id=3, Name = "HIGHRISK", Sector = "Private", InitialValue = 1000000, FinalValue = Double.MaxValue } };
        }

        public Category AddCategory(string name, string sector, double initialvalue, double finalvalue)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategory()
        {
            return memoryCategories;
        }

        public int RemoveCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public int UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
