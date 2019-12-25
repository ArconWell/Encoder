namespace Presentation_Layer
{
    partial class cryptographyApp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cipherCaesarPage = new System.Windows.Forms.TabPage();
            this.msltfShift = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mrbExecute = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.mrbEnglish = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbRussian = new MaterialSkin.Controls.MaterialRadioButton();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.mrbHack = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbDecrypt = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbEncrypt = new MaterialSkin.Controls.MaterialRadioButton();
            this.mlbProcessedText = new MaterialSkin.Controls.MaterialLabel();
            this.mlbSourceText = new MaterialSkin.Controls.MaterialLabel();
            this.pbRightArrow = new System.Windows.Forms.PictureBox();
            this.tbModifiedText = new System.Windows.Forms.TextBox();
            this.tbSourceText = new System.Windows.Forms.TextBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.gbAppLanguage = new System.Windows.Forms.GroupBox();
            this.mrbEnglishApp = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbRussianApp = new MaterialSkin.Controls.MaterialRadioButton();
            this.gbColorScheme = new System.Windows.Forms.GroupBox();
            this.mrbGray = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbLightBlue = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbGreen = new MaterialSkin.Controls.MaterialRadioButton();
            this.gbTheme = new System.Windows.Forms.GroupBox();
            this.mrbDarkTheme = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbLightTheme = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.mfbSpravka = new MaterialSkin.Controls.MaterialFlatButton();
            this.cipherCaesarPage.SuspendLayout();
            this.gbLanguage.SuspendLayout();
            this.gbActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightArrow)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.gbAppLanguage.SuspendLayout();
            this.gbColorScheme.SuspendLayout();
            this.gbTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // cipherCaesarPage
            // 
            this.cipherCaesarPage.BackColor = System.Drawing.Color.White;
            this.cipherCaesarPage.Controls.Add(this.msltfShift);
            this.cipherCaesarPage.Controls.Add(this.mrbExecute);
            this.cipherCaesarPage.Controls.Add(this.gbLanguage);
            this.cipherCaesarPage.Controls.Add(this.gbActions);
            this.cipherCaesarPage.Controls.Add(this.mlbProcessedText);
            this.cipherCaesarPage.Controls.Add(this.mlbSourceText);
            this.cipherCaesarPage.Controls.Add(this.pbRightArrow);
            this.cipherCaesarPage.Controls.Add(this.tbModifiedText);
            this.cipherCaesarPage.Controls.Add(this.tbSourceText);
            this.cipherCaesarPage.Location = new System.Drawing.Point(4, 22);
            this.cipherCaesarPage.Name = "cipherCaesarPage";
            this.cipherCaesarPage.Padding = new System.Windows.Forms.Padding(3);
            this.cipherCaesarPage.Size = new System.Drawing.Size(883, 418);
            this.cipherCaesarPage.TabIndex = 0;
            this.cipherCaesarPage.Text = "Шифр Цезаря";
            // 
            // msltfShift
            // 
            this.msltfShift.Depth = 0;
            this.msltfShift.Hint = "Сдвиг";
            this.msltfShift.Location = new System.Drawing.Point(343, 384);
            this.msltfShift.MaxLength = 2;
            this.msltfShift.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltfShift.Name = "msltfShift";
            this.msltfShift.PasswordChar = '\0';
            this.msltfShift.SelectedText = "";
            this.msltfShift.SelectionLength = 0;
            this.msltfShift.SelectionStart = 0;
            this.msltfShift.Size = new System.Drawing.Size(75, 23);
            this.msltfShift.TabIndex = 13;
            this.msltfShift.TabStop = false;
            this.msltfShift.UseSystemPasswordChar = false;
            this.msltfShift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msltfShift_KeyPress);
            // 
            // mrbExecute
            // 
            this.mrbExecute.AutoSize = true;
            this.mrbExecute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mrbExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mrbExecute.Depth = 0;
            this.mrbExecute.Icon = null;
            this.mrbExecute.Location = new System.Drawing.Point(434, 379);
            this.mrbExecute.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbExecute.Name = "mrbExecute";
            this.mrbExecute.Primary = true;
            this.mrbExecute.Size = new System.Drawing.Size(107, 36);
            this.mrbExecute.TabIndex = 12;
            this.mrbExecute.TabStop = false;
            this.mrbExecute.Text = "Выполнить";
            this.mrbExecute.UseVisualStyleBackColor = true;
            this.mrbExecute.Click += new System.EventHandler(this.mrbExecute_Click);
            // 
            // gbLanguage
            // 
            this.gbLanguage.Controls.Add(this.mrbEnglish);
            this.gbLanguage.Controls.Add(this.mrbRussian);
            this.gbLanguage.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbLanguage.Location = new System.Drawing.Point(338, 270);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Size = new System.Drawing.Size(208, 94);
            this.gbLanguage.TabIndex = 7;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Язык";
            // 
            // mrbEnglish
            // 
            this.mrbEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mrbEnglish.Depth = 0;
            this.mrbEnglish.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbEnglish.Location = new System.Drawing.Point(5, 59);
            this.mrbEnglish.Margin = new System.Windows.Forms.Padding(0);
            this.mrbEnglish.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbEnglish.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbEnglish.Name = "mrbEnglish";
            this.mrbEnglish.Ripple = true;
            this.mrbEnglish.Size = new System.Drawing.Size(198, 30);
            this.mrbEnglish.TabIndex = 1;
            this.mrbEnglish.Text = "Английский";
            this.mrbEnglish.UseVisualStyleBackColor = true;
            // 
            // mrbRussian
            // 
            this.mrbRussian.Checked = true;
            this.mrbRussian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mrbRussian.Depth = 0;
            this.mrbRussian.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbRussian.Location = new System.Drawing.Point(5, 20);
            this.mrbRussian.Margin = new System.Windows.Forms.Padding(0);
            this.mrbRussian.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbRussian.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbRussian.Name = "mrbRussian";
            this.mrbRussian.Ripple = true;
            this.mrbRussian.Size = new System.Drawing.Size(198, 30);
            this.mrbRussian.TabIndex = 0;
            this.mrbRussian.TabStop = true;
            this.mrbRussian.Text = "Русский";
            this.mrbRussian.UseVisualStyleBackColor = true;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.mrbHack);
            this.gbActions.Controls.Add(this.mrbDecrypt);
            this.gbActions.Controls.Add(this.mrbEncrypt);
            this.gbActions.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbActions.Location = new System.Drawing.Point(338, 65);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(208, 104);
            this.gbActions.TabIndex = 6;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Действия";
            // 
            // mrbHack
            // 
            this.mrbHack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mrbHack.Depth = 0;
            this.mrbHack.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbHack.Location = new System.Drawing.Point(5, 76);
            this.mrbHack.Margin = new System.Windows.Forms.Padding(0);
            this.mrbHack.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbHack.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbHack.Name = "mrbHack";
            this.mrbHack.Ripple = true;
            this.mrbHack.Size = new System.Drawing.Size(198, 20);
            this.mrbHack.TabIndex = 2;
            this.mrbHack.Text = "Взломать";
            this.mrbHack.UseVisualStyleBackColor = true;
            this.mrbHack.CheckedChanged += new System.EventHandler(this.mrbHack_CheckedChanged);
            // 
            // mrbDecrypt
            // 
            this.mrbDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mrbDecrypt.Depth = 0;
            this.mrbDecrypt.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbDecrypt.Location = new System.Drawing.Point(5, 48);
            this.mrbDecrypt.Margin = new System.Windows.Forms.Padding(0);
            this.mrbDecrypt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbDecrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbDecrypt.Name = "mrbDecrypt";
            this.mrbDecrypt.Ripple = true;
            this.mrbDecrypt.Size = new System.Drawing.Size(198, 20);
            this.mrbDecrypt.TabIndex = 1;
            this.mrbDecrypt.Text = "Расшифровать";
            this.mrbDecrypt.UseVisualStyleBackColor = true;
            // 
            // mrbEncrypt
            // 
            this.mrbEncrypt.Checked = true;
            this.mrbEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mrbEncrypt.Depth = 0;
            this.mrbEncrypt.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbEncrypt.Location = new System.Drawing.Point(5, 20);
            this.mrbEncrypt.Margin = new System.Windows.Forms.Padding(0);
            this.mrbEncrypt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbEncrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbEncrypt.Name = "mrbEncrypt";
            this.mrbEncrypt.Ripple = true;
            this.mrbEncrypt.Size = new System.Drawing.Size(198, 20);
            this.mrbEncrypt.TabIndex = 0;
            this.mrbEncrypt.TabStop = true;
            this.mrbEncrypt.Text = "Зашифровать";
            this.mrbEncrypt.UseVisualStyleBackColor = true;
            // 
            // mlbProcessedText
            // 
            this.mlbProcessedText.AutoSize = true;
            this.mlbProcessedText.Depth = 0;
            this.mlbProcessedText.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlbProcessedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlbProcessedText.Location = new System.Drawing.Point(552, 46);
            this.mlbProcessedText.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlbProcessedText.Name = "mlbProcessedText";
            this.mlbProcessedText.Size = new System.Drawing.Size(156, 19);
            this.mlbProcessedText.TabIndex = 5;
            this.mlbProcessedText.Text = "Обработанный текст";
            // 
            // mlbSourceText
            // 
            this.mlbSourceText.AutoSize = true;
            this.mlbSourceText.Depth = 0;
            this.mlbSourceText.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlbSourceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlbSourceText.Location = new System.Drawing.Point(9, 43);
            this.mlbSourceText.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlbSourceText.Name = "mlbSourceText";
            this.mlbSourceText.Size = new System.Drawing.Size(125, 19);
            this.mlbSourceText.TabIndex = 4;
            this.mlbSourceText.Text = "Исходный текст";
            // 
            // pbRightArrow
            // 
            this.pbRightArrow.Image = global::Presentation_Layer.Properties.Resources.Right_Arrow_Black;
            this.pbRightArrow.Location = new System.Drawing.Point(370, 175);
            this.pbRightArrow.Name = "pbRightArrow";
            this.pbRightArrow.Size = new System.Drawing.Size(159, 89);
            this.pbRightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRightArrow.TabIndex = 3;
            this.pbRightArrow.TabStop = false;
            // 
            // tbModifiedText
            // 
            this.tbModifiedText.Location = new System.Drawing.Point(552, 65);
            this.tbModifiedText.Multiline = true;
            this.tbModifiedText.Name = "tbModifiedText";
            this.tbModifiedText.ReadOnly = true;
            this.tbModifiedText.Size = new System.Drawing.Size(331, 347);
            this.tbModifiedText.TabIndex = 1;
            this.tbModifiedText.TabStop = false;
            // 
            // tbSourceText
            // 
            this.tbSourceText.Location = new System.Drawing.Point(9, 65);
            this.tbSourceText.Multiline = true;
            this.tbSourceText.Name = "tbSourceText";
            this.tbSourceText.Size = new System.Drawing.Size(323, 347);
            this.tbSourceText.TabIndex = 0;
            this.tbSourceText.TabStop = false;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.cipherCaesarPage);
            this.materialTabControl1.Controls.Add(this.settingsPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(891, 444);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.TabStop = false;
            // 
            // settingsPage
            // 
            this.settingsPage.BackColor = System.Drawing.Color.White;
            this.settingsPage.Controls.Add(this.mfbSpravka);
            this.settingsPage.Controls.Add(this.gbAppLanguage);
            this.settingsPage.Controls.Add(this.gbColorScheme);
            this.settingsPage.Controls.Add(this.gbTheme);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(883, 418);
            this.settingsPage.TabIndex = 1;
            this.settingsPage.Text = "Настройки";
            // 
            // gbAppLanguage
            // 
            this.gbAppLanguage.Controls.Add(this.mrbEnglishApp);
            this.gbAppLanguage.Controls.Add(this.mrbRussianApp);
            this.gbAppLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAppLanguage.Location = new System.Drawing.Point(661, 45);
            this.gbAppLanguage.Name = "gbAppLanguage";
            this.gbAppLanguage.Size = new System.Drawing.Size(183, 100);
            this.gbAppLanguage.TabIndex = 2;
            this.gbAppLanguage.TabStop = false;
            this.gbAppLanguage.Text = "Язык приложения";
            // 
            // mrbEnglishApp
            // 
            this.mrbEnglishApp.AutoSize = true;
            this.mrbEnglishApp.Depth = 0;
            this.mrbEnglishApp.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbEnglishApp.Location = new System.Drawing.Point(7, 55);
            this.mrbEnglishApp.Margin = new System.Windows.Forms.Padding(0);
            this.mrbEnglishApp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbEnglishApp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbEnglishApp.Name = "mrbEnglishApp";
            this.mrbEnglishApp.Ripple = true;
            this.mrbEnglishApp.Size = new System.Drawing.Size(106, 30);
            this.mrbEnglishApp.TabIndex = 2;
            this.mrbEnglishApp.Text = "Английский";
            this.mrbEnglishApp.UseVisualStyleBackColor = true;
            this.mrbEnglishApp.CheckedChanged += new System.EventHandler(this.mrbEnglishApp_CheckedChanged);
            // 
            // mrbRussianApp
            // 
            this.mrbRussianApp.AutoSize = true;
            this.mrbRussianApp.Checked = true;
            this.mrbRussianApp.Depth = 0;
            this.mrbRussianApp.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbRussianApp.Location = new System.Drawing.Point(7, 24);
            this.mrbRussianApp.Margin = new System.Windows.Forms.Padding(0);
            this.mrbRussianApp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbRussianApp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbRussianApp.Name = "mrbRussianApp";
            this.mrbRussianApp.Ripple = true;
            this.mrbRussianApp.Size = new System.Drawing.Size(82, 30);
            this.mrbRussianApp.TabIndex = 0;
            this.mrbRussianApp.TabStop = true;
            this.mrbRussianApp.Text = "Русский";
            this.mrbRussianApp.UseVisualStyleBackColor = true;
            this.mrbRussianApp.CheckedChanged += new System.EventHandler(this.mrbRussianApp_CheckedChanged);
            // 
            // gbColorScheme
            // 
            this.gbColorScheme.Controls.Add(this.mrbGray);
            this.gbColorScheme.Controls.Add(this.mrbLightBlue);
            this.gbColorScheme.Controls.Add(this.mrbGreen);
            this.gbColorScheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbColorScheme.Location = new System.Drawing.Point(352, 45);
            this.gbColorScheme.Name = "gbColorScheme";
            this.gbColorScheme.Size = new System.Drawing.Size(183, 140);
            this.gbColorScheme.TabIndex = 1;
            this.gbColorScheme.TabStop = false;
            this.gbColorScheme.Text = "Цвет интерфейса";
            // 
            // mrbGray
            // 
            this.mrbGray.AutoSize = true;
            this.mrbGray.Depth = 0;
            this.mrbGray.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbGray.Location = new System.Drawing.Point(7, 88);
            this.mrbGray.Margin = new System.Windows.Forms.Padding(0);
            this.mrbGray.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbGray.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbGray.Name = "mrbGray";
            this.mrbGray.Ripple = true;
            this.mrbGray.Size = new System.Drawing.Size(72, 30);
            this.mrbGray.TabIndex = 2;
            this.mrbGray.Text = "Серый";
            this.mrbGray.UseVisualStyleBackColor = true;
            this.mrbGray.CheckedChanged += new System.EventHandler(this.mrbGray_CheckedChanged);
            // 
            // mrbLightBlue
            // 
            this.mrbLightBlue.AutoSize = true;
            this.mrbLightBlue.Depth = 0;
            this.mrbLightBlue.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbLightBlue.Location = new System.Drawing.Point(7, 55);
            this.mrbLightBlue.Margin = new System.Windows.Forms.Padding(0);
            this.mrbLightBlue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbLightBlue.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbLightBlue.Name = "mrbLightBlue";
            this.mrbLightBlue.Ripple = true;
            this.mrbLightBlue.Size = new System.Drawing.Size(82, 30);
            this.mrbLightBlue.TabIndex = 1;
            this.mrbLightBlue.Text = "Голубой";
            this.mrbLightBlue.UseVisualStyleBackColor = true;
            this.mrbLightBlue.CheckedChanged += new System.EventHandler(this.mrbLightBlue_CheckedChanged);
            // 
            // mrbGreen
            // 
            this.mrbGreen.AutoSize = true;
            this.mrbGreen.Checked = true;
            this.mrbGreen.Depth = 0;
            this.mrbGreen.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbGreen.Location = new System.Drawing.Point(7, 24);
            this.mrbGreen.Margin = new System.Windows.Forms.Padding(0);
            this.mrbGreen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbGreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbGreen.Name = "mrbGreen";
            this.mrbGreen.Ripple = true;
            this.mrbGreen.Size = new System.Drawing.Size(87, 30);
            this.mrbGreen.TabIndex = 0;
            this.mrbGreen.TabStop = true;
            this.mrbGreen.Text = "Зелёный";
            this.mrbGreen.UseVisualStyleBackColor = true;
            this.mrbGreen.CheckedChanged += new System.EventHandler(this.mrbGreen_CheckedChanged);
            // 
            // gbTheme
            // 
            this.gbTheme.Controls.Add(this.mrbDarkTheme);
            this.gbTheme.Controls.Add(this.mrbLightTheme);
            this.gbTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTheme.Location = new System.Drawing.Point(33, 45);
            this.gbTheme.Name = "gbTheme";
            this.gbTheme.Size = new System.Drawing.Size(183, 100);
            this.gbTheme.TabIndex = 0;
            this.gbTheme.TabStop = false;
            this.gbTheme.Text = "Тема";
            // 
            // mrbDarkTheme
            // 
            this.mrbDarkTheme.AutoSize = true;
            this.mrbDarkTheme.Depth = 0;
            this.mrbDarkTheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbDarkTheme.Location = new System.Drawing.Point(7, 54);
            this.mrbDarkTheme.Margin = new System.Windows.Forms.Padding(0);
            this.mrbDarkTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbDarkTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbDarkTheme.Name = "mrbDarkTheme";
            this.mrbDarkTheme.Ripple = true;
            this.mrbDarkTheme.Size = new System.Drawing.Size(113, 30);
            this.mrbDarkTheme.TabIndex = 1;
            this.mrbDarkTheme.Text = "Тёмная тема";
            this.mrbDarkTheme.UseVisualStyleBackColor = true;
            this.mrbDarkTheme.CheckedChanged += new System.EventHandler(this.mrbDarkTheme_CheckedChanged);
            // 
            // mrbLightTheme
            // 
            this.mrbLightTheme.AutoSize = true;
            this.mrbLightTheme.Checked = true;
            this.mrbLightTheme.Depth = 0;
            this.mrbLightTheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbLightTheme.Location = new System.Drawing.Point(7, 24);
            this.mrbLightTheme.Margin = new System.Windows.Forms.Padding(0);
            this.mrbLightTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbLightTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbLightTheme.Name = "mrbLightTheme";
            this.mrbLightTheme.Ripple = true;
            this.mrbLightTheme.Size = new System.Drawing.Size(118, 30);
            this.mrbLightTheme.TabIndex = 0;
            this.mrbLightTheme.TabStop = true;
            this.mrbLightTheme.Text = "Светлая тема";
            this.mrbLightTheme.UseVisualStyleBackColor = true;
            this.mrbLightTheme.CheckedChanged += new System.EventHandler(this.mrbLightTheme_CheckedChanged);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(890, 33);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.TabStop = false;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // mfbSpravka
            // 
            this.mfbSpravka.AutoSize = true;
            this.mfbSpravka.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbSpravka.Depth = 0;
            this.mfbSpravka.Icon = null;
            this.mfbSpravka.Location = new System.Drawing.Point(390, 368);
            this.mfbSpravka.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mfbSpravka.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbSpravka.Name = "mfbSpravka";
            this.mfbSpravka.Primary = false;
            this.mfbSpravka.Size = new System.Drawing.Size(84, 36);
            this.mfbSpravka.TabIndex = 3;
            this.mfbSpravka.TabStop = false;
            this.mfbSpravka.Text = "Справка";
            this.mfbSpravka.UseVisualStyleBackColor = true;
            this.mfbSpravka.Click += new System.EventHandler(this.mfbSpravka_Click);
            // 
            // cryptographyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(890, 505);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.MaximizeBox = false;
            this.Name = "cryptographyApp";
            this.Sizable = false;
            this.Text = "Криптография";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cryptographyApp_FormClosing);
            this.Load += new System.EventHandler(this.cryptographyApp_Load);
            this.cipherCaesarPage.ResumeLayout(false);
            this.cipherCaesarPage.PerformLayout();
            this.gbLanguage.ResumeLayout(false);
            this.gbActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRightArrow)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.gbAppLanguage.ResumeLayout(false);
            this.gbAppLanguage.PerformLayout();
            this.gbColorScheme.ResumeLayout(false);
            this.gbColorScheme.PerformLayout();
            this.gbTheme.ResumeLayout(false);
            this.gbTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage cipherCaesarPage;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TextBox tbSourceText;
        private System.Windows.Forms.TextBox tbModifiedText;
        private System.Windows.Forms.PictureBox pbRightArrow;
        private MaterialSkin.Controls.MaterialLabel mlbProcessedText;
        private MaterialSkin.Controls.MaterialLabel mlbSourceText;
        private System.Windows.Forms.GroupBox gbActions;
        private MaterialSkin.Controls.MaterialRadioButton mrbHack;
        private MaterialSkin.Controls.MaterialRadioButton mrbDecrypt;
        private MaterialSkin.Controls.MaterialRadioButton mrbEncrypt;
        private System.Windows.Forms.GroupBox gbLanguage;
        private MaterialSkin.Controls.MaterialRadioButton mrbEnglish;
        private MaterialSkin.Controls.MaterialRadioButton mrbRussian;
        private MaterialSkin.Controls.MaterialRaisedButton mrbExecute;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltfShift;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.GroupBox gbTheme;
        private MaterialSkin.Controls.MaterialRadioButton mrbDarkTheme;
        private MaterialSkin.Controls.MaterialRadioButton mrbLightTheme;
        private System.Windows.Forms.GroupBox gbColorScheme;
        private MaterialSkin.Controls.MaterialRadioButton mrbLightBlue;
        private MaterialSkin.Controls.MaterialRadioButton mrbGreen;
        private MaterialSkin.Controls.MaterialRadioButton mrbGray;
        private System.Windows.Forms.GroupBox gbAppLanguage;
        private MaterialSkin.Controls.MaterialRadioButton mrbEnglishApp;
        private MaterialSkin.Controls.MaterialRadioButton mrbRussianApp;
        private MaterialSkin.Controls.MaterialFlatButton mfbSpravka;
    }
}

