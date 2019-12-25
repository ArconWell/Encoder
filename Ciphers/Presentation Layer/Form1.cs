//Подключение библиотеки Ciphers 
using Ciphers;

//Подключение Material Skin
using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class cryptographyApp : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public cryptographyApp()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green600,
                Primary.Green500, Accent.Orange200, TextShade.WHITE);
        }

        private void msltfShift_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void mrbExecute_Click(object sender, EventArgs e)
        {
            string language;
            if (mrbRussian.Checked)
            {
                language = "Cyrillic";
            }
            else
            {
                if (mrbEnglish.Checked)
                {
                    language = "Latin";
                }
                else
                {
                    throw new Exception("Не выбран язык текста.");
                }
            }
            if (!mrbHack.Checked)
            {

                if (Int32.TryParse(msltfShift.Text, out int shift))
                {
                    if (shift > (GetLanguageAlphabetLength(language) - 1) || shift < 1)
                    {
                        MessageBox.Show("Сдвиг должен быть меньше длины алфавита и больше нуля.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Сдвиг должен быть меньше длины алфавита и больше нуля.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            CaesarCipher caesarCipher = new CaesarCipher();
            if (mrbEncrypt.Checked)
            {
                tbModifiedText.Text = caesarCipher.Encrypt(tbSourceText.Text, Int32.Parse(msltfShift.Text), language);
            }
            else
            {
                if (mrbDecrypt.Checked)
                {
                    tbModifiedText.Text = caesarCipher.Decrypt(tbSourceText.Text, Int32.Parse(msltfShift.Text), language);
                }
                else
                {
                    if (mrbHack.Checked)
                    {
                        tbModifiedText.Text = caesarCipher.Hack(tbSourceText.Text, language);
                    }
                }
            }
        }

        private int GetLanguageAlphabetLength(string language)
        {
            if (string.Compare(language, "Cyrillic", StringComparison.OrdinalIgnoreCase) == 0)
            {
                return 32;
            }
            else
            {
                if (string.Compare(language, "Latin", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return 26;
                }
                else
                {
                    throw new Exception("Несовместимый язык.");
                }
            }
        }

        string shift;
        private void mrbHack_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbHack.Checked)
            {
                shift = msltfShift.Text;
                msltfShift.Text = "";
                msltfShift.Enabled = false;

            }
            else
            {
                msltfShift.Text = shift;
                msltfShift.Enabled = true;
            }
        }

        private void mrbLightTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLightTheme.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                if (mrbGreen.Checked)
                {
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green600,
        Primary.Green500, Accent.Orange200, TextShade.WHITE);
                }
                else
                {
                    if (mrbLightBlue.Checked)
                    {
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
                    }
                    else
                    {
                        if (mrbGray.Checked)
                        {
                            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey600,
                                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                tbSourceText.BackColor = Color.White;
                tbModifiedText.BackColor = Color.White;
                gbActions.ForeColor = Color.Black;
                gbLanguage.ForeColor = Color.Black;
                gbTheme.ForeColor = Color.Black;
                gbAppLanguage.ForeColor = Color.Black;
                gbColorScheme.ForeColor = Color.Black;
                pbRightArrow.Image = Presentation_Layer.Properties.Resources.Right_Arrow_Black;
            }
        }

        private void mrbDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbDarkTheme.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                if (mrbGreen.Checked)
                {
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900,
            Primary.Green800, Accent.Orange200, TextShade.WHITE);
                }
                else
                {
                    if (mrbLightBlue.Checked)
                    {
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue700,
                Primary.Blue800, Accent.LightBlue200, TextShade.WHITE);
                    }
                    else
                    {
                        if (mrbGray.Checked)
                        {
                            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
    Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                tbSourceText.BackColor = Color.DimGray;
                tbModifiedText.BackColor = Color.DimGray;
                gbActions.ForeColor = Color.White;
                gbLanguage.ForeColor = Color.White;
                gbTheme.ForeColor = Color.White;
                gbAppLanguage.ForeColor = Color.White;
                gbColorScheme.ForeColor = Color.White;
                pbRightArrow.Image = Presentation_Layer.Properties.Resources.Right_Arrow_White;
            }
        }

        private void mrbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbGreen.Checked)
            {
                if (mrbLightTheme.Checked)
                {
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green600,
    Primary.Green500, Accent.Orange200, TextShade.WHITE);
                }
                else
                {
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900,
    Primary.Green800, Accent.Orange200, TextShade.WHITE);
                }
            }
        }

        private void mrbLightBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLightBlue.Checked)
            {
                if (mrbLightTheme.Checked)
                {
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500,
            Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
                }
                else
                {
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue800,
            Primary.Blue800, Accent.LightBlue200, TextShade.WHITE);
                }
            }
        }

        private void mrbGray_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbGray.Checked)
            {
                if (mrbLightTheme.Checked)
                {
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey600,
                        Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                }
                else
                {
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                }
            }

        }

        private void mrbRussianApp_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbRussianApp.Checked)
            {
                this.Text = "Криптография";
                this.Refresh();
                cipherCaesarPage.Text = "Шифр Цезаря";
                settingsPage.Text = "Настройки";
                materialTabSelector1.Refresh();
                gbTheme.Text = "Тема";
                mrbLightTheme.Text = "Светлая тема";
                mrbDarkTheme.Text = "Тёмная тема";
                gbColorScheme.Text = "Цвет интерфейса";
                mrbGreen.Text = "Зелёный";
                mrbLightBlue.Text = "Голубой";
                mrbGray.Text = "Серый";
                gbAppLanguage.Text = "Язык приложения";
                mrbRussianApp.Text = "Русский";
                mrbEnglishApp.Text = "Английский";
                mlbSourceText.Text = "Исходный текст";
                mlbProcessedText.Text = "Обработанный текст";
                gbActions.Text = "Действия";
                gbLanguage.Text = "Язык";
                mrbEncrypt.Text = "Зашифровать";
                mrbDecrypt.Text = "Расшифровать";
                mrbHack.Text = "Взломать";
                mrbRussian.Text = "Русский";
                mrbEnglish.Text = "Английский";
                msltfShift.Hint = "Сдвиг";
                mrbExecute.Text = "Выполнить";
                mfbSpravka.Text = "Справка";
            }
        }

        private void mrbEnglishApp_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbEnglishApp.Checked)
            {
                this.Text = "Cryptography";
                this.Refresh();
                cipherCaesarPage.Text = "Caesar Cipher";
                settingsPage.Text = "Settings";
                materialTabSelector1.Refresh();
                gbTheme.Text = "Theme";
                mrbLightTheme.Text = "Light theme";
                mrbDarkTheme.Text = "Dark theme";
                gbColorScheme.Text = "Interface color";
                mrbGreen.Text = "Green";
                mrbLightBlue.Text = "Light blue";
                mrbGray.Text = "Gray";
                gbAppLanguage.Text = "App language";
                mrbRussianApp.Text = "Russian";
                mrbEnglishApp.Text = "English";
                mlbSourceText.Text = "Source text";
                mlbProcessedText.Text = "Processed text";
                gbActions.Text = "Actions";
                gbLanguage.Text = "Language";
                mrbEncrypt.Text = "Encrypt";
                mrbDecrypt.Text = "Decrypt";
                mrbHack.Text = "Hack";
                mrbRussian.Text = "Russian";
                mrbEnglish.Text = "English";
                msltfShift.Hint = "Shift";
                mrbExecute.Text = "Execute";
                mfbSpravka.Text = "Help";
            }
        }

        private void cryptographyApp_Load(object sender, EventArgs e)
        {
            if (string.Compare((string)Properties.Settings.Default["Theme"], "LIGHT", StringComparison.OrdinalIgnoreCase) == 0)
            {
                mrbLightTheme.Checked = true;
                mrbLightTheme_CheckedChanged(new object(), new EventArgs());
                if (string.Compare((string)Properties.Settings.Default["ColorScheme"], "Green", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    mrbGreen.Checked = true;
                    mrbGreen_CheckedChanged(new object(), new EventArgs());
                }
                else
                {
                    if (string.Compare((string)Properties.Settings.Default["ColorScheme"], "LightBlue", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        mrbLightBlue.Checked = true;
                        mrbLightBlue_CheckedChanged(new object(), new EventArgs());
                    }
                    else
                    {
                        if (string.Compare((string)Properties.Settings.Default["ColorScheme"], "Gray", StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            mrbGray.Checked = true;
                            mrbGray_CheckedChanged(new object(), new EventArgs());
                        }
                    }
                }
            }
            else
            {
                if (string.Compare((string)Properties.Settings.Default["Theme"], "DARK", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    mrbDarkTheme.Checked = true;
                    mrbDarkTheme_CheckedChanged(new object(), new EventArgs());
                    if (string.Compare((string)Properties.Settings.Default["ColorScheme"], "Green", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        mrbGreen.Checked = true;
                        mrbGreen_CheckedChanged(new object(), new EventArgs());
                    }
                    else if (string.Compare((string)Properties.Settings.Default["ColorScheme"], "LightBlue", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        mrbLightBlue.Checked = true;
                        mrbLightBlue_CheckedChanged(new object(), new EventArgs());
                    }
                    else
                    {
                        if (string.Compare((string)Properties.Settings.Default["ColorScheme"], "Gray", StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            mrbGray.Checked = true;
                            mrbGray_CheckedChanged(new object(), new EventArgs());
                        }
                    }
                }
            }
            if (string.Compare((string)Properties.Settings.Default["AppLanguage"], "Russian", StringComparison.OrdinalIgnoreCase) == 0)
            {
                mrbRussianApp.Checked = true;
                mrbRussianApp_CheckedChanged(new object(), new EventArgs());
            }
            else
            {
                if (string.Compare((string)Properties.Settings.Default["AppLanguage"], "English", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    mrbEnglishApp.Checked = true;
                    mrbEnglishApp_CheckedChanged(new object(), new EventArgs());
                }
            }
        }

        private void cryptographyApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            string theme;
            if (mrbLightTheme.Checked)
                theme = "LIGHT";
            else
                if (mrbDarkTheme.Checked)
                theme = "DARK";
            else
                throw new Exception();
            string colorScheme;
            if (mrbGreen.Checked)
                colorScheme = "Green";
            else
                if (mrbLightBlue.Checked)
                colorScheme = "LightBlue";
            else
                if (mrbGray.Checked)
                colorScheme = "Gray";
            else
                throw new Exception();
            string appLanguage;
            if (mrbRussianApp.Checked)
                appLanguage = "Russian";
            else
                if (mrbEnglishApp.Checked)
                appLanguage = "English";
            else
                throw new Exception();
            Properties.Settings.Default["Theme"] = theme;
            Properties.Settings.Default["ColorScheme"] = colorScheme;
            Properties.Settings.Default["AppLanguage"] = appLanguage;
            Properties.Settings.Default.Save();
        }

        private void mfbSpravka_Click(object sender, EventArgs e)
        {
            
            Help.ShowHelp(this, @"E:\Other\Рабочий стол\Институт\Курсовая работа. Визуальное программирование. 5 семестр\Ciphers\Presentation Layer\Resources\CiphersHelp.chm");
        }
    }
}
