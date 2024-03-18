namespace NotificationManagementGUI
{
    partial class ManageSubscriptionForm
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
            this.ckSendByEmail = new System.Windows.Forms.CheckBox();
            this.ckSendByPhoneNumber = new System.Windows.Forms.CheckBox();
            this.txtInputEmail = new System.Windows.Forms.TextBox();
            this.txtInputPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.btnCancelSubscription = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckSendByEmail
            // 
            this.ckSendByEmail.AutoSize = true;
            this.ckSendByEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckSendByEmail.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSendByEmail.Location = new System.Drawing.Point(105, 117);
            this.ckSendByEmail.Name = "ckSendByEmail";
            this.ckSendByEmail.Size = new System.Drawing.Size(221, 26);
            this.ckSendByEmail.TabIndex = 0;
            this.ckSendByEmail.Text = "Notification Sent by Email";
            this.ckSendByEmail.UseVisualStyleBackColor = true;
            this.ckSendByEmail.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // ckSendByPhoneNumber
            // 
            this.ckSendByPhoneNumber.AutoSize = true;
            this.ckSendByPhoneNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckSendByPhoneNumber.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSendByPhoneNumber.Location = new System.Drawing.Point(105, 215);
            this.ckSendByPhoneNumber.Name = "ckSendByPhoneNumber";
            this.ckSendByPhoneNumber.Size = new System.Drawing.Size(212, 26);
            this.ckSendByPhoneNumber.TabIndex = 1;
            this.ckSendByPhoneNumber.Text = "Notification Sent by SMS";
            this.ckSendByPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // txtInputEmail
            // 
            this.txtInputEmail.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputEmail.Location = new System.Drawing.Point(351, 117);
            this.txtInputEmail.Name = "txtInputEmail";
            this.txtInputEmail.Size = new System.Drawing.Size(353, 28);
            this.txtInputEmail.TabIndex = 2;
            this.txtInputEmail.Click += new System.EventHandler(this.TxtInputEmail_Click);
            // 
            // txtInputPhoneNumber
            // 
            this.txtInputPhoneNumber.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputPhoneNumber.Location = new System.Drawing.Point(351, 213);
            this.txtInputPhoneNumber.Name = "txtInputPhoneNumber";
            this.txtInputPhoneNumber.Size = new System.Drawing.Size(353, 28);
            this.txtInputPhoneNumber.TabIndex = 3;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.AutoSize = true;
            this.btnSubscribe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubscribe.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscribe.Location = new System.Drawing.Point(105, 324);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(165, 44);
            this.btnSubscribe.TabIndex = 4;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.BtnSubscribe_Click);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.AutoSize = true;
            this.btnUnsubscribe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnsubscribe.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnsubscribe.Location = new System.Drawing.Point(322, 324);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(164, 44);
            this.btnUnsubscribe.TabIndex = 5;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
            // 
            // btnCancelSubscription
            // 
            this.btnCancelSubscription.AutoSize = true;
            this.btnCancelSubscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSubscription.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSubscription.Location = new System.Drawing.Point(541, 324);
            this.btnCancelSubscription.Name = "btnCancelSubscription";
            this.btnCancelSubscription.Size = new System.Drawing.Size(163, 44);
            this.btnCancelSubscription.TabIndex = 6;
            this.btnCancelSubscription.Text = "Cancel";
            this.btnCancelSubscription.UseVisualStyleBackColor = true;
            this.btnCancelSubscription.Click += new System.EventHandler(this.BtnCancelSubscription_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ManageSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelSubscription);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.txtInputPhoneNumber);
            this.Controls.Add(this.txtInputEmail);
            this.Controls.Add(this.ckSendByPhoneNumber);
            this.Controls.Add(this.ckSendByEmail);
            this.Name = "ManageSubscriptionForm";
            this.Text = "Manage Subscription";
            this.Load += new System.EventHandler(this.ManageSubscription_Load);
            this.Click += new System.EventHandler(this.TxtInputEmail_Click);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckSendByEmail;
        private System.Windows.Forms.CheckBox ckSendByPhoneNumber;
        private System.Windows.Forms.TextBox txtInputEmail;
        private System.Windows.Forms.TextBox txtInputPhoneNumber;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.Button btnCancelSubscription;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}