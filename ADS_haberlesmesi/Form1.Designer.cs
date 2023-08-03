
namespace ADSCommunication
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
            this.btnConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFloatValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.txtEnabled = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentWrite = new System.Windows.Forms.TextBox();
            this.btnCurrentWrite = new System.Windows.Forms.Button();
            this.txtVoltageWrite = new System.Windows.Forms.TextBox();
            this.btnVoltageWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnection.Location = new System.Drawing.Point(72, 196);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(179, 64);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "CONNECTION";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "fValue";

            // 
            // txtFloatValue
            // 
            this.txtFloatValue.Location = new System.Drawing.Point(295, 114);
            this.txtFloatValue.Multiline = true;
            this.txtFloatValue.Name = "txtFloatValue";
            this.txtFloatValue.Size = new System.Drawing.Size(125, 32);
            this.txtFloatValue.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "DIJITAL";

            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(95, 56);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(67, 32);
            this.btnEnable.TabIndex = 6;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(188, 56);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(67, 32);
            this.btnDisable.TabIndex = 7;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // txtEnabled
            // 
            this.txtEnabled.Location = new System.Drawing.Point(295, 56);
            this.txtEnabled.Multiline = true;
            this.txtEnabled.Name = "txtEnabled";
            this.txtEnabled.Size = new System.Drawing.Size(125, 32);
            this.txtEnabled.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "ANALOG";
            // 
            // txtCurrentWrite
            // 
            this.txtCurrentWrite.Location = new System.Drawing.Point(248, 42);
            this.txtCurrentWrite.Multiline = true;
            this.txtCurrentWrite.Name = "txtCurrentWrite";
            this.txtCurrentWrite.Size = new System.Drawing.Size(125, 32);
            this.txtCurrentWrite.TabIndex = 11;
            // 
            // btnCurrentWrite
            // 
            this.btnCurrentWrite.Location = new System.Drawing.Point(94, 42);
            this.btnCurrentWrite.Name = "btnCurrentWrite";
            this.btnCurrentWrite.Size = new System.Drawing.Size(114, 32);
            this.btnCurrentWrite.TabIndex = 10;
            this.btnCurrentWrite.Text = "Current Write";
            this.btnCurrentWrite.UseVisualStyleBackColor = true;
            this.btnCurrentWrite.Click += new System.EventHandler(this.btnCurrentWrite_Click);
            // 
            // txtVoltageWrite
            // 
            this.txtVoltageWrite.Location = new System.Drawing.Point(248, 104);
            this.txtVoltageWrite.Multiline = true;
            this.txtVoltageWrite.Name = "txtVoltageWrite";
            this.txtVoltageWrite.Size = new System.Drawing.Size(125, 32);
            this.txtVoltageWrite.TabIndex = 13;
            // 
            // btnVoltageWrite
            // 
            this.btnVoltageWrite.Location = new System.Drawing.Point(94, 104);
            this.btnVoltageWrite.Name = "btnVoltageWrite";
            this.btnVoltageWrite.Size = new System.Drawing.Size(114, 32);
            this.btnVoltageWrite.TabIndex = 12;
            this.btnVoltageWrite.Text = "Voltage Write";
            this.btnVoltageWrite.UseVisualStyleBackColor = true;
            this.btnVoltageWrite.Click += new System.EventHandler(this.btnVoltageWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(95, 117);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(67, 32);
            this.btnRead.TabIndex = 14;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(188, 117);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(67, 32);
            this.btnWrite.TabIndex = 15;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWrite);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.txtEnabled);
            this.groupBox1.Controls.Add(this.btnDisable);
            this.groupBox1.Controls.Add(this.btnEnable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFloatValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(292, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 181);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DIJITAL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVoltageWrite);
            this.groupBox2.Controls.Add(this.btnVoltageWrite);
            this.groupBox2.Controls.Add(this.txtCurrentWrite);
            this.groupBox2.Controls.Add(this.btnCurrentWrite);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(292, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 184);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ANALOG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 543);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConnection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFloatValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.TextBox txtEnabled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentWrite;
        private System.Windows.Forms.Button btnCurrentWrite;
        private System.Windows.Forms.TextBox txtVoltageWrite;
        private System.Windows.Forms.Button btnVoltageWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}