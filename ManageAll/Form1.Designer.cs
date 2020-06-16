namespace ManageAll
{
    partial class home
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
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(151, 270);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(109, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(23, 270);
            this.txtCode.Name = "txtCode";
            this.txtCode.PromptText = "Enter text to be encoded!";
            this.txtCode.Size = new System.Drawing.Size(122, 23);
            this.txtCode.TabIndex = 1;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(23, 63);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(237, 201);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 310);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnGenerate);
            this.Name = "home";
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private System.Windows.Forms.PictureBox picBox;
    }
}

