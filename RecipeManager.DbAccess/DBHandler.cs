using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RecipeManager.Entities;

namespace RecipeManager.DbAccess
{
	public class DBHandler:CommonDB
	{
		public DBHandler()
			:base()
		{

		}

		public List<Ingredient> GetAllIngredients()
		{
			String sql = "SELECT * FROM Ingredients";
			DataSet set = ExecuteQuery(sql);
			List<Ingredient> ingredients = new List<Ingredient>(0);
			DataTable table = set.Tables[0];
			foreach (DataRow row in table.Rows)
			{
				decimal price = (decimal)row["Price"];
				string name = (string)row["IngredientName"];
				IngredientType type = (IngredientType)Enum.Parse(typeof(IngredientType), (string)row["IngredientType"]);
				Ingredient i = new Ingredient(name, price, type);

				ingredients.Add(i);
			}
			return ingredients;
		}

		public List<Recipe> GetAllRecipes()
		{
			string sql = "SELECT * FROM Recipes";
			DataSet set = ExecuteQuery(sql);
			List<Recipe> recipes = new List<Recipe>(0);
			DataTable table = set.Tables[0];
			foreach (DataRow row in table.Rows)
			{
				string name = (string)row["RecipeName"];
				Recipe r = new Recipe(name);

				recipes.Add(r);
			}
			return recipes;
		}
	}
}
