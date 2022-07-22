using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.BaseEntities
{
    public class BaseEntity2
    {
        [ExplicitKey]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
