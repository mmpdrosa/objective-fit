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
    public partial class UserForm : Form
    {
        private string id;

        public UserForm(string _id)
        {
            id = _id;

            InitializeComponent();

            try
            {
                UsersRepository usersRepository = new UsersRepository();
                var user = usersRepository.findById(id);

                if (user != null)
                {
                    textBoxRegistration.Text = user["registration"].ToString();
                    textBoxName.Text = user["name"].ToString();
                    dateTimePickerBirthday.Text = user["birthday"].ToString();
                    comboBoxGender.Text = user["gender"].ToString();
                    textBoxAdress.Text = user["adress"].ToString();
                    textBoxPhone.Text = user["phone"].ToString();
                    textBoxEmail.Text = user["email"].ToString();
                    textBoxCpf.Text = user["cpf"].ToString();
                    textBoxCreated.Text = user["created_at"].ToString();
                    textBoxUpdated.Text = user["updated_at"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string registration = textBoxRegistration.Text;
            string name = textBoxName.Text;
            string birthday = DateTime.Parse(dateTimePickerBirthday.Text).ToString("MM/dd/yyyy HH:mm:ss");
            string gender = comboBoxGender.Text;
            string adress = textBoxAdress.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string cpf = textBoxCpf.Text;

            try
            {
                UsersRepository usersRepository = new UsersRepository();
                usersRepository.update(id, registration, name, birthday, gender, adress, phone, email, cpf);

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
                    UsersRepository usersRepository = new UsersRepository();
                    usersRepository.delete(id);

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
