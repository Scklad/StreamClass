using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamClass.Models
{
    [Table("ModuleVideo", Schema = "dbo")]
    public class ModuleVideo
    {
        [Required]
        public int IdModule { get; set; }
        [Required]
        public int IdVideo { get; set; }

        #region Foreign key
        [ForeignKey("IdModule")]
        [InverseProperty("ModulesVideos")]
        public virtual Module Module { get; set; }

        [ForeignKey("IdVideo")]
        [InverseProperty("ModulesVideos")]
        public virtual Video Video { get; set; }
        #endregion
    }
}
