using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabenListe2
{
    public partial class FormTaskManagement : Form
    {
        public List<Task> tasks = new List<Task>();
        public FormTaskManagement()
        {
            InitializeComponent();
            ImportTasks();
            //AddTask(new Task("Essen bestellen", DateTime.Now, "wir", 0));
            //AddTask(new Task("Essen aufessen", DateTime.Now, "wir", 0));
            //AddTask(new Task("C# Tutorial schreiben", DateTime.Now, "wir", 0));
        }
        // refresh display of list
        public void RefreshList()
        {
            listBoxTasks.DataSource = null;
            listBoxTasks.DataSource = tasks;
        }

        public void AddTask(Task t)
        {
            tasks.Add(t);
            //listBoxTasks.Items.Add(t.ToString());
            RefreshList();
        }

        // import tasks from external .csv file
        private static string EXTERNALTASKFILE = "ExternalTasks.csv";

        public void ImportTasks()
        {
            try
            {
                StreamReader reader = new StreamReader(new FileStream (EXTERNALTASKFILE, FileMode.Open, FileAccess.Read), new UTF8Encoding());
                do
                {
                    string row = reader.ReadLine();
                    if (row.Length == 0)
                    {
                        continue;
                    }
                    string[] separate = row.Split(';');
                    string designation = separate[0];
                    DateTime duedate = DateTime.Parse(separate[1], CultureInfo.GetCultureInfo("de-DE"));
                    string assignee = separate[2];
                    int degreesdone = int.Parse(separate[3]);
                    Task t = new Task(designation, duedate, assignee, degreesdone);
                    AddTask(t);
                }
                while (!reader.EndOfStream);
                reader.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Couldn't read the file: " + ex.Message);
            }
        }



        public void SaveData()
        {
            try
            {
                if (tasks.Count == 0)
                { 
                    return;
                }
                List<string> lines = new List<string>();
                foreach (Task t in tasks)
                {
                    lines.Add($"{t.Designation};{t.DueDate};{t.Assignee};{t.DegreesDone}");
                }
                File.WriteAllLines(EXTERNALTASKFILE, lines);
            }
            catch(IOException ex)
            {
                MessageBox.Show("File couldn't be written: " + ex);
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            // open new Form-Object
            TaskEditor f = new TaskEditor(tasks);
            if (f.ShowDialog()==DialogResult.OK)
            {
                SaveData();
                RefreshList();
            }
        }

        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                tasks.RemoveAt(listBoxTasks.SelectedIndex);
                SaveData();
                RefreshList();
            }
            else
            {
                MessageBox.Show("Select an item to remove.");
            }
        }
    }
}
