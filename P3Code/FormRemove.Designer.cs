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
            this.ProjectRemovalLabel = new System.Windows.Forms.Label();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.RemoveCancel = new System.Windows.Forms.Button();
            this.RemoveOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectRemovalLabel
            // 
            this.ProjectRemovalLabel.AutoSize = true;
            this.ProjectRemovalLabel.Location = new System.Drawing.Point(84, 87);
            this.ProjectRemovalLabel.Name = "ProjectRemovalLabel";
            this.ProjectRemovalLabel.Size = new System.Drawing.Size(93, 13);
            this.ProjectRemovalLabel.TabIndex = 0;
            this.ProjectRemovalLabel.Text = "Project to remove:";
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Location = new System.Drawing.Point(227, 87);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(99, 13);
            this.ProjectNameLabel.TabIndex = 1;
            this.ProjectNameLabel.Text = "Placeholder Project";
            // 
            // RemoveCancel
            // 
            this.RemoveCancel.Location = new System.Drawing.Point(172, 160);
            this.RemoveCancel.Name = "RemoveCancel";
            this.RemoveCancel.Size = new System.Drawing.Size(75, 23);
            this.RemoveCancel.TabIndex = 2;
            this.RemoveCancel.Text = "Cancel";
            this.RemoveCancel.UseVisualStyleBackColor = true;
            // 
            // RemoveOkay
            // 
            this.RemoveOkay.Location = new System.Drawing.Point(299, 160);
            this.RemoveOkay.Name = "RemoveOkay";
            this.RemoveOkay.Size = new System.Drawing.Size(110, 23);
            this.RemoveOkay.TabIndex = 3;
            this.RemoveOkay.Text = "Remove Project";
            this.RemoveOkay.UseVisualStyleBackColor = true;
            // 
            // FormRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 215);
            this.Controls.Add(this.RemoveOkay);
            this.Controls.Add(this.RemoveCancel);
            this.Controls.Add(this.ProjectNameLabel);
            this.Controls.Add(this.ProjectRemovalLabel);
            this.Name = "FormRemove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectRemovalLabel;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Button RemoveCancel;
        private System.Windows.Forms.Button RemoveOkay;
    }
}