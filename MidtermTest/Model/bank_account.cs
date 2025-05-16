using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermTest.Model
{
    public class bank_account
    {
        [Key]
        public int account_id { get; set; }
        public string owner_name { get; set; }
        public string owner_address { get; set; }
        public string owner_phone { get; set; }
        public double balance { get; set; }
        public string account_type { get; set; }
        public string password { get; set; }
        public ICollection<transactions> Transactions { get; set; }
    }
}
