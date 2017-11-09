using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RecipeManager.Entities;
using RecipeManager.DbAccess;
using RecipeManager.Services;

namespace RecipeManager.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
		private DBHandler handler;

        public MainWindow()
        {
            InitializeComponent();
			handler = new DBHandler();			;
			FillIngredientsDataGrid();
        }

		public void FillIngredientsDataGrid()
		{
			dataGridAllIngredients.ItemsSource = handler.GetAllIngredients();
		}		
	}
}
