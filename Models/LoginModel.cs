using System.ComponentModel.DataAnnotations;

namespace DotnetStockAPI.Models;
public class LoginModel
{
    [Required(ErrorMessage = "Username is required")]
    [StringLength(50, ErrorMessage = "Username is too long")]
    [MinLength(3, ErrorMessage = "Username is too short ")]
    public string? Username { get; set; }
    
    [Required(ErrorMessage = "Password is required จำเป็นต้องมีรหัสผ่าน❗❗❗")]
     [MinLength(6, ErrorMessage = "Password is too short รหัสสั้นไปอีหนู💦💨🚮")]
    public string? Password { get; set; }
}