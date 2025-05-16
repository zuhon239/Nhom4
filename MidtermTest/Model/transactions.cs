using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermTest.Model
{
    public class transactions
    {
        [Key]
        public Guid trans_id { get; set; }
        public int account_id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime happend_time { get; set; }
        public string action_desc { get; set; }
        public string note { get; set; }

        [ForeignKey("account_id")]
        public bank_account bank_account { get; set; }
    }
}
