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
        private static string usecaseDeleteWarning = "WARNING!\n" +
                                              "You are about to DELETE this USE CASE!\n" +
                                              "Are you sure?";

        private UseCase lastUseCase = null;
        private List<UseCase> useCaseList = new List<UseCase>();

        private Timer refreshTimer = new Timer();

        private UseCaseDetails activeUseCaseDetails = null;

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
                        listBox_Entities.Items.Remove(usecase.Name);
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
            try
            {
                UseCase intersectUseCase = null;
                foreach (UseCase useCase in useCaseList)
                {
                    if (useCase.HitBox.Contains(e.X, e.Y))
                    {
                        intersectUseCase = useCase;
                        break;
                    }
                }

                if (intersectUseCase != null)
                {
                    OpenUseCaseDetails(intersectUseCase);
                }
                else
                {
                    lastUseCase = new UseCase(e.X, e.Y, 0.0f, 0.0f);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK);
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
                listBox_Entities.Items.Add(lastUseCase.Name);

                lastUseCase = null;
            }
        }

        private void Form_Main_LocationChanged(object sender, EventArgs e)
        {
            if (activeUseCaseDetails != null)
            {
                activeUseCaseDetails.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            }
        }

        private void listBox_Entities_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete && listBox_Entities.SelectedIndex >= 0)
                {
                    string name = (string)listBox_Entities.Items[listBox_Entities.SelectedIndex];

                    if (MessageBox.Show(usecaseDeleteWarning, "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        UseCase usecase = useCaseList.Find(x => x.Name == name);
                        if (usecase != null)
                        {
                            usecase.DestroyUseCase();
                        }
                    }
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    string name = (string)listBox_Entities.Items[listBox_Entities.SelectedIndex];
                    UseCase usecase = useCaseList.Find(x => x.Name == name);

                    OpenUseCaseDetails(usecase);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        private void OpenUseCaseDetails(UseCase usecase)
        {
            try
            {
                if (activeUseCaseDetails != null)
                {
                    activeUseCaseDetails.Close();
                }

                activeUseCaseDetails = new UseCaseDetails(usecase);
                activeUseCaseDetails.Location = new Point(this.Location.X + this.Width, this.Location.Y);

                string oldName = usecase.Name;

                if (activeUseCaseDetails.ShowDialog() == DialogResult.OK)
                {
                    int index = listBox_Entities.Items.IndexOf(oldName);
                    listBox_Entities.Items[index] = usecase.Name;
                }
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }
    }
}
