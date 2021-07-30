namespace AZORD_CANTINE.USERCONTROL
{
    partial class ABONNEMENT
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TABLEELEVE = new System.Windows.Forms.DataGridView();
            this.DESIGNATION = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SECTION = new Guna.UI2.WinForms.Guna2ComboBox();
            this.NIVEAU = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NOM = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.POSTNOM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PRENOM = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.STATUS = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label13 = new System.Windows.Forms.Label();
            this.NONABONNE = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ABONNE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLEELEVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.TABLEELEVE);
            this.groupBox1.Controls.Add(this.DESIGNATION);
            this.groupBox1.Controls.Add(this.SECTION);
            this.groupBox1.Controls.Add(this.NIVEAU);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(425, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SALLE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Rechercher ici";
            // 
            // TABLEELEVE
            // 
            this.TABLEELEVE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABLEELEVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLEELEVE.Location = new System.Drawing.Point(9, 154);
            this.TABLEELEVE.Name = "TABLEELEVE";
            this.TABLEELEVE.Size = new System.Drawing.Size(527, 362);
            this.TABLEELEVE.TabIndex = 6;
            this.TABLEELEVE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLEELEVE_CellContentClick);
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.BackColor = System.Drawing.Color.Transparent;
            this.DESIGNATION.BorderRadius = 9;
            this.DESIGNATION.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DESIGNATION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DESIGNATION.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DESIGNATION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DESIGNATION.FocusedState.Parent = this.DESIGNATION;
            this.DESIGNATION.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DESIGNATION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DESIGNATION.HoverState.Parent = this.DESIGNATION;
            this.DESIGNATION.ItemHeight = 30;
            this.DESIGNATION.Items.AddRange(new object[] {
            "TESTING",
            "AS"});
            this.DESIGNATION.ItemsAppearance.Parent = this.DESIGNATION;
            this.DESIGNATION.Location = new System.Drawing.Point(382, 56);
            this.DESIGNATION.Name = "DESIGNATION";
            this.DESIGNATION.ShadowDecoration.Parent = this.DESIGNATION;
            this.DESIGNATION.Size = new System.Drawing.Size(96, 36);
            this.DESIGNATION.TabIndex = 5;
            this.DESIGNATION.SelectedIndexChanged += new System.EventHandler(this.DESIGNATION_SelectedIndexChanged);
            // 
            // SECTION
            // 
            this.SECTION.BackColor = System.Drawing.Color.Transparent;
            this.SECTION.BorderRadius = 9;
            this.SECTION.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SECTION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SECTION.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SECTION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SECTION.FocusedState.Parent = this.SECTION;
            this.SECTION.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SECTION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SECTION.HoverState.Parent = this.SECTION;
            this.SECTION.ItemHeight = 30;
            this.SECTION.ItemsAppearance.Parent = this.SECTION;
            this.SECTION.Location = new System.Drawing.Point(215, 56);
            this.SECTION.Name = "SECTION";
            this.SECTION.ShadowDecoration.Parent = this.SECTION;
            this.SECTION.Size = new System.Drawing.Size(114, 36);
            this.SECTION.TabIndex = 4;
            this.SECTION.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // NIVEAU
            // 
            this.NIVEAU.BackColor = System.Drawing.Color.Transparent;
            this.NIVEAU.BorderRadius = 9;
            this.NIVEAU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NIVEAU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NIVEAU.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NIVEAU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NIVEAU.FocusedState.Parent = this.NIVEAU;
            this.NIVEAU.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NIVEAU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.NIVEAU.HoverState.Parent = this.NIVEAU;
            this.NIVEAU.ItemHeight = 30;
            this.NIVEAU.ItemsAppearance.Parent = this.NIVEAU;
            this.NIVEAU.Location = new System.Drawing.Point(9, 56);
            this.NIVEAU.Name = "NIVEAU";
            this.NIVEAU.ShadowDecoration.Parent = this.NIVEAU;
            this.NIVEAU.Size = new System.Drawing.Size(88, 36);
            this.NIVEAU.TabIndex = 3;
            this.NIVEAU.SelectedIndexChanged += new System.EventHandler(this.NIVEAU_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESIGNATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SECTION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIVEAU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "NOM";
            // 
            // NOM
            // 
            this.NOM.AutoSize = true;
            this.NOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM.Location = new System.Drawing.Point(654, 15);
            this.NOM.Name = "NOM";
            this.NOM.Size = new System.Drawing.Size(107, 16);
            this.NOM.TabIndex = 10;
            this.NOM.Text = "MUTINDIAPALA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AZORD_CANTINE.Properties.Resources.avtar_3;
            this.pictureBox1.Location = new System.Drawing.Point(807, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // POSTNOM
            // 
            this.POSTNOM.AutoSize = true;
            this.POSTNOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSTNOM.Location = new System.Drawing.Point(654, 62);
            this.POSTNOM.Name = "POSTNOM";
            this.POSTNOM.Size = new System.Drawing.Size(85, 16);
            this.POSTNOM.TabIndex = 13;
            this.POSTNOM.Text = "MWILILIKWA";
            this.POSTNOM.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(564, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "POSTNOM";
            // 
            // PRENOM
            // 
            this.PRENOM.AutoSize = true;
            this.PRENOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRENOM.Location = new System.Drawing.Point(654, 109);
            this.PRENOM.Name = "PRENOM";
            this.PRENOM.Size = new System.Drawing.Size(85, 16);
            this.PRENOM.TabIndex = 15;
            this.PRENOM.Text = "MWILILIKWA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(573, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "PRENOM";
            // 
            // STATUS
            // 
            this.STATUS.AutoSize = true;
            this.STATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATUS.Location = new System.Drawing.Point(654, 156);
            this.STATUS.Name = "STATUS";
            this.STATUS.Size = new System.Drawing.Size(65, 16);
            this.STATUS.TabIndex = 17;
            this.STATUS.Text = "ABONNE";
            this.STATUS.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(465, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "STATUS D\'ABONNEMENT";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Enabled = false;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(807, 204);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(160, 45);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "ABONNE";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 7;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(468, 204);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(160, 45);
            this.guna2Button2.TabIndex = 19;
            this.guna2Button2.Text = "FICHE DE PAIE";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 7;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(250, 600);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(160, 45);
            this.guna2Button3.TabIndex = 20;
            this.guna2Button3.Text = "FINANCE";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 15);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(416, 300);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(190, 765);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "eleve pas encore enregstre, cliquer  ";
            // 
            // NONABONNE
            // 
            this.NONABONNE.AutoSize = true;
            this.NONABONNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NONABONNE.Location = new System.Drawing.Point(208, 400);
            this.NONABONNE.Name = "NONABONNE";
            this.NONABONNE.Size = new System.Drawing.Size(22, 16);
            this.NONABONNE.TabIndex = 25;
            this.NONABONNE.Text = "78";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(87, 400);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "NON ABONNES";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.Location = new System.Drawing.Point(208, 444);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(22, 16);
            this.TOTAL.TabIndex = 23;
            this.TOTAL.Text = "45";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(120, 353);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 16);
            this.label19.TabIndex = 22;
            this.label19.Text = "ABONNES";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(400, 765);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(19, 15);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ici";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(208, 549);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "4 500 FC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 549);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "FRAIS D\'ABONNEMENT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(208, 600);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 16);
            this.label15.TabIndex = 34;
            this.label15.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(35, 600);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(162, 16);
            this.label20.TabIndex = 33;
            this.label20.Text = "LIMITE D\'ABONNEMENT";
            // 
            // ABONNE
            // 
            this.ABONNE.AutoSize = true;
            this.ABONNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABONNE.Location = new System.Drawing.Point(208, 353);
            this.ABONNE.Name = "ABONNE";
            this.ABONNE.Size = new System.Drawing.Size(22, 16);
            this.ABONNE.TabIndex = 36;
            this.ABONNE.Text = "78";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "TOTAL";
            // 
            // ABONNEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.ABONNE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NONABONNE);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.STATUS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PRENOM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.POSTNOM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NOM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABONNEMENT";
            this.Size = new System.Drawing.Size(985, 802);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLEELEVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox DESIGNATION;
        private Guna.UI2.WinForms.Guna2ComboBox SECTION;
        private Guna.UI2.WinForms.Guna2ComboBox NIVEAU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView TABLEELEVE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NOM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label POSTNOM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PRENOM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label STATUS;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label NONABONNE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label ABONNE;
        private System.Windows.Forms.Label label6;
    }
}
