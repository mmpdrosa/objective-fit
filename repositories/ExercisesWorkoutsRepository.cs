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
	public class ExercisesWorkoutsRepository : Repository 
    {
        public ExercisesWorkoutsRepository(): base("exercises_workouts") 
        {

        }

        public void create(string workout_id, string exercise_id) 
        {
            string id = Guid.NewGuid().ToString();

            command.CommandText = String.Format("INSERT INTO exercises_workouts (id, workout_id, exercise_id) " +
                "VALUES ('{0}', '{1}', '{2}');", id, workout_id, exercise_id);
            var reader = command.ExecuteReader();
            reader.Close();
        }

        public DataTable findByWorkoutId(string workout_id)
        {
            command.CommandText = String.Format("SELECT * FROM exercises_workouts WHERE workout_id='{0}';", workout_id);
            using (var exercisesWorkoutsReader = command.ExecuteReader())
            {
                DataTable exercisesWorkoutsDataTable = new DataTable();

                if (exercisesWorkoutsReader.HasRows)
                {
                    exercisesWorkoutsDataTable.Load(exercisesWorkoutsReader);
                }
                return exercisesWorkoutsDataTable;
            }
        }
    }
}