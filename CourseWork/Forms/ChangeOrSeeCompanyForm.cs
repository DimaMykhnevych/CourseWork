using CourseWork.Enums;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class ChangeOrSeeCompanyForm : Form
    {
        public ChangeOrSeeCompanyForm()
        {
            InitializeComponent();
        }
        public ChangeOrSeeCompanyForm(Company company)
        {
            InitializeComponent();
            FillinformationAboutComp(company);
        }
        //Возврат в основную форму по нажатию на кнопку "ОТМЕНА"
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Сохранение изменений по нажатию на кнопку "ПОДТВЕРДИТЬ"
        private void BackToMain_Click(object sender, EventArgs e)
        {
            if (!CheckTelephone())
            {
                MessageBox.Show("Некорректно введен номер телефона.",
                              "Некорректные данные", MessageBoxButtons.OK); 
            }
            else
            {
                var comp = CreateCompanyFromForm();
                CompanyCollection.ChangeCompany(comp.Id, comp);
            }
        }
        //Сделать форму доступной для изменения при нажатии на клавишу "ИЗМЕНИТЬ"
        private void ChangeCompButton_Click(object sender, EventArgs e)
        {
            Writable(true);
        }
        //Создание новой компании из данных введенных в форме
        private Company CreateCompanyFromForm()
        {
            Company addedCompany = new Company()
            {
                Id = Convert.ToInt32(idLabel.Text),
                Name = nametextBox.Text,
                Category = (Category)Enum.Parse(typeof(Category), cathegorycomboBox.Text, true),
                Specialization = (Specialization)Enum.Parse(typeof(Specialization), speccomboBox.Text, true),
                Ownership = (OwnershipType)Enum.Parse(typeof(OwnershipType), ownerShipcomboBox.Text, true),
                Contacts = new CompanyContactData()
                {
                    Addres = new Addres()
                    {
                        City = citytextBox.Text,
                        Street = streettextBox.Text,
                        HouseNumber = string.IsNullOrEmpty(houseNumtextBox.Text) ? 0 : Convert.ToInt32(houseNumtextBox.Text)
                    },
                    Telephone = telephtextBox.Text
                }
            };
            var schedule = new List<CompanySchedule>();
            foreach (var el in groupBox1.Controls)
            {
                CheckBox day = (CheckBox)el;
                if (day.Checked) schedule.Add(new CompanySchedule()
                {
                    Day = (Days)Enum.Parse(typeof(Days), day.Text, true),
                    StartWorkingTime = startTimePicker.Value,
                    EndWorkingTime = endTimePicker.Value
                });
            }
            addedCompany.Schedules = schedule;
            var serv = new List<string>();
            foreach (var ch in servicesList.CheckedItems) serv.Add(ch.ToString());
            addedCompany.Services = serv;
            return addedCompany;
        }
        //Заполнение данных о компании в форму
        private void FillinformationAboutComp(Company company)
        {
            idLabel.Text = company.Id + "";
            nametextBox.Text = company.Name;
            citytextBox.Text = company.Contacts.Addres.City;
            streettextBox.Text = company.Contacts.Addres.Street;
            houseNumtextBox.Text = company.Contacts.Addres.HouseNumber + "";
            telephtextBox.Text = company.Contacts.Telephone;
            cathegorycomboBox.Text = company.Category.ToString();
            ownerShipcomboBox.Text = company.Ownership.ToString();
            speccomboBox.Text = company.Specialization.ToString();
            endTimePicker.Value = company.Schedules[0].EndWorkingTime;
            startTimePicker.Value = company.Schedules[0].StartWorkingTime;

            foreach (var s in company.Schedules)
            {
                foreach (var el in groupBox1.Controls)
                {
                    var El = el as CheckBox;
                    if (El.Text.Equals(s.Day.ToString(), StringComparison.OrdinalIgnoreCase))
                        El.Checked = true;
                }
            }

            var arr = servicesList.Items;
            foreach (var s in company.Services)
            {
                for (int i = 0; i < servicesList.Items.Count; i++)
                {
                    if (arr[i].ToString().Equals(s, StringComparison.OrdinalIgnoreCase))
                    {
                        servicesList.SetItemChecked(i, true);
                    }
                }
            }
        }
        public void Writable(bool verif)
        {
            foreach (var element in Controls)
            {
                if (element is TextBox)
                {
                    TextBox tb = (TextBox)element;
                    tb.ReadOnly = !verif;
                }
                else if (element is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)element;
                    dtp.Enabled = verif;
                }
                else if (element is ComboBox)
                {
                    ComboBox cb = (ComboBox)element;
                    cb.Enabled = verif;
                }
                else if (element is CheckBox)
                {
                    CheckBox cb = (CheckBox)element;
                    cb.Enabled = verif;
                }
                else if (element is CheckedListBox)
                {
                    CheckedListBox cb = (CheckedListBox)element;
                    cb.Enabled = verif;
                }
                else if (element is GroupBox)
                {
                    GroupBox gb = (GroupBox)element;
                    foreach (var tmp in gb.Controls)
                    {
                        var ch = (CheckBox)tmp;
                        ch.Enabled = verif;
                    }
                }
            }
        }

        //проверка на введенный номер телефона
        private bool CheckTelephone()
        {
            string pattern = @"[3-9]{1}\d{8}";
            if (Regex.IsMatch(telephtextBox.Text, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        //проверка на ввод начального времени
        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime startValue = endTimePicker.Value;
            startTimePicker.MaxDate = startValue.AddMinutes(-1);
            if (startTimePicker.MaxDate >= endTimePicker.Value)
            {
                if (startValue.Minute > 0) startValue.AddMinutes(-1);
                else
                {
                    startValue.AddMinutes(59);
                    startValue.AddHours(-1);
                }
            }
            else startValue.AddMinutes(-1);

        }

        //проверка на ввод конечного времени
        private void endDTPicker_ValueChanged(object sender, EventArgs e)
        {
            if (startTimePicker.Value >= endTimePicker.Value)
            {
                endTimePicker.Value = startTimePicker.Value.AddMinutes(1);
            }
        }


    }
}
