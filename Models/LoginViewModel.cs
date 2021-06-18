
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FileUploadDemo.Models
{
	public class LoginViewModel
	{
		[DisplayName("User Name")]
		[Required]
		public string UserName { get; set; }
		[DisplayName("Password")]
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

	}
}