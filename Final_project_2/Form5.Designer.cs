namespace Final_project_2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rechargeAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expairDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expairYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardCCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rechargeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rechargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tapNgo_Metro_ServiceDataSet1 = new Final_project_2.TapNgo_Metro_ServiceDataSet1();
            this.rechargeTableAdapter = new Final_project_2.TapNgo_Metro_ServiceDataSet1TableAdapters.RechargeTableAdapter();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechargeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapNgo_Metro_ServiceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailDataGridViewTextBoxColumn,
            this.rechargeAmountDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.cardNameDataGridViewTextBoxColumn,
            this.cardNumberDataGridViewTextBoxColumn,
            this.expairDateDataGridViewTextBoxColumn,
            this.expairYearDataGridViewTextBoxColumn,
            this.cardCCVDataGridViewTextBoxColumn,
            this.rechargeTimeDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rechargeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(92, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rechargeAmountDataGridViewTextBoxColumn
            // 
            this.rechargeAmountDataGridViewTextBoxColumn.DataPropertyName = "Recharge_Amount";
            this.rechargeAmountDataGridViewTextBoxColumn.HeaderText = "Recharge_Amount";
            this.rechargeAmountDataGridViewTextBoxColumn.Name = "rechargeAmountDataGridViewTextBoxColumn";
            this.rechargeAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "Account_Number";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "Account_Number";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardNameDataGridViewTextBoxColumn
            // 
            this.cardNameDataGridViewTextBoxColumn.DataPropertyName = "Card_Name";
            this.cardNameDataGridViewTextBoxColumn.HeaderText = "Card_Name";
            this.cardNameDataGridViewTextBoxColumn.Name = "cardNameDataGridViewTextBoxColumn";
            this.cardNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardNumberDataGridViewTextBoxColumn
            // 
            this.cardNumberDataGridViewTextBoxColumn.DataPropertyName = "Card_Number";
            this.cardNumberDataGridViewTextBoxColumn.HeaderText = "Card_Number";
            this.cardNumberDataGridViewTextBoxColumn.Name = "cardNumberDataGridViewTextBoxColumn";
            this.cardNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expairDateDataGridViewTextBoxColumn
            // 
            this.expairDateDataGridViewTextBoxColumn.DataPropertyName = "Expair_Date";
            this.expairDateDataGridViewTextBoxColumn.HeaderText = "Expair_Date";
            this.expairDateDataGridViewTextBoxColumn.Name = "expairDateDataGridViewTextBoxColumn";
            this.expairDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expairYearDataGridViewTextBoxColumn
            // 
            this.expairYearDataGridViewTextBoxColumn.DataPropertyName = "Expair_Year";
            this.expairYearDataGridViewTextBoxColumn.HeaderText = "Expair_Year";
            this.expairYearDataGridViewTextBoxColumn.Name = "expairYearDataGridViewTextBoxColumn";
            this.expairYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardCCVDataGridViewTextBoxColumn
            // 
            this.cardCCVDataGridViewTextBoxColumn.DataPropertyName = "Card_CCV";
            this.cardCCVDataGridViewTextBoxColumn.HeaderText = "Card_CCV";
            this.cardCCVDataGridViewTextBoxColumn.Name = "cardCCVDataGridViewTextBoxColumn";
            this.cardCCVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rechargeTimeDataGridViewTextBoxColumn
            // 
            this.rechargeTimeDataGridViewTextBoxColumn.DataPropertyName = "Recharge_Time";
            this.rechargeTimeDataGridViewTextBoxColumn.HeaderText = "Recharge_Time";
            this.rechargeTimeDataGridViewTextBoxColumn.Name = "rechargeTimeDataGridViewTextBoxColumn";
            this.rechargeTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "Payment_Type";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "Payment_Type";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rechargeBindingSource
            // 
            this.rechargeBindingSource.DataMember = "Recharge";
            this.rechargeBindingSource.DataSource = this.tapNgo_Metro_ServiceDataSet1;
            // 
            // tapNgo_Metro_ServiceDataSet1
            // 
            this.tapNgo_Metro_ServiceDataSet1.DataSetName = "TapNgo_Metro_ServiceDataSet1";
            this.tapNgo_Metro_ServiceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rechargeTableAdapter
            // 
            this.rechargeTableAdapter.ClearBeforeFill = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("OCR A Extended", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(549, 458);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 40);
            this.button9.TabIndex = 41;
            this.button9.Text = "GO BACK";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(495, 451);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(251, 58);
            this.pictureBox6.TabIndex = 42;
            this.pictureBox6.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 661);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechargeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapNgo_Metro_ServiceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TapNgo_Metro_ServiceDataSet1 tapNgo_Metro_ServiceDataSet1;
        private System.Windows.Forms.BindingSource rechargeBindingSource;
        private TapNgo_Metro_ServiceDataSet1TableAdapters.RechargeTableAdapter rechargeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rechargeAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expairDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expairYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rechargeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}