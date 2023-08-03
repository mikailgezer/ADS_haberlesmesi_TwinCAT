using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace ADSCommunication
{
    public partial class Form1 : Form
    {

        TcAdsClient tcClient = new TcAdsClient();

        bool Connection_Control;
        public StateInfo connection_state;

        public string DIGITAL_STATE;

        public int digitalInput2_handle;
        public int readWrite_handle;
        public int akim_Output_handle;
        public int gerilim_Output_handle;

        public Form1()
        {
            InitializeComponent();
        }

        public void CONNECT_2_BECKHOFF()
        {
            try
            {
                tcClient.Connect("169.254.17.200.1.1", 851);

                Connection_Control = true;


                readWrite_handle = tcClient.CreateVariableHandle("MAIN.readWriteValue");
                akim_Output_handle = tcClient.CreateVariableHandle("MAIN.akim_Output");
                gerilim_Output_handle = tcClient.CreateVariableHandle("MAIN.gerilim_Output");

                digitalInput2_handle = tcClient.AddDeviceNotificationEx("MAIN.digitalInput2", AdsTransMode.Cyclic, 50, 50, null, typeof(bool));

                tcClient.AdsNotificationEx += TcClient_AdsNotificationEx;
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error");
            }
        }



        public void DISCONNECT_FR_BECKHOFF()
        {
            try
            {
                tcClient.Dispose();
                Connection_Control = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Connection study");
            }
        }


        private void TcClient_AdsNotificationEx(object sender, AdsNotificationExEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            if (tcClient.IsConnected)
            {
                if (tcClient.TryReadState(out connection_state) == AdsErrorCode.NoError)
                {
                    try
                    {
                        if (e.NotificationHandle == digitalInput2_handle)
                        {
                            DIGITAL_STATE = e.Value.ToString();
                            if (DIGITAL_STATE == "True")
                            {
                                txtEnabled.Text = "ENABLED";
                            }
                            else
                            {
                                txtEnabled.Text = "DISABLED";
                            }
                        }

                        if (e.NotificationHandle == readWrite_handle)
                        {
                            txtFloatValue.Invoke(
                                new Action(() => txtFloatValue.Text = e.Value.ToString()));
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("AdsNotificationEx Error");
                    }
                }
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Connection_Control)
                {
                    CONNECT_2_BECKHOFF();
                }
                else
                {
                    DISCONNECT_FR_BECKHOFF();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error");
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            tcClient.WriteSymbol("MAIN.digitalInput2", true, true);
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            tcClient.WriteSymbol("MAIN.digitalInput2", false, false);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int analogOutput1_handle_write = tcClient.CreateVariableHandle("MAIN.readWriteValue");
            Single fValue = Convert.ToSingle(tcClient.ReadAny(analogOutput1_handle_write, typeof(Single)));
            tcClient.DeleteVariableHandle(analogOutput1_handle_write);
            txtFloatValue.Text = fValue.ToString();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            int analogOutput1_handle_write = tcClient.CreateVariableHandle("MAIN.readWriteValue");
            Single fValue = Convert.ToSingle(txtFloatValue.Text);
            tcClient.WriteAny(analogOutput1_handle_write, fValue);
            tcClient.DeleteVariableHandle(analogOutput1_handle_write);
        }

        private void btnCurrentWrite_Click(object sender, EventArgs e)
        {
            int rAkim_handle_write = tcClient.CreateVariableHandle("MAIN.akim_Output");
            Single fValue = Convert.ToSingle(txtCurrentWrite.Text);
            tcClient.WriteAny(rAkim_handle_write, fValue);
            tcClient.DeleteVariableHandle(rAkim_handle_write);
        }

        private void btnVoltageWrite_Click(object sender, EventArgs e)
        {
            int gerilim_handle_write = tcClient.CreateVariableHandle("MAIN.gerilim_Output");
            Single fValue = Convert.ToSingle(txtVoltageWrite.Text);
            tcClient.WriteAny(gerilim_handle_write, fValue);
            tcClient.DeleteVariableHandle(gerilim_handle_write);
        }

        

        

        
    }
}
