using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMarconiSP4
{
    public partial class Main : Form
    {
        public float[] vecTotales = new float[5];
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dgvMozos.Rows.Add();
            dgvMozos[0, 0].Value = "Julio";
            dgvMozos.Rows.Add();
            dgvMozos[0, 1].Value = "Esteban";
            dgvMozos.Rows.Add();
            dgvMozos[0, 2].Value = "Javier";
            dgvMozos.Rows.Add();
            dgvMozos[0, 3].Value = "Gonzalo";
            dgvMozos.Rows.Add();
            dgvMozos[0, 4].Value = "Alberto";
            for (int c = 1; c < dgvMozos.ColumnCount; c++)
            {
                for (int f = 0; f < dgvMozos.Rows.Count; f++)
                {
                    if (dgvMozos[c, f].Value == null)
                    {
                        dgvMozos[c, f].Value = 0;
                    }
                }
            }
        }

        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            bool datosValidados = true;
            for (int c = 1; c < dgvMozos.ColumnCount; c++)
            {
                for (int r = 0; r < dgvMozos.Rows.Count; r++)
                {
                    if (dgvMozos[c, r].Value == null)
                    {
                        datosValidados = false;
                        MessageBox.Show("Faltan datos en:\nMozo: " + dgvMozos[0, r].Value + ", Categoría: " + dgvMozos.Columns[c].Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (datosValidados == true)
            {
                MessageBox.Show("Datos Correctos!", "Genial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnTotales.Enabled = true;
            }
        }

        private void btnMozoDia_Click(object sender, EventArgs e)
        {
            Array.Clear(vecTotales, 0, vecTotales.Length);
            for (int f = 0; f < dgvMozos.ColumnCount; f++)
            {
                for (int c = 1; c < dgvMozos.Rows.Count; c++)
                {
                    vecTotales[f] = vecTotales[f] + Convert.ToSingle(dgvMozos[c, f].Value);
                }
            }
            int mayorTotal = Array.IndexOf(vecTotales, vecTotales.Max());
            if (mayorTotal == 0)
            {
                txtMozoDia.Text = "Julio - $" + vecTotales.Max();
            }
            else
            {
                if (mayorTotal == 1)
                {
                    txtMozoDia.Text = "Esteban - $" + vecTotales.Max();
                }
                else
                {
                    if (mayorTotal == 2)
                    {
                        txtMozoDia.Text = "Javier - $" + vecTotales.Max();
                    }
                    else
                    {
                        if (mayorTotal == 3)
                        {
                            txtMozoDia.Text = "Gonzalo - $" + vecTotales.Max();
                        }
                        else
                        {
                            if (mayorTotal == 4)
                            {
                                txtMozoDia.Text = "Alberto - $" + vecTotales.Max();
                            }
                        }
                    }
                }
            }
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            Array.Clear(vecTotales, 0, vecTotales.Length);
            for (int f = 0; f < dgvMozos.ColumnCount; f++)
            {
                for (int c = 1; c < dgvMozos.Rows.Count; c++)
                {
                    vecTotales[f] = vecTotales[f] + Convert.ToSingle(dgvMozos[c, f].Value);
                }
                if (f == 0)
                {
                    lstTotales.Items.Add("Total Julio: $" + vecTotales[f]);
                }
                else
                {
                    if (f == 1)
                    {
                        lstTotales.Items.Add("Total Esteban: $" + vecTotales[f]);
                    }
                    else
                    {
                        if (f == 2)
                        {
                            lstTotales.Items.Add("Total Javier: $" + vecTotales[f]);
                        }
                        else
                        {
                            if (f == 3)
                            {
                                lstTotales.Items.Add("Total Gonzalo: $" + vecTotales[f]);
                            }
                            else
                            {
                                if (f == 4)
                                {
                                    lstTotales.Items.Add("Total Alberto: $" + vecTotales[f]);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
