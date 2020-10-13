namespace P3Code
{
    partial class FormRemove
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
            this.RemoveCancel = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project to remove:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PlaceholderLabel";
            // 
            // RemoveCancel
            // 
            this.RemoveCancel.Location = new System.Drawing.Point(189, 130);
            this.RemoveCancel.Name = "RemoveCancel";
            this.RemoveCancel.Size = new System.Drawing.Size(75, 23);
            this.RemoveCancel.TabIndex = 2;
            this.RemoveCancel.Text = "Cancel";
            this.RemoveCancel.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(343, 130);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(108, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove Project";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // FormRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 192);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.RemoveCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRemove";
            this.Text = "Remove Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveCancel;
        private System.Windows.Forms.Button RemoveButton;
    }
}