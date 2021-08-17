using System;
using System.Collections.Generic;
using WebApplication3.Models;

namespace WebApplication3.UrunlerData
{
   public interface IUrunlerData
    {
        List<Urunler> GetUrunlers();

        Urunler GetUrunler(Guid id);

        Urunler AddUrunler(Urunler urunler);

        void DeleteUrunler(Urunler urunler);

        Urunler EditUrunler(Urunler urunler);
       
    }
}
