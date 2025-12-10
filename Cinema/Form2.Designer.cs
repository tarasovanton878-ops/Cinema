namespace Cinema
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.cDataSet = new Cinema.CDataSet();
            this.расписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписаниеTableAdapter = new Cinema.CDataSetTableAdapters.РасписаниеTableAdapter();
            this.деньНеделисеансDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.понедельникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вторникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.средаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.четвергDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пятницаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.субботаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.воскресеньеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.деньНеделисеансDataGridViewTextBoxColumn,
            this.понедельникDataGridViewTextBoxColumn,
            this.вторникDataGridViewTextBoxColumn,
            this.средаDataGridViewTextBoxColumn,
            this.четвергDataGridViewTextBoxColumn,
            this.пятницаDataGridViewTextBoxColumn,
            this.субботаDataGridViewTextBoxColumn,
            this.воскресеньеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.расписаниеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(551, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Купить или забронировать билет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cDataSet
            // 
            this.cDataSet.DataSetName = "CDataSet";
            this.cDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // расписаниеBindingSource
            // 
            this.расписаниеBindingSource.DataMember = "Расписание";
            this.расписаниеBindingSource.DataSource = this.cDataSet;
            // 
            // расписаниеTableAdapter
            // 
            this.расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // деньНеделисеансDataGridViewTextBoxColumn
            // 
            this.деньНеделисеансDataGridViewTextBoxColumn.DataPropertyName = "День недели/сеанс";
            this.деньНеделисеансDataGridViewTextBoxColumn.HeaderText = "День недели/сеанс";
            this.деньНеделисеансDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.деньНеделисеансDataGridViewTextBoxColumn.Name = "деньНеделисеансDataGridViewTextBoxColumn";
            this.деньНеделисеансDataGridViewTextBoxColumn.Width = 125;
            // 
            // понедельникDataGridViewTextBoxColumn
            // 
            this.понедельникDataGridViewTextBoxColumn.DataPropertyName = "Понедельник";
            this.понедельникDataGridViewTextBoxColumn.HeaderText = "Понедельник";
            this.понедельникDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.понедельникDataGridViewTextBoxColumn.Name = "понедельникDataGridViewTextBoxColumn";
            this.понедельникDataGridViewTextBoxColumn.Width = 125;
            // 
            // вторникDataGridViewTextBoxColumn
            // 
            this.вторникDataGridViewTextBoxColumn.DataPropertyName = "Вторник";
            this.вторникDataGridViewTextBoxColumn.HeaderText = "Вторник";
            this.вторникDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.вторникDataGridViewTextBoxColumn.Name = "вторникDataGridViewTextBoxColumn";
            this.вторникDataGridViewTextBoxColumn.Width = 125;
            // 
            // средаDataGridViewTextBoxColumn
            // 
            this.средаDataGridViewTextBoxColumn.DataPropertyName = "Среда";
            this.средаDataGridViewTextBoxColumn.HeaderText = "Среда";
            this.средаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.средаDataGridViewTextBoxColumn.Name = "средаDataGridViewTextBoxColumn";
            this.средаDataGridViewTextBoxColumn.Width = 125;
            // 
            // четвергDataGridViewTextBoxColumn
            // 
            this.четвергDataGridViewTextBoxColumn.DataPropertyName = "Четверг";
            this.четвергDataGridViewTextBoxColumn.HeaderText = "Четверг";
            this.четвергDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.четвергDataGridViewTextBoxColumn.Name = "четвергDataGridViewTextBoxColumn";
            this.четвергDataGridViewTextBoxColumn.Width = 125;
            // 
            // пятницаDataGridViewTextBoxColumn
            // 
            this.пятницаDataGridViewTextBoxColumn.DataPropertyName = "Пятница";
            this.пятницаDataGridViewTextBoxColumn.HeaderText = "Пятница";
            this.пятницаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.пятницаDataGridViewTextBoxColumn.Name = "пятницаDataGridViewTextBoxColumn";
            this.пятницаDataGridViewTextBoxColumn.Width = 125;
            // 
            // субботаDataGridViewTextBoxColumn
            // 
            this.субботаDataGridViewTextBoxColumn.DataPropertyName = "Суббота";
            this.субботаDataGridViewTextBoxColumn.HeaderText = "Суббота";
            this.субботаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.субботаDataGridViewTextBoxColumn.Name = "субботаDataGridViewTextBoxColumn";
            this.субботаDataGridViewTextBoxColumn.Width = 125;
            // 
            // воскресеньеDataGridViewTextBoxColumn
            // 
            this.воскресеньеDataGridViewTextBoxColumn.DataPropertyName = "Воскресенье";
            this.воскресеньеDataGridViewTextBoxColumn.HeaderText = "Воскресенье";
            this.воскресеньеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.воскресеньеDataGridViewTextBoxColumn.Name = "воскресеньеDataGridViewTextBoxColumn";
            this.воскресеньеDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(575, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Расписание сеансов";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private CDataSet cDataSet;
        private System.Windows.Forms.BindingSource расписаниеBindingSource;
        private CDataSetTableAdapters.РасписаниеTableAdapter расписаниеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn деньНеделисеансDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn понедельникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вторникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn средаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn четвергDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пятницаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn субботаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn воскресеньеDataGridViewTextBoxColumn;
    }
}