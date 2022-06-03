using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ТестовоеЗаданиеБД
{
    public partial class MainForm : Form
    {
        Database db = new Database();

        public MainForm()
        {
            InitializeComponent();
            db.LoadFullList(dataTableView);
        }

        //вывод списка сотрудников
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if(JobsSelect.SelectedItem == JobsSelect.Items[0])
            {
                db.LoadFullList(dataTableView);
            }
            else
            {
                string condition = JobsSelect.SelectedItem.ToString();
                db.LoadListofJob(dataTableView, condition);
            }
        }

        //Добавление нового
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            EditTable editForm = new EditTable();
            editForm.Show();
        }

        //Изменение
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditTable editForm = new EditTable(dataTableView.CurrentRow);
            editForm.Show();
        }

        //Удаление
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            db.DeleteQuery(dataTableView);
            db.LoadFullList(dataTableView);
        }

        private void btnGrand_Click(object sender, EventArgs e)
        {
            db.GrandOrRevokeQuery(Database.GrandRevoke.Grand, Int32.Parse(dataTableView.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            db.GrandOrRevokeQuery(Database.GrandRevoke.Revoke, Int32.Parse(dataTableView.CurrentRow.Cells[0].Value.ToString()));
        }
    }
}
