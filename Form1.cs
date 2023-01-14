using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Newtonsoft.Json;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Net;

namespace RGR
{
    public partial class Form1 : Form
    {
        private static readonly string _logsPath = @"C:\Users\igor_2\Desktop\уЧеба_3курс\.net\лабы\RGR\Logs.txt";
        public Form1()
        {
            InitializeComponent();
            
            checkBoxIsDead.Checked = !checkBoxIsDead.Checked;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "writersDBDataSet.writers". При необходимости она может быть перемещена или удалена.
            this.writersTableAdapter.Fill(this.writersDBDataSet.writers);
            groupBox.Enabled = false;

            if (sender is BackgroundWorker)
            {
                var eventArgs = e as RunWorkerCompletedEventArgs;
                if (eventArgs.Error == null)
                    toolStripStatusLabel.Text = "Данные успешно загружены";

                else
                {
                    string errorText = "";
                    string toolStripText = "";

                    if (eventArgs.Error.InnerException is SqlException)
                    {
                        errorText = "Ошибка при работе с базой данных. Подробности в файле Logs.txt";
                        toolStripText = "Произошла ошибка при работе с базой данных";
                    }
                    else if (eventArgs.Error.InnerException is WebException)
                    {
                        errorText = "Не удалось загрузить информацию с ресурса. Подробности в файле Logs.txt";
                        toolStripText = "Произошла ошибка при загрузке данных";
                    }
                    else
                    {
                        errorText = "Непредвиденная ошибка. Подробности в файле Logs.txt";
                        toolStripText = "Непредвиденная ошибка";
                    }

                    toolStripStatusLabel.Text = toolStripText;
                    MessageBox.Show(errorText, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                writersDataGridView.Enabled = true;
                writersBindingNavigator.Enabled = true;

            }

        }

        private void writersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.writersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.writersDBDataSet);
            toolStripStatusLabel.Text = "Сохранение успешно";
        }

        private void writersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            writersDataGridView.CurrentRow.ErrorText = "Не выбран никакой элемент";
        }

        private void writersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = writersBindingSource.Current as DataRowView;

            if (dataRow == null)
                return;

            var writersRow = dataRow.Row as writersDBDataSet.writersRow;

            if (writersRow == null || writersRow.RowState == DataRowState.Detached)
                return;

