using ChatApp.Data.Common;
using ChatApp.Data.Enum;
using ChatApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Data.Entities
{
    public class GroupMember :BaseEntity<int>, IDateTracking, ISwitchable
    {
        public int GroupId { get; set; }
        [ForeignKey("GroupId")] 
        
        public Group Group { get; set; }

        public Guid ?MemberId { get; set; }
        [ForeignKey("MemberId")]
        public AppUser AppUser { get; set; }
        public string ?Role { get; set; }
        public Status Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateCreated { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateModified { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
