namespace project01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox Search;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            StudentID = new TextBox();
            StudentName = new TextBox();
            Search = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnShowAll = new Button();
            lblID = new Label();
            lblName = new Label();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.Location = new Point(32, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(702, 250);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // StudentID
            // 
            StudentID.Location = new Point(113, 57);
            StudentID.Name = "StudentID";
            StudentID.Size = new Size(120, 23);
            StudentID.TabIndex = 3;
            // 
            // StudentName
            // 
            StudentName.Location = new Point(337, 57);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(150, 23);
            StudentName.TabIndex = 4;
            // 
            // Search
            // 
            Search.Location = new Point(565, 57);
            Search.Name = "Search";
            Search.Size = new Size(120, 23);
            Search.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 64, 0);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(84, 362);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 64, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(218, 362);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 64, 0);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(362, 362);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(106, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.FromArgb(128, 64, 0);
            btnShowAll.ForeColor = SystemColors.ButtonHighlight;
            btnShowAll.Location = new Point(523, 362);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(100, 23);
            btnShowAll.TabIndex = 9;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(52, 60);
            lblID.Name = "lblID";
            lblID.Size = new Size(62, 15);
            lblID.TabIndex = 0;
            lblID.Text = "StudentID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(246, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(85, 15);
            lblName.TabIndex = 1;
            lblName.Text = "StudentNAME:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(509, 60);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search:";
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(lblSearch);
            Controls.Add(StudentID);
            Controls.Add(StudentName);
            Controls.Add(Search);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnShowAll);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Student System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}