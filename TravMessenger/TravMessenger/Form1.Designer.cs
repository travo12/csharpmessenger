namespace TravMessenger
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
            this.This_Computer = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Box_Local_Port = new System.Windows.Forms.TextBox();
            this.Text_Box_Local_IP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_Box_Remote_Port = new System.Windows.Forms.TextBox();
            this.Text_Box_Remote_IP = new System.Windows.Forms.TextBox();
            this.Text_Box_Msg_Input = new System.Windows.Forms.TextBox();
            this.Chat_Window = new System.Windows.Forms.ListBox();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.Send_Button = new System.Windows.Forms.Button();
            this.This_Computer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // This_Computer
            // 
            this.This_Computer.Controls.Add(this.label2);
            this.This_Computer.Controls.Add(this.label1);
            this.This_Computer.Controls.Add(this.Text_Box_Local_Port);
            this.This_Computer.Controls.Add(this.Text_Box_Local_IP);
            this.This_Computer.Location = new System.Drawing.Point(40, 33);
            this.This_Computer.Name = "This_Computer";
            this.This_Computer.Size = new System.Drawing.Size(250, 158);
            this.This_Computer.TabIndex = 0;
            this.This_Computer.TabStop = false;
            this.This_Computer.Text = "This Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // Text_Box_Local_Port
            // 
            this.Text_Box_Local_Port.Location = new System.Drawing.Point(51, 95);
            this.Text_Box_Local_Port.Name = "Text_Box_Local_Port";
            this.Text_Box_Local_Port.Size = new System.Drawing.Size(127, 20);
            this.Text_Box_Local_Port.TabIndex = 1;
            // 
            // Text_Box_Local_IP
            // 
            this.Text_Box_Local_IP.Location = new System.Drawing.Point(51, 35);
            this.Text_Box_Local_IP.Name = "Text_Box_Local_IP";
            this.Text_Box_Local_IP.Size = new System.Drawing.Size(127, 20);
            this.Text_Box_Local_IP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Text_Box_Remote_Port);
            this.groupBox2.Controls.Add(this.Text_Box_Remote_IP);
            this.groupBox2.Location = new System.Drawing.Point(314, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Computer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP";
            // 
            // Text_Box_Remote_Port
            // 
            this.Text_Box_Remote_Port.Location = new System.Drawing.Point(42, 102);
            this.Text_Box_Remote_Port.Name = "Text_Box_Remote_Port";
            this.Text_Box_Remote_Port.Size = new System.Drawing.Size(127, 20);
            this.Text_Box_Remote_Port.TabIndex = 2;
            // 
            // Text_Box_Remote_IP
            // 
            this.Text_Box_Remote_IP.Location = new System.Drawing.Point(42, 37);
            this.Text_Box_Remote_IP.Name = "Text_Box_Remote_IP";
            this.Text_Box_Remote_IP.Size = new System.Drawing.Size(127, 20);
            this.Text_Box_Remote_IP.TabIndex = 1;
            // 
            // Text_Box_Msg_Input
            // 
            this.Text_Box_Msg_Input.Location = new System.Drawing.Point(40, 449);
            this.Text_Box_Msg_Input.Name = "Text_Box_Msg_Input";
            this.Text_Box_Msg_Input.Size = new System.Drawing.Size(523, 20);
            this.Text_Box_Msg_Input.TabIndex = 2;
            this.Text_Box_Msg_Input.TextChanged += new System.EventHandler(this.Text_Box_Msg_Input_TextChanged);
            // 
            // Chat_Window
            // 
            this.Chat_Window.FormattingEnabled = true;
            this.Chat_Window.Location = new System.Drawing.Point(43, 210);
            this.Chat_Window.Name = "Chat_Window";
            this.Chat_Window.Size = new System.Drawing.Size(642, 199);
            this.Chat_Window.TabIndex = 3;
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(588, 90);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(98, 29);
            this.Connect_Button.TabIndex = 4;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(586, 442);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(99, 27);
            this.Send_Button.TabIndex = 5;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 494);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.Chat_Window);
            this.Controls.Add(this.Text_Box_Msg_Input);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.This_Computer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.This_Computer.ResumeLayout(false);
            this.This_Computer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox This_Computer;
        private System.Windows.Forms.TextBox Text_Box_Local_Port;
        private System.Windows.Forms.TextBox Text_Box_Local_IP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Text_Box_Remote_Port;
        private System.Windows.Forms.TextBox Text_Box_Remote_IP;
        private System.Windows.Forms.TextBox Text_Box_Msg_Input;
        private System.Windows.Forms.ListBox Chat_Window;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Send_Button;
    }
}

