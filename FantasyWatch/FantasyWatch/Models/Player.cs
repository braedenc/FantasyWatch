using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FantasyWatch.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Roster Roster { get; set; }
        [ForeignKey("Roster")]
        public int RosterId { get; set; }
        
        

    }
}