using CourseWork.Enums;
using CourseWork.Forms;
using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CourseWork
{
    // Форма для поиска по различным параметрам, вызова форм
    //просмотра/изменения/добавления компании.
    public partial class MainForm : Form
    {
        private BindingList<Company> foundCompanies;
        private bool isFormClosingThroughMenuButton;
        public MainForm()
        {
            InitializeComponent();
        }

        //Установка значений по умолчанию в ComboBox
        private void Form1_Load(object sender, EventArgs e)
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
        // О программе
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовая работа\nПрограмма \"Справочник потребителя\"" +
                            " содержит базу предприятий бытового обслуживания города. Возможен" +
                            " поиск предприятий по заданным параметрам, а также внесение в базу новых предприятий. \nВыполнил:" +
                            " Михневич Д.К.\nст.гр ПЗПИ-19-1\n2020", "О программе");
        }

        //Выход из приложения по нажатию на соответсвующий пункт меню в разделе "Файл"
        private void ExitTStrMenu_Click(object sender, EventArgs e)
        {
            isFormClosingThroughMenuButton = true;
            DialogResult dialogResult = MessageBox.Show("Хотите ли вы сохранить найденные предприятия?",
               "Сохранение предприятия", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                DataBaseRepository.Save(foundCompanies, "searchResult.json");
            }
            Close();
        }
        //Поиск предприятий по нажатию на кнопку "Поиск"
        private void Findbtn_Click(object sender, EventArgs e)
        {
            if (!CheckTelephone())
            {
                MessageBox.Show("Некорректно введен номер телефона.",
                              "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CompanySearchParameter searchedCompany = FindSearchedCompany();
                var collection = CompanyCollection.Search(searchedCompany);
                bindListToDataGridView(collection);
                foundCompanies = collection;
                if (collection.Count == 0)
                {
                    MessageBox.Show("Предприятий по заданным параметрам не найдено.",
                    "Поиск", MessageBoxButtons.OK);
                    return;
                }
            }
        }
        //Сброс параметров для поиска по нажатию на кнопку "Сбросить"
        private void Resetbtn_Click(object sender, EventArgs e)
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
                    if (dtp.Name == "startDTPicker") dtp.Value = Convert.ToDateTime("01/01/1800 " + "00:00" + ":00.00");
                    else if (dtp.Name == "endDTPicker") dtp.Value = Convert.ToDateTime("01/01/1800 " + "23:59" + ":00.00");
                }
                else if (c is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)c;
                    for (int i = 0; i < clb.Items.Count; i++) clb.SetItemChecked(i, false);
                }
                else if (c is NumericUpDown)
                {
                    NumericUpDown num = (NumericUpDown)c;
                    num.Value = 0;
                }
            }
        }
        //При нажатии "Удалить" в контекстном меню
        private void DeleteTSM_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(dataGV[0, dataGV.SelectedRows[0].Index].Value);
                DialogResult dialogResult = MessageBox.Show("Вы уверены, " +
                    "что хотите удалить " + dataGV[1,
                    dataGV.SelectedRows[0].Index].Value + " ? ",
               "Удаление предприятия", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CompanyCollection.DeleteCompany(Convert.ToInt32(dataGV[0, dataGV.SelectedRows[0].Index].Value));
                    bindListToDataGridView(CompanyCollection.companies);
                }
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Выберите предприятие для удаления.",
                "Удаление предприятия", MessageBoxButtons.OK);
                return;
            }
            catch (KeyNotFoundException)
            {

                MessageBox.Show("Выберите предприятие для удаления.",
                "Удаление предприятия", MessageBoxButtons.OK);
                return;
            }
        }
        //Добавление предприятия по нажатию "Действия" - "Добавить"
        private void AddTStrMenu_Click(object sender, EventArgs e)
        {
            AddCompanyForm form = new AddCompanyForm();
            form.ShowDialog();
            bindListToDataGridView(CompanyCollection.companies);
        }
        //Показ информации о компании выбранной в списке компаний по нажатию на клавишу "ПОСМОТРЕТЬ"
        private void ShowTSM_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(dataGV[0, dataGV.SelectedRows[0].Index].Value);
                ChangeOrSeeCompanyForm form = new ChangeOrSeeCompanyForm(CompanyCollection.GetCompanyById
                        (Convert.ToInt32(dataGV[0, dataGV.SelectedRows[0].Index].Value)));
                form.Writable(false);
                form.ShowDialog();
                bindListToDataGridView(CompanyCollection.companies);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите предприятие для просмотра.",
                "Просмотр предприятия", MessageBoxButtons.OK);
                return;
            }
        }
        //Изменение выбранной компании в DataGridView по выбору в контекстном меню
        //"Изменить". Вызов формы для внесения изменений в выбранную компанию.
        private void ChangeTSM_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(dataGV[0, dataGV.SelectedRows[0].Index].Value);
                ChangeOrSeeCompanyForm form = new ChangeOrSeeCompanyForm(CompanyCollection.GetCompanyById(ID));

                form.Writable(false);
                form.ShowDialog();
                bindListToDataGridView(CompanyCollection.companies);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите предприятие для изменения.",
                "Изменение предприятия", MessageBoxButtons.OK);
                return;
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Выберите предприятие для изменения.",
                "Изменение предприятия", MessageBoxButtons.OK);
                return;
            }
        }
        private bool CheckTelephone()
        {
            string pattern = @"[3-9]{1}\d{8}";
            if (Regex.IsMatch(phoneNumberTBox.Text, pattern, RegexOptions.IgnoreCase)
                || phoneNumberTBox.Text.Length == 0)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        //Показ информации о форме по двойному клику по выбранной компании из списка
        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int ID = Convert.ToInt32(dataGV[0, e.RowIndex].Value);
            ChangeOrSeeCompanyForm form = new ChangeOrSeeCompanyForm(CompanyCollection.GetCompanyById(ID));
            form.Writable(false);
            form.ShowDialog();
            bindListToDataGridView(CompanyCollection.companies);
        }
        //Сохраняет заданные параметры для поиска компаниии
        private CompanySearchParameter FindSearchedCompany()
        {
            CompanySearchParameter searchedCompany = new CompanySearchParameter()
            {
                Name = nameTBox.Text,
                Category = (Category)Enum.Parse(typeof(Category), kindCBox.Text, true),
                Specialization = (Specialization)Enum.Parse(typeof(Specialization), specializationCBox.Text, true),
                Ownership = (OwnershipType)Enum.Parse(typeof(OwnershipType), ownershipCBox.Text, true),
                Contacts = new CompanyContactData()
                {
                    Addres = new Addres()
                    {
                        City = citytextBox.Text,
                        Street = streettextBox.Text,
                        HouseNumber = (int)houseNumber.Value
                    },
                    Telephone = phoneNumberTBox.Text
                }
            };
            var schedule = new List<CompanySchedule>();
            foreach (var el in workdaysGB.Controls)
            {
                CheckBox day = (CheckBox)el;
                if (day.Checked) schedule.Add(new CompanySchedule()
                {
                    Day = (Days)Enum.Parse(typeof(Days), day.Text, true),
                    StartWorkingTime = startDTPicker.Value,
                    EndWorkingTime = endDTPicker.Value
                });
            }
            searchedCompany.Schedules = schedule;
            var serv = new List<string>();
            foreach (var ch in servicesChLB.CheckedItems) serv.Add(ch.ToString());
            searchedCompany.Services = serv;
            return searchedCompany;
        }

        //Вызов контекстного меню по событию "Нажатие правой клавишей
        //мыши по выбранной компании в DataGridView"
        private void dataGridView_CellContextMenuStripNeeded(object sender,
            DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            dataGV[e.ColumnIndex, e.RowIndex].Selected = true;
            dataGV.ContextMenuStrip.Show(new System.Drawing.Point());
        }
        //Привязка данных к форме
        private void bindListToDataGridView(BindingList<Company> list)
        {
            var bindingList = list;
            var source = new BindingSource(bindingList, null);
            dataGV.DataSource = source;
        }
        //проверка на ввод начального времени
        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime startValue = endDTPicker.Value;
            startDTPicker.MaxDate = startValue.AddMinutes(-1);
            if (startDTPicker.MaxDate >= endDTPicker.Value)
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
            if (startDTPicker.Value >= endDTPicker.Value)
            {
                endDTPicker.Value = startDTPicker.Value.AddMinutes(1);
            }
        }
        //сохранение документа по клику "Файл", "Сохранить"
        private void SaveTStrMenu_Click(object sender, EventArgs e)
        {
            DataBaseRepository.Save(CompanyCollection.companies);
        }
        //сохранение при закрытии формы
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBaseRepository.Save(CompanyCollection.companies);
            if (!isFormClosingThroughMenuButton)
            {
                DialogResult dialogResult = MessageBox.Show("Хотите ли вы сохранить найденные предприятия?",
                 "Сохранение предприятия", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataBaseRepository.Save(foundCompanies, "searchResult.json");
                }
            }
        }

    }
}
