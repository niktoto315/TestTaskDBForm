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
    class Database
    {
        private string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=MyDatabase.mdb";
        OleDbConnection connection;
        public enum GrandRevoke{
            Grand,
            Revoke
        };

        public void OpenConnection()
        {
            connection = new OleDbConnection(connectString);
            connection.Open();
        }

        public void CloseConnection()
        {
            connection = new OleDbConnection(connectString);
            connection.Close();
        }

        public void LoadFullList(DataGridView dataTableView)
        {
            OpenConnection(); 
            string query = "SELECT * FROM [Сотрудники]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "[Сотрудники]");
            dataTableView.DataSource = dataSet.Tables["[Сотрудники]"];
            CloseConnection();
        }

        public void LoadListofJob(DataGridView dataTableView, string condition)
        {
            OpenConnection();
            string query = "SELECT * " +
                           "FROM [Сотрудники] " +
                           "WHERE [Должность]='" + condition + "'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "[Сотрудники]");
            dataTableView.DataSource = dataSet.Tables["[Сотрудники]"];
            CloseConnection();
        }

        public void DeleteQuery(DataGridView dataTableView)
        {
            OpenConnection();
            OleDbCommand command;

            DialogResult confirm = MessageBox.Show(
                "Вы действительно хотите удалить эту запись, отменить это дейтсвие будет невозможно", 
                "Подтверждение",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question
                );

            if(confirm == DialogResult.Yes)
            {
                string query = "DELETE FROM [Сотрудники] WHERE [Код]=@id";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@id", dataTableView.CurrentRow.Cells[0].Value);
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public void UpdateQuery(string[] values, int id)
        {
            OpenConnection();
            OleDbCommand command;
            string query = "UPDATE [Сотрудники] SET " +
                            "[ФИО]='" + values[0] + "', " +
                            "[Дата рождения]='" + values[1] + "', " +
                            "[Пол]='" + values[2] + "' WHERE [Код]=@id";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            CloseConnection();

            /* not working: not updated
            string query = "UPDATE [Сотрудники] SET [ФИО]=@Name WHERE [Код]=@id";
            command.Parameters.AddWithValue("@Name", values[0]);
            command.Parameters.AddWithValue("@Date", values[1]);
            command.Parameters.AddWithValue("@Gender", values[2]);
            */
        }

        public void InsertQuery(string[] values)
        {
            OpenConnection();
            OleDbCommand command;

            string query = "INSERT INTO [Сотрудники] ([ФИО], [Дата рождения], [Пол], [Должность]) VALUES (@Name, @Date, @Gender, @Job)";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@Name", values[0]);
            command.Parameters.AddWithValue("@Date", values[1]);
            command.Parameters.AddWithValue("@Gender", values[2]);
            command.Parameters.AddWithValue("@Job", values[3]);
            command.ExecuteNonQuery();
            MessageBox.Show(command.CommandText);

            CloseConnection();
        }

        public void GrandOrRevokeQuery(GrandRevoke grandRevoke, int id)
        {
            OleDbCommand command;
            OpenConnection();
            string currentJob = "SELECT [Должность] FROM [Сотрудники] WHERE [Код]=@id";
            command = new OleDbCommand(currentJob, connection);
            command.Parameters.AddWithValue("@id", id);
            currentJob = command.ExecuteScalar().ToString();
            if (grandRevoke == GrandRevoke.Grand)
            {
                switch (currentJob)
                {
                    case "Рабочий": currentJob = "Контроллер"; break;
                    case "Контроллер": currentJob = "Руководитель подразделения"; break;
                }
            }
            else
            {
                switch (currentJob)
                {
                    case "Руководитель подразделения": currentJob = "Контроллер"; break;
                    case "Контроллер": currentJob = "Рабочий"; break;
                }
            }
            string query = "UPDATE [Сотрудники] SET [Должность]='" + currentJob + "' WHERE [Код]=@id";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
