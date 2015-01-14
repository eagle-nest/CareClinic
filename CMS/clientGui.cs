using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class clientGui : Form
    {
        public clientGui()
        {
            InitializeComponent();
            this.clinicPanel.BringToFront();
        }
        //clock timer event
        private void timer1_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString() + "    ";
        }

        private void clientGui_Load(object sender, EventArgs e)
        {
           
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clinicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.clinicPanel.BringToFront();
        }

        private void newPatientLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void patientRecordLabel_Click(object sender, EventArgs e)
        {

        }

        private void newPatientFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patientLabel_Click(object sender, EventArgs e)
        {
            this.patientPanel.BringToFront();
        }

        private void patientPictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image files (*.jpg)|*.jpg|(*.png)|*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    patientPictureBox.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void patientRecordLabel_Click_1(object sender, EventArgs e)
        {
            patientRecordPanel.BringToFront();
        }

        private void newPatientLabel_Click_1(object sender, EventArgs e)
        {
            newPatientFormPanel.BringToFront();
        }

        private void patientFormCencelButton_Click(object sender, EventArgs e)
        {
            patientRecordPanel.BringToFront();
        }

        private void patientFormSaveButton_Click(object sender, EventArgs e)
        {
            patientRecordPanel.BringToFront();
        }

        private void appointmentLabel_Click(object sender, EventArgs e)
        {
            appointmentPanel.BringToFront();
        }

        private void doctorLabel_Click(object sender, EventArgs e)
        {
            doctorPanel.BringToFront();
        }

        private void reportLabel_Click(object sender, EventArgs e)
        {
            reportsPanel.BringToFront();
        }

        private void settingLabel_Click(object sender, EventArgs e)
        {
            settingPanel.BringToFront();
        }

        private void staffLabel_Click(object sender, EventArgs e)
        {
            staffPanel.BringToFront();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingPanel.BringToFront();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appointmentPanel.BringToFront();
        }

        private void staffPictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image files (*.jpg)|*.jpg|(*.png)|*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    staffPictureBox.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void doctorPictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image files (*.jpg)|*.jpg|(*.png)|*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    doctorPictureBox.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void newDoctorLabel_Click(object sender, EventArgs e)
        {
            newDoctorPanel.BringToFront();
        }

        private void doctorRecordLabel_Click(object sender, EventArgs e)
        {
            doctorRecordPanel.BringToFront();
        }

        private void newAppointmentLabel_Click(object sender, EventArgs e)
        {
            newAppointmentPanel.BringToFront();
        }

        private void appointmentRecordLabel_Click(object sender, EventArgs e)
        {
            appointmentRecordPanel.BringToFront();
        }

        private void addStaffLabel_Click(object sender, EventArgs e)
        {
            addStaffPanel.BringToFront();
        }

        private void staffRecordLabel_Click(object sender, EventArgs e)
        {
            staffRecordPanel.BringToFront();
        }
                
    }
}
