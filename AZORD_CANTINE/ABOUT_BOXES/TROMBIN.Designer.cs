namespace AZORD_CANTINE.ABOUT_BOXES
{
    partial class TROMBIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DESIGNATION = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SECTION = new Guna.UI2.WinForms.Guna2ComboBox();
            this.NIVEAU = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TABLEELEVE = new System.Windows.Forms.DataGridView();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLEELEVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DESIGNATION);
            this.groupBox1.Controls.Add(this.SECTION);
            this.groupBox1.Controls.Add(this.NIVEAU);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SALLE";
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.BackColor = System.Drawing.Color.Transparent;
            this.DESIGNATION.BorderRadius = 8;
            this.DESIGNATION.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DESIGNATION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DESIGNATION.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DESIGNATION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DESIGNATION.FocusedState.Parent = this.DESIGNATION;
            this.DESIGNATION.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DESIGNATION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DESIGNATION.HoverState.Parent = this.DESIGNATION;
            this.DESIGNATION.ItemHeight = 30;
            this.DESIGNATION.ItemsAppearance.Parent = this.DESIGNATION;
            this.DESIGNATION.Location = new System.Drawing.Point(235, 69);
            this.DESIGNATION.Name = "DESIGNATION";
            this.DESIGNATION.ShadowDecoration.Parent = this.DESIGNATION;
            this.DESIGNATION.Size = new System.Drawing.Size(92, 36);
            this.DESIGNATION.TabIndex = 5;
            this.DESIGNATION.SelectedIndexChanged += new System.EventHandler(this.DESIGNATION_SelectedIndexChanged);
            // 
            // SECTION
            // 
            this.SECTION.BackColor = System.Drawing.Color.Transparent;
            this.SECTION.BorderRadius = 8;
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
            this.SECTION.Location = new System.Drawing.Point(123, 69);
            this.SECTION.Name = "SECTION";
            this.SECTION.ShadowDecoration.Parent = this.SECTION;
            this.SECTION.Size = new System.Drawing.Size(106, 36);
            this.SECTION.TabIndex = 4;
            this.SECTION.SelectedIndexChanged += new System.EventHandler(this.SECTION_SelectedIndexChanged);
            // 
            // NIVEAU
            // 
            this.NIVEAU.BackColor = System.Drawing.Color.Transparent;
            this.NIVEAU.BorderRadius = 8;
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
            this.NIVEAU.Location = new System.Drawing.Point(10, 69);
            this.NIVEAU.Name = "NIVEAU";
            this.NIVEAU.ShadowDecoration.Parent = this.NIVEAU;
            this.NIVEAU.Size = new System.Drawing.Size(67, 36);
            this.NIVEAU.TabIndex = 3;
            this.NIVEAU.SelectedIndexChanged += new System.EventHandler(this.NIVEAU_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESIGNATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "SECTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIVEAU";
            // 
            // TABLEELEVE
            // 
            this.TABLEELEVE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABLEELEVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLEELEVE.Location = new System.Drawing.Point(446, 63);
            this.TABLEELEVE.Name = "TABLEELEVE";
            this.TABLEELEVE.Size = new System.Drawing.Size(458, 319);
            this.TABLEELEVE.TabIndex = 1;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(704, 12);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 2;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AZORD_CANTINE.Properties.Resources.avtar_8;
            this.pictureBox1.Location = new System.Drawing.Point(263, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(276, 305);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Choisir une photo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TROMBIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 587);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.TABLEELEVE);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TROMBIN";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TROMBIN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLEELEVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox DESIGNATION;
        private Guna.UI2.WinForms.Guna2ComboBox SECTION;
        private Guna.UI2.WinForms.Guna2ComboBox NIVEAU;
        private System.Windows.Forms.DataGridView TABLEELEVE;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}
