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
    public partial class FormText : Form
    {
        public static string textPassedFormText;
        public static string textPassedFormText2;
        public FormText()
        {
            InitializeComponent();
        }

        private void FormText_Load(object sender, EventArgs e)
        {
            TXTname.Text = FormaProgram.textPassedFormaProgram;
            TXTdescription.Text = FormaProgram.textPassedFormaProgram2;
        }
        private void BTNok_Click(object sender, EventArgs e)
        {
            textPassedFormText = TXTname.Text;
            textPassedFormText2 = TXTdescription.Text;
            FormaProgram formaProgram = new FormaProgram();
            formaProgram.Show();
            this.Hide();
        }
    }
}
