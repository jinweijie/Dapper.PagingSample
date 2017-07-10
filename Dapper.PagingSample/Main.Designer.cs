namespace Dapper.PagingSample
{
    partial class Main
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
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.lPrompt = new System.Windows.Forms.Label();
            this.lConnectionString = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.btnGenerateInfoLog = new System.Windows.Forms.Button();
            this.gbCriteria = new System.Windows.Forms.GroupBox();
            this.lMessage = new System.Windows.Forms.Label();
            this.lLevel = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.gbPaging = new System.Windows.Forms.GroupBox();
            this.lTotalCountValue = new System.Windows.Forms.Label();
            this.lTotalCount = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSortDesc = new System.Windows.Forms.TextBox();
            this.lPageSize = new System.Windows.Forms.Label();
            this.txtPageSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lPageIndex = new System.Windows.Forms.Label();
            this.txtSortAsc = new System.Windows.Forms.TextBox();
            this.txtPageIndex = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbOffsetFetch = new System.Windows.Forms.RadioButton();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.gbConnection.SuspendLayout();
            this.gbCriteria.SuspendLayout();
            this.gbPaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gbMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(99, 29);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(510, 20);
            this.txtConnectionString.TabIndex = 0;
            // 
            // lPrompt
            // 
            this.lPrompt.AutoSize = true;
            this.lPrompt.Location = new System.Drawing.Point(615, 32);
            this.lPrompt.Name = "lPrompt";
            this.lPrompt.Size = new System.Drawing.Size(264, 13);
            this.lPrompt.TabIndex = 1;
            this.lPrompt.Text = "Please make sure the database is attched to LocalDB.";
            // 
            // lConnectionString
            // 
            this.lConnectionString.AutoSize = true;
            this.lConnectionString.Location = new System.Drawing.Point(6, 32);
            this.lConnectionString.Name = "lConnectionString";
            this.lConnectionString.Size = new System.Drawing.Size(91, 13);
            this.lConnectionString.TabIndex = 2;
            this.lConnectionString.Text = "ConnectionString:";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(98, 19);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 3;
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.lConnectionString);
            this.gbConnection.Controls.Add(this.txtConnectionString);
            this.gbConnection.Controls.Add(this.btnGenerateInfoLog);
            this.gbConnection.Controls.Add(this.lPrompt);
            this.gbConnection.Location = new System.Drawing.Point(12, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(1001, 69);
            this.gbConnection.TabIndex = 4;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Database";
            // 
            // btnGenerateInfoLog
            // 
            this.btnGenerateInfoLog.Location = new System.Drawing.Point(885, 26);
            this.btnGenerateInfoLog.Name = "btnGenerateInfoLog";
            this.btnGenerateInfoLog.Size = new System.Drawing.Size(110, 25);
            this.btnGenerateInfoLog.TabIndex = 7;
            this.btnGenerateInfoLog.Text = "Generate Info Logs";
            this.btnGenerateInfoLog.UseVisualStyleBackColor = true;
            this.btnGenerateInfoLog.Click += new System.EventHandler(this.btnGenerateInfoLog_Click);
            // 
            // gbCriteria
            // 
            this.gbCriteria.Controls.Add(this.lMessage);
            this.gbCriteria.Controls.Add(this.lLevel);
            this.gbCriteria.Controls.Add(this.txtMessage);
            this.gbCriteria.Controls.Add(this.txtLevel);
            this.gbCriteria.Location = new System.Drawing.Point(13, 87);
            this.gbCriteria.Name = "gbCriteria";
            this.gbCriteria.Size = new System.Drawing.Size(492, 77);
            this.gbCriteria.TabIndex = 5;
            this.gbCriteria.TabStop = false;
            this.gbCriteria.Text = "Criteria";
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Location = new System.Drawing.Point(214, 22);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(53, 13);
            this.lMessage.TabIndex = 3;
            this.lMessage.Text = "Message:";
            // 
            // lLevel
            // 
            this.lLevel.AutoSize = true;
            this.lLevel.Location = new System.Drawing.Point(51, 22);
            this.lLevel.Name = "lLevel";
            this.lLevel.Size = new System.Drawing.Size(36, 13);
            this.lLevel.TabIndex = 3;
            this.lLevel.Text = "Level:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(276, 19);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 20);
            this.txtMessage.TabIndex = 3;
            // 
            // gbPaging
            // 
            this.gbPaging.Controls.Add(this.lTotalCountValue);
            this.gbPaging.Controls.Add(this.lTotalCount);
            this.gbPaging.Controls.Add(this.btnPrevious);
            this.gbPaging.Controls.Add(this.btnNext);
            this.gbPaging.Controls.Add(this.label2);
            this.gbPaging.Controls.Add(this.txtSortDesc);
            this.gbPaging.Controls.Add(this.lPageSize);
            this.gbPaging.Controls.Add(this.txtPageSize);
            this.gbPaging.Controls.Add(this.label1);
            this.gbPaging.Controls.Add(this.lPageIndex);
            this.gbPaging.Controls.Add(this.txtSortAsc);
            this.gbPaging.Controls.Add(this.txtPageIndex);
            this.gbPaging.Location = new System.Drawing.Point(520, 87);
            this.gbPaging.Name = "gbPaging";
            this.gbPaging.Size = new System.Drawing.Size(493, 77);
            this.gbPaging.TabIndex = 6;
            this.gbPaging.TabStop = false;
            this.gbPaging.Text = "Paging";
            // 
            // lTotalCountValue
            // 
            this.lTotalCountValue.AutoSize = true;
            this.lTotalCountValue.Location = new System.Drawing.Point(81, 54);
            this.lTotalCountValue.Name = "lTotalCountValue";
            this.lTotalCountValue.Size = new System.Drawing.Size(0, 13);
            this.lTotalCountValue.TabIndex = 15;
            // 
            // lTotalCount
            // 
            this.lTotalCount.AutoSize = true;
            this.lTotalCount.Location = new System.Drawing.Point(9, 54);
            this.lTotalCount.Name = "lTotalCount";
            this.lTotalCount.Size = new System.Drawing.Size(65, 13);
            this.lTotalCount.TabIndex = 14;
            this.lTotalCount.Text = "Total Count:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(311, 45);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(85, 23);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous Page";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(402, 45);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next Page";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sort Desc:";
            // 
            // txtSortDesc
            // 
            this.txtSortDesc.Location = new System.Drawing.Point(402, 19);
            this.txtSortDesc.Name = "txtSortDesc";
            this.txtSortDesc.Size = new System.Drawing.Size(85, 20);
            this.txtSortDesc.TabIndex = 5;
            // 
            // lPageSize
            // 
            this.lPageSize.AutoSize = true;
            this.lPageSize.Location = new System.Drawing.Point(117, 22);
            this.lPageSize.Name = "lPageSize";
            this.lPageSize.Size = new System.Drawing.Size(58, 13);
            this.lPageSize.TabIndex = 3;
            this.lPageSize.Text = "Page Size:";
            // 
            // txtPageSize
            // 
            this.txtPageSize.Location = new System.Drawing.Point(181, 19);
            this.txtPageSize.Name = "txtPageSize";
            this.txtPageSize.Size = new System.Drawing.Size(37, 20);
            this.txtPageSize.TabIndex = 3;
            this.txtPageSize.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sort Asc:";
            // 
            // lPageIndex
            // 
            this.lPageIndex.AutoSize = true;
            this.lPageIndex.Location = new System.Drawing.Point(10, 22);
            this.lPageIndex.Name = "lPageIndex";
            this.lPageIndex.Size = new System.Drawing.Size(64, 13);
            this.lPageIndex.TabIndex = 3;
            this.lPageIndex.Text = "Page Index:";
            // 
            // txtSortAsc
            // 
            this.txtSortAsc.Location = new System.Drawing.Point(272, 19);
            this.txtSortAsc.Name = "txtSortAsc";
            this.txtSortAsc.Size = new System.Drawing.Size(62, 20);
            this.txtSortAsc.TabIndex = 3;
            this.txtSortAsc.Text = "CreateTime";
            // 
            // txtPageIndex
            // 
            this.txtPageIndex.Location = new System.Drawing.Point(80, 19);
            this.txtPageIndex.Name = "txtPageIndex";
            this.txtPageIndex.Size = new System.Drawing.Size(31, 20);
            this.txtPageIndex.TabIndex = 3;
            this.txtPageIndex.Text = "0";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(866, 180);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 36);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(13, 226);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(1000, 348);
            this.dgvData.TabIndex = 9;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(6, 20);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(170, 17);
            this.rbNormal.TabIndex = 11;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal search (With 2 queries)";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbOffsetFetch
            // 
            this.rbOffsetFetch.AutoSize = true;
            this.rbOffsetFetch.Location = new System.Drawing.Point(182, 20);
            this.rbOffsetFetch.Name = "rbOffsetFetch";
            this.rbOffsetFetch.Size = new System.Drawing.Size(235, 17);
            this.rbOffsetFetch.TabIndex = 11;
            this.rbOffsetFetch.Text = "Search with Offset/Fetch (Sql Server 2012+)";
            this.rbOffsetFetch.UseVisualStyleBackColor = true;
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbNormal);
            this.gbMode.Controls.Add(this.rbOffsetFetch);
            this.gbMode.Location = new System.Drawing.Point(13, 170);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(492, 50);
            this.gbMode.TabIndex = 12;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Mode";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 590);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbPaging);
            this.Controls.Add(this.gbCriteria);
            this.Controls.Add(this.gbConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Dapper Custom Paging Sample";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.gbCriteria.ResumeLayout(false);
            this.gbCriteria.PerformLayout();
            this.gbPaging.ResumeLayout(false);
            this.gbPaging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label lPrompt;
        private System.Windows.Forms.Label lConnectionString;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.GroupBox gbCriteria;
        private System.Windows.Forms.Label lLevel;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox gbPaging;
        private System.Windows.Forms.Label lPageIndex;
        private System.Windows.Forms.Label lPageSize;
        private System.Windows.Forms.TextBox txtPageIndex;
        private System.Windows.Forms.TextBox txtPageSize;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSortAsc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSortDesc;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbOffsetFetch;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lTotalCount;
        private System.Windows.Forms.Label lTotalCountValue;
        private System.Windows.Forms.Button btnGenerateInfoLog;
    }
}

