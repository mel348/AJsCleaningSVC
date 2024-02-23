using System.ComponentModel.DataAnnotations;


namespace AJsCleaning.Models {
    public enum PropertyType {
        Residential,
        Commercial,
        Other
    }

    public class Services {
        [Key]
        public int Id { get; set; }
        [Required]
        public PropertyType Type { get; set; }
        [Required]
        public string Service { get; set; } = String.Empty;
        [Required]
        public string Description { get; set; } = String.Empty;
    }
}