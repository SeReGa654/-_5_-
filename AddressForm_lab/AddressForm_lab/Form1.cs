using System;
using System.Linq;
using System.Windows.Forms;

namespace AddressForm_lab
{
    public partial class MainForm : Form
    {
        private string[] kyivCities = { "Київ", "Бровари", "Буча", "Васильків", "Вишневе", "Ірпінь", "Обухів", "Фастів", "Боярка", "Вишгород" };
        private string[] vinnytsiaCities = { "Вінниця", "Хмільник", "Могилів-Подільський", "Козятин", "Кропивницький", "Жмеринка", "Калинівка", "Ладижин", "Тульчин", "Гайсин" };
        private string[] zhytomyrCities = { "Житомир", "Бердичів", "Новоград-Волинський", "Коростень", "Малин", "Народичі", "Овруч", "Радомишль", "Чуднів", "Брусилів" };
        private string[] khmelnytskyiCities = { "Хмельницький", "Кам'янець-Подільський", "Ізяслав", "Старокостянтинів", "Шепетівка", "Волочиськ", "Славута", "Деражня", "Нетішин", "Дунаївці" };
        private string[] cherkasyCities = { "Черкаси", "Умань", "Звенигородка", "Корсунь-Шевченківський", "Сміла", "Канів", "Жашків", "Христинівка", "Катеринопіль", "Монастирище" };
        private string[] rivneCities = { "Рівне", "Дубно", "Острог", "Сарни", "Здолбунів", "Костопіль", "Радивилів", "Березне", "Квасилів", "Володимирець" };
        private string[] ternopilCities = { "Тернопіль", "Кременець", "Чортків", "Тернопіль", "Бережани", "Підволочиськ", "Збараж", "Монастириська", "Ланівці", "Бучач" };
        private string[] ivanoFrankivskCities = { "Івано-Франківськ", "Коломия", "Надвірна", "Калуш", "Яремче", "Богородчани", "Долина", "Тисмениця", "Снятин", "Городенка" };
        private string[] chernivtsiCities = { "Чернівці", "Новодністровськ", "Сокиряни", "Хотин", "Вижниця", "Сторожинець", "Глибока", "Кельменці", "Заставна", "Герца" };
        private string[] volynCities = { "Луцьк", "Ковель", "Володимир-Волинський", "Нововолинськ", "Кременчук", "Іваничі", "Камінь-Каширський", "Любомль", "Рожище", "Ківерці" };
        private string[] zakarpattiaCities = { "Ужгород", "Мукачево", "Хуст", "Берегове", "Свалява", "Тячів", "Виноградів", "Іршава", "Рахів", "Великий Березний" };
        private string[] odesaCities = { "Одеса", "Білгород-Дністровський", "Ізмаїл", "Южне", "Чорноморськ", "Подільськ", "Ананьїв", "Балта", "Роздільна", "Котовськ" };
        private string[] mykolaivCities = { "Миколаїв", "Первомайськ", "Южноукраїнськ", "Вознесенськ", "Очаків", "Новий Буг", "Баштанка", "Снігурівка", "Березнегувате", "Доманівка" };
        private string[] khersonCities = { "Херсон", "Нова Каховка", "Каховка", "Таврійськ", "Олешки", "Берислав", "Гола Пристань", "Скадовськ", "Генічеськ", "Чаплинка" };
        private string[] dnipropetrovskCities = { "Дніпро", "Кривий Ріг", "Кам'янське", "Нікополь", "Павлоград", "Дніпродзержинськ", "Новомосковськ", "Верхньодніпровськ", "Синельникове", "Марганець" };
        private string[] zaporizhiaCities = { "Запоріжжя", "Мелітополь", "Бердянськ", "Енергодар", "Токмак", "Пологи", "Гуляйполе", "Оріхів", "Василівка", "Дніпрорудне" };
        private string[] kirovohradCities = { "Кропивницький", "Олександрія", "Світловодськ", "Знам'янка", "Новоукраїнка", "Мала Виска", "Долинська", "Бобринець", "Гайворон", "Онуфріївка" };
        private string[] poltavaCities = { "Полтава", "Кременчук", "Миргород", "Лубни", "Горішні Плавні", "Гадяч", "Карлівка", "Пирятин", "Лохвиця", "Зіньків" };
        private string[] sumyCities = { "Суми", "Конотоп", "Шостка", "Ромни", "Охтирка", "Лебедин", "Глухів", "Путивль", "Кролевець", "Білопілля" };
        private string[] kharkivCities = { "Харків", "Лозова", "Ізюм", "Чугуїв", "Первомайський", "Красноград", "Богодухів", "Валки", "Дергачі", "Зміїв" };


        public MainForm()
        {
            InitializeComponent();
            InitializeRegionDropdown();
        }

