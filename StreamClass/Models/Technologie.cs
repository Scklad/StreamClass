using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamClass.Models
{
    [Table("Technologie", Schema = "dbo")]
    public class Technologie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Description { get; set; }

        #region Foreign key
        public List<ModuleTechnologie> ModulesTechnologies { get; set; }
        #endregion
    }
}
