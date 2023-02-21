using System.ComponentModel.DataAnnotations;

namespace Domain.ModelBase
{
    public abstract class BaseModel
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public bool Borrado { get; set; }
        [Required]
        public DateTime FechaCreado { get; set; }
        public DateTime? FechaModificado { get; set; }
    }
}
