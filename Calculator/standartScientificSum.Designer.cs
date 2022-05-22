namespace Calculator
{
    partial class standartScientificSum
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
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(98, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 251);
            this.listBox1.TabIndex = 8;
            // 
            // standartScientificSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.MaximumSize = new System.Drawing.Size(348, 399);
            this.MinimumSize = new System.Drawing.Size(348, 399);
            this.Name = "standartScientificSum";
            this.Text = "Standart / Bilimsel Özet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListBox listBox1;
    }
}