namespace MSSS_Master_File_Project___Dictionary
{
    partial class Form2_Admin
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
            textBox_Search_Key = new TextBox();
            textBox_Search_Value = new TextBox();
            button_remove = new Button();
            label2 = new Label();
            label1 = new Label();
            listBox_Selectable = new ListBox();
            listBox_ReadOnly = new ListBox();
            statusStrip1 = new StatusStrip();
            toolStripStatus = new ToolStripStatusLabel();
            button_Save_Close = new Button();
            button_Edit = new Button();
            button_Add = new Button();
            label_Selectable = new Label();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Search_Key
            // 
            textBox_Search_Key.Location = new Point(440, 182);
            textBox_Search_Key.MaxLength = 9;
            textBox_Search_Key.Name = "textBox_Search_Key";
            textBox_Search_Key.ReadOnly = true;
            textBox_Search_Key.Size = new Size(197, 23);
            textBox_Search_Key.TabIndex = 5;
            // 
            // textBox_Search_Value
            // 
            textBox_Search_Value.Location = new Point(440, 128);
            textBox_Search_Value.Name = "textBox_Search_Value";
            textBox_Search_Value.Size = new Size(197, 23);
            textBox_Search_Value.TabIndex = 4;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(440, 240);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(84, 23);
            button_remove.TabIndex = 7;
            button_remove.Text = "Remove";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 164);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 9;
            label2.Text = "Staff ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 110);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 8;
            label1.Text = "Staff Name:";
            // 
            // listBox_Selectable
            // 
            listBox_Selectable.FormattingEnabled = true;
            listBox_Selectable.ItemHeight = 15;
            listBox_Selectable.Location = new Point(256, 68);
            listBox_Selectable.Name = "listBox_Selectable";
            listBox_Selectable.Size = new Size(178, 349);
            listBox_Selectable.TabIndex = 11;
            listBox_Selectable.SelectedIndexChanged += listBox_Selectable_SelectedIndexChanged;
            // 
            // listBox_ReadOnly
            // 
            listBox_ReadOnly.FormattingEnabled = true;
            listBox_ReadOnly.ItemHeight = 15;
            listBox_ReadOnly.Location = new Point(32, 68);
            listBox_ReadOnly.Name = "listBox_ReadOnly";
            listBox_ReadOnly.SelectionMode = SelectionMode.None;
            listBox_ReadOnly.Size = new Size(178, 349);
            listBox_ReadOnly.TabIndex = 10;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatus });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            toolStripStatus.Name = "toolStripStatus";
            toolStripStatus.Size = new Size(0, 17);
            // 
            // button_Save_Close
            // 
            button_Save_Close.Location = new Point(440, 394);
            button_Save_Close.Name = "button_Save_Close";
            button_Save_Close.Size = new Size(84, 23);
            button_Save_Close.TabIndex = 13;
            button_Save_Close.Text = "Save and Exit";
            toolTip1.SetToolTip(button_Save_Close, "Press ALT + L to save and exit");
            button_Save_Close.UseVisualStyleBackColor = true;
            button_Save_Close.Click += button_Save_Close_Click;
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(440, 211);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(84, 23);
            button_Edit.TabIndex = 14;
            button_Edit.Text = "Edit";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(440, 211);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(84, 23);
            button_Add.TabIndex = 15;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // label_Selectable
            // 
            label_Selectable.AutoSize = true;
            label_Selectable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Selectable.Location = new Point(256, 48);
            label_Selectable.Name = "label_Selectable";
            label_Selectable.Size = new Size(96, 17);
            label_Selectable.TabIndex = 17;
            label_Selectable.Text = "Selectable List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 48);
            label3.Name = "label3";
            label3.Size = new Size(121, 17);
            label3.TabIndex = 16;
            label3.Text = "Full list - readonly";
            // 
            // Form2_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label_Selectable);
            Controls.Add(label3);
            Controls.Add(button_Add);
            Controls.Add(button_Edit);
            Controls.Add(button_Save_Close);
            Controls.Add(statusStrip1);
            Controls.Add(listBox_Selectable);
            Controls.Add(listBox_ReadOnly);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_remove);
            Controls.Add(textBox_Search_Key);
            Controls.Add(textBox_Search_Value);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "Form2_Admin";
            RightToLeft = RightToLeft.No;
            Text = "MSSS - Admin GUI";
            KeyDown += Form2_Admin_KeyDown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Search_Key;
        private TextBox textBox_Search_Value;
        private Button button_remove;
        private Label label2;
        private Label label1;
        private ListBox listBox_Selectable;
        private ListBox listBox_ReadOnly;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatus;
        private Button button_Save_Close;
        private Button button_Edit;
        private Button button_Add;
        private Label label_Selectable;
        private Label label3;
        private ToolTip toolTip1;
    }
}