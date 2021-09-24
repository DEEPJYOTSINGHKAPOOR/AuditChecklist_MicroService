using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuditChecklist_MicroService.Models
{
    public class AuditQuestionModel
    {
        [Key]
        public int QuestionId { get; set; }

        [Required]
        public AuditTypeEnum AuditType { get; set; }


        [Required]
        public string AuditQuestion { get; set; }
    }
}
