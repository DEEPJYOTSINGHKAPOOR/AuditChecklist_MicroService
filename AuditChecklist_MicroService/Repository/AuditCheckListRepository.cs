using AuditChecklist_MicroService.Models;
using AuditChecklist_MicroService.Provider;
using AuditChecklist_MicroService.Repository.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace AuditChecklist_MicroService.Repository
{
    public class AuditChecklistRepository : IAuditChecklistRepository
    {
        //private readonly ApplicationDbContext _db;
        private readonly IAuditChecklistProvider _provider;
        

        public AuditChecklistRepository(IAuditChecklistProvider provider)
        {
            _provider = provider;
        }
        public ICollection<AuditQuestionModel> GetQuestions()
        {
            return _provider.GetQuestions().OrderBy(a=> a.QuestionId).ToList();
        }

        public ICollection<AuditQuestionModel> GetSpecificTypeQuestions(AuditTypeEnum auditTypeEnum)
        {
            return _provider.GetQuestions().Where(a1=>a1.AuditType == auditTypeEnum).OrderBy(a => a.QuestionId).ToList();
        }

        public bool Save()
        {
            return true;
        }
    }
}
