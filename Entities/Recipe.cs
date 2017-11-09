using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Entities
{
	public class Recipe
	{
		#region Fields
		private List<Ingredient> ingredients;
		private string name;
		private int recipeId;
		#endregion


		#region Constructors
		public Recipe(List<Ingredient> ingredients, string name, int recipeId)
		{
			Ingredients = ingredients;
			Name = name;
			RecipeId = recipeId;
		}

		public Recipe(string name)
		{			
			Name = name;			
		}
		#endregion


		#region Properties
		public string Name { get => name; set => name = value; }
		public int RecipeId { get => recipeId; set => recipeId = value; }
		internal List<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }
		#endregion


		#region Methods
		//public List<IngredientType> GetIngredientTypes()
		//{

		//}
		#endregion
	}
}
