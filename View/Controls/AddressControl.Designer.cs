namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            IndexTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CountryTextBox = new TextBox();
            CityTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Delivery Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Post Index:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Country:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 70);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 109);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Street:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 149);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 5;
            label6.Text = "Building:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.Location = new Point(73, 30);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(95, 23);
            IndexTextBox.TabIndex = 6;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(73, 106);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(339, 23);
            StreetTextBox.TabIndex = 9;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(73, 67);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(148, 23);
            CountryTextBox.TabIndex = 11;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(264, 67);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(148, 23);
            CityTextBox.TabIndex = 12;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(73, 146);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(95, 23);
            BuildingTextBox.TabIndex = 13;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(264, 146);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(108, 23);
            ApartmentTextBox.TabIndex = 14;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(191, 149);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 15;
            label7.Text = "Apartment:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(ApartmentTextBox);
            Controls.Add(BuildingTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(StreetTextBox);
            Controls.Add(IndexTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddressControl";
            Size = new Size(481, 182);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox IndexTextBox;
        private TextBox StreetTextBox;
        private TextBox CountryTextBox;
        private TextBox CityTextBox;
        private TextBox BuildingTextBox;
        private TextBox ApartmentTextBox;
        private Label label7;
    }
}
