using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MSSS_Master_File_Project___Dictionary
{
    /// <summary>
    /// Project Details ///
    /// Student ID: P467103
    /// Student Name: JACK DU BOULAY
    /// 
    /// Program Explanation ///
    /// This Program showcases how to use a .csv file.
    /// It demonstrates how to open and read a csv file as well as write to one.
    /// The program also shows how to use an unsorted dictionary using key value pairs.
    /// 
    /// Program Keyboard Shortcuts ///
    /// F4          - Clears Value textbox
    /// F5          - Clears Key textbox
    /// Alt + A     - Access Admin GUI Edit Mode (Select an index to use the edit function) <--- IMPORTANT
    /// Alt + A     - Access Admin GUI Add Mode (MUST Type 77 in the key textbox) <--- IMPORTANT
    /// 
    /// </summary>

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            // Set key preview true to allow the key press listener:  https://youtu.be/ogVAU54EQFg?t=360
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            toolStripStatus.Text = "Program launched successfully.";

            LoadCSV();
        }
        // Question 4.1 - Create Dictionary Data Structure that is public and static
        public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();
        
        // Global Variables
        #region Global Variables
        private Form2_Admin form2Admin;         // Create and hold an instance of Form2_Admin
        private string previousPath;            // Get file path of the loaded CSV
        public static bool showdialog = false;  // Checks the duplication of dialog windows 
        #endregion

        // Question 4.2 - Read CSV Data
        private void LoadCSV()
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog(); // Open new Dialog
                dialog.Filter = "CSV | *.csv"; // Filter file types for CSV
                if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK then read csv
                {
                    MasterFile.Clear();
                    previousPath = dialog.FileName; // Collect the previous location
                    using (StreamReader reader = new StreamReader(dialog.FileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine(); // read current line of csv
                            if (line != ",") // The CSV has many ',' at the end of the file - this will ignore that error
                            {
                                var values = line.Split(','); // Split the data into: 
                                int num = int.Parse(values[0]); // Key
                                string name = values[1]; // Value
                                MasterFile.Add(num, name); // Add Key and Value
                            }
                        }
                    }
                }
                DisplayData(); // Display entries
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // An error occured
            }
        }

        // Question 4.3 - Display Data
        public void DisplayData()
        {
            listBox_ReadOnly.Items.Clear();
            foreach (var record in MasterFile) // Go through each dictionary entry
            {
                listBox_ReadOnly.Items.Add(string.Format("{0} {1}", record.Key, record.Value)); // Add each dictionary key into the unselectable listbox
                listBox_Selectable.Items.Add(record.Value); // add each dictionary key balue into the selectable listbox
            }
            Unsubscribe_Text_Change();
            textBox_Search_Key.Clear();
            textBox_Search_Value.Clear();
            Subscribe_Text_Change();
        }

        // Question 4.4 - Textbox Search Value
        /// <summary>
        /// This Method will sift through the entrire dictionary to find any values containing the letters typed into the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Search_Value_TextChanged(object sender, EventArgs e)
        {
            if (label_Selectable.Text != "Selectable List - by Name")
            {
                label_Selectable.Text = "Selectable List - by Name";
            }

            listBox_Selectable.Items.Clear(); // Clear listbox
            string search = textBox_Search_Value.Text; // Get text from textbox

            foreach (var record in MasterFile) // Go through each entry
            {
                if (record.Value.Contains(search, StringComparison.OrdinalIgnoreCase)) // If the record contains any of these letters in that order 
                {
                    listBox_Selectable.Items.Add(record.Value); // Add to the selectable listbox
                }
            }
        }

        // Question 4.5 Textbox Search Key
        /// <summary>
        /// This Method will sift through the entrire dictionary to find any keys containing the numbers typed into the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Search_Key_TextChanged(object sender, EventArgs e)
        {
            // Change label title
            if (label_Selectable.Text != "Selectable List - by Key")
            {
                label_Selectable.Text = "Selectable List - by Key";
            }

            listBox_Selectable.Items.Clear(); // Clear listbox
            string search = textBox_Search_Key.Text; // Get text from textbox

            foreach (var record in MasterFile) // Go through each entry
            {
                if (record.Key.ToString().StartsWith(search)) // If the record contains any of these numbers in that order
                {
                    listBox_Selectable.Items.Add(record.Key); // Add to the selectable listbox
                }
            }
        }

        // Question 4.6 Clear textbox search value for staff names
        private void Clear_TextBox_Search_Value()
        {
            textBox_Search_Value.Clear();
        }

        // Question 4.7 Clear textbox search for staff keys
        private void Clear_TextBox_Search_Key()
        {
            textBox_Search_Key.Clear();
        }

        // Question 4.8 Filter records 
        /// <summary>
        /// This method checks to see if the index has been changed.
        /// When the index has changed it will display the entry's key and value in the specified textboxes
        /// To do this without flagging the TextChanged methods, i need to temporarily disable the method and then reenable them after.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Question 4.8 Filter Records
        private void listBox_Selectable_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change label title
            if (label_Selectable.Text != "Selectable List - by Index")
            {
                label_Selectable.Text = "Selectable List - by Index";
            }
            
            int selectedkey = listBox_Selectable.SelectedIndex;
            string selected = listBox_Selectable.Items[selectedkey].ToString();

            // Search by Key
            if (int.TryParse(selected, out int value))
            {
                Unsubscribe_Text_Change();
                textBox_Search_Key.Text = selected;
                textBox_Search_Value.Text = MasterFile[value];
                Subscribe_Text_Change();
            }
            else
            {
                // Quick way of getting the element at the selected index
                Unsubscribe_Text_Change();
                textBox_Search_Key.Text = MasterFile.ElementAt(selectedkey).Key.ToString();
                textBox_Search_Value.Text = selected;
                Subscribe_Text_Change();
            }
        }

        private void Unsubscribe_Text_Change()
        {
            // Unsubscribe from the TextChanged events
            textBox_Search_Key.TextChanged -= textBox_Search_Key_TextChanged;
            textBox_Search_Value.TextChanged -= textBox_Search_Value_TextChanged;
        }

        private void Subscribe_Text_Change()
        {
            // Re-subscribe to the TextChanged events
            textBox_Search_Key.TextChanged += textBox_Search_Key_TextChanged;
            textBox_Search_Value.TextChanged += textBox_Search_Value_TextChanged;
        }
        #endregion

        // Question 4.9 Switch to Admin GUI
        private void Switch_To_Admin()
        {
            if (form2Admin == null || form2Admin.IsDisposed) // If form2Admin has not been instantiated or has been disposed then check:
            {
                int textKey;
                try
                {
                    textKey = int.Parse(textBox_Search_Key.Text);

                    // If the textkey is exactly 77 then initialize add mode
                    if (textKey == 77 && previousPath != null) // OPEN ADMIN INTERFACE - ADD MODE
                    {
                        toolStripStatus.Text = "Opened Admin Interface - Add Mode";
                        form2Admin = new Form2_Admin(textBox_Search_Key.Text, MasterFile, previousPath);
                        Display_And_Dispose(form2Admin);
                    }
                    // If the Key textbox is not null and the number is a match in the masterfile keys then:
                    else if (MasterFile.Keys.Contains(textKey)) // OPEN ADMIN INTERFACE - EDIT & DELETE MODE
                    {
                        toolStripStatus.Text = "Opened Admin Interface - Edit Mode";

                        form2Admin = new Form2_Admin(textKey, listBox_Selectable.SelectedIndex, MasterFile, previousPath);
                        Display_And_Dispose(form2Admin);
                    }
                    else
                    {
                        toolStripStatus.Text = "Admin Interface Access: Denied - Data required. Please insert data and select an entry.";
                        return;
                    }
                }
                catch (Exception)
                {
                    toolStripStatus.Text = "Admin Interface Access: Denied - Key not valid ";
                }
            }
        }

        private void Display_And_Dispose(Form2_Admin form2Admin)
        {
            form2Admin.ShowDialog(); // Display form2 as a dialog
            form2Admin.Dispose(); // Dispose form2 when done - save nothing
            showdialog = true; // set the global show dialog variable to true 
            Load_Updated_CSV(); // Load the csv after it has been saved from form2
            toolStripStatus.Text = "Closed Admin Interface";
        }

        private void Load_Updated_CSV() // Load it after closing admin GUI
        {
            MasterFile.Clear();
            using (StreamReader reader = new StreamReader(previousPath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine(); // read current line of csv
                    if (line != ",") // The CSV has many ',' at the end of the file - this will ignore that error
                    {
                        var values = line.Split(','); // Split the data into: 
                        int num = int.Parse(values[0]); // Key
                        string name = values[1]; // Value
                        MasterFile.Add(num, name); // Add Key and Value
                    }
                }
            }
            // Display the list of entries in the dictionary
            DisplayData();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Clear staff name textbox (F4)
            if (e.KeyCode == Keys.F4)
            {
                Clear_TextBox_Search_Value();
            }

            // Clear staff id textbox (F5)
            if (e.KeyCode == Keys.F5)
            {
                Clear_TextBox_Search_Key();
            }

            // Switch to Admin GUI (A + ALT) to switch
            if (e.KeyCode == Keys.A && ModifierKeys.HasFlag(Keys.Alt)) // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.modifierkeys?view=windowsdesktop-8.0
            {
                if (!showdialog) // A simple fix to a dumb problem, turns out key down is being triggered twice. im not sure how that is being done but 
                {
                    Switch_To_Admin(); // Switch to the admin gui
                    textBox_Search_Value_TextChanged(sender, e);  // This will update the selectable list so we can see the full list of staff names
                }
                else
                {
                    showdialog = false; // An issue arised where alt+a gets triggered twice. once it has been opened and then closed, another dialog opens - this fixes that issue
                }
            }
        }

        /// <summary>
        /// MENU TOOLBAR SYSTEM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCSV();
            textBox_Search_Value_TextChanged(sender, e);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
