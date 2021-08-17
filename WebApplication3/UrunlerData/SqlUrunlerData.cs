using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.UrunlerData
{
    public class SqlUrunlerData : IUrunlerData
    {
        private UrunlerContext _urunlerContext;
        public SqlUrunlerData(UrunlerContext urunlerContext)
        {
            _urunlerContext = urunlerContext;
        }
        public Urunler AddUrunler(Urunler urunler)
        {
            urunler.Id = Guid.NewGuid();
            _urunlerContext.Urunlers.Add(urunler);
            _urunlerContext.SaveChanges();
            return urunler;
        }

        public void DeleteUrunler(Urunler urunler)
        {
            
            _urunlerContext.Urunlers.Remove(urunler);
            _urunlerContext.SaveChanges();
            
        }

        public Urunler EditUrunler(Urunler urunler)
        {
            var existingUrunler = _urunlerContext.Urunlers.Find(urunler.Id);
            if (existingUrunler != null)
            {
                existingUrunler.marka = urunler.marka;
                _urunlerContext.Urunlers.Update(existingUrunler);
                _urunlerContext.SaveChanges();
            }
            return urunler;
        }

        public Urunler GetUrunler(Guid id)
        {
           var urunler = _urunlerContext.Urunlers.Find(id);
            return urunler;
        }

        public List<Urunler> GetUrunlers()
        {
            return _urunlerContext.Urunlers.ToList();
        }

       
    }
}
