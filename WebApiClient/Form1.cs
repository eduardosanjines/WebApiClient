using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebApiClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Mostrar(object sender, EventArgs e)
        {
            HttpApiController api = new HttpApiController();
            List<AlumnoModelView> alumnos = new List<AlumnoModelView>();
            alumnos = api.GetCall().Result;
            dGAlumno.DataSource = alumnos;
            dGAlumno.Refresh();

        }
        private void Form1_Load(object sender, EventArgs e){}

        private void GridShowAlumno(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NewFormAdd(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
