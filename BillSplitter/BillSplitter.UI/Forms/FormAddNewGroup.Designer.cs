namespace BillSplitter.UI.Forms
{
  partial class FormAddNewGroup
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
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.nameTextBox = new System.Windows.Forms.TextBox();
      this.acceptButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 23);
      this.label1.TabIndex = 0;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(0, 0);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 27);
      this.textBox1.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(103, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(87, 20);
      this.label2.TabIndex = 0;
      this.label2.Text = "Enter name:";
      // 
      // nameTextBox
      // 
      this.nameTextBox.Location = new System.Drawing.Point(58, 104);
      this.nameTextBox.Name = "nameTextBox";
      this.nameTextBox.Size = new System.Drawing.Size(172, 27);
      this.nameTextBox.TabIndex = 1;
      // 
      // acceptButton
      // 
      this.acceptButton.Location = new System.Drawing.Point(73, 169);
      this.acceptButton.Name = "acceptButton";
      this.acceptButton.Size = new System.Drawing.Size(148, 43);
      this.acceptButton.TabIndex = 2;
      this.acceptButton.Text = "Accept";
      this.acceptButton.UseVisualStyleBackColor = true;
      this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
      // 
      // FormAddNewGroup
      // 
      this.ClientSize = new System.Drawing.Size(297, 253);
      this.Controls.Add(this.acceptButton);
      this.Controls.Add(this.nameTextBox);
      this.Controls.Add(this.label2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "FormAddNewGroup";
      this.Text = "Bill Splitter";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private TextBox nameTextBox;
    private Button acceptButton;
  }
}