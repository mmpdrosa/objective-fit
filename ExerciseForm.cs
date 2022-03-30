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
    public partial class ExerciseForm : Form
    {
        private string id;

        public ExerciseForm(string _id)
        {
            InitializeComponent();
            
            id = _id;

            try
            {
                ExercisesRepository exercisesRepository = new ExercisesRepository();
                var exercise = exercisesRepository.findById(id);

                if (exercise != null)
                {
                    textBoxName.Text = exercise["name"].ToString();
                    textBoxBodyPart.Text = exercise["body_part"].ToString();
                    textBoxEquipment.Text = exercise["equipment"].ToString();
                    comboBoxDifficulty.Text = exercise["difficulty"].ToString();
                    textBoxSets.Text = exercise["sets"].ToString();
                    textBoxRepetitions.Text = exercise["repetitions"].ToString();
                    textBoxDescription.Text = exercise["description"].ToString();
                    textBoxCreated.Text = exercise["created_at"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var bodyPart = textBoxBodyPart.Text;
            var equipment = textBoxEquipment.Text;
            var difficulty = comboBoxDifficulty.Text;
            var sets = textBoxSets.Text;
            var repetitions = textBoxRepetitions.Text;
            var description = textBoxDescription.Text;

            try
            {
                ExercisesRepository exercisesRepository = new ExercisesRepository();
                exercisesRepository.update(id, name, bodyPart, equipment, difficulty, sets, repetitions, description);

                MessageBox.Show("Alterado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var op = MessageBox.Show("?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (op == DialogResult.Yes)
            {
                try
                {
                    ExercisesRepository exercisesRepository = new ExercisesRepository();
                    exercisesRepository.delete(id);

                    MessageBox.Show("Deletado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
        }
    }
}
