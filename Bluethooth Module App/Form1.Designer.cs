
namespace Bluethooth_Module_App
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
            this.components = new System.ComponentModel.Container();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Status_txt = new System.Windows.Forms.Label();
            this.Status_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Location = new System.Drawing.Point(12, 9);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(40, 13);
            this.Status_Label.TabIndex = 0;
            this.Status_Label.Text = "Status:";
            // 
            // Status_txt
            // 
            this.Status_txt.AutoSize = true;
            this.Status_txt.Location = new System.Drawing.Point(48, 9);
            this.Status_txt.Name = "Status_txt";
            this.Status_txt.Size = new System.Drawing.Size(61, 13);
            this.Status_txt.TabIndex = 1;
            this.Status_txt.Text = "Status Text";
            // 
            // Status_Timer
            // 
            this.Status_Timer.Tick += new System.EventHandler(this.Status_Update);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Status_txt);
            this.Controls.Add(this.Status_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Label Status_txt;
        private System.Windows.Forms.Timer Status_Timer;
    }
}

