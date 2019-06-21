using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCruiseBookingPaymentState", Schema = "dbo")]
    public partial class TCruiseBookingPaymentState
    {
        public TCruiseBookingPaymentState()
        {
            TCruise = new HashSet<TCruise>();
        }

        [Key]
        [Column("CruiseBookingPaymentStateID")]
        public int CruiseBookingPaymentStateId { get; set; }
        [Required]
        [StringLength(15)]
        public string CruiseBookingPaymentState { get; set; }

        [InverseProperty("CruiseBookingPaymentState")]
        public ICollection<TCruise> TCruise { get; set; }
    }
}
