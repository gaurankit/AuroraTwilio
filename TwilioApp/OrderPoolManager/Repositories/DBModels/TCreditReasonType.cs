using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCreditReasonType", Schema = "dbo")]
    public partial class TCreditReasonType
    {
        public TCreditReasonType()
        {
            TActivity = new HashSet<TActivity>();
            TAirTicket = new HashSet<TAirTicket>();
            TCarRental = new HashSet<TCarRental>();
            TCruise = new HashSet<TCruise>();
            THotelRoom = new HashSet<THotelRoom>();
            TInsurance = new HashSet<TInsurance>();
            TOrderAdjustment = new HashSet<TOrderAdjustment>();
            TPackage = new HashSet<TPackage>();
            TRetailProduct = new HashSet<TRetailProduct>();
        }

        [Key]
        [Column("CreditReasonTypeID")]
        public int CreditReasonTypeId { get; set; }
        [Required]
        [StringLength(20)]
        public string CreditReasonType { get; set; }

        [InverseProperty("CreditReasonType")]
        public ICollection<TActivity> TActivity { get; set; }
        [InverseProperty("CreditReasonType")]
        public ICollection<TAirTicket> TAirTicket { get; set; }
        [InverseProperty("CreditReasonType")]
        public ICollection<TCarRental> TCarRental { get; set; }
        [InverseProperty("CreditReasonType")]
        public ICollection<TCruise> TCruise { get; set; }
        [InverseProperty("CreditReasonType")]
        public ICollection<THotelRoom> THotelRoom { get; set; }
        [InverseProperty("CreditReasonType")]
        public ICollection<TInsurance> TInsurance { get; set; }
        [InverseProperty("CreditReasonType")]
        public ICollection<TOrderAdjustment> TOrderAdjustment { get; set; }
        [InverseProperty("CreditReasonType")]
        public ICollection<TPackage> TPackage { get; set; }
        [InverseProperty("CreditReasonType")]
        public ICollection<TRetailProduct> TRetailProduct { get; set; }
    }
}
