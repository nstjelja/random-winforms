using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingFactorialCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCacluclateFactorial_Click(object sender, EventArgs e)
        {
            var factorial = this.numSeed.Value;

            await Task.WhenAll( CalculateFactorial((int)factorial));


          
        }

        private async Task CalculateFactorial(int seed){
             var result = await Task.Run<BigInteger>( async () => {
                var bi = new BigInteger(1);

                for (var i = 1; i <= seed; i++)
                {
                    bi *= i;
                }

                return bi;
            });

            
            lblFactorial.Text = result.ToString();
        }

       
    }
}