        private void InitializeRegionDropdown()
        {
            regionComboBox.Items.AddRange(new string[] { "Київська", "Вінницька", "Житомирська", "Хмельницька", "Черкаська", "Рівненська", "Тернопільська", "Івано-Франківська", "Чернівецька", "Волинська", "Закарпатська", "Одеська", "Миколаївська", "Херсонська", "Дніпропетровська", "Запорізька", "Кіровоградська", "Полтавська", "Сумська", "Харківська" });

        }

        private void regionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityComboBox.Items.Clear();
            string selectedRegion = regionComboBox.SelectedItem.ToString();

            switch (selectedRegion)
            {
                case "Київська":
                    cityComboBox.Items.AddRange(kyivCities);
                    break;
                case "Вінницька":
                    cityComboBox.Items.AddRange(vinnytsiaCities);
                    break;
                case "Житомирська":
                    cityComboBox.Items.AddRange(zhytomyrCities);
                    break;
                case "Хмельницька":
                    cityComboBox.Items.AddRange(khmelnytskyiCities);
                    break;
                case "Черкаська":
                    cityComboBox.Items.AddRange(cherkasyCities);
                    break;
                case "Рівненська":
                    cityComboBox.Items.AddRange(rivneCities);
                    break;
                case "Тернопільська":
                    cityComboBox.Items.AddRange(ternopilCities);
                    break;
                case "Івано-Франківська":
                    cityComboBox.Items.AddRange(ivanoFrankivskCities);
                    break;
                case "Чернівецька":
                    cityComboBox.Items.AddRange(chernivtsiCities);
                    break;
                case "Волинська":
                    cityComboBox.Items.AddRange(volynCities);
                    break;
                case "Закарпатська":
                    cityComboBox.Items.AddRange(zakarpattiaCities);
                    break;
                case "Одеська":
                    cityComboBox.Items.AddRange(odesaCities);
                    break;
                case "Миколаївська":
                    cityComboBox.Items.AddRange(mykolaivCities);
                    break;
                case "Херсонська":
                    cityComboBox.Items.AddRange(khersonCities);
                    break;
                case "Дніпропетровська":
                    cityComboBox.Items.AddRange(dnipropetrovskCities);
                    break;
                case "Запорізька":
                    cityComboBox.Items.AddRange(zaporizhiaCities);
                    break;
                case "Кіровоградська":
                    cityComboBox.Items.AddRange(kirovohradCities);
                    break;
                case "Полтавська":
                    cityComboBox.Items.AddRange(poltavaCities);
                    break;
                case "Сумська":
                    cityComboBox.Items.AddRange(sumyCities);
                    break;
                case "Харківська":
                    cityComboBox.Items.AddRange(kharkivCities);
                    break;
                default:
                    break;
            }

        }
        //regionComboBox.SelectedIndexChanged += regionComboBox_SelectedIndexChanged;
        private void saveButton_Click(object sender, EventArgs e)
{
            string region = regionComboBox.SelectedItem?.ToString();
            string city = cityComboBox.SelectedItem?.ToString();
            string postalCode = postalCodeTextBox.Text;
            string streetAndNumber = streetAndNumberTextBox.Text;

            if (string.IsNullOrEmpty(region) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(postalCode) || string.IsNullOrEmpty(streetAndNumber))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!postalCode.All(char.IsDigit) || postalCode.Length != 6)
            {
                MessageBox.Show("Невірний формат поштового коду. Введіть 6 цифр.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (streetAndNumber.Length <= 5)
            {
                MessageBox.Show("Введіть правильну вулицю та номер будинку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = $"Область: {region}\nМісто: {city}\nПоштовий код: {postalCode}\nВулиця та номер будинку: {streetAndNumber}";
            MessageBox.Show(message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string region = regionComboBox.SelectedItem?.ToString();
            string city = cityComboBox.SelectedItem?.ToString();
            string postalCode = postalCodeTextBox.Text;
            string streetAndNumber = streetAndNumberTextBox.Text;

            if (string.IsNullOrEmpty(region) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(postalCode) || string.IsNullOrEmpty(streetAndNumber))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!postalCode.All(char.IsDigit) || postalCode.Length != 6)
            {
                MessageBox.Show("Невірний формат поштового коду. Введіть 6 цифр.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (streetAndNumber.Length <= 5)
            {
                MessageBox.Show("Введіть правильну вулицю та номер будинку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string dataToWrite = $"Область: {region}\nМісто: {city}\nПоштовий код: {postalCode}\nВулиця та номер будинку: {streetAndNumber}";

            string filePath = "result.txt";

            try
            {
                System.IO.File.WriteAllText(filePath, dataToWrite);
                MessageBox.Show("Інформацію збережено у файл result.txt", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні інформації у файл: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
