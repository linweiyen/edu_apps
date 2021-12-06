using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace english_learning
{
    public partial class FrmMain : Form
    {
        private String _DatabaseFileName = "database.csv";
        private String _CorrectWordFileName = "correct_words.txt";
        private List<Word> _Result = new List<Word>();
        private List<String> _PassedWord = new List<String>();
        private Int32 _CurrentWordIndex = -1;
        private Int32 _CorrectNumber = 0;
        private Int32 _TotalNumber = 0;

        private FrmDialog _PracticeDialog = new FrmDialog();
        private void _Reload()
        {
            //Read Database
            var list = File.ReadLines(this._DatabaseFileName, Encoding.UTF8)
                .Skip(1)
                .Select(it => it.Split(','));
            var passed_word_list = File.ReadLines(this._CorrectWordFileName, Encoding.UTF8);

            this._PassedWord.Clear();
            foreach (var item in passed_word_list)
            {
                this._PassedWord.Add(item);
            }

            List<string> category_list = new List<string>();

            this._Result.Clear();
            foreach (var item in list)
            {
                category_list.Add(item[3]);
                if (ckbPassCorrect.Checked && this._PassedWord.Contains(item[0]))
                {
                    continue;
                }
                this._Result.Add(new Word(item[0], item[1], item[2], item[3]));
            }

            category_list = category_list.Distinct().ToList(); //Get only the unique items

            //Binding to combobax
            this.cbCategory.Items.Clear();
            this.cbCategory.Items.Add("");
            foreach (var item in category_list)
            {
                this.cbCategory.Items.Add(item);
            }

            this.lblTotalWordNumber.Text = this._Result.Count.ToString();
            this._TotalNumber = 0;
            this._CorrectNumber = 0;
            this._CurrentWordIndex = -1;
            this._ShowRecord();
            this._NextWord();

        }

        private void _ShowCurrentWordInfo()
        {
            if (this._CurrentWordIndex >= this._Result.Count)
            {
                this.lblChinese.Text = "";
                this.txtEnglish.Text = "";
                this.lblWordInfo.Text = "";
                return;
            }

            Word item = this._Result[this._CurrentWordIndex];
            this.lblChinese.Text = item.Chinese;
            this.lblWordInfo.Text = "[" + item.PoS + "]" + "[" + item.Category + "]";
            this.txtEnglish.Text = "";
            this.lblWordInfo.Left = this.lblChinese.Left + this.lblChinese.Width + 100;
        }

        private void _NextWord()
        {
            do
            {
                this._CurrentWordIndex++;
                if (this._CurrentWordIndex >= this._Result.Count)
                {
                    MessageBox.Show("測驗結束，得分是 " + this.lblResult.Text);
                    this._Reload();
                    return;
                }
                if (this.cbCategory.Text == "" || this._Result[this._CurrentWordIndex].Category == this.cbCategory.Text)
                    break;
            } while (true);

            this._ShowCurrentWordInfo();
        }


        private void _ShowRecord()
        {
            this.lblResult.Text = this._CorrectNumber + "/" + this._TotalNumber;
        }


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this._Reload();
        }

        private bool _FirstAnswer = true;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Check the correct of result
            Word item = this._Result[this._CurrentWordIndex];
            if (item.English.ToLower().Trim() == this.txtEnglish.Text.ToLower().Trim())
            {
                if (_FirstAnswer && !this._PassedWord.Contains(item.English))
                {
                    this._PassedWord.Add(item.English);

                    using (StreamWriter sw = new StreamWriter(this._CorrectWordFileName))
                    {
                        foreach (var correct_word in this._PassedWord)
                        {
                            sw.WriteLine(correct_word);
                        }
                    }
                }
                this._CorrectNumber++;
                this._TotalNumber++;
                this._ShowRecord();
                this._NextWord();
                this._FirstAnswer = true;
            }
            else
            {
                this._FirstAnswer = false;
                MessageBox.Show("寶貝，你拼錯了");
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this._NextWord();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._PracticeDialog.Answer = this._Result[this._CurrentWordIndex].English;
            this._PracticeDialog.ShowDialog();
            this._TotalNumber++;
            this._ShowRecord();
            this._NextWord();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this._Reload();
        }

        private void ckbPassCorrect_CheckedChanged(object sender, EventArgs e)
        {
            this._Reload();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._CurrentWordIndex--;
            this._NextWord();
        }
    }
}
