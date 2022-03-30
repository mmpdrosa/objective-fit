namespace objective_fit
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.buttonUserWorkouts = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxRegistration = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCreateExercise = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRepetitions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSets = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxExerciseName = new System.Windows.Forms.TextBox();
            this.textBoxBodyPart = new System.Windows.Forms.TextBox();
            this.textBoxEquipment = new System.Windows.Forms.TextBox();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.dataGridViewExercises = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxUserName);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textBoxPhone);
            this.tabPage2.Controls.Add(this.buttonUserWorkouts);
            this.tabPage2.Controls.Add(this.textBoxRegistration);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBoxAdress);
            this.tabPage2.Controls.Add(this.buttonCreateUser);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.dataGridViewUsers);
            this.tabPage2.Controls.Add(this.textBoxCpf);
            this.tabPage2.Controls.Add(this.comboBoxGender);
            this.tabPage2.Controls.Add(this.textBoxEmail);
            this.tabPage2.Controls.Add(this.dateTimePickerBirthday);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(876, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alunos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreateUser.Location = new System.Drawing.Point(143, 245);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(146, 23);
            this.buttonCreateUser.TabIndex = 10;
            this.buttonCreateUser.Text = "Cadastrar Usuário";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // buttonUserWorkouts
            // 
            this.buttonUserWorkouts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUserWorkouts.Location = new System.Drawing.Point(561, 245);
            this.buttonUserWorkouts.Name = "buttonUserWorkouts";
            this.buttonUserWorkouts.Size = new System.Drawing.Size(115, 23);
            this.buttonUserWorkouts.TabIndex = 11;
            this.buttonUserWorkouts.Text = "Abrir Treinos";
            this.buttonUserWorkouts.UseVisualStyleBackColor = true;
            this.buttonUserWorkouts.Click += new System.EventHandler(this.buttonUserWorkouts_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewUsers.Location = new System.Drawing.Point(10, 274);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowTemplate.Height = 25;
            this.dataGridViewUsers.Size = new System.Drawing.Size(856, 249);
            this.dataGridViewUsers.TabIndex = 9;
            this.dataGridViewUsers.DoubleClick += new System.EventHandler(this.dataGridViewUsers_DoubleClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Registro:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Gênero:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 15);
            this.label15.TabIndex = 7;
            this.label15.Text = "CPF:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nome:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "E-mail:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(541, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Data de Nascimento:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "Telefone:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Endereço:";
            // 
            // textBoxRegistration
            // 
            this.textBoxRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRegistration.Location = new System.Drawing.Point(13, 28);
            this.textBoxRegistration.Name = "textBoxRegistration";
            this.textBoxRegistration.Size = new System.Drawing.Size(105, 23);
            this.textBoxRegistration.TabIndex = 8;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdress.Location = new System.Drawing.Point(13, 138);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(850, 23);
            this.textBoxAdress.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Location = new System.Drawing.Point(13, 83);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(506, 23);
            this.textBoxEmail.TabIndex = 10;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserName.Location = new System.Drawing.Point(143, 28);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(720, 23);
            this.textBoxUserName.TabIndex = 12;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhone.Location = new System.Drawing.Point(247, 195);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(223, 23);
            this.textBoxPhone.TabIndex = 13;
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCpf.Location = new System.Drawing.Point(13, 195);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(204, 23);
            this.textBoxCpf.TabIndex = 14;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(541, 83);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(322, 23);
            this.dateTimePickerBirthday.TabIndex = 15;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.comboBoxGender.Location = new System.Drawing.Point(496, 195);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(367, 23);
            this.comboBoxGender.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxDifficulty);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxSets);
            this.tabPage1.Controls.Add(this.buttonCreateExercise);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxExerciseName);
            this.tabPage1.Controls.Add(this.textBoxRepetitions);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxBodyPart);
            this.tabPage1.Controls.Add(this.textBoxDescription);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dataGridViewExercises);
            this.tabPage1.Controls.Add(this.textBoxEquipment);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(876, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Exercícios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCreateExercise
            // 
            this.buttonCreateExercise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreateExercise.Location = new System.Drawing.Point(201, 193);
            this.buttonCreateExercise.Name = "buttonCreateExercise";
            this.buttonCreateExercise.Size = new System.Drawing.Size(201, 23);
            this.buttonCreateExercise.TabIndex = 15;
            this.buttonCreateExercise.Text = "Criar Exercício";
            this.buttonCreateExercise.UseVisualStyleBackColor = true;
            this.buttonCreateExercise.Click += new System.EventHandler(this.buttonCreateExercise_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descrição:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDescription.Location = new System.Drawing.Point(427, 83);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(436, 133);
            this.textBoxDescription.TabIndex = 16;
            this.textBoxDescription.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parte do Corpo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equipamento:";
            // 
            // textBoxRepetitions
            // 
            this.textBoxRepetitions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRepetitions.Location = new System.Drawing.Point(107, 193);
            this.textBoxRepetitions.Name = "textBoxRepetitions";
            this.textBoxRepetitions.Size = new System.Drawing.Size(74, 23);
            this.textBoxRepetitions.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dificuldade:";
            // 
            // textBoxSets
            // 
            this.textBoxSets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSets.Location = new System.Drawing.Point(13, 193);
            this.textBoxSets.Name = "textBoxSets";
            this.textBoxSets.Size = new System.Drawing.Size(70, 23);
            this.textBoxSets.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Séries:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Repetições:";
            // 
            // textBoxExerciseName
            // 
            this.textBoxExerciseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxExerciseName.Location = new System.Drawing.Point(13, 28);
            this.textBoxExerciseName.Name = "textBoxExerciseName";
            this.textBoxExerciseName.Size = new System.Drawing.Size(438, 23);
            this.textBoxExerciseName.TabIndex = 8;
            // 
            // textBoxBodyPart
            // 
            this.textBoxBodyPart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBodyPart.Location = new System.Drawing.Point(475, 28);
            this.textBoxBodyPart.Name = "textBoxBodyPart";
            this.textBoxBodyPart.Size = new System.Drawing.Size(388, 23);
            this.textBoxBodyPart.TabIndex = 9;
            // 
            // textBoxEquipment
            // 
            this.textBoxEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEquipment.Location = new System.Drawing.Point(13, 83);
            this.textBoxEquipment.Name = "textBoxEquipment";
            this.textBoxEquipment.Size = new System.Drawing.Size(389, 23);
            this.textBoxEquipment.TabIndex = 10;
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil"});
            this.comboBoxDifficulty.Location = new System.Drawing.Point(13, 138);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(389, 23);
            this.comboBoxDifficulty.TabIndex = 14;
            // 
            // dataGridViewExercises
            // 
            this.dataGridViewExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExercises.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewExercises.Location = new System.Drawing.Point(10, 242);
            this.dataGridViewExercises.Name = "dataGridViewExercises";
            this.dataGridViewExercises.ReadOnly = true;
            this.dataGridViewExercises.RowTemplate.Height = 25;
            this.dataGridViewExercises.Size = new System.Drawing.Size(856, 281);
            this.dataGridViewExercises.TabIndex = 0;
            this.dataGridViewExercises.DoubleClick += new System.EventHandler(this.dataGridViewExercises_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Objective Fit";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridViewExercises;
        private TabPage tabPage2;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox textBoxEquipment;
        private TextBox textBoxBodyPart;
        private TextBox textBoxExerciseName;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBoxRepetitions;
        private TextBox textBoxSets;
        private Button buttonCreateExercise;
        private RichTextBox textBoxDescription;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button buttonCreateUser;
        private DataGridView dataGridViewUsers;
        private TextBox textBoxRegistration;
        private TextBox textBoxAdress;
        private TextBox textBoxEmail;
        private TextBox textBoxUserName;
        private TextBox textBoxPhone;
        private TextBox textBoxCpf;
        private Button buttonUserWorkouts;
        private DateTimePicker dateTimePickerBirthday;
        private ComboBox comboBoxGender;
        private ComboBox comboBoxDifficulty;
    }
}