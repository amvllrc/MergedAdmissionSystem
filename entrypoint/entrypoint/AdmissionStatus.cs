using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entrypoint
{
    public partial class AdmissionStatus: Form
    {
        public AdmissionStatus()
        {
            InitializeComponent();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdmissionStatus.FlatStyle = FlatStyle.Flat;
            btnAdmissionStatus.FlatAppearance.BorderSize = 0;
            btnApplication.FlatStyle = FlatStyle.Flat;
            btnApplication.FlatAppearance.BorderSize = 0;
            btnPaymentExam.FlatStyle = FlatStyle.Flat;
            btnPaymentExam.FlatAppearance.BorderSize = 0;
            btnExamination.FlatStyle = FlatStyle.Flat;
            btnExamination.FlatAppearance.BorderSize = 0;

        }


        private void btnAdmissionStatus_Click(object sender, EventArgs e)
        {
            AdmissionStatus AdmissionForm = new AdmissionStatus();
            AdmissionForm.Show();
            this.Hide();
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            StudentApplicationForm StudentApplicationForm = new StudentApplicationForm();
            StudentApplicationForm.Show();
            this.Hide();
        }

        private void btnPaymentExam_Click(object sender, EventArgs e)
        {
            PaymentForm PaymentForm = new PaymentForm();
            PaymentForm.Show();
            this.Hide();
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            Examination Examination = new Examination();
            Examination.Show();
            this.Hide();
        }
    }
}
