using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.UrunlerData
{
    public class MockUrunlerData : IUrunlerData
    {
        private List<Urunler> urunlers = new List<Urunler>()
        {
            new Urunler()
            {
                Id=Guid.NewGuid(),
                marka = "Urun 1"
            },
             new Urunler()
            {
                Id=Guid.NewGuid(),
                marka = "Urun 2"
            }
        };
        public Urunler AddUrunler(Urunler urunler)
        {
            urunler.Id = Guid.NewGuid();
            urunlers.Add(urunler);
            return urunler;
        }

        public void DeleteUrunler(Urunler urunler)
        {
            urunlers.Remove(urunler);
        }

        public Urunler EditUrunler(Urunler urunler)
        {
            var existingUrunler = GetUrunler(urunler.Id);
            existingUrunler.marka = urunler.marka;
            return existingUrunler;
        }

        public Urunler GetUrunler(int grup_no)
        {
            throw new NotImplementedException();
        }

        public Urunler GetUrunler(Guid id)
        {
            return urunlers.SingleOrDefault(x => x.Id == id);
        }

        public List<Urunler> GetUrunlers()
        {
            return urunlers;
        }
    }
}
