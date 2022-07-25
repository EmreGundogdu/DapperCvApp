using Entities.Concrete.BaseEntities;
using Entities.Interfaces;

namespace Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Certifications")]
    public class Certification : BaseEntity2, ITable
    {
    }
}
