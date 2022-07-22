﻿using DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.SkillDtos
{
    public class SkillAddDo : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