            try
            {
                textBoxName.Text = writersRow.writer_first_name;
                textBoxSurname.Text = writersRow.writer_last_name;
                dateTimePickerBirthDate.Value = writersRow.writer_birthDate;

                if (writersRow.Iswriter_deathDateNull())
                    checkBoxIsDead.Checked = false;
                else
                {
                    dateTimePickerDeathDate.Value = writersRow.writer_deathDate;
                    checkBoxIsDead.Checked = true;
                }

                //textBoxGender.Text = writersRow.writer_gender;
                comboBoxGender.SelectedItem = writersRow.writer_gender;
                textBoxBirthPlace.Text = writersRow.Iswriter_birthPlaceNull() ? "" : writersRow.writer_birthPlace;
                textBoxJobTitle.Text = writersRow.writer_jobTitle;

                if (writersRow.Iswriter_imageNull())
                    pictureBox.Image = default;

                else
                {
                    using (MemoryStream ms = new MemoryStream(writersRow.writer_image))
                        pictureBox.Image = Image.FromStream(ms, true, true);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                File.AppendAllText(_logsPath, $"{DateTime.Now} {exception.Message}\r\n{exception.StackTrace}\r\n\r\n");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool isValid = groupBox.Validate(textBoxName, textBoxSurname, textBoxJobTitle, textBoxBirthPlace); ;

            if (!isValid)
            {
                MessageBox.Show("Одно из значений было не верным");
                return;
            }

            foreach (DataGridViewRow row in writersDataGridView.Rows)
            {

                try
                {
                    DateTime dateTime;

                    DateTime.TryParse(row.Cells[dataGridViewTextBoxColumnBirthDate.Name].Value.ToString(), out dateTime);
                    if (dateTime.Date == dateTimePickerBirthDate.Value.Date)
                    {
                        if (row.Cells[dataGridViewTextBoxColumnSurname.Name].Value.ToString() == textBoxSurname.Text)
                        {
                            MessageBox.Show("Такой автор есть уже в базе данных", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла непредвиденная ошибка");
                    File.AppendAllText(_logsPath, $"{DateTime.Now} {ex.Message}\r\n{ex.StackTrace}\r\n\r\n");
                }


            }
            try
            {
                DataRowView dataRow = writersBindingSource.Current as DataRowView;
                writersDBDataSet.writersRow writersRow = dataRow.Row as writersDBDataSet.writersRow;



                writersRow.writer_first_name = textBoxName.Text;
                writersRow.writer_last_name = textBoxSurname.Text;
                writersRow.writer_birthDate = dateTimePickerBirthDate.Value;

                if (checkBoxIsDead.Checked)
                    writersRow.writer_deathDate = dateTimePickerDeathDate.Value.Date;

                else
                    writersRow.Setwriter_deathDateNull();

                writersRow.writer_gender = (string)comboBoxGender.SelectedItem;//textBoxGender.Text;
                writersRow.writer_birthPlace = textBoxBirthPlace.Text;
                writersRow.writer_jobTitle = textBoxJobTitle.Text;

                ImageConverter imageConverter = new ImageConverter();
                byte[] imageBytes = (byte[])imageConverter.ConvertTo(pictureBox.Image, typeof(byte[]));
                writersRow.writer_image = (byte[])imageConverter.ConvertTo(pictureBox.Image, typeof(byte[]));

                writersRow.writer_image = (imageBytes.Length == 0 || imageBytes == null) ? null : imageBytes;
                toolStripStatusLabel.Text = "Изменения внесены успешно";
            }
            catch (Exception ex)
            {
                File.AppendAllText(_logsPath, $"{DateTime.Now} {ex.Message}\r\n{ex.StackTrace}\r\n\r\n");
                toolStripStatusLabel.Text = "Ошибка при изменении данных";
            }
            finally
            {
                writersDataGridView.Enabled = true;
                writersBindingNavigator.Enabled = true;
                groupBox.Enabled = false;
            }
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            this.writersTableAdapter.Fill(this.writersDBDataSet.writers);
            toolStripStatusLabel.Text = "Обновление успешно";
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            writersDataGridView.Enabled = false;
            writersBindingNavigator.Enabled = false;
            groupBox.Enabled = true;
            toolStripStatusLabel.Text = "Редактирование";

            writersBindingSource.ResetCurrentItem();

        }

        private void toolStripButtonLoadInternet_Click(object sender, EventArgs e)
        {
            DBWorker dBWorker = DBWorker.GetInstanse();
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += dBWorker.LoadInformamtion;
            backgroundWorker.RunWorkerCompleted += FormMain_Load;
            backgroundWorker.RunWorkerAsync();
            toolStripStatusLabel.Text = "Происходит загрузка";
            writersDataGridView.Enabled = false;
            writersBindingNavigator.Enabled = false;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            labelPicture.Location = new Point(splitContainer1.Panel2.Width / 2 - labelPicture.Width / 2, labelPicture.Location.Y);
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, "Строка не должна быть пустой!");
                errorProvider.SetIconAlignment(textBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetIconPadding(textBox, textBox.Width / 20);
            }
            else if (textBox.Text.Length > DBWorker.TextSize)
            {
                errorProvider.SetError(textBox, "Слишком много символов!");
                errorProvider.SetIconAlignment(textBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetIconPadding(textBox, textBox.Width / 20);
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            comboBoxGender.SelectedIndex = 1;
            textBoxBirthPlace.Clear();
            textBoxJobTitle.Clear();
            pictureBox.Image = null;
            writersDataGridView.Enabled = false;
            writersBindingNavigator.Enabled = false;

            groupBox.Enabled = true;

            toolStripStatusLabel.Text = "Добавление нового элемента";

            //добавление
            //прогрузка следующего элемента

            // довыгрузка с интернета, сохранение, тестирование, повторная загрузка,
            //контекстное меню для загрузки изобрадения. Смены энабле дизабле. Тестирование программы, обработка исключений
        }


        private void checkBoxIsDead_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsDead.Checked)
                dateTimePickerDeathDate.Show();
            else
                dateTimePickerDeathDate.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(writersDataGridView.CurrentRow.Cells[0].Value as string))
                writersDataGridView.Rows.Remove(writersDataGridView.CurrentRow);

            writersDataGridView.Invoke((Action<object, EventArgs>)writersDataGridView_SelectionChanged, writersDataGridView, null);
            textBoxJobTitle.Focus();
            textBoxBirthPlace.Focus();

            textBoxName.Focus();
            textBoxSurname.Focus();

            writersDataGridView.Enabled = true;
            writersBindingNavigator.Enabled = true;
            groupBox.Enabled = false;
            toolStripStatusLabel.Text = "Просмотр данных";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void удалитьКартинкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void загрузитьКартинкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
