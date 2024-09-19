namespace UmbracoCMS.Models
{
   public class ContactFormModel
    {
        public string Name { get; set; } = null!;
        public string? Phone { get; set; }
        public string Email { get; set; } = null!;
        public string Service { get; set; } = null!;
    }
}
