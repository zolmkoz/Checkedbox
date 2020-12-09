
namespace WindowsFormsApp2
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
            this.chk_Accept = new System.Windows.Forms.CheckBox();
            this.txt_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chk_Accept
            // 
            this.chk_Accept.AutoSize = true;
            this.chk_Accept.Location = new System.Drawing.Point(238, 121);
            this.chk_Accept.Name = "chk_Accept";
            this.chk_Accept.Size = new System.Drawing.Size(64, 17);
            this.chk_Accept.TabIndex = 0;
            this.chk_Accept.Text = "i accept";
            this.chk_Accept.UseVisualStyleBackColor = true;
            this.chk_Accept.CheckedChanged += new System.EventHandler(this.chk_Accept_CheckedChanged);
            // 
            // txt_result
            // 
            this.txt_result.Enabled = false;
            this.txt_result.Location = new System.Drawing.Point(238, 168);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(75, 23);
            this.txt_result.TabIndex = 1;
            this.txt_result.Text = "Submit";
            this.txt_result.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.chk_Accept);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Accept;
        private System.Windows.Forms.Button txt_result;
    }
}

