using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace objective_fit
{
    public partial class WorkoutForm : Form
    {
        private string user_id;
        private List<string> exercises_ids;
        private List<string> exercises_names;
        private List<string> exercises_body_parts;
        private DataTable workouts;

        public WorkoutForm(string _id)
        {
            InitializeComponent();

            user_id = _id;
            exercises_ids = new List<string>();
            exercises_names = new List<string>();
            exercises_body_parts = new List<string>();

            dataGridViewExercises.AllowUserToAddRows = false;
            listViewExercises.View = View.List;
            listViewWorkouts.View = View.List;

            WorkoutsRepository workoutsRepository = new WorkoutsRepository();
            DataTable workoutsDataTable = workoutsRepository.findByUserId(user_id);
            workouts = workoutsDataTable;

            for (int i = 0; i < workoutsDataTable.Rows.Count; i++)
            {
                listViewWorkouts.Items.Add(workoutsDataTable.Rows[i].Field<string>(2));
            }

            showExercises();
        }

        private void dataGridViewExercises_DoubleClick(object sender, EventArgs e)
        {
            var rowIndex = dataGridViewExercises.CurrentCell.RowIndex;
            var exercise_id = dataGridViewExercises.Rows[rowIndex].Cells["id"].Value.ToString();
            var exercise_name = dataGridViewExercises.Rows[rowIndex].Cells["name"].Value.ToString();
            var exercise_body_part = dataGridViewExercises.Rows[rowIndex].Cells["body_part"].Value.ToString();

            if (!exercises_ids.Contains(exercise_id))
            {
                exercises_ids.Add(exercise_id);
                exercises_names.Add(exercise_name);

                foreach (string body_part in exercise_body_part.Split(",").ToList<string>())
                {
                    if (!exercises_body_parts.Contains(body_part))
                    {
                        exercises_body_parts.Add(body_part);
                    }
                }
                
            }

            showSelectedExercises();
        }

        private void showSelectedExercises()
        {
            listViewExercises.Items.Clear();
            exercises_names.ForEach(exercise_name => listViewExercises.Items.Add(exercise_name, 10));
        }

        private void buttonCreateWorkout_Click(object sender, EventArgs e)
        {
            if (!!exercises_ids.Any() && textBoxWorkoutName.Text != "")
            {
                try
                {
                    var workoutName = textBoxWorkoutName.Text;
                    var bodyParts = String.Join(", ", exercises_body_parts.ToArray());

                    WorkoutsRepository workoutsRepository = new WorkoutsRepository();
                    workoutsRepository.create(user_id, workoutName, bodyParts, exercises_ids);

                    listViewExercises.Items.Clear();
                    exercises_ids.Clear();
                    exercises_names.Clear();
                    exercises_body_parts.Clear();

                    MessageBox.Show("Criado!");

                    
                    listViewWorkouts.Items.Clear();
                    textBoxWorkoutName.Text = "";

                    DataTable workoutsDataTable = workoutsRepository.findByUserId(user_id);
                    workouts = workoutsDataTable;

                    for (int i = 0; i < workoutsDataTable.Rows.Count; i++)
                    {
                        listViewWorkouts.Items.Add(workoutsDataTable.Rows[i].Field<string>(2));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Faltando Informações!");
            }
        }

        private void buttonShowExercises_Click(object sender, EventArgs e)
        {
            showExercises();
        }

        private void textBoxExerciseName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxExerciseName.Text != "")
            {
                (dataGridViewExercises.DataSource as DataTable).DefaultView.RowFilter = string.Format("name like '%{0}%'", textBoxExerciseName.Text);
            }
            else
            {
                showExercises();
            }
        }

        private void showExercises()
        {
            try
            {
                ExercisesRepository exercisesRepository = new ExercisesRepository();
                DataTable exercisesDataTable = exercisesRepository.list();
                dataGridViewExercises.DataSource = exercisesDataTable;

                if (dataGridViewExercises.Rows.Count != 0)
                {
                    dataGridViewExercises.Columns["id"].Visible = false;
                    dataGridViewExercises.Columns["created_at"].Visible = false;
                }

                dataGridViewExercises.AutoResizeColumns();
                dataGridViewExercises.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewWorkouts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewWorkouts.SelectedItems.Count > 0)
            {
                int itemSelectedIndex = listViewWorkouts.SelectedItems[0].Index;
                var workoutId = workouts.Rows[itemSelectedIndex]["id"].ToString();

                ExercisesWorkoutsRepository exercisesWorkoutsRepository = new ExercisesWorkoutsRepository();
                DataTable exercisesWorkoutsDataTable = exercisesWorkoutsRepository.findByWorkoutId(workoutId);
                List<string> exercises_ids = new List<string>(exercisesWorkoutsDataTable.Rows.Count);

                foreach (DataRow row in exercisesWorkoutsDataTable.Rows)
                {
                    exercises_ids.Add("id = '" + row["exercise_id"].ToString() + "'");
                }

                showExercises();

                (dataGridViewExercises.DataSource as DataTable).DefaultView.RowFilter = String.Join(" OR ", exercises_ids);
            }
        }

        private void buttonDeleteWorkout_Click(object sender, EventArgs e)
        {
            if (listViewWorkouts.SelectedItems.Count > 0)
            {

                int itemSelectedIndex = listViewWorkouts.SelectedItems[0].Index;

                WorkoutsRepository workoutsRepository = new WorkoutsRepository();
                var workoutId = workouts.Rows[itemSelectedIndex]["id"].ToString();
                workoutsRepository.delete(workoutId);

                listViewWorkouts.Items.Clear();

                MessageBox.Show("Deletado!");

                DataTable workoutsDataTable = workoutsRepository.findByUserId(user_id);

                workouts = workoutsDataTable;

                for (int i = 0; i < workoutsDataTable.Rows.Count; i++)
                {
                    listViewWorkouts.Items.Add(workoutsDataTable.Rows[i].Field<string>(2));
                }
            }
        }

        private void buttonRemoveExercise_Click(object sender, EventArgs e)
        {
            if (listViewExercises.SelectedItems.Count > 0)
            {
                int itemSelectedIndex = listViewExercises.SelectedItems[0].Index;
                listViewExercises.Items.RemoveAt(itemSelectedIndex);
                exercises_ids.RemoveAt(itemSelectedIndex);
                exercises_names.RemoveAt(itemSelectedIndex);
                exercises_body_parts.RemoveAt(itemSelectedIndex);
            }
        }
    }
}
