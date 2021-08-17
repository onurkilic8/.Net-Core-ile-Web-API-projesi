using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication3.Models;

namespace WebApplication3.StokData
{
    public class SqlStokData : IStokData
    {
        private StokContext _stokContext;
        public SqlStokData(StokContext stokContext)
        {
            _stokContext = stokContext;
        }
        public Stok AddStok(Stok stok)
        {
            stok.Id = Guid.NewGuid();
            _stokContext.Stoklar.Add(stok);
            _stokContext.SaveChanges();
            return stok;
        }

        public void DeleteStok(Stok stok)
        {

            _stokContext.Stoklar.Remove(stok);
            _stokContext.SaveChanges();

        }

        public Stok EditStok(Stok stok)
        {
            var existingStok = _stokContext.Stoklar.Find(stok.Id);
            if (existingStok != null)
            {
                existingStok.stok_no = stok.stok_no;
                _stokContext.Stoklar.Update(existingStok);
                _stokContext.SaveChanges();
            }
            return stok;
        }

        public Stok GetStok(Guid id)
        {
            var stok = _stokContext.Stoklar.Find(id);
            return stok;
        }

        public List<Stok> GetStoklar()
        {
            return _stokContext.Stoklar.ToList();
        }


    }
}
