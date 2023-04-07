
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
            this.DoToDTP.Location = new System.Drawing.Point(439, 166);
            this.DoToDTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoToDTP.Name = "DoToDTP";
            this.DoToDTP.Size = new System.Drawing.Size(224, 26);
            this.DoToDTP.TabIndex = 3;
            // 
            // RepeatingCheckBox
            // 
            this.RepeatingCheckBox.AutoSize = true;
            this.RepeatingCheckBox.Location = new System.Drawing.Point(454, 103);
            this.RepeatingCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RepeatingCheckBox.Name = "RepeatingCheckBox";
            this.RepeatingCheckBox.Size = new System.Drawing.Size(220, 24);
            this.RepeatingCheckBox.TabIndex = 4;
            this.RepeatingCheckBox.Text = "Повторяющаяся задача";
            this.RepeatingCheckBox.UseVisualStyleBackColor = true;
            this.RepeatingCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddTaskBTN
            // 
            this.AddTaskBTN.Location = new System.Drawing.Point(479, 317);
            this.AddTaskBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddTaskBTN.Name = "AddTaskBTN";
            this.AddTaskBTN.Size = new System.Drawing.Size(184, 54);
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
            this.Teams.Location = new System.Drawing.Point(527, 23);
            this.Teams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(136, 28);
            this.Teams.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-14, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // DeadLintDTP
            // 
            this.DeadLintDTP.Location = new System.Drawing.Point(439, 223);
            this.DeadLintDTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeadLintDTP.Name = "DeadLintDTP";
            this.DeadLintDTP.Size = new System.Drawing.Size(224, 26);
            this.DeadLintDTP.TabIndex = 16;
            // 
            // TaskName
            // 
            this.TaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TaskName.Location = new System.Drawing.Point(12, 23);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(430, 44);
            this.TaskName.TabIndex = 17;
            this.TaskName.Text = "Название задачи";
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Description.Location = new System.Drawing.Point(12, 97);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(430, 30);
            this.Description.TabIndex = 18;
            this.Description.Text = "Описание";
            // 
            // PersonGTaskL
            // 
            this.PersonGTaskL.AutoSize = true;
            this.PersonGTaskL.Location = new System.Drawing.Point(12, 198);
            this.PersonGTaskL.Name = "PersonGTaskL";
            this.PersonGTaskL.Size = new System.Drawing.Size(274, 20);
            this.PersonGTaskL.TabIndex = 19;
            this.PersonGTaskL.Text = "Ваш компаньон для общей задачи";
            // 
            // PersonEmailGeneralTask
            // 
            this.PersonEmailGeneralTask.Location = new System.Drawing.Point(16, 251);
            this.PersonEmailGeneralTask.Name = "PersonEmailGeneralTask";
            this.PersonEmailGeneralTask.Size = new System.Drawing.Size(270, 26);
            this.PersonEmailGeneralTask.TabIndex = 20;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(686, 393);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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