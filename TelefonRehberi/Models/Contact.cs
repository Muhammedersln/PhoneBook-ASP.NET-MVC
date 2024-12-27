using System.ComponentModel.DataAnnotations;

namespace TelefonRehberi.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunludur")]
        [Display(Name = "Ad")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur")]
        [Display(Name = "Soyad")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Telefon numarası zorunludur")]
        [Display(Name = "Telefon Numarası")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz")]
        public string PhoneNumber { get; set; }

        [Display(Name = "E-posta")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz")]
        public string? Email { get; set; }

        [Display(Name = "Adres")]
        public string? Address { get; set; }
    }
} 