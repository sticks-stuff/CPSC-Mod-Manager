namespace CPSC_Mod_Manager
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModNameBox = new System.Windows.Forms.TextBox();
            this.ModAuthorBox = new System.Windows.Forms.TextBox();
            this.ModDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModVersionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 9);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(306, 208);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mod version:";
            // 
            // ModNameBox
            // 
            this.ModNameBox.Enabled = false;
            this.ModNameBox.Location = new System.Drawing.Point(72, 231);
            this.ModNameBox.Name = "ModNameBox";
            this.ModNameBox.Size = new System.Drawing.Size(198, 22);
            this.ModNameBox.TabIndex = 4;
            this.ModNameBox.TextChanged += new System.EventHandler(this.ModNameBox_TextChanged);
            // 
            // ModAuthorBox
            // 
            this.ModAuthorBox.Enabled = false;
            this.ModAuthorBox.Location = new System.Drawing.Point(72, 259);
            this.ModAuthorBox.Name = "ModAuthorBox";
            this.ModAuthorBox.Size = new System.Drawing.Size(198, 22);
            this.ModAuthorBox.TabIndex = 5;
            this.ModAuthorBox.TextChanged += new System.EventHandler(this.ModAuthorBox_TextChanged);
            // 
            // ModDescriptionBox
            // 
            this.ModDescriptionBox.Enabled = false;
            this.ModDescriptionBox.Location = new System.Drawing.Point(12, 344);
            this.ModDescriptionBox.Name = "ModDescriptionBox";
            this.ModDescriptionBox.Size = new System.Drawing.Size(306, 98);
            this.ModDescriptionBox.TabIndex = 7;
            this.ModDescriptionBox.Text = "";
            this.ModDescriptionBox.TextChanged += new System.EventHandler(this.ModDescriptionBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mod description:";
            // 
            // ModVersionBox
            // 
            this.ModVersionBox.Enabled = false;
            this.ModVersionBox.Location = new System.Drawing.Point(107, 290);
            this.ModVersionBox.Name = "ModVersionBox";
            this.ModVersionBox.Size = new System.Drawing.Size(163, 22);
            this.ModVersionBox.TabIndex = 9;
            this.ModVersionBox.TextChanged += new System.EventHandler(this.ModVersionBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 454);
            this.Controls.Add(this.ModVersionBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModDescriptionBox);
            this.Controls.Add(this.ModAuthorBox);
            this.Controls.Add(this.ModNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CPSC Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModNameBox;
        private System.Windows.Forms.TextBox ModAuthorBox;
        private System.Windows.Forms.RichTextBox ModDescriptionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ModVersionBox;
    }
}

