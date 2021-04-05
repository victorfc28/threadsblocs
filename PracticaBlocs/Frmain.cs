using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaBlocs
{
    public partial class Frmain : Form
    {
        List<BackgroundWorker> llBackW = new List<BackgroundWorker>();
        List<ClBloc> llBloc = new List<ClBloc>();
        List<Color> Colores = new List<Color>();
        public Frmain()
        {
            InitializeComponent();
        }

        private void Frmain_Load(object sender, EventArgs e)
        {
            Colores.Add(Color.Red);
            Colores.Add(Color.Blue);
            Colores.Add(Color.Yellow);
            Colores.Add(Color.Green);
            Colores.Add(Color.Magenta);
            Colores.Add(Color.Brown);
        }

        private void btNouBloc_Click(object sender, EventArgs e)
        {
            int i;

                llBackW.Add(new BackgroundWorker());
                llBackW[llBackW.Count - 1].DoWork += crearBloc;
                llBackW[llBackW.Count - 1].WorkerSupportsCancellation = true;                     
                llBackW[llBackW.Count - 1].RunWorkerAsync();                       
            
        }

        private void crearBloc(object sender, DoWorkEventArgs e)
        {
            Random r = new Random();
            llBloc.Add(new ClBloc(this,Colores[r.Next(1,Colores.Count)],r.Next(15,40),r.Next(3,10),r.Next(3,10)));
        }

        private void Frmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            int i=0;
            foreach(BackgroundWorker b in llBackW)
            {
                if(b.IsBusy)b.CancelAsync();
            }
        }
    }
}
