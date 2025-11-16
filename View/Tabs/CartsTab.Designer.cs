namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.CartSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ItemsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.CartButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountTextLabel = new System.Windows.Forms.Label();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.CustomersComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CartSplitContainer)).BeginInit();
            this.CartSplitContainer.Panel1.SuspendLayout();
            this.CartSplitContainer.Panel2.SuspendLayout();
            this.CartSplitContainer.SuspendLayout();
            this.ItemsTableLayoutPanel.SuspendLayout();
            this.CartButtonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartSplitContainer
            // 
            this.CartSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.CartSplitContainer.Name = "CartSplitContainer";
            // 
            // CartSplitContainer.Panel1
            // 
            this.CartSplitContainer.Panel1.Controls.Add(this.ItemsTableLayoutPanel);
            this.CartSplitContainer.Panel1.Controls.Add(this.ItemsListBox);
            this.CartSplitContainer.Panel1.Controls.Add(this.ItemsLabel);
            // 
            // CartSplitContainer.Panel2
            // 
            this.CartSplitContainer.Panel2.Controls.Add(this.CartButtonsTableLayoutPanel);
            this.CartSplitContainer.Panel2.Controls.Add(this.AmountLabel);
            this.CartSplitContainer.Panel2.Controls.Add(this.AmountTextLabel);
            this.CartSplitContainer.Panel2.Controls.Add(this.CartListBox);
            this.CartSplitContainer.Panel2.Controls.Add(this.CartLabel);
            this.CartSplitContainer.Panel2.Controls.Add(this.CustomersComboBox);
            this.CartSplitContainer.Panel2.Controls.Add(this.CustomerLabel);
            this.CartSplitContainer.Size = new System.Drawing.Size(592, 477);
            this.CartSplitContainer.SplitterDistance = 287;
            this.CartSplitContainer.TabIndex = 0;
            // 
            // ItemsTableLayoutPanel
            // 
            this.ItemsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsTableLayoutPanel.ColumnCount = 3;
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ItemsTableLayoutPanel.Controls.Add(this.AddToCartButton, 0, 0);
            this.ItemsTableLayoutPanel.Location = new System.Drawing.Point(3, 418);
            this.ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            this.ItemsTableLayoutPanel.RowCount = 1;
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemsTableLayoutPanel.Size = new System.Drawing.Size(281, 56);
            this.ItemsTableLayoutPanel.TabIndex = 0;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddToCartButton.Location = new System.Drawing.Point(3, 3);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(87, 50);
            this.AddToCartButton.TabIndex = 0;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 15;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 18);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(281, 394);
            this.ItemsListBox.TabIndex = 1;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(39, 15);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // CartButtonsTableLayoutPanel
            // 
            this.CartButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartButtonsTableLayoutPanel.ColumnCount = 4;
            this.CartButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CartButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CartButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CartButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CartButtonsTableLayoutPanel.Controls.Add(this.CreateOrderButton, 0, 0);
            this.CartButtonsTableLayoutPanel.Controls.Add(this.RemoveItemButton, 2, 0);
            this.CartButtonsTableLayoutPanel.Controls.Add(this.ClearCartButton, 3, 0);
            this.CartButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 257);
            this.CartButtonsTableLayoutPanel.Name = "CartButtonsTableLayoutPanel";
            this.CartButtonsTableLayoutPanel.RowCount = 1;
            this.CartButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CartButtonsTableLayoutPanel.Size = new System.Drawing.Size(295, 44);
            this.CartButtonsTableLayoutPanel.TabIndex = 7;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateOrderButton.Location = new System.Drawing.Point(3, 3);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(67, 38);
            this.CreateOrderButton.TabIndex = 0;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveItemButton.Location = new System.Drawing.Point(149, 3);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(67, 38);
            this.RemoveItemButton.TabIndex = 1;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearCartButton.Location = new System.Drawing.Point(222, 3);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(70, 38);
            this.ClearCartButton.TabIndex = 2;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(3, 219);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AmountLabel.Size = new System.Drawing.Size(295, 35);
            this.AmountLabel.TabIndex = 6;
            this.AmountLabel.Text = "0,00";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmountTextLabel
            // 
            this.AmountTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTextLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountTextLabel.Location = new System.Drawing.Point(3, 204);
            this.AmountTextLabel.Name = "AmountTextLabel";
            this.AmountTextLabel.Size = new System.Drawing.Size(295, 15);
            this.AmountTextLabel.TabIndex = 5;
            this.AmountTextLabel.Text = "Amount:";
            this.AmountTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CartListBox
            // 
            this.CartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.ItemHeight = 15;
            this.CartListBox.Location = new System.Drawing.Point(3, 62);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(295, 139);
            this.CartListBox.TabIndex = 3;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(3, 44);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(32, 15);
            this.CartLabel.TabIndex = 2;
            this.CartLabel.Text = "Cart:";
            // 
            // CustomersComboBox
            // 
            this.CustomersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomersComboBox.FormattingEnabled = true;
            this.CustomersComboBox.Location = new System.Drawing.Point(73, 15);
            this.CustomersComboBox.Name = "CustomersComboBox";
            this.CustomersComboBox.Size = new System.Drawing.Size(225, 23);
            this.CustomersComboBox.TabIndex = 1;
            this.CustomersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBox_SelectedIndexChanged);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerLabel.Location = new System.Drawing.Point(3, 18);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(64, 15);
            this.CustomerLabel.TabIndex = 0;
            this.CustomerLabel.Text = "Customer:";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartSplitContainer);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(592, 477);
            this.CartSplitContainer.Panel1.ResumeLayout(false);
            this.CartSplitContainer.Panel1.PerformLayout();
            this.CartSplitContainer.Panel2.ResumeLayout(false);
            this.CartSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartSplitContainer)).EndInit();
            this.CartSplitContainer.ResumeLayout(false);
            this.ItemsTableLayoutPanel.ResumeLayout(false);
            this.CartButtonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer CartSplitContainer;
        private System.Windows.Forms.TableLayoutPanel ItemsTableLayoutPanel;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.TableLayoutPanel CartButtonsTableLayoutPanel;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label AmountTextLabel;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.ComboBox CustomersComboBox;
        private System.Windows.Forms.Label CustomerLabel;
    }
}
