using System;
using System.Windows.Forms;
using SimpleCalculator.Abstracts;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {
        private ChildForm _activeForm;
        public MainForm()
        {
            InitializeComponent();
            OpenChildForm(new Forms.FormCalculator());
        }

        private void OpenChildForm(ChildForm childForm)
        {
            if (_activeForm != null)
                _activeForm.Close();
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMainPanel.Controls.Add(childForm);
            this.panelMainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCalculator());
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLength());
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTemperature());
        }
    }
}
