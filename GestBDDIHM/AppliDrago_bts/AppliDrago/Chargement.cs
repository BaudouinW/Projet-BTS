using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace AppliDrago
{
    public partial class Chargement : Form
    {
        public Chargement()
        {
            InitializeComponent();
            Shown += new EventHandler(Chargement_Shown);

            // rapport de progression
            backgroundWorker1.WorkerReportsProgress = true;
            // Event lancer dans le thread
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            // Event lors de la progression de la barre
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);

            //Event quand terminé
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

            labelPourcentage.Text = "";
            
        }

        void Chargement_Shown(object sender, EventArgs e)
        {
            // démarrer le BackgroundWorker
            backgroundWorker1.RunWorkerAsync();
        }
        


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(1);
                // rapporter la progression dans le thread
                backgroundWorker1.ReportProgress(i);
            }
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            // Progression en pourcentage
            barChargement.Value = e.ProgressPercentage;
            labelPourcentage.Text = String.Format("Progress: {0} %", e.ProgressPercentage);
    
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("mis à jour");
            this.Close();
            
        }

        private void Chargement_Load(object sender, EventArgs e)
        {

        }
       
    }
}
