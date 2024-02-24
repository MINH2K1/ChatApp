using ChatApp.Data.Common;
using ChatApp.Data.Enum;
using ChatApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Data.Entities
{
    [Table("Group")]
    public class Group : BaseEntity<int>, IDateTracking, ISwitchable
    {
       
        public string Name { get; set; }
        public virtual ICollection<GroupMessage> GroupMessages { get; set; }
        public virtual ICollection<GroupMember> GroupMembers { get; set; }
        public DateTime DateCreated { get ; set ; }
        public DateTime DateModified { get; set ; }
        public Status Status { get; set ; }
    }
}