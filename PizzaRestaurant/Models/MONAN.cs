namespace PizzaRestaurant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONAN")]
    public partial class MONAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONAN()
        {
            CHITIETPHIEUx = new HashSet<CHITIETPHIEU>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaMonAn { get; set; }

        [StringLength(150)]
        public string TenMonAn { get; set; }

        [StringLength(400)]
        public string MoTa { get; set; }

        public double? Gia { get; set; }

        public int MaDMMonAn { get; set; }

        [StringLength(150)]
        public string Anh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEU> CHITIETPHIEUx { get; set; }

        public virtual DANHMUCMONAN DANHMUCMONAN { get; set; }
    }
}
