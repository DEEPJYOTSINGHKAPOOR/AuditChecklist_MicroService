using AuditChecklist_MicroService.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditChecklist_MicroService
{
    public class AuditChecklistMappings : Profile
    {

        public AuditChecklistMappings()
        {
            CreateMap<AuditQuestionModel, AuditQuestionDto>().ReverseMap();
        }
    }
}
