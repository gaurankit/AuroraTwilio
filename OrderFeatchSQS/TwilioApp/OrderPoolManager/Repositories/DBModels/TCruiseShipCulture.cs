using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCruiseShipCulture", Schema = "dbo")]
    public partial class TCruiseShipCulture
    {
        [Key]
        [Column("CruiseShipCultureID")]
        public int CruiseShipCultureId { get; set; }
        [Column("CruiseShipID")]
        public int CruiseShipId { get; set; }
        [Column("LCID")]
        public int Lcid { get; set; }
        [Required]
        [StringLength(100)]
        public string CruiseShipCultureName { get; set; }

        [ForeignKey("CruiseShipId")]
        [InverseProperty("TCruiseShipCulture")]
        public TCruiseShip CruiseShip { get; set; }
    }
}
