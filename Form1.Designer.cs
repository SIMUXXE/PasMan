namespace PasMan
{
    partial class FormMain
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
            panelMainMenu = new Panel();
            buttonShowRandomizer = new Button();
            labelMainMenu = new Label();
            panelMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainMenu
            // 
            panelMainMenu.Controls.Add(labelMainMenu);
            panelMainMenu.Controls.Add(buttonShowRandomizer);
            panelMainMenu.Location = new Point(0, 0);
            panelMainMenu.Name = "panelMainMenu";
            panelMainMenu.Size = new Size(743, 453);
            panelMainMenu.TabIndex = 0;
            panelMainMenu.Paint += panelMainMenu_Paint;
            // 
            // buttonShowRandomizer
            // 
            buttonShowRandomizer.Location = new Point(96, 139);
            buttonShowRandomizer.Name = "buttonShowRandomizer";
            buttonShowRandomizer.Size = new Size(128, 23);
            buttonShowRandomizer.TabIndex = 0;
            buttonShowRandomizer.Text = "Generate Password";
            buttonShowRandomizer.UseVisualStyleBackColor = true;
            // 
            // labelMainMenu
            // 
            labelMainMenu.AutoSize = true;
            labelMainMenu.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMainMenu.Location = new Point(56, 41);
            labelMainMenu.Name = "labelMainMenu";
            labelMainMenu.Size = new Size(220, 32);
            labelMainMenu.TabIndex = 1;
            labelMainMenu.Text = "Password Manager";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 451);
            Controls.Add(panelMainMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Text = "Password Mananger";
            Load += this.FormMain_Load;
            panelMainMenu.ResumeLayout(false);
            panelMainMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainMenu;
        private Label labelMainMenu;
        private Button buttonShowRandomizer;
    }
}
