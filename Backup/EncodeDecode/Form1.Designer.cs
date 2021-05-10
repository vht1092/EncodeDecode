namespace EncodeDecode
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
            this.btnEncode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(125, 85);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 0;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "String1";
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(125, 48);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(674, 20);
            this.txtString1.TabIndex = 2;
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(125, 125);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(674, 20);
            this.txtString2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "String 2";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(247, 85);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(125, 12);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 162);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncode);
            this.Name = "Form1";
            this.Text = "Encode_Decode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
    }
}

