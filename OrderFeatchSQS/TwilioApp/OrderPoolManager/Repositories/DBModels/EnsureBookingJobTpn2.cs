using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("EnsureBookingJobTPN2", Schema = "dbo")]
    public partial class EnsureBookingJobTpn2
    {
        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [StringLength(200)]
        public string TravelPlanName { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
