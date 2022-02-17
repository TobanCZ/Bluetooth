
namespace Bluethooth_Module_App
{
    partial class Bluetooth_configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bluetooth_configuration));
            this.Module_Status_text = new System.Windows.Forms.Label();
            this.Module_Status = new System.Windows.Forms.Label();
            this.Status_Timer = new System.Windows.Forms.Timer(this.components);
            this.Connect_Button = new System.Windows.Forms.Button();
            this.Port_box = new System.Windows.Forms.ComboBox();
            this.Baud_Rate_select_box = new System.Windows.Forms.ComboBox();
            this.Port_label = new System.Windows.Forms.Label();
            this.Baud_Rate_label = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Status_text = new System.Windows.Forms.Label();
            this.Name_text = new System.Windows.Forms.Label();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.Change_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.Password_text = new System.Windows.Forms.Label();
            this.Baud_Rate_text = new System.Windows.Forms.Label();
            this.Baud_Rate_box = new System.Windows.Forms.ComboBox();
            this.Module_Adress = new System.Windows.Forms.Label();
            this.Module_Adress_text = new System.Windows.Forms.Label();
            this.Module_Version = new System.Windows.Forms.Label();
            this.Module_Version_tetx = new System.Windows.Forms.Label();
            this.Baud_Rate_restart_text = new System.Windows.Forms.Label();
            this.FC_Reset_Button = new System.Windows.Forms.Button();
            this.Role_box = new System.Windows.Forms.ComboBox();
            this.Role_text = new System.Windows.Forms.Label();
            this.Role_Reset_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Module_Status_text
            // 
            this.Module_Status_text.AutoSize = true;
            this.Module_Status_text.Location = new System.Drawing.Point(446, 34);
            this.Module_Status_text.Name = "Module_Status_text";
            this.Module_Status_text.Size = new System.Drawing.Size(78, 13);
            this.Module_Status_text.TabIndex = 0;
            this.Module_Status_text.Text = "Module Status:";
            // 
            // Module_Status
            // 
            this.Module_Status.AutoSize = true;
            this.Module_Status.Location = new System.Drawing.Point(530, 34);
            this.Module_Status.Name = "Module_Status";
            this.Module_Status.Size = new System.Drawing.Size(61, 13);
            this.Module_Status.TabIndex = 1;
            this.Module_Status.Text = "Status Text";
            // 
            // Status_Timer
            // 
            this.Status_Timer.Interval = 1000;
            this.Status_Timer.Tick += new System.EventHandler(this.Status_Update);
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(11, 11);
            this.Connect_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(76, 21);
            this.Connect_Button.TabIndex = 2;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_onClick);
            // 
            // Port_box
            // 
            this.Port_box.FormattingEnabled = true;
            this.Port_box.Location = new System.Drawing.Point(132, 11);
            this.Port_box.Margin = new System.Windows.Forms.Padding(2);
            this.Port_box.Name = "Port_box";
            this.Port_box.Size = new System.Drawing.Size(62, 21);
            this.Port_box.TabIndex = 3;
            // 
            // Baud_Rate_select_box
            // 
            this.Baud_Rate_select_box.FormattingEnabled = true;
            this.Baud_Rate_select_box.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.Baud_Rate_select_box.Location = new System.Drawing.Point(264, 11);
            this.Baud_Rate_select_box.Margin = new System.Windows.Forms.Padding(2);
            this.Baud_Rate_select_box.Name = "Baud_Rate_select_box";
            this.Baud_Rate_select_box.Size = new System.Drawing.Size(62, 21);
            this.Baud_Rate_select_box.TabIndex = 4;
            // 
            // Port_label
            // 
            this.Port_label.AutoSize = true;
            this.Port_label.Location = new System.Drawing.Point(100, 15);
            this.Port_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Port_label.Name = "Port_label";
            this.Port_label.Size = new System.Drawing.Size(29, 13);
            this.Port_label.TabIndex = 5;
            this.Port_label.Text = "Port:";
            // 
            // Baud_Rate_label
            // 
            this.Baud_Rate_label.AutoSize = true;
            this.Baud_Rate_label.Location = new System.Drawing.Point(202, 15);
            this.Baud_Rate_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Baud_Rate_label.Name = "Baud_Rate_label";
            this.Baud_Rate_label.Size = new System.Drawing.Size(61, 13);
            this.Baud_Rate_label.TabIndex = 6;
            this.Baud_Rate_label.Text = "Baud Rate:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(530, 9);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(61, 13);
            this.Status.TabIndex = 7;
            this.Status.Text = "Status Text";
            // 
            // Status_text
            // 
            this.Status_text.AutoSize = true;
            this.Status_text.Location = new System.Drawing.Point(484, 9);
            this.Status_text.Name = "Status_text";
            this.Status_text.Size = new System.Drawing.Size(40, 13);
            this.Status_text.TabIndex = 8;
            this.Status_text.Text = "Status:";
            // 
            // Name_text
            // 
            this.Name_text.AutoSize = true;
            this.Name_text.Location = new System.Drawing.Point(31, 82);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(38, 13);
            this.Name_text.TabIndex = 9;
            this.Name_text.Text = "Name:";
            // 
            // Name_box
            // 
            this.Name_box.Location = new System.Drawing.Point(75, 79);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(100, 20);
            this.Name_box.TabIndex = 10;
            // 
            // Change_Button
            // 
            this.Change_Button.Location = new System.Drawing.Point(435, 269);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(75, 23);
            this.Change_Button.TabIndex = 11;
            this.Change_Button.Text = "Change";
            this.Change_Button.UseVisualStyleBackColor = true;
            this.Change_Button.Click += new System.EventHandler(this.Change_onClick);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(516, 269);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(75, 23);
            this.Reset_Button.TabIndex = 12;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_onClick);
            // 
            // Password_box
            // 
            this.Password_box.Location = new System.Drawing.Point(75, 115);
            this.Password_box.Name = "Password_box";
            this.Password_box.Size = new System.Drawing.Size(100, 20);
            this.Password_box.TabIndex = 14;
            // 
            // Password_text
            // 
            this.Password_text.AutoSize = true;
            this.Password_text.Location = new System.Drawing.Point(13, 118);
            this.Password_text.Name = "Password_text";
            this.Password_text.Size = new System.Drawing.Size(56, 13);
            this.Password_text.TabIndex = 13;
            this.Password_text.Text = "Password:";
            // 
            // Baud_Rate_text
            // 
            this.Baud_Rate_text.AutoSize = true;
            this.Baud_Rate_text.Location = new System.Drawing.Point(8, 154);
            this.Baud_Rate_text.Name = "Baud_Rate_text";
            this.Baud_Rate_text.Size = new System.Drawing.Size(61, 13);
            this.Baud_Rate_text.TabIndex = 15;
            this.Baud_Rate_text.Text = "Baud Rate:";
            // 
            // Baud_Rate_box
            // 
            this.Baud_Rate_box.FormattingEnabled = true;
            this.Baud_Rate_box.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.Baud_Rate_box.Location = new System.Drawing.Point(75, 151);
            this.Baud_Rate_box.Margin = new System.Windows.Forms.Padding(2);
            this.Baud_Rate_box.Name = "Baud_Rate_box";
            this.Baud_Rate_box.Size = new System.Drawing.Size(100, 21);
            this.Baud_Rate_box.TabIndex = 17;
            // 
            // Module_Adress
            // 
            this.Module_Adress.AutoSize = true;
            this.Module_Adress.Location = new System.Drawing.Point(518, 58);
            this.Module_Adress.Name = "Module_Adress";
            this.Module_Adress.Size = new System.Drawing.Size(63, 13);
            this.Module_Adress.TabIndex = 19;
            this.Module_Adress.Text = "Adress Text";
            // 
            // Module_Adress_text
            // 
            this.Module_Adress_text.AutoSize = true;
            this.Module_Adress_text.Location = new System.Drawing.Point(432, 58);
            this.Module_Adress_text.Name = "Module_Adress_text";
            this.Module_Adress_text.Size = new System.Drawing.Size(80, 13);
            this.Module_Adress_text.TabIndex = 18;
            this.Module_Adress_text.Text = "Module Adress:";
            // 
            // Module_Version
            // 
            this.Module_Version.AutoSize = true;
            this.Module_Version.Location = new System.Drawing.Point(525, 82);
            this.Module_Version.Name = "Module_Version";
            this.Module_Version.Size = new System.Drawing.Size(66, 13);
            this.Module_Version.TabIndex = 21;
            this.Module_Version.Text = "Version Text";
            // 
            // Module_Version_tetx
            // 
            this.Module_Version_tetx.AutoSize = true;
            this.Module_Version_tetx.Location = new System.Drawing.Point(436, 82);
            this.Module_Version_tetx.Name = "Module_Version_tetx";
            this.Module_Version_tetx.Size = new System.Drawing.Size(83, 13);
            this.Module_Version_tetx.TabIndex = 20;
            this.Module_Version_tetx.Text = "Module Version:";
            // 
            // Baud_Rate_restart_text
            // 
            this.Baud_Rate_restart_text.AutoSize = true;
            this.Baud_Rate_restart_text.Location = new System.Drawing.Point(179, 154);
            this.Baud_Rate_restart_text.Name = "Baud_Rate_restart_text";
            this.Baud_Rate_restart_text.Size = new System.Drawing.Size(85, 13);
            this.Baud_Rate_restart_text.TabIndex = 22;
            this.Baud_Rate_restart_text.Text = "Restart required!";
            // 
            // FC_Reset_Button
            // 
            this.FC_Reset_Button.Location = new System.Drawing.Point(11, 266);
            this.FC_Reset_Button.Name = "FC_Reset_Button";
            this.FC_Reset_Button.Size = new System.Drawing.Size(75, 23);
            this.FC_Reset_Button.TabIndex = 23;
            this.FC_Reset_Button.Text = "FC Reset";
            this.FC_Reset_Button.UseVisualStyleBackColor = true;
            this.FC_Reset_Button.Click += new System.EventHandler(this.FC_Reset_onClick);
            // 
            // Role_box
            // 
            this.Role_box.FormattingEnabled = true;
            this.Role_box.Items.AddRange(new object[] {
            "Slave",
            "Master",
            "Slave-Loop"});
            this.Role_box.Location = new System.Drawing.Point(75, 188);
            this.Role_box.Margin = new System.Windows.Forms.Padding(2);
            this.Role_box.Name = "Role_box";
            this.Role_box.Size = new System.Drawing.Size(100, 21);
            this.Role_box.TabIndex = 25;
            // 
            // Role_text
            // 
            this.Role_text.AutoSize = true;
            this.Role_text.Location = new System.Drawing.Point(37, 191);
            this.Role_text.Name = "Role_text";
            this.Role_text.Size = new System.Drawing.Size(32, 13);
            this.Role_text.TabIndex = 24;
            this.Role_text.Text = "Role:";
            // 
            // Role_Reset_text
            // 
            this.Role_Reset_text.AutoSize = true;
            this.Role_Reset_text.Location = new System.Drawing.Point(180, 191);
            this.Role_Reset_text.Name = "Role_Reset_text";
            this.Role_Reset_text.Size = new System.Drawing.Size(85, 13);
            this.Role_Reset_text.TabIndex = 26;
            this.Role_Reset_text.Text = "Restart required!";
            // 
            // Bluetooth_configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(605, 303);
            this.Controls.Add(this.Role_Reset_text);
            this.Controls.Add(this.Role_box);
            this.Controls.Add(this.Role_text);
            this.Controls.Add(this.FC_Reset_Button);
            this.Controls.Add(this.Baud_Rate_restart_text);
            this.Controls.Add(this.Module_Version);
            this.Controls.Add(this.Module_Version_tetx);
            this.Controls.Add(this.Module_Adress);
            this.Controls.Add(this.Module_Adress_text);
            this.Controls.Add(this.Baud_Rate_box);
            this.Controls.Add(this.Baud_Rate_text);
            this.Controls.Add(this.Password_box);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Change_Button);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.Status_text);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Baud_Rate_label);
            this.Controls.Add(this.Port_label);
            this.Controls.Add(this.Baud_Rate_select_box);
            this.Controls.Add(this.Port_box);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.Module_Status);
            this.Controls.Add(this.Module_Status_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bluetooth_configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bluethooth Module Conguration";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Module_Status_text;
        private System.Windows.Forms.Label Module_Status;
        private System.Windows.Forms.Timer Status_Timer;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.ComboBox Port_box;
        private System.Windows.Forms.ComboBox Baud_Rate_select_box;
        private System.Windows.Forms.Label Port_label;
        private System.Windows.Forms.Label Baud_Rate_label;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Status_text;
        private System.Windows.Forms.Label Name_text;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.Label Password_text;
        private System.Windows.Forms.Label Baud_Rate_text;
        private System.Windows.Forms.ComboBox Baud_Rate_box;
        private System.Windows.Forms.Label Module_Adress;
        private System.Windows.Forms.Label Module_Adress_text;
        private System.Windows.Forms.Label Module_Version;
        private System.Windows.Forms.Label Module_Version_tetx;
        private System.Windows.Forms.Label Baud_Rate_restart_text;
        private System.Windows.Forms.Button FC_Reset_Button;
        private System.Windows.Forms.ComboBox Role_box;
        private System.Windows.Forms.Label Role_text;
        private System.Windows.Forms.Label Role_Reset_text;
    }
}

