
namespace Serial_Communication
{
    partial class Form2
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
            this.PortName_ComBox = new System.Windows.Forms.ComboBox();
            this.Com_Btn = new System.Windows.Forms.Button();
            this.BaudRate_ComBox = new System.Windows.Forms.ComboBox();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.DataBit_ComBox = new System.Windows.Forms.ComboBox();
            this.StopBit_ComBox = new System.Windows.Forms.ComboBox();
            this.BoudRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Parity_ComBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PortName_ComBox
            // 
            this.PortName_ComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortName_ComBox.FormattingEnabled = true;
            this.PortName_ComBox.Location = new System.Drawing.Point(135, 28);
            this.PortName_ComBox.Name = "PortName_ComBox";
            this.PortName_ComBox.Size = new System.Drawing.Size(121, 20);
            this.PortName_ComBox.TabIndex = 0;
            // 
            // Com_Btn
            // 
            this.Com_Btn.Location = new System.Drawing.Point(153, 176);
            this.Com_Btn.Name = "Com_Btn";
            this.Com_Btn.Size = new System.Drawing.Size(103, 46);
            this.Com_Btn.TabIndex = 1;
            this.Com_Btn.Text = "적용하기";
            this.Com_Btn.UseVisualStyleBackColor = true;
            this.Com_Btn.Click += new System.EventHandler(this.Com_Btn_Click);
            // 
            // BaudRate_ComBox
            // 
            this.BaudRate_ComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRate_ComBox.FormattingEnabled = true;
            this.BaudRate_ComBox.Location = new System.Drawing.Point(135, 54);
            this.BaudRate_ComBox.Name = "BaudRate_ComBox";
            this.BaudRate_ComBox.Size = new System.Drawing.Size(121, 20);
            this.BaudRate_ComBox.TabIndex = 2;
            // 
            // Search_Btn
            // 
            this.Search_Btn.Location = new System.Drawing.Point(17, 178);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(103, 42);
            this.Search_Btn.TabIndex = 3;
            this.Search_Btn.Text = "포트조회";
            this.Search_Btn.UseVisualStyleBackColor = true;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // DataBit_ComBox
            // 
            this.DataBit_ComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBit_ComBox.FormattingEnabled = true;
            this.DataBit_ComBox.Items.AddRange(new object[] {
            "7",
            "8"});
            this.DataBit_ComBox.Location = new System.Drawing.Point(135, 80);
            this.DataBit_ComBox.Name = "DataBit_ComBox";
            this.DataBit_ComBox.Size = new System.Drawing.Size(121, 20);
            this.DataBit_ComBox.TabIndex = 4;
            // 
            // StopBit_ComBox
            // 
            this.StopBit_ComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBit_ComBox.FormattingEnabled = true;
            this.StopBit_ComBox.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.StopBit_ComBox.Location = new System.Drawing.Point(135, 106);
            this.StopBit_ComBox.Name = "StopBit_ComBox";
            this.StopBit_ComBox.Size = new System.Drawing.Size(121, 20);
            this.StopBit_ComBox.TabIndex = 5;
            // 
            // BoudRate
            // 
            this.BoudRate.AutoSize = true;
            this.BoudRate.Location = new System.Drawing.Point(13, 54);
            this.BoudRate.Name = "BoudRate";
            this.BoudRate.Size = new System.Drawing.Size(59, 12);
            this.BoudRate.TabIndex = 6;
            this.BoudRate.Text = "BoudRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "StopBit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "DataBit";
            // 
            // Parity_ComBox
            // 
            this.Parity_ComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Parity_ComBox.FormattingEnabled = true;
            this.Parity_ComBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.Parity_ComBox.Location = new System.Drawing.Point(135, 133);
            this.Parity_ComBox.Name = "Parity_ComBox";
            this.Parity_ComBox.Size = new System.Drawing.Size(121, 20);
            this.Parity_ComBox.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 227);
            this.Controls.Add(this.Parity_ComBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoudRate);
            this.Controls.Add(this.StopBit_ComBox);
            this.Controls.Add(this.DataBit_ComBox);
            this.Controls.Add(this.Search_Btn);
            this.Controls.Add(this.BaudRate_ComBox);
            this.Controls.Add(this.Com_Btn);
            this.Controls.Add(this.PortName_ComBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortName_ComBox;
        private System.Windows.Forms.Button Com_Btn;
        private System.Windows.Forms.ComboBox BaudRate_ComBox;
        private System.Windows.Forms.Button Search_Btn;
        private System.Windows.Forms.ComboBox DataBit_ComBox;
        private System.Windows.Forms.ComboBox StopBit_ComBox;
        private System.Windows.Forms.Label BoudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Parity_ComBox;
    }
}