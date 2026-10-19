using System;
using System.Collections.Generic;

namespace FMSISSTransactionService.Models
{
    public class Parameter
    {
        public long ParameterId { get; set; }
        public string ParameterName { get; set; }
        public string FieldType { get; set; }
        public string DataType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? EditedAt { get; set; }
        public string EditedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
