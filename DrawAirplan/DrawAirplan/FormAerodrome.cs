using System;
using NLog;
using System.Drawing;
using System.Windows.Forms;

namespace DrawAirplan
{
    public partial class FormAerodrome : Form
    {

        private readonly AerodromeCollection aerodromeCollection;

        private readonly Logger logger;

        public FormAerodrome()
        {
            InitializeComponent();
            aerodromeCollection = new AerodromeCollection(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            logger = LogManager.GetCurrentClassLogger();
        }

        private void ReloadLevels()
        {
            int index = listBoxAerodromes.SelectedIndex;
            listBoxAerodromes.Items.Clear();
            for (int i = 0; i < aerodromeCollection.Keys.Count; i++)
            {
                listBoxAerodromes.Items.Add(aerodromeCollection.Keys[i]);
            }
            if (listBoxAerodromes.Items.Count > 0 && (index == -1 || index >=
listBoxAerodromes.Items.Count))
            {
                listBoxAerodromes.SelectedIndex = 0;
            }
            else if (listBoxAerodromes.Items.Count > 0 && index > -1 && index <
listBoxAerodromes.Items.Count)
            {
                listBoxAerodromes.SelectedIndex = index;
            }
        }


        private void Draw()
        {           
            if (listBoxAerodromes.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
                Graphics gr = Graphics.FromImage(bmp);
                aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()].Draw(gr);
                pictureBoxAerodrome.Image = bmp;
            }
        }

        private void buttonAddAerodrome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название аэродрома", "Ошибка",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили аэродром {textBoxNewLevelName.Text}");
            aerodromeCollection.AddAerodrome(textBoxNewLevelName.Text);
            textBoxNewLevelName.Text = "";
            ReloadLevels();
        }

        private void buttonDeleteAerodrome_Click(object sender, EventArgs e)
        {
            if (listBoxAerodromes.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить аэродром {listBoxAerodromes.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили аэродром{ listBoxAerodromes.SelectedItem.ToString()}");
                    aerodromeCollection.DelAerodrome(listBoxAerodromes.Text);
                    ReloadLevels();
                }
            }
        }

        private void buttonTakeAircraft_Click(object sender, EventArgs e)
        {
            if (listBoxAerodromes.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                try
                {
                    var aircraft = aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (aircraft != null)
                    {
                        FormAircraft form = new FormAircraft();
                        form.SetAircraft(aircraft);
                        form.ShowDialog();
                        logger.Info($"Изъят самолёт {aircraft} с места{ maskedTextBox.Text}");
                        Draw();
                    }
                }
                catch (AerodromeNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message}");
                }

            }
        }

        private void listBoxAerodromes_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку { listBoxAerodromes.SelectedItem.ToString()}");
            Draw();
        }

        private void buttonSetAircraft_Click(object sender, EventArgs e)
        {
            var formAircraftConfig = new FormAircraftConfig();
            formAircraftConfig.AddEvent(AddAircraft);
            formAircraftConfig.Show();
        }

        private void AddAircraft(Vehicle aircraft)
        {
            if (aircraft != null && listBoxAerodromes.SelectedIndex > -1)
            {
                try
                {
                    if ((aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()]) + aircraft)
                    {
                        Draw();
                        logger.Info($"Добавлен самолёт {aircraft}");
                    }
                    else
                    {
                        MessageBox.Show("Самолёт не удалось посадить");
                        logger.Warn("Самолёт не удалось посадить");
                    }
                    Draw();
                }
                catch (AerodromeOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message}");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    aerodromeCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message}");
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    aerodromeCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (AerodromeOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message}");
                }
            }
        }
    }
}
