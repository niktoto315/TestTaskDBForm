using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТестовоеЗаданиеБД
{
    public partial class EditTable : Form
    {
        private int id;
        private string Mode;

        public EditTable()
        {
            InitializeComponent();
            Mode = "insert";
        }

        public EditTable(DataGridViewRow row)
        {
            InitializeComponent();
            id = Int32.Parse(row.Cells[0].Value.ToString());
            NameInput.Text = row.Cells[1].Value.ToString();
            DateInput.Value = DateTime.Parse(row.Cells[2].Value.ToString());
            GenderInput.SelectedItem = row.Cells[3].Value.ToString();
            JobInput.SelectedItem = row.Cells[4].Value.ToString();
            Mode = "update";
            JobInput.Enabled = false;

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            string[] values = {
                    NameInput.Text,
                    DateInput.Value.ToString(),
                    GenderInput.SelectedItem.ToString(),
                    JobInput.SelectedItem.ToString()
            };
            Database db = new Database();
            if (Mode == "update")
            {
                db.UpdateQuery(values, id);
            }
            else if (Mode == "insert")
            {
                db.InsertQuery(values);
            }
            this.Dispose();
        }
    }
}
