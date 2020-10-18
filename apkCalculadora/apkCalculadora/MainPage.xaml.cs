using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace apkCalculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            wkOperacion.Items.Add("suma");
            wkOperacion.Items.Add("resta");
            wkOperacion.Items.Add("multiplicacion");
            wkOperacion.Items.Add("division");
            wkOperacion.SelectedIndexChanged += WkOperacion_SelectedIndexChanged;
        }

        private void WkOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            String op = wkOperacion.SelectedItem.ToString();
            int n1 = Int32.Parse(txtn1.Text);
            int n2 = Int32.Parse(txtn2.Text);
            double res = 0;

            if (op == "suma")
            {
                res = n1 + n2;
            }
            else if (op == "resta")
            {
                res = n1 - n2;
            }
            else if (op == "multiplicacion")
            {
                res = n1 * n2;
            }
            else if (op == "division")
            {
                res = n1 / n2;
            }
            else
            {
                Console.WriteLine("no se pueden hacer calculos multiples");
            }
            lblRes.Text = res + "";
        }
    }
}
