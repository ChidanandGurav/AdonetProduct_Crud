using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Data;

namespace AdonetProduct_Crud
{
    public partial class Form1 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        private object DataTable;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                List<Category> list = new List<Category>();
                string qry = "Select * from Category";
                cmd = new SqlCommand(qry, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Category cat = new Category();
                        cat.Cid = Convert.ToInt32(reader["Cid"]);
                        cat.Cname = reader["Cname"].ToString();
                        list.Add(cat);

                    }
                }
                cmbcategory.DataSource = list;
                cmbcategory.DisplayMember = "Cname";
                cmbcategory.ValueMember = "Cid";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into product values(@Pname,@Price,@Cid)";
                cmd = new SqlCommand(qry, con);
                // assign value to each parameter
                cmd.Parameters.AddWithValue("@Pname", txtpname.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtprice.Text));
                cmd.Parameters.AddWithValue("@Cid", Convert.ToInt32(cmbcategory.SelectedValue));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                    ClearFields();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            
            GetAllProducts();
        }

        private void btnserach_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select p.*, c.Cname from Product p inner join Category c on c.Cid = p.Cid where p.Pid=@Pid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Pid", Convert.ToInt32(txtpid.Text));
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        txtpname.Text = reader["Pname"].ToString();
                        txtprice.Text = reader["Price"].ToString();
                        cmbcategory.Text = reader["Cname"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Product set Pname=@Pname,Price=@Price,Cid=@Cid where Pid=@Pid";
                cmd = new SqlCommand(qry, con);
                // assign value to each parameter
                cmd.Parameters.AddWithValue("@Pname", txtpname.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtprice.Text));
                cmd.Parameters.AddWithValue("@Cid", Convert.ToInt32(cmbcategory.SelectedValue));
                cmd.Parameters.AddWithValue("@Pid", Convert.ToInt32(txtpid.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record updated");
                    ClearFields();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            GetAllProducts();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Product where Pid=@Pid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtpid.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record deleted");
                    ClearFields();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            GetAllProducts();
        }

        private void GetAllProducts()
        {
            string qry = "select p.*, c.Cname from Product p inner join Category c on c.Cid = p.Cid";
            cmd = new SqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();

        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        private void ClearFields()
        {
            txtpid.Clear();
            txtpname.Clear();
            txtprice.Clear();
            cmbcategory.ResetText();
        }

        
    }
}


