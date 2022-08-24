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
    public partial class fmAnimalNotes : Form
    {
        List<string> notes;
        public fmAnimalNotes(List<string> notes)
        {
            InitializeComponent();
            this.notes = notes;
        }

        private void fmAnimalNotes_Load(object sender, EventArgs e)
        {
            foreach (string note in notes)
            {
                ucAnimalNotes animalNote = new ucAnimalNotes(note);
                flpNotes.Controls.Add(animalNote);
            }
        }
    }
}
