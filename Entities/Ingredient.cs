using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Entities
{
	public class Ingredient
	{
		#region Fields
		private int ingredientId;
		private string name;
		private decimal price;
		private IngredientType IngredietType;
		#endregion

		#region Constructors
		public Ingredient(int ingredientId, string name, decimal price, IngredientType ingredietType)
		{
			IngredientId = ingredientId;
			Name = name;
			Price = price;
			IngredientType1 = ingredietType;
		}

		public Ingredient(string name, decimal price, IngredientType ingredientType)
		{
			Name = name;
			Price = price;
			IngredientType1 = ingredientType;
		}
		#endregion

		#region Properties
		public int IngredientId { get => ingredientId; set => ingredientId = value; }
		public string Name { get => name; set => name = value; }
		public decimal Price { get => price; set => price = value; }
		public IngredientType IngredientType1 { get => IngredietType; set => IngredietType = value; }
		#endregion

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
