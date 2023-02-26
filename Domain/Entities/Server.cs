

namespace Domain.Entities
{
    public class Server : EntityBase
    {
        public string name { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
        public ICollection<Video> Videos { get; set; }
    }
}
