using System.ComponentModel.DataAnnotations;

namespace BlazorSSRSendEmail.Models
{
public class EmailRequest
{
    [Required(ErrorMessage = "First Name is required.")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Last Name is required.")]
    public string LastName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email Address is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string EmailAddress { get; set; } = string.Empty;

    [Required(ErrorMessage = "Body is required.")]
    public string Body { get; set; } = string.Empty;

    [Required(ErrorMessage = "Subject is required.")]
    public string Subject { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Company is required.")]
    public string Company { get; set; } = string.Empty;
}

}