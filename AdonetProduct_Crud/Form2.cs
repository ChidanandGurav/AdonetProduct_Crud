using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Data;
using System.Drawing;


namespace AdonetProduct_Crud
{
    public partial class Form2 : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder builder;
        DataSet ds;

        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //Write a query
                string qry = " select * from Category";

                //Assign query to Adapter --> will fire the query
                da = new SqlDataAdapter(qry, con);

                //create object of DataSet
                ds = new DataSet();

                //FIll() will fire the select query and load data in the ds
                //Dept is a name given to the table in DataSet
                da.Fill(ds, "Category");
                cmbcategory.DataSource = ds.Tables["Category"];
                cmbcategory.DisplayMember = "Cname";
                cmbcategory.ValueMember = "Cid";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DataSet GetProducts()
        {
            string qry = "Select * from Product";

            //Assign the query
            da = new SqlDataAdapter(qry, con);

            //When app load the in Dataset, we need to manage the PK also
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            //SCB will track the Dataset and updatequeries to the DataAdapter
            builder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Product");//this name givrn to the dataset table
            return ds;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetProducts();

                // create new row to add recrod
                DataRow row = ds.Tables["Product"].NewRow();
                // assign value to the row
                row["Pname"] = txtpname.Text;
                row["Price"] = txtprice.Text;
                row["Cid"] = cmbcategory.SelectedValue;
                // attach this row in DataSet table
                ds.Tables["Product"].Rows.Add(row);
                // update the changes from DataSet to DB
                int result = da.Update(ds.Tables["Product"]);
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetProducts();
                // find the row
                DataRow row = ds.Tables["Product"].Rows.Find(txtpid.Text);
                if (row != null)
                {
                    row["Pname"] = txtpname.Text;
                    row["Price"] = txtprice.Text;
                    row["Cid"] = cmbcategory.SelectedValue;
                    // update the changes from DataSet to DB
                    int result = da.Update(ds.Tables["Product"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record updated");
                    }
                }
                else
                {
                    MessageBox.Show("Id not matched");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetProducts();
                // find the row
                DataRow row = ds.Tables["Product"].Rows.Find(txtpid.Text);
                if (row != null)
                {
                    // delete the current row from DataSet table
                    row.Delete();
                    // update the changes from DataSet to DB
                    int result = da.Update(ds.Tables["Product"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Id not matched");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetProducts();
                dataGridView1.DataSource = ds.Tables["Product"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnserach_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select p.*, c.Cname from Product p inner join Category c on c.Cid = p.Cid";
                da = new SqlDataAdapter(qry, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
                da.Fill(ds, "Employee");

                //find method can only search the data if pf is applied in the Dataset table
                DataRow row = ds.Tables["Employee"].Rows.Find(txtpid.Text);
                if (row != null)
                {
                    txtpname.Text = row["Pname"].ToString();
                    txtprice.Text = row["Price"].ToString();
                    cmbcategory.Text = row["Cname"].ToString();
                }
                else
                {
                    MessageBox.Show("Id not matched");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpid.Text = dataGridView1.CurrentRow.Cells["Pid"].Value.ToString();
            txtpname.Text = dataGridView1.CurrentRow.Cells["Pname"].Value.ToString();
            txtprice.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            cmbcategory.Text = dataGridView1.CurrentRow.Cells["Cid"].Value.ToString();
        }
    }
}

