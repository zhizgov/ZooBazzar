using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazzar_Group03
{
    public partial class ucAnimalNotes : UserControl
    {
        private string note;
        public ucAnimalNotes(string note)
        {
            InitializeComponent();
            this.note = note;
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {

        }

        private void ucAnimalNotes_Load(object sender, EventArgs e)
        {
            tbNote.Text = note;
        }
    }
}
