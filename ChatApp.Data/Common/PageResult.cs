using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Data.Common
{
    public class PageResult<T> : PageResultBase where T : class
    {
        public PageResult()
        {
            Results = new List<T>();
        }
        public IList<T> Results { get; set; }
    }
}
