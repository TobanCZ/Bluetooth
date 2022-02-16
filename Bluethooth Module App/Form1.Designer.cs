
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
            this.Connect_Button = new System.Windows.Forms.Button();
            this.Port_box = new System.Windows.Forms.ComboBox();
            this.Baud_Rate_box = new System.Windows.Forms.ComboBox();
            this.Port_label = new System.Windows.Forms.Label();
            this.Baud_Rate_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Location = new System.Drawing.Point(1387, 9);
            this.Status_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(79, 25);
            this.Status_Label.TabIndex = 0;
            this.Status_Label.Text = "Status:";
            // 
            // Status_txt
            // 
            this.Status_txt.AutoSize = true;
            this.Status_txt.Location = new System.Drawing.Point(1464, 9);
            this.Status_txt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Status_txt.Name = "Status_txt";
            this.Status_txt.Size = new System.Drawing.Size(121, 25);
            this.Status_txt.TabIndex = 1;
            this.Status_txt.Text = "Status Text";
            // 
            // Status_Timer
            // 
            this.Status_Timer.Tick += new System.EventHandler(this.Status_Update);
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(12, 12);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(113, 41);
            this.Connect_Button.TabIndex = 2;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_onClick);
            // 
            // Port_box
            // 
            this.Port_box.FormattingEnabled = true;
            this.Port_box.Location = new System.Drawing.Point(224, 12);
            this.Port_box.Name = "Port_box";
            this.Port_box.Size = new System.Drawing.Size(121, 33);
            this.Port_box.TabIndex = 3;
            // 
            // Baud_Rate_box
            // 
            this.Baud_Rate_box.FormattingEnabled = true;
            this.Baud_Rate_box.Items.AddRange(new object[] {
            "110 ",
            "300 ",
            "600 ",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200 ",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.Baud_Rate_box.Location = new System.Drawing.Point(488, 12);
            this.Baud_Rate_box.Name = "Baud_Rate_box";
            this.Baud_Rate_box.Size = new System.Drawing.Size(121, 33);
            this.Baud_Rate_box.TabIndex = 4;
            // 
            // Port_label
            // 
            this.Port_label.AutoSize = true;
            this.Port_label.Location = new System.Drawing.Point(161, 20);
            this.Port_label.Name = "Port_label";
            this.Port_label.Size = new System.Drawing.Size(57, 25);
            this.Port_label.TabIndex = 5;
            this.Port_label.Text = "Port:";
            // 
            // Baud_Rate_label
            // 
            this.Baud_Rate_label.AutoSize = true;
            this.Baud_Rate_label.Location = new System.Drawing.Point(363, 20);
            this.Baud_Rate_label.Name = "Baud_Rate_label";
            this.Baud_Rate_label.Size = new System.Drawing.Size(119, 25);
            this.Baud_Rate_label.TabIndex = 6;
            this.Baud_Rate_label.Text = "Baud Rate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 873);
            this.Controls.Add(this.Baud_Rate_label);
            this.Controls.Add(this.Port_label);
            this.Controls.Add(this.Baud_Rate_box);
            this.Controls.Add(this.Port_box);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.Status_txt);
            this.Controls.Add(this.Status_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.ComboBox Port_box;
        private System.Windows.Forms.ComboBox Baud_Rate_box;
        private System.Windows.Forms.Label Port_label;
        private System.Windows.Forms.Label Baud_Rate_label;
    }
}

