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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CreateTables migration = new CreateTables();
            migration.run();

            dataGridViewExercises.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToAddRows = false;

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

                UsersRepository usersRepository = new UsersRepository();
                DataTable usersDataTable = usersRepository.list();
                dataGridViewUsers.DataSource = usersDataTable;

                if (dataGridViewUsers.Rows.Count != 0)
                {
                    dataGridViewUsers.Columns["id"].Visible = false;
                    dataGridViewUsers.Columns["created_at"].Visible = false;
                    dataGridViewUsers.Columns["updated_at"].Visible = false;

                }

                dataGridViewUsers.AutoResizeColumns();
                dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCreateExercise_Click(object sender, EventArgs e)
        {
            string name = textBoxExerciseName.Text;
            string bodyPart = textBoxBodyPart.Text;
            string equipment = textBoxEquipment.Text;
            string difficulty = comboBoxDifficulty.Text;
            string sets = textBoxSets.Text;
            string repetitions = textBoxRepetitions.Text;
            string description = textBoxDescription.Text;

            try
            {
                ExercisesRepository exercisesRepository = new ExercisesRepository();
                exercisesRepository.create(name, bodyPart, equipment, difficulty, sets, repetitions, description);

                MessageBox.Show("Criado!");

                textBoxExerciseName.Text = "";
                textBoxBodyPart.Text = "";
                textBoxEquipment.Text = "";
                comboBoxDifficulty.Text = "";
                textBoxSets.Text = "";
                textBoxRepetitions.Text = "";
                textBoxDescription.Text = "";

                DataTable exercisesDataTable = exercisesRepository.list();
                dataGridViewExercises.DataSource = exercisesDataTable;
                dataGridViewExercises.Columns["id"].Visible = false;
                dataGridViewExercises.Columns["created_at"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewExercises_DoubleClick(object sender, EventArgs e)
        {
            var rowIndex = dataGridViewExercises.CurrentCell.RowIndex;
            var id = dataGridViewExercises.Rows[rowIndex].Cells["id"].Value.ToString();
            ExerciseForm exerciseForm = new ExerciseForm(id);
            exerciseForm.ShowDialog();

            try
            {
                ExercisesRepository exercisesRepository = new ExercisesRepository();
                DataTable exercisesDataTable = exercisesRepository.list();
                dataGridViewExercises.DataSource = exercisesDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            string registration = textBoxRegistration.Text;
            string name = textBoxUserName.Text;
            string birthday = DateTime.Parse(dateTimePickerBirthday.Text).ToString("MM/dd/yyyy HH:mm:ss");
            string gender = comboBoxGender.Text;
            string adress = textBoxAdress.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string cpf = textBoxCpf.Text;

            try
            {
                UsersRepository usersRepository = new UsersRepository();
                usersRepository.create(registration, name, birthday, gender, adress, phone, email, cpf);

                MessageBox.Show("Criado!");

                textBoxRegistration.Text = "";
                textBoxUserName.Text = "";
                comboBoxGender.Text = "";
                textBoxAdress.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxCpf.Text = "";

                DataTable usersDataTable = usersRepository.list();
                dataGridViewUsers.DataSource = usersDataTable;
                dataGridViewUsers.Columns["id"].Visible = false;
                dataGridViewUsers.Columns["created_at"].Visible = false;
                dataGridViewUsers.Columns["updated_at"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUsers_DoubleClick(object sender, EventArgs e)
        {
            var rowIndex = dataGridViewUsers.CurrentCell.RowIndex;
            var id = dataGridViewUsers.Rows[rowIndex].Cells["id"].Value.ToString();
            UserForm exerciseForm = new UserForm(id);
            exerciseForm.ShowDialog();

            try
            {
                UsersRepository usersRepository = new UsersRepository();
                DataTable usersDataTable = usersRepository.list();
                dataGridViewUsers.DataSource = usersDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUserWorkouts_Click(object sender, EventArgs e)
        {
            var rowIndex = dataGridViewUsers.CurrentCell.RowIndex;
            var id = dataGridViewUsers.Rows[rowIndex].Cells["id"].Value.ToString();
            WorkoutForm workoutForm = new WorkoutForm(id);
            workoutForm.ShowDialog();
        }
    }
}
