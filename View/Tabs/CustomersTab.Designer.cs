namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            IDTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            button3 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "CustomerListBox" });
            listBox1.Location = new Point(3, 18);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(315, 334);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Customers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 83);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 10;
            label5.Text = "Address:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(72, 80);
            textBox2.MinimumSize = new Size(135, 23);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(393, 89);
            textBox2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 54);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Full Name:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(73, 51);
            textBox1.MinimumSize = new Size(135, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 23);
            textBox1.TabIndex = 7;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(73, 21);
            IDTextBox.MinimumSize = new Size(135, 23);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(135, 23);
            IDTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 24);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 2;
            label2.Text = "Selected Customers";
            label2.Click += label2_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(listBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(IDTextBox);
            splitContainer1.Size = new Size(799, 417);
            splitContainer1.SplitterDistance = 323;
            splitContainer1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(button3);
            panel3.Location = new Point(110, 373);
            panel3.Name = "panel3";
            panel3.Size = new Size(101, 41);
            panel3.TabIndex = 6;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(3, 2);
            button3.Name = "button3";
            button3.Size = new Size(95, 36);
            button3.TabIndex = 7;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 373);
            panel1.Name = "panel1";
            panel1.Size = new Size(101, 41);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 36);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Location = new Point(217, 373);
            panel2.Name = "panel2";
            panel2.Size = new Size(101, 41);
            panel2.TabIndex = 8;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CustomersTab";
            Size = new Size(799, 417);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private TextBox IDTextBox;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Button button3;
        private Button button1;
    }
}
