
namespace ТестовоеЗаданиеБД
{
    partial class EditTable
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
            this.GenderInput = new System.Windows.Forms.ComboBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.DateInput = new System.Windows.Forms.DateTimePicker();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JobInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenderInput
            // 
            this.GenderInput.FormattingEnabled = true;
            this.GenderInput.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.GenderInput.Location = new System.Drawing.Point(47, 130);
            this.GenderInput.Name = "GenderInput";
            this.GenderInput.Size = new System.Drawing.Size(245, 21);
            this.GenderInput.TabIndex = 0;
            this.GenderInput.Text = "Мужской";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(142, 203);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(150, 50);
            this.SendBtn.TabIndex = 1;
            this.SendBtn.Text = "Добавить или редактировать";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // DateInput
            // 
            this.DateInput.Location = new System.Drawing.Point(47, 91);
            this.DateInput.Name = "DateInput";
            this.DateInput.Size = new System.Drawing.Size(245, 20);
            this.DateInput.TabIndex = 2;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(47, 52);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(245, 20);
            this.NameInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пол:";
            // 
            // JobInput
            // 
            this.JobInput.FormattingEnabled = true;
            this.JobInput.Items.AddRange(new object[] {
            "Директор",
            "Руководитель подразделения",
            "Контроллер",
            "Рабочий"});
            this.JobInput.Location = new System.Drawing.Point(47, 176);
            this.JobInput.Name = "JobInput";
            this.JobInput.Size = new System.Drawing.Size(245, 21);
            this.JobInput.TabIndex = 8;
            this.JobInput.Text = "Рабочий";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Должность:";
            // 
            // EditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 265);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JobInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.DateInput);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.GenderInput);
            this.Name = "EditTable";
            this.Text = "EditTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GenderInput;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.DateTimePicker DateInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox JobInput;
        private System.Windows.Forms.Label label4;
    }
}