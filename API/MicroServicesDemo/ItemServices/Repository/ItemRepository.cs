using ItemServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemServices.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly shopDBContext _context;
        public ItemRepository(shopDBContext context)
        {
            _context = context;
        }
        public void AddItem(Items obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteItem(string id)
        {
            Items i = _context.Items.Find(id);
            _context.Remove(i);
            _context.SaveChanges();
        }

        public List<Items> GetAllItems()
        {
            return _context.Items.ToList();
        }

        public Items GetByID(string id)
        {
            return _context.Items.Find(id);
        }

        public void updateItem(Items obj)
        {
            _context.Items.Update(obj);
            _context.SaveChanges();
        }
    }
}
