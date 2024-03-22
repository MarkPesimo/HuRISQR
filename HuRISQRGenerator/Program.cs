using CAL.Global;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuRISQRGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool result;
            var mutex = new System.Threading.Mutex(true, "HURIS QR Generator", out result);

            if (!result)
            {
                MessageBox.Show("Another instance of HURIS QR Generator is already running.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ConnectionControl _configure = new ConnectionControl();
            Signatories _signatories = new Signatories();

            //if (Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\ZMG System\HRIS", "Server Name", null) != null)
            //{
                //_configure.GetSystemConfiguration(appmodule.IRECRUIT);
                _configure.GetSystemConfigurationLocalMachine();
            //}
            //else
            //{
            //    _configure.SetSystemConfigurationNull();
            //    _signatories.SetDCLSystemSignatoriesNull(appmodule.HURIS);
            //}

            //string _message;
            //SecurityControl _securitycontrol = new SecurityControl();
            //_message = _securitycontrol.CheckIfValidAppVerion(appmodule.HURIS);
            //if (_message != null && _message != "")
            //{
            //    MessageBox.Show(_message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            LoginUser.userid = 117;
            LoginUser.accountid = 0;
            LoginUser.usertype = "ADMIN";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QRGeneratorform());

            GC.KeepAlive(mutex);
        }
    }
}
