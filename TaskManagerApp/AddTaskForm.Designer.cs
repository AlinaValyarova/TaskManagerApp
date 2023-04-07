
namespace TaskManagerApp
{
    partial class AddTaskForm
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
            this.DoToDTP = new System.Windows.Forms.DateTimePicker();
            this.RepeatingCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddTaskBTN = new System.Windows.Forms.Button();
            this.Teams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeadLintDTP = new System.Windows.Forms.DateTimePicker();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.PersonGTaskL = new System.Windows.Forms.Label();
            this.PersonEmailGeneralTask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DoToDTP
            // 
            this.DoToDTP.Location = new System.Drawing.Point(390, 133);
            this.DoToDTP.Name = "DoToDTP";
            this.DoToDTP.Size = new System.Drawing.Size(200, 22);
            this.DoToDTP.TabIndex = 3;
            // 
            // RepeatingCheckBox
            // 
            this.RepeatingCheckBox.AutoSize = true;
            this.RepeatingCheckBox.Location = new System.Drawing.Point(404, 82);
            this.RepeatingCheckBox.Name = "RepeatingCheckBox";
            this.RepeatingCheckBox.Size = new System.Drawing.Size(189, 21);
            this.RepeatingCheckBox.TabIndex = 4;
            this.RepeatingCheckBox.Text = "Повторяющаяся задача";
            this.RepeatingCheckBox.UseVisualStyleBackColor = true;
            this.RepeatingCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddTaskBTN
            // 
            this.AddTaskBTN.Location = new System.Drawing.Point(426, 254);
            this.AddTaskBTN.Name = "AddTaskBTN";
            this.AddTaskBTN.Size = new System.Drawing.Size(164, 43);
            this.AddTaskBTN.TabIndex = 7;
            this.AddTaskBTN.Text = "Добавить задачу";
            this.AddTaskBTN.UseVisualStyleBackColor = true;
            this.AddTaskBTN.Click += new System.EventHandler(this.AddTaskBTN_Click);
            // 
            // Teams
            // 
            this.Teams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Teams.FormattingEnabled = true;
            this.Teams.Items.AddRange(new object[] {
            "Личная",
            "Общая"});
            this.Teams.Location = new System.Drawing.Point(468, 18);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(121, 24);
            this.Teams.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // DeadLintDTP
            // 
            this.DeadLintDTP.Location = new System.Drawing.Point(390, 178);
            this.DeadLintDTP.Name = "DeadLintDTP";
            this.DeadLintDTP.Size = new System.Drawing.Size(200, 22);
            this.DeadLintDTP.TabIndex = 16;
            // 
            // TaskName
            // 
            this.TaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TaskName.Location = new System.Drawing.Point(11, 18);
            this.TaskName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(383, 38);
            this.TaskName.TabIndex = 17;
            this.TaskName.Text = "Название задачи";
            this.TaskName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskName_MouseDown);
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Description.Location = new System.Drawing.Point(11, 78);
            this.Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(383, 26);
            this.Description.TabIndex = 18;
            this.Description.Text = "Описание";
            this.Description.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Description_MouseDown);
            // 
            // PersonGTaskL
            // 
            this.PersonGTaskL.AutoSize = true;
            this.PersonGTaskL.Location = new System.Drawing.Point(11, 158);
            this.PersonGTaskL.Name = "PersonGTaskL";
            this.PersonGTaskL.Size = new System.Drawing.Size(228, 17);
            this.PersonGTaskL.TabIndex = 19;
            this.PersonGTaskL.Text = "С кем будете выполнять задачу?";
            this.PersonGTaskL.Click += new System.EventHandler(this.PersonGTaskL_Click);
            // 
            // PersonEmailGeneralTask
            // 
            this.PersonEmailGeneralTask.Location = new System.Drawing.Point(14, 201);
            this.PersonEmailGeneralTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PersonEmailGeneralTask.Name = "PersonEmailGeneralTask";
            this.PersonEmailGeneralTask.Size = new System.Drawing.Size(240, 22);
            this.PersonEmailGeneralTask.TabIndex = 20;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(610, 314);
            this.Controls.Add(this.PersonEmailGeneralTask);
            this.Controls.Add(this.PersonGTaskL);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.DeadLintDTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.AddTaskBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RepeatingCheckBox);
            this.Controls.Add(this.DoToDTP);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DoToDTP;
        private System.Windows.Forms.CheckBox RepeatingCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddTaskBTN;
        private System.Windows.Forms.ComboBox Teams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DeadLintDTP;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label PersonGTaskL;
        private System.Windows.Forms.TextBox PersonEmailGeneralTask;
    }
}