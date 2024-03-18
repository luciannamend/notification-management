namespace NotificationManagementGUI
{
    partial class NotificationManagerForm
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
            this.btnManageSubscription = new System.Windows.Forms.Button();
            this.btnPublishNotification = new System.Windows.Forms.Button();
            this.btnExitNotificationManager = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnManageSubscription
            // 
            this.btnManageSubscription.AccessibleDescription = "Manage Subscription";
            this.btnManageSubscription.AutoSize = true;
            this.btnManageSubscription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageSubscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageSubscription.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnManageSubscription.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSubscription.Location = new System.Drawing.Point(46, 184);
            this.btnManageSubscription.Name = "btnManageSubscription";
            this.btnManageSubscription.Size = new System.Drawing.Size(202, 46);
            this.btnManageSubscription.TabIndex = 0;
            this.btnManageSubscription.Text = "Manage Subscription";
            this.btnManageSubscription.UseVisualStyleBackColor = false;
            this.btnManageSubscription.Click += new System.EventHandler(this.btnManageSubscription_Click);
            // 
            // btnPublishNotification
            // 
            this.btnPublishNotification.AccessibleDescription = "Publish Notification";
            this.btnPublishNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublishNotification.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPublishNotification.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublishNotification.Location = new System.Drawing.Point(297, 184);
            this.btnPublishNotification.Name = "btnPublishNotification";
            this.btnPublishNotification.Size = new System.Drawing.Size(202, 46);
            this.btnPublishNotification.TabIndex = 1;
            this.btnPublishNotification.Text = "Publish Notification";
            this.btnPublishNotification.UseVisualStyleBackColor = true;            
            this.btnPublishNotification.Click += new System.EventHandler(this.btnPublishNotification_Click);

            // 
            // btnExitNotificationManager
            // 
            this.btnExitNotificationManager.AccessibleDescription = "Exit";
            this.btnExitNotificationManager.AutoSize = true;
            this.btnExitNotificationManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitNotificationManager.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExitNotificationManager.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitNotificationManager.Location = new System.Drawing.Point(554, 184);
            this.btnExitNotificationManager.Name = "btnExitNotificationManager";
            this.btnExitNotificationManager.Size = new System.Drawing.Size(201, 46);
            this.btnExitNotificationManager.TabIndex = 2;
            this.btnExitNotificationManager.Text = "Exit";
            this.btnExitNotificationManager.UseVisualStyleBackColor = true;
            this.btnExitNotificationManager.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NotificationManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.btnExitNotificationManager);
            this.Controls.Add(this.btnPublishNotification);
            this.Controls.Add(this.btnManageSubscription);
            this.Name = "NotificationManagerForm";
            this.Text = "Notification Manager";
            this.Load += new System.EventHandler(this.NotificationManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageSubscription;
        private System.Windows.Forms.Button btnPublishNotification;
        private System.Windows.Forms.Button btnExitNotificationManager;
    }
}

