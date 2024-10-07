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
        private string previousPath;

        // Constructor 1 - Edit & Delete Mode
        public Form2_Admin(int Key, Dictionary<int, string> MasterFile, string PreviousPath)
        {
            InitializeComponent();

            // add new KeyEventHandler
            this.KeyDown += new KeyEventHandler(Form2_Admin_KeyDown);

            // Assign the passed values to the global variables
            selectedkey = Key;
            masterFile = MasterFile;
            previousPath = PreviousPath;

            // Hide buttons
            button_Add.Hide();

            // Display methods
            DisplaySelectedIndex(); // Display selected entry from general interface
            DisplayData(); // display data from passed dictionary
            Display_Staff_Names(); // display the names

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
            textBox_Search_Key.Text = newKey; // set 77 to be the text
            masterFile = MasterFile;
            previousPath = PreviousPath;

            DisplayData(); // display data from passed dictionary

            toolStripStatus.Text = "Admin Interface successfully opened. - (ADD MODE ACTIVE).";
        }

        private void DisplaySelectedIndex()
        {
            textBox_Search_Key.Text = selectedkey.ToString();
            textBox_Search_Value.Text = masterFile[selectedkey];
        }

        private void Display_Staff_Names()
        {
            listBox_Selectable.Items.Clear();
            foreach (var record in masterFile) // Go through each entry
            {
                    listBox_Selectable.Items.Add(record.Value); // Add to the selectable listbox
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (masterFile.ContainsKey(selectedkey))
            {
                masterFile.Remove(selectedkey);
                DisplayData();
                Display_Staff_Names();

                // clear textboxes
                textBox_Search_Key.Clear();
                textBox_Search_Value.Clear();
            }
        }

        private void listBox_Selectable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = listBox_Selectable.SelectedItem.ToString();
            int selectedIndex = listBox_Selectable.SelectedIndex;

            int value;
            // Search by Key
            if (int.TryParse(selected, out value))
            {
                textBox_Search_Key.Text = selected;
                textBox_Search_Value.Text = masterFile[value];
            }
            else // Search by Value
            {
                // Find the amount of duplicates in the selectable listbox
                int duplicates = CountDuplicates(selected, selectedIndex);

                // Iterate through the masterfile entries to find the correct staff name to key pair.
                int duplicatesChecker = 0;
                foreach (var record in masterFile)
                {
                    // If the record value matches the selected entry's string  then check to see if the duplicate amount has been matched
                    // Otherwise iterate through the masterfle list until it has.
                    if (record.Value == selected)
                    {
                        if (duplicates == duplicatesChecker)
                        {
                            textBox_Search_Key.Text = record.Key.ToString();
                            textBox_Search_Value.Text = selected;
                            break; // find the match and GTFO
                        }
                        duplicatesChecker++;
                    }
                }
            }
        }

        private int CountDuplicates(string selected, int selectedIndex)
        {
            int duplicates = 0;
            for (int i = 0; i < selectedIndex; i++)
            {
                if (listBox_Selectable.Items[i].ToString() == selected)
                {
                    duplicates++;
                }
            }
            return duplicates;
        }

        private void button_Save_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void DisplayData()
        {
            listBox_ReadOnly.Items.Clear();
            foreach (var record in masterFile) // Go through each dictionary entry
            {
                listBox_ReadOnly.Items.Add(string.Format("{0} {1}", record.Key, record.Value)); // Add each dictionary key into the unselectable listbox
            }
        }

        private void Form2_Admin_KeyDown(object sender, KeyEventArgs e)
        {
            // Switch to General GUI - (ALT + L)
            if (e.KeyCode == Keys.L && ModifierKeys.HasFlag(Keys.Alt)) // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.modifierkeys?view=windowsdesktop-8.0
            {
                button_Save_Close_Click(sender, e);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Search_Value.Text))
            {
                masterFile[int.Parse(textBox_Search_Key.Text)] = textBox_Search_Value.Text;
                DisplayData();
                Display_Staff_Names();
                toolStripStatus.Text = $"Edited entry successfully: Key: {textBox_Search_Key.Text} Value: {textBox_Search_Value.Text}.";
            }
            else
            {
                toolStripStatus.Text = $"Cannot edit entry: Value is empty.";
            }
        }
    }
}
