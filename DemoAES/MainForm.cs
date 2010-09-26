using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DemoAES
{
    public partial class MainForm : Form
    {
        #region Events
        public delegate void ViewEventHandler(object sender, ViewStateArgs e);
        public static event ViewEventHandler ViewStateEvent;

        public delegate void EndThreadEventHandler(object sender, EndStateArgs e);
        public static event EndThreadEventHandler EndStateEvent;
        #endregion

        #region Events Handlers
        void ViewState(object sender, ViewStateArgs e)
        {
            if (!isAuto.Checked)
            {
                MyThread.Suspend();
            }
            ViewMatrix.State = e.StateMatrix;
            ViewMatrix.View();

        }
        void EndState(object sender, EndStateArgs e)
        {
            MessageBox.Show("end");

        }
        #endregion

        #region Variables
        Cryptographer Cgrapher = null;
        private bool IsEncryption = false;
        Thread MyThread;
        #endregion

        #region Thread Operations
        private void StartThread()
        {
            MyThread.Start();
        }
        private void EndThread()
        {

        }
        #endregion

        #region Encryption/Decryption
        private void StartProcess(string _file_path,string _new_file_path,string _key)
        {
            if (IsEncryption == true)
            {
                    Cgrapher = new Cryptographer(ViewStateEvent, EndStateEvent);
                    Cgrapher.EncryptionStart(_file_path.Replace("\\", "\\\\"), _new_file_path.Replace("\\", "\\\\"), _key);
            }
            else
            {
                    Cgrapher = new Cryptographer( ViewStateEvent, EndStateEvent);
                    Cgrapher.DecryptionStart(_file_path.Replace("\\", "\\\\"), _new_file_path.Replace("\\", "\\\\"), _key);
            }
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Buttons Events

        private void bt_encrypt_Click(object sender, EventArgs e)
        {
            IsEncryption = true;

            StartThread();
        }
        private void bt_decrypt_Click(object sender, EventArgs e)
        {
            IsEncryption = false;

            StartThread();
        }

        private void bt_file_select_Click(object sender, EventArgs e)
        {
            txt_file_path.Clear();
            txt_new_file_path.Clear();

            if (OD.ShowDialog() == DialogResult.OK)
            {
                txt_file_path.Text = OD.FileName;
                txt_new_file_path.Text = OD.FileName.Replace(".", "_2.");
            }
        }
        private void bt_key_select_Click(object sender, EventArgs e)
        {
            txt_key.Clear();
            key_path.Clear();
            if (OD.ShowDialog() == DialogResult.OK)
            {
                key_path.Text = OD.FileName;
                FileStream fs = new FileStream(key_path.Text, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                txt_key.Text = sr.ReadToEnd();
            }
        }
        private void bt_step_Click(object sender, EventArgs e)
        {
            if (MyThread.ThreadState == ThreadState.Suspended)
            {
                MyThread.Resume();
            }
        }

        private void isHex_CheckedChanged(object sender, EventArgs e)
        {
            ViewMatrix.Hex = isHex.Checked;
        }

        #endregion

        void DoWork(object sender)
        {
            this.StartProcess(txt_file_path.Text, txt_new_file_path.Text, txt_key.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Set Events
            ViewStateEvent += new ViewEventHandler(ViewState);
            EndStateEvent += new EndThreadEventHandler(EndState);
            #endregion

            MyThread = new Thread(new ParameterizedThreadStart(DoWork));
        }

        private void bt_clipboard_Click(object sender, EventArgs e)
        {
            string clip = "";
            for (int j = 0; j < ViewMatrix.State.Rows; j++)
            {
                for (int i = 0; i < ViewMatrix.State.Columns; i++)
                {
                    MyLabel tmp;
                    tmp = (MyLabel)ViewMatrix.Labels[j * 4 + i];
                    clip += "-" + tmp.Text;
                }
                clip = clip + "\r\n";
            }
            System.Windows.Forms.Clipboard.SetDataObject(clip, true);
        }
    }

    public partial class MyLabel : Label
    {
        public void ChangeText(string newText)
        {
            this.Text = newText;
        }
    }
}