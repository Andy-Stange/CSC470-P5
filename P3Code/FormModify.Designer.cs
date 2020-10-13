namespace P3Code
{
    partial class FormModify
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ModifyCancel = new System.Windows.Forms.Button();
            this.ModifyAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ModifyCancel
            // 
            this.ModifyCancel.Location = new System.Drawing.Point(159, 114);
            this.ModifyCancel.Name = "ModifyCancel";
            this.ModifyCancel.Size = new System.Drawing.Size(75, 23);
            this.ModifyCancel.TabIndex = 2;
            this.ModifyCancel.Text = "Cancel";
            this.ModifyCancel.UseVisualStyleBackColor = true;
            // 
            // ModifyAccept
            // 
            this.ModifyAccept.Location = new System.Drawing.Point(275, 114);
            this.ModifyAccept.Name = "ModifyAccept";
            this.ModifyAccept.Size = new System.Drawing.Size(75, 23);
            this.ModifyAccept.TabIndex = 3;
            this.ModifyAccept.Text = "Modify";
            this.ModifyAccept.UseVisualStyleBackColor = true;
            // 
            // FormModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 173);
            this.Controls.Add(this.ModifyAccept);
            this.Controls.Add(this.ModifyCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ModifyCancel;
        private System.Windows.Forms.Button ModifyAccept;
    }
}