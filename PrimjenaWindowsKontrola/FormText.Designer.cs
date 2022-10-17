namespace PrimjenaWindowsKontrola
{
    partial class FormText
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTdescription = new System.Windows.Forms.TextBox();
            this.TXTname = new System.Windows.Forms.TextBox();
            this.BTNok = new System.Windows.Forms.Button();
            this.BTNcancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program description:";
            // 
            // TXTdescription
            // 
            this.TXTdescription.Location = new System.Drawing.Point(121, 79);
            this.TXTdescription.Multiline = true;
            this.TXTdescription.Name = "TXTdescription";
            this.TXTdescription.Size = new System.Drawing.Size(207, 104);
            this.TXTdescription.TabIndex = 2;
            // 
            // TXTname
            // 
            this.TXTname.Location = new System.Drawing.Point(121, 13);
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(207, 20);
            this.TXTname.TabIndex = 3;
            // 
            // BTNok
            // 
            this.BTNok.Location = new System.Drawing.Point(13, 203);
            this.BTNok.Name = "BTNok";
            this.BTNok.Size = new System.Drawing.Size(75, 23);
            this.BTNok.TabIndex = 4;
            this.BTNok.Text = "OK";
            this.BTNok.UseVisualStyleBackColor = true;
            this.BTNok.Click += new System.EventHandler(this.BTNok_Click);
            // 
            // BTNcancel
            // 
            this.BTNcancel.Location = new System.Drawing.Point(253, 203);
            this.BTNcancel.Name = "BTNcancel";
            this.BTNcancel.Size = new System.Drawing.Size(75, 23);
            this.BTNcancel.TabIndex = 5;
            this.BTNcancel.Text = "Cancel";
            this.BTNcancel.UseVisualStyleBackColor = true;
            // 
            // FormText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 238);
            this.Controls.Add(this.BTNcancel);
            this.Controls.Add(this.BTNok);
            this.Controls.Add(this.TXTname);
            this.Controls.Add(this.TXTdescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormText";
            this.Text = "FormText";
            this.Load += new System.EventHandler(this.FormText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTdescription;
        private System.Windows.Forms.TextBox TXTname;
        private System.Windows.Forms.Button BTNok;
        private System.Windows.Forms.Button BTNcancel;
    }
}