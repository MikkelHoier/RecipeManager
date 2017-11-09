using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeManager.DbAccess;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace RecipeManager.Test
{
	[TestClass]
	public class UnitTest1:CommonDB
	{
		[TestMethod]
		public void ExecuteQueryTest()
		{
			//Arrange:
			string sql = "SELECT TOP 1 * FROM Recipes";
			int expectedRows = 1;
			int actualRows;

			//Act:
			DataSet resultSet = ExecuteQuery(sql);
			actualRows = resultSet.Tables[0].Rows.Count;

			//Assert:
			Assert.AreEqual(expectedRows, actualRows);

		}
	}
}
