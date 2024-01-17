using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficacionProyecto_U4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int incGraf = 0, rotGraf = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'estadisticasDataSet1.VistasPorAño' Puede moverla o quitarla según sea necesario.
            this.vistasPorAñoTableAdapter.Fill(this.estadisticasDataSet1.VistasPorAño);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            checkBox1.Checked = true;
            chart1.ChartAreas[1].Visible = false;
            chart1.ChartAreas[2].Visible = false;
            comboBox3.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "2D")
            {
                chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
                chart1.ChartAreas[1].Area3DStyle.Enable3D = false;
                chart1.ChartAreas[2].Area3DStyle.Enable3D = false;
                trackInclinacion.Enabled = false;
                trackRotacion.Enabled = false;
            }
            else
            {
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
                chart1.ChartAreas[1].Area3DStyle.Enable3D = true;
                chart1.ChartAreas[2].Area3DStyle.Enable3D = true;
                trackInclinacion.Enabled = true;
                trackRotacion.Enabled=true;
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Barras":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    break;
                case "Area":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    break;
                case "Pie":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    break;
                case "Columnas":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case "Anillo":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                    break;
                case "Piramide":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
                    break;
                default:
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
                    break;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { chart1.ChartAreas[0].Visible = true; }
            else { chart1.ChartAreas[0].Visible = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            { chart1.ChartAreas[1].Visible = true; }
            else { chart1.ChartAreas[1].Visible = false; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            { chart1.ChartAreas[2].Visible = true; }
            else { chart1.ChartAreas[2].Visible = false; }
        }

        private void trackRotacion_Scroll(object sender, EventArgs e)
        {
            rotGraf = (trackRotacion.Value)*10;
            chart1.ChartAreas[0].Area3DStyle.Rotation = rotGraf;
            chart1.ChartAreas[1].Area3DStyle.Rotation = rotGraf;
            chart1.ChartAreas[2].Area3DStyle.Rotation = rotGraf;
            lblrot.Text = rotGraf.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
                    break;
                case 1:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
                    break;
                case 2:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
                    break;
                case 3:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
                    break;
                default:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
                    break;
            }
            
        }

        private void trackInclinacion_ValueChanged(object sender, EventArgs e)
        {
            incGraf = (trackInclinacion.Value) * 10;
            chart1.ChartAreas[0].Area3DStyle.Inclination = incGraf;
            chart1.ChartAreas[1].Area3DStyle.Inclination = incGraf;
            chart1.ChartAreas[2].Area3DStyle.Inclination = incGraf;
            lblinc.Text = incGraf.ToString(); 

        }
    }
}
