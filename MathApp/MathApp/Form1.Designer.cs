namespace Math_Quiz_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Leftlabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Leftlabel
            // 
            this.Leftlabel.AutoSize = true;
            this.Leftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leftlabel.Location = new System.Drawing.Point(26, 102);
            this.Leftlabel.Name = "Leftlabel";
            this.Leftlabel.Size = new System.Drawing.Size(18, 20);
            this.Leftlabel.TabIndex = 2;
            this.Leftlabel.Text = "?";
            // 
            // Submit
            // 
            this.Submit.AutoSize = true;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(255, 344);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(102, 34);
            this.Submit.TabIndex = 22;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(257, 102);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(100, 20);
            this.Answer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 415);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Leftlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Leftlabel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Answer;
    }
}

