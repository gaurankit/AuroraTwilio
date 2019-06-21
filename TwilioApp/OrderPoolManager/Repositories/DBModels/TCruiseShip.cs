using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCruiseShip", Schema = "dbo")]
    public partial class TCruiseShip
    {
        public TCruiseShip()
        {
            TCruise = new HashSet<TCruise>();
            TCruiseShipCulture = new HashSet<TCruiseShipCulture>();
        }

        [Key]
        [Column("CruiseShipID")]
        public int CruiseShipId { get; set; }
        [Column("SupplerShipID")]
        [StringLength(15)]
        public string SupplerShipId { get; set; }
        [StringLength(100)]
        public string CruiseShipName { get; set; }
        [Column("CruiseLineID")]
        public int? CruiseLineId { get; set; }
        [Column("ProviderID")]
        public int? ProviderId { get; set; }

        [ForeignKey("CruiseLineId")]
        [InverseProperty("TCruiseShip")]
        public TCruiseLine CruiseLine { get; set; }
        [ForeignKey("ProviderId")]
        [InverseProperty("TCruiseShip")]
        public TProvider Provider { get; set; }
        [InverseProperty("CruiseShip")]
        public ICollection<TCruise> TCruise { get; set; }
        [InverseProperty("CruiseShip")]
        public ICollection<TCruiseShipCulture> TCruiseShipCulture { get; set; }
    }
}
