using AuditChecklist_MicroService.Models;
using System.Collections.Generic;

namespace AuditChecklist_MicroService.Provider
{
    public class AuditChecklistProvider : IAuditChecklistProvider
    {
        public ICollection<AuditQuestionModel> GetQuestions()
        {
            var  l = new List<AuditQuestionModel>();
                l.Add(new AuditQuestionModel()
                {
                    QuestionId = 1,
                    AuditType = AuditTypeEnum.Internal,
                    AuditQuestion = "Have all Change requests followed SDLC before PROD move?"
                });
                l.Add(new AuditQuestionModel()
                {
                    QuestionId = 2,
                    AuditType = AuditTypeEnum.Internal,
                    AuditQuestion = "Have all Change requests been approved by the application owner?"
                });
                l.Add(new AuditQuestionModel()
                {
                    QuestionId = 3,
                    AuditType = AuditTypeEnum.Internal,
                    AuditQuestion = "Are all artifacts like CR document, Unit test cases available?"
                });


                l.Add(new AuditQuestionModel()
                {
                    QuestionId = 4,
                    AuditType = AuditTypeEnum.Internal,
                    AuditQuestion = "Is the SIT and UAT sign-off available?"
                });

                l.Add(new AuditQuestionModel()
                {
                    QuestionId = 5,
                    AuditType = AuditTypeEnum.Internal,
                    AuditQuestion = "Is data deletion from the system done with application owner approval?"
                });
            
            
            
                l.Add(new AuditQuestionModel()
                {
                    QuestionId = 6,
                    AuditType = AuditTypeEnum.SOX,
                    AuditQuestion = "Have all Change requests followed SDLC before PROD move?"
                });

                l.Add(new AuditQuestionModel()
                {
                    QuestionId = 7,
                    AuditType = AuditTypeEnum.SOX,
                    AuditQuestion = "Have all Change requests been approved by the application owner?"
                });


                l.Add(new AuditQuestionModel()
                {
                    QuestionId = 8,
                    AuditType = AuditTypeEnum.SOX,
                    AuditQuestion = "For a major change, was there a database backup taken before and after PROD move?"
                });


                l.Add(new AuditQuestionModel()
                {
                    QuestionId = 9,
                    AuditType = AuditTypeEnum.SOX,
                    AuditQuestion = "Has the application owner approval obtained while adding a user to the system?"
                });

                l.Add(new AuditQuestionModel()
                {
                    QuestionId = 10,
                    AuditType = AuditTypeEnum.SOX,
                    AuditQuestion = "Is data deletion from the system done with application owner approval?"
                });
           

            return l;
        }

        
    }
}
