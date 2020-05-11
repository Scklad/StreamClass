using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamClass.Models
{
    [Table("SousTheme", Schema = "dbo")]
    public class SousTheme
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titre { get; set; }
        [Required]
        public int IdThemeCompetence { get; set; }

        #region Foreign key
        [ForeignKey("IdThemeCompetence")]
        [InverseProperty("SousThemes")]
        public virtual ThemeCompetence ThemeCompetence { get; set; }

        public virtual List<Competence> Competences { get; set; }
        #endregion
    }
}
