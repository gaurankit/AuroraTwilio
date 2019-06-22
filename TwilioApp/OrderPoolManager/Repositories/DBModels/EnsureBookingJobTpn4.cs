using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("EnsureBookingJobTPN4", Schema = "dbo")]
    public partial class EnsureBookingJobTpn4
    {
        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [StringLength(200)]
        public string TravelPlanName { get; set; }
    }
}
