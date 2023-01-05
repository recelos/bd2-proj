using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter.DataAccess.Models
{
    public class User
    {
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int user_type { get; set; }
        public int id_country { get; set; }
        public DateTime creation_date { get; set; }
    }
}
