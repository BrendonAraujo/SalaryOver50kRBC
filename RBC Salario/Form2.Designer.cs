namespace RBC_Salario
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableOrderCase = new System.Windows.Forms.DataGridView();
            this.rownumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.similarity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.race = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourperweek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrderCase)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // tableOrderCase
            // 
            this.tableOrderCase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOrderCase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rownumber,
            this.similarity,
            this.handle,
            this.age,
            this.maritalStatus,
            this.occupation,
            this.relationship,
            this.race,
            this.sex,
            this.hourperweek,
            this.workClass});
            this.tableOrderCase.Location = new System.Drawing.Point(12, 12);
            this.tableOrderCase.Name = "tableOrderCase";
            this.tableOrderCase.RowTemplate.Height = 25;
            this.tableOrderCase.Size = new System.Drawing.Size(1144, 766);
            this.tableOrderCase.TabIndex = 0;
            this.tableOrderCase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // rownumber
            // 
            this.rownumber.HeaderText = "Row";
            this.rownumber.Name = "rownumber";
            // 
            // similarity
            // 
            this.similarity.HeaderText = "Similarity";
            this.similarity.Name = "similarity";
            // 
            // handle
            // 
            this.handle.HeaderText = "Id";
            this.handle.Name = "handle";
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            // 
            // maritalStatus
            // 
            this.maritalStatus.HeaderText = "Marital Status";
            this.maritalStatus.Name = "maritalStatus";
            // 
            // occupation
            // 
            this.occupation.HeaderText = "Occupation";
            this.occupation.Name = "occupation";
            // 
            // relationship
            // 
            this.relationship.HeaderText = "Relationship";
            this.relationship.Name = "relationship";
            // 
            // race
            // 
            this.race.HeaderText = "Race";
            this.race.Name = "race";
            // 
            // sex
            // 
            this.sex.HeaderText = "Sex";
            this.sex.Name = "sex";
            // 
            // hourperweek
            // 
            this.hourperweek.HeaderText = "Hour Per Week";
            this.hourperweek.Name = "hourperweek";
            // 
            // workClass
            // 
            this.workClass.HeaderText = "Work Class";
            this.workClass.Name = "workClass";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1171, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add case em database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1470, 790);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableOrderCase);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrderCase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView tableOrderCase;
        private DataGridViewTextBoxColumn rownumber;
        private DataGridViewTextBoxColumn similarity;
        private DataGridViewTextBoxColumn handle;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn maritalStatus;
        private DataGridViewTextBoxColumn occupation;
        private DataGridViewTextBoxColumn relationship;
        private DataGridViewTextBoxColumn race;
        private DataGridViewTextBoxColumn sex;
        private DataGridViewTextBoxColumn hourperweek;
        private DataGridViewTextBoxColumn workClass;
        private Button button1;
    }
}