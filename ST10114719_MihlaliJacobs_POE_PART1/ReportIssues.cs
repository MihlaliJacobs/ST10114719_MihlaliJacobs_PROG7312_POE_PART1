using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ST10114719_MihlaliJacobs_POE_PART1
{
	public partial class Form2 : Form
	{
        // Track how many fields are filled
        int fieldsFilled = 0;
        int totalFields = 3; 

        public Form2()
		{
			InitializeComponent();

            // Initialize ProgressBar 
            progressBar1.Minimum = 0;
            progressBar1.Maximum = totalFields;
            progressBar1.Value = 0;

            txtLocation.TextChanged += new EventHandler(InputField_TextChanged);
            listCategory.SelectedIndexChanged += new EventHandler(InputField_TextChanged); 
            txtDescription.TextChanged += new EventHandler(InputField_TextChanged);
            
        }

        private void InputField_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void UpdateProgressBar()
        {
            fieldsFilled = 0;

            if (!string.IsNullOrEmpty(txtLocation.Text)) fieldsFilled++;
            if (listCategory.SelectedIndex >= 0) fieldsFilled++;
            if (!string.IsNullOrEmpty(txtDescription.Text)) fieldsFilled++;

            // Update the progress bar value
            progressBar1.Value = fieldsFilled;
        }

        private void button1_Click(object sender, EventArgs e)
		{

            //Coding to let user upload images
            String fileLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files|*.*|Document Files|*.DOCX;*.DOC;*.PDF;*.TXT|All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|BMP Files: (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE|JPEG Files: (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF|GIF Files: (*.GIF)|*.GIF|TIFF Files: (*.TIF;*.TIFF)|*.TIF;*.TIFF|PNG Files: (*.PNG)|*.PNG|All Files|*.*|Document Files|*.DOCX;*.DOC;*.PDF;*.TXT";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileLocation = dialog.FileName;



                    linkLabel1.Text = fileLocation;
                    linkLabel1.Links.Clear();
                    linkLabel1.Links.Add(0, fileLocation.Length, fileLocation);
                    linkLabel1.Visible = true;  
                }

                else
                {
                    MessageBox.Show("Selected Document: " + fileLocation);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Media and document upload link
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = e.Link.LinkData.ToString(),
                UseShellExecute = true
            });
        }

        //Page change to main menu
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();  
        }

        //Submit button - storing and compiling report summary
        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            List<string> issues = new List<string>();
            issues.Add(txtLocation.Text);
            issues.Add(listCategory.Text);
            issues.Add(txtDescription.Text);

                MessageBox.Show("Report Summary:" +
                                "\n------------------------------" +
                               "\n\nLocation: " + issues[0] +
                               "\n\nCategory: " + issues[1] +
                               "\n\nDescription: " + issues[2]);

            //Reset all of the input fields and progress bar
            txtLocation.Text = "";
            txtDescription.Text = "";

            linkLabel1.Text = "(Media/Document)";

            listCategory.SelectedIndex = -1;

            progressBar1.Value = 0;
        }
    }
}
