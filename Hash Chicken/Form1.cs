using System.Management.Automation;

namespace Hash_Chicken
/*Hash Chicken File Hasher
    Copyright (C) 2025-Present  chicken5610

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.*/
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the file path from the TextBox
            string filePath = txtFilePath.Text;

            // Validate the file path (make sure it exists)
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Please select a valid file first.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Run the PowerShell script with the file path as an argument
            string result = RunPowerShellScript("Get-FileHash", filePath);
            textBox1.Text = result;
        }

        // Method to run a PowerShell command with the file path as input
        private string RunPowerShellScript(string script, string filePath)
        {
            try
            {
                // Create a PowerShell instance
                using (PowerShell ps = PowerShell.Create())
                {
                    // Add the PowerShell script to execute with the file path
                    ps.AddScript($"{script} -Path \"{filePath}\"");

                    // Execute the script and capture the result
                    var result = ps.Invoke();

                    // If there is output, Need to process 
                    if (result.Count > 0)
                    {
                        // Extract the Hash value from the result (which is a FileHashInfo object)
                        var fileHashInfo = result[0];  // Get the first object returned (should be a FileHashInfo)
                        string hash = fileHashInfo.Properties["Hash"].Value.ToString();  // Extract the Hash property

                        return hash;  // Return the hash string
                    }
                    else
                    {
                        return "No output returned from PowerShell.";
                    }
                }
            }
            catch (Exception ex)
            {
                // If there is an error, return the exception message
                return $"Error: {ex.Message}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open a File Dialog to select a file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Show the file dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the file path to the TextBox
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //strings to compare
            string string1 = textBox1.Text;
            string string2 = UserHash.Text;
            if (string.Equals(string1, string2, StringComparison.OrdinalIgnoreCase))
            {
               MessageBox.Show("The Hashes Match!", "Hash Chicken Comparer", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("The Hashes Do Not Match!", "Hash Chicken Comparer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}