
namespace AufgabenListe2
{
    partial class TaskEditor
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
            this.buttonCreateTask = new System.Windows.Forms.Button();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxAssignee = new System.Windows.Forms.TextBox();
            this.textBoxDegreesDone = new System.Windows.Forms.TextBox();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.labelAssignee = new System.Windows.Forms.Label();
            this.labelDegreesDone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreateTask
            // 
            this.buttonCreateTask.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTask.Location = new System.Drawing.Point(99, 262);
            this.buttonCreateTask.Name = "buttonCreateTask";
            this.buttonCreateTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCreateTask.Size = new System.Drawing.Size(79, 47);
            this.buttonCreateTask.TabIndex = 0;
            this.buttonCreateTask.Tag = "bool";
            this.buttonCreateTask.Text = "Create Task";
            this.buttonCreateTask.UseVisualStyleBackColor = true;
            this.buttonCreateTask.Click += new System.EventHandler(this.buttonCreateTask_Click);
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(29, 59);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(225, 20);
            this.textBoxDesignation.TabIndex = 1;
            // 
            // textBoxAssignee
            // 
            this.textBoxAssignee.Location = new System.Drawing.Point(29, 160);
            this.textBoxAssignee.Name = "textBoxAssignee";
            this.textBoxAssignee.Size = new System.Drawing.Size(172, 20);
            this.textBoxAssignee.TabIndex = 2;
            // 
            // textBoxDegreesDone
            // 
            this.textBoxDegreesDone.Location = new System.Drawing.Point(29, 212);
            this.textBoxDegreesDone.Name = "textBoxDegreesDone";
            this.textBoxDegreesDone.Size = new System.Drawing.Size(50, 20);
            this.textBoxDegreesDone.TabIndex = 3;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(29, 104);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDueDate.TabIndex = 4;
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Location = new System.Drawing.Point(29, 40);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(31, 13);
            this.labelDesignation.TabIndex = 5;
            this.labelDesignation.Text = "Task";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(29, 86);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(53, 13);
            this.labelDueDate.TabIndex = 6;
            this.labelDueDate.Text = "Due Date";
            // 
            // labelAssignee
            // 
            this.labelAssignee.AutoSize = true;
            this.labelAssignee.Location = new System.Drawing.Point(29, 141);
            this.labelAssignee.Name = "labelAssignee";
            this.labelAssignee.Size = new System.Drawing.Size(50, 13);
            this.labelAssignee.TabIndex = 7;
            this.labelAssignee.Text = "Assigned";
            // 
            // labelDegreesDone
            // 
            this.labelDegreesDone.AutoSize = true;
            this.labelDegreesDone.Location = new System.Drawing.Point(29, 193);
            this.labelDegreesDone.Name = "labelDegreesDone";
            this.labelDegreesDone.Size = new System.Drawing.Size(114, 13);
            this.labelDegreesDone.TabIndex = 8;
            this.labelDegreesDone.Text = "% of Task that is Done";
            // 
            // TaskEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 372);
            this.Controls.Add(this.labelDegreesDone);
            this.Controls.Add(this.labelAssignee);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.textBoxDegreesDone);
            this.Controls.Add(this.textBoxAssignee);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.buttonCreateTask);
            this.Name = "TaskEditor";
            this.Text = "TaskEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateTask;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxAssignee;
        private System.Windows.Forms.TextBox textBoxDegreesDone;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label labelAssignee;
        private System.Windows.Forms.Label labelDegreesDone;
    }
}