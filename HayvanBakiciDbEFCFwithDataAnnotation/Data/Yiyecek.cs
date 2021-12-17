using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakiciDbEFCFwithDataAnnotation.Data
{
    [Table("Yiyecekler")]
    public class Yiyecek
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        public DateTime UretimTarihi { get; set; }
        public DateTime? SonKullanmaTarihi { get; set; }
        public string YiyecekResimYolu { get; set; }

        [Range(0.0d, 2000.0d, ErrorMessage = "Kalori 0 ile 2000 arasında olmalıdır.")]
        public decimal? Kalori { get; set; }

        public virtual ICollection<Hayvan> BeniSevenHayvanlar { get; set; }
    }
}
