

using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Video : EntityBase
    {
        public string Description { get; set; }
        public byte[] Binary { get; set; }
        public Guid ServerId { get; set; }
        [ForeignKey("ServerId")]
        public Server Server { get; set; }
    }
}
