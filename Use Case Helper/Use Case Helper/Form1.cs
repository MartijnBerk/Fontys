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
    public partial class Form_Main : Form
    {
        private UseCase lastUseCase = null;
        private List<UseCase> useCaseList = new List<UseCase>();

        private Timer refreshTimer = new Timer();

        public Form_Main()
        {
            InitializeComponent();

            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Interval = 33;
            refreshTimer.Start();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            pictureBox_Main.Refresh();
        }

        private void pictureBox_Main_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                List<UseCase> readList = new List<UseCase>(useCaseList);
                foreach(UseCase usecase in readList)
                {
                    if (usecase.Destroy)
                    {
                        useCaseList.Remove(usecase);
                    }
                    else
                    {
                        usecase.Draw(e.Graphics);
                    }
                }

                if(lastUseCase != null)
                {
                    lastUseCase.Draw(e.Graphics);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        private void pictureBox_Main_MouseDown(object sender, MouseEventArgs e)
        {
            UseCase intersectUseCase = null;
            foreach(UseCase useCase in useCaseList)
            {
                if(useCase.HitBox.Contains(e.X, e.Y))
                {
                    intersectUseCase = useCase;
                    break;
                }
            }

            if (intersectUseCase != null)
            {
                UseCaseDetails useCaseDetails = new UseCaseDetails(intersectUseCase);
                useCaseDetails.Show();
            }
            else
            {
                lastUseCase = new UseCase(e.X, e.Y, 0.0f, 0.0f);
            }
        }

        private void pictureBox_Main_MouseMove(object sender, MouseEventArgs e)
        {
            if(lastUseCase != null)
            {
                lastUseCase.SetSize(e.X, e.Y);
            }
        }

        private void pictureBox_Main_MouseUp(object sender, MouseEventArgs e)
        {
            if(lastUseCase != null)
            {
                useCaseList.Add(lastUseCase);

                lastUseCase = null;
            }
        }
    }
}
