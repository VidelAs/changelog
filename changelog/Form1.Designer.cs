namespace changelog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMostrarCommits = new Button();
            txtCommits = new TextBox();
            SuspendLayout();
            // 
            // btnMostrarCommits
            // 
            btnMostrarCommits.Location = new Point(27, 49);
            btnMostrarCommits.Name = "btnMostrarCommits";
            btnMostrarCommits.Size = new Size(151, 30);
            btnMostrarCommits.TabIndex = 0;
            btnMostrarCommits.Text = "Mostrar Commits";
            btnMostrarCommits.UseVisualStyleBackColor = true;
            btnMostrarCommits.Click += btnMostrarCommits_Click;
            // 
            // txtCommits
            // 
            txtCommits.Location = new Point(37, 120);
            txtCommits.Multiline = true;
            txtCommits.Name = "txtCommits";
            txtCommits.ReadOnly = true;
            txtCommits.Size = new Size(421, 212);
            txtCommits.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCommits);
            Controls.Add(btnMostrarCommits);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarCommits;
        private TextBox txtCommits;
    }
}