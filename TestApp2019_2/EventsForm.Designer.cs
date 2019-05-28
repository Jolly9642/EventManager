namespace TestApp2019_2
{
    partial class EventsForm
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
            this.DropDownList = new System.Windows.Forms.ComboBox();
            this.EventsLabel = new System.Windows.Forms.Label();
            this.EventRank = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.eventsSubmitButton = new System.Windows.Forms.Button();
            this.userGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DropDownList
            // 
            this.DropDownList.FormattingEnabled = true;
            this.DropDownList.Location = new System.Drawing.Point(29, 73);
            this.DropDownList.Name = "DropDownList";
            this.DropDownList.Size = new System.Drawing.Size(121, 24);
            this.DropDownList.TabIndex = 0;
            // 
            // EventsLabel
            // 
            this.EventsLabel.AutoSize = true;
            this.EventsLabel.Location = new System.Drawing.Point(29, 38);
            this.EventsLabel.Name = "EventsLabel";
            this.EventsLabel.Size = new System.Drawing.Size(55, 17);
            this.EventsLabel.TabIndex = 1;
            this.EventsLabel.Text = "Events:";
            // 
            // EventRank
            // 
            this.EventRank.AutoSize = true;
            this.EventRank.Location = new System.Drawing.Point(172, 79);
            this.EventRank.Name = "EventRank";
            this.EventRank.Size = new System.Drawing.Size(0, 17);
            this.EventRank.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(444, 73);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "8AM - 12PM";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(444, 133);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 21);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "12PM - 4PM";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(444, 187);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 21);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "4PM - 8PM";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // eventsSubmitButton
            // 
            this.eventsSubmitButton.Location = new System.Drawing.Point(29, 311);
            this.eventsSubmitButton.Name = "eventsSubmitButton";
            this.eventsSubmitButton.Size = new System.Drawing.Size(172, 35);
            this.eventsSubmitButton.TabIndex = 6;
            this.eventsSubmitButton.Text = "Submit";
            this.eventsSubmitButton.UseVisualStyleBackColor = true;
            this.eventsSubmitButton.Click += new System.EventHandler(this.eventsSubmitButton_Click);
            // 
            // userGreeting
            // 
            this.userGreeting.AutoSize = true;
            this.userGreeting.Location = new System.Drawing.Point(32, 388);
            this.userGreeting.Name = "userGreeting";
            this.userGreeting.Size = new System.Drawing.Size(115, 17);
            this.userGreeting.TabIndex = 7;
            this.userGreeting.Text = "Hello, insert user";
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userGreeting);
            this.Controls.Add(this.eventsSubmitButton);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.EventRank);
            this.Controls.Add(this.EventsLabel);
            this.Controls.Add(this.DropDownList);
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DropDownList;
        private System.Windows.Forms.Label EventsLabel;
        private System.Windows.Forms.Label EventRank;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button eventsSubmitButton;
        private System.Windows.Forms.Label userGreeting;
    }
}