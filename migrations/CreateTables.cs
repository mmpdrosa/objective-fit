using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace objective_fit
{
    public class CreateTables
    {
        public void run()
        {
            try
            {
                string connectionString = "Server=localhost;Port=5432;Database=objective_fit;User Id=postgres;Password=docker;";

                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader reader;
                bool tableExists;

                cmd.CommandText = "SELECT EXISTS (SELECT FROM pg_tables WHERE schemaname = 'public' AND tablename = 'exercises');";
                reader = cmd.ExecuteReader();
                reader.Read();
                tableExists = (bool) reader["exists"];
                reader.Close();

                if (!tableExists)
                {
                    cmd.CommandText = "CREATE TABLE exercises (" +
                        "id UUID NOT NULL PRIMARY KEY," +
                        "name VARCHAR(255) NOT NULL," +
                        "body_part VARCHAR(255) NOT NULL," +
                        "equipment VARCHAR(255)," +
                        "difficulty VARCHAR(255)," +
                        "sets INT NOT NULL," +
                        "repetitions INT NOT NULL," +
                        "description VARCHAR(255)," +
                        "created_at TIMESTAMP DEFAULT now()" +
                        ");";
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }

                cmd.CommandText = "SELECT EXISTS (SELECT FROM pg_tables WHERE schemaname = 'public' AND tablename = 'workouts');";
                reader = cmd.ExecuteReader();
                reader.Read();
                tableExists = (bool) reader["exists"];
                reader.Close();

                if (!tableExists)
                {
                    cmd.CommandText = "CREATE TABLE workouts (" +
                        "id UUID NOT NULL PRIMARY KEY," +
                        "user_id UUID NOT NULL," +
                        "name VARCHAR(255) NOT NULL," +
                        "body_parts VARCHAR(255) NOT NULL," +
                        "created_at TIMESTAMP DEFAULT now()," +
                        "updated_at TIMESTAMP DEFAULT now()," +
                         "CONSTRAINT fk_user " +
                           "FOREIGN KEY(user_id) " +
                               "REFERENCES users(id) " +
                                  "ON DELETE CASCADE" +
                        ");";
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }

                cmd.CommandText = "SELECT EXISTS (SELECT FROM pg_tables WHERE schemaname = 'public' AND tablename = 'exercises_workouts');";
                reader = cmd.ExecuteReader();
                reader.Read();
                tableExists = (bool) reader["exists"];
                reader.Close();

                if (!tableExists)
                {
                    cmd.CommandText = "CREATE TABLE exercises_workouts (" +
                        "id UUID NOT NULL PRIMARY KEY," +
                        "workout_id UUID NOT NULL," +
                        "exercise_id UUID NOT NULL," +
                        "created_at TIMESTAMP DEFAULT now()," +
                        "CONSTRAINT fk_workout " +
                           "FOREIGN KEY(workout_id) " +
                                "REFERENCES workouts(id) " +
                                   "ON DELETE CASCADE," +
                        "CONSTRAINT fk_exercise " +
                           "FOREIGN KEY(exercise_id) " +
                               "REFERENCES exercises(id) " +
                                  "ON DELETE CASCADE" +
                        ")";
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }

                cmd.CommandText = "SELECT EXISTS (SELECT FROM pg_tables WHERE schemaname = 'public' AND tablename = 'users');";
                reader = cmd.ExecuteReader();
                reader.Read();
                tableExists = (bool) reader["exists"];
                reader.Close();
                if (!tableExists)
                {
                    cmd.CommandText = "CREATE TABLE users (" +
                        "id UUID NOT NULL PRIMARY KEY," +
                        "registration INT NOT NULL," +
                        "name VARCHAR(255) NOT NULL," +
                        "birthday TIMESTAMP," +
                        "gender VARCHAR(255) NOT NULL," +
                        "adress VARCHAR(255) NOT NULL," +
                        "phone VARCHAR(255) NOT NULL," +
                        "email VARCHAR(255) NOT NULL," +
                        "cpf VARCHAR(255) NOT NULL," +
                        "created_at TIMESTAMP DEFAULT now()," +
                        "updated_at TIMESTAMP DEFAULT now()" +
                        ");";
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }

                cmd.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}