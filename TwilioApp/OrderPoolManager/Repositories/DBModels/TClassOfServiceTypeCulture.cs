using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tClassOfServiceTypeCulture", Schema = "dbo")]
    public partial class TClassOfServiceTypeCulture
    {
        [Key]
        [Column("ClassOfServiceTypeCultureID")]
        public int ClassOfServiceTypeCultureId { get; set; }
        [Column("ClassOfServiceTypeID")]
        public int ClassOfServiceTypeId { get; set; }
        [Column("LCID")]
        public int Lcid { get; set; }
        [StringLength(100)]
        public string ClassOfServiceTypeCultureDescription { get; set; }

        [ForeignKey("ClassOfServiceTypeId")]
        [InverseProperty("TClassOfServiceTypeCulture")]
        public TClassOfServiceType ClassOfServiceType { get; set; }
    }
}
