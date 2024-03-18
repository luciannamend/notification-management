namespace NotificationManagementGUI
{
    partial class PublishNotificationForm
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
            this.lbNotificationContent = new System.Windows.Forms.Label();
            this.txtInputNotificationContent = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnExitNotificationContent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNotificationContent
            // 
            this.lbNotificationContent.AutoSize = true;
            this.lbNotificationContent.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotificationContent.Location = new System.Drawing.Point(39, 110);
            this.lbNotificationContent.Name = "lbNotificationContent";
            this.lbNotificationContent.Size = new System.Drawing.Size(161, 22);
            this.lbNotificationContent.TabIndex = 0;
            this.lbNotificationContent.Text = "Notification Content";
            // 
            // txtInputNotificationContent
            // 
            this.txtInputNotificationContent.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputNotificationContent.Location = new System.Drawing.Point(227, 108);
            this.txtInputNotificationContent.Name = "txtInputNotificationContent";
            this.txtInputNotificationContent.Size = new System.Drawing.Size(352, 28);
            this.txtInputNotificationContent.TabIndex = 1;
            this.txtInputNotificationContent.TextChanged += new System.EventHandler(this.txtInputNotificationContent_TextChanged);
            // 
            // btnPublish
            // 
            this.btnPublish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublish.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublish.Location = new System.Drawing.Point(170, 223);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(108, 38);
            this.btnPublish.TabIndex = 2;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnExitNotificationContent
            // 
            this.btnExitNotificationContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitNotificationContent.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitNotificationContent.Location = new System.Drawing.Point(353, 223);
            this.btnExitNotificationContent.Name = "btnExitNotificationContent";
            this.btnExitNotificationContent.Size = new System.Drawing.Size(108, 38);
            this.btnExitNotificationContent.TabIndex = 3;
            this.btnExitNotificationContent.Text = "Exit";
            this.btnExitNotificationContent.UseVisualStyleBackColor = true;
            this.btnExitNotificationContent.Click += new System.EventHandler(this.btnExitPublishNotification);
            // 
            // PublishNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.btnExitNotificationContent);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.txtInputNotificationContent);
            this.Controls.Add(this.lbNotificationContent);
            this.Name = "PublishNotificationForm";
            this.Text = "Publish Notification";
            this.Load += new System.EventHandler(this.PublishNotificationForm_Loadcd );
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNotificationContent;
        private System.Windows.Forms.TextBox txtInputNotificationContent;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Button btnExitNotificationContent;
    }
}