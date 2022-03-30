using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace objective_fit
{ 
	public class Repository 
    {
        protected NpgsqlConnection connection;
        protected NpgsqlCommand command;
        private String tableName;

        public Repository(String _tableName)
        {
			tableName = _tableName;

            string connectionString = "Server=localhost;Port=5432;Database=objective_fit;User Id=postgres;Password=docker;";
            connection = new NpgsqlConnection(connectionString);
            connection.Open();

            command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }

        ~Repository()
        {
            try
            {
                command.Dispose();
                connection.Close();
            } catch { }
        }

		public DataTable list()
        {
            command.CommandText = String.Format("SELECT * FROM {0};", tableName);
            using (var exercisesReader = command.ExecuteReader())
            {
                DataTable exercisesDataTable = new DataTable();

                if (exercisesReader.HasRows)
                {
                    exercisesDataTable.Load(exercisesReader);
                }
                return exercisesDataTable;
            }
        }

		public NpgsqlDataReader findById(string id)
        {
            command.CommandText = String.Format("SELECT * FROM {0} WHERE id='{1}'", tableName, id);
            var dataReader = command.ExecuteReader();

            dataReader.Read();

            return dataReader;
        }

		public void delete(string id)
        {
            command.CommandText = String.Format("DELETE FROM {0} WHERE id='{1}'", tableName, id);
            var reader = command.ExecuteReader();
            reader.Close();
        }
	}
}