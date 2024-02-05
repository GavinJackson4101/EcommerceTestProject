using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Test1.Shared
{
	public class SignInSignUp
	{
		public string? SignUpUserName { get; set; }
		public string? SignUpEmail { get; set; }
		public string? SignUpPassword { get; set; }
		public string? SignInEmail { get; set; }
		public string? SignInPassword { get; set; }

	}
}
