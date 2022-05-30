namespace RBC_Salario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ageInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hourPerWekInput = new System.Windows.Forms.NumericUpDown();
            this.educationComboBox = new System.Windows.Forms.ComboBox();
            this.educationLabel = new System.Windows.Forms.Label();
            this.maritalLabel = new System.Windows.Forms.Label();
            this.maritalStatuscomboBox = new System.Windows.Forms.ComboBox();
            this.occupationLabel = new System.Windows.Forms.Label();
            this.occupationcomboBox = new System.Windows.Forms.ComboBox();
            this.relationshipLabel = new System.Windows.Forms.Label();
            this.relactionshipComboBox = new System.Windows.Forms.ComboBox();
            this.raceLabel = new System.Windows.Forms.Label();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.workClassLabel = new System.Windows.Forms.Label();
            this.workClasscomboBox = new System.Windows.Forms.ComboBox();
            this.nativeCountryLabel = new System.Windows.Forms.Label();
            this.nativeCountrycomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourPerWekInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(132, 70);
            this.ageInput.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(88, 23);
            this.ageInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Do you earn more than 50k?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hour per Wek";
            // 
            // hourPerWekInput
            // 
            this.hourPerWekInput.Location = new System.Drawing.Point(132, 114);
            this.hourPerWekInput.Name = "hourPerWekInput";
            this.hourPerWekInput.Size = new System.Drawing.Size(88, 23);
            this.hourPerWekInput.TabIndex = 4;
            // 
            // educationComboBox
            // 
            this.educationComboBox.FormattingEnabled = true;
            this.educationComboBox.Location = new System.Drawing.Point(231, 70);
            this.educationComboBox.Name = "educationComboBox";
            this.educationComboBox.Size = new System.Drawing.Size(120, 23);
            this.educationComboBox.TabIndex = 6;
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.Location = new System.Drawing.Point(231, 52);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(60, 15);
            this.educationLabel.TabIndex = 7;
            this.educationLabel.Text = "Education";
            // 
            // maritalLabel
            // 
            this.maritalLabel.AutoSize = true;
            this.maritalLabel.Location = new System.Drawing.Point(231, 96);
            this.maritalLabel.Name = "maritalLabel";
            this.maritalLabel.Size = new System.Drawing.Size(78, 15);
            this.maritalLabel.TabIndex = 9;
            this.maritalLabel.Text = "Marital status";
            // 
            // maritalStatuscomboBox
            // 
            this.maritalStatuscomboBox.FormattingEnabled = true;
            this.maritalStatuscomboBox.Location = new System.Drawing.Point(231, 114);
            this.maritalStatuscomboBox.Name = "maritalStatuscomboBox";
            this.maritalStatuscomboBox.Size = new System.Drawing.Size(120, 23);
            this.maritalStatuscomboBox.TabIndex = 8;
            // 
            // occupationLabel
            // 
            this.occupationLabel.AutoSize = true;
            this.occupationLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.occupationLabel.Location = new System.Drawing.Point(231, 140);
            this.occupationLabel.Name = "occupationLabel";
            this.occupationLabel.Size = new System.Drawing.Size(63, 15);
            this.occupationLabel.TabIndex = 11;
            this.occupationLabel.Text = "Ocupation";
            // 
            // occupationcomboBox
            // 
            this.occupationcomboBox.FormattingEnabled = true;
            this.occupationcomboBox.Location = new System.Drawing.Point(231, 158);
            this.occupationcomboBox.Name = "occupationcomboBox";
            this.occupationcomboBox.Size = new System.Drawing.Size(120, 23);
            this.occupationcomboBox.TabIndex = 10;
            // 
            // relationshipLabel
            // 
            this.relationshipLabel.AutoSize = true;
            this.relationshipLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.relationshipLabel.Location = new System.Drawing.Point(231, 184);
            this.relationshipLabel.Name = "relationshipLabel";
            this.relationshipLabel.Size = new System.Drawing.Size(73, 15);
            this.relationshipLabel.TabIndex = 13;
            this.relationshipLabel.Text = "RelationShip";
            // 
            // relactionshipComboBox
            // 
            this.relactionshipComboBox.FormattingEnabled = true;
            this.relactionshipComboBox.Location = new System.Drawing.Point(231, 202);
            this.relactionshipComboBox.Name = "relactionshipComboBox";
            this.relactionshipComboBox.Size = new System.Drawing.Size(120, 23);
            this.relactionshipComboBox.TabIndex = 12;
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.raceLabel.Location = new System.Drawing.Point(231, 228);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(32, 15);
            this.raceLabel.TabIndex = 15;
            this.raceLabel.Text = "Race";
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(231, 246);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(120, 23);
            this.raceComboBox.TabIndex = 14;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(16, 47);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(51, 19);
            this.maleRadio.TabIndex = 16;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(16, 22);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(63, 19);
            this.femaleRadio.TabIndex = 17;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // workClassLabel
            // 
            this.workClassLabel.AutoSize = true;
            this.workClassLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.workClassLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.workClassLabel.Location = new System.Drawing.Point(231, 272);
            this.workClassLabel.Name = "workClassLabel";
            this.workClassLabel.Size = new System.Drawing.Size(65, 15);
            this.workClassLabel.TabIndex = 20;
            this.workClassLabel.Text = "Work Class";
            // 
            // workClasscomboBox
            // 
            this.workClasscomboBox.FormattingEnabled = true;
            this.workClasscomboBox.Location = new System.Drawing.Point(231, 290);
            this.workClasscomboBox.Name = "workClasscomboBox";
            this.workClasscomboBox.Size = new System.Drawing.Size(120, 23);
            this.workClasscomboBox.TabIndex = 19;
            // 
            // nativeCountryLabel
            // 
            this.nativeCountryLabel.AutoSize = true;
            this.nativeCountryLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.nativeCountryLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.nativeCountryLabel.Location = new System.Drawing.Point(231, 316);
            this.nativeCountryLabel.Name = "nativeCountryLabel";
            this.nativeCountryLabel.Size = new System.Drawing.Size(87, 15);
            this.nativeCountryLabel.TabIndex = 22;
            this.nativeCountryLabel.Text = "Native Country";
            // 
            // nativeCountrycomboBox
            // 
            this.nativeCountrycomboBox.FormattingEnabled = true;
            this.nativeCountrycomboBox.Location = new System.Drawing.Point(231, 334);
            this.nativeCountrycomboBox.Name = "nativeCountrycomboBox";
            this.nativeCountrycomboBox.Size = new System.Drawing.Size(120, 23);
            this.nativeCountrycomboBox.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femaleRadio);
            this.groupBox1.Controls.Add(this.maleRadio);
            this.groupBox1.Location = new System.Drawing.Point(132, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 82);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nativeCountryLabel);
            this.Controls.Add(this.nativeCountrycomboBox);
            this.Controls.Add(this.workClassLabel);
            this.Controls.Add(this.workClasscomboBox);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.relationshipLabel);
            this.Controls.Add(this.relactionshipComboBox);
            this.Controls.Add(this.occupationLabel);
            this.Controls.Add(this.occupationcomboBox);
            this.Controls.Add(this.maritalLabel);
            this.Controls.Add(this.maritalStatuscomboBox);
            this.Controls.Add(this.educationLabel);
            this.Controls.Add(this.educationComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hourPerWekInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourPerWekInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private NumericUpDown ageInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown hourPerWekInput;
        private ComboBox educationComboBox;
        private Label educationLabel;
        private Label maritalLabel;
        private ComboBox maritalStatuscomboBox;
        private Label occupationLabel;
        private ComboBox occupationcomboBox;
        private Label relationshipLabel;
        private ComboBox relactionshipComboBox;
        private Label raceLabel;
        private ComboBox raceComboBox;
        private RadioButton maleRadio;
        private RadioButton femaleRadio;
        private Label workClassLabel;
        private ComboBox workClasscomboBox;
        private Label nativeCountryLabel;
        private ComboBox nativeCountrycomboBox;
        private GroupBox groupBox1;
    }
}