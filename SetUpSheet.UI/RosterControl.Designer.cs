namespace SetUpSheet.UI
{
    partial class RosterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BreakTime = new System.Windows.Forms.DateTimePicker();
            this.Clockout = new System.Windows.Forms.DateTimePicker();
            this.Clockin = new System.Windows.Forms.DateTimePicker();
            this.txtbreakType = new System.Windows.Forms.TextBox();
            this.ckbIsMinor = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BreakTime
            // 
            this.BreakTime.CustomFormat = "hh:mm tt";
            this.BreakTime.Enabled = false;
            this.BreakTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BreakTime.Location = new System.Drawing.Point(396, 3);
            this.BreakTime.Name = "BreakTime";
            this.BreakTime.Size = new System.Drawing.Size(75, 20);
            this.BreakTime.TabIndex = 118;
            // 
            // Clockout
            // 
            this.Clockout.CustomFormat = "hh:mm tt";
            this.Clockout.Enabled = false;
            this.Clockout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Clockout.Location = new System.Drawing.Point(262, 3);
            this.Clockout.Name = "Clockout";
            this.Clockout.Size = new System.Drawing.Size(75, 20);
            this.Clockout.TabIndex = 117;
            // 
            // Clockin
            // 
            this.Clockin.CustomFormat = "hh:mm tt";
            this.Clockin.Enabled = false;
            this.Clockin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Clockin.Location = new System.Drawing.Point(181, 3);
            this.Clockin.Name = "Clockin";
            this.Clockin.Size = new System.Drawing.Size(75, 20);
            this.Clockin.TabIndex = 116;
            // 
            // txtbreakType
            // 
            this.txtbreakType.Enabled = false;
            this.txtbreakType.Location = new System.Drawing.Point(343, 3);
            this.txtbreakType.Name = "txtbreakType";
            this.txtbreakType.Size = new System.Drawing.Size(47, 20);
            this.txtbreakType.TabIndex = 115;
            // 
            // ckbIsMinor
            // 
            this.ckbIsMinor.AutoSize = true;
            this.ckbIsMinor.Enabled = false;
            this.ckbIsMinor.Location = new System.Drawing.Point(113, 5);
            this.ckbIsMinor.Name = "ckbIsMinor";
            this.ckbIsMinor.Size = new System.Drawing.Size(62, 17);
            this.ckbIsMinor.TabIndex = 114;
            this.ckbIsMinor.Text = "Is minor";
            this.ckbIsMinor.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(3, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(104, 20);
            this.txtName.TabIndex = 113;
            // 
            // RosterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BreakTime);
            this.Controls.Add(this.Clockout);
            this.Controls.Add(this.Clockin);
            this.Controls.Add(this.txtbreakType);
            this.Controls.Add(this.ckbIsMinor);
            this.Controls.Add(this.txtName);
            this.Name = "RosterControl";
            this.Size = new System.Drawing.Size(477, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker BreakTime;
        public System.Windows.Forms.DateTimePicker Clockout;
        public System.Windows.Forms.DateTimePicker Clockin;
        private System.Windows.Forms.TextBox txtbreakType;
        private System.Windows.Forms.CheckBox ckbIsMinor;
        private System.Windows.Forms.TextBox txtName;
    }
}
