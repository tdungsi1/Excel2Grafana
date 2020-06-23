namespace WindowsFormsApp1
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
            this.btinput = new System.Windows.Forms.Button();
            this.btupload = new System.Windows.Forms.Button();
            this.btjson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btinput
            // 
            this.btinput.Location = new System.Drawing.Point(12, 12);
            this.btinput.Name = "btinput";
            this.btinput.Size = new System.Drawing.Size(108, 34);
            this.btinput.TabIndex = 0;
            this.btinput.Text = "Input excel file";
            this.btinput.UseVisualStyleBackColor = true;
            this.btinput.Click += new System.EventHandler(this.btinput_Click);
            // 
            // btupload
            // 
            this.btupload.Location = new System.Drawing.Point(68, 52);
            this.btupload.Name = "btupload";
            this.btupload.Size = new System.Drawing.Size(108, 32);
            this.btupload.TabIndex = 1;
            this.btupload.Text = "Upload to Grafana";
            this.btupload.UseVisualStyleBackColor = true;
            // 
            // btjson
            // 
            this.btjson.Location = new System.Drawing.Point(126, 14);
            this.btjson.Name = "btjson";
            this.btjson.Size = new System.Drawing.Size(108, 32);
            this.btjson.TabIndex = 2;
            this.btjson.Text = "Generate json";
            this.btjson.UseVisualStyleBackColor = true;
            this.btjson.Click += new System.EventHandler(this.btjson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note: The current version of this software ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "only support the excel format in this button";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(182, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 27);
            this.button4.TabIndex = 5;
            this.button4.Text = "Format";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 150);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btjson);
            this.Controls.Add(this.btupload);
            this.Controls.Add(this.btinput);
            this.Name = "Form1";
            this.Text = "Excel to Grafana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btinput;
        private System.Windows.Forms.Button btupload;
        private System.Windows.Forms.Button btjson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}

