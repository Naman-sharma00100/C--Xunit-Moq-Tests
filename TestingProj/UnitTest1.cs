using testingApplication;
using Xunit;
using Moq;

namespace TestingProj
{
	public class PasswordCheckerTesting
	{
		public PasswordChecker passwordvalidator = new PasswordChecker();
		Mock<PasswordChecker> mockService = new Mock<PasswordChecker>();


		[Fact]
		public void Test1()
		{
			//Arrange

			const string password = "Th1s1saPassword!";
			//mockService.Setup(s => s.MakeDBCall(It.IsAny<string>())).Returns("Test");

			//Act
			bool isValid = passwordvalidator.IsValid(password);

			//Assert
			Assert.True(isValid);
		}


		[Theory]
		[InlineData("Th1s1saPassword!", true)]
		[InlineData("Th1s!", false)]
		[InlineData("", false)]
		public void Test2(string pass, bool ExpectedResult)
		{
			//mockService.Setup(s => s.MakeDBCall(It.IsAny<string>())).Returns("Test");

			var result = passwordvalidator.IsValid(pass);

			Assert.Equal(ExpectedResult, result);
		}


		[Theory]
		[MemberData(nameof(TestCases.testData), MemberType = typeof(TestCases)) ]
		public void validate_password_with_MemberData(TestCases testCases)
		{
			//mockService.Setup(s => s.MakeDBCall(It.IsAny<string>())).Returns("Test");

			bool result = passwordvalidator.IsValid(testCases.pass);
			Assert.Equal(testCases.expectedResult, result);

		}



		//Mock
		[Fact]
		public void PasswordValidate()
		{
			const string pass = "123";


			mockService.Setup(s => s.MakeDBCall("Test")).Returns("Test Result");


			bool isValid = passwordvalidator.IsValid(pass); 
			Assert.True(isValid);
		}



	}
}