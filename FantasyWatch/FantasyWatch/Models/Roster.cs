using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FantasyWatch.Models
{
    public class Roster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ApplicationUser User { get; set; }
        [ForeignKey("User")]
        public string UserID { get; set; }
        
        
    }
}