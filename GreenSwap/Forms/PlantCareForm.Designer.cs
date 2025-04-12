namespace GreenSwap
{
    partial class PlantCareForm
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
            this.dgvPlantCare = new System.Windows.Forms.DataGridView();
            this.InfoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlantTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WateringFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LightRequirements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoilPreferences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrowthHabits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommonIssues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lblInfoID = new MaterialSkin.Controls.MaterialLabel();
            this.txtInfoID = new MaterialSkin.Controls.MaterialTextBox();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.lblCommonIssues = new MaterialSkin.Controls.MaterialLabel();
            this.txtCommonIssues = new MaterialSkin.Controls.MaterialTextBox();
            this.lblGrowthHabits = new MaterialSkin.Controls.MaterialLabel();
            this.txtGrowthHabits = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDifficulty = new MaterialSkin.Controls.MaterialLabel();
            this.cmbDifficulty = new MaterialSkin.Controls.MaterialComboBox();
            this.lblSoil = new MaterialSkin.Controls.MaterialLabel();
            this.txtSoil = new MaterialSkin.Controls.MaterialTextBox();
            this.lblLight = new MaterialSkin.Controls.MaterialLabel();
            this.txtLight = new MaterialSkin.Controls.MaterialTextBox();
            this.lblWatering = new MaterialSkin.Controls.MaterialLabel();
            this.txtWatering = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPlantType = new MaterialSkin.Controls.MaterialLabel();
            this.txtPlantType = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnFindHardestPlants = new MaterialSkin.Controls.MaterialButton();
            this.btnFindPopularTypes = new MaterialSkin.Controls.MaterialButton();
            this.btnFindEasyPlants = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantCare)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvPlantCare);
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
            // dgvPlantCare
            // 
            this.dgvPlantCare.AllowUserToAddRows = false;
            this.dgvPlantCare.AllowUserToDeleteRows = false;
            this.dgvPlantCare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlantCare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InfoID,
            this.PlantTypeName,
            this.WateringFrequency,
            this.LightRequirements,
            this.SoilPreferences,
            this.DifficultyLevel,
            this.GrowthHabits,
            this.CommonIssues});
            this.dgvPlantCare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlantCare.Location = new System.Drawing.Point(14, 14);
            this.dgvPlantCare.Name = "dgvPlantCare";
            this.dgvPlantCare.ReadOnly = true;
            this.dgvPlantCare.RowTemplate.Height = 25;
            this.dgvPlantCare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlantCare.Size = new System.Drawing.Size(838, 222);
            this.dgvPlantCare.TabIndex = 0;   
            // InfoID
            // 
            this.InfoID.HeaderText = "ID";
            this.InfoID.Name = "InfoID";
            this.InfoID.ReadOnly = true;
            this.InfoID.Width = 50;
            // 
            // PlantTypeName
            // 
            this.PlantTypeName.HeaderText = "Plant Type";
            this.PlantTypeName.Name = "PlantTypeName";
            this.PlantTypeName.ReadOnly = true;
            this.PlantTypeName.Width = 120;
            // 
            // WateringFrequency
            // 
            this.WateringFrequency.HeaderText = "Watering";
            this.WateringFrequency.Name = "WateringFrequency";
            this.WateringFrequency.ReadOnly = true;
            this.WateringFrequency.Width = 110;
            // 
            // LightRequirements
            // 
            this.LightRequirements.HeaderText = "Light";
            this.LightRequirements.Name = "LightRequirements";
            this.LightRequirements.ReadOnly = true;
            this.LightRequirements.Width = 110;
            // 
            // SoilPreferences
            // 
            this.SoilPreferences.HeaderText = "Soil";
            this.SoilPreferences.Name = "SoilPreferences";
            this.SoilPreferences.ReadOnly = true;
            this.SoilPreferences.Width = 110;
            // 
            // DifficultyLevel
            // 
            this.DifficultyLevel.HeaderText = "Difficulty";
            this.DifficultyLevel.Name = "DifficultyLevel";
            this.DifficultyLevel.ReadOnly = true;
            this.DifficultyLevel.Width = 70;
            // 
            // GrowthHabits
            // 
            this.GrowthHabits.HeaderText = "Growth Habits";
            this.GrowthHabits.Name = "GrowthHabits";
            this.GrowthHabits.ReadOnly = true;
            this.GrowthHabits.Width = 130;
            // 
            // CommonIssues
            // 
            this.CommonIssues.HeaderText = "Common Issues";
            this.CommonIssues.Name = "CommonIssues";
            this.CommonIssues.ReadOnly = true;
            this.CommonIssues.Width = 130;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblInfoID);
            this.materialCard2.Controls.Add(this.txtInfoID);
            this.materialCard2.Controls.Add(this.btnClear);
            this.materialCard2.Controls.Add(this.btnDelete);
            this.materialCard2.Controls.Add(this.btnUpdate);
            this.materialCard2.Controls.Add(this.btnAdd);
            this.materialCard2.Controls.Add(this.lblCommonIssues);
            this.materialCard2.Controls.Add(this.txtCommonIssues);
            this.materialCard2.Controls.Add(this.lblGrowthHabits);
            this.materialCard2.Controls.Add(this.txtGrowthHabits);
            this.materialCard2.Controls.Add(this.lblDifficulty);
            this.materialCard2.Controls.Add(this.cmbDifficulty);
            this.materialCard2.Controls.Add(this.lblSoil);
            this.materialCard2.Controls.Add(this.txtSoil);
            this.materialCard2.Controls.Add(this.lblLight);
            this.materialCard2.Controls.Add(this.txtLight);
            this.materialCard2.Controls.Add(this.lblWatering);
            this.materialCard2.Controls.Add(this.txtWatering);
            this.materialCard2.Controls.Add(this.lblPlantType);
            this.materialCard2.Controls.Add(this.txtPlantType);
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
            // lblInfoID
            // 
            this.lblInfoID.AutoSize = true;
            this.lblInfoID.Depth = 0;
            this.lblInfoID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblInfoID.Location = new System.Drawing.Point(17, 15);
            this.lblInfoID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInfoID.Name = "lblInfoID";
            this.lblInfoID.Size = new System.Drawing.Size(47, 19);
            this.lblInfoID.TabIndex = 19;
            this.lblInfoID.Text = "Info ID";
            // 
            // txtInfoID
            // 
            this.txtInfoID.AnimateReadOnly = false;
            this.txtInfoID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfoID.Depth = 0;
            this.txtInfoID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfoID.LeadingIcon = null;
            this.txtInfoID.Location = new System.Drawing.Point(144, 15);
            this.txtInfoID.MaxLength = 50;
            this.txtInfoID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInfoID.Multiline = false;
            this.txtInfoID.Name = "txtInfoID";
            this.txtInfoID.ReadOnly = true;
            this.txtInfoID.Size = new System.Drawing.Size(351, 50);
            this.txtInfoID.TabIndex = 18;
            this.txtInfoID.Text = "";
            this.txtInfoID.TrailingIcon = null;
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
            this.btnClear.TabIndex = 17;
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
            this.btnDelete.TabIndex = 16;
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
            this.btnUpdate.TabIndex = 15;
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
            this.btnAdd.Location = new System.Drawing.Point(17, 440);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 36);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCommonIssues
            // 
            this.lblCommonIssues.AutoSize = true;
            this.lblCommonIssues.Depth = 0;
            this.lblCommonIssues.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCommonIssues.Location = new System.Drawing.Point(17, 387);
            this.lblCommonIssues.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCommonIssues.Name = "lblCommonIssues";
            this.lblCommonIssues.Size = new System.Drawing.Size(108, 19);
            this.lblCommonIssues.TabIndex = 13;
            this.lblCommonIssues.Text = "Common Issues";
            // 
            // txtCommonIssues
            // 
            this.txtCommonIssues.AnimateReadOnly = false;
            this.txtCommonIssues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCommonIssues.Depth = 0;
            this.txtCommonIssues.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCommonIssues.LeadingIcon = null;
            this.txtCommonIssues.Location = new System.Drawing.Point(144, 387);
            this.txtCommonIssues.MaxLength = 500;
            this.txtCommonIssues.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCommonIssues.Multiline = false;
            this.txtCommonIssues.Name = "txtCommonIssues";
            this.txtCommonIssues.Size = new System.Drawing.Size(351, 50);
            this.txtCommonIssues.TabIndex = 12;
            this.txtCommonIssues.Text = "";
            this.txtCommonIssues.TrailingIcon = null;
            // 
            // lblGrowthHabits
            // 
            this.lblGrowthHabits.AutoSize = true;
            this.lblGrowthHabits.Depth = 0;
            this.lblGrowthHabits.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGrowthHabits.Location = new System.Drawing.Point(17, 334);
            this.lblGrowthHabits.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGrowthHabits.Name = "lblGrowthHabits";
            this.lblGrowthHabits.Size = new System.Drawing.Size(96, 19);
            this.lblGrowthHabits.TabIndex = 11;
            this.lblGrowthHabits.Text = "Growth Habits";
            // 
            // txtGrowthHabits
            // 
            this.txtGrowthHabits.AnimateReadOnly = false;
            this.txtGrowthHabits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrowthHabits.Depth = 0;
            this.txtGrowthHabits.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGrowthHabits.LeadingIcon = null;
            this.txtGrowthHabits.Location = new System.Drawing.Point(144, 334);
            this.txtGrowthHabits.MaxLength = 500;
            this.txtGrowthHabits.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGrowthHabits.Multiline = false;
            this.txtGrowthHabits.Name = "txtGrowthHabits";
            this.txtGrowthHabits.Size = new System.Drawing.Size(351, 50);
            this.txtGrowthHabits.TabIndex = 10;
            this.txtGrowthHabits.Text = "";
            this.txtGrowthHabits.TrailingIcon = null;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Depth = 0;
            this.lblDifficulty.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDifficulty.Location = new System.Drawing.Point(17, 282);
            this.lblDifficulty.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(104, 19);
            this.lblDifficulty.TabIndex = 9;
            this.lblDifficulty.Text = "Difficulty Level";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.AutoResize = false;
            this.cmbDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDifficulty.Depth = 0;
            this.cmbDifficulty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDifficulty.DropDownHeight = 174;
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.DropDownWidth = 121;
            this.cmbDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.IntegralHeight = false;
            this.cmbDifficulty.ItemHeight = 43;
            this.cmbDifficulty.Location = new System.Drawing.Point(144, 282);
            this.cmbDifficulty.MaxDropDownItems = 5;
            this.cmbDifficulty.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(351, 49);
            this.cmbDifficulty.StartIndex = 0;
            this.cmbDifficulty.TabIndex = 8;
            // 
            // lblSoil
            // 
            this.lblSoil.AutoSize = true;
            this.lblSoil.Depth = 0;
            this.lblSoil.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSoil.Location = new System.Drawing.Point(17, 229);
            this.lblSoil.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSoil.Name = "lblSoil";
            this.lblSoil.Size = new System.Drawing.Size(101, 19);
            this.lblSoil.TabIndex = 7;
            this.lblSoil.Text = "Soil Preference";
            // 
            // txtSoil
            // 
            this.txtSoil.AnimateReadOnly = false;
            this.txtSoil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoil.Depth = 0;
            this.txtSoil.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoil.LeadingIcon = null;
            this.txtSoil.Location = new System.Drawing.Point(144, 229);
            this.txtSoil.MaxLength = 100;
            this.txtSoil.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoil.Multiline = false;
            this.txtSoil.Name = "txtSoil";
            this.txtSoil.Size = new System.Drawing.Size(351, 50);
            this.txtSoil.TabIndex = 6;
            this.txtSoil.Text = "";
            this.txtSoil.TrailingIcon = null;
            // 
            // lblLight
            // 
            this.lblLight.AutoSize = true;
            this.lblLight.Depth = 0;
            this.lblLight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLight.Location = new System.Drawing.Point(17, 176);
            this.lblLight.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(122, 19);
            this.lblLight.TabIndex = 5;
            this.lblLight.Text = "Light Requirement";
            // 
            // txtLight
            // 
            this.txtLight.AnimateReadOnly = false;
            this.txtLight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLight.Depth = 0;
            this.txtLight.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLight.LeadingIcon = null;
            this.txtLight.Location = new System.Drawing.Point(144, 176);
            this.txtLight.MaxLength = 100;
            this.txtLight.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLight.Multiline = false;
            this.txtLight.Name = "txtLight";
            this.txtLight.Size = new System.Drawing.Size(351, 50);
            this.txtLight.TabIndex = 4;
            this.txtLight.Text = "";
            this.txtLight.TrailingIcon = null;
            // 
            // lblWatering
            // 
            this.lblWatering.AutoSize = true;
            this.lblWatering.Depth = 0;
            this.lblWatering.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWatering.Location = new System.Drawing.Point(17, 123);
            this.lblWatering.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWatering.Name = "lblWatering";
            this.lblWatering.Size = new System.Drawing.Size(127, 19);
            this.lblWatering.TabIndex = 3;
            this.lblWatering.Text = "Watering Schedule";
            // 
            // txtWatering
            // 
            this.txtWatering.AnimateReadOnly = false;
            this.txtWatering.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWatering.Depth = 0;
            this.txtWatering.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWatering.LeadingIcon = null;
            this.txtWatering.Location = new System.Drawing.Point(144, 123);
            this.txtWatering.MaxLength = 100;
            this.txtWatering.MouseState = MaterialSkin.MouseState.OUT;
            this.txtWatering.Multiline = false;
            this.txtWatering.Name = "txtWatering";
            this.txtWatering.Size = new System.Drawing.Size(351, 50);
            this.txtWatering.TabIndex = 2;
            this.txtWatering.Text = "";
            this.txtWatering.TrailingIcon = null;
            // 
            // lblPlantType
            // 
            this.lblPlantType.AutoSize = true;
            this.lblPlantType.Depth = 0;
            this.lblPlantType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPlantType.Location = new System.Drawing.Point(17, 70);
            this.lblPlantType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPlantType.Name = "lblPlantType";
            this.lblPlantType.Size = new System.Drawing.Size(73, 19);
            this.lblPlantType.TabIndex = 1;
            this.lblPlantType.Text = "Plant Type";
            // 
            // txtPlantType
            // 
            this.txtPlantType.AnimateReadOnly = false;
            this.txtPlantType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlantType.Depth = 0;
            this.txtPlantType.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlantType.LeadingIcon = null;
            this.txtPlantType.Location = new System.Drawing.Point(144, 70);
            this.txtPlantType.MaxLength = 100;
            this.txtPlantType.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPlantType.Multiline = false;
            this.txtPlantType.Name = "txtPlantType";
            this.txtPlantType.Size = new System.Drawing.Size(351, 50);
            this.txtPlantType.TabIndex = 0;
            this.txtPlantType.Text = "";
            this.txtPlantType.TrailingIcon = null;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnFindHardestPlants);
            this.materialCard3.Controls.Add(this.btnFindPopularTypes);
            this.materialCard3.Controls.Add(this.btnFindEasyPlants);
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
            // btnFindHardestPlants
            // 
            this.btnFindHardestPlants.AutoSize = false;
            this.btnFindHardestPlants.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindHardestPlants.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFindHardestPlants.Depth = 0;
            this.btnFindHardestPlants.HighEmphasis = true;
            this.btnFindHardestPlants.Icon = null;
            this.btnFindHardestPlants.Location = new System.Drawing.Point(17, 176);
            this.btnFindHardestPlants.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindHardestPlants.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFindHardestPlants.Name = "btnFindHardestPlants";
            this.btnFindHardestPlants.Size = new System.Drawing.Size(303, 36);
            this.btnFindHardestPlants.TabIndex = 3;
            this.btnFindHardestPlants.Text = "FIND HARDEST PLANTS";
            this.btnFindHardestPlants.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFindHardestPlants.UseAccentColor = false;
            this.btnFindHardestPlants.UseVisualStyleBackColor = true;
            this.btnFindHardestPlants.Click += new System.EventHandler(this.btnFindHardestPlants_Click);
            // 
            // btnFindPopularTypes
            // 
            this.btnFindPopularTypes.AutoSize = false;
            this.btnFindPopularTypes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindPopularTypes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFindPopularTypes.Depth = 0;
            this.btnFindPopularTypes.HighEmphasis = true;
            this.btnFindPopularTypes.Icon = null;
            this.btnFindPopularTypes.Location = new System.Drawing.Point(17, 124);
            this.btnFindPopularTypes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindPopularTypes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFindPopularTypes.Name = "btnFindPopularTypes";
            this.btnFindPopularTypes.Size = new System.Drawing.Size(303, 36);
            this.btnFindPopularTypes.TabIndex = 2;
            this.btnFindPopularTypes.Text = "FIND MOST POPULAR TYPES";
            this.btnFindPopularTypes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFindPopularTypes.UseAccentColor = false;
            this.btnFindPopularTypes.UseVisualStyleBackColor = true;
            this.btnFindPopularTypes.Click += new System.EventHandler(this.btnFindPopularTypes_Click);
            // 
            // btnFindEasyPlants
            // 
            this.btnFindEasyPlants.AutoSize = false;
            this.btnFindEasyPlants.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindEasyPlants.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFindEasyPlants.Depth = 0;
            this.btnFindEasyPlants.HighEmphasis = true;
            this.btnFindEasyPlants.Icon = null;
            this.btnFindEasyPlants.Location = new System.Drawing.Point(17, 72);
            this.btnFindEasyPlants.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindEasyPlants.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFindEasyPlants.Name = "btnFindEasyPlants";
            this.btnFindEasyPlants.Size = new System.Drawing.Size(303, 36);
            this.btnFindEasyPlants.TabIndex = 1;
            this.btnFindEasyPlants.Text = "FIND EASIEST PLANTS";
            this.btnFindEasyPlants.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFindEasyPlants.UseAccentColor = false;
            this.btnFindEasyPlants.UseVisualStyleBackColor = true;
            this.btnFindEasyPlants.Click += new System.EventHandler(this.btnFindEasyPlants_Click);
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
            this.materialLabel1.Text = "Pre-defined Queries";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlantCareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 835);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "PlantCareForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.Text = "Plant Care Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlantCareForm_FormClosing);
            this.Load += new System.EventHandler(this.PlantCareForm_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantCare)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridView dgvPlantCare;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlantTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WateringFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn LightRequirements;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoilPreferences;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrowthHabits;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommonIssues;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lblInfoID;
        private MaterialSkin.Controls.MaterialTextBox txtInfoID;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialLabel lblCommonIssues;
        private MaterialSkin.Controls.MaterialTextBox txtCommonIssues;
        private MaterialSkin.Controls.MaterialLabel lblGrowthHabits;
        private MaterialSkin.Controls.MaterialTextBox txtGrowthHabits;
        private MaterialSkin.Controls.MaterialLabel lblDifficulty;
        private MaterialSkin.Controls.MaterialComboBox cmbDifficulty;
        private MaterialSkin.Controls.MaterialLabel lblSoil;
        private MaterialSkin.Controls.MaterialTextBox txtSoil;
        private MaterialSkin.Controls.MaterialLabel lblLight;
        private MaterialSkin.Controls.MaterialTextBox txtLight;
        private MaterialSkin.Controls.MaterialLabel lblWatering;
        private MaterialSkin.Controls.MaterialTextBox txtWatering;
        private MaterialSkin.Controls.MaterialLabel lblPlantType;
        private MaterialSkin.Controls.MaterialTextBox txtPlantType;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton btnFindHardestPlants;
        private MaterialSkin.Controls.MaterialButton btnFindPopularTypes;
        private MaterialSkin.Controls.MaterialButton btnFindEasyPlants;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
