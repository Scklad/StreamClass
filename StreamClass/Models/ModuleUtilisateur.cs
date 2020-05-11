using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamClass.Models
{
    [Table("ModuleUtilisateur", Schema = "dbo")]
    public class ModuleUtilisateur
    {
        [Required]
        public int IdModule { get; set; }
        [Required]
        public int IdUtilisateur { get; set; }

        #region Foreign key
        [ForeignKey("IdModule")]
        [InverseProperty("ModulesUtilisateurs")]
        public virtual Module Module { get; set; }

        [ForeignKey("IdUtilisateur")]
        [InverseProperty("ModulesUtilisateurs")]
        public virtual Utilisateur Utilisateur { get; set; }
        #endregion
    }
}
