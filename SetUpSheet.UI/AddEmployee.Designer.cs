namespace SetUpSheet.UI
{
    partial class AddEmployee
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
            this.components = new System.ComponentModel.Container();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.IsMinor = new System.Windows.Forms.CheckBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblClockintime = new System.Windows.Forms.Label();
            this.LblClockouttime = new System.Windows.Forms.Label();
            this.Clockintime = new System.Windows.Forms.DateTimePicker();
            this.Clockoutime = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(118, 107);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(29, 107);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // IsMinor
            // 
            this.IsMinor.AutoSize = true;
            this.IsMinor.Location = new System.Drawing.Point(78, 32);
            this.IsMinor.Name = "IsMinor";
            this.IsMinor.Size = new System.Drawing.Size(52, 17);
            this.IsMinor.TabIndex = 5;
            this.IsMinor.Text = "Minor";
            this.IsMinor.UseVisualStyleBackColor = true;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(29, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 6;
            this.LblName.Text = "Name";
            // 
            // LblClockintime
            // 
            this.LblClockintime.AutoSize = true;
            this.LblClockintime.Location = new System.Drawing.Point(29, 58);
            this.LblClockintime.Name = "LblClockintime";
            this.LblClockintime.Size = new System.Drawing.Size(75, 13);
            this.LblClockintime.TabIndex = 7;
            this.LblClockintime.Text = "Clock In Time:";
            // 
            // LblClockouttime
            // 
            this.LblClockouttime.AutoSize = true;
            this.LblClockouttime.Location = new System.Drawing.Point(29, 84);
            this.LblClockouttime.Name = "LblClockouttime";
            this.LblClockouttime.Size = new System.Drawing.Size(83, 13);
            this.LblClockouttime.TabIndex = 10;
            this.LblClockouttime.Text = "Clock Out Time:";
            // 
            // Clockintime
            // 
            this.Clockintime.CustomFormat = "hh:mm tt";
            this.Clockintime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Clockintime.Location = new System.Drawing.Point(110, 52);
            this.Clockintime.Name = "Clockintime";
            this.Clockintime.Size = new System.Drawing.Size(75, 20);
            this.Clockintime.TabIndex = 11;
            // 
            // Clockoutime
            // 
            this.Clockoutime.CustomFormat = "hh:mm tt";
            this.Clockoutime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Clockoutime.Location = new System.Drawing.Point(110, 78);
            this.Clockoutime.Name = "Clockoutime";
            this.Clockoutime.Size = new System.Drawing.Size(75, 20);
            this.Clockoutime.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEmployee
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(219, 143);
            this.ControlBox = false;
            this.Controls.Add(this.Clockoutime);
            this.Controls.Add(this.Clockintime);
            this.Controls.Add(this.LblClockouttime);
            this.Controls.Add(this.LblClockintime);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.IsMinor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblClockintime;
        private System.Windows.Forms.Label LblClockouttime;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.CheckBox IsMinor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.DateTimePicker Clockintime;
        public System.Windows.Forms.DateTimePicker Clockoutime;
    }
}