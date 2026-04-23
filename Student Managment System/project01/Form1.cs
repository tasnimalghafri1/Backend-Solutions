using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace project01
{
    public partial class Form1 : Form
    {
        BindingList<Student> students = new BindingList<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        // Student Class
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = students;
        }

        // ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(StudentID.Text, out int id))
            {
                MessageBox.Show("Enter valid ID");
                return;
            }

            if (string.IsNullOrWhiteSpace(StudentName.Text))
            {
                MessageBox.Show("Enter name");
                return;
            }

            if (students.Any(s => s.ID == id))
            {
                MessageBox.Show("ID already exists");
                return;
            }

            students.Add(new Student
            {
                ID = id,
                Name = StudentName.Text
            });

            StudentID.Clear();
            StudentName.Clear();
        }

        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (MessageBox.Show("Delete student?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                students.Remove((Student)dataGridView1.CurrentRow.DataBoundItem);
            }
        }

        // SEARCH
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = Search.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(key))
            {
                dataGridView1.DataSource = students;
                return;
            }

            var result = students
                .Where(s => s.Name != null &&
                            s.Name.ToLower().Contains(key))
                .ToList();

            if (result.Count == 0)
            {
                MessageBox.Show("No student found");
                dataGridView1.DataSource = students;
                return;
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result;
        }

        // SHOW ALL
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = students;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}