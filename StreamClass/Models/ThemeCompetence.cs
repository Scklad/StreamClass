using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamClass.Models
{
    [Table("ThemeCompetence", Schema = "dbo")]
    public class ThemeCompetence
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }

        #region Foreign key
        public virtual List<SousTheme> SousThemes { get; set; }
        #endregion
    }
}
