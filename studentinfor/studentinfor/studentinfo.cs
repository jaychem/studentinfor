using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace studentinfor
{
    public partial class studentinfo : Form
    {
        private bool isAdd;

        public studentinfo()
        {
            InitializeComponent();
            enAbleButton();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {

            load_dataGridView1();
        }
        
        public void load_dataGridView1()
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //BindingSource bindingsource = new BindingSource();
                dataGridView1.Rows.Clear();
                List<DBstuinfo> rec = DBstuinfo.GetData();
                foreach (DBstuinfo data in rec) {
                    string[] row = new string[] { data.Id.ToString(), data.FirstName, data.LastName, data.MiddleName, data.Course, data.Year.ToString(), data.Address };
                    dataGridView1.Rows.Add(row);
                    dataGridView1.Refresh();
                }

                 //   bindingsource.Add(data);

                //this.dataGridView1.Refresh();
                //this.dataGridView1.AutoGenerateColumns = false;
                //this.dataGridView1.DataSource = bindingsource;
                //this.dataGridView1.ClearSelection();

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

       

        private void enAbleButton() {
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
        
        private void Form1_Load(object sender, EventArgs e)
        {
            enAbleButton();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index > -1)
                {

                    DataGridViewRow selectedRow = dataGridView1.Rows[index];
                    this.textBoxF.Text = selectedRow.Cells[1].Value.ToString();
                    this.textBoxL.Text = selectedRow.Cells[2].Value.ToString();
                    this.textBoxM.Text = selectedRow.Cells[3].Value.ToString();
                    this.comboBoxC.Text = selectedRow.Cells[4].Value.ToString();
                    this.comboBoxY.Text = selectedRow.Cells[5].Value.ToString();
                    this.textBoxA.Text = selectedRow.Cells[6].Value.ToString();
                }

            }
            catch (ArgumentException ex)
            {
                ex.ToString();
            }

        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            isAdd = false;
            disAbleButton();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            textBoxF.Text = "";
            textBoxL.Text = "";
            textBoxM.Text = "";
            comboBoxC.Text = "";
            comboBoxY.Text = "";
            textBoxA.Text = "";
            isAdd = true;
            disAbleButton();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            enAbleButton();
            if (isAdd == true)
            {
                    DBstuinfo add = new DBstuinfo(textBoxF.Text, textBoxL.Text, textBoxM.Text, comboBoxC.Text, Convert.ToInt32(comboBoxY.Text), textBoxA.Text);
                    add.Add();

                    load_dataGridView1();

                    MessageBox.Show("Added successfuly");

            }
            else if(isAdd == false)
            {
                try
                {
                    int idx = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    DBstuinfo cards = DBstuinfo.GetDataID(idx);

                    cards.FirstName = textBoxF.Text;
                    cards.LastName = textBoxL.Text;
                    cards.MiddleName = textBoxM.Text;
                    cards.Course = comboBoxC.Text;
                    cards.Year = Convert.ToInt32(comboBoxY.Text);
                    cards.Address = textBoxA.Text;

                    cards.Update();
                    load_dataGridView1();
                    MessageBox.Show("Edited successfuly");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record " + ex.Message);
                }
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                DBstuinfo cards = DBstuinfo.GetDataID(idx);

                if (cards != null)
                {

                    DialogResult dialogResult = MessageBox.Show(" Do you want to delete this record?", "Delete", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        cards.Delete();
                        load_dataGridView1();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record " + ex.Message);
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            enAbleButton();
        }

        private void comboBoxC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
