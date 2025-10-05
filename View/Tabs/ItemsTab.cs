using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Выбранный товар
        /// </summary>
        private Item _currentItem;

        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление нового товара
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item("None", "None", 0);
            _items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);
            ItemsListBox.SelectedIndex = _items.Count - 1;
            UpdateTextBoxes(_currentItem);
        }

        /// <summary>
        /// Удаление товара
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0) return;
            int index = ItemsListBox.SelectedIndex;
            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);

            if (ItemsListBox.Items.Count > index)
                ItemsListBox.SelectedIndex = index;
            else if (ItemsListBox.Items.Count != 0)
                ItemsListBox.SelectedIndex = 0;
            else
                ItemsListBox.SelectedIndex = -1;

            UpdateTextBoxes(_currentItem);

            if (ItemsListBox.Items.Count == 0)
                ClearTextBoxes();
        }

        /// <summary>
        /// Обновление текстбоксов
        /// </summary>
        /// <param name="item">Товар</param>
        private void UpdateTextBoxes(Item item)
        {
            IDTextBox.Text = item.ID.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Info;
        }

        /// <summary>
        /// Очистка текстбоксов
        /// </summary>
        private void ClearTextBoxes()
        {
            IDTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
        }

        /// <summary>
        /// Извенение цены товара, когда в CostTextBox меняется значение
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {

            if (CostTextBox.Text == "")
            {
                _currentItem.Cost = 0;
                return;
            }

            try
            {
                double cost = Convert.ToDouble(CostTextBox.Text);
                ValueValidator.AssertValueInRange(cost, 0, 100000, "Стоимость");
                _currentItem.Cost = cost;
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnlengs(NameTextBox.Text, 200, "Название");
                _currentItem.Name = NameTextBox.Text;
                ItemsListBox.Items[_items.IndexOf(_currentItem)] = _currentItem.Name;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnlengs(DescriptionTextBox.Text, 1000, "Описание");
                _currentItem.Info = DescriptionTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Обновление данных при выборе товара в ItemsListBox
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index == -1) return;
            _currentItem = _items[index];
            UpdateTextBoxes(_currentItem);
        }
    }
}
