namespace Terminkalender.Forms
{
    partial class NewLocationForm
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
            this.TbName = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TbStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbPostcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbTown = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(69, 12);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(203, 20);
            this.TbName.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(116, 142);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Hinzufügen";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(197, 142);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Abbrechen";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TbStreet
            // 
            this.TbStreet.Location = new System.Drawing.Point(69, 38);
            this.TbStreet.Name = "TbStreet";
            this.TbStreet.Size = new System.Drawing.Size(203, 20);
            this.TbStreet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Straße";
            // 
            // TbNumber
            // 
            this.TbNumber.Location = new System.Drawing.Point(69, 64);
            this.TbNumber.Name = "TbNumber";
            this.TbNumber.Size = new System.Drawing.Size(203, 20);
            this.TbNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hausnr.";
            // 
            // TbPostcode
            // 
            this.TbPostcode.Location = new System.Drawing.Point(69, 90);
            this.TbPostcode.Name = "TbPostcode";
            this.TbPostcode.Size = new System.Drawing.Size(203, 20);
            this.TbPostcode.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PLZ";
            // 
            // TbTown
            // 
            this.TbTown.Location = new System.Drawing.Point(69, 116);
            this.TbTown.Name = "TbTown";
            this.TbTown.Size = new System.Drawing.Size(203, 20);
            this.TbTown.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stadt";
            // 
            // NewLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.TbTown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbPostcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbStreet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label1);
            this.Name = "NewLocationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neuer Ort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TbStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbPostcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbTown;
        private System.Windows.Forms.Label label5;
    }
}