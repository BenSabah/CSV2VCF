namespace CSV2VCF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Button_CreateVCF = new System.Windows.Forms.Button();
            this.TextBox_CsvFilePath_ = new System.Windows.Forms.TextBox();
            this.Button_CSVLoading = new System.Windows.Forms.Button();
            this.Checkbox_MergeVCFs = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_Number = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox_Name = new System.Windows.Forms.ComboBox();
            this.Checkbox_IgnoreFirstLine = new System.Windows.Forms.CheckBox();
            this.dataGridView_ClipboardData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClipboardData)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_CreateVCF
            // 
            this.Button_CreateVCF.Enabled = false;
            this.Button_CreateVCF.Location = new System.Drawing.Point(11, 215);
            this.Button_CreateVCF.Name = "Button_CreateVCF";
            this.Button_CreateVCF.Size = new System.Drawing.Size(409, 126);
            this.Button_CreateVCF.TabIndex = 5;
            this.Button_CreateVCF.Text = "Create VCF File(s)";
            this.Button_CreateVCF.UseVisualStyleBackColor = true;
            this.Button_CreateVCF.Click += new System.EventHandler(this.Button_CreateVCF_Click);
            // 
            // TextBox_CsvFilePath_
            // 
            this.TextBox_CsvFilePath_.Location = new System.Drawing.Point(12, 61);
            this.TextBox_CsvFilePath_.Name = "TextBox_CsvFilePath_";
            this.TextBox_CsvFilePath_.ReadOnly = true;
            this.TextBox_CsvFilePath_.Size = new System.Drawing.Size(408, 22);
            this.TextBox_CsvFilePath_.TabIndex = 4;
            // 
            // Button_CSVLoading
            // 
            this.Button_CSVLoading.Location = new System.Drawing.Point(11, 11);
            this.Button_CSVLoading.Name = "Button_CSVLoading";
            this.Button_CSVLoading.Size = new System.Drawing.Size(409, 44);
            this.Button_CSVLoading.TabIndex = 3;
            this.Button_CSVLoading.Text = "Load CSV file";
            this.Button_CSVLoading.UseVisualStyleBackColor = true;
            this.Button_CSVLoading.Click += new System.EventHandler(this.Button_CSVLoading_Click);
            // 
            // Checkbox_MergeVCFs
            // 
            this.Checkbox_MergeVCFs.AutoSize = true;
            this.Checkbox_MergeVCFs.Checked = true;
            this.Checkbox_MergeVCFs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Checkbox_MergeVCFs.Location = new System.Drawing.Point(12, 161);
            this.Checkbox_MergeVCFs.Name = "Checkbox_MergeVCFs";
            this.Checkbox_MergeVCFs.Size = new System.Drawing.Size(182, 21);
            this.Checkbox_MergeVCFs.TabIndex = 6;
            this.Checkbox_MergeVCFs.Tag = "";
            this.Checkbox_MergeVCFs.Text = "Merge to a single VCard";
            this.Checkbox_MergeVCFs.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Number, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_Name, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 91);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 67);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // comboBox_Number
            // 
            this.comboBox_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Number.Location = new System.Drawing.Point(207, 37);
            this.comboBox_Number.Name = "comboBox_Number";
            this.comboBox_Number.Size = new System.Drawing.Size(197, 24);
            this.comboBox_Number.TabIndex = 3;
            this.comboBox_Number.SelectedIndexChanged += new System.EventHandler(this.comboBox_Number_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "phone number row";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "full name row";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox_Name
            // 
            this.ComboBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Name.Location = new System.Drawing.Point(4, 37);
            this.ComboBox_Name.Name = "ComboBox_Name";
            this.ComboBox_Name.Size = new System.Drawing.Size(196, 24);
            this.ComboBox_Name.TabIndex = 0;
            this.ComboBox_Name.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Name_SelectedIndexChanged);
            // 
            // Checkbox_IgnoreFirstLine
            // 
            this.Checkbox_IgnoreFirstLine.AutoSize = true;
            this.Checkbox_IgnoreFirstLine.Location = new System.Drawing.Point(12, 188);
            this.Checkbox_IgnoreFirstLine.Name = "Checkbox_IgnoreFirstLine";
            this.Checkbox_IgnoreFirstLine.Size = new System.Drawing.Size(132, 21);
            this.Checkbox_IgnoreFirstLine.TabIndex = 8;
            this.Checkbox_IgnoreFirstLine.Text = "Ignore First Line";
            this.Checkbox_IgnoreFirstLine.UseVisualStyleBackColor = true;
            // 
            // dataGridView_ClipboardData
            // 
            this.dataGridView_ClipboardData.AllowUserToAddRows = false;
            this.dataGridView_ClipboardData.AllowUserToResizeColumns = false;
            this.dataGridView_ClipboardData.AllowUserToResizeRows = false;
            this.dataGridView_ClipboardData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ClipboardData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ClipboardData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView_ClipboardData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ClipboardData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ClipboardData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_ClipboardData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_ClipboardData.EnableHeadersVisualStyles = false;
            this.dataGridView_ClipboardData.Location = new System.Drawing.Point(426, 12);
            this.dataGridView_ClipboardData.Name = "dataGridView_ClipboardData";
            this.dataGridView_ClipboardData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_ClipboardData.RowHeadersVisible = false;
            this.dataGridView_ClipboardData.RowTemplate.Height = 24;
            this.dataGridView_ClipboardData.ShowCellErrors = false;
            this.dataGridView_ClipboardData.ShowCellToolTips = false;
            this.dataGridView_ClipboardData.ShowEditingIcon = false;
            this.dataGridView_ClipboardData.Size = new System.Drawing.Size(394, 328);
            this.dataGridView_ClipboardData.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Phone Number";
            this.Column2.Name = "Column2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 353);
            this.Controls.Add(this.dataGridView_ClipboardData);
            this.Controls.Add(this.Checkbox_IgnoreFirstLine);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Checkbox_MergeVCFs);
            this.Controls.Add(this.Button_CreateVCF);
            this.Controls.Add(this.TextBox_CsvFilePath_);
            this.Controls.Add(this.Button_CSVLoading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV to VCF - 4Li";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClipboardData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_CreateVCF;
        private System.Windows.Forms.TextBox TextBox_CsvFilePath_;
        private System.Windows.Forms.Button Button_CSVLoading;
        private System.Windows.Forms.CheckBox Checkbox_MergeVCFs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Number;
        private System.Windows.Forms.ComboBox ComboBox_Name;
        private System.Windows.Forms.CheckBox Checkbox_IgnoreFirstLine;
        private System.Windows.Forms.DataGridView dataGridView_ClipboardData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}