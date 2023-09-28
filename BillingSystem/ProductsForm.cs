using iTextSharp.text.pdf;
using iTextSharp.text;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class ProductsForm : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public ProductsForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
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

        private void ShowDataGridView()
        {
            DGV.Rows.Clear();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\Documents\B.Tech\Third Year\Fifth Semester\C#\project\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string id = reader.GetFieldValue<int>(0).ToString();
                    string name = reader.GetFieldValue<string>(1);
                    string price = reader.GetFieldValue<int>(2).ToString();

                    string[] row = { id, name, price };

                    DGV.Rows.Add(row);
                }
            }

            conn.Close();
        }

        private void FillBillProductNames()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\Documents\B.Tech\Third Year\Fifth Semester\C#\project\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = "SELECT name FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            List<string> itemsList = new List<string>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string name = reader.GetString(0).ToString();
                    itemsList.Add(name);
                }
            }

            BillProductsCB.DataSource = itemsList;

            conn.Close();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.billingSystemDataSet.Products);
            ShowDataGridView();
            FillBillProductNames();
            BillDate.Text = DateTime.Now.ToShortDateString();
        }

        private void PAddButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\Documents\B.Tech\Third Year\Fifth Semester\C#\project\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string searchProductQuery = "SELECT name FROM Products WHERE name = @name";
            SqlCommand searchCommand = new SqlCommand(searchProductQuery, conn);

            searchCommand.Parameters.AddWithValue("@name", PNameTextBox.Text);

            SqlDataReader reader = searchCommand.ExecuteReader();

            if (!reader.HasRows)
            {
                reader.Close();

                if (int.TryParse(PriceTextBox.Text, out int price))
                {
                    string query = "INSERT INTO Products(name, price) VALUES(@name, @price)";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@name", PNameTextBox.Text);
                    command.Parameters.AddWithValue("@price", price);

                    command.ExecuteNonQuery();

                    MaterialMessageBox.Show("Added Successfully", "Info", false, FlexibleMaterialForm.ButtonsPosition.Center);
                }
                else
                {
                    MaterialMessageBox.Show("Must be an Integer", "Info", false, FlexibleMaterialForm.ButtonsPosition.Center);
                }

            }
            else
            {
                MaterialMessageBox.Show("Already Exists", "Error", false, FlexibleMaterialForm.ButtonsPosition.Center);
            }

            conn.Close();

            ShowDataGridView();
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            if(DGV.SelectedRows.Count > 0)
            {
                PNameTextBox.Text = DGV.SelectedRows[0].Cells["PName"].Value.ToString();
                PriceTextBox.Text = DGV.SelectedRows[0].Cells["PPrice"].Value.ToString();
            }
        }

        bool CheckForNameConflict(SqlConnection connection, string name, int id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM Products WHERE name = @name AND id <> @id";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@id", id);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        private void PUpdateButton_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentRow != null)
            {
                int selectedRowId = Convert.ToInt32(DGV.SelectedRows[0].Cells["PIDCol"].Value);
                string newName = PNameTextBox.Text;
                string newPrice = PriceTextBox.Text;

                if (!string.IsNullOrEmpty(newName) && int.TryParse(newPrice, out int price))
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\Documents\B.Tech\Third Year\Fifth Semester\C#\project\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        bool isNewName = CheckForNameConflict(conn, newName, selectedRowId);

                        if (!isNewName)
                        {
                            string query = "UPDATE Products SET name = @name, price = @price WHERE Id = @id";
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@id", selectedRowId);
                                command.Parameters.AddWithValue("@name", newName);
                                command.Parameters.AddWithValue("@price", price);

                                command.ExecuteNonQuery();

                                MessageBox.Show("Updated Successfully.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Name already exists.");
                        }

                        conn.Close();

                        ShowDataGridView();
                    }
                }
                else
                {
                    MaterialMessageBox.Show("Something Went Wrong!", "Error", false, FlexibleMaterialForm.ButtonsPosition.Center);
                }
            }
            else
            {
                MaterialMessageBox.Show("Select a Row to Make Changes", "Info", false, FlexibleMaterialForm.ButtonsPosition.Center);

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\Documents\B.Tech\Third Year\Fifth Semester\C#\project\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = "DELETE FROM Products WHERE id = @id";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@id", Convert.ToInt64(DGV.SelectedCells[0].Value));

            command.ExecuteNonQuery();

            MaterialMessageBox.Show("Deleted Successfully", "Info", false, FlexibleMaterialForm.ButtonsPosition.Center);

            conn.Close();

            ShowDataGridView();
        }

        private void BillDGV_SelectionChanged(object sender, EventArgs e)
        {
            int totalBillAmount = 0;

            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                int productTotal = (Convert.ToInt32(row.Cells[BillDGV.Columns["BillPriceCol"].Index].Value) * Convert.ToInt32(row.Cells[BillDGV.Columns["BillQtCol"].Index].Value));
                row.Cells[BillDGV.Columns["BillTotalCol"].Index].Value = productTotal;
                totalBillAmount += productTotal;
            }

            BillTotalButton.Text = "";
            BillTotalButton.Text += totalBillAmount.ToString();
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            FillBillProductNames();
            BillDate.Text = DateTime.Now.ToShortDateString();
        }

        private void BillProductsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\Documents\B.Tech\Third Year\Fifth Semester\C#\project\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = "SELECT price FROM Products WHERE name = @name";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", BillProductsCB.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                BillPriceTB.Text = reader.GetFieldValue<int>(0).ToString();
            }

            conn.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int totalBillAmount = 0;
            bool Found = false;
            if (BillDGV.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in BillDGV.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == BillProductsCB.Text &&
                        Convert.ToString(row.Cells[1].Value) == BillPriceTB.Text)
                    {
                        row.Cells[2].Value = Convert.ToString(Convert.ToInt32(BillQtTB.Text) + Convert.ToInt32(row.Cells[2].Value));
                        Found = true;
                    }
                }

                if (!Found)
                {
                    BillDGV.Rows.Add(BillProductsCB.Text, BillPriceTB.Text, BillQtTB.Text);
                }
            }
            else
            {
                BillDGV.Rows.Add(BillProductsCB.Text, BillPriceTB.Text, BillQtTB.Text);
            }

            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                int productTotal = (Convert.ToInt32(row.Cells[BillDGV.Columns["BillPriceCol"].Index].Value) * Convert.ToInt32(row.Cells[BillDGV.Columns["BillQtCol"].Index].Value));
                row.Cells[BillDGV.Columns["BillTotalCol"].Index].Value = productTotal;
                totalBillAmount += productTotal;
            }

            BillTotalButton.Text = "";
            BillTotalButton.Text += totalBillAmount.ToString();
        }

        private void BGSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if(BGSwitch.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            } else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
        }

        private void DPAccentSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if(DPAccentSwitch.Checked)
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.DeepPurple800,
                    Primary.DeepPurple900,
                    Primary.DeepPurple500,
                    Accent.LightBlue200,
                    TextShade.WHITE
                );
            } else
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Blue800,
                    Primary.Blue900,
                    Primary.Blue500,
                    Accent.LightBlue200,
                    TextShade.WHITE
                );
            }
        }

        private void AmberAccentSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (AmberAccentSwitch.Checked)
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Amber800,
                    Primary.Amber900,
                    Primary.Amber500,
                    Accent.LightGreen200,
                    TextShade.WHITE
                );
            }
            else
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Blue800,
                    Primary.Blue900,
                    Primary.Blue500,
                    Accent.LightBlue200,
                    TextShade.WHITE
                );
            }
        }

        private void GreyAccentSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (GreyAccentSwitch.Checked)
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Grey800,
                    Primary.Grey900,
                    Primary.Grey500,
                    Accent.LightBlue200,
                    TextShade.WHITE
                );
            }
            else
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Blue800,
                    Primary.Blue900,
                    Primary.Blue500,
                    Accent.LightBlue200,
                    TextShade.WHITE
                );
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (BillDGV.Rows.Count == 0)
            {
                MessageBox.Show("No items in the bill to print.");
                return;
            }

            StringBuilder billText = new StringBuilder();

            billText.AppendLine("========== Bill ==========");
            billText.AppendLine("Customer Name: " + CustNameTB.Text);
            billText.AppendLine("Date: " + BillDate.Text);
            billText.AppendLine("==========================");
            billText.AppendLine("Products:");

            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                if (row.Cells["BillPNameCol"].Value != null &&
                    row.Cells["BillPriceCol"].Value != null &&
                    row.Cells["BillQtCol"].Value != null &&
                    row.Cells["BillTotalCol"].Value != null
                )
                {
                    string productName = row.Cells["BillPNameCol"].Value.ToString();
                    string price = row.Cells["BillPriceCol"].Value.ToString();
                    string quantity = row.Cells["BillQtCol"].Value.ToString();
                    string totalAmount = row.Cells["BillTotalCol"].Value.ToString();

                    billText.AppendLine(productName + "\tPrice: " + price + "\tQuantity: " + quantity + "\tTotal: " + totalAmount);
                }
            }

            billText.AppendLine("==========================");
            billText.AppendLine("Total Bill Amount: " + BillTotalButton.Text);
            billText.AppendLine("==========================");

            MessageBox.Show(billText.ToString(), "Bill");
            Document document = new Document();

            string pdfPath = Path.GetTempFileName() + ".pdf";

            try
            {
                PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));

                document.Open();
                document.Add(new Paragraph($"Customer Name: {CustNameTB.Text}"));
                document.Add(new Paragraph($"Date: {BillDate.Text}\n"));

                Paragraph p = new Paragraph();
                p.SpacingAfter = 25f;
                document.Add(p);

                PdfPTable table = new PdfPTable(4);

                float[] columnWidths = { 2f, 1f, 1f, 1f };
                table.SetWidths(columnWidths);

                table.AddCell("ProductName");
                table.AddCell("Price");
                table.AddCell("Quantity");
                table.AddCell("Total");

                foreach (DataGridViewRow row in BillDGV.Rows)
                {
                    if (row.Cells["BillPNameCol"].Value != null &&
                        row.Cells["BillPriceCol"].Value != null &&
                        row.Cells["BillQtCol"].Value != null &&
                        row.Cells["BillTotalCol"].Value != null)
                    {
                        string productName = row.Cells["BillPNameCol"].Value.ToString();
                        string price = row.Cells["BillPriceCol"].Value.ToString();
                        string quantity = row.Cells["BillQtCol"].Value.ToString();
                        string totalAmount = row.Cells["BillTotalCol"].Value.ToString();

                        table.AddCell(productName);
                        table.AddCell(price);
                        table.AddCell(quantity);
                        table.AddCell(totalAmount);
                    }
                }

                document.Add(table);
                document.Add(new Paragraph($"Total Bill Amount: {BillTotalButton.Text}"));

                document.Close();

                MessageBox.Show($"Bill saved as {pdfPath}", "PDF Saved");

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.FileName = "Bill.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(pdfPath, saveFileDialog.FileName, true);
                    MessageBox.Show("PDF saved successfully.", "PDF Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating PDF: {ex.Message}", "Error");
            }
        }
    }
}
