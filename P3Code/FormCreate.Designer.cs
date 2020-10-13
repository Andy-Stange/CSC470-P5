namespace P3Code
{
    partial class FormCreate
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
            this.CreateLabel = new System.Windows.Forms.Label();
            this.CreateCancel = new System.Windows.Forms.Button();
            this.CreateAdd = new System.Windows.Forms.Button();
            this.CreateTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateLabel
            // 
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.Location = new System.Drawing.Point(67, 61);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(74, 13);
            this.CreateLabel.TabIndex = 0;
            this.CreateLabel.Text = "Project Name:";
            // 
            // CreateCancel
            // 
            this.CreateCancel.Location = new System.Drawing.Point(169, 102);
            this.CreateCancel.Name = "CreateCancel";
            this.CreateCancel.Size = new System.Drawing.Size(75, 23);
            this.CreateCancel.TabIndex = 1;
            this.CreateCancel.Text = "Cancel";
            this.CreateCancel.UseVisualStyleBackColor = true;
            // 
            // CreateAdd
            // 
            this.CreateAdd.Location = new System.Drawing.Point(312, 102);
            this.CreateAdd.Name = "CreateAdd";
            this.CreateAdd.Size = new System.Drawing.Size(75, 23);
            this.CreateAdd.TabIndex = 2;
            this.CreateAdd.Text = "Add";
            this.CreateAdd.UseVisualStyleBackColor = true;
            // 
            // CreateTextbox
            // 
            this.CreateTextbox.Location = new System.Drawing.Point(155, 58);
            this.CreateTextbox.Name = "CreateTextbox";
            this.CreateTextbox.Size = new System.Drawing.Size(232, 20);
            this.CreateTextbox.TabIndex = 3;
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 154);
            this.Controls.Add(this.CreateTextbox);
            this.Controls.Add(this.CreateAdd);
            this.Controls.Add(this.CreateCancel);
            this.Controls.Add(this.CreateLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Project";
            this.Load += new System.EventHandler(this.FormCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateLabel;
        private System.Windows.Forms.Button CreateCancel;
        private System.Windows.Forms.Button CreateAdd;
        private System.Windows.Forms.TextBox CreateTextbox;
    }
}