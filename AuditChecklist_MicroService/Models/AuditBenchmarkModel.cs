using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmark_MicroService.Models
{
    public class AuditBenchmarkModel
    {
        public AuditTypeEnum AuditType { get; set; }
        public int Benchmark { get; set; }
    }
}
