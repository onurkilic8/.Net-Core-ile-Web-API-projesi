using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Stok
    {
        [Key]
        public Guid Id { get; set; }
        [Required]

        public int stok_no { get; set; }
        public int urun_no { get; set; }
        public DateTime? giris_tarihi { get; set; }
        public int urun_sayisi { get; set; }
        public DateTime? uretim_tarihi { get; set; }
        public int? raf_omru { get; set; }

    }
}
