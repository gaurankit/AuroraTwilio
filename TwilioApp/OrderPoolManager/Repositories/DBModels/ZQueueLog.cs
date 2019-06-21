using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("Z_QueueLog", Schema = "dbo")]
    public partial class ZQueueLog
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("HandleID")]
        public Guid? HandleId { get; set; }
        public string MessageType { get; set; }
        public string MessageBody { get; set; }
        [Column("DT", TypeName = "datetime")]
        public DateTime Dt { get; set; }
        public string ErrorMsg { get; set; }
    }
}
