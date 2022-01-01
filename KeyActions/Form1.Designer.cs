namespace KeyActions
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chbControl = new System.Windows.Forms.CheckBox();
            this.chbAlt = new System.Windows.Forms.CheckBox();
            this.chbShift = new System.Windows.Forms.CheckBox();
            this.cbKeys = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbShortcut = new System.Windows.Forms.TextBox();
            this.cbListen = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbListenLink = new System.Windows.Forms.CheckBox();
            this.tbShortcutLinked = new System.Windows.Forms.TextBox();
            this.chbWin = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(493, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(295, 411);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // chbControl
            // 
            this.chbControl.AutoSize = true;
            this.chbControl.Location = new System.Drawing.Point(6, 19);
            this.chbControl.Name = "chbControl";
            this.chbControl.Size = new System.Drawing.Size(41, 17);
            this.chbControl.TabIndex = 4;
            this.chbControl.Text = "Ctrl";
            this.chbControl.UseVisualStyleBackColor = true;
            this.chbControl.CheckedChanged += new System.EventHandler(this.cbWin_CheckedChanged);
            // 
            // chbAlt
            // 
            this.chbAlt.AutoSize = true;
            this.chbAlt.Location = new System.Drawing.Point(6, 42);
            this.chbAlt.Name = "chbAlt";
            this.chbAlt.Size = new System.Drawing.Size(38, 17);
            this.chbAlt.TabIndex = 4;
            this.chbAlt.Text = "Alt";
            this.chbAlt.UseVisualStyleBackColor = true;
            this.chbAlt.CheckedChanged += new System.EventHandler(this.cbWin_CheckedChanged);
            // 
            // chbShift
            // 
            this.chbShift.AutoSize = true;
            this.chbShift.Location = new System.Drawing.Point(6, 65);
            this.chbShift.Name = "chbShift";
            this.chbShift.Size = new System.Drawing.Size(47, 17);
            this.chbShift.TabIndex = 4;
            this.chbShift.Text = "Shift";
            this.chbShift.UseVisualStyleBackColor = true;
            this.chbShift.CheckedChanged += new System.EventHandler(this.cbWin_CheckedChanged);
            // 
            // cbKeys
            // 
            this.cbKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeys.FormattingEnabled = true;
            this.cbKeys.Location = new System.Drawing.Point(6, 111);
            this.cbKeys.Name = "cbKeys";
            this.cbKeys.Size = new System.Drawing.Size(121, 21);
            this.cbKeys.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbControl);
            this.groupBox1.Controls.Add(this.chbAlt);
            this.groupBox1.Controls.Add(this.cbKeys);
            this.groupBox1.Controls.Add(this.chbWin);
            this.groupBox1.Controls.Add(this.chbShift);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configure";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbListen);
            this.groupBox2.Controls.Add(this.tbShortcut);
            this.groupBox2.Location = new System.Drawing.Point(155, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 143);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type in";
            // 
            // tbShortcut
            // 
            this.tbShortcut.BackColor = System.Drawing.Color.White;
            this.tbShortcut.Enabled = false;
            this.tbShortcut.Location = new System.Drawing.Point(6, 19);
            this.tbShortcut.Name = "tbShortcut";
            this.tbShortcut.Size = new System.Drawing.Size(125, 20);
            this.tbShortcut.TabIndex = 0;
            // 
            // cbListen
            // 
            this.cbListen.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbListen.Location = new System.Drawing.Point(6, 45);
            this.cbListen.Name = "cbListen";
            this.cbListen.Size = new System.Drawing.Size(125, 23);
            this.cbListen.TabIndex = 1;
            this.cbListen.Text = "Click to listen";
            this.cbListen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbListen.UseVisualStyleBackColor = true;
            this.cbListen.CheckedChanged += new System.EventHandler(this.cbListen_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cbType);
            this.groupBox3.Location = new System.Drawing.Point(12, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 136);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Linked to :";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(6, 19);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbListenLink);
            this.groupBox4.Controls.Add(this.tbShortcutLinked);
            this.groupBox4.Location = new System.Drawing.Point(6, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(137, 80);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Type in";
            // 
            // cbListenLink
            // 
            this.cbListenLink.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbListenLink.Location = new System.Drawing.Point(6, 45);
            this.cbListenLink.Name = "cbListenLink";
            this.cbListenLink.Size = new System.Drawing.Size(125, 23);
            this.cbListenLink.TabIndex = 1;
            this.cbListenLink.Text = "Click to listen";
            this.cbListenLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbListenLink.UseVisualStyleBackColor = true;
            this.cbListenLink.CheckedChanged += new System.EventHandler(this.cbListenLink_CheckedChanged);
            // 
            // tbShortcutLinked
            // 
            this.tbShortcutLinked.BackColor = System.Drawing.Color.White;
            this.tbShortcutLinked.Enabled = false;
            this.tbShortcutLinked.Location = new System.Drawing.Point(6, 19);
            this.tbShortcutLinked.Name = "tbShortcutLinked";
            this.tbShortcutLinked.Size = new System.Drawing.Size(125, 20);
            this.tbShortcutLinked.TabIndex = 0;
            // 
            // chbWin
            // 
            this.chbWin.AutoSize = true;
            this.chbWin.Location = new System.Drawing.Point(6, 88);
            this.chbWin.Name = "chbWin";
            this.chbWin.Size = new System.Drawing.Size(45, 17);
            this.chbWin.TabIndex = 4;
            this.chbWin.Text = "Win";
            this.chbWin.UseVisualStyleBackColor = true;
            this.chbWin.CheckedChanged += new System.EventHandler(this.cbWin_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.CheckBox chbControl;
        private System.Windows.Forms.CheckBox chbAlt;
        private System.Windows.Forms.CheckBox chbShift;
        private System.Windows.Forms.ComboBox cbKeys;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbShortcut;
        private System.Windows.Forms.CheckBox cbListen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbListenLink;
        private System.Windows.Forms.TextBox tbShortcutLinked;
        private System.Windows.Forms.CheckBox chbWin;
        private System.Windows.Forms.Button btnAdd;
    }
}

