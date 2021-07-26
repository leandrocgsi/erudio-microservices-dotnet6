using System.ComponentModel.DataAnnotations.Schema;

namespace ErudioMicroservices.NET6.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
