namespace test0608_OleDB {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.da = new System.Data.OleDb.OleDbDataAdapter();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.ds = new test0608_OleDB.MusicDataSet();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.songIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songIDDataGridViewTextBoxColumn,
            this.songDataGridViewTextBoxColumn,
            this.artisteDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.issuingDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bs;
            this.dataGridView1.Location = new System.Drawing.Point(31, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(487, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT  SongID, Song, Artiste, [Language], IssuingDate\r\nFROM     Title";
            this.oleDbSelectCommand1.Connection = this.cn;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Title` (`SongID`, `Song`, `Artiste`, `Language`, `IssuingDate`) VALU" +
    "ES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.cn;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("SongID", System.Data.OleDb.OleDbType.VarWChar, 0, "SongID"),
            new System.Data.OleDb.OleDbParameter("Song", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Song"),
            new System.Data.OleDb.OleDbParameter("Artiste", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Artiste"),
            new System.Data.OleDb.OleDbParameter("Language", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Language"),
            new System.Data.OleDb.OleDbParameter("IssuingDate", System.Data.OleDb.OleDbType.LongVarWChar, 0, "IssuingDate")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE `Title` SET `SongID` = ?, `Song` = ?, `Artiste` = ?, `Language` = ?, `Issu" +
    "ingDate` = ? WHERE ((`SongID` = ?))";
            this.oleDbUpdateCommand1.Connection = this.cn;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("SongID", System.Data.OleDb.OleDbType.VarWChar, 0, "SongID"),
            new System.Data.OleDb.OleDbParameter("Song", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Song"),
            new System.Data.OleDb.OleDbParameter("Artiste", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Artiste"),
            new System.Data.OleDb.OleDbParameter("Language", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Language"),
            new System.Data.OleDb.OleDbParameter("IssuingDate", System.Data.OleDb.OleDbType.LongVarWChar, 0, "IssuingDate"),
            new System.Data.OleDb.OleDbParameter("Original_SongID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SongID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `Title` WHERE ((`SongID` = ?))";
            this.oleDbDeleteCommand1.Connection = this.cn;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_SongID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SongID", System.Data.DataRowVersion.Original, null)});
            // 
            // da
            // 
            this.da.DeleteCommand = this.oleDbDeleteCommand1;
            this.da.InsertCommand = this.oleDbInsertCommand1;
            this.da.SelectCommand = this.oleDbSelectCommand1;
            this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Title", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SongID", "SongID"),
                        new System.Data.Common.DataColumnMapping("Song", "Song"),
                        new System.Data.Common.DataColumnMapping("Artiste", "Artiste"),
                        new System.Data.Common.DataColumnMapping("Language", "Language"),
                        new System.Data.Common.DataColumnMapping("IssuingDate", "IssuingDate")})});
            this.da.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Music.mdb";
            // 
            // ds
            // 
            this.ds.DataSetName = "MusicDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs
            // 
            this.bs.DataMember = "Title";
            this.bs.DataSource = this.ds;
            // 
            // songIDDataGridViewTextBoxColumn
            // 
            this.songIDDataGridViewTextBoxColumn.DataPropertyName = "SongID";
            this.songIDDataGridViewTextBoxColumn.HeaderText = "SongID";
            this.songIDDataGridViewTextBoxColumn.Name = "songIDDataGridViewTextBoxColumn";
            // 
            // songDataGridViewTextBoxColumn
            // 
            this.songDataGridViewTextBoxColumn.DataPropertyName = "Song";
            this.songDataGridViewTextBoxColumn.HeaderText = "Song";
            this.songDataGridViewTextBoxColumn.Name = "songDataGridViewTextBoxColumn";
            // 
            // artisteDataGridViewTextBoxColumn
            // 
            this.artisteDataGridViewTextBoxColumn.DataPropertyName = "Artiste";
            this.artisteDataGridViewTextBoxColumn.HeaderText = "Artiste";
            this.artisteDataGridViewTextBoxColumn.Name = "artisteDataGridViewTextBoxColumn";
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            // 
            // issuingDateDataGridViewTextBoxColumn
            // 
            this.issuingDateDataGridViewTextBoxColumn.DataPropertyName = "IssuingDate";
            this.issuingDateDataGridViewTextBoxColumn.HeaderText = "IssuingDate";
            this.issuingDateDataGridViewTextBoxColumn.Name = "issuingDateDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 382);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter da;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bs;
        private MusicDataSet ds;
    }
}

