using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //List<URL> urls = new List<URL>();
        List<clsURL> urls = new List<clsURL>();
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            btnIr.Left = this.ClientSize.Width - btnIr.Width;
            comboBox1.Width = btnIr.Left - comboBox1.Left;
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            //string url = comboBox1.Text.ToString();
            string urlIngresado = comboBox1.Text.ToString();
            if (webView != null && webView.CoreWebView2 != null)
            {
                if (!(urlIngresado.Contains(".com")))
                {
                    urlIngresado = "https://www.google.com/search?q=" + urlIngresado;

                }
                else if (!(urlIngresado.Contains("http://")))
                {
                    urlIngresado = "http://" + urlIngresado;

                }
                else if ((urlIngresado.Contains("http://"))&& (urlIngresado.Contains(".com")))
                {
                    urlIngresado = urlIngresado+"";

                }
                webView.CoreWebView2.Navigate(urlIngresado);
                Guardar("archivo.txt", comboBox1.Text);

                MessageBox.Show("Historial guardo en una carpeta txt");
                //codigo de guardo en archivo  txt
                //MessageBox.Show("Historial?", "¿Quieres guardar el historial?",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            clsURL urlExiste = urls.Find(u => u.Pagina == urlIngresado);
            if (urlExiste == null)
            {
                clsURL urlNueva = new clsURL();
                urlNueva.Pagina = urlIngresado;
                urlNueva.Veces = 1;
                urlNueva.Fecha = DateTime.Now;
                urls.Add(urlNueva);
                grabar("Historial.txt");
                webView.CoreWebView2.Navigate(urlIngresado);
            }
            else
            {
                urlExiste.Veces++;
                urlExiste.Fecha = DateTime.Now;
                grabar("Historial.txt");
                webView.CoreWebView2.Navigate(urlExiste.Pagina);
            }
        }
        private void grabar(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var url in urls)
            {
                writer.WriteLine(url.Pagina);
                writer.WriteLine(url.Veces);
                writer.WriteLine(url.Fecha);
            }
            writer.Close();

        }
        private void leer()
        {
            string fileName = "Historial.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() >-1)
            {
                clsURL url = new clsURL();
                url.Pagina = reader.ReadLine();
                url.Veces = Convert.ToInt32(reader.ReadLine());
                url.Fecha = Convert.ToDateTime(reader.ReadLine());
                urls.Add(url);
            }
            reader.Close();
            comboBox1.DisplayMember = "pagina";
            comboBox1.DataSource = urls;
            comboBox1.Refresh();

            
        }

        private void Guardar(string NombreArchivo, string texto)
        {
            FileStream flujo = new FileStream(NombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(flujo);
            writer.WriteLine(texto);
            writer.Close();
        }

        private void inicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            //webBrowser1.GoHome();
        }

        private void haciaAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
             webView.GoBack();
            ///webBrowser1.GoBack();
        }

        private void haciaDelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView.GoForward();
            //webBrowser1.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leer();
            comboBox1.SelectedIndex = -1;
        }

        private void webView21_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
