namespace PizzaRestaurant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPHIEU")]
    public partial class CHITIETPHIEU
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaChiTietPhieu { get; set; }

        public int MaPhieu { get; set; }

        public int MaMonAn { get; set; }

        public int? SoLuong { get; set; }

        public virtual MONAN MONAN { get; set; }

        public virtual PHIEUDATCHO PHIEUDATCHO { get; set; }
    }
}
