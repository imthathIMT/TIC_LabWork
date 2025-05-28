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

namespace WinFormsWithDB
{
    public partial class Form1 : Form
    {
        private string _connString ;

        public Form1()
        {
            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(email) )
            {
                MessageBox.Show("Please enter both Name and Email.");
                return;
            }

            string query = "INSERT INTO Customers (Name, Email) VALUES (@Name, @Email)";
            using (SqlCommand cmd = new SqlCommand(query, Program.conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);

                if (Program.conn.State != ConnectionState.Open)
                    Program.conn.Open();

                cmd.ExecuteNonQuery();
                Program.conn.Close();

                MessageBox.Show("Saved!");
                txtEmail.Clear();
                txtName.Clear();
                LoadData();
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT Id, Name, Email FROM Customers";
            using (SqlCommand cmd = new SqlCommand(query, Program.conn))
            {
                if (Program.conn.State != System.Data.ConnectionState.Open)
                    Program.conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                Program.conn.Close();
            }

            // Hide the Id column in the DataGridView
            if (dataGridView1.Columns["Id"] != null)
            {
                dataGridView1.Columns["Id"].Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get Id of selected row
            int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Customers WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, Program.conn))
                {
                    cmd.Parameters.AddWithValue("@Id", selectedId);

                    if (Program.conn.State != System.Data.ConnectionState.Open)
                        Program.conn.Open();

                    cmd.ExecuteNonQuery();
                    Program.conn.Close();

                    MessageBox.Show("Record deleted.");
                    LoadData();
                }
            }

        }
    }
}
