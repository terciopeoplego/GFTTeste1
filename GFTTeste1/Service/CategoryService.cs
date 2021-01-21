using GFTTeste1.Data.Interfaces;
using GFTTeste1.Entity;
using GFTTeste1.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GFTTeste1.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ITradeRepository _tradeRepository;

        public CategoryService(ITradeRepository tradeRepository)
        {
            _tradeRepository = tradeRepository;
        }

        public List<string> GetCategoriesToString(List<Trade> portfolio)
        {
            List<Category> categories = _tradeRepository.GetAllCategory();
            List<string> tradeCategories = new List<string>();
            portfolio.ForEach(item =>
               tradeCategories.Add(ClassifyTrade(item, categories)));
            return tradeCategories;

        }

        private string ClassifyTrade(Trade iTrade, List<Category> categories)
        {
            foreach (var item in categories)
            {
                if (iTrade.ClientSelector == item.Sector)
                {
                    if (iTrade.Value >= item.InitialValue && iTrade.Value <= item.FinalValue)
                        return item.Name;
                }
            }
            return "";
        }
    }
}
