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
	public class ExercisesRepository : Repository
    {
        public ExercisesRepository() : base("exercises")
        {
    
        }
		
        public void create(string name, string bodyPart, string equipment, string difficulty, string sets, string repetitions, string description)
        {
            string id = Guid.NewGuid().ToString();

            command.CommandText = String.Format("INSERT INTO exercises (id, name, body_part, equipment, difficulty, sets, repetitions, description) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, '{7}');", id, name, bodyPart, equipment, difficulty, sets, repetitions, description);
            var reader = command.ExecuteReader();
            reader.Close();
        }

        public void update(string id, string name, string bodyPart, string equipment, string difficulty, string sets, string repetitions, string description)
        {
            command.CommandText = String.Format("UPDATE exercises SET name='{0}', body_part='{1}', equipment='{2}', difficulty='{3}', sets={4}, repetitions={5}, description='{6}' " +
                "WHERE id='{7}'", name, bodyPart, equipment, difficulty, sets, repetitions, description, id);
            command.ExecuteReader();
        }
    }
}