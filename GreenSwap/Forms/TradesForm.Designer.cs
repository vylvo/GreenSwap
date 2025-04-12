namespace GreenSwap
{
    partial class TradesForm
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
            this.dgvTrades = new System.Windows.Forms.DataGridView();
            this.TradeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradeStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradeNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dtpCompletionDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbTradeStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTradeNotes = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTradeID = new MaterialSkin.Controls.MaterialTextBox();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPlant = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbProvider = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbRequestor = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnFindTradesByUser = new MaterialSkin.Controls.MaterialButton();
            this.btnFindCompletedTrades = new MaterialSkin.Controls.MaterialButton();
            this.btnFindPendingTrades = new MaterialSkin.Controls.MaterialButton();
            this.cmbSearchUser = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrades)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvTrades);
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
            // dgvTrades
            // 
            this.dgvTrades.AllowUserToAddRows = false;
            this.dgvTrades.AllowUserToDeleteRows = false;
            this.dgvTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TradeID,
            this.RequestorName,
            this.ProviderName,
            this.PlantName,
            this.RequestDate,
            this.TradeStatus,
            this.CompletionDate,
            this.TradeNotes});
            this.dgvTrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrades.Location = new System.Drawing.Point(14, 14);
            this.dgvTrades.Name = "dgvTrades";
            this.dgvTrades.ReadOnly = true;
            this.dgvTrades.RowTemplate.Height = 25;
            this.dgvTrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrades.Size = new System.Drawing.Size(838, 222);
            this.dgvTrades.TabIndex = 0;
            this.dgvTrades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrades_CellClick);
            // 
            // TradeID
            // 
            this.TradeID.HeaderText = "ID";
            this.TradeID.Name = "TradeID";
            this.TradeID.ReadOnly = true;
            this.TradeID.Width = 50;
            // 
            // RequestorName
            // 
            this.RequestorName.HeaderText = "Requestor";
            this.RequestorName.Name = "RequestorName";
            this.RequestorName.ReadOnly = true;
            this.RequestorName.Width = 120;
            // 
            // ProviderName
            // 
            this.ProviderName.HeaderText = "Provider";
            this.ProviderName.Name = "ProviderName";
            this.ProviderName.ReadOnly = true;
            this.ProviderName.Width = 120;
            // 
            // PlantName
            // 
            this.PlantName.HeaderText = "Plant";
            this.PlantName.Name = "PlantName";
            this.PlantName.ReadOnly = true;
            this.PlantName.Width = 120;
            // 
            // RequestDate
            // 
            this.RequestDate.HeaderText = "Request Date";
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.ReadOnly = true;
            // 
            // TradeStatus
            // 
            this.TradeStatus.HeaderText = "Status";
            this.TradeStatus.Name = "TradeStatus";
            this.TradeStatus.ReadOnly = true;
            // 
            // CompletionDate
            // 
            this.CompletionDate.HeaderText = "Completion Date";
            this.CompletionDate.Name = "CompletionDate";
            this.CompletionDate.ReadOnly = true;
            // 
            // TradeNotes
            // 
            this.TradeNotes.HeaderText = "Notes";
            this.TradeNotes.Name = "TradeNotes";
            this.TradeNotes.ReadOnly = true;
            this.TradeNotes.Width = 150;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dtpCompletionDate);
            this.materialCard2.Controls.Add(this.materialLabel8);
            this.materialCard2.Controls.Add(this.cmbTradeStatus);
            this.materialCard2.Controls.Add(this.materialLabel7);
            this.materialCard2.Controls.Add(this.dtpRequestDate);
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.txtTradeNotes);
            this.materialCard2.Controls.Add(this.materialLabel9);
            this.materialCard2.Controls.Add(this.txtTradeID);
            this.materialCard2.Controls.Add(this.btnClear);
            this.materialCard2.Controls.Add(this.btnDelete);
            this.materialCard2.Controls.Add(this.btnUpdate);
            this.materialCard2.Controls.Add(this.btnAdd);
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.cmbPlant);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.cmbProvider);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.cmbRequestor);
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
            // dtpCompletionDate
            // 
            this.dtpCompletionDate.Enabled = false;
            this.dtpCompletionDate.Location = new System.Drawing.Point(144, 340);
            this.dtpCompletionDate.Name = "dtpCompletionDate";
            this.dtpCompletionDate.Size = new System.Drawing.Size(351, 23);
            this.dtpCompletionDate.TabIndex = 22;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(18, 340);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(115, 19);
            this.materialLabel8.TabIndex = 21;
            this.materialLabel8.Text = "Completion Date";
            // 
            // cmbTradeStatus
            // 
            this.cmbTradeStatus.AutoResize = false;
            this.cmbTradeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTradeStatus.Depth = 0;
            this.cmbTradeStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTradeStatus.DropDownHeight = 174;
            this.cmbTradeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTradeStatus.DropDownWidth = 121;
            this.cmbTradeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTradeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTradeStatus.FormattingEnabled = true;
            this.cmbTradeStatus.IntegralHeight = false;
            this.cmbTradeStatus.ItemHeight = 43;
            this.cmbTradeStatus.Location = new System.Drawing.Point(144, 285);
            this.cmbTradeStatus.MaxDropDownItems = 4;
            this.cmbTradeStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTradeStatus.Name = "cmbTradeStatus";
            this.cmbTradeStatus.Size = new System.Drawing.Size(351, 49);
            this.cmbTradeStatus.StartIndex = 0;
            this.cmbTradeStatus.TabIndex = 20;
            this.cmbTradeStatus.SelectedIndexChanged += new System.EventHandler(this.cmbTradeStatus_SelectedIndexChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(18, 300);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(45, 19);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "Status";
            // 
            // dtpRequestDate
            // 
            this.dtpRequestDate.Location = new System.Drawing.Point(144, 235);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(351, 23);
            this.dtpRequestDate.TabIndex = 18;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(18, 235);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(93, 19);
            this.materialLabel6.TabIndex = 17;
            this.materialLabel6.Text = "Request Date";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(18, 376);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(41, 19);
            this.materialLabel5.TabIndex = 16;
            this.materialLabel5.Text = "Notes";
            // 
            // txtTradeNotes
            // 
            this.txtTradeNotes.AnimateReadOnly = false;
            this.txtTradeNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTradeNotes.Depth = 0;
            this.txtTradeNotes.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTradeNotes.LeadingIcon = null;
            this.txtTradeNotes.Location = new System.Drawing.Point(144, 376);
            this.txtTradeNotes.MaxLength = 500;
            this.txtTradeNotes.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTradeNotes.Multiline = false;
            this.txtTradeNotes.Name = "txtTradeNotes";
            this.txtTradeNotes.Size = new System.Drawing.Size(351, 50);
            this.txtTradeNotes.TabIndex = 15;
            this.txtTradeNotes.Text = "";
            this.txtTradeNotes.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(18, 15);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(55, 19);
            this.materialLabel9.TabIndex = 14;
            this.materialLabel9.Text = "Trade ID";
            // 
            // txtTradeID
            // 
            this.txtTradeID.AnimateReadOnly = false;
            this.txtTradeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTradeID.Depth = 0;
            this.txtTradeID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTradeID.LeadingIcon = null;
            this.txtTradeID.Location = new System.Drawing.Point(144, 15);
            this.txtTradeID.MaxLength = 50;
            this.txtTradeID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTradeID.Multiline = false;
            this.txtTradeID.Name = "txtTradeID";
            this.txtTradeID.ReadOnly = true;
            this.txtTradeID.Size = new System.Drawing.Size(351, 50);
            this.txtTradeID.TabIndex = 13;
            this.txtTradeID.Text = "";
            this.txtTradeID.TrailingIcon = null;
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
            this.materialLabel4.Location = new System.Drawing.Point(18, 180);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(37, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Plant";
            // 
            // cmbPlant
            // 
            this.cmbPlant.AutoResize = false;
            this.cmbPlant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPlant.Depth = 0;
            this.cmbPlant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPlant.DropDownHeight = 174;
            this.cmbPlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlant.DropDownWidth = 121;
            this.cmbPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPlant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.IntegralHeight = false;
            this.cmbPlant.ItemHeight = 43;
            this.cmbPlant.Location = new System.Drawing.Point(144, 180);
            this.cmbPlant.MaxDropDownItems = 4;
            this.cmbPlant.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(351, 49);
            this.cmbPlant.StartIndex = 0;
            this.cmbPlant.TabIndex = 7;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(18, 125);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(57, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Provider";
            // 
            // cmbProvider
            // 
            this.cmbProvider.AutoResize = false;
            this.cmbProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProvider.Depth = 0;
            this.cmbProvider.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbProvider.DropDownHeight = 174;
            this.cmbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvider.DropDownWidth = 121;
            this.cmbProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.IntegralHeight = false;
            this.cmbProvider.ItemHeight = 43;
            this.cmbProvider.Location = new System.Drawing.Point(144, 125);
            this.cmbProvider.MaxDropDownItems = 4;
            this.cmbProvider.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(351, 49);
            this.cmbProvider.StartIndex = 0;
            this.cmbProvider.TabIndex = 5;
            this.cmbProvider.SelectedIndexChanged += new System.EventHandler(this.cmbProvider_SelectedIndexChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(18, 70);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Requestor";
            // 
            // cmbRequestor
            // 
            this.cmbRequestor.AutoResize = false;
            this.cmbRequestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRequestor.Depth = 0;
            this.cmbRequestor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRequestor.DropDownHeight = 174;
            this.cmbRequestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequestor.DropDownWidth = 121;
            this.cmbRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbRequestor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRequestor.FormattingEnabled = true;
            this.cmbRequestor.IntegralHeight = false;
            this.cmbRequestor.ItemHeight = 43;
            this.cmbRequestor.Location = new System.Drawing.Point(144, 70);
            this.cmbRequestor.MaxDropDownItems = 4;
            this.cmbRequestor.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRequestor.Name = "cmbRequestor";
            this.cmbRequestor.Size = new System.Drawing.Size(351, 49);
            this.cmbRequestor.StartIndex = 0;
            this.cmbRequestor.TabIndex = 3;
            this.cmbRequestor.SelectedIndexChanged += new System.EventHandler(this.cmbRequestor_SelectedIndexChanged);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnFindTradesByUser);
            this.materialCard3.Controls.Add(this.btnFindCompletedTrades);
            this.materialCard3.Controls.Add(this.btnFindPendingTrades);
            this.materialCard3.Controls.Add(this.cmbSearchUser);
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
            // btnFindTradesByUser
            // 
            this.btnFindTradesByUser.AutoSize = false;
            this.btnFindTradesByUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindTradesByUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFindTradesByUser.Depth = 0;
            this.btnFindTradesByUser.HighEmphasis = true;
            this.btnFindTradesByUser.Icon = null;
            this.btnFindTradesByUser.Location = new System.Drawing.Point(17, 180);
            this.btnFindTradesByUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindTradesByUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFindTradesByUser.Name = "btnFindTradesByUser";
            this.btnFindTradesByUser.Size = new System.Drawing.Size(303, 36);
            this.btnFindTradesByUser.TabIndex = 16;
            this.btnFindTradesByUser.Text = "FIND TRADES BY USER";
            this.btnFindTradesByUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFindTradesByUser.UseAccentColor = false;
            this.btnFindTradesByUser.UseVisualStyleBackColor = true;
            this.btnFindTradesByUser.Click += new System.EventHandler(this.btnFindTradesByUser_Click);
            // 
            // btnFindCompletedTrades
            // 
            this.btnFindCompletedTrades.AutoSize = false;
            this.btnFindCompletedTrades.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindCompletedTrades.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFindCompletedTrades.Depth = 0;
            this.btnFindCompletedTrades.HighEmphasis = true;
            this.btnFindCompletedTrades.Icon = null;
            this.btnFindCompletedTrades.Location = new System.Drawing.Point(17, 276);
            this.btnFindCompletedTrades.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindCompletedTrades.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFindCompletedTrades.Name = "btnFindCompletedTrades";
            this.btnFindCompletedTrades.Size = new System.Drawing.Size(303, 36);
            this.btnFindCompletedTrades.TabIndex = 15;
            this.btnFindCompletedTrades.Text = "FIND COMPLETED TRADES";
            this.btnFindCompletedTrades.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFindCompletedTrades.UseAccentColor = false;
            this.btnFindCompletedTrades.UseVisualStyleBackColor = true;
            this.btnFindCompletedTrades.Click += new System.EventHandler(this.btnFindCompletedTrades_Click);
            // 
            // btnFindPendingTrades
            // 
            this.btnFindPendingTrades.AutoSize = false;
            this.btnFindPendingTrades.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindPendingTrades.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFindPendingTrades.Depth = 0;
            this.btnFindPendingTrades.HighEmphasis = true;
            this.btnFindPendingTrades.Icon = null;
            this.btnFindPendingTrades.Location = new System.Drawing.Point(17, 228);
            this.btnFindPendingTrades.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindPendingTrades.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFindPendingTrades.Name = "btnFindPendingTrades";
            this.btnFindPendingTrades.Size = new System.Drawing.Size(303, 36);
            this.btnFindPendingTrades.TabIndex = 14;
            this.btnFindPendingTrades.Text = "FIND PENDING TRADES";
            this.btnFindPendingTrades.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFindPendingTrades.UseAccentColor = false;
            this.btnFindPendingTrades.UseVisualStyleBackColor = true;
            this.btnFindPendingTrades.Click += new System.EventHandler(this.btnFindPendingTrades_Click);
            // 
            // cmbSearchUser
            // 
            this.cmbSearchUser.AutoResize = false;
            this.cmbSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSearchUser.Depth = 0;
            this.cmbSearchUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSearchUser.DropDownHeight = 174;
            this.cmbSearchUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchUser.DropDownWidth = 121;
            this.cmbSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSearchUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSearchUser.FormattingEnabled = true;
            this.cmbSearchUser.IntegralHeight = false;
            this.cmbSearchUser.ItemHeight = 43;
            this.cmbSearchUser.Location = new System.Drawing.Point(17, 125);
            this.cmbSearchUser.MaxDropDownItems = 4;
            this.cmbSearchUser.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSearchUser.Name = "cmbSearchUser";
            this.cmbSearchUser.Size = new System.Drawing.Size(303, 49);
            this.cmbSearchUser.StartIndex = 0;
            this.cmbSearchUser.TabIndex = 13;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(17, 103);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(76, 19);
            this.materialLabel11.TabIndex = 11;
            this.materialLabel11.Text = "Select User";
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
            // TradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 835);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "TradesForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.Text = "Trade Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TradesForm_FormClosing);
            this.Load += new System.EventHandler(this.TradesForm_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrades)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridView dgvTrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeNotes;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DateTimePicker dtpCompletionDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox cmbTradeStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DateTimePicker dtpRequestDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtTradeNotes;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txtTradeID;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cmbPlant;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cmbProvider;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cmbRequestor;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton btnFindTradesByUser;
        private MaterialSkin.Controls.MaterialButton btnFindCompletedTrades;
        private MaterialSkin.Controls.MaterialButton btnFindPendingTrades;
        private MaterialSkin.Controls.MaterialComboBox cmbSearchUser;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}