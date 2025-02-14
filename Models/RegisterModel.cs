using System.ComponentModel.DataAnnotations;

namespace DotnetStockAPI.Models;

public class RegisterModel
{
    [Required(ErrorMessage = "Username is required")]
    [StringLength(50, ErrorMessage = "Username is too long")]
    [MinLength(3, ErrorMessage = "Username is too short")]
    public required string Username { get; set; }
    
    [Required(ErrorMessage = "Email is required สมัครเมลเป็นมั้ย💌")]
    [EmailAddress(ErrorMessage = "Email is not valid ใส่เมลไม่ถูกค้าบอ้วง")]
    public required string Email { get; set; }
    
    [Required(ErrorMessage = "Password is required จำเป็นต้องมีรหัสผ่านคะ❗❗❗")]
    [MinLength(6, ErrorMessage = "Password is too short รหัสสั้นไปอีหนู💦💨🚮 ")]
    public required string Password { get; set; }
}