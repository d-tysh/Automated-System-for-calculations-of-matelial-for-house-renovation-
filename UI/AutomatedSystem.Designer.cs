namespace UI
{
    partial class AutomatedSystem
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
            this.EnterTheSystem = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EnterTheSystem
            // 
            this.EnterTheSystem.Location = new System.Drawing.Point(117, 45);
            this.EnterTheSystem.Name = "EnterTheSystem";
            this.EnterTheSystem.Size = new System.Drawing.Size(170, 35);
            this.EnterTheSystem.TabIndex = 0;
            this.EnterTheSystem.Text = "Enter the system";
            this.EnterTheSystem.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(117, 100);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(170, 35);
            this.Registration.TabIndex = 1;
            this.Registration.Text = "Registration";
            this.Registration.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(117, 155);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(170, 35);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(447, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 251);
            this.listBox1.TabIndex = 5;
            // 
            // AutomatedSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 426);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.EnterTheSystem);
            this.Name = "AutomatedSystem";
            this.Text = "Automated System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterTheSystem;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.ListBox listBox1;
    }
}

