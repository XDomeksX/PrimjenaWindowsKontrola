using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimjenaWindowsKontrola
{
    public partial class FormaProgram : Form
    {
        public static string textPassedFormaProgram;
        public static string textPassedFormaProgram2;
        public FormaProgram()
        {
            InitializeComponent();
        }

        private void FormaProgram_Load(object sender, EventArgs e)
        {
            TXTname.Text = FormText.textPassedFormText;
            TXTdescription.Text = FormText.textPassedFormText2;
        }
        private void CHBshowProgramAction_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBshowProgramAction.Checked)
            {
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                TXTname.Enabled = true;
                TXTdescription.Enabled = true;
                BTNclear.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                TXTname.Enabled = false;
                TXTdescription.Enabled = false;
                BTNclear.Enabled = false;
            }
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            TXTname.Clear();
            TXTdescription.Clear();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Odaberite neko dugme", "Obavijest", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                Close();
            }
            if (result == DialogResult.No)
            {
                Close();
            }
            if (result == DialogResult.Cancel)
            {
                Close();
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormText formText = new FormText();
            formText.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Jeste li sigurni da želite zatvoriti program?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if( result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
            }
        }
    }
}
