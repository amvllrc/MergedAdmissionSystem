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
    public partial class PaymentForm: Form
    {
        public PaymentForm()
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

        private void btnProofOfPayment_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set filters for image file types
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image into the PictureBox
                    try
                    {
                        Image selectedImage = Image.FromFile(openFileDialog.FileName);
                        picPreviewImg.Image = selectedImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }

    }
}
