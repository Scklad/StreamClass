using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamClass.Models
{
    [Table("Utilisateur", Schema = "dbo")]
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string AdresseMail { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string AdressePostale { get; set; }
        [Required]
        [StringLength(5)]
        public string CodePostal { get; set; }
        [Required]
        public string Ville { get; set; }
        [Required]
        [StringLength(10)]
        public string NumTelephone { get; set; }

        #region Foreign key
        public virtual List<ModuleUtilisateur> ModulesUtilisateurs { get; set; }
        #endregion
    }
}
