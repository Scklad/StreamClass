using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamClass.Models
{
    [Table("SousThemeCompetence", Schema = "dbo")]
    public class SousThemeCompetence
    {
        [Required]
        public int IdSousTheme { get; set; }
        [Required]
        public int IdCompetence { get; set; }

        #region Foreign key
        [ForeignKey("IdSousTheme")]
        [InverseProperty("SousThemesCompetences")]
        public virtual SousTheme SousTheme { get; set; }

        [ForeignKey("IdCompetence")]
        [InverseProperty("SousThemesCompetences")]
        public virtual Competence Competence { get; set; }
        #endregion
    }
}
