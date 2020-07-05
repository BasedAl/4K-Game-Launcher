namespace _4K_Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.launch_beans = new System.Windows.Forms.Button();
            this.update_beans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // launch_beans
            // 
            this.launch_beans.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.launch_beans, "launch_beans");
            this.launch_beans.Name = "launch_beans";
            this.launch_beans.UseVisualStyleBackColor = true;
            this.launch_beans.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // update_beans
            // 
            this.update_beans.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.update_beans, "update_beans");
            this.update_beans.Name = "update_beans";
            this.update_beans.UseVisualStyleBackColor = true;
            this.update_beans.Click += new System.EventHandler(this.update_beans_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.update_beans);
            this.Controls.Add(this.launch_beans);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button launch_beans;
        private System.Windows.Forms.Button update_beans;
    }
}

