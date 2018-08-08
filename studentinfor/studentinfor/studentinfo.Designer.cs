namespace studentinfor
{
    partial class studentinfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.fname = new System.Windows.Forms.Label();
            this.mmname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.Label();
            this.yname = new System.Windows.Forms.Label();
            this.aname = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.comboBoxC = new System.Windows.Forms.ComboBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.buttonS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstname,
            this.lastname,
            this.mname,
            this.course,
            this.year,
            this.address});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Location = new System.Drawing.Point(-5, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(811, 166);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // firstname
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.firstname.DefaultCellStyle = dataGridViewCellStyle4;
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            this.firstname.Width = 150;
            // 
            // lastname
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.lastname.DefaultCellStyle = dataGridViewCellStyle5;
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            this.lastname.Width = 150;
            // 
            // mname
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.mname.DefaultCellStyle = dataGridViewCellStyle6;
            this.mname.HeaderText = "Middle Name";
            this.mname.Name = "mname";
            // 
            // course
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.course.DefaultCellStyle = dataGridViewCellStyle7;
            this.course.HeaderText = "Course";
            this.course.Name = "course";
            // 
            // year
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.year.DefaultCellStyle = dataGridViewCellStyle8;
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.Width = 50;
            // 
            // address
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.address.DefaultCellStyle = dataGridViewCellStyle9;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.Width = 200;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(696, 171);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(93, 43);
            this.buttonR.TabIndex = 1;
            this.buttonR.Text = "REFRESH";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(141, 306);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(80, 43);
            this.buttonA.TabIndex = 2;
            this.buttonA.Text = "ADD";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(257, 306);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(79, 43);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "DELETE";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(375, 306);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(75, 43);
            this.buttonE.TabIndex = 4;
            this.buttonE.Text = "EDIT";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(590, 306);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 43);
            this.buttonC.TabIndex = 5;
            this.buttonC.Text = "CANCEL";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(46, 186);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(57, 13);
            this.fname.TabIndex = 7;
            this.fname.Text = "First Name";
            // 
            // mmname
            // 
            this.mmname.AutoSize = true;
            this.mmname.Location = new System.Drawing.Point(46, 248);
            this.mmname.Name = "mmname";
            this.mmname.Size = new System.Drawing.Size(69, 13);
            this.mmname.TabIndex = 8;
            this.mmname.Text = "Middle Name";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(46, 218);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(58, 13);
            this.lname.TabIndex = 9;
            this.lname.Text = "Last Name";
            // 
            // cname
            // 
            this.cname.AutoSize = true;
            this.cname.Location = new System.Drawing.Point(362, 186);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(40, 13);
            this.cname.TabIndex = 10;
            this.cname.Text = "Course";
            // 
            // yname
            // 
            this.yname.AutoSize = true;
            this.yname.Location = new System.Drawing.Point(362, 218);
            this.yname.Name = "yname";
            this.yname.Size = new System.Drawing.Size(29, 13);
            this.yname.TabIndex = 11;
            this.yname.Text = "Year";
            // 
            // aname
            // 
            this.aname.AutoSize = true;
            this.aname.Location = new System.Drawing.Point(362, 248);
            this.aname.Name = "aname";
            this.aname.Size = new System.Drawing.Size(45, 13);
            this.aname.TabIndex = 12;
            this.aname.Text = "Address";
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(126, 183);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(190, 20);
            this.textBoxF.TabIndex = 13;
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(126, 215);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(190, 20);
            this.textBoxL.TabIndex = 14;
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(126, 245);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(190, 20);
            this.textBoxM.TabIndex = 15;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(427, 245);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(190, 20);
            this.textBoxA.TabIndex = 16;
            // 
            // comboBoxC
            // 
            this.comboBoxC.FormattingEnabled = true;
            this.comboBoxC.Items.AddRange(new object[] {
            "BSCOE",
            "BSME",
            "BSEE",
            "BSNAME",
            "BSECE",
            "BSIE"});
            this.comboBoxC.Location = new System.Drawing.Point(427, 183);
            this.comboBoxC.Name = "comboBoxC";
            this.comboBoxC.Size = new System.Drawing.Size(121, 21);
            this.comboBoxC.TabIndex = 17;
            this.comboBoxC.SelectedIndexChanged += new System.EventHandler(this.comboBoxC_SelectedIndexChanged);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // comboBoxY
            // 
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxY.Location = new System.Drawing.Point(427, 215);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(43, 21);
            this.comboBoxY.TabIndex = 18;
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(485, 306);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(75, 43);
            this.buttonS.TabIndex = 19;
            this.buttonS.Text = "SAVE";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // studentinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(801, 361);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.comboBoxC);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.aname);
            this.Controls.Add(this.yname);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.mmname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.dataGridView1);
            this.Name = "studentinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Record";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label mmname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label cname;
        private System.Windows.Forms.Label yname;
        private System.Windows.Forms.Label aname;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.ComboBox comboBoxC;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.ComboBox comboBoxY;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}

