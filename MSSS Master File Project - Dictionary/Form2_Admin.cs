using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MSSS_Master_File_Project___Dictionary
{
    public partial class Form2_Admin : Form
    {
        public static Dictionary<int, string> masterFile;
        private int selectedkey;
        private int selectedIndex;
        private readonly string previousPath;

        // Constructor 1 - Edit & Delete Mode
        public Form2_Admin(int Key, int index, Dictionary<int, string> MasterFile, string PreviousPath)
        {
            InitializeComponent();

            // add new KeyEventHandler
            this.KeyDown += new KeyEventHandler(Form2_Admin_KeyDown);

            // Assign the passed values to the global variables
            selectedkey = Key;
            selectedIndex = index;
            masterFile = MasterFile;
            previousPath = PreviousPath;

            // Hide buttons
            button_Add.Hide();

            // Display methods
            DisplaySelectedIndex(); // Display selected entry from general interface
            DisplayData();          // display data from passed dictionary

            toolStripStatus.Text = "Admin Interface successfully opened. - (EDIT MODE ACTIVE)";
        }

        // Constructor 2 - Add mode
        public Form2_Admin(string newKey, Dictionary<int, string> MasterFile, string PreviousPath)
        {
            InitializeComponent();

            // add new KeyEventHandler
            this.KeyDown += new KeyEventHandler(Form2_Admin_KeyDown);

            // Hide buttons
            button_remove.Hide();
            button_Edit.Hide();

            textBox_Search_Key.ReadOnly = false; // remove the read only of the textbox

            // Assign the passed values to the global variables
            textBox_Search_Key.Text = newKey;
            masterFile = MasterFile;
            previousPath = PreviousPath;

            DisplayData(); // display data from passed dictionary

            toolStripStatus.Text = "Admin Interface successfully opened. - (ADD MODE ACTIVE).";
        }

        #region Quesiton 5.2 - Display Methods
        // Question 5.2 - Display the selected index for Constructor 1 and then display all the data in the related textboxes
        private void DisplaySelectedIndex()
        {
            textBox_Search_Key.Text = selectedkey.ToString();
            textBox_Search_Value.Text = masterFile[selectedkey];
        }

        private void DisplayData()
        {
            listBox_ReadOnly.Items.Clear();
            foreach (var record in masterFile) // Go through each dictionary entry
            {
                listBox_ReadOnly.Items.Add(string.Format("{0} {1}", record.Key, record.Value)); // Add each dictionary key into the unselectable listbox
            }
            Display_Staff_Names();
        }
        private void Display_Staff_Names()
        {
            listBox_Selectable.Items.Clear();
            foreach (var record in masterFile) // Go through each dictionary entry
            {
                listBox_Selectable.Items.Add(record.Value); // Add to the selectable listbox
            }
        }

        // Display the selected entries upon index changing
        private void listBox_Selectable_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = listBox_Selectable.SelectedIndex;
            selectedkey = masterFile.ElementAt(selectedIndex).Key; // this onec       
            string selected = listBox_Selectable.Items[selectedIndex].ToString();

            // Quick way of getting the element at the selected index
            textBox_Search_Key.Text = masterFile.ElementAt(selectedIndex).Key.ToString();
            textBox_Search_Value.Text = selected;
        }
        #endregion

        // Question 5.3 Create new entry to Dictionary
        private void button_Add_Click(object sender, EventArgs e)
        {
            string sVal = textBox_Search_Value.Text;
            string sKey = textBox_Search_Key.Text;
            try
            {
                // Valid Key and value
                // Check first 2 chars of the string for 77, then check the key length then check if the value is not empty.
                if (sKey.StartsWith("77") && sKey.Length == 9 && !string.IsNullOrEmpty(sVal))
                {
                    if (int.TryParse(sKey, out int key))
                    {
                        if (!masterFile.Keys.Contains(key))
                        {
                            masterFile.Add(key, sVal);
                            toolStripStatus.Text = $"Entry added: Key = {key}, Value = {sVal}";
                            DisplayData();

                            // Wipe text boxes
                            textBox_Search_Key.Text = "77";
                            textBox_Search_Value.Clear();
                        }
                        // Cannot add key if key is already present
                        else
                        {
                            toolStripStatus.Text = $"Cannot add entry: Key {key} is already taken.";
                        }
                    }
                    else // couldnt parse
                    {
                        toolStripStatus.Text = $"Cannot add entry: Key {sKey} is not a valid number.";
                    }
                }
                else
                {   // Needs to start with 77
                    if (!sKey.StartsWith("77"))
                    {
                        toolStripStatus.Text = $"Cannot add entry: Key {sKey} does not start with '77'.";
                    }
                    // Must be 9 digits
                    else if (sKey.Length != 9)
                    {
                        toolStripStatus.Text = $"Cannot add entry: Key {sKey} is not 9 digits long.";
                    }
                    // the value cannot be null
                    else if (string.IsNullOrEmpty(sVal))
                    {
                        toolStripStatus.Text = $"Cannot add entry: Value is empty.";
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripStatus.Text = $"{ex}";
            }
        }

        #region Question 5.4 - Edit entry in dictionary
        // Question 5.4 - Edit entry in dictionary
        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Search_Value.Text))
            {
                // Insert the new change into the dictionary
                masterFile[int.Parse(textBox_Search_Key.Text)] = textBox_Search_Value.Text;


                // Update both list boxes with the new name
                listBox_ReadOnly.Items[selectedIndex] = $"{masterFile.ElementAt(selectedIndex).Key.ToString()} {textBox_Search_Value.Text}";

                Unsubscribe_Index_Change();  // Unsub to not conflict with the selected index changed
                listBox_Selectable.Items[selectedIndex] = textBox_Search_Value.Text;
                Subscribe_Index_Change(); // resub so it can be used again.

                toolStripStatus.Text = $"Edited entry successfully: Key: {textBox_Search_Key.Text} Value: {textBox_Search_Value.Text}.";
            }
            else
            {
                toolStripStatus.Text = $"Cannot edit entry: Value is empty.";
            }
        }
        private void Unsubscribe_Index_Change()
        {
            listBox_Selectable.SelectedIndexChanged -= listBox_Selectable_SelectedIndexChanged;
        }

        private void Subscribe_Index_Change()
        {
            listBox_Selectable.SelectedIndexChanged += listBox_Selectable_SelectedIndexChanged;
        }
        #endregion

        // Question 5.5 - Remove entry from dictionary
        private void button_remove_Click(object sender, EventArgs e)
        {
            if (masterFile.ContainsKey(selectedkey))
            {
                masterFile.Remove(selectedkey);

                // Remove selected item from both lists
                Unsubscribe_Index_Change();
                listBox_ReadOnly.Items.RemoveAt(selectedIndex);
                listBox_Selectable.Items.RemoveAt(selectedIndex);
                Subscribe_Index_Change();

                // clear textboxes
                textBox_Search_Key.Clear();
                textBox_Search_Value.Clear();
            }
        }

        // Question 5.6 - Save to CSV file.
        private void button_Save_Close_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Would you like to overwrite the currently opened file?\n" +
                "By pressing No you can save to a new file", "Overwrite Opened File", MessageBoxButtons.YesNoCancel);
            switch (dr) // Check results
            {
                case DialogResult.Yes: // Overwrite opened file
                    if (previousPath == null)
                    {
                        toolStripStatus.Text = "No CSV file was opened";
                        return;
                    }
                    try
                    {
                        Save_To_File(previousPath);
                        DialogResult _ = MessageBox.Show("File has been saved.\nFile will Automatically Load in General UI", "Alert", MessageBoxButtons.OK);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        toolStripStatus.Text = $"{ex}";
                        return;
                    }
                    break;
                    
                case DialogResult.No:
                    // Create new csv file
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "CSV files|*.csv";
                        saveFileDialog.Title = "Save Data File";
                        saveFileDialog.DefaultExt = "csv";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                Save_To_File(saveFileDialog.FileName);
                                DialogResult _ = MessageBox.Show("File has been saved.\nPlease open file in the General UI", "Alert", MessageBoxButtons.OK);
                                this.Close();// Close program
                            }
                            catch (Exception ex)
                            {
                                toolStripStatus.Text = $"{ex}";
                                return;
                            }
                        }
                        else
                        {
                            toolStripStatus.Text = "User chose not to save file.";
                            return;
                        }
                    }
                    break;

                case DialogResult.Cancel:
                    return;
            }
        }

        private void Save_To_File(string fileName)
        {
            using (StreamWriter txtwriter = new StreamWriter(fileName))
            {
                foreach (var entry in masterFile)
                {
                    string key = entry.Key.ToString();
                    string value = entry.Value;
                    string line = string.Format("{0},{1}", key, value);

                    txtwriter.WriteLine(line);
                }
                txtwriter.Close();
            }
        }

       // Question 5.7 - Close Admin GUI with keyboard shortcut
        private void Form2_Admin_KeyDown(object sender, KeyEventArgs e)  // Key down check - listens for key shortcuts
        {
            // Switch to General GUI - (ALT + L)
            if (e.KeyCode == Keys.L && ModifierKeys.HasFlag(Keys.Alt)) // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.modifierkeys?view=windowsdesktop-8.0
            {
                button_Save_Close_Click(sender, e);
            }
        }

    }
}
