using System.ComponentModel.DataAnnotations;

namespace Contacts.Application.Dto.Common;

public class GuidReqDto
{
    [Required] 
    [Key]
    [RegularExpression("^((?!00000000-0000-0000-0000-000000000000).)*$", ErrorMessage = "Cannot use default Guid Value")]
    public Guid Id { get; set; }
}