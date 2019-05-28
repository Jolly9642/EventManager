namespace TestApp2019_2
{
    partial class AdminForm
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
            this.adminUsersBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminEventsBox = new System.Windows.Forms.ListBox();
            this.adminEventLabel = new System.Windows.Forms.Label();
            this.adminEventNameBox = new System.Windows.Forms.TextBox();
            this.adminEventNameLabel = new System.Windows.Forms.Label();
            this.adminEventRankDD = new System.Windows.Forms.Label();
            this.adminDeleteUserBtn = new System.Windows.Forms.Button();
            this.adminMakeAdminBtn = new System.Windows.Forms.Button();
            this.adminCreateEventBtn = new System.Windows.Forms.Button();
            this.adminDeleteEventBtn = new System.Windows.Forms.Button();
            this.adminRadioBtn1 = new System.Windows.Forms.RadioButton();
            this.adminRadioBtn2 = new System.Windows.Forms.RadioButton();
            this.adminRadioBtn3 = new System.Windows.Forms.RadioButton();
            this.adminLabelGreeting = new System.Windows.Forms.Label();
            this.adminEventRankInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adminUsersBox
            // 
            this.adminUsersBox.FormattingEnabled = true;
            this.adminUsersBox.ItemHeight = 16;
            this.adminUsersBox.Location = new System.Drawing.Point(490, 37);
            this.adminUsersBox.Name = "adminUsersBox";
            this.adminUsersBox.Size = new System.Drawing.Size(120, 228);
            this.adminUsersBox.TabIndex = 0;
            this.adminUsersBox.SelectedIndexChanged += new System.EventHandler(this.adminUsersBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users:";
            // 
            // adminEventsBox
            // 
            this.adminEventsBox.FormattingEnabled = true;
            this.adminEventsBox.ItemHeight = 16;
            this.adminEventsBox.Location = new System.Drawing.Point(234, 37);
            this.adminEventsBox.Name = "adminEventsBox";
            this.adminEventsBox.Size = new System.Drawing.Size(120, 228);
            this.adminEventsBox.TabIndex = 2;
            this.adminEventsBox.SelectedIndexChanged += new System.EventHandler(this.adminEventsBox_SelectedIndexChanged);
            // 
            // adminEventLabel
            // 
            this.adminEventLabel.AutoSize = true;
            this.adminEventLabel.Location = new System.Drawing.Point(231, 14);
            this.adminEventLabel.Name = "adminEventLabel";
            this.adminEventLabel.Size = new System.Drawing.Size(55, 17);
            this.adminEventLabel.TabIndex = 3;
            this.adminEventLabel.Text = "Events:";
            // 
            // adminEventNameBox
            // 
            this.adminEventNameBox.Location = new System.Drawing.Point(32, 54);
            this.adminEventNameBox.Name = "adminEventNameBox";
            this.adminEventNameBox.Size = new System.Drawing.Size(100, 22);
            this.adminEventNameBox.TabIndex = 4;
            // 
            // adminEventNameLabel
            // 
            this.adminEventNameLabel.AutoSize = true;
            this.adminEventNameLabel.Location = new System.Drawing.Point(32, 31);
            this.adminEventNameLabel.Name = "adminEventNameLabel";
            this.adminEventNameLabel.Size = new System.Drawing.Size(89, 17);
            this.adminEventNameLabel.TabIndex = 6;
            this.adminEventNameLabel.Text = "Event Name:";
            // 
            // adminEventRankDD
            // 
            this.adminEventRankDD.AutoSize = true;
            this.adminEventRankDD.Location = new System.Drawing.Point(32, 83);
            this.adminEventRankDD.Name = "adminEventRankDD";
            this.adminEventRankDD.Size = new System.Drawing.Size(85, 17);
            this.adminEventRankDD.TabIndex = 7;
            this.adminEventRankDD.Text = "Event Rank:";
            // 
            // adminDeleteUserBtn
            // 
            this.adminDeleteUserBtn.Location = new System.Drawing.Point(493, 283);
            this.adminDeleteUserBtn.Name = "adminDeleteUserBtn";
            this.adminDeleteUserBtn.Size = new System.Drawing.Size(147, 23);
            this.adminDeleteUserBtn.TabIndex = 8;
            this.adminDeleteUserBtn.Text = "Delete User";
            this.adminDeleteUserBtn.UseVisualStyleBackColor = true;
            this.adminDeleteUserBtn.Click += new System.EventHandler(this.adminDeleteUserBtn_Click);
            // 
            // adminMakeAdminBtn
            // 
            this.adminMakeAdminBtn.Location = new System.Drawing.Point(493, 325);
            this.adminMakeAdminBtn.Name = "adminMakeAdminBtn";
            this.adminMakeAdminBtn.Size = new System.Drawing.Size(147, 23);
            this.adminMakeAdminBtn.TabIndex = 9;
            this.adminMakeAdminBtn.Text = "Make Admin";
            this.adminMakeAdminBtn.UseVisualStyleBackColor = true;
            this.adminMakeAdminBtn.Click += new System.EventHandler(this.adminMakeAdminBtn_Click);
            // 
            // adminCreateEventBtn
            // 
            this.adminCreateEventBtn.Location = new System.Drawing.Point(32, 266);
            this.adminCreateEventBtn.Name = "adminCreateEventBtn";
            this.adminCreateEventBtn.Size = new System.Drawing.Size(120, 23);
            this.adminCreateEventBtn.TabIndex = 11;
            this.adminCreateEventBtn.Text = "Create Event";
            this.adminCreateEventBtn.UseVisualStyleBackColor = true;
            this.adminCreateEventBtn.Click += new System.EventHandler(this.adminCreateEventBtn_Click);
            // 
            // adminDeleteEventBtn
            // 
            this.adminDeleteEventBtn.Location = new System.Drawing.Point(234, 283);
            this.adminDeleteEventBtn.Name = "adminDeleteEventBtn";
            this.adminDeleteEventBtn.Size = new System.Drawing.Size(120, 23);
            this.adminDeleteEventBtn.TabIndex = 12;
            this.adminDeleteEventBtn.Text = "Delete Event";
            this.adminDeleteEventBtn.UseVisualStyleBackColor = true;
            this.adminDeleteEventBtn.Click += new System.EventHandler(this.adminDeleteEventBtn_Click);
            // 
            // adminRadioBtn1
            // 
            this.adminRadioBtn1.AutoSize = true;
            this.adminRadioBtn1.Location = new System.Drawing.Point(32, 147);
            this.adminRadioBtn1.Name = "adminRadioBtn1";
            this.adminRadioBtn1.Size = new System.Drawing.Size(106, 21);
            this.adminRadioBtn1.TabIndex = 13;
            this.adminRadioBtn1.TabStop = true;
            this.adminRadioBtn1.Text = "8AM - 12PM";
            this.adminRadioBtn1.UseVisualStyleBackColor = true;
            // 
            // adminRadioBtn2
            // 
            this.adminRadioBtn2.AutoSize = true;
            this.adminRadioBtn2.Location = new System.Drawing.Point(32, 175);
            this.adminRadioBtn2.Name = "adminRadioBtn2";
            this.adminRadioBtn2.Size = new System.Drawing.Size(106, 21);
            this.adminRadioBtn2.TabIndex = 14;
            this.adminRadioBtn2.TabStop = true;
            this.adminRadioBtn2.Text = "12PM - 4PM";
            this.adminRadioBtn2.UseVisualStyleBackColor = true;
            // 
            // adminRadioBtn3
            // 
            this.adminRadioBtn3.AutoSize = true;
            this.adminRadioBtn3.Location = new System.Drawing.Point(32, 203);
            this.adminRadioBtn3.Name = "adminRadioBtn3";
            this.adminRadioBtn3.Size = new System.Drawing.Size(98, 21);
            this.adminRadioBtn3.TabIndex = 15;
            this.adminRadioBtn3.TabStop = true;
            this.adminRadioBtn3.Text = "4PM - 8PM";
            this.adminRadioBtn3.UseVisualStyleBackColor = true;
            // 
            // adminLabelGreeting
            // 
            this.adminLabelGreeting.AutoSize = true;
            this.adminLabelGreeting.Location = new System.Drawing.Point(35, 404);
            this.adminLabelGreeting.Name = "adminLabelGreeting";
            this.adminLabelGreeting.Size = new System.Drawing.Size(48, 17);
            this.adminLabelGreeting.TabIndex = 16;
            this.adminLabelGreeting.Text = "Hello, ";
            // 
            // adminEventRankInput
            // 
            this.adminEventRankInput.Location = new System.Drawing.Point(32, 104);
            this.adminEventRankInput.Name = "adminEventRankInput";
            this.adminEventRankInput.Size = new System.Drawing.Size(100, 22);
            this.adminEventRankInput.TabIndex = 17;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminEventRankInput);
            this.Controls.Add(this.adminLabelGreeting);
            this.Controls.Add(this.adminRadioBtn3);
            this.Controls.Add(this.adminRadioBtn2);
            this.Controls.Add(this.adminRadioBtn1);
            this.Controls.Add(this.adminDeleteEventBtn);
            this.Controls.Add(this.adminCreateEventBtn);
            this.Controls.Add(this.adminMakeAdminBtn);
            this.Controls.Add(this.adminDeleteUserBtn);
            this.Controls.Add(this.adminEventRankDD);
            this.Controls.Add(this.adminEventNameLabel);
            this.Controls.Add(this.adminEventNameBox);
            this.Controls.Add(this.adminEventLabel);
            this.Controls.Add(this.adminEventsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminUsersBox);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox adminUsersBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox adminEventsBox;
        private System.Windows.Forms.Label adminEventLabel;
        private System.Windows.Forms.TextBox adminEventNameBox;
        private System.Windows.Forms.Label adminEventNameLabel;
        private System.Windows.Forms.Label adminEventRankDD;
        private System.Windows.Forms.Button adminDeleteUserBtn;
        private System.Windows.Forms.Button adminMakeAdminBtn;
        private System.Windows.Forms.Button adminCreateEventBtn;
        private System.Windows.Forms.Button adminDeleteEventBtn;
        private System.Windows.Forms.RadioButton adminRadioBtn1;
        private System.Windows.Forms.RadioButton adminRadioBtn2;
        private System.Windows.Forms.RadioButton adminRadioBtn3;
        private System.Windows.Forms.Label adminLabelGreeting;
        private System.Windows.Forms.TextBox adminEventRankInput;
    }
}