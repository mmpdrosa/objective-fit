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
	public class WorkoutsRepository : Repository 
    {
        public WorkoutsRepository(): base("workouts") 
        {

        }

        public void create(string user_id, string name, string body_parts, List<string> exercises_ids) 
        {
            string id = Guid.NewGuid().ToString();

            command.CommandText = String.Format("INSERT INTO workouts (id, user_id, name, body_parts) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}');", id, user_id, name, body_parts);
            var reader = command.ExecuteReader();
            reader.Close();

            ExercisesWorkoutsRepository exercisesWorkoutsRepository = new ExercisesWorkoutsRepository();

            exercises_ids.ForEach(exercise_id => exercisesWorkoutsRepository.create(id, exercise_id));
        }

        public DataTable findByUserId(string user_id)
        {
            command.CommandText = String.Format("SELECT * FROM workouts WHERE user_id='{0}';", user_id);
            using (var workoutsReader = command.ExecuteReader())
            {
                DataTable workoutsDataTable = new DataTable();

                if (workoutsReader.HasRows)
                {
                    workoutsDataTable.Load(workoutsReader);
                }
                return workoutsDataTable;
            }
        }
    }
}