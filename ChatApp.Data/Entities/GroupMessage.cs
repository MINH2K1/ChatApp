using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Data.Entities
{
    public class GroupMessage
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public  AppUser ?User{get; set;}

        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group ?Group { get; set; }



    }
}
