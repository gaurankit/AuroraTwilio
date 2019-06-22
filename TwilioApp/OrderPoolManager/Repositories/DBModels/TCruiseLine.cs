using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCruiseLine", Schema = "dbo")]
    public partial class TCruiseLine
    {
        public TCruiseLine()
        {
            TCruiseShip = new HashSet<TCruiseShip>();
        }

        [Key]
        [Column("CruiseLineID")]
        public int CruiseLineId { get; set; }
        [Required]
        [Column("CruiseLineSupplierID")]
        [StringLength(15)]
        public string CruiseLineSupplierId { get; set; }
        [Required]
        [StringLength(100)]
        public string CruiseLineName { get; set; }
        [Column("IsGDS")]
        public bool? IsGds { get; set; }
        [Column("ProviderID")]
        public int? ProviderId { get; set; }

        [ForeignKey("ProviderId")]
        [InverseProperty("TCruiseLine")]
        public TProvider Provider { get; set; }
        [InverseProperty("CruiseLine")]
        public ICollection<TCruiseShip> TCruiseShip { get; set; }
    }
}
