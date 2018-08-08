namespace student
{
    partial class studentform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.mname = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_student
            // 
            this.dataGridView_student.AllowUserToAddRows = false;
            this.dataGridView_student.AllowUserToDeleteRows = false;
            this.dataGridView_student.AllowUserToResizeColumns = false;
            this.dataGridView_student.AllowUserToResizeRows = false;
            this.dataGridView_student.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_student.ColumnHeadersHeight = 25;
            this.dataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstname,
            this.lastname,
            this.middlename});
            this.dataGridView_student.EnableHeadersVisualStyles = false;
            this.dataGridView_student.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_student.Location = new System.Drawing.Point(3, 37);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.ReadOnly = true;
            this.dataGridView_student.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_student.RowHeadersVisible = false;
            this.dataGridView_student.Size = new System.Drawing.Size(456, 180);
            this.dataGridView_student.TabIndex = 0;
            this.dataGridView_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_student_CellContentClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Width = 50;
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            this.firstname.Width = 150;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            this.lastname.Width = 150;
            // 
            // middlename
            // 
            this.middlename.HeaderText = "Middle Name";
            this.middlename.Name = "middlename";
            this.middlename.ReadOnly = true;
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(12, 320);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(75, 33);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "ADD";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(100, 321);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(75, 32);
            this.buttonD.TabIndex = 2;
            this.buttonD.Text = "DELETE";
            this.buttonD.UseVisualStyleBackColor = true;
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(189, 321);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(75, 32);
            this.buttonE.TabIndex = 3;
            this.buttonE.Text = "EDIT";
            this.buttonE.UseVisualStyleBackColor = true;
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(281, 321);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(75, 32);
            this.buttonS.TabIndex = 4;
            this.buttonS.Text = "SAVE";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(374, 321);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 32);
            this.buttonC.TabIndex = 5;
            this.buttonC.Text = "CANCEL";
            this.buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(374, 223);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(75, 37);
            this.buttonR.TabIndex = 6;
            this.buttonR.Text = "REFRESH";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(69, 234);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(85, 15);
            this.fname.TabIndex = 7;
            this.fname.Text = "First Name :";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(68, 257);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(84, 15);
            this.lname.TabIndex = 8;
            this.lname.Text = "Last Name :";
            // 
            // mname
            // 
            this.mname.AutoSize = true;
            this.mname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mname.Location = new System.Drawing.Point(69, 279);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(101, 15);
            this.mname.TabIndex = 9;
            this.mname.Text = "Middle Name :";
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(171, 233);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(172, 20);
            this.textBoxF.TabIndex = 10;
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(171, 256);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(172, 20);
            this.textBoxL.TabIndex = 11;
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(171, 278);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(172, 20);
            this.textBoxM.TabIndex = 12;
            // 
            // studentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(461, 356);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.dataGridView_student);
            this.Name = "studentform";
            this.Text = "STUDENT FORM";
            this.Load += new System.EventHandler(this.studentform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlename;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label mname;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxM;
    }
}

