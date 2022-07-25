using Entities.Concrete.BaseEntities;
using Entities.Interfaces;

namespace Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Educations")]

    public class Education : BaseEntity, ITable
    {
    }
}
