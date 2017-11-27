namespace WinForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lab_id = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_section = new System.Windows.Forms.TextBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_section = new System.Windows.Forms.Label();
            this.lab_Address = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_id
            // 
            this.lab_id.AutoSize = true;
            this.lab_id.Location = new System.Drawing.Point(8, 8);
            this.lab_id.Name = "lab_id";
            this.lab_id.Size = new System.Drawing.Size(16, 13);
            this.lab_id.TabIndex = 1;
            this.lab_id.Text = "Id";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(81, 12);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 20);
            this.text_id.TabIndex = 2;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(81, 38);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 20);
            this.text_name.TabIndex = 3;
            // 
            // text_section
            // 
            this.text_section.Location = new System.Drawing.Point(81, 66);
            this.text_section.Name = "text_section";
            this.text_section.Size = new System.Drawing.Size(100, 20);
            this.text_section.TabIndex = 4;
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(81, 100);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(100, 20);
            this.text_address.TabIndex = 5;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(8, 38);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(35, 13);
            this.lab_Name.TabIndex = 6;
            this.lab_Name.Text = "Name";
            // 
            // lab_section
            // 
            this.lab_section.AutoSize = true;
            this.lab_section.Location = new System.Drawing.Point(12, 66);
            this.lab_section.Name = "lab_section";
            this.lab_section.Size = new System.Drawing.Size(43, 13);
            this.lab_section.TabIndex = 7;
            this.lab_section.Text = "Section";
            // 
            // lab_Address
            // 
            this.lab_Address.AutoSize = true;
            this.lab_Address.Location = new System.Drawing.Point(8, 103);
            this.lab_Address.Name = "lab_Address";
            this.lab_Address.Size = new System.Drawing.Size(45, 13);
            this.lab_Address.TabIndex = 8;
            this.lab_Address.Text = "Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lab_Address);
            this.Controls.Add(this.lab_section);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.text_address);
            this.Controls.Add(this.text_section);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.lab_id);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab_id;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_section;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_section;
        private System.Windows.Forms.Label lab_Address;
    }
}

