using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("EnsureBookingJobTP", Schema = "dbo")]
    public partial class EnsureBookingJobTp
    {
        [StringLength(32)]
        public string ConfirmationNumber { get; set; }
        [Column("TripProductID")]
        public Guid TripProductId { get; set; }
        [Column("TripFolderID")]
        public Guid? TripFolderId { get; set; }
        [StringLength(36)]
        public string VendorConfirmationNumber { get; set; }
        [StringLength(3)]
        public string CityCode { get; set; }
        [StringLength(64)]
        public string Owner { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AddDate { get; set; }
    }
}
