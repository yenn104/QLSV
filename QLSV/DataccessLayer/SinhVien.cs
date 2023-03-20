namespace QLSV.DataccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            Diems = new HashSet<Diem>();
        }

        [Key]
        [StringLength(10)]
        public string MSSV { get; set; }

        [StringLength(50)]
        public string Ho { get; set; }

        [StringLength(20)]
        public string Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(30)]
        public string QueQuan { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(30)]
        public string Mail { get; set; }

        [StringLength(11)]
        public string MaLop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }

        public virtual LopHoc LopHoc { get; set; }
    }
}
