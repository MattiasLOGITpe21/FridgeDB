using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridgeDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FridgeDB.Properties.Settings.FoodTypeConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFoodTable();
        }

        private void PopulateFoodTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TypeName", connection))
            {
                DataTable foodTable = new DataTable();
                adapter.Fill(foodTable);

                listFood.DisplayMember = "FoodTypeName";
                listFood.ValueMember = "Id";
                listFood.DataSource = foodTable;
            }
        }

        private void listFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFoodInTheFridge();
        }

        private void PopulateFoodInTheFridge()
        {
            string query = "SELECT FoodInTheFridge.Name FROM TypeName INNER JOIN FoodInTheFridge.TypeId = TypeName.Id Where TypeName.Id = @TypeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@TypeId", listFood.SelectedValue);
                DataTable foodTable = new DataTable();
                adapter.Fill(foodTable);

                listFoodInTheFridge.DisplayMember = "Name";
                listFoodInTheFridge.ValueMember = "Id";
                listFoodInTheFridge.DataSource = foodTable;
            }
        }
    }
}
