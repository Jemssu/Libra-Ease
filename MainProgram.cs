using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 
/// </summary>
namespace IT_PROJECT
{
    public partial class MainProgram : Form
    {
        readonly Random random = new Random(); // Random Number Generator 
        private readonly string authorizationPasscode = "admin"; // Authentication Code for EDIT and DELETE operations
        private bool editMode = false; // Sets Default Value for editMode
        private BookData originalBookData;
        private bool insertMode = false;


        //                        //
        //    FORM OPERATIONS     //
        //                        //

        public MainProgram()
        {
            InitializeComponent();
            EnableBookComponents(false);
            EnableAutomatedComponents(false);
            EnableButtonsToggle(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.libraryManagementTableAdapter.Fill(this.libraEase.LibraryManagement); // Fills the Table with Data
            libraryManagementDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selects the Whole ROW instead of Just One Column
            libraryManagementDataGridView.AllowUserToAddRows = false; // DISABLES the NEW BLANK ROW 
        }


        //                             //
        //    OBSERVERS AND HELPERS    //
        //                             //
        
        // Method that CHECKS / UNCHECKS the AVAILABILITY CHECKBOX
        private void CheckAvailabilityBox(bool value)
        {
            availabilityCheckBox.Checked = value;

            if (value == true)
            {
                availabilityCheckBox.CheckState = CheckState.Checked;
            } else if (value == false)
            {
                availabilityCheckBox.CheckState = CheckState.Unchecked;
            }
        }

        // Method that Sets BorrowerID to '1', Borrow, Due and Returned to Today
        private void SetBorrowerDetailsToDefault()
        {
            // Clear the Borrower ID (set it to "1" which means Library or anything as all ID must be 8-digits)
            borrowerIDTextBox.Text = "1";
            dateBorrowedDateTimePicker.Value = DateTime.Today;
            dateDueDateTimePicker.Value = DateTime.Today;
            dateReturnedDateTimePicker.Value = DateTime.Today;

        }

        // Method that SETS the DATETIME VALUES to TODAY
        private void SetPublicationDateTimeToDefault()
        {
            publicationDateDateTimePicker.Value = DateTime.Today;

        }

        // Method that SAVES the Data / UPDATES the data
        private void SaveChangesToSQL()
        {
            this.Validate();
            this.libraryManagementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraEase);
        }

        // Method that ENABLES / DISABLES the AUTOMATED PARTS
        private void EnableAutomatedComponents(bool value)
        {
            bookIDTextBox.Enabled = value;
            availabilityCheckBox.Enabled = value;
            borrowerIDTextBox.Enabled = value;
            dateBorrowedDateTimePicker.Enabled = value;
            dateDueDateTimePicker.Enabled = value;
            dateReturnedDateTimePicker.Enabled = value;
        }

        // Method that ENABLES / DISABLES the BOOK PARTS
        private void EnableBookComponents(bool value)
        {
            titleTextBox.Enabled = value;
            authorTextBox.Enabled = value;
            publisherTextBox.Enabled = value;
            genreComboBox.Enabled = value;
            publicationDateDateTimePicker.Enabled = value;
        }

        // Method that ENABLES / DISABLES the BUTTONS and TABLE
        private void EnableButtonsToggle(bool value)
        {
            bindingNavigatorAddNewItem.Enabled = value;
            libraryManagementDataGridView.Enabled = value;
            SearchBox.Enabled = value;
            SearchButton.Enabled = value;
            EditButton.Enabled = value;
            DeleteButton.Enabled = value;
            ClearButton.Enabled = value;
            BorrowButton.Enabled = value;
            ReturnButton.Enabled = value;
            CopyButton.Enabled = value;
            Cancel.Enabled = !value;
        }

        // Method that ENABLES / DISABLES the EnableBookComponents Method
        private void EditModeToggle()
        {
            editMode = !editMode;

            EnableBookComponents(editMode);
        }

        // Method that ENABLES / DISABLES the insertMode
        private void InsertModeToggle()
        {
            insertMode = !insertMode;
        }

        // Method that GENERATES and SETS the VALUE directly to the bookID TextBox
        private void GenerateThenSetBookID()
        {
            int bookID;
            do
            {
                bookID = random.Next(10000000, 100000000); // Generate a random 8-digit number
            } while (DoesBookIDExist(bookID));

            bookIDTextBox.Text = bookID.ToString();
        }

