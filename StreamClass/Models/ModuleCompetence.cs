using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamClass.Models
{
    [Table("ModuleCompetence", Schema = "dbo")]
    public class ModuleCompetence
    {
        [Required]
        public int IdModule { get; set; }
        [Required]
        public int IdCompetence { get; set; }

        #region Foreign key
        [ForeignKey("IdModule")]
        [InverseProperty("ModulesCompetences")]
        public virtual Module Module { get; set; }

        [ForeignKey("IdCompetence")]
        [InverseProperty("ModulesCompetences")]
        public virtual Competence Competence { get; set; }
        #endregion
    }
}
