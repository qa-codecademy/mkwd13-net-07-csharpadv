namespace Qinshift.WinFormAsyncAwait
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
            btnSendMessage = new Button();
            btnSendMessageAsync = new Button();
            lblMessage = new Label();
            btnCheckMessage = new Button();
            lblResult = new Label();
            btnGetUsers = new Button();
            listViewTodos = new ListView();
            SuspendLayout();
            // 
            // btnSendMessage
            // 
            btnSendMessage.Location = new Point(31, 53);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(147, 50);
            btnSendMessage.TabIndex = 0;
            btnSendMessage.Text = "Send Message";
            btnSendMessage.UseVisualStyleBackColor = true;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // btnSendMessageAsync
            // 
            btnSendMessageAsync.Location = new Point(205, 53);
            btnSendMessageAsync.Name = "btnSendMessageAsync";
            btnSendMessageAsync.Size = new Size(147, 50);
            btnSendMessageAsync.TabIndex = 1;
            btnSendMessageAsync.Text = "Send Message Async";
            btnSendMessageAsync.UseVisualStyleBackColor = true;
            btnSendMessageAsync.Click += btnSendMessageAsync_Click;
            // 
            // lblMessage
            // 
            lblMessage.AllowDrop = true;
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(31, 216);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 30);
            lblMessage.TabIndex = 2;
            lblMessage.UseMnemonic = false;
            // 
            // btnCheckMessage
            // 
            btnCheckMessage.Location = new Point(379, 53);
            btnCheckMessage.Name = "btnCheckMessage";
            btnCheckMessage.Size = new Size(147, 50);
            btnCheckMessage.TabIndex = 3;
            btnCheckMessage.Text = "Check for new message";
            btnCheckMessage.UseVisualStyleBackColor = true;
            btnCheckMessage.Click += btnCheckMessage_Click;
            // 
            // lblResult
            // 
            lblResult.AllowDrop = true;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(31, 121);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 30);
            lblResult.TabIndex = 4;
            lblResult.UseMnemonic = false;
            // 
            // btnGetUsers
            // 
            btnGetUsers.Location = new Point(12, 200);
            btnGetUsers.Name = "btnGetUsers";
            btnGetUsers.Size = new Size(848, 50);
            btnGetUsers.TabIndex = 5;
            btnGetUsers.Text = "Get users";
            btnGetUsers.UseVisualStyleBackColor = true;
            btnGetUsers.Click += btnGetUsers_Click;
            // 
            // listViewTodos
            // 
            listViewTodos.Location = new Point(217, 274);
            listViewTodos.Name = "listViewTodos";
            listViewTodos.Size = new Size(448, 346);
            listViewTodos.TabIndex = 6;
            listViewTodos.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 652);
            Controls.Add(listViewTodos);
            Controls.Add(btnGetUsers);
            Controls.Add(lblResult);
            Controls.Add(btnCheckMessage);
            Controls.Add(lblMessage);
            Controls.Add(btnSendMessageAsync);
            Controls.Add(btnSendMessage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSendMessage;
        private Button btnSendMessageAsync;
        private Label lblMessage;
        private Button btnCheckMessage;
        private Label lblResult;
        private Button btnGetUsers;
        private ListView listViewTodos;
    }
}