        // Method that AVOIDS DUPLICATION
        private bool DoesBookIDExist(int bookID)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=Jems-PC-1227;Initial Catalog=myLibraryDB;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM LibraryManagement WHERE BookID = @BookID", connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookID);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Method that DELETED the SELECTED ROW and Calls the SaveDeletedLog Method
        private void PerformDeleteOperation()
        {
            SaveDeletedLog(libraryManagementDataGridView.SelectedRows[0]);
            libraryManagementDataGridView.Rows.Remove(libraryManagementDataGridView.SelectedRows[0]);
            MessageBox.Show("Row Deleted Successfully! Added to Logs.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Save and Update the data inside the Database
            SaveChangesToSQL();
            
        }

        // Method that LOGS the DELETED DATA into a File
        private void SaveDeletedLog(DataGridViewRow row)
        {
            string
            deletedData = "Book ID: " + row.Cells["dataGridViewTextBoxColumn1"].Value + "\n";
            deletedData += "Title: " + row.Cells["dataGridViewTextBoxColumn2"].Value + "\n";
            deletedData += "Author: " + row.Cells["dataGridViewTextBoxColumn3"].Value + "\n";
            deletedData += "Publisher: " + row.Cells["dataGridViewTextBoxColumn5"].Value + "\n";
            deletedData += "Publication Date: " + row.Cells["dataGridViewTextBoxColumn6"].Value + "\n";
            deletedData += "Genre: " + row.Cells["dataGridViewTextBoxColumn4"].Value + "\n";
            deletedData += "Availability: " + row.Cells["dataGridViewCheckBoxColumn1"].Value + "\n";
            deletedData += "Borrower ID: " + row.Cells["dataGridViewTextBoxColumn7"].Value + "\n";
            deletedData += "Borrowed Date: " + row.Cells["dataGridViewTextBoxColumn8"].Value + "\n";
            deletedData += "Due Date: " + row.Cells["dataGridViewTextBoxColumn9"].Value + "\n";
            deletedData += "Returned Date: " + row.Cells["dataGridViewTextBoxColumn10"].Value + "\n";

            string filePath = @"C:\Users\Admin\source\repos\ProjectSample\logs.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(deletedData);
                }
                // The Line Below is For Debugging ONLY
                // MessageBox.Show("Data appended to the file: " + filePath, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException)
            {
                // The Line Below is For Debugging ONLY
                // MessageBox.Show("File not found. Creating a new file: " + filePath, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(deletedData);
                }
            }
            // The Lines Below are For Debugging ONLY
            // catch (Exception ex)
            // {
                // MessageBox.Show("Error while writing to the file: " + ex.Message, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }
        }

        //                                       //
        //    NAVIGATOR AND TABLE OPERATIONS     //
        //                                       //

        // Add Button (ICON)
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Disables the Buttons |
            EnableButtonsToggle(false);
 
            // Enables the Book Components
            EnableBookComponents(true);

            // Sets the InsertMode to True -- Allows Cancel Button to Work
            InsertModeToggle();

            // Generates and Sets a Unique BookID
            GenerateThenSetBookID();

            // Update the Publication Date to Today
            SetPublicationDateTimeToDefault();

            // Set the "Availability" field to true and (checked)
            CheckAvailabilityBox(true);

