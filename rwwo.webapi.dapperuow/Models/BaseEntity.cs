namespace rwwo.webapi.dapperuow.Models
{
    public class BaseEntity
    {
        public Guid id { get; set; }
        public DateTime create_date { get; set; }
        public DateTime update_date { get; set; }
        public DateTime delete_date { get; set; }
    }
}
