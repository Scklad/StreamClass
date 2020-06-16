using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamClass.Models
{
    [Table("Competence", Schema = "dbo")]
    public class Competence
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public int IdSousTheme { get; set; }

        #region Foreign key
        [ForeignKey("IdSousTheme")]
        [InverseProperty("Competences")]
        public virtual SousTheme SousTheme { get; set; }

        public virtual List<ModuleCompetence> ModulesCompetences { get; set; }
        public virtual List<SousThemeCompetence> SousThemesCompetences { get; set; }
        #endregion
    }
}
