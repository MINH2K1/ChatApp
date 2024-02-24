using ChatApp.Data.Common;
using ChatApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Data.Entities
{
    [Table("Attepments")]
    public class Attepment:BaseEntity<int>,IDateTracking
    {
       
        public Guid? UserId { get; set; }
        [ForeignKey("UserId")]
        public AppUser AppUser { get; set; }
        public string Link { get; set; }
        public string ImageDescription { set; get; }
        public DateTime DateCreated { get ; set; }
        public DateTime DateModified { get; set; }
    }
}
