using Entities.Concrete.BaseEntities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Educations")]

    public class Education : BaseEntity, ITable
    {
    }
}
