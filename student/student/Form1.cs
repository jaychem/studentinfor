using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{
    public partial class studentform : Form
    {
        private bool isAdd;

        public studentform()
        {
            InitializeComponent();
            
        }
        private void buttonR_Click(object sender, EventArgs e)
        {
            load_dataGridView_student();
        }

        private void load_dataGridView_student()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                BindingSource bindingsource = new BindingSource();

                List<DBstudent> rec = DBstudent.GetData();
                foreach (DBstudent data in rec)

                    bindingsource.Add(data);

                this.dataGridView_student.Refresh();
                this.dataGridView_student.AutoGenerateColumns = false;
                this.dataGridView_student.DataSource = bindingsource;
                this.dataGridView_student.ClearSelection();

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        private void enAbleButton()
        {
            buttonA.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;

            buttonS.Enabled = false;
            buttonC.Enabled = false;
        }

        private void disAbleButton()
        {
            buttonA.Enabled = false;
            buttonD.Enabled = false;
            buttonE.Enabled = false;

            buttonS.Enabled = true;
            buttonC.Enabled = true;
        }

        private void studentform_Load(object sender, EventArgs e)
        {
            enAbleButton();
        }

        private void dataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index > -1)
                {

                    DataGridViewRow selectedRow = dataGridView_student.Rows[index];
                    this.textBoxF.Text = selectedRow.Cells[1].Value.ToString();
                    this.textBoxL.Text = selectedRow.Cells[2].Value.ToString();
                    this.textBoxM.Text = selectedRow.Cells[3].Value.ToString();
                }

            }
            catch (ArgumentException ex)
            {
                ex.ToString();
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            textBoxF.Text = "";
            textBoxL.Text = "";
            textBoxM.Text = "";
            isAdd = true;
            disAbleButton();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            enAbleButton();
            if (isAdd)
            {
                DBstudent add = new DBstudent(textBoxF.Text, textBoxL.Text,textBoxM.Text);
                add.Add();

                load_dataGridView_student();

                MessageBox.Show("Added successfuly");

            }
        }



    }
}
