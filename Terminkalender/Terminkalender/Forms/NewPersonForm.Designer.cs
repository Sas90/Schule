namespace Terminkalender.Forms
{
    partial class NewPersonForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbFirstname = new System.Windows.Forms.TextBox();
            this.TbLastname = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TbTown = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbPostCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbNr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbStreet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nachname";
            // 
            // TbFirstname
            // 
            this.TbFirstname.Location = new System.Drawing.Point(87, 6);
            this.TbFirstname.Name = "TbFirstname";
            this.TbFirstname.Size = new System.Drawing.Size(185, 20);
            this.TbFirstname.TabIndex = 0;
            // 
            // TbLastname
            // 
            this.TbLastname.Location = new System.Drawing.Point(87, 32);
            this.TbLastname.Name = "TbLastname";
            this.TbLastname.Size = new System.Drawing.Size(185, 20);
            this.TbLastname.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(116, 162);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(197, 162);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Abbrechen";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TbTown
            // 
            this.TbTown.Location = new System.Drawing.Point(87, 136);
            this.TbTown.Name = "TbTown";
            this.TbTown.Size = new System.Drawing.Size(185, 20);
            this.TbTown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stadt";
            // 
            // TbPostCode
            // 
            this.TbPostCode.Location = new System.Drawing.Point(87, 110);
            this.TbPostCode.Name = "TbPostCode";
            this.TbPostCode.Size = new System.Drawing.Size(185, 20);
            this.TbPostCode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "PLZ";
            // 
            // TbNr
            // 
            this.TbNr.Location = new System.Drawing.Point(87, 84);
            this.TbNr.Name = "TbNr";
            this.TbNr.Size = new System.Drawing.Size(185, 20);
            this.TbNr.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hausnummer";
            // 
            // TbStreet
            // 
            this.TbStreet.Location = new System.Drawing.Point(87, 58);
            this.TbStreet.Name = "TbStreet";
            this.TbStreet.Size = new System.Drawing.Size(185, 20);
            this.TbStreet.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Straße";
            // 
            // NewPersonForm
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.TbStreet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbNr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbPostCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbTown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TbLastname);
            this.Controls.Add(this.TbFirstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 232);
            this.MinimumSize = new System.Drawing.Size(300, 232);
            this.Name = "NewPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neue Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbFirstname;
        private System.Windows.Forms.TextBox TbLastname;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TbTown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbPostCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbNr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbStreet;
        private System.Windows.Forms.Label label6;
    }
}