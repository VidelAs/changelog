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
            txtCommits = new RichTextBox();
            SuspendLayout();
            // 
            // btnMostrarCommits
            // 
            btnMostrarCommits.Location = new Point(364, 599);
            btnMostrarCommits.Margin = new Padding(3, 4, 3, 4);
            btnMostrarCommits.Name = "btnMostrarCommits";
            btnMostrarCommits.Size = new Size(173, 40);
            btnMostrarCommits.TabIndex = 0;
            btnMostrarCommits.Text = "Mostrar Commits";
            btnMostrarCommits.UseVisualStyleBackColor = true;
            btnMostrarCommits.Click += btnMostrarCommits_Click;
            // 
            // txtCommits
            // 
            txtCommits.Location = new Point(38, 29);
            txtCommits.Margin = new Padding(3, 4, 3, 4);
            txtCommits.Name = "txtCommits";
            txtCommits.ReadOnly = true;
            txtCommits.Size = new Size(736, 524);
            txtCommits.TabIndex = 2;
            txtCommits.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 650);
            Controls.Add(txtCommits);
            Controls.Add(btnMostrarCommits);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrarCommits;
        private RichTextBox txtCommits;
    }
}