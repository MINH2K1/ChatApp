using ChatApp.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Data.Interface
{
    public interface ISwitchable
    {
        Status Status { get; set; }  
    }
}
