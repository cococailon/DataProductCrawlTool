namespace DataProductCrawlTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonGoiAPI = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewDataLuuVaoDb = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imageUrlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sortOrderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mainCategoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            relatedIdsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workFlowStatesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publicOnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            metadataJsonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            completeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            completePathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            completeCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            labelsJsonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdByUserIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastModifiedByUserIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastModifiedOnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdOnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isdeletedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            label2 = new Label();
            richTextBoxDataTraVe = new RichTextBox();
            label1 = new Label();
            buttonLuuVaoDb = new Button();
            panel1 = new Panel();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataLuuVaoDb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGoiAPI
            // 
            buttonGoiAPI.Anchor = AnchorStyles.Top;
            buttonGoiAPI.Location = new Point(347, 14);
            buttonGoiAPI.Name = "buttonGoiAPI";
            buttonGoiAPI.Size = new Size(75, 46);
            buttonGoiAPI.TabIndex = 0;
            buttonGoiAPI.Text = "Gọi API";
            buttonGoiAPI.UseVisualStyleBackColor = true;
            buttonGoiAPI.Click += buttonGoiAPI_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridViewDataLuuVaoDb, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(richTextBoxDataTraVe, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonLuuVaoDb, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            tableLayoutPanel1.Size = new Size(776, 470);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridViewDataLuuVaoDb
            // 
            dataGridViewDataLuuVaoDb.AutoGenerateColumns = false;
            dataGridViewDataLuuVaoDb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataLuuVaoDb.Columns.AddRange(new DataGridViewColumn[] { STT, idDataGridViewTextBoxColumn, codeDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, imageUrlDataGridViewTextBoxColumn, sortOrderDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, mainCategoryIdDataGridViewTextBoxColumn, relatedIdsDataGridViewTextBoxColumn, workFlowStatesDataGridViewTextBoxColumn, publicOnDateDataGridViewTextBoxColumn, metadataJsonDataGridViewTextBoxColumn, completeNameDataGridViewTextBoxColumn, completePathDataGridViewTextBoxColumn, completeCodeDataGridViewTextBoxColumn, labelsJsonDataGridViewTextBoxColumn, createdByUserIdDataGridViewTextBoxColumn, lastModifiedByUserIdDataGridViewTextBoxColumn, lastModifiedOnDateDataGridViewTextBoxColumn, createdOnDateDataGridViewTextBoxColumn, isdeletedDataGridViewTextBoxColumn });
            dataGridViewDataLuuVaoDb.DataSource = productBindingSource;
            dataGridViewDataLuuVaoDb.Dock = DockStyle.Fill;
            dataGridViewDataLuuVaoDb.Location = new Point(3, 274);
            dataGridViewDataLuuVaoDb.Name = "dataGridViewDataLuuVaoDb";
            dataGridViewDataLuuVaoDb.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewDataLuuVaoDb.RowTemplate.Height = 25;
            dataGridViewDataLuuVaoDb.Size = new Size(770, 193);
            dataGridViewDataLuuVaoDb.TabIndex = 5;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // imageUrlDataGridViewTextBoxColumn
            // 
            imageUrlDataGridViewTextBoxColumn.DataPropertyName = "ImageUrl";
            imageUrlDataGridViewTextBoxColumn.HeaderText = "ImageUrl";
            imageUrlDataGridViewTextBoxColumn.Name = "imageUrlDataGridViewTextBoxColumn";
            // 
            // sortOrderDataGridViewTextBoxColumn
            // 
            sortOrderDataGridViewTextBoxColumn.DataPropertyName = "SortOrder";
            sortOrderDataGridViewTextBoxColumn.HeaderText = "SortOrder";
            sortOrderDataGridViewTextBoxColumn.Name = "sortOrderDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // mainCategoryIdDataGridViewTextBoxColumn
            // 
            mainCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "MainCategoryId";
            mainCategoryIdDataGridViewTextBoxColumn.HeaderText = "MainCategoryId";
            mainCategoryIdDataGridViewTextBoxColumn.Name = "mainCategoryIdDataGridViewTextBoxColumn";
            // 
            // relatedIdsDataGridViewTextBoxColumn
            // 
            relatedIdsDataGridViewTextBoxColumn.DataPropertyName = "RelatedIds";
            relatedIdsDataGridViewTextBoxColumn.HeaderText = "RelatedIds";
            relatedIdsDataGridViewTextBoxColumn.Name = "relatedIdsDataGridViewTextBoxColumn";
            // 
            // workFlowStatesDataGridViewTextBoxColumn
            // 
            workFlowStatesDataGridViewTextBoxColumn.DataPropertyName = "WorkFlowStates";
            workFlowStatesDataGridViewTextBoxColumn.HeaderText = "WorkFlowStates";
            workFlowStatesDataGridViewTextBoxColumn.Name = "workFlowStatesDataGridViewTextBoxColumn";
            // 
            // publicOnDateDataGridViewTextBoxColumn
            // 
            publicOnDateDataGridViewTextBoxColumn.DataPropertyName = "PublicOnDate";
            publicOnDateDataGridViewTextBoxColumn.HeaderText = "PublicOnDate";
            publicOnDateDataGridViewTextBoxColumn.Name = "publicOnDateDataGridViewTextBoxColumn";
            // 
            // metadataJsonDataGridViewTextBoxColumn
            // 
            metadataJsonDataGridViewTextBoxColumn.DataPropertyName = "MetadataJson";
            metadataJsonDataGridViewTextBoxColumn.HeaderText = "MetadataJson";
            metadataJsonDataGridViewTextBoxColumn.Name = "metadataJsonDataGridViewTextBoxColumn";
            // 
            // completeNameDataGridViewTextBoxColumn
            // 
            completeNameDataGridViewTextBoxColumn.DataPropertyName = "CompleteName";
            completeNameDataGridViewTextBoxColumn.HeaderText = "CompleteName";
            completeNameDataGridViewTextBoxColumn.Name = "completeNameDataGridViewTextBoxColumn";
            // 
            // completePathDataGridViewTextBoxColumn
            // 
            completePathDataGridViewTextBoxColumn.DataPropertyName = "CompletePath";
            completePathDataGridViewTextBoxColumn.HeaderText = "CompletePath";
            completePathDataGridViewTextBoxColumn.Name = "completePathDataGridViewTextBoxColumn";
            // 
            // completeCodeDataGridViewTextBoxColumn
            // 
            completeCodeDataGridViewTextBoxColumn.DataPropertyName = "CompleteCode";
            completeCodeDataGridViewTextBoxColumn.HeaderText = "CompleteCode";
            completeCodeDataGridViewTextBoxColumn.Name = "completeCodeDataGridViewTextBoxColumn";
            // 
            // labelsJsonDataGridViewTextBoxColumn
            // 
            labelsJsonDataGridViewTextBoxColumn.DataPropertyName = "LabelsJson";
            labelsJsonDataGridViewTextBoxColumn.HeaderText = "LabelsJson";
            labelsJsonDataGridViewTextBoxColumn.Name = "labelsJsonDataGridViewTextBoxColumn";
            // 
            // createdByUserIdDataGridViewTextBoxColumn
            // 
            createdByUserIdDataGridViewTextBoxColumn.DataPropertyName = "CreatedByUserId";
            createdByUserIdDataGridViewTextBoxColumn.HeaderText = "CreatedByUserId";
            createdByUserIdDataGridViewTextBoxColumn.Name = "createdByUserIdDataGridViewTextBoxColumn";
            // 
            // lastModifiedByUserIdDataGridViewTextBoxColumn
            // 
            lastModifiedByUserIdDataGridViewTextBoxColumn.DataPropertyName = "LastModifiedByUserId";
            lastModifiedByUserIdDataGridViewTextBoxColumn.HeaderText = "LastModifiedByUserId";
            lastModifiedByUserIdDataGridViewTextBoxColumn.Name = "lastModifiedByUserIdDataGridViewTextBoxColumn";
            // 
            // lastModifiedOnDateDataGridViewTextBoxColumn
            // 
            lastModifiedOnDateDataGridViewTextBoxColumn.DataPropertyName = "LastModifiedOnDate";
            lastModifiedOnDateDataGridViewTextBoxColumn.HeaderText = "LastModifiedOnDate";
            lastModifiedOnDateDataGridViewTextBoxColumn.Name = "lastModifiedOnDateDataGridViewTextBoxColumn";
            // 
            // createdOnDateDataGridViewTextBoxColumn
            // 
            createdOnDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedOnDate";
            createdOnDateDataGridViewTextBoxColumn.HeaderText = "CreatedOnDate";
            createdOnDateDataGridViewTextBoxColumn.Name = "createdOnDateDataGridViewTextBoxColumn";
            // 
            // isdeletedDataGridViewTextBoxColumn
            // 
            isdeletedDataGridViewTextBoxColumn.DataPropertyName = "Isdeleted";
            isdeletedDataGridViewTextBoxColumn.HeaderText = "Isdeleted";
            isdeletedDataGridViewTextBoxColumn.Name = "isdeletedDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Model.Product);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 220);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 3;
            label2.Text = "Data sẽ lưu vào Db";
            // 
            // richTextBoxDataTraVe
            // 
            richTextBoxDataTraVe.Dock = DockStyle.Fill;
            richTextBoxDataTraVe.Location = new Point(3, 26);
            richTextBoxDataTraVe.Name = "richTextBoxDataTraVe";
            richTextBoxDataTraVe.ReadOnly = true;
            richTextBoxDataTraVe.Size = new Size(770, 191);
            richTextBoxDataTraVe.TabIndex = 0;
            richTextBoxDataTraVe.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 2;
            label1.Text = "Data trả về";
            // 
            // buttonLuuVaoDb
            // 
            buttonLuuVaoDb.Location = new Point(3, 246);
            buttonLuuVaoDb.Name = "buttonLuuVaoDb";
            buttonLuuVaoDb.Size = new Size(136, 22);
            buttonLuuVaoDb.TabIndex = 4;
            buttonLuuVaoDb.Text = "Lưu hết Data vào Db";
            buttonLuuVaoDb.UseVisualStyleBackColor = true;
            buttonLuuVaoDb.Click += buttonLuuVaoDb_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(15, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 33);
            panel1.TabIndex = 4;
            panel1.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(115, 220);
            label3.Name = "label3";
            label3.Size = new Size(609, 32);
            label3.TabIndex = 0;
            label3.Text = "Loading...(Lâu vl, 4000 bản ghi thì phải đợi tầm hơn 1 h)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 548);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonGoiAPI);
            Name = "Form1";
            Text = "DataProductCrawlTool";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataLuuVaoDb).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGoiAPI;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox richTextBoxDataTraVe;
        private Label label2;
        private Label label1;
        private BindingSource productBindingSource;
        private DataGridView dataGridViewDataLuuVaoDb;
        private Button buttonLuuVaoDb;
        private Panel panel1;
        private Label label3;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imageUrlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sortOrderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mainCategoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn relatedIdsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workFlowStatesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publicOnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn metadataJsonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn completeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn completePathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn completeCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn labelsJsonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdByUserIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastModifiedByUserIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastModifiedOnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdOnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isdeletedDataGridViewTextBoxColumn;
    }
}
