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
            this.ModifyLabel = new System.Windows.Forms.Label();
            this.ModifyTextBox = new System.Windows.Forms.TextBox();
            this.ModifyCancel = new System.Windows.Forms.Button();
            this.ModifyOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModifyLabel
            // 
            this.ModifyLabel.AutoSize = true;
            this.ModifyLabel.Location = new System.Drawing.Point(46, 80);
            this.ModifyLabel.Name = "ModifyLabel";
            this.ModifyLabel.Size = new System.Drawing.Size(74, 13);
            this.ModifyLabel.TabIndex = 0;
            this.ModifyLabel.Text = "Project Name:";
            // 
            // ModifyTextBox
            // 
            this.ModifyTextBox.Location = new System.Drawing.Point(153, 73);
            this.ModifyTextBox.Name = "ModifyTextBox";
            this.ModifyTextBox.Size = new System.Drawing.Size(286, 20);
            this.ModifyTextBox.TabIndex = 1;
            // 
            // ModifyCancel
            // 
            this.ModifyCancel.Location = new System.Drawing.Point(165, 142);
            this.ModifyCancel.Name = "ModifyCancel";
            this.ModifyCancel.Size = new System.Drawing.Size(75, 23);
            this.ModifyCancel.TabIndex = 2;
            this.ModifyCancel.Text = "Cancel";
            this.ModifyCancel.UseVisualStyleBackColor = true;
            // 
            // ModifyOkay
            // 
            this.ModifyOkay.Location = new System.Drawing.Point(300, 142);
            this.ModifyOkay.Name = "ModifyOkay";
            this.ModifyOkay.Size = new System.Drawing.Size(75, 23);
            this.ModifyOkay.TabIndex = 3;
            this.ModifyOkay.Text = "Modify";
            this.ModifyOkay.UseVisualStyleBackColor = true;
            // 
            // FormModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 196);
            this.Controls.Add(this.ModifyOkay);
            this.Controls.Add(this.ModifyCancel);
            this.Controls.Add(this.ModifyTextBox);
            this.Controls.Add(this.ModifyLabel);
            this.Name = "FormModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyLabel;
        private System.Windows.Forms.TextBox ModifyTextBox;
        private System.Windows.Forms.Button ModifyCancel;
        private System.Windows.Forms.Button ModifyOkay;
    }
}