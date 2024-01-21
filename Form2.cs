using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Skills_International
{
    public partial class Form2 : Form
    {
        string url = "Data Source=MSI;Initial Catalog=Student;Integrated Security=True";  //server name
        public Form2()
        {
            InitializeComponent();
            PopulateComboBox();
            ClearFormData();
        }

        private void PopulateComboBox() //combobox populate method
        {
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
            comboBox1.Items.Add(6);
            comboBox1.Items.Add(7);
            comboBox1.Items.Add(8);
            comboBox1.Items.Add(9);
            comboBox1.Items.Add(10);

        }

        private void ClearFormData()  //data clear method
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_mphone.Clear();
            txt_hphone.Clear();
            txt_parentName.Clear();
            txt_nic.Clear();
            txt_pphone.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }


        private void btn_clear_Click(object sender, EventArgs e)  //clear button
        {
            ClearFormData();
        }

        private void lable_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)  //exit link label
        {
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lable_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)  //logout link label
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }

        private void btn_register_Click(object sender, EventArgs e)  //register button
        {

            using (SqlConnection connection = new SqlConnection(url))
            {
                connection.Open();
                //data insertion query
                string query = "INSERT INTO Registration (regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilephone, homePhone, parentName, nic, contactNo) " +
                                   "VALUES (@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilephone, @homePhone, @parentName, @nic, @contactNo)";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@regNo", Convert.ToInt32(comboBox1.SelectedItem));
                        command.Parameters.AddWithValue("@firstName", txt_fname.Text);
                        command.Parameters.AddWithValue("@lastName", txt_lname.Text);
                        command.Parameters.AddWithValue("@dateOfBirth", date.Value);
                        command.Parameters.AddWithValue("@gender", radioButton1.Checked ? "Male" : "Female");
                        command.Parameters.AddWithValue("@address", txt_address.Text);
                        command.Parameters.AddWithValue("@email", txt_email.Text);
                        command.Parameters.AddWithValue("@mobilePhone", Convert.ToInt32(txt_mphone.Text));
                        command.Parameters.AddWithValue("@homephone", Convert.ToInt32(txt_hphone.Text));
                        command.Parameters.AddWithValue("@parentName", txt_parentName.Text);
                        command.Parameters.AddWithValue("@nic", txt_nic.Text);
                        command.Parameters.AddWithValue("@contactNo", Convert.ToInt32(txt_pphone.Text));

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record added successful", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registration failed", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex);
                }

            }

        }

        private void btn_delete_Click(object sender, EventArgs e)  //delete button
        {

            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (comboBox1.SelectedItem != null)
                {
                    using (SqlConnection connection = new SqlConnection(url))
                    {
                        try
                        {
                            connection.Open();

                            //data delete query
                            string query = "DELETE FROM Registration WHERE regNo = @regNo";

                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@regNo", Convert.ToInt32(comboBox1.SelectedItem));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully", "delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFormData();
                            }
                            else
                            {
                                MessageBox.Show("No record found with the selected registration number", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a record to delete", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btn_update_Click(object sender, EventArgs e) //update button
        {
            if (comboBox1.SelectedItem != null)
            {
                using (SqlConnection connection = new SqlConnection(url))
                {
                    try
                    {
                        connection.Open();

                        //data update query
                        string query = "UPDATE Registration SET firstName = @firstName, lastName = @lastName, dateOfBirth = @dateOfBirth, gender = @gender, " +
                                       "address = @address, email = @email, mobilephone = @mobilephone, homePhone = @homePhone, " +
                                       "parentName = @parentName, nic = @nic, contactNo = @contactNo WHERE regNo = @regNo";

                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@regNo", Convert.ToInt32(comboBox1.SelectedItem));
                        command.Parameters.AddWithValue("@firstName", txt_fname.Text);
                        command.Parameters.AddWithValue("@lastName", txt_lname.Text);
                        command.Parameters.AddWithValue("@dateOfBirth", date.Value);
                        command.Parameters.AddWithValue("@gender", radioButton1.Checked ? "Male" : "Female");
                        command.Parameters.AddWithValue("@address", txt_address.Text);
                        command.Parameters.AddWithValue("@email", txt_email.Text);
                        command.Parameters.AddWithValue("@mobilephone", Convert.ToInt32(txt_mphone.Text));
                        command.Parameters.AddWithValue("@homePhone", Convert.ToInt32(txt_hphone.Text));
                        command.Parameters.AddWithValue("@parentName", txt_parentName.Text);
                        command.Parameters.AddWithValue("@nic", txt_nic.Text);
                        command.Parameters.AddWithValue("@contactNo", Convert.ToInt32(txt_pphone.Text));

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the selected registration number", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)  // Combo box as a search function
        {
            if (comboBox1.SelectedItem != null) // Check if a registration number is selected
            {
                using (SqlConnection connection = new SqlConnection(url))
                {
                    try
                    {
                        connection.Open();

                        //all data selection query
                        string query = "SELECT * FROM Registration WHERE regNo = @searchValue";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@searchValue", Convert.ToInt32(comboBox1.SelectedItem));

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            txt_fname.Text = reader["firstName"].ToString();
                            txt_lname.Text = reader["lastName"].ToString();
                            date.Value = Convert.ToDateTime(reader["dateOfBirth"]);
                            string gender = reader["gender"].ToString();

                            if (gender == "Male")
                                radioButton1.Checked = true;
                            else if (gender == "Female")
                                radioButton2.Checked = true;

                            txt_address.Text = reader["address"].ToString();
                            txt_email.Text = reader["email"].ToString();

                            int mobilephone = Convert.ToInt32(reader["mobilephone"]);
                            txt_mphone.Text = mobilephone.ToString();

                            int homePhone = Convert.ToInt32(reader["homePhone"]);
                            txt_hphone.Text = homePhone.ToString();

                            int contactNo = Convert.ToInt32(reader["contactNo"]);
                            txt_pphone.Text = contactNo.ToString();
                            txt_parentName.Text = reader["parentName"].ToString();
                            txt_nic.Text = reader["nic"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("No records found for the selected registration number", "Search Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearFormData();
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
