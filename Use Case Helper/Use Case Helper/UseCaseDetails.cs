using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_Helper
{
    public partial class UseCaseDetails : Form
    {
        private static string usecaseDeleteWarning = "WARNING!\n" +
                                              "You are about to DELETE this USE CASE!\n" +
                                              "Are you sure?";

        private UseCase usecase;
        private string originalName = null;

        private bool apply = false;

        public UseCaseDetails(UseCase objUsecase)
        {
            InitializeComponent();

            usecase = objUsecase;
            originalName = usecase.Name;
            textBox_Name.Text = usecase.Name;
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            usecase.Name = textBox_Name.Text;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            usecase.Name = originalName;

            this.Close();
        }

        private void UseCaseDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing && !apply)
            {
                button_Cancel_Click(null, null);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(usecaseDeleteWarning, "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    usecase.DestroyUseCase();

                    this.Close();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            apply = true;

            this.Close();
        }
    }
}
