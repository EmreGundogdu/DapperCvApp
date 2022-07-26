﻿using Dapper.Contrib.Extensions;

namespace Entities.Concrete.BaseEntities
{
    public class BaseEntity
    {
        [ExplicitKey]
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
