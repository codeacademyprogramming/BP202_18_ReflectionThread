namespace ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pb1_btn = new System.Windows.Forms.Button();
            this.pb2_btn = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 109);
            this.progressBar1.TabIndex = 0;
            // 
            // pb1_btn
            // 
            this.pb1_btn.Location = new System.Drawing.Point(676, 139);
            this.pb1_btn.Name = "pb1_btn";
            this.pb1_btn.Size = new System.Drawing.Size(112, 34);
            this.pb1_btn.TabIndex = 1;
            this.pb1_btn.Text = "Fill PB1";
            this.pb1_btn.UseVisualStyleBackColor = true;
            this.pb1_btn.Click += new System.EventHandler(this.pb1_btn_Click);
            // 
            // pb2_btn
            // 
            this.pb2_btn.Location = new System.Drawing.Point(676, 372);
            this.pb2_btn.Name = "pb2_btn";
            this.pb2_btn.Size = new System.Drawing.Size(112, 34);
            this.pb2_btn.TabIndex = 3;
            this.pb2_btn.Text = "Fill PB2";
            this.pb2_btn.UseVisualStyleBackColor = true;
            this.pb2_btn.Click += new System.EventHandler(this.pb2_btn_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 245);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(776, 109);
            this.progressBar2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb2_btn);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.pb1_btn);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button pb1_btn;
        private System.Windows.Forms.Button pb2_btn;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}
