using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Uı
{
    public partial class Form1 : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\msag1\Desktop\visual\database\user.accdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                   
                    connection.Open();
                    string query = "SELECT COUNT(1) FROM [user] WHERE Username = ? AND Password = ?";
                    OleDbCommand command = new OleDbCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@Username", textUser.Text);
                    command.Parameters.AddWithValue("@Password", textPass.Text);

                    
                    int result = (int)command.ExecuteScalar();

                    if (result == 1)
                    {
                        MessageBox.Show("Congrulations!!! Username and Password are True....", "Sign In Panel", MessageBoxButtons.OK);

                        // Giriş başarılı, yeni formu aç
                        Form2 form = new Form2();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username and Password are wrong....", "Sign In Panel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    connection.Close();
                }
            }
        }
    }
}
