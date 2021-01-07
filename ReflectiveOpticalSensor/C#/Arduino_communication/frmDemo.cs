using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMTcs;
using System.Diagnostics;

namespace UI
{
    public partial class frmDemo : Form
    {
        TGMTarduino m_arduino;
        bool m_formClosed;
        Stopwatch m_watch;

        public frmDemo()
        {
            InitializeComponent();               
        }

        private void frmDemo_Load(object sender, EventArgs e)
        {
            InitArduino();
            m_watch = Stopwatch.StartNew();
        }

        private void frmDemo_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_formClosed = true;
            m_arduino.Disconnect();
        }

        private void chk_autoConnect_CheckedChanged(object sender, EventArgs e)
        {
            txt_port.Enabled = !chk_autoConnect.Checked;
        }

        void OnArduinoMessage(object sender, ArduinoEventArgs args)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if(args.message.Contains("Item appear"))
                {
                    m_watch.Stop();
                    long elapsed = m_watch.ElapsedMilliseconds;
                    lbl_elapsed.Text = elapsed.ToString() + "ms";
                    double speed = 3.0 * 1000 / elapsed;
                    lbl_speed.Text = String.Format("{0:0.00}", speed) + "m/s";

                    m_watch = Stopwatch.StartNew();
                }
            });
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        
        void OnBoardDisconnedted(object sender, ArduinoEventArgs args)
        {
            if (m_formClosed)
                return;

            
            this.btn_connect.Invoke((MethodInvoker)delegate
            {
                btn_connect.Enabled = true;
            });

            this.lblArduino.Invoke((MethodInvoker)delegate
            {
                lblArduino.Text = "Board disconnected";
                lblArduino.ForeColor = Color.Red;
            });
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            InitArduino();
        }

        void InitArduino()
        {
            string port = "";
            if(chk_autoConnect.Checked == false)
            {
                port = txt_port.Text;
            }
            m_arduino = new TGMTarduino(port);
            m_arduino.onMessageReceived += OnArduinoMessage;
            m_arduino.onBoardDisconnectedHandler += OnBoardDisconnedted;

            if (m_arduino.Connected)
            {
                lblArduino.Text = "Connected to " + m_arduino.ConnectedPort;
                lblArduino.ForeColor = Color.Green;

                txt_port.Text = m_arduino.ConnectedPort;

                btn_connect.Enabled = false;
            }
            else
            {
                lblArduino.Text = "Can not connect to board";
                lblArduino.ForeColor = Color.Red;

                btn_connect.Enabled = true;
            }
        }

    }
}
