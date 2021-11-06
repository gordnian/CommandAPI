using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        
        [Required]
        public string Platform { get; set; }
        
        [Required(ErrorMessage = "This is required man!!!")]
        public string CommandLine { get; set; }
    }
}