namespace DrawAirplan
{
    partial class FormAircraft
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
            this.pictureBoxAircraft = new System.Windows.Forms.PictureBox();
            this.buttonCreateAircraft = new System.Windows.Forms.Button();
            this.buttonCreateAirbus = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAircraft
            // 
            this.pictureBoxAircraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAircraft.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAircraft.Name = "pictureBoxAircraft";
            this.pictureBoxAircraft.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxAircraft.TabIndex = 0;
            this.pictureBoxAircraft.TabStop = false;
            // 
            // buttonCreateAircraft
            // 
            this.buttonCreateAircraft.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateAircraft.Name = "buttonCreateAircraft";
            this.buttonCreateAircraft.Size = new System.Drawing.Size(120, 25);
            this.buttonCreateAircraft.TabIndex = 1;
            this.buttonCreateAircraft.Text = "Создать самолёт";
            this.buttonCreateAircraft.UseVisualStyleBackColor = true;
            this.buttonCreateAircraft.Click += new System.EventHandler(this.buttonCreateAircraft_Click);
            // 
            // buttonCreateAirbus
            // 
            this.buttonCreateAirbus.Location = new System.Drawing.Point(149, 12);
            this.buttonCreateAirbus.Name = "buttonCreateAirbus";
            this.buttonCreateAirbus.Size = new System.Drawing.Size(120, 25);
            this.buttonCreateAirbus.TabIndex = 2;
            this.buttonCreateAirbus.Text = "Создать аэробус";
            this.buttonCreateAirbus.UseVisualStyleBackColor = true;
            this.buttonCreateAirbus.Click += new System.EventHandler(this.buttonCreateAirbus_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::DrawAirplan.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(724, 410);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLeft.BackgroundImage = global::DrawAirplan.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(689, 410);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUp.BackgroundImage = global::DrawAirplan.Properties.Resources.up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(724, 376);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRight.BackgroundImage = global::DrawAirplan.Properties.Resources.right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(759, 410);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 6;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // FormAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonCreateAirbus);
            this.Controls.Add(this.buttonCreateAircraft);
            this.Controls.Add(this.pictureBoxAircraft);
            this.Name = "FormAircraft";
            this.Text = "FormAircraft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAircraft;
        private System.Windows.Forms.Button buttonCreateAircraft;
        private System.Windows.Forms.Button buttonCreateAirbus;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonRight;
    }
}