namespace Client.Forms
{
    partial class FinishTestingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.qExit = new System.Windows.Forms.Button();
            this.qResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qF = new System.Windows.Forms.Label();
            this.qN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mistakesButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qExit
            // 
            this.qExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qExit.Location = new System.Drawing.Point(280, 305);
            this.qExit.Margin = new System.Windows.Forms.Padding(6);
            this.qExit.Name = "qExit";
            this.qExit.Size = new System.Drawing.Size(235, 56);
            this.qExit.TabIndex = 0;
            this.qExit.Text = "�����";
            this.qExit.UseVisualStyleBackColor = true;
            this.qExit.Click += new System.EventHandler(this.qExit_Click);
            // 
            // qResult
            // 
            this.qResult.AutoSize = true;
            this.qResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qResult.ForeColor = System.Drawing.Color.Black;
            this.qResult.Location = new System.Drawing.Point(453, 136);
            this.qResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.qResult.Name = "qResult";
            this.qResult.Size = new System.Drawing.Size(40, 29);
            this.qResult.TabIndex = 1;
            this.qResult.Text = "---";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "������������ ���������. ���������� ���������� �������:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qF);
            this.groupBox1.Controls.Add(this.qN);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(500, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "���������� � ��������";
            // 
            // qF
            // 
            this.qF.AutoSize = true;
            this.qF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qF.ForeColor = System.Drawing.Color.Red;
            this.qF.Location = new System.Drawing.Point(245, 35);
            this.qF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.qF.Name = "qF";
            this.qF.Size = new System.Drawing.Size(28, 24);
            this.qF.TabIndex = 1;
            this.qF.Text = "---";
            // 
            // qN
            // 
            this.qN.AutoSize = true;
            this.qN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qN.ForeColor = System.Drawing.Color.Red;
            this.qN.Location = new System.Drawing.Point(12, 35);
            this.qN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.qN.Name = "qN";
            this.qN.Size = new System.Drawing.Size(28, 24);
            this.qN.TabIndex = 0;
            this.qN.Text = "---";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "� ���������(%):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "������:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(258, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "---";
            // 
            // mistakesButton
            // 
            this.mistakesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mistakesButton.Location = new System.Drawing.Point(15, 305);
            this.mistakesButton.Margin = new System.Windows.Forms.Padding(6);
            this.mistakesButton.Name = "mistakesButton";
            this.mistakesButton.Size = new System.Drawing.Size(235, 56);
            this.mistakesButton.TabIndex = 7;
            this.mistakesButton.Text = "����������� ������";
            this.mistakesButton.UseVisualStyleBackColor = true;
            this.mistakesButton.Click += new System.EventHandler(this.mistakesButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(453, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "---";
            // 
            // FinishTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(524, 376);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mistakesButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qResult);
            this.Controls.Add(this.qExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinishTestingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "���������� ������������";
            this.Load += new System.EventHandler(this.FinishTestingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button qExit;
        private System.Windows.Forms.Label qResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label qF;
        private System.Windows.Forms.Label qN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mistakesButton;
        private System.Windows.Forms.Label label5;
    }
}