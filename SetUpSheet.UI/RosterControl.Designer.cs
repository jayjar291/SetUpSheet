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
            this.incator1 = new System.Windows.Forms.Button();
            this.incator2 = new System.Windows.Forms.Button();
            this.incator3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BreakTime
            // 
            this.BreakTime.CustomFormat = "hh:mm tt";
            this.BreakTime.Enabled = false;
            this.BreakTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BreakTime.Location = new System.Drawing.Point(476, 3);
            this.BreakTime.Name = "BreakTime";
            this.BreakTime.Size = new System.Drawing.Size(75, 20);
            this.BreakTime.TabIndex = 118;
            this.BreakTime.ValueChanged += new System.EventHandler(this.BreakTime_ValueChanged);
            // 
            // Clockout
            // 
            this.Clockout.CustomFormat = "hh:mm tt";
            this.Clockout.Enabled = false;
            this.Clockout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Clockout.Location = new System.Drawing.Point(302, 3);
            this.Clockout.Name = "Clockout";
            this.Clockout.Size = new System.Drawing.Size(75, 20);
            this.Clockout.TabIndex = 117;
            this.Clockout.ValueChanged += new System.EventHandler(this.Clockout_ValueChanged);
            // 
            // Clockin
            // 
            this.Clockin.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clockin.CustomFormat = "hh:mm tt";
            this.Clockin.Enabled = false;
            this.Clockin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Clockin.Location = new System.Drawing.Point(201, 3);
            this.Clockin.Name = "Clockin";
            this.Clockin.Size = new System.Drawing.Size(75, 20);
            this.Clockin.TabIndex = 116;
            this.Clockin.ValueChanged += new System.EventHandler(this.Clockin_ValueChanged);
            // 
            // txtbreakType
            // 
            this.txtbreakType.Enabled = false;
            this.txtbreakType.Location = new System.Drawing.Point(383, 3);
            this.txtbreakType.Name = "txtbreakType";
            this.txtbreakType.Size = new System.Drawing.Size(67, 20);
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
            this.ckbIsMinor.CheckedChanged += new System.EventHandler(this.ckbIsMinor_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(3, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(104, 20);
            this.txtName.TabIndex = 113;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // incator1
            // 
            this.incator1.BackColor = System.Drawing.SystemColors.Control;
            this.incator1.FlatAppearance.BorderSize = 0;
            this.incator1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incator1.Location = new System.Drawing.Point(181, 6);
            this.incator1.Name = "incator1";
            this.incator1.Size = new System.Drawing.Size(14, 13);
            this.incator1.TabIndex = 122;
            this.incator1.UseVisualStyleBackColor = false;
            // 
            // incator2
            // 
            this.incator2.BackColor = System.Drawing.SystemColors.Control;
            this.incator2.FlatAppearance.BorderSize = 0;
            this.incator2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incator2.Location = new System.Drawing.Point(282, 6);
            this.incator2.Name = "incator2";
            this.incator2.Size = new System.Drawing.Size(14, 13);
            this.incator2.TabIndex = 123;
            this.incator2.UseVisualStyleBackColor = false;
            // 
            // incator3
            // 
            this.incator3.BackColor = System.Drawing.SystemColors.Control;
            this.incator3.FlatAppearance.BorderSize = 0;
            this.incator3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incator3.Location = new System.Drawing.Point(456, 6);
            this.incator3.Name = "incator3";
            this.incator3.Size = new System.Drawing.Size(14, 13);
            this.incator3.TabIndex = 124;
            this.incator3.UseVisualStyleBackColor = false;
            // 
            // RosterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.incator3);
            this.Controls.Add(this.incator2);
            this.Controls.Add(this.incator1);
            this.Controls.Add(this.BreakTime);
            this.Controls.Add(this.Clockout);
            this.Controls.Add(this.Clockin);
            this.Controls.Add(this.txtbreakType);
            this.Controls.Add(this.ckbIsMinor);
            this.Controls.Add(this.txtName);
            this.Name = "RosterControl";
            this.Size = new System.Drawing.Size(568, 27);
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
        private System.Windows.Forms.Button incator1;
        private System.Windows.Forms.Button incator2;
        private System.Windows.Forms.Button incator3;
    }
}
