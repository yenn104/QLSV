namespace QLSV.DataccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diem")]
    public partial class Diem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MSSV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaMH { get; set; }

        [Column("Diem")]
        public double? Diem1 { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
