namespace GreenSwap
{
    partial class PlantsForm
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
            this.dgvPlants = new System.Windows.Forms.DataGridView();
            this.PlantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlantType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeOrStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateListed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btnPlantCare = new MaterialSkin.Controls.MaterialButton();
            this.cmbStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpDateListed = new System.Windows.Forms.DateTimePicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAgeOrStage = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPlantID = new MaterialSkin.Controls.MaterialTextBox();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbUser = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPlantType = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPlantName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.cmbSearchPlantType = new MaterialSkin.Controls.MaterialComboBox();
            this.btnFindPlantsByLocation = new MaterialSkin.Controls.MaterialButton();
            this.btnFindAvailablePlants = new MaterialSkin.Controls.MaterialButton();
            this.btnSearchByType = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearchLocation = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlants)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvPlants);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(866, 250);
            this.materialCard1.TabIndex = 0;
            // 
            // dgvPlants
            // 
            this.dgvPlants.AllowUserToAddRows = false;
            this.dgvPlants.AllowUserToDeleteRows = false;
            this.dgvPlants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlantID,
            this.PlantName,
            this.PlantType,
            this.Owner,
            this.AgeOrStage,
            this.DateListed,
            this.Status,
            this.Description});
            this.dgvPlants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlants.Location = new System.Drawing.Point(14, 14);
            this.dgvPlants.Name = "dgvPlants";
            this.dgvPlants.ReadOnly = true;
            this.dgvPlants.RowTemplate.Height = 25;
            this.dgvPlants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlants.Size = new System.Drawing.Size(838, 222);
            this.dgvPlants.TabIndex = 0;
            this.dgvPlants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlants_CellClick);
            // 
            // PlantID
            // 
            this.PlantID.HeaderText = "ID";
            this.PlantID.Name = "PlantID";
            this.PlantID.ReadOnly = true;
            this.PlantID.Width = 50;
            // 
            // PlantName
            // 
            this.PlantName.HeaderText = "Name";
            this.PlantName.Name = "PlantName";
            this.PlantName.ReadOnly = true;
            this.PlantName.Width = 120;
            // 
            // PlantType
            // 
            this.PlantType.HeaderText = "Type";
            this.PlantType.Name = "PlantType";
            this.PlantType.ReadOnly = true;
            this.PlantType.Width = 120;
            // 
            // Owner
            // 
            this.Owner.HeaderText = "Owner";
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            // 
            // AgeOrStage
            // 
            this.AgeOrStage.HeaderText = "Age/Stage";
            this.AgeOrStage.Name = "AgeOrStage";
            this.AgeOrStage.ReadOnly = true;
            // 
            // DateListed
            // 
            this.DateListed.HeaderText = "Date Listed";
            this.DateListed.Name = "DateListed";
            this.DateListed.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btnPlantCare);
            this.materialCard2.Controls.Add(this.cmbStatus);
            this.materialCard2.Controls.Add(this.materialLabel8);
            this.materialCard2.Controls.Add(this.dtpDateListed);
            this.materialCard2.Controls.Add(this.materialLabel7);
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Controls.Add(this.txtAgeOrStage);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.txtDescription);
            this.materialCard2.Controls.Add(this.materialLabel9);
            this.materialCard2.Controls.Add(this.txtPlantID);
            this.materialCard2.Controls.Add(this.btnClear);
            this.materialCard2.Controls.Add(this.btnDelete);
            this.materialCard2.Controls.Add(this.btnUpdate);
            this.materialCard2.Controls.Add(this.btnAdd);
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.cmbUser);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.cmbPlantType);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.txtPlantName);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 342);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(511, 480);
            this.materialCard2.TabIndex = 1;
            // 
            // btnPlantCare
            // 
            this.btnPlantCare.AutoSize = false;
            // btnPlantCare
            this.btnPlantCare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlantCare.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPlantCare.Depth = 0;
            this.btnPlantCare.HighEmphasis = true;
            this.btnPlantCare.Icon = null;
            this.btnPlantCare.Location = new System.Drawing.Point(320, 182);
            this.btnPlantCare.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlantCare.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlantCare.Name = "btnPlantCare";
            this.btnPlantCare.Size = new System.Drawing.Size(175, 36);
            this.btnPlantCare.TabIndex = 23;
            this.btnPlantCare.Text = "VIEW CARE INFO";
            this.btnPlantCare.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPlantCare.UseAccentColor = true;
            this.btnPlantCare.UseVisualStyleBackColor = true;
            this.btnPlantCare.Click += new System.EventHandler(this.btnPlantCare_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoResize = false;
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbStatus.Depth = 0;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStatus.DropDownHeight = 174;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.DropDownWidth = 121;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.IntegralHeight = false;
            this.cmbStatus.ItemHeight = 43;
            this.cmbStatus.Location = new System.Drawing.Point(144, 381);
            this.cmbStatus.MaxDropDownItems = 4;
            this.cmbStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(351, 49);
            this.cmbStatus.StartIndex = 0;
            this.cmbStatus.TabIndex = 22;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(18, 396);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(45, 19);
            this.materialLabel8.TabIndex = 21;
            this.materialLabel8.Text = "Status";
            // 
            // dtpDateListed
            // 
            this.dtpDateListed.Location = new System.Drawing.Point(144, 340);
            this.dtpDateListed.Name = "dtpDateListed";
            this.dtpDateListed.Size = new System.Drawing.Size(351, 23);
            this.dtpDateListed.TabIndex = 20;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(18, 340);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(77, 19);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "Date Listed";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(18, 284);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(81, 19);
            this.materialLabel6.TabIndex = 18;
            this.materialLabel6.Text = "Age or Stage";
            // 
            // txtAgeOrStage
            // 
            this.txtAgeOrStage.AnimateReadOnly = false;
            this.txtAgeOrStage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgeOrStage.Depth = 0;
            this.txtAgeOrStage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAgeOrStage.LeadingIcon = null;
            this.txtAgeOrStage.Location = new System.Drawing.Point(144, 284);
            this.txtAgeOrStage.MaxLength = 50;
            this.txtAgeOrStage.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAgeOrStage.Multiline = false;
            this.txtAgeOrStage.Name = "txtAgeOrStage";
            this.txtAgeOrStage.Size = new System.Drawing.Size(351, 50);
            this.txtAgeOrStage.TabIndex = 17;
            this.txtAgeOrStage.Text = "";
            this.txtAgeOrStage.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(18, 228);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(76, 19);
            this.materialLabel5.TabIndex = 16;
            this.materialLabel5.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.AnimateReadOnly = false;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Depth = 0;
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescription.LeadingIcon = null;
            this.txtDescription.Location = new System.Drawing.Point(144, 228);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(351, 50);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.Text = "";
            this.txtDescription.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(18, 14);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(55, 19);
            this.materialLabel9.TabIndex = 14;
            this.materialLabel9.Text = "Plant ID";
            // 
            // txtPlantID
            // 
            this.txtPlantID.AnimateReadOnly = false;
            this.txtPlantID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlantID.Depth = 0;
            this.txtPlantID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlantID.LeadingIcon = null;
            this.txtPlantID.Location = new System.Drawing.Point(144, 14);
            this.txtPlantID.MaxLength = 50;
            this.txtPlantID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPlantID.Multiline = false;
            this.txtPlantID.Name = "txtPlantID";
            this.txtPlantID.ReadOnly = true;
            this.txtPlantID.Size = new System.Drawing.Size(351, 50);
            this.txtPlantID.TabIndex = 13;
            this.txtPlantID.Text = "";
            this.txtPlantID.TrailingIcon = null;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = false;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(390, 440);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 36);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = true;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.Enabled = false;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(262, 440);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 36);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = false;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(144, 440);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 36);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(18, 440);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(18, 182);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(41, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Owner";
            // 
            // cmbUser
            // 
            this.cmbUser.AutoResize = false;
            this.cmbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbUser.Depth = 0;
            this.cmbUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbUser.DropDownHeight = 174;
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.DropDownWidth = 121;
            this.cmbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.IntegralHeight = false;
            this.cmbUser.ItemHeight = 43;
            this.cmbUser.Location = new System.Drawing.Point(144, 173);
            this.cmbUser.MaxDropDownItems = 4;
            this.cmbUser.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(169, 49);
            this.cmbUser.StartIndex = 0;
            this.cmbUser.TabIndex = 7;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(18, 126);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(35, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Type";
            // 
            // cmbPlantType
            // 
            this.cmbPlantType.AutoResize = false;
            this.cmbPlantType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPlantType.Depth = 0;
            this.cmbPlantType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPlantType.DropDownHeight = 174;
            this.cmbPlantType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlantType.DropDownWidth = 121;
            this.cmbPlantType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPlantType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPlantType.FormattingEnabled = true;
            this.cmbPlantType.IntegralHeight = false;
            this.cmbPlantType.ItemHeight = 43;
            this.cmbPlantType.Location = new System.Drawing.Point(144, 118);
            this.cmbPlantType.MaxDropDownItems = 4;
            this.cmbPlantType.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPlantType.Name = "cmbPlantType";
            this.cmbPlantType.Size = new System.Drawing.Size(351, 49);
            this.cmbPlantType.StartIndex = 0;
            this.cmbPlantType.TabIndex = 5;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(18, 70);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(42, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Name";
            // 
            // txtPlantName
            // 
            this.txtPlantName.AnimateReadOnly = false;
            this.txtPlantName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlantName.Depth = 0;
            this.txtPlantName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlantName.LeadingIcon = null;
            this.txtPlantName.Location = new System.Drawing.Point(144, 70);
            this.txtPlantName.MaxLength = 100;
            this.txtPlantName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPlantName.Multiline = false;
            this.txtPlantName.Name = "txtPlantName";
            this.txtPlantName.Size = new System.Drawing.Size(351, 50);
            this.txtPlantName.TabIndex = 3;
            this.txtPlantName.Text = "";
            this.txtPlantName.TrailingIcon = null;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.cmbSearchPlantType);
            this.materialCard3.Controls.Add(this.btnFindPlantsByLocation);
            this.materialCard3.Controls.Add(this.btnFindAvailablePlants);
            this.materialCard3.Controls.Add(this.btnSearchByType);
            this.materialCard3.Controls.Add(this.materialLabel10);
            this.materialCard3.Controls.Add(this.txtSearchLocation);
            this.materialCard3.Controls.Add(this.materialLabel11);
            this.materialCard3.Controls.Add(this.materialLabel1);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(546, 342);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(337, 480);
            this.materialCard3.TabIndex = 2;
            // 
            // cmbSearchPlantType
            // 
            this.cmbSearchPlantType.AutoResize = false;
            this.cmbSearchPlantType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSearchPlantType.Depth = 0;
            this.cmbSearchPlantType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSearchPlantType.DropDownHeight = 174;
            this.cmbSearchPlantType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchPlantType.DropDownWidth = 121;
            this.cmbSearchPlantType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSearchPlantType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSearchPlantType.FormattingEnabled = true;
            this.cmbSearchPlantType.IntegralHeight = false;
            this.cmbSearchPlantType.ItemHeight = 43;
            this.cmbSearchPlantType.Location = new System.Drawing.Point(17, 70);
            this.cmbSearchPlantType.MaxDropDownItems = 4;
            this.cmbSearchPlantType.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSearchPlantType.Name = "cmbSearchPlantType";
            this.cmbSearchPlantType.Size = new System.Drawing.Size(303, 49);
            this.cmbSearchPlantType.StartIndex = 0;
            this.cmbSearchPlantType.TabIndex = 17;
            // 
            // btnFindPlantsByLocation
            // 
            this.btnFindPlantsByLocation.AutoSize = false;
            this.btnFindPlantsByLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindPlantsByLocation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFindPlantsByLocation.Depth = 0;
            this.btnFindPlantsByLocation.HighEmphasis = true;
            this.btnFindPlantsByLocation.Icon = null;
            this.btnFindPlantsByLocation.Location = new System.Drawing.Point(17, 228);
            this.btnFindPlantsByLocation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindPlantsByLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFindPlantsByLocation.Name = "btnFindPlantsByLocation";
            this.btnFindPlantsByLocation.Size = new System.Drawing.Size(303, 36);
            this.btnFindPlantsByLocation.TabIndex = 16;
            this.btnFindPlantsByLocation.Text = "SEARCH BY LOCATION";
            this.btnFindPlantsByLocation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFindPlantsByLocation.UseAccentColor = false;
            this.btnFindPlantsByLocation.UseVisualStyleBackColor = true;
            this.btnFindPlantsByLocation.Click += new System.EventHandler(this.btnFindPlantsByLocation_Click);
            // 
            // btnFindAvailablePlants
            // 
            this.btnFindAvailablePlants.AutoSize = false;
            this.btnFindAvailablePlants.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindAvailablePlants.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFindAvailablePlants.Depth = 0;
            this.btnFindAvailablePlants.HighEmphasis = true;
            this.btnFindAvailablePlants.Icon = null;
            this.btnFindAvailablePlants.Location = new System.Drawing.Point(17, 276);
            this.btnFindAvailablePlants.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindAvailablePlants.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFindAvailablePlants.Name = "btnFindAvailablePlants";
            this.btnFindAvailablePlants.Size = new System.Drawing.Size(303, 36);
            this.btnFindAvailablePlants.TabIndex = 15;
            this.btnFindAvailablePlants.Text = "FIND AVAILABLE PLANTS";
            this.btnFindAvailablePlants.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFindAvailablePlants.UseAccentColor = false;
            this.btnFindAvailablePlants.UseVisualStyleBackColor = true;
            this.btnFindAvailablePlants.Click += new System.EventHandler(this.btnFindAvailablePlants_Click);
            // 
            // btnSearchByType
            // 
            this.btnSearchByType.AutoSize = false;
            this.btnSearchByType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchByType.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearchByType.Depth = 0;
            this.btnSearchByType.HighEmphasis = true;
            this.btnSearchByType.Icon = null;
            this.btnSearchByType.Location = new System.Drawing.Point(17, 125);
            this.btnSearchByType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearchByType.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchByType.Name = "btnSearchByType";
            this.btnSearchByType.Size = new System.Drawing.Size(303, 36);
            this.btnSearchByType.TabIndex = 14;
            this.btnSearchByType.Text = "SEARCH BY TYPE";
            this.btnSearchByType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearchByType.UseAccentColor = false;
            this.btnSearchByType.UseVisualStyleBackColor = true;
            this.btnSearchByType.Click += new System.EventHandler(this.btnSearchByType_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(17, 48);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(71, 19);
            this.materialLabel10.TabIndex = 13;
            this.materialLabel10.Text = "Plant Type";
            // 
            // txtSearchLocation
            // 
            this.txtSearchLocation.AnimateReadOnly = false;
            this.txtSearchLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchLocation.Depth = 0;
            this.txtSearchLocation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchLocation.LeadingIcon = null;
            this.txtSearchLocation.Location = new System.Drawing.Point(17, 173);
            this.txtSearchLocation.MaxLength = 100;
            this.txtSearchLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchLocation.Multiline = false;
            this.txtSearchLocation.Name = "txtSearchLocation";
            this.txtSearchLocation.Size = new System.Drawing.Size(303, 50);
            this.txtSearchLocation.TabIndex = 12;
            this.txtSearchLocation.Text = "";
            this.txtSearchLocation.TrailingIcon = null;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(17, 151);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(98, 19);
            this.materialLabel11.TabIndex = 11;
            this.materialLabel11.Text = "Owner Location";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(303, 30);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Advanced Search";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 835);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "PlantsForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.Text = "Plant Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlantsForm_FormClosing);
            this.Load += new System.EventHandler(this.PlantsForm_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlants)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridView dgvPlants;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cmbUser;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cmbPlantType;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtPlantName;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txtPlantID;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txtAgeOrStage;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DateTimePicker dtpDateListed;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox cmbStatus;
        private MaterialSkin.Controls.MaterialButton btnFindPlantsByLocation;
        private MaterialSkin.Controls.MaterialButton btnFindAvailablePlants;
        private MaterialSkin.Controls.MaterialButton btnSearchByType;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox txtSearchLocation;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialComboBox cmbSearchPlantType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlantType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeOrStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateListed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private MaterialSkin.Controls.MaterialButton btnPlantCare;
    }
}