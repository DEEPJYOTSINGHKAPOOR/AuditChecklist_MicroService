using AuditChecklist_MicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditChecklist_MicroService.Repository.IRepository
{
    public interface IAuditChecklistRepository
    {
        public ICollection<AuditQuestionModel> GetQuestions();
        public ICollection<AuditQuestionModel> GetSpecificTypeQuestions(AuditTypeEnum auditTypeEnum);

    }
}
