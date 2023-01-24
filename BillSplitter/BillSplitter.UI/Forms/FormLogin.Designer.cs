namespace BillSplitter
{
  partial class FormLogin
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.loginTextBox = new System.Windows.Forms.TextBox();
      this.passwordTextBox = new System.Windows.Forms.TextBox();
      this.loginButton = new System.Windows.Forms.Button();
      this.newAccLinkLabel = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(86, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Login";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(77, 99);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Password";
      // 
      // loginTextBox
      // 
      this.loginTextBox.Location = new System.Drawing.Point(240, 34);
      this.loginTextBox.Name = "loginTextBox";
      this.loginTextBox.Size = new System.Drawing.Size(171, 27);
      this.loginTextBox.TabIndex = 2;
      // 
      // passwordTextBox
      // 
      this.passwordTextBox.Location = new System.Drawing.Point(240, 96);
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.Size = new System.Drawing.Size(171, 27);
      this.passwordTextBox.TabIndex = 3;
      this.passwordTextBox.UseSystemPasswordChar = true;
      // 
      // loginButton
      // 
      this.loginButton.Location = new System.Drawing.Point(185, 146);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(129, 46);
      this.loginButton.TabIndex = 4;
      this.loginButton.Text = "Login";
      this.loginButton.UseVisualStyleBackColor = true;
      this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
      // 
      // newAccLinkLabel
      // 
      this.newAccLinkLabel.AutoSize = true;
      this.newAccLinkLabel.Location = new System.Drawing.Point(167, 207);
      this.newAccLinkLabel.Name = "newAccLinkLabel";
      this.newAccLinkLabel.Size = new System.Drawing.Size(163, 20);
      this.newAccLinkLabel.TabIndex = 5;
      this.newAccLinkLabel.TabStop = true;
      this.newAccLinkLabel.Text = "Don\'t have an account?";
      this.newAccLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newAccLinkLabel_LinkClicked);
      // 
      // FormLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(493, 249);
      this.Controls.Add(this.newAccLinkLabel);
      this.Controls.Add(this.loginButton);
      this.Controls.Add(this.passwordTextBox);
      this.Controls.Add(this.loginTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "FormLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Bill Splitter";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox loginTextBox;
    private TextBox passwordTextBox;
    private Button loginButton;
    private LinkLabel newAccLinkLabel;
  }
}