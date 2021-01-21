using System.Collections.Generic;

namespace GFTTeste1.Service.Interfaces
{
    public interface ICategoryService
    {
        List<string> GetCategoriesToString(List<Trade> portfolio);
    }
}