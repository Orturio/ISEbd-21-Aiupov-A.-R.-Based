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
            this.buttonLandAircraft = new System.Windows.Forms.Button();
            this.buttonLandAirbus = new System.Windows.Forms.Button();
            this.groupBoxAircraft = new System.Windows.Forms.GroupBox();
            this.buttonTakeAircraft = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).BeginInit();
            this.groupBoxAircraft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAerodrome
            // 
            this.pictureBoxAerodrome.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxAerodrome.Name = "pictureBoxAerodrome";
            this.pictureBoxAerodrome.Size = new System.Drawing.Size(799, 451);
            this.pictureBoxAerodrome.TabIndex = 0;
            this.pictureBoxAerodrome.TabStop = false;
            // 
            // buttonLandAircraft
            // 
            this.buttonLandAircraft.Location = new System.Drawing.Point(675, 8);
            this.buttonLandAircraft.Name = "buttonLandAircraft";
            this.buttonLandAircraft.Size = new System.Drawing.Size(109, 35);
            this.buttonLandAircraft.TabIndex = 1;
            this.buttonLandAircraft.Text = "Посадить самолёт";
            this.buttonLandAircraft.UseVisualStyleBackColor = true;
            this.buttonLandAircraft.Click += new System.EventHandler(this.buttonLandAircraft_Click);
            // 
            // buttonLandAirbus
            // 
            this.buttonLandAirbus.Location = new System.Drawing.Point(675, 49);
            this.buttonLandAirbus.Name = "buttonLandAirbus";
            this.buttonLandAirbus.Size = new System.Drawing.Size(109, 36);
            this.buttonLandAirbus.TabIndex = 2;
            this.buttonLandAirbus.Text = "Посадить аэробус";
            this.buttonLandAirbus.UseVisualStyleBackColor = true;
            this.buttonLandAirbus.Click += new System.EventHandler(this.buttonLandAirbus_Click);
            // 
            // groupBoxAircraft
            // 
            this.groupBoxAircraft.Controls.Add(this.buttonTakeAircraft);
            this.groupBoxAircraft.Controls.Add(this.maskedTextBox);
            this.groupBoxAircraft.Controls.Add(this.labelPlace);
            this.groupBoxAircraft.Location = new System.Drawing.Point(675, 91);
            this.groupBoxAircraft.Name = "groupBoxAircraft";
            this.groupBoxAircraft.Size = new System.Drawing.Size(109, 96);
            this.groupBoxAircraft.TabIndex = 3;
            this.groupBoxAircraft.TabStop = false;
            this.groupBoxAircraft.Text = "Забрать самолёт";
            // 
            // buttonTakeAircraft
            // 
            this.buttonTakeAircraft.Location = new System.Drawing.Point(14, 63);
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
            // FormAerodrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAircraft);
            this.Controls.Add(this.buttonLandAirbus);
            this.Controls.Add(this.buttonLandAircraft);
            this.Controls.Add(this.pictureBoxAerodrome);
            this.Name = "FormAerodrome";
            this.Text = "FormAerodrome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).EndInit();
            this.groupBoxAircraft.ResumeLayout(false);
            this.groupBoxAircraft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAerodrome;
        private System.Windows.Forms.Button buttonLandAircraft;
        private System.Windows.Forms.Button buttonLandAirbus;
        private System.Windows.Forms.GroupBox groupBoxAircraft;
        private System.Windows.Forms.Button buttonTakeAircraft;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelPlace;
    }
}