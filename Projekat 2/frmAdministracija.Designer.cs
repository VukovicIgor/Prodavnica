
namespace Projekat_2
{
    partial class frmAdministracija
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.početniEkranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.višeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbStatistika = new System.Windows.Forms.ListBox();
            this.dtpMesec = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dtgRacun = new System.Windows.Forms.DataGridView();
            this.idracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zbirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkupovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bazaProjektaDataSet = new Projekat_2.BazaProjektaDataSet();
            this.dtpPocetni = new System.Windows.Forms.DateTimePicker();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpKrajnji = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.txtDodajCenu = new System.Windows.Forms.TextBox();
            this.txtDodajNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.racunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgProizvod = new System.Windows.Forms.DataGridView();
            this.idproizvodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkategorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodTableAdapter = new Projekat_2.BazaProjektaDataSetTableAdapters.ProizvodTableAdapter();
            this.racunTableAdapter = new Projekat_2.BazaProjektaDataSetTableAdapters.RacunTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaProjektaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProizvod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcijeToolStripMenuItem,
            this.višeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1240, 27);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracijaToolStripMenuItem,
            this.početniEkranToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.opcijeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.opcijeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.opcijeToolStripMenuItem.Text = "Op&cije";
            // 
            // administracijaToolStripMenuItem
            // 
            this.administracijaToolStripMenuItem.Name = "administracijaToolStripMenuItem";
            this.administracijaToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.administracijaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.administracijaToolStripMenuItem.ShowShortcutKeys = false;
            this.administracijaToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.administracijaToolStripMenuItem.Text = "P&rodaja";
            this.administracijaToolStripMenuItem.Click += new System.EventHandler(this.Prodaja);
            // 
            // početniEkranToolStripMenuItem
            // 
            this.početniEkranToolStripMenuItem.Name = "početniEkranToolStripMenuItem";
            this.početniEkranToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.početniEkranToolStripMenuItem.ShowShortcutKeys = false;
            this.početniEkranToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.početniEkranToolStripMenuItem.Text = "P&očetni ekran";
            this.početniEkranToolStripMenuItem.Click += new System.EventHandler(this.Pocetni);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.izlazToolStripMenuItem.ShowShortcutKeys = false;
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.izlazToolStripMenuItem.Text = "I&zlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.Izlaz);
            // 
            // višeToolStripMenuItem
            // 
            this.višeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomoćToolStripMenuItem,
            this.kontaktToolStripMenuItem});
            this.višeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.višeToolStripMenuItem.Name = "višeToolStripMenuItem";
            this.višeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.višeToolStripMenuItem.ShowShortcutKeys = false;
            this.višeToolStripMenuItem.Size = new System.Drawing.Size(51, 25);
            this.višeToolStripMenuItem.Text = "V&iše";
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.pomoćToolStripMenuItem.ShowShortcutKeys = false;
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.pomoćToolStripMenuItem.Text = "&Pomoć";
            this.pomoćToolStripMenuItem.Click += new System.EventHandler(this.Pomoc);
            // 
            // kontaktToolStripMenuItem
            // 
            this.kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            this.kontaktToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.kontaktToolStripMenuItem.ShowShortcutKeys = false;
            this.kontaktToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.kontaktToolStripMenuItem.Text = "&Kontakt";
            this.kontaktToolStripMenuItem.Click += new System.EventHandler(this.Kontakt);
            // 
            // lbStatistika
            // 
            this.lbStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatistika.FormattingEnabled = true;
            this.lbStatistika.ItemHeight = 16;
            this.lbStatistika.Location = new System.Drawing.Point(733, 190);
            this.lbStatistika.Name = "lbStatistika";
            this.lbStatistika.Size = new System.Drawing.Size(479, 148);
            this.lbStatistika.TabIndex = 48;
            this.lbStatistika.Visible = false;
            // 
            // dtpMesec
            // 
            this.dtpMesec.CustomFormat = "MMMM";
            this.dtpMesec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMesec.Location = new System.Drawing.Point(1052, 99);
            this.dtpMesec.Name = "dtpMesec";
            this.dtpMesec.ShowUpDown = true;
            this.dtpMesec.Size = new System.Drawing.Size(125, 20);
            this.dtpMesec.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(766, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Statistika prodaje proizvoda za mesec:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(728, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 29);
            this.label8.TabIndex = 45;
            this.label8.Text = "Statistika:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(915, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 44;
            this.button1.Text = "Pogledaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Pogledaj);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnObrisi.Location = new System.Drawing.Point(433, 222);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(107, 32);
            this.btnObrisi.TabIndex = 43;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.Obrisi);
            // 
            // dtgRacun
            // 
            this.dtgRacun.AllowUserToAddRows = false;
            this.dtgRacun.AllowUserToDeleteRows = false;
            this.dtgRacun.AutoGenerateColumns = false;
            this.dtgRacun.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRacun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRacun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idracunaDataGridViewTextBoxColumn,
            this.zbirDataGridViewTextBoxColumn,
            this.datumkupovineDataGridViewTextBoxColumn});
            this.dtgRacun.DataSource = this.racunBindingSource2;
            this.dtgRacun.Location = new System.Drawing.Point(151, 371);
            this.dtgRacun.Name = "dtgRacun";
            this.dtgRacun.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRacun.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgRacun.RowHeadersWidth = 62;
            this.dtgRacun.Size = new System.Drawing.Size(376, 168);
            this.dtgRacun.TabIndex = 41;
            // 
            // idracunaDataGridViewTextBoxColumn
            // 
            this.idracunaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idracunaDataGridViewTextBoxColumn.DataPropertyName = "id_racuna";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idracunaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.idracunaDataGridViewTextBoxColumn.HeaderText = "ID racuna";
            this.idracunaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idracunaDataGridViewTextBoxColumn.Name = "idracunaDataGridViewTextBoxColumn";
            this.idracunaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zbirDataGridViewTextBoxColumn
            // 
            this.zbirDataGridViewTextBoxColumn.DataPropertyName = "zbir";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zbirDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.zbirDataGridViewTextBoxColumn.HeaderText = "Zbir RSD";
            this.zbirDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.zbirDataGridViewTextBoxColumn.Name = "zbirDataGridViewTextBoxColumn";
            this.zbirDataGridViewTextBoxColumn.ReadOnly = true;
            this.zbirDataGridViewTextBoxColumn.Width = 150;
            // 
            // datumkupovineDataGridViewTextBoxColumn
            // 
            this.datumkupovineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumkupovineDataGridViewTextBoxColumn.DataPropertyName = "datum_kupovine";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumkupovineDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.datumkupovineDataGridViewTextBoxColumn.HeaderText = "Datum kupovine";
            this.datumkupovineDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datumkupovineDataGridViewTextBoxColumn.Name = "datumkupovineDataGridViewTextBoxColumn";
            this.datumkupovineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // racunBindingSource2
            // 
            this.racunBindingSource2.DataMember = "Racun";
            this.racunBindingSource2.DataSource = this.bazaProjektaDataSet;
            // 
            // bazaProjektaDataSet
            // 
            this.bazaProjektaDataSet.DataSetName = "BazaProjektaDataSet";
            this.bazaProjektaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpPocetni
            // 
            this.dtpPocetni.Location = new System.Drawing.Point(200, 307);
            this.dtpPocetni.Name = "dtpPocetni";
            this.dtpPocetni.Size = new System.Drawing.Size(200, 20);
            this.dtpPocetni.TabIndex = 40;
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPretraga.Location = new System.Drawing.Point(468, 307);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(181, 47);
            this.btnPretraga.TabIndex = 39;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.Pretraga);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Krajnji datum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "Pretraga računa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Početni datum:";
            // 
            // dtpKrajnji
            // 
            this.dtpKrajnji.Location = new System.Drawing.Point(200, 334);
            this.dtpKrajnji.Name = "dtpKrajnji";
            this.dtpKrajnji.Size = new System.Drawing.Size(200, 20);
            this.dtpKrajnji.TabIndex = 35;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDodaj.Location = new System.Drawing.Point(133, 222);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(107, 32);
            this.btnDodaj.TabIndex = 34;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.Dodaj);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.ItemHeight = 18;
            this.cmbKategorija.Location = new System.Drawing.Point(110, 169);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(180, 26);
            this.cmbKategorija.TabIndex = 33;
            // 
            // txtDodajCenu
            // 
            this.txtDodajCenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDodajCenu.Location = new System.Drawing.Point(110, 130);
            this.txtDodajCenu.Name = "txtDodajCenu";
            this.txtDodajCenu.Size = new System.Drawing.Size(180, 24);
            this.txtDodajCenu.TabIndex = 32;
            // 
            // txtDodajNaziv
            // 
            this.txtDodajNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDodajNaziv.Location = new System.Drawing.Point(110, 95);
            this.txtDodajNaziv.Name = "txtDodajNaziv";
            this.txtDodajNaziv.Size = new System.Drawing.Size(180, 24);
            this.txtDodajNaziv.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kategorija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Dodavanje proizvoda:";
            // 
            // racunBindingSource1
            // 
            this.racunBindingSource1.DataMember = "Racun";
            // 
            // proizvodBindingSource1
            // 
            this.proizvodBindingSource1.DataMember = "Proizvod";
            // 
            // dtgProizvod
            // 
            this.dtgProizvod.AllowUserToAddRows = false;
            this.dtgProizvod.AllowUserToDeleteRows = false;
            this.dtgProizvod.AutoGenerateColumns = false;
            this.dtgProizvod.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProizvod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProizvod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproizvodaDataGridViewTextBoxColumn,
            this.idkategorijeDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dtgProizvod.DataSource = this.proizvodBindingSource2;
            this.dtgProizvod.Location = new System.Drawing.Point(300, 48);
            this.dtgProizvod.Name = "dtgProizvod";
            this.dtgProizvod.ReadOnly = true;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProizvod.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dtgProizvod.RowHeadersWidth = 62;
            this.dtgProizvod.Size = new System.Drawing.Size(375, 150);
            this.dtgProizvod.TabIndex = 49;
            // 
            // idproizvodaDataGridViewTextBoxColumn
            // 
            this.idproizvodaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idproizvodaDataGridViewTextBoxColumn.DataPropertyName = "id_proizvoda";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idproizvodaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.idproizvodaDataGridViewTextBoxColumn.HeaderText = "ID proizvoda";
            this.idproizvodaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idproizvodaDataGridViewTextBoxColumn.Name = "idproizvodaDataGridViewTextBoxColumn";
            this.idproizvodaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idkategorijeDataGridViewTextBoxColumn
            // 
            this.idkategorijeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idkategorijeDataGridViewTextBoxColumn.DataPropertyName = "id_kategorije";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idkategorijeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.idkategorijeDataGridViewTextBoxColumn.HeaderText = "ID kategorije";
            this.idkategorijeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idkategorijeDataGridViewTextBoxColumn.Name = "idkategorijeDataGridViewTextBoxColumn";
            this.idkategorijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cenaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proizvodBindingSource2
            // 
            this.proizvodBindingSource2.DataMember = "Proizvod";
            this.proizvodBindingSource2.DataSource = this.bazaProjektaDataSet;
            // 
            // proizvodTableAdapter
            // 
            this.proizvodTableAdapter.ClearBeforeFill = true;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdministracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1240, 561);
            this.Controls.Add(this.dtgProizvod);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbStatistika);
            this.Controls.Add(this.dtpMesec);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dtgRacun);
            this.Controls.Add(this.dtpPocetni);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpKrajnji);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.txtDodajCenu);
            this.Controls.Add(this.txtDodajNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdministracija";
            this.Text = "Administracija";
            this.Load += new System.EventHandler(this.frmAdministracija_Load);
            this.Click += new System.EventHandler(this.Deselektuj);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaProjektaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProizvod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem početniEkranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem višeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontaktToolStripMenuItem;
        private System.Windows.Forms.ListBox lbStatistika;
        private System.Windows.Forms.DateTimePicker dtpMesec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.BindingSource proizvodBindingSource1;
        private System.Windows.Forms.BindingSource racunBindingSource1;
        private System.Windows.Forms.DataGridView dtgRacun;
        private System.Windows.Forms.DateTimePicker dtpPocetni;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpKrajnji;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.TextBox txtDodajCenu;
        private System.Windows.Forms.TextBox txtDodajNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private System.Windows.Forms.DataGridView dtgProizvod;
        private BazaProjektaDataSet bazaProjektaDataSet;
        private System.Windows.Forms.BindingSource proizvodBindingSource2;
        private BazaProjektaDataSetTableAdapters.ProizvodTableAdapter proizvodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproizvodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkategorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource racunBindingSource2;
        private BazaProjektaDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zbirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkupovineDataGridViewTextBoxColumn;
    }
}