using System;
using System.Collections.Generic;


    public class AuditRequestDto
    {
        public string ProjectName { get; set; }

        public string ProjectManagerName { get; set; }

        public string ApplicationOwnerName { get; set; }

        public AuditDetailDto  auditDetail{get; set;}

    }

    public class AuditDetailDto
    {
        public AuditTypeEnum AuditType { get; set; }

        public DateTime AuditDate { get; set; }

        public List<AuditAnswerDto> responses { get; set; }

    }


    public class AuditAnswerDto
    {
        public int QuestionId { get; set; }

        public bool Answer { get; set; }
    }

