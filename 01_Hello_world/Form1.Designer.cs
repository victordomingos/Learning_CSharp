namespace _01_Hello_world
{
    partial class Form1
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
            this.txt_hello = new System.Windows.Forms.TextBox();
            this.btn_hello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_hello
            // 
            this.txt_hello.Location = new System.Drawing.Point(40, 52);
            this.txt_hello.Name = "txt_hello";
            this.txt_hello.Size = new System.Drawing.Size(163, 20);
            this.txt_hello.TabIndex = 0;
            // 
            // btn_hello
            // 
            this.btn_hello.Location = new System.Drawing.Point(40, 23);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(163, 23);
            this.btn_hello.TabIndex = 1;
            this.btn_hello.Text = "Say Hello";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.Btn_hello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 93);
            this.Controls.Add(this.btn_hello);
            this.Controls.Add(this.txt_hello);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Say hi!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_hello;
        private System.Windows.Forms.Button btn_hello;
    }
}

