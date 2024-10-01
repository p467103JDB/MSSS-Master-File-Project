namespace MSSS_Master_File_Project___Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCSV();
        }
        // Question 4.1 - Create Dictionary Data Structure
        Dictionary<int, string> MasterFile = new Dictionary<int, string>();

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
                    foreach (string path in dialog.FileNames)
                    {
                        using (StreamReader reader = new StreamReader(path))
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
                }
                DisplayData(listBox_ReadOnly); // Display entries
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // An error occured
            }

        }

        // Question 4.3 - Display Data
        private void DisplayData(ListBox list)
        {
            foreach (var record in MasterFile) // Go through each dictionary entry
            {
                list.Items.Add(string.Format("{0} {1}", record.Key, record.Value)); // Add each dictionary key into the unselectable listbox
            }
        }

        // Question 4.4 - Textbox Search Value
        /// <summary>
        /// This Method will sift through the entrire dictionary to find any values containing the letters typed into the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Search_Value_TextChanged(object sender, EventArgs e)
        {
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
            listBox_Selectable.Items.Clear(); // Clear listbox
            string search = textBox_Search_Key.Text; // Get text from textbox

            foreach (var record in MasterFile) // Go through each entry
            {
                if (record.Key.ToString().Contains(search)) // If the record contains any of these numbers in that order
                {
                    listBox_Selectable.Items.Add(record.Key); // Add to the selectable listbox
                }
            }
        }
    }
}
