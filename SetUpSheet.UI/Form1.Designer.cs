namespace SetUpSheet.UI
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
            this.label9 = new System.Windows.Forms.Label();
            this.pnlLunch = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bntLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBreaks = new System.Windows.Forms.Button();
            this.pnlTransition = new System.Windows.Forms.Panel();
            this.lblTransition = new System.Windows.Forms.Label();
            this.lblNameL = new System.Windows.Forms.Label();
            this.lblClockInL = new System.Windows.Forms.Label();
            this.lblBreakL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlLunch.SuspendLayout();
            this.pnlTransition.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(540, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 31);
            this.label9.TabIndex = 131;
            this.label9.Text = "Lunch:";
            // 
            // pnlLunch
            // 
            this.pnlLunch.AutoScroll = true;
            this.pnlLunch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLunch.Controls.Add(this.lblBreakL);
            this.pnlLunch.Controls.Add(this.lblClockInL);
            this.pnlLunch.Controls.Add(this.lblNameL);
            this.pnlLunch.Location = new System.Drawing.Point(546, 41);
            this.pnlLunch.Name = "pnlLunch";
            this.pnlLunch.Size = new System.Drawing.Size(500, 293);
            this.pnlLunch.TabIndex = 129;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "Break:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Shift:   Start:         End:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Time:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bntLoad
            // 
            this.bntLoad.Location = new System.Drawing.Point(452, 142);
            this.bntLoad.Name = "bntLoad";
            this.bntLoad.Size = new System.Drawing.Size(75, 23);
            this.bntLoad.TabIndex = 132;
            this.bntLoad.Text = "Load";
            this.bntLoad.UseVisualStyleBackColor = true;
            this.bntLoad.Click += new System.EventHandler(this.bntLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(452, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 133;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBreaks
            // 
            this.btnBreaks.Location = new System.Drawing.Point(451, 201);
            this.btnBreaks.Name = "btnBreaks";
            this.btnBreaks.Size = new System.Drawing.Size(75, 23);
            this.btnBreaks.TabIndex = 134;
            this.btnBreaks.Text = "Auto Breaks";
            this.btnBreaks.UseVisualStyleBackColor = true;
            this.btnBreaks.Click += new System.EventHandler(this.btnBreaks_Click);
            // 
            // pnlTransition
            // 
            this.pnlTransition.AutoScroll = true;
            this.pnlTransition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTransition.Controls.Add(this.label8);
            this.pnlTransition.Controls.Add(this.label10);
            this.pnlTransition.Controls.Add(this.label11);
            this.pnlTransition.Location = new System.Drawing.Point(546, 371);
            this.pnlTransition.Name = "pnlTransition";
            this.pnlTransition.Size = new System.Drawing.Size(500, 197);
            this.pnlTransition.TabIndex = 130;
            // 
            // lblTransition
            // 
            this.lblTransition.AutoSize = true;
            this.lblTransition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransition.Location = new System.Drawing.Point(540, 337);
            this.lblTransition.Name = "lblTransition";
            this.lblTransition.Size = new System.Drawing.Size(142, 31);
            this.lblTransition.TabIndex = 135;
            this.lblTransition.Text = "Transition:";
            // 
            // lblNameL
            // 
            this.lblNameL.AutoSize = true;
            this.lblNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameL.Location = new System.Drawing.Point(3, 0);
            this.lblNameL.Name = "lblNameL";
            this.lblNameL.Size = new System.Drawing.Size(57, 18);
            this.lblNameL.TabIndex = 1;
            this.lblNameL.Text = "Name:";
            // 
            // lblClockInL
            // 
            this.lblClockInL.AutoSize = true;
            this.lblClockInL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockInL.Location = new System.Drawing.Point(185, 0);
            this.lblClockInL.Name = "lblClockInL";
            this.lblClockInL.Size = new System.Drawing.Size(149, 18);
            this.lblClockInL.TabIndex = 2;
            this.lblClockInL.Text = "Clock in/Out Time:";
            // 
            // lblBreakL
            // 
            this.lblBreakL.AutoSize = true;
            this.lblBreakL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakL.Location = new System.Drawing.Point(348, 0);
            this.lblBreakL.Name = "lblBreakL";
            this.lblBreakL.Size = new System.Drawing.Size(114, 18);
            this.lblBreakL.TabIndex = 3;
            this.lblBreakL.Text = "Break:   Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(348, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Break:   Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(185, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Clock in/Out Time:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 580);
            this.Controls.Add(this.lblTransition);
            this.Controls.Add(this.pnlTransition);
            this.Controls.Add(this.btnBreaks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bntLoad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnlLunch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlLunch.ResumeLayout(false);
            this.pnlLunch.PerformLayout();
            this.pnlTransition.ResumeLayout(false);
            this.pnlTransition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlLunch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bntLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBreaks;
        private System.Windows.Forms.Panel pnlTransition;
        private System.Windows.Forms.Label lblTransition;
        private System.Windows.Forms.Label lblBreakL;
        private System.Windows.Forms.Label lblClockInL;
        private System.Windows.Forms.Label lblNameL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

