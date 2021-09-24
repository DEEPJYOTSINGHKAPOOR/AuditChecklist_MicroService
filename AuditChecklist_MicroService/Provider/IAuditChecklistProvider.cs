using AuditChecklist_MicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditChecklist_MicroService.Provider
{
    public interface IAuditChecklistProvider
    {
        public ICollection<AuditQuestionModel> GetQuestions();
    }
}
