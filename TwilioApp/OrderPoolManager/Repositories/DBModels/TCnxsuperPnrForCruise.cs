using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCNXSuperPnrForCruise", Schema = "dbo")]
    public partial class TCnxsuperPnrForCruise
    {
        [Key]
        [Column("CNXSuperPnrForCruise")]
        public int CnxsuperPnrForCruise { get; set; }
    }
}