            borrowerIDTextBox.Text = "1";
            dateBorrowedDateTimePicker.Value = DateTime.Today;
            dateDueDateTimePicker.Value = DateTime.Today;
            dateReturnedDateTimePicker.Value = DateTime.Today;
        }

        // Save Button (ICON)
        private void libraryManagementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            { 
                // Checks if Title, Author, Genre, Publisher and Publication Date is Not Empty
                if (string.IsNullOrEmpty(titleTextBox.Text))
                {
                    MessageBox.Show("Please fill in the Title field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(authorTextBox.Text))
                {
                    MessageBox.Show("Please fill in the Author field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(genreComboBox.Text))
                {
                    MessageBox.Show("Please fill in the Genre field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(publisherTextBox.Text))
                {
                    MessageBox.Show("Please fill in the Publisher field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!editMode)
                {
                    if (publicationDateDateTimePicker.Value == DateTime.Today)
                    {
                        MessageBox.Show("Please Change the Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                

                // Save and Update the data inside the Database
                SaveChangesToSQL();
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Disables the Book Components
                EnableBookComponents(false);  
                // Disables Edit Mode
                editMode = false;
                // Enables the Buttons Again
                EnableButtonsToggle(true);
                // Disables Insert Mode
                insertMode = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured: {ex.Message} \nKindly Check!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // There is no need to modify this
        private void libraryManagementDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // There is no need to modify this
        private void libraryManagementBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        //                          //
        //    BUTTON OPERATIONS     //
        //                          //

        // SearchBox (TextBox) - Don't Mind This
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Search Button
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchKeyword = SearchBox.Text.Trim();

            // This Deselects the Currently Selected Cell as Upon Testing it also Includes
            // It for apparently No Reason. This is just for Double-Checking / Error-Removal.
            libraryManagementDataGridView.CurrentCell = null;

            // Checks if the SearchBox is EMPTY or NOT
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                // Foreach Loop in the Table
                foreach (DataGridViewRow row in libraryManagementDataGridView.Rows)
                {
                    // Checks if the Current Row (Passed by the Foreach Loop) is not a New Row
                    // This is Useless Now Since I Removed the New Row Upon Loading the Form
                    if (!row.IsNewRow)
                    {
                        bool rowMatchesSearch = false;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value.ToString().IndexOf(searchKeyword, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                rowMatchesSearch = true;
                                break;
                            }
                        }

                        // This Makes the Current Row (Passed by the Foreach Loop) to be Invisible since it does not Match the Search Key
                        if (!rowMatchesSearch)
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
            else
            {
                // If the Keyword is Blank, it just Shows Everything Back!
                foreach (DataGridViewRow row in libraryManagementDataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        // Clear Button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // This Here Clears the SearchBox
            SearchBox.Clear();

            // Below Shows the Rows Back
            foreach (DataGridViewRow row in libraryManagementDataGridView.Rows)
            {
                row.Visible = true;
            }
        }

        // Borrow Button
        private void BorrowButton_Click(object sender, EventArgs e)
        {
            // Did User Select a Row Checker
            if (libraryManagementDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Book to Borrow.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get The Selected Row
            DataGridViewRow selectedRow = libraryManagementDataGridView.SelectedRows[0];

            // Check the Value of the Availability Check Box
            bool isAvailable = (bool)selectedRow.Cells["dataGridViewCheckBoxColumn1"].Value;

            // Determines if Book is Available or Not (Borrowed)
            if (!isAvailable)
            {
                MessageBox.Show("This Book Can't Be Borrowed! Somebody is Currently Using it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Borrow Date and Due Date Variables
            DateTime borrowDate;
            DateTime dueDate;

            using (BorrowerInputForm inputDialog = new BorrowerInputForm())
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the Borrower ID entered by the user
                    string newBorrowerID = inputDialog.BorrowerID_INPUT;

                    // Sets Borrower ID
                    borrowerIDTextBox.Text = newBorrowerID;

                    // Set Borrow Date to today
                    borrowDate = DateTime.Today;
                    dateBorrowedDateTimePicker.Value = DateTime.Today;

                    // Calculate Due Date (15 days from Borrow Date)
                    dueDate = borrowDate.AddDays(15);
                    dateDueDateTimePicker.Value = dueDate;

                    // Set Return Date to Borrow Date (Default -- Can be Modified)
                    dateReturnedDateTimePicker.Value = borrowDate;

                    // Uncheck the availability checkbox to indicate that the book is now borrowed
                    selectedRow.Cells["dataGridViewCheckBoxColumn1"].Value = false;

                    // Save and Update the data inside the Database
                    SaveChangesToSQL();
                    MessageBox.Show("Information Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
        }

        // Return Button
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            // Get The Selected Row
            if (libraryManagementDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Book to Return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = libraryManagementDataGridView.SelectedRows[0];

            // Check the Value of the Availability Check Box
            bool isAvailable = (bool)selectedRow.Cells["dataGridViewCheckBoxColumn1"].Value;

            // Determines if Book is Borrowed or Not (Available)
            if (isAvailable)
            {
                MessageBox.Show("This book is Currently Not Borrowed. You Cannot Return it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Checks the Availability Checkbox
            selectedRow.Cells["dataGridViewCheckBoxColumn1"].Value = true;

            // Update the Dates to NOW and Sets the ID to '1'
            SetBorrowerDetailsToDefault();

            // Save and Update the data inside the Database
            SaveChangesToSQL();
            MessageBox.Show("Information Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // EditButton - Responsible for Deleting Data in the Table
        private void EditButton_Click(object sender, EventArgs e)
        {
            // Did User Select a Row Checker
            if (libraryManagementDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Row to Edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ask for the authorization passcode every time
            using (var authorizationForm = new AuthorizationInputForm())
            {
                if (authorizationForm.ShowDialog() == DialogResult.OK)
                {
                    string passcode = authorizationForm.AuthCodeBoxValue;
                    if (passcode == authorizationPasscode)
                    {
                        // Stores the Original Values
                        StoreOriginalValues();

                        // Enables Editing and Disables the Buttons to Avoid Errors
                        EditModeToggle();
                        EnableButtonsToggle(false);
                    }
                    else
                    {
                        MessageBox.Show("Authorization Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // DeleteButton - Responsible for Deleting Data in the Table
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Did User Select a Row Checker
            if (libraryManagementDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Row to Delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Ask for the authorization passcode every time
            using (var authorizationForm = new AuthorizationInputForm())
            {
                if (authorizationForm.ShowDialog() == DialogResult.OK)
                {
                    string passcode = authorizationForm.AuthCodeBoxValue;
                    if (passcode == authorizationPasscode)
                    {
                        // Calls the method to Delete
                        PerformDeleteOperation();
                    }
                    else
                    {
                        MessageBox.Show("Authorization Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //                          //
        //    SQL LABELS AND BOX    //
        //                          //

        // Book ID
        private void bookIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void bookIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Book Title
        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Book Author
        private void authorLabel_Click(object sender, EventArgs e)
        {

        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Book Genre
        private void genreLabel_Click(object sender, EventArgs e)
        {

        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Book Publisher 
        private void publisherLabel_Click(object sender, EventArgs e)
        {

        }

        private void publisherTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Publication Date
        private void publicationDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void publicationDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        // Book Availability
        private void availabilityLabel_Click(object sender, EventArgs e)
        {

        }

        private void availabilityCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Borrower ID
        private void borrowerIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void borrowerIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Borrowed Date
        private void dateBorrowedLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateBorrowedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        // Due Date
        private void dateDueLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateDueDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        // Returned Date
        private void dateReturnedLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateReturnedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        // CopyToClipboard Button
        private void CopyButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (libraryManagementDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = libraryManagementDataGridView.SelectedRows[0];

                // Create a StringBuilder to hold the row data
                StringBuilder rowData = new StringBuilder();

                // Append the data from each cell in the selected row
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Append(cell.Value);
                    rowData.Append("\t"); // Use tab as a delimiter
                }
                // Copy the row data to the clipboard
                Clipboard.SetText(rowData.ToString());

                // This is for Debugging Only
                // MessageBox.Show("Selected row data copied to clipboard.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Help Label (directs to GitHub Wiki with Instructions) -- https://github.com/Jemssu/Libra-Ease/wiki/Getting-Started
        private void HelpLabel_Click(object sender, EventArgs e)
        {
            string wikiURL = "https://github.com/Jemssu/Libra-Ease/wiki/Getting-Started";

            // Open the default web browser to the specified URL.
            try
            {
                Process.Start(wikiURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the help page: " + ex.Message, "Error");
            }
        }
        
        // Cancel Button
        private void Cancel_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                // Restore the Original Values 
                RestoreOriginalValues();

                // If in edit mode, cancel the changes and revert to non-edit mode
                editMode = false;
                EnableBookComponents(false);
                EnableButtonsToggle(true);

                // Save and Update the data inside the Database
                SaveChangesToSQL();

                MessageBox.Show("Changes Were Reverted", "Reverted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (insertMode)
            {
                // Cancel the insert operation
                insertMode = false;

                // Clear the input fields and disable book components
                EnableBookComponents(false);
                EnableButtonsToggle(true);

                // Erase the New Row Made with Null Values
                libraryManagementDataGridView.Rows.RemoveAt(libraryManagementDataGridView.Rows.Count - 1);

                // Save and Update the data inside the Database
                SaveChangesToSQL();

                MessageBox.Show("No New Book was Added", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private class BookData
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public string Publisher { get; set; }
            public DateTime PublicationDate { get; set; }
        }


        private void StoreOriginalValues()
        {
            originalBookData = new BookData
            {
                Title = titleTextBox.Text,
                Author = authorTextBox.Text,
                Genre = genreComboBox.Text,
                Publisher = publisherTextBox.Text,
                PublicationDate = publicationDateDateTimePicker.Value
            };
        }


        private void RestoreOriginalValues()
        {
            titleTextBox.Text = originalBookData.Title;
            authorTextBox.Text = originalBookData.Author;
            genreComboBox.Text = originalBookData.Genre;
            publisherTextBox.Text = originalBookData.Publisher;
            publicationDateDateTimePicker.Value = originalBookData.PublicationDate;
        }

    } // END OF CLASS
} // END OF NAMESPACE`