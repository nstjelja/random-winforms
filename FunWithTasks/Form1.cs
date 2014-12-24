using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithTasks
{
    public partial class Form1 : Form
    {

        Task runningTask = null;
        CancellationToken token = new CancellationToken(false);
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            runningTask = Task.Factory.StartNew(() => {
                while (true) {

                    if (token.IsCancellationRequested)
                        break;

                    Task.Delay(100).Wait();
                    var time = DateTime.Now.ToString();

                    Invoke(new Action(() => this.time.Text = time));
                }
            }, token,TaskCreationOptions.LongRunning, TaskScheduler.Default);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (runningTask == null)
                return;

            token.WaitHandle.Close();
        }

        
    }
}
