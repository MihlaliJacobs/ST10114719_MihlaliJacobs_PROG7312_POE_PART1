using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10114719_MihlaliJacobs_POE_PART1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		//changing pages
		private void lblReportIssues_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();

            MessageBox.Show("Welcome to the report page \n------------------------------------- \nThis is where you can file reports on any municipal issues that you have discovered in your city. On this page you are given fields to enter the location, category, description and any supporting media. Once you have completed filling out the form select the submit button to finalise and send your report so that it can be reviewed and attended to. \n\nPress OK to continue");
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();
            MessageBox.Show("Welcome to the report page \n------------------------------------- \nThis is where you can file reports on any municipal issues that you have discovered in your city. On this page you are given fields to enter the location, category, description and any supporting media. Once you have completed filling out the form select the submit button to finalise and send your report so that it can be reviewed and attended to. \n\nPress OK to continue");
        }

        private void lblEventsAndAnnouncements_Click(object sender, EventArgs e)
		{
		
		}

		private void pbEventsAnnouncements_Click(object sender, EventArgs e)
		{
			
		}

		private void label2_Click(object sender, EventArgs e)
		{
			
		}

		private void pbServiceReqStatus_Click(object sender, EventArgs e)
		{
			
		}

		private void lblReportDesc_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();
            MessageBox.Show("Welcome to the report page \n------------------------------------- \nThis is where you can file reports on any municipal issues that you have discovered in your city. On this page you are given fields to enter the location, category, description and any supporting media. Once you have completed filling out the form select the submit button to finalise and send your report so that it can be reviewed and attended to. \n\nPress OK to continue");
    }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

            MessageBox.Show("Welcome to the report page \n------------------------------------- \nThis is where you can file reports on any municipal issues that you have discovered in your city. On this page you are given fields to enter the location, category, description and any supporting media. Once you have completed filling out the form select the submit button to finalise and send your report so that it can be reviewed and attended to. \n\nPress OK to continue");
    }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblServiceReqStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
