namespace myForm
{
    partial class add
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
            this.pbCancel = new System.Windows.Forms.Button();
            this.pbOk = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbCancel
            // 
            this.pbCancel.Location = new System.Drawing.Point(145, 44);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(75, 23);
            this.pbCancel.TabIndex = 7;
            this.pbCancel.Text = "Cancel";
            this.pbCancel.UseVisualStyleBackColor = true;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // pbOk
            // 
            this.pbOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pbOk.Location = new System.Drawing.Point(64, 44);
            this.pbOk.Name = "pbOk";
            this.pbOk.Size = new System.Drawing.Size(75, 23);
            this.pbOk.TabIndex = 6;
            this.pbOk.Text = "OK";
            this.pbOk.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(93, 8);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(159, 20);
            this.textBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "enter name";
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 87);
            this.Controls.Add(this.pbCancel);
            this.Controls.Add(this.pbOk);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Name = "add";
            this.Text = "add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pbCancel;
        private System.Windows.Forms.Button pbOk;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
    }
}