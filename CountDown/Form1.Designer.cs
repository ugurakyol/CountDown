
namespace CountDown
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labeltimepassed = new System.Windows.Forms.Label();
            this.labelduration = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnSetDuration = new System.Windows.Forms.Button();
            this.textBoxSure = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(50, 399);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 51);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.Location = new System.Drawing.Point(216, 399);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 51);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Durdur";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F);
            this.btnReset.Location = new System.Drawing.Point(382, 399);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 51);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Sıfırla";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelDate.Location = new System.Drawing.Point(548, 25);
            this.labelDate.Name = "labelDate";
            this.labelDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDate.Size = new System.Drawing.Size(493, 61);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Tarih";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labeltimepassed
            // 
            this.labeltimepassed.AutoSize = true;
            this.labeltimepassed.BackColor = System.Drawing.Color.Transparent;
            this.labeltimepassed.Font = new System.Drawing.Font("Digital-7", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltimepassed.ForeColor = System.Drawing.Color.White;
            this.labeltimepassed.Location = new System.Drawing.Point(38, 168);
            this.labeltimepassed.Name = "labeltimepassed";
            this.labeltimepassed.Size = new System.Drawing.Size(234, 64);
            this.labeltimepassed.TabIndex = 5;
            this.labeltimepassed.Text = "00:00:00";
            this.labeltimepassed.Visible = false;
            // 
            // labelduration
            // 
            this.labelduration.AutoSize = true;
            this.labelduration.BackColor = System.Drawing.Color.Transparent;
            this.labelduration.Font = new System.Drawing.Font("Digital-7", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelduration.ForeColor = System.Drawing.Color.White;
            this.labelduration.Location = new System.Drawing.Point(14, 189);
            this.labelduration.Name = "labelduration";
            this.labelduration.Size = new System.Drawing.Size(668, 185);
            this.labelduration.TabIndex = 6;
            this.labelduration.Text = "00:00:00";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.BackColor = System.Drawing.Color.Transparent;
            this.labelHour.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.ForeColor = System.Drawing.Color.White;
            this.labelHour.Location = new System.Drawing.Point(797, 86);
            this.labelHour.Name = "labelHour";
            this.labelHour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHour.Size = new System.Drawing.Size(235, 58);
            this.labelHour.TabIndex = 7;
            this.labelHour.Text = "00:00:00";
            // 
            // btnAddTime
            // 
            this.btnAddTime.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F);
            this.btnAddTime.Location = new System.Drawing.Point(548, 399);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(119, 51);
            this.btnAddTime.TabIndex = 8;
            this.btnAddTime.Text = "Ek Süre";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // btnSetDuration
            // 
            this.btnSetDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSetDuration.Location = new System.Drawing.Point(801, 404);
            this.btnSetDuration.Name = "btnSetDuration";
            this.btnSetDuration.Size = new System.Drawing.Size(100, 39);
            this.btnSetDuration.TabIndex = 9;
            this.btnSetDuration.Text = "Süre Ayarı";
            this.btnSetDuration.UseVisualStyleBackColor = true;
            this.btnSetDuration.Visible = false;
            this.btnSetDuration.Click += new System.EventHandler(this.btnSetDuration_Click);
            // 
            // textBoxSure
            // 
            this.textBoxSure.Font = new System.Drawing.Font("Digital-7", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSure.Location = new System.Drawing.Point(695, 404);
            this.textBoxSure.Name = "textBoxSure";
            this.textBoxSure.Size = new System.Drawing.Size(100, 39);
            this.textBoxSure.TabIndex = 10;
            this.textBoxSure.Text = "00:00";
            this.textBoxSure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSure.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1072, 486);
            this.Controls.Add(this.textBoxSure);
            this.Controls.Add(this.btnSetDuration);
            this.Controls.Add(this.labelduration);
            this.Controls.Add(this.labeltimepassed);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bursa Ticaret ve Sanayi Odası";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labeltimepassed;
        private System.Windows.Forms.Label labelduration;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnSetDuration;
        private System.Windows.Forms.TextBox textBoxSure;
    }
}

