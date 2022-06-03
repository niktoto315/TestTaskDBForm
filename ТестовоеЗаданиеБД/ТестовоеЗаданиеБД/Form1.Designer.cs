
namespace ТестовоеЗаданиеБД
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataTableView = new System.Windows.Forms.DataGridView();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.JobsSelect = new System.Windows.Forms.ComboBox();
            this.btnGrand = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableView
            // 
            this.dataTableView.AllowUserToAddRows = false;
            this.dataTableView.AllowUserToDeleteRows = false;
            this.dataTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTableView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableView.Location = new System.Drawing.Point(12, 95);
            this.dataTableView.Name = "dataTableView";
            this.dataTableView.ReadOnly = true;
            this.dataTableView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableView.Size = new System.Drawing.Size(860, 354);
            this.dataTableView.TabIndex = 0;
            this.dataTableView.VirtualMode = true;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(12, 12);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(100, 50);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Выборка по должностям\r\n";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(224, 12);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 50);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(330, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 50);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(118, 12);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(100, 50);
            this.buttonInsert.TabIndex = 4;
            this.buttonInsert.Text = "Добавить";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // JobsSelect
            // 
            this.JobsSelect.FormattingEnabled = true;
            this.JobsSelect.Items.AddRange(new object[] {
            "Все",
            "Директор",
            "Руководитель подразделения",
            "Контроллер",
            "Рабочий"});
            this.JobsSelect.Location = new System.Drawing.Point(12, 68);
            this.JobsSelect.Name = "JobsSelect";
            this.JobsSelect.Size = new System.Drawing.Size(100, 21);
            this.JobsSelect.TabIndex = 5;
            this.JobsSelect.Text = "Все";
            // 
            // btnGrand
            // 
            this.btnGrand.Location = new System.Drawing.Point(436, 12);
            this.btnGrand.Name = "btnGrand";
            this.btnGrand.Size = new System.Drawing.Size(100, 50);
            this.btnGrand.TabIndex = 6;
            this.btnGrand.Text = "Повысить";
            this.btnGrand.UseVisualStyleBackColor = true;
            this.btnGrand.Click += new System.EventHandler(this.btnGrand_Click);
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(542, 12);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(100, 50);
            this.btnRevoke.TabIndex = 7;
            this.btnRevoke.Text = "Понизить";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnRevoke);
            this.Controls.Add(this.btnGrand);
            this.Controls.Add(this.JobsSelect);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.dataTableView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseView";
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTableView;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ComboBox JobsSelect;
        private System.Windows.Forms.Button btnGrand;
        private System.Windows.Forms.Button btnRevoke;
    }
}

