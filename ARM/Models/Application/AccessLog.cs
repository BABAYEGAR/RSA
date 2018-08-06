using System.ComponentModel.DataAnnotations.Schema;

namespace ARM.Models.Application
{
    public class AccessLog : Transport
    {
        public long AccessLogId { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public long? AppUserId { get; set; }
        [ForeignKey("AppUserId")]
        public AppUser AppUser { get; set; }
    }
}