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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            dgvPlants = new DataGridView();
            PlantID = new DataGridViewTextBoxColumn();
            PlantName = new DataGridViewTextBoxColumn();
            PlantType = new DataGridViewTextBoxColumn();
            Owner = new DataGridViewTextBoxColumn();
            AgeOrStage = new DataGridViewTextBoxColumn();
            DateListed = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            btnPlantCare = new MaterialSkin.Controls.MaterialButton();
            cmbStatus = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            dtpDateListed = new DateTimePicker();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            txtAgeOrStage = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            txtDescription = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            txtPlantID = new MaterialSkin.Controls.MaterialTextBox();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            cmbUser = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            cmbPlantType = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            txtPlantName = new MaterialSkin.Controls.MaterialTextBox();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            cmbSearchPlantType = new MaterialSkin.Controls.MaterialComboBox();
            btnFindPlantsByLocation = new MaterialSkin.Controls.MaterialButton();
            btnFindAvailablePlants = new MaterialSkin.Controls.MaterialButton();
            btnSearchByType = new MaterialSkin.Controls.MaterialButton();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            txtSearchLocation = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlants).BeginInit();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(dgvPlants);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(866, 250);
            materialCard1.TabIndex = 0;
            // 
            // dgvPlants
            // 
            dgvPlants.AllowUserToAddRows = false;
            dgvPlants.AllowUserToDeleteRows = false;
            dgvPlants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlants.Columns.AddRange(new DataGridViewColumn[] { PlantID, PlantName, PlantType, Owner, AgeOrStage, DateListed, Status, Description });
            dgvPlants.Dock = DockStyle.Fill;
            dgvPlants.Location = new Point(14, 14);
            dgvPlants.Name = "dgvPlants";
            dgvPlants.ReadOnly = true;
            dgvPlants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlants.Size = new Size(838, 222);
            dgvPlants.TabIndex = 0;
            dgvPlants.CellClick += dgvPlants_CellClick;
            // 
            // PlantID
            // 
            PlantID.HeaderText = "ID";
            PlantID.Name = "PlantID";
            PlantID.ReadOnly = true;
            PlantID.Width = 50;
            // 
            // PlantName
            // 
            PlantName.HeaderText = "Name";
            PlantName.Name = "PlantName";
            PlantName.ReadOnly = true;
            PlantName.Width = 120;
            // 
            // PlantType
            // 
            PlantType.HeaderText = "Type";
            PlantType.Name = "PlantType";
            PlantType.ReadOnly = true;
            PlantType.Width = 120;
            // 
            // Owner
            // 
            Owner.HeaderText = "Owner";
            Owner.Name = "Owner";
            Owner.ReadOnly = true;
            // 
            // AgeOrStage
            // 
            AgeOrStage.HeaderText = "Age/Stage";
            AgeOrStage.Name = "AgeOrStage";
            AgeOrStage.ReadOnly = true;
            // 
            // DateListed
            // 
            DateListed.HeaderText = "Date Listed";
            DateListed.Name = "DateListed";
            DateListed.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 150;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(btnPlantCare);
            materialCard2.Controls.Add(cmbStatus);
            materialCard2.Controls.Add(materialLabel8);
            materialCard2.Controls.Add(dtpDateListed);
            materialCard2.Controls.Add(materialLabel7);
            materialCard2.Controls.Add(materialLabel6);
            materialCard2.Controls.Add(txtAgeOrStage);
            materialCard2.Controls.Add(materialLabel5);
            materialCard2.Controls.Add(txtDescription);
            materialCard2.Controls.Add(materialLabel9);
            materialCard2.Controls.Add(txtPlantID);
            materialCard2.Controls.Add(btnClear);
            materialCard2.Controls.Add(btnDelete);
            materialCard2.Controls.Add(btnUpdate);
            materialCard2.Controls.Add(btnAdd);
            materialCard2.Controls.Add(materialLabel4);
            materialCard2.Controls.Add(cmbUser);
            materialCard2.Controls.Add(materialLabel3);
            materialCard2.Controls.Add(cmbPlantType);
            materialCard2.Controls.Add(materialLabel2);
            materialCard2.Controls.Add(txtPlantName);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(17, 342);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(511, 480);
            materialCard2.TabIndex = 1;
            // 
            // btnPlantCare
            // 
            btnPlantCare.AutoSize = false;
            btnPlantCare.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPlantCare.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPlantCare.Depth = 0;
            btnPlantCare.HighEmphasis = true;
            btnPlantCare.Icon = null;
            btnPlantCare.Location = new Point(320, 182);
            btnPlantCare.Margin = new Padding(4, 6, 4, 6);
            btnPlantCare.MouseState = MaterialSkin.MouseState.HOVER;
            btnPlantCare.Name = "btnPlantCare";
            btnPlantCare.NoAccentTextColor = Color.Empty;
            btnPlantCare.Size = new Size(175, 36);
            btnPlantCare.TabIndex = 23;
            btnPlantCare.Text = "VIEW CARE INFO";
            btnPlantCare.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPlantCare.UseAccentColor = true;
            btnPlantCare.UseVisualStyleBackColor = true;
            btnPlantCare.Click += btnPlantCare_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.AutoResize = false;
            cmbStatus.BackColor = Color.FromArgb(255, 255, 255);
            cmbStatus.Depth = 0;
            cmbStatus.DrawMode = DrawMode.OwnerDrawVariable;
            cmbStatus.DropDownHeight = 174;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.DropDownWidth = 121;
            cmbStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.IntegralHeight = false;
            cmbStatus.ItemHeight = 43;
            cmbStatus.Location = new Point(144, 381);
            cmbStatus.MaxDropDownItems = 4;
            cmbStatus.MouseState = MaterialSkin.MouseState.OUT;
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(351, 49);
            cmbStatus.StartIndex = 0;
            cmbStatus.TabIndex = 22;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(18, 396);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(47, 19);
            materialLabel8.TabIndex = 21;
            materialLabel8.Text = "Status";
            // 
            // dtpDateListed
            // 
            dtpDateListed.Location = new Point(144, 340);
            dtpDateListed.Name = "dtpDateListed";
            dtpDateListed.Size = new Size(351, 23);
            dtpDateListed.TabIndex = 20;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(18, 340);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(81, 19);
            materialLabel7.TabIndex = 19;
            materialLabel7.Text = "Date Listed";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(18, 284);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(91, 19);
            materialLabel6.TabIndex = 18;
            materialLabel6.Text = "Age or Stage";
            // 
            // txtAgeOrStage
            // 
            txtAgeOrStage.AnimateReadOnly = false;
            txtAgeOrStage.BorderStyle = BorderStyle.None;
            txtAgeOrStage.Depth = 0;
            txtAgeOrStage.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAgeOrStage.LeadingIcon = null;
            txtAgeOrStage.Location = new Point(144, 284);
            txtAgeOrStage.MaxLength = 50;
            txtAgeOrStage.MouseState = MaterialSkin.MouseState.OUT;
            txtAgeOrStage.Multiline = false;
            txtAgeOrStage.Name = "txtAgeOrStage";
            txtAgeOrStage.Size = new Size(351, 50);
            txtAgeOrStage.TabIndex = 17;
            txtAgeOrStage.Text = "";
            txtAgeOrStage.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(18, 228);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(81, 19);
            materialLabel5.TabIndex = 16;
            materialLabel5.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Depth = 0;
            txtDescription.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescription.LeadingIcon = null;
            txtDescription.Location = new Point(144, 228);
            txtDescription.MaxLength = 500;
            txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            txtDescription.Multiline = false;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(351, 50);
            txtDescription.TabIndex = 15;
            txtDescription.Text = "";
            txtDescription.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(18, 14);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(57, 19);
            materialLabel9.TabIndex = 14;
            materialLabel9.Text = "Plant ID";
            // 
            // txtPlantID
            // 
            txtPlantID.AnimateReadOnly = false;
            txtPlantID.BorderStyle = BorderStyle.None;
            txtPlantID.Depth = 0;
            txtPlantID.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPlantID.LeadingIcon = null;
            txtPlantID.Location = new Point(144, 14);
            txtPlantID.MaxLength = 50;
            txtPlantID.MouseState = MaterialSkin.MouseState.OUT;
            txtPlantID.Multiline = false;
            txtPlantID.Name = "txtPlantID";
            txtPlantID.ReadOnly = true;
            txtPlantID.Size = new Size(351, 50);
            txtPlantID.TabIndex = 13;
            txtPlantID.Text = "";
            txtPlantID.TrailingIcon = null;
            // 
            // btnClear
            // 
            btnClear.AutoSize = false;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(390, 440);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(105, 36);
            btnClear.TabIndex = 12;
            btnClear.Text = "CLEAR";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = true;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = false;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.Enabled = false;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(262, 440);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(105, 36);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "DELETE";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = false;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.Enabled = false;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(144, 440);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(105, 36);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = false;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(18, 440);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(105, 36);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(18, 182);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(46, 19);
            materialLabel4.TabIndex = 8;
            materialLabel4.Text = "Owner";
            // 
            // cmbUser
            // 
            cmbUser.AutoResize = false;
            cmbUser.BackColor = Color.FromArgb(255, 255, 255);
            cmbUser.Depth = 0;
            cmbUser.DrawMode = DrawMode.OwnerDrawVariable;
            cmbUser.DropDownHeight = 174;
            cmbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUser.DropDownWidth = 121;
            cmbUser.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbUser.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbUser.FormattingEnabled = true;
            cmbUser.IntegralHeight = false;
            cmbUser.ItemHeight = 43;
            cmbUser.Location = new Point(144, 173);
            cmbUser.MaxDropDownItems = 4;
            cmbUser.MouseState = MaterialSkin.MouseState.OUT;
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(169, 49);
            cmbUser.StartIndex = 0;
            cmbUser.TabIndex = 7;
            cmbUser.SelectedIndexChanged += cmbUser_SelectedIndexChanged;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(18, 126);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(36, 19);
            materialLabel3.TabIndex = 6;
            materialLabel3.Text = "Type";
            // 
            // cmbPlantType
            // 
            cmbPlantType.AutoResize = false;
            cmbPlantType.BackColor = Color.FromArgb(255, 255, 255);
            cmbPlantType.Depth = 0;
            cmbPlantType.DrawMode = DrawMode.OwnerDrawVariable;
            cmbPlantType.DropDownHeight = 174;
            cmbPlantType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlantType.DropDownWidth = 121;
            cmbPlantType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbPlantType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbPlantType.FormattingEnabled = true;
            cmbPlantType.IntegralHeight = false;
            cmbPlantType.ItemHeight = 43;
            cmbPlantType.Location = new Point(144, 118);
            cmbPlantType.MaxDropDownItems = 4;
            cmbPlantType.MouseState = MaterialSkin.MouseState.OUT;
            cmbPlantType.Name = "cmbPlantType";
            cmbPlantType.Size = new Size(351, 49);
            cmbPlantType.StartIndex = 0;
            cmbPlantType.TabIndex = 5;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(18, 70);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(43, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Name";
            // 
            // txtPlantName
            // 
            txtPlantName.AnimateReadOnly = false;
            txtPlantName.BorderStyle = BorderStyle.None;
            txtPlantName.Depth = 0;
            txtPlantName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPlantName.LeadingIcon = null;
            txtPlantName.Location = new Point(144, 70);
            txtPlantName.MaxLength = 100;
            txtPlantName.MouseState = MaterialSkin.MouseState.OUT;
            txtPlantName.Multiline = false;
            txtPlantName.Name = "txtPlantName";
            txtPlantName.Size = new Size(351, 50);
            txtPlantName.TabIndex = 3;
            txtPlantName.Text = "";
            txtPlantName.TrailingIcon = null;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(cmbSearchPlantType);
            materialCard3.Controls.Add(btnFindPlantsByLocation);
            materialCard3.Controls.Add(btnFindAvailablePlants);
            materialCard3.Controls.Add(btnSearchByType);
            materialCard3.Controls.Add(materialLabel10);
            materialCard3.Controls.Add(txtSearchLocation);
            materialCard3.Controls.Add(materialLabel11);
            materialCard3.Controls.Add(materialLabel1);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(546, 342);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(337, 480);
            materialCard3.TabIndex = 2;
            // 
            // cmbSearchPlantType
            // 
            cmbSearchPlantType.AutoResize = false;
            cmbSearchPlantType.BackColor = Color.FromArgb(255, 255, 255);
            cmbSearchPlantType.Depth = 0;
            cmbSearchPlantType.DrawMode = DrawMode.OwnerDrawVariable;
            cmbSearchPlantType.DropDownHeight = 174;
            cmbSearchPlantType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchPlantType.DropDownWidth = 121;
            cmbSearchPlantType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbSearchPlantType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbSearchPlantType.FormattingEnabled = true;
            cmbSearchPlantType.IntegralHeight = false;
            cmbSearchPlantType.ItemHeight = 43;
            cmbSearchPlantType.Location = new Point(17, 70);
            cmbSearchPlantType.MaxDropDownItems = 4;
            cmbSearchPlantType.MouseState = MaterialSkin.MouseState.OUT;
            cmbSearchPlantType.Name = "cmbSearchPlantType";
            cmbSearchPlantType.Size = new Size(303, 49);
            cmbSearchPlantType.StartIndex = 0;
            cmbSearchPlantType.TabIndex = 17;
            // 
            // btnFindPlantsByLocation
            // 
            btnFindPlantsByLocation.AutoSize = false;
            btnFindPlantsByLocation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFindPlantsByLocation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFindPlantsByLocation.Depth = 0;
            btnFindPlantsByLocation.HighEmphasis = true;
            btnFindPlantsByLocation.Icon = null;
            btnFindPlantsByLocation.Location = new Point(17, 228);
            btnFindPlantsByLocation.Margin = new Padding(4, 6, 4, 6);
            btnFindPlantsByLocation.MouseState = MaterialSkin.MouseState.HOVER;
            btnFindPlantsByLocation.Name = "btnFindPlantsByLocation";
            btnFindPlantsByLocation.NoAccentTextColor = Color.Empty;
            btnFindPlantsByLocation.Size = new Size(303, 36);
            btnFindPlantsByLocation.TabIndex = 16;
            btnFindPlantsByLocation.Text = "SEARCH BY LOCATION";
            btnFindPlantsByLocation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFindPlantsByLocation.UseAccentColor = false;
            btnFindPlantsByLocation.UseVisualStyleBackColor = true;
            btnFindPlantsByLocation.Click += btnFindPlantsByLocation_Click;
            // 
            // btnFindAvailablePlants
            // 
            btnFindAvailablePlants.AutoSize = false;
            btnFindAvailablePlants.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFindAvailablePlants.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFindAvailablePlants.Depth = 0;
            btnFindAvailablePlants.HighEmphasis = true;
            btnFindAvailablePlants.Icon = null;
            btnFindAvailablePlants.Location = new Point(17, 276);
            btnFindAvailablePlants.Margin = new Padding(4, 6, 4, 6);
            btnFindAvailablePlants.MouseState = MaterialSkin.MouseState.HOVER;
            btnFindAvailablePlants.Name = "btnFindAvailablePlants";
            btnFindAvailablePlants.NoAccentTextColor = Color.Empty;
            btnFindAvailablePlants.Size = new Size(303, 36);
            btnFindAvailablePlants.TabIndex = 15;
            btnFindAvailablePlants.Text = "FIND AVAILABLE PLANTS";
            btnFindAvailablePlants.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFindAvailablePlants.UseAccentColor = false;
            btnFindAvailablePlants.UseVisualStyleBackColor = true;
            btnFindAvailablePlants.Click += btnFindAvailablePlants_Click;
            // 
            // btnSearchByType
            // 
            btnSearchByType.AutoSize = false;
            btnSearchByType.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearchByType.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearchByType.Depth = 0;
            btnSearchByType.HighEmphasis = true;
            btnSearchByType.Icon = null;
            btnSearchByType.Location = new Point(16, 112);
            btnSearchByType.Margin = new Padding(4, 6, 4, 6);
            btnSearchByType.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearchByType.Name = "btnSearchByType";
            btnSearchByType.NoAccentTextColor = Color.Empty;
            btnSearchByType.Size = new Size(303, 36);
            btnSearchByType.TabIndex = 14;
            btnSearchByType.Text = "SEARCH BY TYPE";
            btnSearchByType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearchByType.UseAccentColor = false;
            btnSearchByType.UseVisualStyleBackColor = true;
            btnSearchByType.Click += btnSearchByType_Click;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(17, 48);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(77, 19);
            materialLabel10.TabIndex = 13;
            materialLabel10.Text = "Plant Type";
            // 
            // txtSearchLocation
            // 
            txtSearchLocation.AnimateReadOnly = false;
            txtSearchLocation.BorderStyle = BorderStyle.None;
            txtSearchLocation.Depth = 0;
            txtSearchLocation.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearchLocation.LeadingIcon = null;
            txtSearchLocation.Location = new Point(17, 173);
            txtSearchLocation.MaxLength = 100;
            txtSearchLocation.MouseState = MaterialSkin.MouseState.OUT;
            txtSearchLocation.Multiline = false;
            txtSearchLocation.Name = "txtSearchLocation";
            txtSearchLocation.Size = new Size(303, 50);
            txtSearchLocation.TabIndex = 12;
            txtSearchLocation.Text = "";
            txtSearchLocation.TrailingIcon = null;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(17, 151);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(112, 19);
            materialLabel11.TabIndex = 11;
            materialLabel11.Text = "Owner Location";
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(20, 7);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(303, 30);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Advanced Search";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlantsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 835);
            Controls.Add(materialCard3);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Name = "PlantsForm";
            Text = "Plant Management";
            FormClosing += PlantsForm_FormClosing;
            Load += PlantsForm_Load;
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPlants).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ResumeLayout(false);
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