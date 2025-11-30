namespace ObjectOrientedPractics
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tab1Paget = new TabControl();
            tabPage1 = new TabPage();
            ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            tabPage2 = new TabPage();
            CustomersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            Carts = new TabPage();
            cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            Orders = new TabPage();
            ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            tabPage3 = new TabPage();
            priorityOrdersTab1 = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            tab1Paget.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            Carts.SuspendLayout();
            Orders.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tab1Paget
            // 
            tab1Paget.Controls.Add(tabPage1);
            tab1Paget.Controls.Add(tabPage2);
            tab1Paget.Controls.Add(Carts);
            tab1Paget.Controls.Add(Orders);
            tab1Paget.Controls.Add(tabPage3);
            tab1Paget.Dock = DockStyle.Fill;
            tab1Paget.Location = new Point(0, 0);
            tab1Paget.Name = "tab1Paget";
            tab1Paget.SelectedIndex = 0;
            tab1Paget.Size = new Size(940, 581);
            tab1Paget.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ItemsTab);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(932, 553);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Item";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(926, 547);
            ItemsTab.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(CustomersTab);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(932, 553);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(3, 3);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(926, 547);
            CustomersTab.TabIndex = 0;
            // 
            // Carts
            // 
            Carts.Controls.Add(cartsTab1);
            Carts.Location = new Point(4, 24);
            Carts.Name = "Carts";
            Carts.Padding = new Padding(3);
            Carts.Size = new Size(932, 553);
            Carts.TabIndex = 2;
            Carts.Text = "Carts";
            Carts.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Location = new Point(3, 3);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(926, 547);
            cartsTab1.TabIndex = 0;
            // 
            // Orders
            // 
            Orders.Controls.Add(ordersTab1);
            Orders.Location = new Point(4, 24);
            Orders.Name = "Orders";
            Orders.Padding = new Padding(3);
            Orders.Size = new Size(932, 553);
            Orders.TabIndex = 3;
            Orders.Text = "Orders";
            Orders.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Customers = null;
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(3, 3);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(926, 547);
            ordersTab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(priorityOrdersTab1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(932, 553);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "Priority Orders";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            priorityOrdersTab1.Dock = DockStyle.Fill;
            priorityOrdersTab1.Items = null;
            priorityOrdersTab1.Location = new Point(3, 3);
            priorityOrdersTab1.Name = "priorityOrdersTab1";
            priorityOrdersTab1.Size = new Size(926, 547);
            priorityOrdersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 581);
            Controls.Add(tab1Paget);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "ObjectOrientedPractics";
            tab1Paget.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            Carts.ResumeLayout(false);
            Orders.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab1Paget;
        private TabPage tabPage1;
        private View.Tabs.ItemsTab ItemsTab;
        private TabPage tabPage2;
        private View.Tabs.CustomersTab CustomersTab;
        private TabPage Carts;
        private TabPage Orders;
        private View.Tabs.CartsTab cartsTab1;
        private View.Tabs.OrdersTab ordersTab1;
        private TabPage tabPage3;
        private View.Tabs.PriorityOrdersTab priorityOrdersTab1;
    }
}
