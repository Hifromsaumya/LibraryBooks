using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryBooks
{
    public partial class Library : Form
    {
        /*//----Delegate
        DelegateForVoid delegateOpenConnection = openConnection;
        DelegateForVoid delegatepopulateDataGridView = populateDataGridView;
        DelegateForVoid delegateclearInputFields = clearInputFields;
        DelegateForByte delegateconvertImageToByteArray = convertImageToByteArray;
        DelegateForVoid multiDel = delegateOpenConnection + delegatepopulateDataGridView + delegateclearInputFields + delegateconvertImageToByteArray;*/


        //----MS Accesss DB Connection String Field
        string microsoftAccessDatabaseConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\krich\OneDrive\Desktop\DB.accdb";
        //----Quere to insert data in MS Access DB
        string insertDataIntoMicrosoftAccessDatabase = "INSERT INTO Book(Name, PublishedYear, CoverPhoto) VALUES(?, ?, ?)";
        //----Query to Get all data from MS Access DB
        string GetAllData = "SELECT * FROM Book";
        //----Query to Update data
        string UpdateSelectedData = "UPDATE Book SET Name =?, PublishedYear =?, CoverPhoto =? WHERE ID = ?";
        //----Query to Delete data
        string DeleteSelectedData = "DELETE FROM Book WHERE ID = ?";

        //----OleDB Connection Field
        public OleDbConnection microsoftAccessDatabaseOleDbConnection = null;

        public Library()
        {
            //----Initialize OleDb Connection in a Form Constructor---- OleDb conn. instance is created automatically everytime form loads
            microsoftAccessDatabaseOleDbConnection = new OleDbConnection(microsoftAccessDatabaseConnectionString);  //----MS Access DB conn string is passed as an argument
            InitializeComponent();
            openConnection();
        }

        //----Method to Start Connection
        public static void openConnection()
        {
            Library lib = new Library();
            if (lib.microsoftAccessDatabaseOleDbConnection.State == ConnectionState.Closed)
            {
                lib.microsoftAccessDatabaseOleDbConnection.Open();
                MessageBox.Show("Connection Started");
            }
        }//----Opening Connection
        private void buttonConnect_Click(object sender, System.EventArgs e)
        {
            openConnection();  //-----Using Deleagte
        }

        /*//----Method to Close Connection
        public void closeConnection()
        {
            if (microsoftAccessDatabaseOleDbConnection.State == ConnectionState.Open)
            {
                microsoftAccessDatabaseOleDbConnection.Close();
                MessageBox.Show("Connection Closed");
            }
        }//----Cloasing Connection
        private void buttonCloseConnection_Click(object sender, System.EventArgs e)
        {
            closeConnection();
        }*/

        public static byte[] convertImageToByteArray(Image image)
        {
            MemoryStream convertImageMemoryStream = new MemoryStream();
            image.Save(convertImageMemoryStream, image.RawFormat);
            return convertImageMemoryStream.ToArray();
        }

        //----Selecting Cover photo
        private void buttonChooseCover_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog coverUploadFileDialog = new OpenFileDialog();
                coverUploadFileDialog.Title = "Choose Image";
                coverUploadFileDialog.Filter = "Choose Image Files | *.png; *.jpg; *.gif";
                DialogResult coverUploadDialogResult = coverUploadFileDialog.ShowDialog();
                if (coverUploadDialogResult == DialogResult.OK)
                {
                    string fileName = coverUploadFileDialog.FileName;
                    pictureBoxCover.Image = Image.FromFile(fileName);
                }
            }
            catch (Exception imageException)
            {

                MessageBox.Show(imageException.Message);
            }
        }

        //----Inserting data
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            OleDbCommand InsertDataIntoMicrosoftAccessDatabaseOleDbCommand;

            if (String.IsNullOrEmpty(textBoxBookName.Text) || String.IsNullOrEmpty(textBoxPublishedYear.Text) || pictureBoxCover.Image == null)
            {
                MessageBox.Show("One Or More Fields Are Empty Make Sure All Fields Are Filled");
            }
            else
            {
                try
                {
                    InsertDataIntoMicrosoftAccessDatabaseOleDbCommand = new OleDbCommand(insertDataIntoMicrosoftAccessDatabase, microsoftAccessDatabaseOleDbConnection);
                    InsertDataIntoMicrosoftAccessDatabaseOleDbCommand.Parameters.AddWithValue("Name", OleDbType.VarChar).Value = textBoxBookName.Text;
                    InsertDataIntoMicrosoftAccessDatabaseOleDbCommand.Parameters.AddWithValue("PublishedYear", OleDbType.VarChar).Value = textBoxPublishedYear.Text;
                    InsertDataIntoMicrosoftAccessDatabaseOleDbCommand.Parameters.AddWithValue("CoverPhoto", OleDbType.Binary).Value = convertImageToByteArray(pictureBoxCover.Image);
                    //----Open Database Connection
                    openConnection();
                    int dataInserted = InsertDataIntoMicrosoftAccessDatabaseOleDbCommand.ExecuteNonQuery();

                    if (dataInserted > 0)
                    {
                        MessageBox.Show("Data Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    /*//----finally close ConnectionDatabase
                    closeConnection();*/
                    populateDataGridView();
                }
            }
            }

        //----Populating DataGridView
        private void Library_Load(object sender, EventArgs e)
        {
            //Change dataGridView Row Height
            dataGridView.RowTemplate.Height = 50;
            populateDataGridView();
        }//----Method to Populate DataGridView
        public static void populateDataGridView()
        {
            try
            {
                Library lib = new Library();
                //----clearing Datagridview rows before loading data
                if (lib.dataGridView.Rows.Count > 0)
                {
                    lib.dataGridView.Rows.Clear();
                }
                OleDbCommand populateDatagridViewOleDbCommand = new OleDbCommand(lib.GetAllData, lib.microsoftAccessDatabaseOleDbConnection);
                OleDbDataReader reader = populateDatagridViewOleDbCommand.ExecuteReader();
                //----Open Database Connection
                openConnection();
                while (reader.Read()) //----Looping throught the DB
                {
                    //AddDB to datagridview
                    lib.dataGridView.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), (byte[])reader[3]);
                }
                reader.Close();
            }
            catch (Exception populatingDataInDataGridViewException)
            {
                MessageBox.Show(populatingDataInDataGridViewException.Message);
            }
            /*finally
            {
                //----finally close Connection w Database
                closeConnection();
            }*/
        }

        //----Updating Data
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("First click on datagridview cell content or Make sure id field is not empty");
            }
            else
            {
                OleDbCommand UpdateDataOleDbCommand;
                //----Check If One Or More Fields Are Empty
                if (String.IsNullOrEmpty(textBoxBookName.Text) || String.IsNullOrEmpty(textBoxPublishedYear.Text) || pictureBoxCover.Image == null)
                {
                    MessageBox.Show("One Or More Fields Are Empty Make Sure All Fields Are Filled");
                }
                else
                {
                    try
                    {
                        UpdateDataOleDbCommand = new OleDbCommand(UpdateSelectedData, microsoftAccessDatabaseOleDbConnection);
                        UpdateDataOleDbCommand.Parameters.AddWithValue("Name", OleDbType.VarChar).Value = textBoxBookName.Text;
                        UpdateDataOleDbCommand.Parameters.AddWithValue("PublishedYear", OleDbType.VarChar).Value = textBoxPublishedYear.Text;
                        UpdateDataOleDbCommand.Parameters.AddWithValue("Cover", OleDbType.Binary).Value = convertImageToByteArray(pictureBoxCover.Image);
                        UpdateDataOleDbCommand.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt16(textBoxID.Text);
                        //----Open Database Connection
                        openConnection();
                        int dataInserted = UpdateDataOleDbCommand.ExecuteNonQuery();

                        if (dataInserted > 0)
                        {
                            MessageBox.Show("Data Updated");
                        }
                    }
                    catch (Exception updateDataException)
                    {
                        MessageBox.Show(updateDataException.Message);
                    }
                    finally
                    {
                        /*//----finally close Connection w Database
                        closeConnection();*/
                        //Refresh DtaaGridview
                        populateDataGridView();
                    }
                }
            }
        }

        //----Method for Clearing Fields
        public static void clearInputFields()
        {
            Library lib = new Library();
            if (String.IsNullOrEmpty(lib.textBoxBookName.Text) && string.IsNullOrEmpty(lib.textBoxPublishedYear.Text) && lib.pictureBoxCover.Image == null)
            {
                MessageBox.Show("All Fields Empty");
            }
            else
            {
                //----Clear
                lib.textBoxID.Text = string.Empty;
                lib.textBoxBookName.Text = string.Empty;
                lib.textBoxPublishedYear.Text = string.Empty;
                lib.pictureBoxCover.Image = null;
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearInputFields();
        }

        //----Deleting Data
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //----check If Id TextBox Is Empty
                if (String.IsNullOrEmpty(textBoxID.Text))
                {
                    MessageBox.Show("ID Field Is Empty Click On Datagrid row cell first");
                }
                else
                {
                    OleDbCommand deleteDataOleDbCommand = new OleDbCommand(DeleteSelectedData, microsoftAccessDatabaseOleDbConnection);
                    deleteDataOleDbCommand.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt16(textBoxID.Text);
                    //----Open Microsoft Access Database Connection
                    openConnection();

                    int deleteDataFromMicrosoftAccessDatabase = deleteDataOleDbCommand.ExecuteNonQuery();
                    if (deleteDataFromMicrosoftAccessDatabase > 0)
                    {
                        MessageBox.Show("Data Deleted From Microsoft Access Database Successfully");
                        //-----Clear Input Fields 
                        clearInputFields();
                    }
                }
            }
            catch (Exception deleteDataException)
            {
                MessageBox.Show(deleteDataException.Message);
            }
            finally
            {
                /*//Close Microsoft Access Database Connection
                closeConnection();*/
                //Refresh Datagridview after Deleting data From the database
                populateDataGridView();
            }
        }

        
    }
}

