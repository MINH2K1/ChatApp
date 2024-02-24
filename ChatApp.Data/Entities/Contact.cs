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
    [Table("Contacts")]
    public class Contact :BaseEntity<int>,IDateTracking,ISwitchable
    {
       
        public Guid UserId { get; set; }

        public int ContactId { get; set; }
        public bool IsBlock{ get; set; }
       public DateTime DateCreated { set; get; }

        public  DateTime DateModified { set; get; }
         public Status Status { get; set; }
    }
}
