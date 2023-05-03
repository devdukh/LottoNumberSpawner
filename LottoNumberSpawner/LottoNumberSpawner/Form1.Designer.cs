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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.NumericUpDown();
            this.Max = new System.Windows.Forms.NumericUpDown();
            this.Count = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(116, 98);
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
            this.NumArray.Location = new System.Drawing.Point(12, 127);
            this.NumArray.MaxLength = 10;
            this.NumArray.Name = "NumArray";
            this.NumArray.ReadOnly = true;
            this.NumArray.Size = new System.Drawing.Size(306, 43);
            this.NumArray.TabIndex = 1;
            this.NumArray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "최소값";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "최대값";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(230, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "개 수";
            // 
            // Min
            // 
            this.Min.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Min.Location = new System.Drawing.Point(14, 49);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(98, 43);
            this.Min.TabIndex = 8;
            this.Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Max
            // 
            this.Max.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Max.Location = new System.Drawing.Point(118, 49);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(98, 43);
            this.Max.TabIndex = 9;
            this.Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Count.Location = new System.Drawing.Point(222, 49);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(98, 43);
            this.Count.TabIndex = 10;
            this.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 184);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumArray);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Min);
            this.Name = "Form1";
            this.Text = "로또 번호 생성기";
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Confirm;
        private TextBox NumArray;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown Min;
        private NumericUpDown Max;
        private NumericUpDown Count;
    }
}