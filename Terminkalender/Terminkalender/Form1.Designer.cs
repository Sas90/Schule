namespace Terminkalender
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OlvAppointments = new BrightIdeasSoftware.ObjectListView();
            this.OlvcAppointmentDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OlvcPerson = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OlvcLocation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OlvcDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.BtnAddAppointment = new System.Windows.Forms.Button();
            this.BtnDeleteAppointment = new System.Windows.Forms.Button();
            this.TcMain = new System.Windows.Forms.TabControl();
            this.TpAppointments = new System.Windows.Forms.TabPage();
            this.BtnSortAppointments = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmiSortByDescription = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSortByPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSortByLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSortByDate = new System.Windows.Forms.ToolStripMenuItem();
            this.TpPersons = new System.Windows.Forms.TabPage();
            this.BtnSortPersons = new System.Windows.Forms.Button();
            this.TbFilterPerson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OlvPersons = new BrightIdeasSoftware.ObjectListView();
            this.OlvcLastname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OlvcFirstname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OlvcPersonStreet = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OlvcPersonNr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OlvcPersonPostcode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OlvcPersonTown = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.BtnDeletePerson = new System.Windows.Forms.Button();
            this.BtnNewPerson = new System.Windows.Forms.Button();
            this.TpLocations = new System.Windows.Forms.TabPage();
            this.BtnSortLocations = new System.Windows.Forms.Button();
            this.OlvLocations = new BrightIdeasSoftware.ObjectListView();
            this.OlvcName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OlvcStreet = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OlvcNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OlvcPostCode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OlvcTown = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.BtnDeleteLocation = new System.Windows.Forms.Button();
            this.BtnNewLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OlvAppointments)).BeginInit();
            this.TcMain.SuspendLayout();
            this.TpAppointments.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.TpPersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OlvPersons)).BeginInit();
            this.TpLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OlvLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // OlvAppointments
            // 
            this.OlvAppointments.AllColumns.Add(this.OlvcAppointmentDescription);
            this.OlvAppointments.AllColumns.Add(this.OlvcPerson);
            this.OlvAppointments.AllColumns.Add(this.OlvcLocation);
            this.OlvAppointments.AllColumns.Add(this.OlvcDate);
            this.OlvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OlvAppointments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OlvcAppointmentDescription,
            this.OlvcPerson,
            this.OlvcLocation,
            this.OlvcDate});
            this.OlvAppointments.EmptyListMsg = "Keine Termine vorhanden";
            this.OlvAppointments.FullRowSelect = true;
            this.OlvAppointments.Location = new System.Drawing.Point(6, 6);
            this.OlvAppointments.Name = "OlvAppointments";
            this.OlvAppointments.ShowGroups = false;
            this.OlvAppointments.Size = new System.Drawing.Size(499, 275);
            this.OlvAppointments.TabIndex = 0;
            this.OlvAppointments.UseCompatibleStateImageBehavior = false;
            this.OlvAppointments.View = System.Windows.Forms.View.Details;
            // 
            // OlvcAppointmentDescription
            // 
            this.OlvcAppointmentDescription.CellPadding = null;
            this.OlvcAppointmentDescription.Text = "Beschreibung";
            // 
            // OlvcPerson
            // 
            this.OlvcPerson.CellPadding = null;
            this.OlvcPerson.Text = "Person";
            // 
            // OlvcLocation
            // 
            this.OlvcLocation.CellPadding = null;
            this.OlvcLocation.Text = "Ort";
            // 
            // OlvcDate
            // 
            this.OlvcDate.CellPadding = null;
            this.OlvcDate.Text = "Datum";
            // 
            // BtnAddAppointment
            // 
            this.BtnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddAppointment.Location = new System.Drawing.Point(511, 229);
            this.BtnAddAppointment.Name = "BtnAddAppointment";
            this.BtnAddAppointment.Size = new System.Drawing.Size(111, 23);
            this.BtnAddAppointment.TabIndex = 2;
            this.BtnAddAppointment.Text = "Neuer Termin";
            this.BtnAddAppointment.UseVisualStyleBackColor = true;
            this.BtnAddAppointment.Click += new System.EventHandler(this.BtnAddAppointment_Click);
            // 
            // BtnDeleteAppointment
            // 
            this.BtnDeleteAppointment.Location = new System.Drawing.Point(511, 258);
            this.BtnDeleteAppointment.Name = "BtnDeleteAppointment";
            this.BtnDeleteAppointment.Size = new System.Drawing.Size(111, 23);
            this.BtnDeleteAppointment.TabIndex = 3;
            this.BtnDeleteAppointment.Text = "Termin löschen";
            this.BtnDeleteAppointment.UseVisualStyleBackColor = true;
            this.BtnDeleteAppointment.Click += new System.EventHandler(this.BtnDeleteAppointment_Click);
            // 
            // TcMain
            // 
            this.TcMain.Controls.Add(this.TpAppointments);
            this.TcMain.Controls.Add(this.TpPersons);
            this.TcMain.Controls.Add(this.TpLocations);
            this.TcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcMain.Location = new System.Drawing.Point(0, 0);
            this.TcMain.Name = "TcMain";
            this.TcMain.SelectedIndex = 0;
            this.TcMain.Size = new System.Drawing.Size(636, 313);
            this.TcMain.TabIndex = 4;
            // 
            // TpAppointments
            // 
            this.TpAppointments.Controls.Add(this.BtnSortAppointments);
            this.TpAppointments.Controls.Add(this.OlvAppointments);
            this.TpAppointments.Controls.Add(this.BtnDeleteAppointment);
            this.TpAppointments.Controls.Add(this.BtnAddAppointment);
            this.TpAppointments.Location = new System.Drawing.Point(4, 22);
            this.TpAppointments.Name = "TpAppointments";
            this.TpAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.TpAppointments.Size = new System.Drawing.Size(628, 287);
            this.TpAppointments.TabIndex = 0;
            this.TpAppointments.Text = "Termine";
            this.TpAppointments.UseVisualStyleBackColor = true;
            // 
            // BtnSortAppointments
            // 
            this.BtnSortAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.BtnSortAppointments.Location = new System.Drawing.Point(511, 200);
            this.BtnSortAppointments.Name = "BtnSortAppointments";
            this.BtnSortAppointments.Size = new System.Drawing.Size(109, 23);
            this.BtnSortAppointments.TabIndex = 10;
            this.BtnSortAppointments.Text = "Sortiere";
            this.BtnSortAppointments.UseVisualStyleBackColor = true;
            this.BtnSortAppointments.Click += new System.EventHandler(this.BtnSortAppointments_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiSortByDescription,
            this.TsmiSortByPerson,
            this.TsmiSortByLocation,
            this.TsmiSortByDate});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 92);
            // 
            // TsmiSortByDescription
            // 
            this.TsmiSortByDescription.Name = "TsmiSortByDescription";
            this.TsmiSortByDescription.Size = new System.Drawing.Size(226, 22);
            this.TsmiSortByDescription.Text = "Nach Beschreibung sortieren";
            this.TsmiSortByDescription.Click += new System.EventHandler(this.TsmiSortByDescription_Click);
            // 
            // TsmiSortByPerson
            // 
            this.TsmiSortByPerson.Name = "TsmiSortByPerson";
            this.TsmiSortByPerson.Size = new System.Drawing.Size(226, 22);
            this.TsmiSortByPerson.Text = "Nach Personen sortieren";
            this.TsmiSortByPerson.Click += new System.EventHandler(this.TsmiSortByPerson_Click);
            // 
            // TsmiSortByLocation
            // 
            this.TsmiSortByLocation.Name = "TsmiSortByLocation";
            this.TsmiSortByLocation.Size = new System.Drawing.Size(226, 22);
            this.TsmiSortByLocation.Text = "Nach Ort sortieren";
            this.TsmiSortByLocation.Click += new System.EventHandler(this.TsmiSortByLocation_Click);
            // 
            // TsmiSortByDate
            // 
            this.TsmiSortByDate.Name = "TsmiSortByDate";
            this.TsmiSortByDate.Size = new System.Drawing.Size(226, 22);
            this.TsmiSortByDate.Text = "Nach Datum sortieren";
            this.TsmiSortByDate.Click += new System.EventHandler(this.TsmiSortByDate_Click);
            // 
            // TpPersons
            // 
            this.TpPersons.Controls.Add(this.BtnSortPersons);
            this.TpPersons.Controls.Add(this.TbFilterPerson);
            this.TpPersons.Controls.Add(this.label1);
            this.TpPersons.Controls.Add(this.OlvPersons);
            this.TpPersons.Controls.Add(this.BtnDeletePerson);
            this.TpPersons.Controls.Add(this.BtnNewPerson);
            this.TpPersons.Location = new System.Drawing.Point(4, 22);
            this.TpPersons.Name = "TpPersons";
            this.TpPersons.Padding = new System.Windows.Forms.Padding(3);
            this.TpPersons.Size = new System.Drawing.Size(628, 287);
            this.TpPersons.TabIndex = 1;
            this.TpPersons.Text = "Personen";
            this.TpPersons.UseVisualStyleBackColor = true;
            // 
            // BtnSortPersons
            // 
            this.BtnSortPersons.Location = new System.Drawing.Point(511, 200);
            this.BtnSortPersons.Name = "BtnSortPersons";
            this.BtnSortPersons.Size = new System.Drawing.Size(109, 23);
            this.BtnSortPersons.TabIndex = 9;
            this.BtnSortPersons.Text = "Sortiere";
            this.BtnSortPersons.UseVisualStyleBackColor = true;
            this.BtnSortPersons.Click += new System.EventHandler(this.BtnSortPersons_Click);
            // 
            // TbFilterPerson
            // 
            this.TbFilterPerson.Location = new System.Drawing.Point(122, 6);
            this.TbFilterPerson.Name = "TbFilterPerson";
            this.TbFilterPerson.Size = new System.Drawing.Size(383, 20);
            this.TbFilterPerson.TabIndex = 8;
            this.TbFilterPerson.TextChanged += new System.EventHandler(this.TbFilterPerson_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Textfilter (Nachname)";
            // 
            // OlvPersons
            // 
            this.OlvPersons.AllColumns.Add(this.OlvcLastname);
            this.OlvPersons.AllColumns.Add(this.OlvcFirstname);
            this.OlvPersons.AllColumns.Add(this.OlvcPersonStreet);
            this.OlvPersons.AllColumns.Add(this.OlvcPersonNr);
            this.OlvPersons.AllColumns.Add(this.OlvcPersonPostcode);
            this.OlvPersons.AllColumns.Add(this.OlvcPersonTown);
            this.OlvPersons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OlvPersons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OlvcLastname,
            this.OlvcFirstname,
            this.OlvcPersonStreet,
            this.OlvcPersonNr,
            this.OlvcPersonPostcode,
            this.OlvcPersonTown});
            this.OlvPersons.EmptyListMsg = "Keine Personen vorhanden";
            this.OlvPersons.FullRowSelect = true;
            this.OlvPersons.Location = new System.Drawing.Point(6, 32);
            this.OlvPersons.MultiSelect = false;
            this.OlvPersons.Name = "OlvPersons";
            this.OlvPersons.ShowGroups = false;
            this.OlvPersons.Size = new System.Drawing.Size(499, 249);
            this.OlvPersons.TabIndex = 4;
            this.OlvPersons.UseCompatibleStateImageBehavior = false;
            this.OlvPersons.UseFiltering = true;
            this.OlvPersons.View = System.Windows.Forms.View.Details;
            // 
            // OlvcLastname
            // 
            this.OlvcLastname.CellPadding = null;
            this.OlvcLastname.Text = "Nachname";
            // 
            // OlvcFirstname
            // 
            this.OlvcFirstname.CellPadding = null;
            this.OlvcFirstname.Text = "Vorname";
            // 
            // OlvcPersonStreet
            // 
            this.OlvcPersonStreet.CellPadding = null;
            this.OlvcPersonStreet.Text = "Straße";
            // 
            // OlvcPersonNr
            // 
            this.OlvcPersonNr.CellPadding = null;
            this.OlvcPersonNr.Text = "Nr";
            // 
            // OlvcPersonPostcode
            // 
            this.OlvcPersonPostcode.CellPadding = null;
            this.OlvcPersonPostcode.Text = "PLZ";
            // 
            // OlvcPersonTown
            // 
            this.OlvcPersonTown.CellPadding = null;
            this.OlvcPersonTown.Text = "Stadt";
            // 
            // BtnDeletePerson
            // 
            this.BtnDeletePerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeletePerson.Location = new System.Drawing.Point(511, 258);
            this.BtnDeletePerson.Name = "BtnDeletePerson";
            this.BtnDeletePerson.Size = new System.Drawing.Size(111, 23);
            this.BtnDeletePerson.TabIndex = 6;
            this.BtnDeletePerson.Text = "Person löschen";
            this.BtnDeletePerson.UseVisualStyleBackColor = true;
            this.BtnDeletePerson.Click += new System.EventHandler(this.BtnDeletePerson_Click);
            // 
            // BtnNewPerson
            // 
            this.BtnNewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewPerson.Location = new System.Drawing.Point(511, 229);
            this.BtnNewPerson.Name = "BtnNewPerson";
            this.BtnNewPerson.Size = new System.Drawing.Size(111, 23);
            this.BtnNewPerson.TabIndex = 5;
            this.BtnNewPerson.Text = "Neue Person";
            this.BtnNewPerson.UseVisualStyleBackColor = true;
            this.BtnNewPerson.Click += new System.EventHandler(this.BtnNewPerson_Click);
            // 
            // TpLocations
            // 
            this.TpLocations.Controls.Add(this.BtnSortLocations);
            this.TpLocations.Controls.Add(this.OlvLocations);
            this.TpLocations.Controls.Add(this.BtnDeleteLocation);
            this.TpLocations.Controls.Add(this.BtnNewLocation);
            this.TpLocations.Location = new System.Drawing.Point(4, 22);
            this.TpLocations.Name = "TpLocations";
            this.TpLocations.Padding = new System.Windows.Forms.Padding(3);
            this.TpLocations.Size = new System.Drawing.Size(628, 287);
            this.TpLocations.TabIndex = 2;
            this.TpLocations.Text = "Orte";
            this.TpLocations.UseVisualStyleBackColor = true;
            // 
            // BtnSortLocations
            // 
            this.BtnSortLocations.Location = new System.Drawing.Point(511, 200);
            this.BtnSortLocations.Name = "BtnSortLocations";
            this.BtnSortLocations.Size = new System.Drawing.Size(109, 23);
            this.BtnSortLocations.TabIndex = 10;
            this.BtnSortLocations.Text = "Sortiere";
            this.BtnSortLocations.UseVisualStyleBackColor = true;
            this.BtnSortLocations.Click += new System.EventHandler(this.BtnSortLocations_Click);
            // 
            // OlvLocations
            // 
            this.OlvLocations.AllColumns.Add(this.OlvcName);
            this.OlvLocations.AllColumns.Add(this.OlvcStreet);
            this.OlvLocations.AllColumns.Add(this.OlvcNumber);
            this.OlvLocations.AllColumns.Add(this.OlvcPostCode);
            this.OlvLocations.AllColumns.Add(this.OlvcTown);
            this.OlvLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OlvLocations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OlvcName,
            this.OlvcStreet,
            this.OlvcNumber,
            this.OlvcPostCode,
            this.OlvcTown});
            this.OlvLocations.EmptyListMsg = "Keine Orte vorhanden";
            this.OlvLocations.FullRowSelect = true;
            this.OlvLocations.Location = new System.Drawing.Point(6, 6);
            this.OlvLocations.Name = "OlvLocations";
            this.OlvLocations.ShowGroups = false;
            this.OlvLocations.Size = new System.Drawing.Size(499, 275);
            this.OlvLocations.TabIndex = 4;
            this.OlvLocations.UseCompatibleStateImageBehavior = false;
            this.OlvLocations.View = System.Windows.Forms.View.Details;
            // 
            // OlvcName
            // 
            this.OlvcName.CellPadding = null;
            this.OlvcName.Text = "Name";
            // 
            // OlvcStreet
            // 
            this.OlvcStreet.CellPadding = null;
            this.OlvcStreet.Text = "Straße";
            // 
            // OlvcNumber
            // 
            this.OlvcNumber.CellPadding = null;
            this.OlvcNumber.Text = "Hausnr.";
            // 
            // OlvcPostCode
            // 
            this.OlvcPostCode.CellPadding = null;
            this.OlvcPostCode.Text = "PLZ";
            // 
            // OlvcTown
            // 
            this.OlvcTown.CellPadding = null;
            this.OlvcTown.Text = "Stadt";
            // 
            // BtnDeleteLocation
            // 
            this.BtnDeleteLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteLocation.Location = new System.Drawing.Point(511, 258);
            this.BtnDeleteLocation.Name = "BtnDeleteLocation";
            this.BtnDeleteLocation.Size = new System.Drawing.Size(111, 23);
            this.BtnDeleteLocation.TabIndex = 6;
            this.BtnDeleteLocation.Text = "Ort löschen";
            this.BtnDeleteLocation.UseVisualStyleBackColor = true;
            this.BtnDeleteLocation.Click += new System.EventHandler(this.BtnDeleteLocation_Click);
            // 
            // BtnNewLocation
            // 
            this.BtnNewLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewLocation.Location = new System.Drawing.Point(511, 229);
            this.BtnNewLocation.Name = "BtnNewLocation";
            this.BtnNewLocation.Size = new System.Drawing.Size(111, 23);
            this.BtnNewLocation.TabIndex = 5;
            this.BtnNewLocation.Text = "Neuer Ort";
            this.BtnNewLocation.UseVisualStyleBackColor = true;
            this.BtnNewLocation.Click += new System.EventHandler(this.BtnNewLocation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 313);
            this.Controls.Add(this.TcMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminkalender";
            ((System.ComponentModel.ISupportInitialize)(this.OlvAppointments)).EndInit();
            this.TcMain.ResumeLayout(false);
            this.TpAppointments.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.TpPersons.ResumeLayout(false);
            this.TpPersons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OlvPersons)).EndInit();
            this.TpLocations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OlvLocations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView OlvAppointments;
        private System.Windows.Forms.Button BtnAddAppointment;
        private System.Windows.Forms.Button BtnDeleteAppointment;
        private System.Windows.Forms.TabControl TcMain;
        private System.Windows.Forms.TabPage TpAppointments;
        private System.Windows.Forms.TabPage TpPersons;
        private BrightIdeasSoftware.ObjectListView OlvPersons;
        private System.Windows.Forms.Button BtnDeletePerson;
        private System.Windows.Forms.Button BtnNewPerson;
        private System.Windows.Forms.TabPage TpLocations;
        private BrightIdeasSoftware.ObjectListView OlvLocations;
        private System.Windows.Forms.Button BtnDeleteLocation;
        private System.Windows.Forms.Button BtnNewLocation;
        private BrightIdeasSoftware.OLVColumn OlvcPerson;
        private BrightIdeasSoftware.OLVColumn OlvcLocation;
        private BrightIdeasSoftware.OLVColumn OlvcDate;
        private BrightIdeasSoftware.OLVColumn OlvcLastname;
        private BrightIdeasSoftware.OLVColumn OlvcFirstname;
        private BrightIdeasSoftware.OLVColumn OlvcName;
        private BrightIdeasSoftware.OLVColumn OlvcStreet;
        private BrightIdeasSoftware.OLVColumn OlvcNumber;
        private BrightIdeasSoftware.OLVColumn OlvcPostCode;
        private BrightIdeasSoftware.OLVColumn OlvcTown;
        private BrightIdeasSoftware.OLVColumn OlvcPersonStreet;
        private BrightIdeasSoftware.OLVColumn OlvcPersonNr;
        private BrightIdeasSoftware.OLVColumn OlvcPersonPostcode;
        private BrightIdeasSoftware.OLVColumn OlvcPersonTown;
        private System.Windows.Forms.TextBox TbFilterPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSortPersons;
        private BrightIdeasSoftware.OLVColumn OlvcAppointmentDescription;
        private System.Windows.Forms.Button BtnSortAppointments;
        private System.Windows.Forms.Button BtnSortLocations;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmiSortByPerson;
        private System.Windows.Forms.ToolStripMenuItem TsmiSortByDate;
        private System.Windows.Forms.ToolStripMenuItem TsmiSortByLocation;
        private System.Windows.Forms.ToolStripMenuItem TsmiSortByDescription;
    }
}

