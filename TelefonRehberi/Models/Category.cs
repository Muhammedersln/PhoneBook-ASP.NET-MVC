using System.ComponentModel.DataAnnotations;

namespace TelefonRehberi.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kategori adı zorunludur")]
        [Display(Name = "Kategori Adı")]
        [StringLength(50, ErrorMessage = "Kategori adı en fazla 50 karakter olabilir")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        public string? Description { get; set; }

        // Navigation property - bir kategorinin birden çok kişisi olabilir
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}