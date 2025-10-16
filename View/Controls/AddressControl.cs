using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Текущий адрес, связанный с элементом управления.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Возвращает или задает текущий адрес.
        /// При установке значения обновляет текстовые поля элемента управления.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                UpdateTextBoxes(_address);
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Очищает все текстовые поля элемента управления.
        /// </summary>
        public void ClearInfo()
        {
            IndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        /// <summary>
        /// Обновляет текстовые поля элемента управления данными из указанного адреса.
        /// </summary>
        /// <param name="address">Адрес, данные которого отображаются в элементе управления.</param>
        public void UpdateTextBoxes(Address address)
        {
            if (address == null) return;

            IndexTextBox.Text = address.Index.ToString();
            CountryTextBox.Text = address.Country;
            CityTextBox.Text = address.City;
            StreetTextBox.Text = address.Street;
            BuildingTextBox.Text = address.Building;
            ApartmentTextBox.Text = address.Apartment;
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле почтового индекса.
        /// Выполняет валидацию и обновление значения индекса в текущем адресе.
        /// </summary>
        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = int.Parse(IndexTextBox.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле страны/региона.
        /// Выполняет валидацию и обновление значения страны в текущем адресе.
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {   
                _address.Country = CountryTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле улицы.
        /// Выполняет валидацию и обновление значения улицы в текущем адресе.
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле города.
        /// Выполняет валидацию и обновление значения города в текущем адресе.
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле номера дома.
        /// Выполняет валидацию и обновление значения номера дома в текущем адресе.
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле номера квартиры/помещения.
        /// Выполняет валидацию и обновление значения номера квартиры в текущем адресе.
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
