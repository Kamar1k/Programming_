using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        // Добавьте это свойство:
        public Category SelectedCategory { get; private set; }

        public AddDiscountForm()
        {
            InitializeComponent();

            // Заполняем ComboBox категориями (ваш код хороший)
            var categoryValues = Enum.GetValues(typeof(Category));
            foreach (var value in categoryValues)
            {
                CategoryComboBox.Items.Add(value);
            }
            CategoryComboBox.SelectedIndex = 0;
        }

        // Это свойство можно оставить или удалить
        public PercentDiscount PercentDiscount { get; set; }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Важно установить DialogResult
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            // Сохраняем выбранную категорию
            SelectedCategory = (Category)CategoryComboBox.SelectedItem;

            // Можно создать PercentDiscount, но лучше только категорию
            PercentDiscount = new PercentDiscount(SelectedCategory);

            // Важно установить DialogResult
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}