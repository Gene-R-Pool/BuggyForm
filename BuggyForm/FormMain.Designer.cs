namespace BuggyForm
{
    partial class FormMain
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
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            this.buttonGo.AccessibleDescription = "Go Button";
            this.buttonGo.AccessibleName = "buttonGo";
            this.buttonGo.Location = new System.Drawing.Point(406, 399);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(100, 30);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGoClick);
            this.buttonClose.AccessibleDescription = "Close Button";
            this.buttonClose.AccessibleName = "ButtonClose";
            this.buttonClose.Location = new System.Drawing.Point(512, 399);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonCloseClick);
            this.tabControl.AccessibleDescription = "tab control";
            this.tabControl.AccessibleName = "tabControl";
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(10, 16);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(600, 375);
            this.tabControl.TabIndex = 0;
            this.tabPage1.AccessibleDescription = "Main tab on form";
            this.tabPage1.AccessibleName = "tabMain";
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(592, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.comboBox1.AccessibleDescription = "Combo Box with a few things to select";
            this.comboBox1.AccessibleName = "comboBox";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 23);
            this.comboBox1.TabIndex = 2;
            this.richTextBox1.AccessibleDescription = "Rich text box containing messages";
            this.richTextBox1.AccessibleName = "richTextBoxMessages";
            this.richTextBox1.Location = new System.Drawing.Point(4, 239);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(582, 102);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            this.label2.AccessibleDescription = "Second label on the page";
            this.label2.AccessibleName = "label2";
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Label";
            this.textBox2.AccessibleDescription = "Second text box";
            this.textBox2.AccessibleName = "textBox2";
            this.textBox2.Location = new System.Drawing.Point(89, 50);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 3;
            this.label1.AccessibleDescription = "First label on the page";
            this.label1.AccessibleName = "label1";
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Label";
            this.textBox1.AccessibleDescription = "First text box";
            this.textBox1.AccessibleName = "textBox1";
            this.textBox1.Location = new System.Drawing.Point(89, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 1;
            this.tabPage2.AccessibleDescription = "SecondaryTab";
            this.tabPage2.AccessibleName = "tabSecondary";
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(592, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Secondary Tab";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.checkBox1.AccessibleDescription = "Check box on the secondary tab";
            this.checkBox1.AccessibleName = "checkBox";
            this.checkBox1.Location = new System.Drawing.Point(7, 6);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 33);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Only click when displayed";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonGo);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "Buggy Form";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonClose;
    }
}