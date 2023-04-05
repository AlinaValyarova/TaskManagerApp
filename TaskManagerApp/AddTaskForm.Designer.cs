
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
            this.TaskName = new System.Windows.Forms.RichTextBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddTaskBTN = new System.Windows.Forms.Button();
            this.Teams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskName
            // 
            this.TaskName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TaskName.Location = new System.Drawing.Point(12, 12);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(591, 50);
            this.TaskName.TabIndex = 1;
            this.TaskName.Text = "Название задачи";
            // 
            // Description
            // 
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Description.Location = new System.Drawing.Point(12, 68);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(372, 23);
            this.Description.TabIndex = 2;
            this.Description.Text = "Введите описание";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(336, 163);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(189, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Повторяющаяся задача";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddTaskBTN
            // 
            this.AddTaskBTN.Location = new System.Drawing.Point(361, 220);
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
            this.Teams.Location = new System.Drawing.Point(0, 239);
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
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(537, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.AddTaskBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.TaskName);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TaskName;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddTaskBTN;
        private System.Windows.Forms.ComboBox Teams;
        private System.Windows.Forms.Label label1;
    }
}