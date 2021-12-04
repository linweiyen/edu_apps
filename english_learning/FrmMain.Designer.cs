
namespace english_learning
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblChinese = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.lblWordInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalWordNumber = new System.Windows.Forms.Label();
            this.ckbPassCorrect = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblChinese
            // 
            this.lblChinese.AutoSize = true;
            this.lblChinese.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChinese.Location = new System.Drawing.Point(41, 146);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(338, 127);
            this.lblChinese.TabIndex = 0;
            this.lblChinese.Text = "label1";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnglish.Location = new System.Drawing.Point(41, 347);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(1314, 135);
            this.txtEnglish.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(50, 634);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(288, 118);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(1221, 26);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(143, 85);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "0/0";
            // 
            // btnSkip
            // 
            this.btnSkip.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSkip.Location = new System.Drawing.Point(732, 634);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(288, 118);
            this.btnSkip.TabIndex = 4;
            this.btnSkip.Text = "跳過";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(384, 634);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(288, 118);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "認錯";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(1076, 634);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(288, 118);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "重來";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmessage.Location = new System.Drawing.Point(830, 26);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(372, 85);
            this.lblmessage.TabIndex = 7;
            this.lblmessage.Text = "目前成績：";
            // 
            // lblWordInfo
            // 
            this.lblWordInfo.AutoSize = true;
            this.lblWordInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWordInfo.Location = new System.Drawing.Point(413, 180);
            this.lblWordInfo.Name = "lblWordInfo";
            this.lblWordInfo.Size = new System.Drawing.Size(182, 68);
            this.lblWordInfo.TabIndex = 8;
            this.lblWordInfo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(386, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 85);
            this.label1.TabIndex = 10;
            this.label1.Text = "總字數";
            // 
            // lblTotalWordNumber
            // 
            this.lblTotalWordNumber.AutoSize = true;
            this.lblTotalWordNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalWordNumber.Location = new System.Drawing.Point(618, 26);
            this.lblTotalWordNumber.Name = "lblTotalWordNumber";
            this.lblTotalWordNumber.Size = new System.Drawing.Size(154, 85);
            this.lblTotalWordNumber.TabIndex = 9;
            this.lblTotalWordNumber.Text = "300";
            // 
            // ckbPassCorrect
            // 
            this.ckbPassCorrect.AutoSize = true;
            this.ckbPassCorrect.Checked = true;
            this.ckbPassCorrect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbPassCorrect.Location = new System.Drawing.Point(50, 542);
            this.ckbPassCorrect.Name = "ckbPassCorrect";
            this.ckbPassCorrect.Size = new System.Drawing.Size(325, 42);
            this.ckbPassCorrect.TabIndex = 11;
            this.ckbPassCorrect.Text = "略過已正確答對文字";
            this.ckbPassCorrect.UseVisualStyleBackColor = true;
            this.ckbPassCorrect.CheckedChanged += new System.EventHandler(this.ckbPassCorrect_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1401, 830);
            this.Controls.Add(this.ckbPassCorrect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalWordNumber);
            this.Controls.Add(this.lblWordInfo);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.lblChinese);
            this.Name = "FrmMain";
            this.Text = "英文單字測驗";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label lblWordInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalWordNumber;
        private System.Windows.Forms.CheckBox ckbPassCorrect;
    }
}

