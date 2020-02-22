using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemServices.Models;
namespace ItemServices.Repository
{
   public interface IItemRepository
    {
        List<Items> GetAllItems();
        Items GetByID(string id);
        void AddItem(Items obj);
        void DeleteItem(string id);
        void updateItem(Items obj);
    }
}
