using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.StokData 
{
    public class MockStokData
    {
        private List<Stok> stoklar = new List<Stok>()
        {
            new Stok()
            {
                Id=Guid.NewGuid(),
                stok_no = 1
            },
             new Stok()
            {
                Id=Guid.NewGuid(),
                stok_no = 2
            }
        };
        public Stok AddStok(Stok stok)
        {
            stok.Id = Guid.NewGuid();
            stoklar.Add(stok);
            return stok;
        }

        public void DeleteStok(Stok stok)
        {
            stoklar.Remove(stok);
        }

        public Stok EditStok(Stok stok)
        {
            var existingStok = GetStok(stok.Id);
            existingStok.stok_no = stok.stok_no;
            return existingStok;
        }

        public Stok GetStok(int stok_no)
        {
            throw new NotImplementedException();
        }

        public Stok GetStok(Guid id)
        {
            return stoklar.SingleOrDefault(x => x.Id == id);
        }

        public List<Stok> GetStoklar()
        {
            return stoklar; 
        }
    }

    
}
