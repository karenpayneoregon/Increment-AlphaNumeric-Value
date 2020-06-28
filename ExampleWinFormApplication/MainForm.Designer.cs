namespace ExampleWinFormApplication
{
    partial class MainForm
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
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.SequenceTextBox = new System.Windows.Forms.TextBox();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.IncrementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(13, 11);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(203, 160);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SequenceTextBox
            // 
            this.SequenceTextBox.Location = new System.Drawing.Point(13, 184);
            this.SequenceTextBox.Name = "SequenceTextBox";
            this.SequenceTextBox.Size = new System.Drawing.Size(200, 20);
            this.SequenceTextBox.TabIndex = 2;
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Image = global::ExampleWinFormApplication.Properties.Resources.NewItem_16x;
            this.NewOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewOrderButton.Location = new System.Drawing.Point(13, 251);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(203, 23);
            this.NewOrderButton.TabIndex = 4;
            this.NewOrderButton.Text = "New order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // IncrementButton
            // 
            this.IncrementButton.Image = global::ExampleWinFormApplication.Properties.Resources.Next_16x;
            this.IncrementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IncrementButton.Location = new System.Drawing.Point(13, 222);
            this.IncrementButton.Name = "IncrementButton";
            this.IncrementButton.Size = new System.Drawing.Size(203, 23);
            this.IncrementButton.TabIndex = 3;
            this.IncrementButton.Text = "Increment sequence value";
            this.IncrementButton.UseVisualStyleBackColor = true;
            this.IncrementButton.Click += new System.EventHandler(this.IncrementButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 293);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.IncrementButton);
            this.Controls.Add(this.SequenceTextBox);
            this.Controls.Add(this.CustomersListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.TextBox SequenceTextBox;
        private System.Windows.Forms.Button IncrementButton;
        private System.Windows.Forms.Button NewOrderButton;
    }
}

