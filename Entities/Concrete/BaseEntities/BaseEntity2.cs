using Dapper.Contrib.Extensions;

namespace Entities.Concrete.BaseEntities
{
    public class BaseEntity2
    {
        [ExplicitKey]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
