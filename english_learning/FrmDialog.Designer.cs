
namespace english_learning
{
    partial class FrmDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPractice01 = new System.Windows.Forms.TextBox();
            this.txtPractice02 = new System.Windows.Forms.TextBox();
            this.txtPractice03 = new System.Windows.Forms.TextBox();
            this.txtPractice04 = new System.Windows.Forms.TextBox();
            this.txtPractice05 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "正確答案是";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer.Location = new System.Drawing.Point(503, 68);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(270, 85);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 85);
            this.label2.TabIndex = 2;
            this.label2.Text = "請練習五次";
            // 
            // txtPractice01
            // 
            this.txtPractice01.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPractice01.Location = new System.Drawing.Point(103, 300);
            this.txtPractice01.Name = "txtPractice01";
            this.txtPractice01.Size = new System.Drawing.Size(905, 92);
            this.txtPractice01.TabIndex = 3;
            // 
            // txtPractice02
            // 
            this.txtPractice02.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPractice02.Location = new System.Drawing.Point(103, 409);
            this.txtPractice02.Name = "txtPractice02";
            this.txtPractice02.Size = new System.Drawing.Size(905, 92);
            this.txtPractice02.TabIndex = 4;
            // 
            // txtPractice03
            // 
            this.txtPractice03.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPractice03.Location = new System.Drawing.Point(103, 518);
            this.txtPractice03.Name = "txtPractice03";
            this.txtPractice03.Size = new System.Drawing.Size(905, 92);
            this.txtPractice03.TabIndex = 5;
            // 
            // txtPractice04
            // 
            this.txtPractice04.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPractice04.Location = new System.Drawing.Point(103, 632);
            this.txtPractice04.Name = "txtPractice04";
            this.txtPractice04.Size = new System.Drawing.Size(905, 92);
            this.txtPractice04.TabIndex = 6;
            // 
            // txtPractice05
            // 
            this.txtPractice05.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPractice05.Location = new System.Drawing.Point(103, 742);
            this.txtPractice05.Name = "txtPractice05";
            this.txtPractice05.Size = new System.Drawing.Size(905, 92);
            this.txtPractice05.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOK.Location = new System.Drawing.Point(103, 861);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(258, 105);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "確認";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1128, 855);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPractice05);
            this.Controls.Add(this.txtPractice04);
            this.Controls.Add(this.txtPractice03);
            this.Controls.Add(this.txtPractice02);
            this.Controls.Add(this.txtPractice01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "練習";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDialog_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDialog_FormClosed);
            this.Load += new System.EventHandler(this.FrmDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPractice01;
        private System.Windows.Forms.TextBox txtPractice02;
        private System.Windows.Forms.TextBox txtPractice03;
        private System.Windows.Forms.TextBox txtPractice04;
        private System.Windows.Forms.TextBox txtPractice05;
        private System.Windows.Forms.Button btnOK;
    }
}