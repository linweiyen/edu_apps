using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace english_learning
{
    public partial class FrmDialog : Form
    {
        private String _Answer;
        public String Answer
        {
            get
            {
                return this._Answer;
            }
            set
            {
                this.lblAnswer.Text = value;
                this._Answer = value;
                this.txtPractice01.Text = "";
                this.txtPractice02.Text = "";
                this.txtPractice03.Text = "";
                this.txtPractice04.Text = "";
                this.txtPractice05.Text = "";
            }
        }
        public FrmDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(this.txtPractice01.Text.ToLower() != this._Answer.ToLower())
            {
                this.txtPractice01.Text = "填寫錯誤";
                return;
            }
            if (this.txtPractice02.Text.ToLower() != this._Answer.ToLower())
            {
                this.txtPractice02.Text = "填寫錯誤";
                return;
            }
            if (this.txtPractice03.Text.ToLower() != this._Answer.ToLower())
            {
                this.txtPractice03.Text = "填寫錯誤";
                return;
            }
            if (this.txtPractice04.Text.ToLower() != this._Answer.ToLower())
            {
                this.txtPractice04.Text = "填寫錯誤";
                return;
            }
            if (this.txtPractice05.Text.ToLower() != this._Answer.ToLower())
            {
                this.txtPractice05.Text = "填寫錯誤";
                return;
            }

            this.Visible = false;
        }

        private void FrmDialog_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FrmDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
