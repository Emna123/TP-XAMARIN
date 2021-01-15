using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tp.Models
{
    [Table("")]
  public  class User { 
    
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100),Unique]
        public String email { get; set; }
        [MaxLength(100)]
        public String password { get; set; }
    }
}
