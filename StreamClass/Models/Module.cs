using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamClass.Models
{
    [Table("Module", Schema = "dbo")]
    public class Module
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Description { get; set; }

        #region Foreign key
        public virtual List<ModuleTechnologie> ModulesTechnologies { get; set; }
        public virtual List<ModuleVideo> ModulesVideos { get; set; }
        public virtual List<ModuleCompetence> ModulesCompetences { get; set; }
        public virtual List<ModuleUtilisateur> ModulesUtilisateurs { get; set; }
        #endregion
    }
}
