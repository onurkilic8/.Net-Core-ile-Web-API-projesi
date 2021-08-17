using System;
using System.Collections.Generic;
using WebApplication3.Models;

namespace WebApplication3.StokData
{
    public interface IStokData
    {
        List<Stok> GetStoklar();

        Stok GetStok(Guid id);

        Stok AddStok(Stok stok);

        void DeleteStok(Stok stok);

        Stok EditStok(Stok stok);

    }
}
