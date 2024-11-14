namespace tela_de_login
{
    partial class FormMain
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
            lblBemVindo = new Label();
            SuspendLayout();
            // 
            // lblBemVindo
            // 
            lblBemVindo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBemVindo.Location = new Point(24, 21);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(402, 32);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Você está logado como [Nome]";
            lblBemVindo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 143);
            Controls.Add(lblBemVindo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            Text = "FormMain";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBemVindo;
    }
}