﻿namespace Kladionica
{
    partial class frmPocetna
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
            this.btnSpremiListic = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMojiListici = new System.Windows.Forms.ToolStripButton();
            this.btnNoviListic = new System.Windows.Forms.ToolStripButton();
            this.btnPregledajRezultate = new System.Windows.Forms.ToolStripButton();
            this.btnResetirajStanjeNovcanika = new System.Windows.Forms.ToolStripButton();
            this.tabRukomet = new System.Windows.Forms.TabPage();
            this.grdRukomet = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbor1_2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IzborX_2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Izbor2_2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabKosarka = new System.Windows.Forms.TabPage();
            this.grdKosarka = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbor1_1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IzborX_1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Izbor2_1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabNogomet = new System.Windows.Forms.TabPage();
            this.grdNogomet = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kvota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KvotaX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kvota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbor1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IzborX = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Izbor2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSportovi = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUlog = new System.Windows.Forms.TextBox();
            this.textBoxStanjeRacuna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUkupnaKvota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUkupniDobitak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabRukomet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRukomet)).BeginInit();
            this.tabKosarka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKosarka)).BeginInit();
            this.tabNogomet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNogomet)).BeginInit();
            this.tabSportovi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpremiListic
            // 
            this.btnSpremiListic.Location = new System.Drawing.Point(625, 381);
            this.btnSpremiListic.Name = "btnSpremiListic";
            this.btnSpremiListic.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiListic.TabIndex = 0;
            this.btnSpremiListic.Text = "Spremi listić";
            this.btnSpremiListic.UseVisualStyleBackColor = true;
            this.btnSpremiListic.Click += new System.EventHandler(this.btnSpremiListic_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMojiListici,
            this.btnNoviListic,
            this.btnPregledajRezultate,
            this.btnResetirajStanjeNovcanika});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(703, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMojiListici
            // 
            this.btnMojiListici.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMojiListici.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMojiListici.Name = "btnMojiListici";
            this.btnMojiListici.Size = new System.Drawing.Size(65, 22);
            this.btnMojiListici.Text = "Moji listići";
            this.btnMojiListici.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMojiListici.Click += new System.EventHandler(this.btnMojiListici_Click);
            // 
            // btnNoviListic
            // 
            this.btnNoviListic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNoviListic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNoviListic.Name = "btnNoviListic";
            this.btnNoviListic.Size = new System.Drawing.Size(63, 22);
            this.btnNoviListic.Text = "Novi listić";
            this.btnNoviListic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNoviListic.Click += new System.EventHandler(this.btnNoviListic_Click);
            // 
            // btnPregledajRezultate
            // 
            this.btnPregledajRezultate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPregledajRezultate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPregledajRezultate.Name = "btnPregledajRezultate";
            this.btnPregledajRezultate.Size = new System.Drawing.Size(108, 22);
            this.btnPregledajRezultate.Text = "Pregledaj rezultate";
            this.btnPregledajRezultate.Click += new System.EventHandler(this.btnPregledajRezultate_Click);
            // 
            // btnResetirajStanjeNovcanika
            // 
            this.btnResetirajStanjeNovcanika.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnResetirajStanjeNovcanika.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnResetirajStanjeNovcanika.Name = "btnResetirajStanjeNovcanika";
            this.btnResetirajStanjeNovcanika.Size = new System.Drawing.Size(146, 22);
            this.btnResetirajStanjeNovcanika.Text = "Resetiraj stanje novčanika";
            this.btnResetirajStanjeNovcanika.Click += new System.EventHandler(this.btnResetirajStanjeNovcanika_Click);
            // 
            // tabRukomet
            // 
            this.tabRukomet.Controls.Add(this.grdRukomet);
            this.tabRukomet.Location = new System.Drawing.Point(4, 22);
            this.tabRukomet.Name = "tabRukomet";
            this.tabRukomet.Padding = new System.Windows.Forms.Padding(3);
            this.tabRukomet.Size = new System.Drawing.Size(695, 297);
            this.tabRukomet.TabIndex = 2;
            this.tabRukomet.Text = "Rukomet";
            this.tabRukomet.UseVisualStyleBackColor = true;
            // 
            // grdRukomet
            // 
            this.grdRukomet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRukomet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Izbor1_2,
            this.IzborX_2,
            this.Izbor2_2});
            this.grdRukomet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRukomet.Location = new System.Drawing.Point(3, 3);
            this.grdRukomet.Name = "grdRukomet";
            this.grdRukomet.Size = new System.Drawing.Size(689, 291);
            this.grdRukomet.TabIndex = 1;
            this.grdRukomet.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdRukomet_CellMouseUp);
            this.grdRukomet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRukomet_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Domacin";
            this.dataGridViewTextBoxColumn2.HeaderText = "Domaćin";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Gost";
            this.Column6.HeaderText = "Gost";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "KvotaPobjedaDomacina";
            this.Column7.HeaderText = "Kvota 1";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "KvotaNerijeseno";
            this.Column8.HeaderText = "Kvota X";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "KvotaPobjedaGosta";
            this.Column9.HeaderText = "Kvota 2";
            this.Column9.Name = "Column9";
            // 
            // Izbor1_2
            // 
            this.Izbor1_2.DataPropertyName = "IzborPobjedaDomacina";
            this.Izbor1_2.HeaderText = "1";
            this.Izbor1_2.Name = "Izbor1_2";
            this.Izbor1_2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izbor1_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Izbor1_2.Width = 50;
            // 
            // IzborX_2
            // 
            this.IzborX_2.DataPropertyName = "IzborNerijeseno";
            this.IzborX_2.HeaderText = "X";
            this.IzborX_2.Name = "IzborX_2";
            this.IzborX_2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IzborX_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IzborX_2.Width = 50;
            // 
            // Izbor2_2
            // 
            this.Izbor2_2.DataPropertyName = "IzborPobjedaGosta";
            this.Izbor2_2.HeaderText = "2";
            this.Izbor2_2.Name = "Izbor2_2";
            this.Izbor2_2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izbor2_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Izbor2_2.Width = 50;
            // 
            // tabKosarka
            // 
            this.tabKosarka.Controls.Add(this.grdKosarka);
            this.tabKosarka.Location = new System.Drawing.Point(4, 22);
            this.tabKosarka.Name = "tabKosarka";
            this.tabKosarka.Padding = new System.Windows.Forms.Padding(3);
            this.tabKosarka.Size = new System.Drawing.Size(695, 297);
            this.tabKosarka.TabIndex = 1;
            this.tabKosarka.Text = "Košarka";
            this.tabKosarka.UseVisualStyleBackColor = true;
            // 
            // grdKosarka
            // 
            this.grdKosarka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKosarka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Izbor1_1,
            this.IzborX_1,
            this.Izbor2_1});
            this.grdKosarka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKosarka.Location = new System.Drawing.Point(3, 3);
            this.grdKosarka.Name = "grdKosarka";
            this.grdKosarka.Size = new System.Drawing.Size(689, 291);
            this.grdKosarka.TabIndex = 1;
            this.grdKosarka.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdKosarka_CellMouseUp);
            this.grdKosarka.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdKosarka_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Domacin";
            this.dataGridViewTextBoxColumn1.HeaderText = "Domaći";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Gost";
            this.Column2.HeaderText = "Gost";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "KvotaPobjedaDomacina";
            this.Column3.HeaderText = "Kvota 1";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "KvotaNerijeseno";
            this.Column4.HeaderText = "Kvota X";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "KvotaPobjedaGosta";
            this.Column5.HeaderText = "Kvota 2";
            this.Column5.Name = "Column5";
            // 
            // Izbor1_1
            // 
            this.Izbor1_1.DataPropertyName = "IzborPobjedaDomacina";
            this.Izbor1_1.HeaderText = "1";
            this.Izbor1_1.Name = "Izbor1_1";
            this.Izbor1_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izbor1_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Izbor1_1.Width = 50;
            // 
            // IzborX_1
            // 
            this.IzborX_1.DataPropertyName = "IzborNerijeseno";
            this.IzborX_1.HeaderText = "X";
            this.IzborX_1.Name = "IzborX_1";
            this.IzborX_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IzborX_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IzborX_1.Width = 50;
            // 
            // Izbor2_1
            // 
            this.Izbor2_1.DataPropertyName = "IzborPobjedaGosta";
            this.Izbor2_1.HeaderText = "2";
            this.Izbor2_1.Name = "Izbor2_1";
            this.Izbor2_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izbor2_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Izbor2_1.Width = 50;
            // 
            // tabNogomet
            // 
            this.tabNogomet.Controls.Add(this.grdNogomet);
            this.tabNogomet.Location = new System.Drawing.Point(4, 22);
            this.tabNogomet.Name = "tabNogomet";
            this.tabNogomet.Padding = new System.Windows.Forms.Padding(3);
            this.tabNogomet.Size = new System.Drawing.Size(695, 297);
            this.tabNogomet.TabIndex = 0;
            this.tabNogomet.Text = "Nogomet";
            this.tabNogomet.UseVisualStyleBackColor = true;
            // 
            // grdNogomet
            // 
            this.grdNogomet.AllowUserToAddRows = false;
            this.grdNogomet.AllowUserToDeleteRows = false;
            this.grdNogomet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNogomet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Gost,
            this.Kvota1,
            this.KvotaX,
            this.Kvota2,
            this.Izbor1,
            this.IzborX,
            this.Izbor2});
            this.grdNogomet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNogomet.Location = new System.Drawing.Point(3, 3);
            this.grdNogomet.MultiSelect = false;
            this.grdNogomet.Name = "grdNogomet";
            this.grdNogomet.Size = new System.Drawing.Size(689, 291);
            this.grdNogomet.TabIndex = 0;
            this.grdNogomet.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdNogomet_CellMouseUp);
            this.grdNogomet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNogomet_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Domacin";
            this.Column1.HeaderText = "Domaći";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Gost
            // 
            this.Gost.DataPropertyName = "Gost";
            this.Gost.HeaderText = "Gost";
            this.Gost.Name = "Gost";
            this.Gost.ReadOnly = true;
            // 
            // Kvota1
            // 
            this.Kvota1.DataPropertyName = "KvotaPobjedaDomacina";
            this.Kvota1.HeaderText = "Kvota 1";
            this.Kvota1.Name = "Kvota1";
            this.Kvota1.ReadOnly = true;
            // 
            // KvotaX
            // 
            this.KvotaX.DataPropertyName = "KvotaNerijeseno";
            this.KvotaX.HeaderText = "Kvota X";
            this.KvotaX.Name = "KvotaX";
            this.KvotaX.ReadOnly = true;
            // 
            // Kvota2
            // 
            this.Kvota2.DataPropertyName = "KvotaPobjedaGosta";
            this.Kvota2.HeaderText = "Kvota 2";
            this.Kvota2.Name = "Kvota2";
            this.Kvota2.ReadOnly = true;
            // 
            // Izbor1
            // 
            this.Izbor1.DataPropertyName = "IzborPobjedaDomacina";
            this.Izbor1.HeaderText = "1";
            this.Izbor1.Name = "Izbor1";
            this.Izbor1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izbor1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Izbor1.Width = 50;
            // 
            // IzborX
            // 
            this.IzborX.DataPropertyName = "IzborNerijeseno";
            this.IzborX.HeaderText = "X";
            this.IzborX.Name = "IzborX";
            this.IzborX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IzborX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IzborX.Width = 50;
            // 
            // Izbor2
            // 
            this.Izbor2.DataPropertyName = "IzborPobjedaGosta";
            this.Izbor2.HeaderText = "2";
            this.Izbor2.Name = "Izbor2";
            this.Izbor2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izbor2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Izbor2.Width = 50;
            // 
            // tabSportovi
            // 
            this.tabSportovi.Controls.Add(this.tabNogomet);
            this.tabSportovi.Controls.Add(this.tabKosarka);
            this.tabSportovi.Controls.Add(this.tabRukomet);
            this.tabSportovi.Location = new System.Drawing.Point(0, 52);
            this.tabSportovi.Name = "tabSportovi";
            this.tabSportovi.SelectedIndex = 0;
            this.tabSportovi.Size = new System.Drawing.Size(703, 323);
            this.tabSportovi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ulog:";
            // 
            // textBoxUlog
            // 
            this.textBoxUlog.Location = new System.Drawing.Point(41, 25);
            this.textBoxUlog.Name = "textBoxUlog";
            this.textBoxUlog.Size = new System.Drawing.Size(100, 20);
            this.textBoxUlog.TabIndex = 4;
            this.textBoxUlog.TextChanged += new System.EventHandler(this.textBoxUlog_TextChanged);
            this.textBoxUlog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUlog_KeyPress);
            // 
            // textBoxStanjeRacuna
            // 
            this.textBoxStanjeRacuna.Enabled = false;
            this.textBoxStanjeRacuna.Location = new System.Drawing.Point(598, 25);
            this.textBoxStanjeRacuna.Name = "textBoxStanjeRacuna";
            this.textBoxStanjeRacuna.Size = new System.Drawing.Size(100, 20);
            this.textBoxStanjeRacuna.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stanje na računu:";
            // 
            // textBoxUkupnaKvota
            // 
            this.textBoxUkupnaKvota.Enabled = false;
            this.textBoxUkupnaKvota.Location = new System.Drawing.Point(84, 381);
            this.textBoxUkupnaKvota.Name = "textBoxUkupnaKvota";
            this.textBoxUkupnaKvota.Size = new System.Drawing.Size(100, 20);
            this.textBoxUkupnaKvota.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ukupna kvota:";
            // 
            // textBoxUkupniDobitak
            // 
            this.textBoxUkupniDobitak.Enabled = false;
            this.textBoxUkupniDobitak.Location = new System.Drawing.Point(304, 381);
            this.textBoxUkupniDobitak.Name = "textBoxUkupniDobitak";
            this.textBoxUkupniDobitak.Size = new System.Drawing.Size(100, 20);
            this.textBoxUkupniDobitak.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ukupni dobitak:";
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 406);
            this.Controls.Add(this.textBoxUkupniDobitak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUkupnaKvota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStanjeRacuna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabSportovi);
            this.Controls.Add(this.btnSpremiListic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPocetna";
            this.Text = "Kladionica";
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabRukomet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRukomet)).EndInit();
            this.tabKosarka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKosarka)).EndInit();
            this.tabNogomet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNogomet)).EndInit();
            this.tabSportovi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremiListic;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMojiListici;
        private System.Windows.Forms.TabPage tabRukomet;
        private System.Windows.Forms.DataGridView grdRukomet;
        private System.Windows.Forms.TabPage tabKosarka;
        private System.Windows.Forms.DataGridView grdKosarka;
        private System.Windows.Forms.TabPage tabNogomet;
        private System.Windows.Forms.DataGridView grdNogomet;
        private System.Windows.Forms.TabControl tabSportovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kvota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KvotaX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kvota2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izbor1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IzborX;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izbor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUlog;
        private System.Windows.Forms.TextBox textBoxStanjeRacuna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUkupnaKvota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUkupniDobitak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton btnNoviListic;
        private System.Windows.Forms.ToolStripButton btnPregledajRezultate;
        private System.Windows.Forms.ToolStripButton btnResetirajStanjeNovcanika;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izbor1_1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IzborX_1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izbor2_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izbor1_2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IzborX_2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izbor2_2;
    }
}

