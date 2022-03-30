namespace objective_fit
{
    partial class WorkoutForm
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
            this.listViewExercises = new System.Windows.Forms.ListView();
            this.listViewWorkouts = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWorkoutName = new System.Windows.Forms.TextBox();
            this.dataGridViewExercises = new System.Windows.Forms.DataGridView();
            this.buttonCreateWorkout = new System.Windows.Forms.Button();
            this.buttonShowExercises = new System.Windows.Forms.Button();
            this.textBoxExerciseName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeleteWorkout = new System.Windows.Forms.Button();
            this.buttonRemoveExercise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewExercises
            // 
            this.listViewExercises.Location = new System.Drawing.Point(498, 82);
            this.listViewExercises.Name = "listViewExercises";
            this.listViewExercises.Size = new System.Drawing.Size(373, 166);
            this.listViewExercises.TabIndex = 0;
            this.listViewExercises.UseCompatibleStateImageBehavior = false;
            // 
            // listViewWorkouts
            // 
            this.listViewWorkouts.Location = new System.Drawing.Point(10, 30);
            this.listViewWorkouts.Name = "listViewWorkouts";
            this.listViewWorkouts.Size = new System.Drawing.Size(297, 218);
            this.listViewWorkouts.TabIndex = 1;
            this.listViewWorkouts.UseCompatibleStateImageBehavior = false;
            this.listViewWorkouts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewWorkouts_ItemSelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Treinos do Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exercícios Selecionados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Treino:";
            // 
            // textBoxWorkoutName
            // 
            this.textBoxWorkoutName.Location = new System.Drawing.Point(498, 28);
            this.textBoxWorkoutName.Name = "textBoxWorkoutName";
            this.textBoxWorkoutName.Size = new System.Drawing.Size(248, 23);
            this.textBoxWorkoutName.TabIndex = 5;
            // 
            // dataGridViewExercises
            // 
            this.dataGridViewExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExercises.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewExercises.Location = new System.Drawing.Point(10, 345);
            this.dataGridViewExercises.Name = "dataGridViewExercises";
            this.dataGridViewExercises.ReadOnly = true;
            this.dataGridViewExercises.RowTemplate.Height = 25;
            this.dataGridViewExercises.Size = new System.Drawing.Size(864, 206);
            this.dataGridViewExercises.TabIndex = 6;
            this.dataGridViewExercises.DoubleClick += new System.EventHandler(this.dataGridViewExercises_DoubleClick);
            // 
            // buttonCreateWorkout
            // 
            this.buttonCreateWorkout.Location = new System.Drawing.Point(498, 254);
            this.buttonCreateWorkout.Name = "buttonCreateWorkout";
            this.buttonCreateWorkout.Size = new System.Drawing.Size(194, 23);
            this.buttonCreateWorkout.TabIndex = 7;
            this.buttonCreateWorkout.Text = "Criar Treino";
            this.buttonCreateWorkout.UseVisualStyleBackColor = true;
            this.buttonCreateWorkout.Click += new System.EventHandler(this.buttonCreateWorkout_Click);
            // 
            // buttonShowExercises
            // 
            this.buttonShowExercises.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowExercises.Location = new System.Drawing.Point(10, 316);
            this.buttonShowExercises.Name = "buttonShowExercises";
            this.buttonShowExercises.Size = new System.Drawing.Size(227, 23);
            this.buttonShowExercises.TabIndex = 8;
            this.buttonShowExercises.Text = "Mostrar Todos os Exercícios";
            this.buttonShowExercises.UseVisualStyleBackColor = true;
            this.buttonShowExercises.Click += new System.EventHandler(this.buttonShowExercises_Click);
            // 
            // textBoxExerciseName
            // 
            this.textBoxExerciseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxExerciseName.Location = new System.Drawing.Point(243, 316);
            this.textBoxExerciseName.Name = "textBoxExerciseName";
            this.textBoxExerciseName.Size = new System.Drawing.Size(631, 23);
            this.textBoxExerciseName.TabIndex = 9;
            this.textBoxExerciseName.TextChanged += new System.EventHandler(this.textBoxExerciseName_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Filtrar Exercícios:";
            // 
            // buttonDeleteWorkout
            // 
            this.buttonDeleteWorkout.Location = new System.Drawing.Point(64, 254);
            this.buttonDeleteWorkout.Name = "buttonDeleteWorkout";
            this.buttonDeleteWorkout.Size = new System.Drawing.Size(152, 23);
            this.buttonDeleteWorkout.TabIndex = 11;
            this.buttonDeleteWorkout.Text = "Excluir Treino";
            this.buttonDeleteWorkout.UseVisualStyleBackColor = true;
            this.buttonDeleteWorkout.Click += new System.EventHandler(this.buttonDeleteWorkout_Click);
            // 
            // buttonRemoveExercise
            // 
            this.buttonRemoveExercise.Location = new System.Drawing.Point(698, 254);
            this.buttonRemoveExercise.Name = "buttonRemoveExercise";
            this.buttonRemoveExercise.Size = new System.Drawing.Size(173, 23);
            this.buttonRemoveExercise.TabIndex = 12;
            this.buttonRemoveExercise.Text = "Remover Exercício";
            this.buttonRemoveExercise.UseVisualStyleBackColor = true;
            this.buttonRemoveExercise.Click += new System.EventHandler(this.buttonRemoveExercise_Click);
            // 
            // WorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.textBoxExerciseName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonShowExercises);
            this.Controls.Add(this.buttonRemoveExercise);
            this.Controls.Add(this.buttonDeleteWorkout);
            this.Controls.Add(this.buttonCreateWorkout);
            this.Controls.Add(this.dataGridViewExercises);
            this.Controls.Add(this.textBoxWorkoutName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewWorkouts);
            this.Controls.Add(this.listViewExercises);
            this.Name = "WorkoutForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkoutForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewExercises;
        private ListView listViewWorkouts;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxWorkoutName;
        private DataGridView dataGridViewExercises;
        private Button buttonCreateWorkout;
        private Button buttonShowExercises;
        private TextBox textBoxExerciseName;
        private Label label4;
        private Button buttonDeleteWorkout;
        private Button buttonRemoveExercise;
    }
}