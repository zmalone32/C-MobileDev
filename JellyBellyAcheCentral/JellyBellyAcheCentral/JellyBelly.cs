using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JellyBellyAcheCentral
{
    /// <summary>
    /// Pasted from the assingment page to link the DB
    /// </summary>
    [Table("JellyBellyTable")]

    public class JellyBelly
    {
        [Key]

        public int JellyBellyId { get; set; }



        [StringLength(30)]

        public string jellyBellyFlavor { get; set; }



        [StringLength(30)]

        public string category { get; set; }
    }
}
