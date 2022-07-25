using Entities.Concrete.BaseEntities;
using Entities.Interfaces;

namespace Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Experiences")]
    public class Experiences : BaseEntity, ITable
    {

    }
}
