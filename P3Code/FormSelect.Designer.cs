namespace P3Code
{
    partial class FormSelect
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
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.SelectProj_btn = new System.Windows.Forms.Button();
            this.ProjectListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_btn.Location = new System.Drawing.Point(141, 232);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(107, 33);
            this.Cancel_btn.TabIndex = 1;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // SelectProj_btn
            // 
            this.SelectProj_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SelectProj_btn.Location = new System.Drawing.Point(267, 232);
            this.SelectProj_btn.Name = "SelectProj_btn";
            this.SelectProj_btn.Size = new System.Drawing.Size(108, 33);
            this.SelectProj_btn.TabIndex = 2;
            this.SelectProj_btn.Text = "Select Project";
            this.SelectProj_btn.UseVisualStyleBackColor = true;
            this.SelectProj_btn.Click += new System.EventHandler(this.SelectProj_btn_Click);
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.Location = new System.Drawing.Point(35, 25);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(340, 186);
            this.ProjectListBox.TabIndex = 0;
            this.ProjectListBox.SelectedIndexChanged += new System.EventHandler(this.ProjectListBox_SelectedIndexChanged);
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 295);
            this.Controls.Add(this.SelectProj_btn);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.ProjectListBox);
            this.Name = "FormSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Project";
            this.Load += new System.EventHandler(this.SelectProject_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button SelectProj_btn;
        private System.Windows.Forms.ListBox ProjectListBox;
    }
}