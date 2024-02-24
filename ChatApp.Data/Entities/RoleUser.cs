using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Data.Entities
{
    [Table("AppRoles")]
    public class RoleUser:IdentityRole<Guid>
    {
        [MaxLength(250)]
        public string ?Description { get; set; }
    }
}
