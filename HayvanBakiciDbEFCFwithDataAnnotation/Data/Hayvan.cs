using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakiciDbEFCFwithDataAnnotation.Data
{
    [Table("Hayvanlar")]
    public class Hayvan
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı zorunludur."),MaxLength(200,ErrorMessage = "Ad uzunluğu çok uzun")]
        public string Ad { get; set; }
        public CinsiyetEnum Cinsiyet { get; set; }
        public bool SahibiVarMi { get; set; }

        [Required]
        public double Kutle { get; set; }
        public DateTime? DogumTarihi { get; set; }

        [Required,MaxLength(100,ErrorMessage = "Tur uzunluğu çok uzun.") ]
        public string Tur { get; set; }

        public string TurResimYolu { get; set; }

        [ForeignKey("Yiyecek")]
        public int? FavoriYiyecekId { get; set; }

        public virtual Yiyecek Yiyecek { get; set; }

        public virtual ICollection<Bakici> Bakicilar { get; set; }
    }
}
