namespace DrawAirplan
{
    partial class FormAerodrome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxAerodrome = new System.Windows.Forms.PictureBox();
            this.buttonSetAircraft = new System.Windows.Forms.Button();
            this.groupBoxAircraft = new System.Windows.Forms.GroupBox();
            this.buttonTakeAircraft = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelAerodromes = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddAerodrome = new System.Windows.Forms.Button();
            this.listBoxAerodromes = new System.Windows.Forms.ListBox();
            this.buttonDeleteAerodrome = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).BeginInit();
            this.groupBoxAircraft.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAerodrome
            // 
            this.pictureBoxAerodrome.Location = new System.Drawing.Point(0, 27);
            this.pictureBoxAerodrome.Name = "pictureBoxAerodrome";
            this.pictureBoxAerodrome.Size = new System.Drawing.Size(800, 423);
            this.pictureBoxAerodrome.TabIndex = 0;
            this.pictureBoxAerodrome.TabStop = false;
            // 
            // buttonSetAircraft
            // 
            this.buttonSetAircraft.Location = new System.Drawing.Point(675, 301);
            this.buttonSetAircraft.Name = "buttonSetAircraft";
            this.buttonSetAircraft.Size = new System.Drawing.Size(109, 35);
            this.buttonSetAircraft.TabIndex = 1;
            this.buttonSetAircraft.Text = "Посадить самолёт";
            this.buttonSetAircraft.UseVisualStyleBackColor = true;
            this.buttonSetAircraft.Click += new System.EventHandler(this.buttonSetAircraft_Click);
            // 
            // groupBoxAircraft
            // 
            this.groupBoxAircraft.Controls.Add(this.buttonTakeAircraft);
            this.groupBoxAircraft.Controls.Add(this.maskedTextBox);
            this.groupBoxAircraft.Controls.Add(this.labelPlace);
            this.groupBoxAircraft.Location = new System.Drawing.Point(675, 342);
            this.groupBoxAircraft.Name = "groupBoxAircraft";
            this.groupBoxAircraft.Size = new System.Drawing.Size(109, 96);
            this.groupBoxAircraft.TabIndex = 3;
            this.groupBoxAircraft.TabStop = false;
            this.groupBoxAircraft.Text = "Забрать самолёт";
            // 
            // buttonTakeAircraft
            // 
            this.buttonTakeAircraft.Location = new System.Drawing.Point(15, 63);
            this.buttonTakeAircraft.Name = "buttonTakeAircraft";
            this.buttonTakeAircraft.Size = new System.Drawing.Size(77, 27);
            this.buttonTakeAircraft.TabIndex = 2;
            this.buttonTakeAircraft.Text = "Забрать";
            this.buttonTakeAircraft.UseVisualStyleBackColor = true;
            this.buttonTakeAircraft.Click += new System.EventHandler(this.buttonTakeAircraft_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(59, 27);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(33, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(11, 30);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // labelAerodromes
            // 
            this.labelAerodromes.AutoSize = true;
            this.labelAerodromes.Location = new System.Drawing.Point(697, 9);
            this.labelAerodromes.Name = "labelAerodromes";
            this.labelAerodromes.Size = new System.Drawing.Size(69, 13);
            this.labelAerodromes.TabIndex = 4;
            this.labelAerodromes.Text = "Аэродромы:";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(675, 25);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(109, 20);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // buttonAddAerodrome
            // 
            this.buttonAddAerodrome.Location = new System.Drawing.Point(675, 51);
            this.buttonAddAerodrome.Name = "buttonAddAerodrome";
            this.buttonAddAerodrome.Size = new System.Drawing.Size(109, 35);
            this.buttonAddAerodrome.TabIndex = 6;
            this.buttonAddAerodrome.Text = "Добавить аэродром";
            this.buttonAddAerodrome.UseVisualStyleBackColor = true;
            this.buttonAddAerodrome.Click += new System.EventHandler(this.buttonAddAerodrome_Click);
            // 
            // listBoxAerodromes
            // 
            this.listBoxAerodromes.FormattingEnabled = true;
            this.listBoxAerodromes.Location = new System.Drawing.Point(675, 92);
            this.listBoxAerodromes.Name = "listBoxAerodromes";
            this.listBoxAerodromes.Size = new System.Drawing.Size(109, 95);
            this.listBoxAerodromes.TabIndex = 7;
            this.listBoxAerodromes.Click += new System.EventHandler(this.listBoxAerodromes_SelectedIndexChanged);
            // 
            // buttonDeleteAerodrome
            // 
            this.buttonDeleteAerodrome.Location = new System.Drawing.Point(675, 193);
            this.buttonDeleteAerodrome.Name = "buttonDeleteAerodrome";
            this.buttonDeleteAerodrome.Size = new System.Drawing.Size(109, 44);
            this.buttonDeleteAerodrome.TabIndex = 8;
            this.buttonDeleteAerodrome.Text = "Удалить аэродром";
            this.buttonDeleteAerodrome.UseVisualStyleBackColor = true;
            this.buttonDeleteAerodrome.Click += new System.EventHandler(this.buttonDeleteAerodrome_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem1,
            this.загрузитьToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem1
            // 
            this.загрузитьToolStripMenuItem1.Name = "загрузитьToolStripMenuItem1";
            this.загрузитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem1.Text = "Загрузить";
            this.загрузитьToolStripMenuItem1.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormAerodrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteAerodrome);
            this.Controls.Add(this.listBoxAerodromes);
            this.Controls.Add(this.buttonAddAerodrome);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.labelAerodromes);
            this.Controls.Add(this.groupBoxAircraft);
            this.Controls.Add(this.buttonSetAircraft);
            this.Controls.Add(this.pictureBoxAerodrome);
            this.Controls.Add(this.menuStrip);
            this.Name = "FormAerodrome";
            this.Text = "FormAerodrome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).EndInit();
            this.groupBoxAircraft.ResumeLayout(false);
            this.groupBoxAircraft.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAerodrome;
        private System.Windows.Forms.Button buttonSetAircraft;
        private System.Windows.Forms.GroupBox groupBoxAircraft;
        private System.Windows.Forms.Button buttonTakeAircraft;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelAerodromes;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddAerodrome;
        private System.Windows.Forms.ListBox listBoxAerodromes;
        private System.Windows.Forms.Button buttonDeleteAerodrome;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}