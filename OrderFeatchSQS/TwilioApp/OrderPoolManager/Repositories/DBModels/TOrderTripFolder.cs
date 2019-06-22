using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderTripFolder", Schema = "dbo")]
    public partial class TOrderTripFolder
    {
        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("TripFolderID")]
        public Guid TripFolderId { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("TOrderTripFolder")]
        public TOrder Order { get; set; }
    }
}
