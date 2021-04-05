using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaBlocs
{
    class ClBloc
    {
        Form fpare;
        Label etq = new Label();
        Color colorblocs = new Color();
        List<Panel> blocs = new List<Panel>();
        int columnes=0;
        int files=0;
        int msegons = 0;
        Double pixels = 0;
        Panel pnl = new Panel();
        

        private delegate void delegat();
        public ClBloc(Form xpare, Color xc, Double xpixels, int xcolumnes, int xfiles)
        {
            fpare = xpare;
            colorblocs = xc;
            columnes = xcolumnes;
            files = xfiles;
            pixels = xpixels;
            
            inipanel();
            try
            {
                fpare.Invoke(new delegat(inserirPanell));
            }
            catch (Exception)
            {

                
            }
            
            inserirBloc();
        }

        private void inipanel()
        {
            Random r = new Random();

            pnl.Width = (int)(columnes * pixels);
            pnl.Height = (int)(files * pixels);
            pnl.Location = new Point(r.Next((int)pixels, (int)(fpare.Width-50-pnl.Width)), r.Next((int)pixels, (int)(fpare.Height-50 - pnl.Height)));
            pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void inserirPanell()
        {
            fpare.Controls.Add(pnl);
        }

        private void inserirBloc()
        {
            int contadorColumnas=0;
            int contadorFilas = 0;
            Random r = new Random();
            msegons= r.Next(20, 500);
            try
            {
                while (contadorColumnas != columnes || contadorFilas != files)
                {
                    Panel bloc = new Panel();
                    bloc.Width = (int)pixels;
                    bloc.Height = (int)pixels;
                    bloc.BackColor = colorblocs;
                    bloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    bloc.Location = new Point((int)(contadorColumnas * pixels), (int)(contadorFilas * pixels));
                    blocs.Add(bloc);
                    fpare.Invoke(new delegat(inserirBlocDelegat));

                    contadorColumnas++;
                    if (contadorColumnas == columnes)
                    {
                        contadorColumnas = 0;
                        contadorFilas++;
                    }
                    System.Threading.Thread.Sleep(msegons);
                }
            }
            catch (Exception)
            {

            }


           
            
        }

        private void inserirBlocDelegat()
        {
            pnl.Controls.Add(blocs[blocs.Count-1]);
        }

    }
}