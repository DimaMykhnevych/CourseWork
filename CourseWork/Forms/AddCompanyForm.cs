using CourseWork.Enums;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class AddCompanyForm : Form
    {
        public AddCompanyForm()
        {
            InitializeComponent();
        }
        //Установка значений для элементов формы по умолчанию
        private void AddCompanyForm_Load(object sender, EventArgs e)
        {
            foreach (Control elem in Controls)
            {
                if (elem is ComboBox)
                {
                    ComboBox combo = (ComboBox)elem;
                    combo.SelectedIndex = 0;
                }
            }
        }

        //Закрытие формы по нажатию на клавишу отмена
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Добавление компании 
        private void AddCompButton_Click(object sender, EventArgs e)
        {
            if (!CheckTelephone())
            {
                MessageBox.Show("Некорректно введен номер телефона.",
                              "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!PassAllFields())
            {
                MessageBox.Show("Заполните все поля.",
                              "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CompanyCollection.AddCompany(AddCompanyToTheDatabase());
                Close();
            }
        }
        //проверка на то, что введены все данные
        private bool PassAllFields()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Text == "") return false;
                }

                else if (c is ComboBox)
                {
                    if (((ComboBox)c).SelectedIndex == 0) return false;
                }

                else if (c is GroupBox)
                {
                    int count = 0;
                    GroupBox gb = (GroupBox)c;
                    foreach (CheckBox ch in gb.Controls)
                    {
                        if (ch.Checked == false) count++;
                    }
                    if (c.Controls.Count == count) return false;

                }
                else if (c is NumericUpDown)
                {
                    if (((NumericUpDown)c).Value == 0) return false;
                }
                else if (c is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)c;

                    if (clb.CheckedItems.Count == 0)
                    {
                        clb.SetItemChecked(clb.Items.Count - 1, true);
                    }
                }
            }
            return true;
        }

        //Сброс параметров по нажатию на кнопку сбросить
        private void ResetParams_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = "";

                else if (c is ComboBox) ((ComboBox)c).SelectedIndex = 0;

                else if (c is GroupBox)
                {
                    GroupBox gb = (GroupBox)c;
                    foreach (CheckBox ch in gb.Controls) ch.Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    if (dtp.Name == "startTimePicker") dtp.Value = Convert.ToDateTime("01/01/1800 " + "00:00" + ":00.00");
                    else if (dtp.Name == "endTimePicker") dtp.Value = Convert.ToDateTime("01/01/1800 " + "23:59" + ":00.00");
                }
                else if (c is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)c;
                    for (int i = 0; i < clb.Items.Count; i++) clb.SetItemChecked(i, false);
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
        //Создание компании по введенным данным
        private Company AddCompanyToTheDatabase()
        {
            Company addedCompany = new Company()
            {
                Id = -1,
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
                        HouseNumber = (int)houseNumber.Value
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
