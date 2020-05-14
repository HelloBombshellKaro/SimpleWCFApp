using DBClientProject.RadarDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBClientProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RadarServiceClient client = new RadarServiceClient();
            radarBindingSource.DataSource=  client.GetRadarList("");
        }

        private void EdytujButton_Click(object sender, EventArgs e)
        {
            Radar radar = radarBindingSource.Current as Radar;

            if (radar!=null)
            {
                RadarServiceClient client = new RadarServiceClient();
               var token = client.GetEditToken(radar.id, "Radary", textBox1.Text);

                if (token.EditGranted)
                {
                    EdycjaRadaru edycja = new EdycjaRadaru(radar, token);
                    if (edycja.ShowDialog() == DialogResult.OK)
                    {
                        client.EditRadar(token.TokenValue, radar);
                    }
                }
                else
                {
                    MessageBox.Show($"Użytkownik {token.CurrentEditor} edytuje {radar.Nazwa} id={radar.id} ");
                }
            }
        }
    }
}
