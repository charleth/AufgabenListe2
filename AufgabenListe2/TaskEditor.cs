using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabenListe2
{
    public partial class TaskEditor : Form
    {
        public List<Task> NewTasks { get; set; }
        public Task Task { get; set; }

        public TaskEditor(List<Task> TasksOld)
        {
            InitializeComponent();
            NewTasks = TasksOld;
            buttonCreateTask.Tag = true;
        }

        public TaskEditor(Task task)
        {
            InitializeComponent();
            Task = task;
            buttonCreateTask.Tag = false;
            buttonCreateTask.Text = "Save Changes";
            FillIn();
        }

        public void FillIn()
        {
            textBoxDesignation.Text = Task.Designation;
            dateTimePickerDueDate.Text = Task.DueDate.Date.ToString();
            textBoxAssignee.Text = Task.Assignee;
            textBoxDegreesDone.Text = Task.DegreesDone.ToString();
        }

        private bool ValidateForm()
        {
            DateTime temp;
            int tempInt;
            if (textBoxDesignation.Text.Length == 0 || !DateTime.TryParse(dateTimePickerDueDate.Text, out temp)
                || textBoxAssignee.Text.Length == 0 || !int.TryParse(textBoxDegreesDone.Text, out tempInt) || !(tempInt>=0&&tempInt<=100))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if ((bool)buttonCreateTask.Tag)
                {
                    NewTasks.Add(new Task(textBoxDesignation.Text,
                                            DateTime.Parse(dateTimePickerDueDate.Text),
                                            textBoxAssignee.Text,
                                            int.Parse(textBoxDegreesDone.Text)));
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if(!(bool)buttonCreateTask.Tag)
                {
                    Task.Designation = textBoxDesignation.Text;
                    Task.DueDate = DateTime.Parse(dateTimePickerDueDate.Text);
                    Task.Assignee = textBoxAssignee.Text;
                    Task.DegreesDone = int.Parse(textBoxDegreesDone.Text);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Computer says no");
            }
        }
    }
}
