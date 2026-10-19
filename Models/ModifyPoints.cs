using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSISSTransactionService.Models
{
    public class ModifyPoints
    {
        [Key]
        public string ModifyType { get; set; }
        public DateTime ModifiedOn { get; set; }
        public long TrxLogId2 { get; set; }
        public bool IsSeeded { get; set; }
    }
}
