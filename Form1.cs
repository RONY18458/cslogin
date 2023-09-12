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
using System.Data.SqlClient;

namespace LOGINRN

{
  
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
            
        {
            String nombre, contraseña;
            nombre = user.Text;
            contraseña = pass.Text;
            SqlConnection con = new SqlConnection("Data source=DESKTOP-7LDGQBD;Initial catalog=;Integrated security=True");
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }
            String sql ="select user, pass from user where user = '" + nombre + "' AND pass_long = '" + contraseña + "'  ";
            SqlCommand cmd = new SqlCommand(sql,con);
            sqlDataReader read = cmd.ExecuteReader();
            if (read.read())
            {
                this.Hide();
                MessageBox.Show("bienvenido" + nombre);
            }
            else
            {
                MessageBox.Show("no existe el usuario" + nombre);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
