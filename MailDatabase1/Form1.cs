using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailDatabase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool edit = false;
        object editMode;
        bool cellSelect = false;
        MailDatabaseDataSet.CitiesDataTable cities;
        MailDatabaseDataSet.OrdersCityDataTable orders;
        MailDatabaseDataSet.OrdersDataTable ordersMoreInfo;
        MailDatabaseDataSet.Type_of_servicesDataTable types;
        MailDatabaseDataSet.OrdersRow rowInfo;

        /// <summary>
        /// Подсчет количества записей в таблице
        /// </summary>
        private void entryCountUpdate()
        {
            rowsCountOutput.Text = "Количество записей: " + (ordersDataView.Rows.Count - 1).ToString() + " из " + orders.Count.ToString();
        }

        /// <summary>
        /// Обновление данных в форме
        /// </summary>
        /// <param name="row">Строка с данными</param>
        private void descriptionEntryOutput(MailDatabaseDataSet.OrdersRow row)
        {
            if (citiesInputBox.Items.Count > 0) citiesInputBox.Items.Clear();
            if (typeInputBox.Items.Count > 0) typeInputBox.Items.Clear();
            statusBox.Items.Clear();
            foreach (TextBox i in entryEditPanel.Controls.OfType<TextBox>())
            {
                i.Text = "";
            }
            descriptionBox.Text = "";

            if (!row.IsCity_of_departureNull())
            {
                citiesInputBox.Items.Add(cities.FindByID(row.City_of_departure).Name_of_city);
                citiesInputBox.SelectedIndex = 0;
            }
            if (!row.IsDate_of_serviceNull()) dateTimeService.Value = row.Date_of_service;
            if (!row.IsClient_adressNull()) adressBox.Text = row.Client_adress;
            if (!row.IsSurnameNull() || !row.IsSurnameNull() || !row.IsSurnameNull()) fioBox.Text = $"{row.Surname} {row.Name} {row.Lastname}";
            if (!row.IsNumber_of_days_to_completeNull()) daysCountBox.Text = row.Number_of_days_to_complete.ToString();
            if (!row.IsType_of_serviceNull())
            {
                typeInputBox.Items.Add(types.FindByID(row.Type_of_service).Types);
                typeInputBox.SelectedIndex = 0;
            }
            if (!row.IsWeightNull()) weightBox.Text = row.Weight.ToString();
            if (!row.IsService_priceNull()) priceBox.Text = row.Service_price.ToString();
            if (!row.IsService_execution_statusNull())
            {
                statusBox.Items.Add(row.Service_execution_status);
                statusBox.SelectedIndex = 0;
            }
            if (!row.IsService_descriptionNull()) descriptionBox.Text = row.Service_description;
        }

        /// <summary>
        /// Обновляет данные таблицы
        /// </summary>
        private void dataViewUpdate()
        {
            orders = ordersCityTableAdapter1.GetData();
            ordersMoreInfo = ordersTableAdapter1.GetData();
            ordersDataView.DataSource = orders;
        }

        /// <summary>
        /// Меняет интерфейс для редактирования записей
        /// </summary>
        /// <param name="edit">Режим редактирования</param>
        private void winModeChange(bool edit, object mode)
        {
            if (edit)
            {
                citiesInputBox.Items.Clear();
                typeInputBox.Items.Clear();
                statusBox.Items.Clear();
                ordersDataView.Enabled = false;
                filtersPanel.Enabled = false;
                entryEditPanel.Enabled = true;
                deleteBtn.Enabled = false;
                addBtn.BackColor = Color.Green;
                addBtn.Text = "Сохранить";
                editBtn.BackColor = Color.Red;
                editBtn.Text = "Отмена";
                string[] citiesRange = new string[4];
                string[] typesRange = new string[types.Rows.Count];
                for (int i = 0; i < cities.Rows.Count; i++)
                {
                    citiesRange[i] = cities.Rows[i].ItemArray[1].ToString();
                }
                for (int i = 0; i < types.Rows.Count; i++)
                {
                    typesRange[i] = types.Rows[i].ItemArray[1].ToString();
                }
                citiesInputBox.Items.AddRange(citiesRange);
                citiesInputBox.SelectedIndex = 0;
                typeInputBox.Items.AddRange(typesRange);
                typeInputBox.SelectedIndex = 0;

                statusBox.Items.AddRange(new string[4] { "Доставленно", "В пути", "Прибыла", "Потерянно" });
                statusBox.SelectedIndex = 0;
                if (mode == addBtn)
                {
                    if (mode == addBtn)
                    {
                        foreach (TextBox i in entryEditPanel.Controls.OfType<TextBox>())
                        {
                            i.Text = "";
                        }
                    }
                }
            }
            else
            {
                ordersDataView.Enabled = true;
                filtersPanel.Enabled = true;
                entryEditPanel.Enabled = false;
                deleteBtn.Enabled = true;
                addBtn.BackColor = Color.Ivory;
                addBtn.Text = "Добавить";
                editBtn.BackColor = Color.Ivory;
                editBtn.Text = "Редактировать";
            }
        }

        /// <summary>
        /// Создание новой записи
        /// </summary>
        private void addNewEntry()
        {
            try
            {
                ordersTableAdapter1.Insert(
                    citiesInputBox.SelectedIndex + 1,
                    fioBox.Text.Split(' ')[0],
                    fioBox.Text.Split(' ')[1],
                    fioBox.Text.Split(' ')[2],
                    adressBox.Text,
                    typeInputBox.SelectedIndex + 1,
                    dateTimeService.Value,
                    Convert.ToInt32(daysCountBox.Text),
                    Convert.ToDecimal(priceBox.Text),
                    Convert.ToInt32(weightBox.Text),
                    statusBox.Text,
                    null,
                    descriptionBox.Text
                    );
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
                return;
            }
            MessageBox.Show("Запись успешно добавлена");
        }

        /// <summary>
        /// Редактирование записей
        /// </summary>
        private void editEntry()
        {
            try
            {
                var row = ordersMoreInfo.FindByOrder_number(rowInfo.Order_number);
                row.City_of_departure = citiesInputBox.SelectedIndex + 1;
                row.Surname = fioBox.Text.Split(' ')[0];
                row.Name = fioBox.Text.Split(' ')[1];
                row.Lastname = fioBox.Text.Split(' ')[2];
                row.Client_adress = adressBox.Text;
                row.Type_of_service = typeInputBox.SelectedIndex + 1;
                row.Date_of_service = dateTimeService.Value;
                row.Number_of_days_to_complete = Convert.ToInt32(daysCountBox.Text);
                row.Service_price = Convert.ToDecimal(priceBox.Text);
                row.Weight = Convert.ToInt32(weightBox.Text);
                row.Service_execution_status = statusBox.Text;
                row.Service_description = descriptionBox.Text;
                ordersTableAdapter1.Update(row);
            }
            catch
            {
                MessageBox.Show("Произошла неизвестная ошибка");
            }

            dataViewUpdate();

        }


        // События
        private void Form1_Load(object sender, EventArgs e)
        {
            cities = citiesTableAdapter1.GetData();
            types = type_of_servicesTableAdapter1.GetData();

            dataViewUpdate();
            ordersDataView.EditMode = DataGridViewEditMode.EditProgrammatically;
            ordersDataView.Columns[6].Visible = false;
            ordersDataView.Columns[0].HeaderText = "Город";
            ordersDataView.Columns[1].HeaderText = "Фамилия";
            ordersDataView.Columns[2].HeaderText = "Имя";
            ordersDataView.Columns[3].HeaderText = "Отчество";
            ordersDataView.Columns[4].HeaderText = "Статус";
            ordersDataView.Columns[5].HeaderText = "Дата отправки";

            citiesList.DataSource = cities;
            citiesList.DisplayMember = "Name of city";
            citiesList.ValueMember = "ID";

            rowInfo = ordersMoreInfo.First();
            descriptionEntryOutput(rowInfo);
            entryCountUpdate();
        }

        private void ordersDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowInfo = ordersMoreInfo.FindByOrder_number(Convert.ToInt32(ordersDataView.Rows[e.RowIndex].Cells[6].Value));
                if (e.RowIndex == ordersDataView.Rows.Count - 1) return;
            }
            catch {
                MessageBox.Show("Ошибка вывода информации о пользователе");
                return;
            }

            cellSelect = true;
            descriptionEntryOutput(rowInfo);
        }

        private void citiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!filterCheck.Checked) return;

            string city = citiesList.Text;
            var filter = orders.Where(result => result.Name_of_city == city);
            if (filter.Count() != 0)
            {
                this.ordersDataView.DataSource = filter.CopyToDataTable();
            }

            entryCountUpdate();
        }

        private void filterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (filterCheck.Checked) { citiesList_SelectedIndexChanged(sender, null); }
            else ordersDataView.DataSource = orders;

            entryCountUpdate();
        }

        private void filterInputName_TextChanged(object sender, EventArgs e)
        {
            filterCheck.Checked = false;
            string name = filterInputName.Text.ToLower();

            var filter = orders.Where(result =>
            (result.Surname.ToString().ToLower() + " " + result.Name.ToString().ToLower() + " " +
            result.Lastname.ToString().ToLower()).Contains(name)
            );

            if (filter.Count() != 0)
            {
                this.ordersDataView.DataSource = filter.CopyToDataTable();
            }
            else
            {
                this.ordersDataView.DataSource = orders;
            }
            entryCountUpdate();
        }

        private void entryBtnChangeMode_Click(object sender, EventArgs e)
        {
            winModeChange(!edit, sender);
            if (!edit)
            {
                edit = true;
                editMode = sender;
            }
            else
            {
                edit = false;
                if (sender == addBtn)
                {
                    if (editMode == addBtn) addNewEntry();
                    else editEntry();
                    dataViewUpdate();
                    entryCountUpdate();
                }
                else
                {
                    descriptionEntryOutput(rowInfo);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!cellSelect)
            {
                MessageBox.Show("Выберите запись для удаления");
                return;
            }

            DialogResult delete = MessageBox.Show($"Вы уверены что хотите удалить данные о\nпочтовой доставки для {rowInfo.Surname}а {rowInfo.Name}а?", "Удаление элемента", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete.ToString() == "Yes")
            {
                ordersTableAdapter1.DeleteById(rowInfo.Order_number);
                MessageBox.Show("Запись успешно удалена");
                cellSelect = false;
            }
            dataViewUpdate();
            entryCountUpdate();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string path = Application.StartupPath;
            string pathSource = path + @"\MailDatabase.mdb";
            string pathDest = path.Remove(path.Length - 10);
            pathDest = pathDest + @"\MailDatabase.mdb";
            File.Delete(pathDest);
            File.Copy(pathSource, pathDest);
            this.Close();
        }

        
    }

}
