using Entities.Concrete.BaseEntities;
using Entities.Interfaces;

namespace Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Skills")]
    public class Skill : BaseEntity2, ITable
    {
    }
}
