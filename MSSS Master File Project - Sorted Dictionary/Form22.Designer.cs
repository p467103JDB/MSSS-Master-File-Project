namespace MSSS_Master_File_Project___Sorted_Dictionary
{
    partial class Form22
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            toolStripStatus = new ToolStripStatusLabel();
            listBox_Selectable = new ListBox();
            listBox_ReadOnly = new ListBox();
            label2 = new Label();
            label1 = new Label();
            button_remove = new Button();
            textBox_Search_Key = new TextBox();
            textBox_Search_Value = new TextBox();
            label_Selectable = new Label();
            label3 = new Label();
            button_Add = new Button();
            button_Edit = new Button();
            button_Save_Close = new Button();
            toolTip1 = new ToolTip(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatus });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 25;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            toolStripStatus.Name = "toolStripStatus";
            toolStripStatus.Size = new Size(0, 17);
            // 
            // listBox_Selectable
            // 
            listBox_Selectable.FormattingEnabled = true;
            listBox_Selectable.ItemHeight = 15;
            listBox_Selectable.Location = new Point(256, 44);
            listBox_Selectable.Name = "listBox_Selectable";
            listBox_Selectable.Size = new Size(178, 349);
            listBox_Selectable.TabIndex = 24;
            listBox_Selectable.SelectedIndexChanged += listBox_Selectable_SelectedIndexChanged;
            // 
            // listBox_ReadOnly
            // 
            listBox_ReadOnly.FormattingEnabled = true;
            listBox_ReadOnly.ItemHeight = 15;
            listBox_ReadOnly.Location = new Point(32, 44);
            listBox_ReadOnly.Name = "listBox_ReadOnly";
            listBox_ReadOnly.SelectionMode = SelectionMode.None;
            listBox_ReadOnly.Size = new Size(178, 349);
            listBox_ReadOnly.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 140);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 22;
            label2.Text = "Staff ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 86);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 21;
            label1.Text = "Staff Name:";
            // 
            // button_remove
            // 
            button_remove.Location = new Point(440, 216);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(84, 23);
            button_remove.TabIndex = 20;
            button_remove.Text = "Remove";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // textBox_Search_Key
            // 
            textBox_Search_Key.Location = new Point(440, 158);
            textBox_Search_Key.MaxLength = 9;
            textBox_Search_Key.Name = "textBox_Search_Key";
            textBox_Search_Key.ReadOnly = true;
            textBox_Search_Key.Size = new Size(197, 23);
            textBox_Search_Key.TabIndex = 19;
            // 
            // textBox_Search_Value
            // 
            textBox_Search_Value.Location = new Point(440, 104);
            textBox_Search_Value.Name = "textBox_Search_Value";
            textBox_Search_Value.Size = new Size(197, 23);
            textBox_Search_Value.TabIndex = 18;
            // 
            // label_Selectable
            // 
            label_Selectable.AutoSize = true;
            label_Selectable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Selectable.Location = new Point(256, 24);
            label_Selectable.Name = "label_Selectable";
            label_Selectable.Size = new Size(96, 17);
            label_Selectable.TabIndex = 30;
            label_Selectable.Text = "Selectable List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 24);
            label3.Name = "label3";
            label3.Size = new Size(121, 17);
            label3.TabIndex = 29;
            label3.Text = "Full list - readonly";
            // 
            // button_Add
            // 
            button_Add.Location = new Point(440, 187);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(84, 23);
            button_Add.TabIndex = 28;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(440, 187);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(84, 23);
            button_Edit.TabIndex = 27;
            button_Edit.Text = "Edit";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // button_Save_Close
            // 
            button_Save_Close.Location = new Point(440, 370);
            button_Save_Close.Name = "button_Save_Close";
            button_Save_Close.Size = new Size(84, 23);
            button_Save_Close.TabIndex = 26;
            button_Save_Close.Text = "Save and Exit";
            toolTip1.SetToolTip(button_Save_Close, "Press ALT + L to save and exit");
            button_Save_Close.UseVisualStyleBackColor = true;
            button_Save_Close.Click += button_Save_Close_Click;
            // 
            // Form22
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(statusStrip1);
            Controls.Add(listBox_Selectable);
            Controls.Add(listBox_ReadOnly);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_remove);
            Controls.Add(textBox_Search_Key);
            Controls.Add(textBox_Search_Value);
            Controls.Add(label_Selectable);
            Controls.Add(label3);
            Controls.Add(button_Add);
            Controls.Add(button_Edit);
            Controls.Add(button_Save_Close);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "Form22";
            Text = "Form22";
            KeyDown += Form2_Admin_KeyDown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatus;
        private ListBox listBox_Selectable;
        private ListBox listBox_ReadOnly;
        private Label label2;
        private Label label1;
        private Button button_remove;
        private TextBox textBox_Search_Key;
        private TextBox textBox_Search_Value;
        private Label label_Selectable;
        private Label label3;
        private Button button_Add;
        private Button button_Edit;
        private Button button_Save_Close;
        private ToolTip toolTip1;
    }
}