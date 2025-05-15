namespace Qinshift.WinFormApp
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
            btnClick = new Button();
            lblNumberView = new Label();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Location = new Point(12, 43);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(196, 54);
            btnClick.TabIndex = 0;
            btnClick.Text = "Click me";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += WhenButtonClickedBy1;
            btnClick.MouseHover += Something;
            btnClick.MouseLeave += SomethingElse;

            // 
            // lblNumberView
            // 
            lblNumberView.AutoSize = true;
            lblNumberView.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberView.Location = new Point(293, 51);
            lblNumberView.Name = "lblNumberView";
            lblNumberView.Size = new Size(0, 30);
            lblNumberView.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNumberView);
            Controls.Add(btnClick);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private Label lblNumberView;
    }
}
