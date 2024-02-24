using ChatApp.Data.Enum;
using ChatApp.Data.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Data.Entities
{

    [Table("AppUsers")]
    public class AppUser: IdentityUser<Guid>, IDateTracking , ISwitchable
    {
        public string FullName { get; set; }

        public DateTime? BirthDay { set; get; }

        public string Avatar { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        [DefaultValue(Status.Active)]
        public Status Status { get; set; }
    }
}
