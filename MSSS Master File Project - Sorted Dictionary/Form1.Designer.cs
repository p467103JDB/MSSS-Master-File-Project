namespace MSSS_Master_File_Project___Sorted_Dictionary
{
    partial class Form1
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
            listBox_Selectable = new ListBox();
            listBox_ReadOnly = new ListBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatus = new ToolStripStatusLabel();
            label2 = new Label();
            label1 = new Label();
            label_Selectable = new Label();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Search_Key
            // 
            textBox_Search_Key.Location = new Point(440, 182);
            textBox_Search_Key.Name = "textBox_Search_Key";
            textBox_Search_Key.Size = new Size(197, 23);
            textBox_Search_Key.TabIndex = 13;
            toolTip1.SetToolTip(textBox_Search_Key, "Press F5 to clear textbox");
            textBox_Search_Key.TextChanged += textBox_Search_Key_TextChanged;
            // 
            // textBox_Search_Value
            // 
            textBox_Search_Value.Location = new Point(440, 128);
            textBox_Search_Value.Name = "textBox_Search_Value";
            textBox_Search_Value.Size = new Size(197, 23);
            textBox_Search_Value.TabIndex = 12;
            toolTip1.SetToolTip(textBox_Search_Value, "Press F4 to clear textbox");
            textBox_Search_Value.TextChanged += textBox_Search_Value_TextChanged;
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(122, 22);
            openFileToolStripMenuItem.Text = "Open file";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(122, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatus });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 17;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            toolStripStatus.Name = "toolStripStatus";
            toolStripStatus.Size = new Size(0, 17);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 164);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 16;
            label2.Text = "Search staff by ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 110);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 15;
            label1.Text = "Search staff by name:";
            // 
            // label_Selectable
            // 
            label_Selectable.AutoSize = true;
            label_Selectable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Selectable.Location = new Point(256, 48);
            label_Selectable.Name = "label_Selectable";
            label_Selectable.Size = new Size(105, 17);
            label_Selectable.TabIndex = 19;
            label_Selectable.Text = "Selectable List -";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 48);
            label3.Name = "label3";
            label3.Size = new Size(121, 17);
            label3.TabIndex = 18;
            label3.Text = "Full list - readonly";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_Search_Key);
            Controls.Add(textBox_Search_Value);
            Controls.Add(listBox_Selectable);
            Controls.Add(listBox_ReadOnly);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_Selectable);
            Controls.Add(label3);
            KeyPreview = true;
            Name = "Form12";
            Text = "Form12";
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Search_Key;
        private ToolTip toolTip1;
        private TextBox textBox_Search_Value;
        private ListBox listBox_Selectable;
        private ListBox listBox_ReadOnly;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatus;
        private Label label2;
        private Label label1;
        private Label label_Selectable;
        private Label label3;
    }
}