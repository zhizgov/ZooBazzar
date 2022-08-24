using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using LogicLayer;
using DataAccessLayer;

namespace ZooBazzar_Group03
{
    public partial class fmAddNote : Form
    {
        private int id;
        private AnimalManager animalManager = new AnimalManager(new AnimalDB(), new AnimalDB());
        public fmAddNote(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            animalManager.AddNote(id, tbNote.Text);
            this.Dispose();
        }
    }
}
