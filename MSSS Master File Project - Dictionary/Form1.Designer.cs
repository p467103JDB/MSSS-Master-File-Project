namespace MSSS_Master_File_Project___Dictionary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox_ReadOnly = new ListBox();
            listBox_Selectable = new ListBox();
            textBox_Search_Value = new TextBox();
            textBox_Search_Key = new TextBox();
            SuspendLayout();
            // 
            // listBox_ReadOnly
            // 
            listBox_ReadOnly.FormattingEnabled = true;
            listBox_ReadOnly.ItemHeight = 15;
            listBox_ReadOnly.Location = new Point(32, 128);
            listBox_ReadOnly.Name = "listBox_ReadOnly";
            listBox_ReadOnly.SelectionMode = SelectionMode.None;
            listBox_ReadOnly.Size = new Size(178, 289);
            listBox_ReadOnly.TabIndex = 0;
            // 
            // listBox_Selectable
            // 
            listBox_Selectable.FormattingEnabled = true;
            listBox_Selectable.ItemHeight = 15;
            listBox_Selectable.Location = new Point(256, 128);
            listBox_Selectable.Name = "listBox_Selectable";
            listBox_Selectable.SelectionMode = SelectionMode.None;
            listBox_Selectable.Size = new Size(178, 289);
            listBox_Selectable.TabIndex = 1;
            // 
            // textBox_Search_Value
            // 
            textBox_Search_Value.Location = new Point(440, 128);
            textBox_Search_Value.Name = "textBox_Search_Value";
            textBox_Search_Value.Size = new Size(197, 23);
            textBox_Search_Value.TabIndex = 2;
            textBox_Search_Value.TextChanged += textBox_Search_Value_TextChanged;
            // 
            // textBox_Search_Key
            // 
            textBox_Search_Key.Location = new Point(440, 182);
            textBox_Search_Key.Name = "textBox_Search_Key";
            textBox_Search_Key.Size = new Size(197, 23);
            textBox_Search_Key.TabIndex = 3;
            textBox_Search_Key.TextChanged += textBox_Search_Key_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_Search_Key);
            Controls.Add(textBox_Search_Value);
            Controls.Add(listBox_Selectable);
            Controls.Add(listBox_ReadOnly);
            Name = "Form1";
            Text = "MSSS - General UI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_ReadOnly;
        private ListBox listBox_Selectable;
        private TextBox textBox_Search_Value;
        private TextBox textBox_Search_Key;
    }
}
