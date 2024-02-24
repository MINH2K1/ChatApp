using ChatApp.Data.Common;
using ChatApp.Data.Enum;
using ChatApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Data.Entities
{
    public class Message:BaseEntity<int>, IDateTracking, ISwitchable
    {
        
        public string ?Body { get; set; }

        public Guid ?SenderId { get; set; }
        [ForeignKey("SenderId")]
        public virtual AppUser? AppUser { get; set; }
        
        public Guid ?ReceiverId { get; set; }
        [ForeignKey("ReceiverId")]
        public AppUser AppUsers { get; set; }


        public DateTime DateModified { get; set; }
        public DateTime? DateCreated { get; set;}

        public ICollection<GroupMessage> GroupMessages{ get; set; }
        public Status Status { get; set; }
        DateTime IDateTracking.DateCreated { get ; set ; }
    }
}
