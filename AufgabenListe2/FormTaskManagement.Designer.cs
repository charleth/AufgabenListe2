
namespace AufgabenListe2
{
    partial class FormTaskManagement
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
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonEditTask = new System.Windows.Forms.Button();
            this.buttonRemoveTask = new System.Windows.Forms.Button();
            this.buttonExportTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(12, 18);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(390, 238);
            this.listBoxTasks.TabIndex = 0;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTask.Location = new System.Drawing.Point(13, 282);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTask.TabIndex = 1;
            this.buttonAddTask.Text = "New Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonEditTask
            // 
            this.buttonEditTask.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTask.Location = new System.Drawing.Point(108, 282);
            this.buttonEditTask.Name = "buttonEditTask";
            this.buttonEditTask.Size = new System.Drawing.Size(75, 23);
            this.buttonEditTask.TabIndex = 2;
            this.buttonEditTask.Text = "Edit Task";
            this.buttonEditTask.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveTask
            // 
            this.buttonRemoveTask.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveTask.Location = new System.Drawing.Point(202, 282);
            this.buttonRemoveTask.Name = "buttonRemoveTask";
            this.buttonRemoveTask.Size = new System.Drawing.Size(101, 23);
            this.buttonRemoveTask.TabIndex = 3;
            this.buttonRemoveTask.Text = "Remove Task";
            this.buttonRemoveTask.UseVisualStyleBackColor = true;
            this.buttonRemoveTask.Click += new System.EventHandler(this.buttonRemoveTask_Click);
            // 
            // buttonExportTasks
            // 
            this.buttonExportTasks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportTasks.Location = new System.Drawing.Point(325, 282);
            this.buttonExportTasks.Name = "buttonExportTasks";
            this.buttonExportTasks.Size = new System.Drawing.Size(75, 23);
            this.buttonExportTasks.TabIndex = 4;
            this.buttonExportTasks.Text = "Export Tasks";
            this.buttonExportTasks.UseVisualStyleBackColor = true;
            // 
            // FormTaskManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(412, 322);
            this.Controls.Add(this.buttonExportTasks);
            this.Controls.Add(this.buttonRemoveTask);
            this.Controls.Add(this.buttonEditTask);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.listBoxTasks);
            this.Name = "FormTaskManagement";
            this.Text = "TaskManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonEditTask;
        private System.Windows.Forms.Button buttonRemoveTask;
        private System.Windows.Forms.Button buttonExportTasks;
    }
}

