using System;
using System.Collections.Generic;
using System.Text;


    public class AuditResponseDto
    {

        public int AuditId { get; set; }

        public AuditResultEnum AuditExecutionStatus { get; set; }

        public string RemedialActionDuration { get; set; }

    }

