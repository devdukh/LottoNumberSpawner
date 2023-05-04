namespace LottoNumberSpawner
{
    partial class Form1
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
            this.Confirm = new System.Windows.Forms.Button();
            this.NumArray = new System.Windows.Forms.TextBox();
            this.Lotto = new System.Windows.Forms.RadioButton();
            this.Yeon = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(118, 50);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(98, 23);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "생 성";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // NumArray
            // 
            this.NumArray.Enabled = false;
            this.NumArray.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumArray.Location = new System.Drawing.Point(12, 79);
            this.NumArray.MaxLength = 10;
            this.NumArray.Name = "NumArray";
            this.NumArray.ReadOnly = true;
            this.NumArray.Size = new System.Drawing.Size(306, 43);
            this.NumArray.TabIndex = 1;
            this.NumArray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lotto
            // 
            this.Lotto.AutoSize = true;
            this.Lotto.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lotto.Location = new System.Drawing.Point(12, 12);
            this.Lotto.Name = "Lotto";
            this.Lotto.Size = new System.Drawing.Size(70, 32);
            this.Lotto.TabIndex = 2;
            this.Lotto.TabStop = true;
            this.Lotto.Text = "로또";
            this.Lotto.UseVisualStyleBackColor = true;
            // 
            // Yeon
            // 
            this.Yeon.AutoSize = true;
            this.Yeon.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Yeon.Location = new System.Drawing.Point(208, 12);
            this.Yeon.Name = "Yeon";
            this.Yeon.Size = new System.Drawing.Size(110, 32);
            this.Yeon.TabIndex = 3;
            this.Yeon.TabStop = true;
            this.Yeon.Text = "연금복권";
            this.Yeon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 131);
            this.Controls.Add(this.Yeon);
            this.Controls.Add(this.Lotto);
            this.Controls.Add(this.NumArray);
            this.Controls.Add(this.Confirm);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "로또 번호 생성기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Confirm;
        private TextBox NumArray;
        private RadioButton Lotto;
        private RadioButton Yeon;
    }
}