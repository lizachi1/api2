namespace Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.magicBtn = new System.Windows.Forms.Button();
            this.firstNumberInput = new System.Windows.Forms.TextBox();
            this.secondNumberInput = new System.Windows.Forms.TextBox();
            this.sumResult = new System.Windows.Forms.TextBox();
            this.multResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // magicBtn
            // 
            this.magicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.magicBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.magicBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.magicBtn.Location = new System.Drawing.Point(108, 131);
            this.magicBtn.Name = "magicBtn";
            this.magicBtn.Size = new System.Drawing.Size(173, 43);
            this.magicBtn.TabIndex = 0;
            this.magicBtn.Text = "Get sum and mult";
            this.magicBtn.UseVisualStyleBackColor = false;
            // 
            // firstNumberInput
            // 
            this.firstNumberInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.firstNumberInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNumberInput.Location = new System.Drawing.Point(72, 73);
            this.firstNumberInput.Name = "firstNumberInput";
            this.firstNumberInput.Size = new System.Drawing.Size(100, 27);
            this.firstNumberInput.TabIndex = 1;
            this.firstNumberInput.Text = "10";
            // 
            // secondNumberInput
            // 
            this.secondNumberInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.secondNumberInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondNumberInput.Location = new System.Drawing.Point(212, 73);
            this.secondNumberInput.Name = "secondNumberInput";
            this.secondNumberInput.Size = new System.Drawing.Size(100, 27);
            this.secondNumberInput.TabIndex = 2;
            this.secondNumberInput.Text = "20";
            // 
            // sumResult
            // 
            this.sumResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sumResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumResult.Location = new System.Drawing.Point(72, 208);
            this.sumResult.Name = "sumResult";
            this.sumResult.Size = new System.Drawing.Size(100, 27);
            this.sumResult.TabIndex = 3;
            // 
            // multResult
            // 
            this.multResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.multResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multResult.Location = new System.Drawing.Point(212, 208);
            this.multResult.Name = "multResult";
            this.multResult.Size = new System.Drawing.Size(100, 27);
            this.multResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(377, 306);
            this.Controls.Add(this.multResult);
            this.Controls.Add(this.sumResult);
            this.Controls.Add(this.secondNumberInput);
            this.Controls.Add(this.firstNumberInput);
            this.Controls.Add(this.magicBtn);
            this.Name = "Form1";
            this.Text = "lab2";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button magicBtn;
        private TextBox firstNumberInput;
        private TextBox secondNumberInput;
        private TextBox sumResult;
        private TextBox multResult;
    }
}
