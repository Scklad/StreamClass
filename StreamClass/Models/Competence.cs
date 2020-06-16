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

        #region Foreign key
        public virtual List<ModuleCompetence> ModulesCompetences { get; set; }
        public virtual List<SousThemeCompetence> SousThemesCompetences { get; set; }
        #endregion
    }
}
