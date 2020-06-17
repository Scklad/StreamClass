using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamClass.Models
{
    [Table("ModuleTechnologie", Schema = "dbo")]
    public class ModuleTechnologie
    {
        [Required]
        public int IdModule { get; set; }
        [Required]
        public int IdTechnologie { get; set; }

        #region Foreign key
        [ForeignKey("IdModule")]
        [InverseProperty("ModulesTechnologies")]
        public virtual Module Module { get; set; }

        [ForeignKey("IdTechnologie")]
        [InverseProperty("ModulesTechnologies")]
        public virtual Technologie Technologie { get; set; }
        #endregion
    }
}
