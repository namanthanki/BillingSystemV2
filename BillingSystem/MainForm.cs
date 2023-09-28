using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class MainForm : MaterialForm
    {
        bool validateUNameErrorFlag = false;
        bool validateUEmailErrorFlag = false;
        bool validateUPassErrorFlag = false;

        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, 
                Primary.Blue900, 
                Primary.Blue500, 
                Accent.LightBlue200, 
                TextShade.WHITE
            );
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool condition =
                String.IsNullOrWhiteSpace(UsernameTextField.Text) ||
                String.IsNullOrWhiteSpace(PasswordTextField.Text);

            if (condition)
            {
                MaterialMessageBox.Show("All Fields are Required", "Error", false, FlexibleMaterialForm.ButtonsPosition.Center);
            }
            else
            {
                try
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\Documents\B.Tech\Third Year\Fifth Semester\C#\project\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();

                    string query = "SELECT * FROM Admins WHERE username = @uname AND password = @pass";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.Parameters.AddWithValue("@uname", UsernameTextField.Text);
                    cmd.Parameters.AddWithValue("@pass", PasswordTextField.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.Read())
                    {
                        MainForm reference = this;

                        ProductsForm productsForm = new ProductsForm();
                        productsForm.Show();

                        reader.Close();

                        sqlConnection.Close();
                    }
                    else
                    {
                        MaterialMessageBox.Show("No Accounts Found!", "Info", false, FlexibleMaterialForm.ButtonsPosition.Center);
                    }

                    sqlConnection.Close();
                }
                catch
                {
                    MaterialMessageBox.Show("Something Went Wrong", "Error", false, FlexibleMaterialForm.ButtonsPosition.Center);
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            bool condition = 
                String.IsNullOrWhiteSpace(RUsernameTextField.Text) || 
                String.IsNullOrWhiteSpace(REmailTextField.Text) || 
                String.IsNullOrWhiteSpace(RPasswordTextField.Text);

            if (condition)
            {
                MaterialMessageBox.Show("All Fields are Required", "Error", false, FlexibleMaterialForm.ButtonsPosition.Center);
            }
            else
            {
                try
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\Documents\B.Tech\Third Year\Fifth Semester\C#\project\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();

                    string query = "INSERT INTO dbo.Admins(username, email, password) VALUES(@uname, @email, @pass)";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.Parameters.AddWithValue("@uname", RUsernameTextField.Text);
                    cmd.Parameters.AddWithValue("@email", REmailTextField.Text);
                    cmd.Parameters.AddWithValue("@pass", RPasswordTextField.Text);

                    cmd.ExecuteNonQuery();

                    MaterialMessageBox.Show("Registered Successfully", "Message", false, FlexibleMaterialForm.ButtonsPosition.Center);

                    sqlConnection.Close();
                }
                catch
                {
                    MaterialMessageBox.Show("Something Went Wrong", "Error", false, FlexibleMaterialForm.ButtonsPosition.Center);
                }
            }
        }
    }
}
