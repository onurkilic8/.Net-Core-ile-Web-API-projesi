using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Urunler
    {
        [Key]
        public Guid Id { get; set; }
        [Required]

        public int grup_no { get; set; }
        public int urun_no { get; set; }

        public string urun_adi { get; set; }

        public string marka { get; set; }

        public int gramaj { get; set; }

        public int fiyat { get; set; }
        public int puan { get; set; }

    }
}
