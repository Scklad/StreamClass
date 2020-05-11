using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StreamClass.Models
{
    [Table("Video", Schema = "dbo")]
    public class Video
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titre { get; set; }
        [Required]
        public string Emplacement { get; set; }
        [Required]
        public int Duree { get; set; }

        #region Foreign key
        public virtual List<ModuleVideo> ModulesVideos { get; set; }
        #endregion
    }
}
