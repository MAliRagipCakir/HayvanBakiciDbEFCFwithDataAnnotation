using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakiciDbEFCFwithDataAnnotation.Data
{
    [Table("Bakicilar")]
    public class Bakici
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Ad { get; set; }
        [Required,MaxLength(100)]
        public string Soyad { get; set; }

        public virtual ICollection<Hayvan> Hayvanlar { get; set; }
    }
}
