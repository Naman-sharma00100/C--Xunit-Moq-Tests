using System.Text.RegularExpressions;

namespace testingApplication
{
	public class PasswordChecker
	{
		public bool IsValid(string password)
		{
			if (!string.IsNullOrEmpty(MakeDBCall("Test")))
			{
				Regex passwordPolicyExpression = new Regex(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#!$%]).{8,20})");
				return passwordPolicyExpression.IsMatch(password);

			}
			return false;
		}

		public string MakeDBCall(string input)
		{
			return input+" Result";
		}

	}
}
