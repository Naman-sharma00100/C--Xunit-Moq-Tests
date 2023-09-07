using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProj
{
	public class TestCases
	{
		public string name { get; set; }
		public string pass { get; set; }
		public bool expectedResult { get; set; }

		public static object[][] testData = new object[][] {
			new object[]
			{
				new TestCases
				{
					name = "When Input password is valid - Positive",
					pass = "Th1sisApASSwprd!",
					expectedResult = true
				}
			},
			new object[]
			{
				new TestCases
				{
					name = "When Input password is Not valid - Negative",
					pass = "Th1!",
					expectedResult = false
				}
			},
			new object[]
			{
				new TestCases
				{
					name = "When Input password is Empty - Negative",
					pass = "",
					expectedResult = false
				}
			},
		};
	}
}

