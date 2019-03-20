namespace PizzaRestaurant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDATCHO")]
    public partial class PHIEUDATCHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDATCHO()
        {
            CHITIETPHIEUx = new HashSet<CHITIETPHIEU>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhieu { get; set; }

        public int MaBanAn { get; set; }

        public DateTime? NgayTaoPhieu { get; set; }

        public DateTime? NgayDatBan { get; set; }

        public int MaTinhTrangPhieu { get; set; }

        public double? TongTien { get; set; }

        public int MaNhanVien { get; set; }

        public int MaKhach { get; set; }

        public virtual BANAN BANAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEU> CHITIETPHIEUx { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual TINHTRANGPHIEU TINHTRANGPHIEU { get; set; }
    }
}
