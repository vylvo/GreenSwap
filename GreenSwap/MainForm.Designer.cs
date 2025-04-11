namespace GreenSwap
{
    partial class MainForm
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlantCare = new MaterialSkin.Controls.MaterialButton();
            this.btnTrades = new MaterialSkin.Controls.MaterialButton();
            this.btnPlants = new MaterialSkin.Controls.MaterialButton();
            this.btnUsers = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblTitle);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(894, 100);
            this.materialCard1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(14, 14);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(866, 72);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GreenSwap: A Community Plant Exchange";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.pictureBox1);
            this.materialCard2.Controls.Add(this.tableLayoutPanel1);
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 181);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(866, 443);
            this.materialCard2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(446, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnPlantCare, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTrades, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPlants, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUsers, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(409, 364);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnPlantCare
            // 
            this.btnPlantCare.AutoSize = false;
            this.btnPlantCare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlantCare.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPlantCare.Depth = 0;
            this.btnPlantCare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlantCare.HighEmphasis = true;
            this.btnPlantCare.Icon = null;
            this.btnPlantCare.Location = new System.Drawing.Point(4, 280);
            this.btnPlantCare.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlantCare.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlantCare.Name = "btnPlantCare";
            this.btnPlantCare.Size = new System.Drawing.Size(401, 78);
            this.btnPlantCare.TabIndex = 3;
            this.btnPlantCare.Text = "PLANT CARE INFORMATION";
            this.btnPlantCare.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPlantCare.UseAccentColor = false;
            this.btnPlantCare.UseVisualStyleBackColor = true;
            this.btnPlantCare.Click += new System.EventHandler(this.btnPlantCare_Click);
            // 
            // btnTrades
            // 
            this.btnTrades.AutoSize = false;
            this.btnTrades.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTrades.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTrades.Depth = 0;
            this.btnTrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrades.HighEmphasis = true;
            this.btnTrades.Icon = null;
            this.btnTrades.Location = new System.Drawing.Point(4, 188);
            this.btnTrades.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTrades.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTrades.Name = "btnTrades";
            this.btnTrades.Size = new System.Drawing.Size(401, 80);
            this.btnTrades.TabIndex = 2;
            this.btnTrades.Text = "MANAGE TRADES";
            this.btnTrades.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTrades.UseAccentColor = false;
            this.btnTrades.UseVisualStyleBackColor = true;
            this.btnTrades.Click += new System.EventHandler(this.btnTrades_Click);
            // 
            // btnPlants
            // 
            this.btnPlants.AutoSize = false;
            this.btnPlants.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlants.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPlants.Depth = 0;
            this.btnPlants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlants.HighEmphasis = true;
            this.btnPlants.Icon = null;
            this.btnPlants.Location = new System.Drawing.Point(4, 97);
            this.btnPlants.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlants.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlants.Name = "btnPlants";
            this.btnPlants.Size = new System.Drawing.Size(401, 79);
            this.btnPlants.TabIndex = 1;
            this.btnPlants.Text = "MANAGE PLANTS";
            this.btnPlants.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPlants.UseAccentColor = false;
            this.btnPlants.UseVisualStyleBackColor = true;
            this.btnPlants.Click += new System.EventHandler(this.btnPlants_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.AutoSize = false;
            this.btnUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsers.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUsers.Depth = 0;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.HighEmphasis = true;
            this.btnUsers.Icon = null;
            this.btnUsers.Location = new System.Drawing.Point(4, 6);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(401, 79);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "MANAGE USERS";
            this.btnUsers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUsers.UseAccentColor = false;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(832, 35);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Welcome to GreenSwap! Choose an option below to get started:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.Text = "GreenSwap";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnPlantCare;
        private MaterialSkin.Controls.MaterialButton btnTrades;
        private MaterialSkin.Controls.MaterialButton btnPlants;
        private MaterialSkin.Controls.MaterialButton btnUsers;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}