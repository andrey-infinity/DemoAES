using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace DemoAES
{
    public partial class MatrixState : UserControl
    {
        #region  Variables

        private bool _hex;
        private Matrix _state;
        public ArrayList Labels = new ArrayList();
        public bool Hex
        {
            get { return _hex; }
            set
            {
                _hex = value;
                View();
            }
        }
        public Matrix State
        {
            get { return _state; }
            set { _state = value; }
        }

        #endregion

        #region The Main View Thing

        delegate void ChangeTextMethodDelegate(string arg);
        public void View()
        {
            if (_state != null)
            {
                if (!Hex)
                {
                    #region Cicles
                    for (int j = 0; j < _state.Rows; j++)
                    {
                        for (int i = 0; i < _state.Columns; i++)
                        {
                            MyLabel tmp;
                            tmp = (MyLabel)Labels[j * 4 + i];
                            tmp.Invoke(new ChangeTextMethodDelegate(tmp.ChangeText), _state[j, i]);
                        }
                    }
                    #endregion
                }
                else
                {
                    #region Cicles
                    for (int j = 0; j < _state.Rows; j++)
                    {
                        for (int i = 0; i < _state.Columns; i++)
                        {
                            MyLabel tmp;
                            tmp = (MyLabel)Labels[j * 4 + i];
                            tmp.Invoke(new ChangeTextMethodDelegate(tmp.ChangeText), BaseTransform.FromBinaryToHex(_state[j, i]));

                        }

                    }
                    #endregion
                }
            }

        }

        #endregion

        #region Ini
        public void Init()
        {
            MyLabel tmp;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    tmp = new MyLabel();
                    tmp.AutoSize = true;
                    tmp.Name = "lablel_"+(j * 4 + i).ToString();
                    tmp.Text = (j * 4 + i).ToString();
                    tmp.Size = new Size(15, 15);
                    tmp.Location = new Point(75 * j, 50 * i);
                    Labels.Add(tmp);
                    this.Controls.Add(tmp);
                }
            }

        }
        #endregion

        public MatrixState()
        {
            InitializeComponent();
        }

        private void MatrixState_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
