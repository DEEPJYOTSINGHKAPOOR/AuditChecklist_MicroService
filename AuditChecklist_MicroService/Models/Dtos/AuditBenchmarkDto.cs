using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;



    public class AuditBenchmarkDto
    {
       
        public AuditTypeEnum AuditType { get; set; }
        public int Benchmark { get; set; }
    }

