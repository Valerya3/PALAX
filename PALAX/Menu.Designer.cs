namespace PALAX
{
    partial class Menu
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
            this.battonClients = new System.Windows.Forms.Button();
            this.battonSale = new System.Windows.Forms.Button();
            this.battonStaff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // battonClients
            // 
            this.battonClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.battonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.battonClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.battonClients.ForeColor = System.Drawing.Color.LightGray;
            this.battonClients.Location = new System.Drawing.Point(59, 207);
            this.battonClients.Name = "battonClients";
            this.battonClients.Size = new System.Drawing.Size(140, 30);
            this.battonClients.TabIndex = 0;
            this.battonClients.Text = "Заказчики";
            this.battonClients.UseVisualStyleBackColor = false;
            this.battonClients.Click += new System.EventHandler(this.button1_Click);
            // 
            // battonSale
            // 
            this.battonSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.battonSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.battonSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.battonSale.ForeColor = System.Drawing.Color.LightGray;
            this.battonSale.Location = new System.Drawing.Point(59, 264);
            this.battonSale.Name = "battonSale";
            this.battonSale.Size = new System.Drawing.Size(140, 30);
            this.battonSale.TabIndex = 1;
            this.battonSale.Text = "Продажа";
            this.battonSale.UseVisualStyleBackColor = false;
            this.battonSale.Click += new System.EventHandler(this.battonSale_Click);
            // 
            // battonStaff
            // 
            this.battonStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.battonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.battonStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.battonStaff.ForeColor = System.Drawing.Color.LightGray;
            this.battonStaff.Location = new System.Drawing.Point(59, 153);
            this.battonStaff.Name = "battonStaff";
            this.battonStaff.Size = new System.Drawing.Size(140, 30);
            this.battonStaff.TabIndex = 2;
            this.battonStaff.Text = "Разработчики";
            this.battonStaff.UseVisualStyleBackColor = false;
            this.battonStaff.Click += new System.EventHandler(this.battonStaff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PALAX.Properties.Resources.Снимок1;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(254, 342);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.battonStaff);
            this.Controls.Add(this.battonSale);
            this.Controls.Add(this.battonClients);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button battonClients;
        private System.Windows.Forms.Button battonSale;
        private System.Windows.Forms.Button battonStaff;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

