using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeTemperatura
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void cmbEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Conversor_Load(object sender, EventArgs e)
        {
            String[] units = { "°F", "°C", "K" };
            foreach (var unit in units)
            {
                cmbEntrada.Items.Add(unit);
                cmbSaida.Items.Add(unit);
            }

            cmbEntrada.Text = units[0];
            cmbSaida.Text = units[1];
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtTemperatura.Text);
            double result = 0;
            string unit1 = cmbEntrada.Text;
            string unit2 = cmbSaida.Text;

            if (unit1 == unit2)
            {
                result = value;
            }
            else if (unit1 == "°F")
            {
                if (unit2 == "°C")
                {
                    result = Converter.F_para_C(value);
                }
                else if (unit2 == "K")
                {
                    result = Converter.F_para_K(value);
                }
            }
            else if (unit1 == "°C")
            {
                if (unit2 == "°F")
                {
                    result = Converter.C_para_F(value);
                }
                else if (unit2 == "K")
                {
                    result = Converter.C_para_K(value);
                }
            }
            else if (unit1 == "K")
            {
                if (unit2 == "°F")
                {
                    result = Converter.K_para_F(value);
                }
                else if (unit2 == "°C")
                {
                    result = Converter.K_para_C(value);
                }
            }

            result = Math.Round(result, 2);
            lblResultado.Text = $"{result}{unit2}";
        }
    }
}

