namespace WindowsFormsApp3
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
            this.TITLELABLE = new System.Windows.Forms.Label();
            this.INFOGROUPBOX = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.outputlabel = new System.Windows.Forms.Label();
            this.INFOGROUPBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // TITLELABLE
            // 
            this.TITLELABLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLELABLE.Location = new System.Drawing.Point(-2, 26);
            this.TITLELABLE.Name = "TITLELABLE";
            this.TITLELABLE.Size = new System.Drawing.Size(99, 46);
            this.TITLELABLE.TabIndex = 0;
            this.TITLELABLE.Text = "LAB08";
            this.TITLELABLE.Click += new System.EventHandler(this.label1_Click);
            // 
            // INFOGROUPBOX
            // 
            this.INFOGROUPBOX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.INFOGROUPBOX.Controls.Add(this.label2);
            this.INFOGROUPBOX.Controls.Add(this.textBox1);
            this.INFOGROUPBOX.Controls.Add(this.label1);
            this.INFOGROUPBOX.Controls.Add(this.NAME);
            this.INFOGROUPBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INFOGROUPBOX.Location = new System.Drawing.Point(1, 92);
            this.INFOGROUPBOX.Name = "INFOGROUPBOX";
            this.INFOGROUPBOX.Size = new System.Drawing.Size(705, 230);
            this.INFOGROUPBOX.TabIndex = 1;
            this.INFOGROUPBOX.TabStop = false;
            this.INFOGROUPBOX.Text = "INFO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "AGE :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(269, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "ENTER NAME :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // NAME
            // 
            this.NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(269, 20);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(258, 38);
            this.NAME.TabIndex = 1;
            this.NAME.TextChanged += new System.EventHandler(this.NAME_TextChanged);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(630, 388);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(150, 50);
            this.submit.TabIndex = 3;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // outputlabel
            // 
            this.outputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlabel.Location = new System.Drawing.Point(33, 388);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(591, 48);
            this.outputlabel.TabIndex = 6;
            this.outputlabel.Click += new System.EventHandler(this.outputlabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.INFOGROUPBOX);
            this.Controls.Add(this.TITLELABLE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.INFOGROUPBOX.ResumeLayout(false);
            this.INFOGROUPBOX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TITLELABLE;
        private System.Windows.Forms.GroupBox INFOGROUPBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label outputlabel;
    }
}

