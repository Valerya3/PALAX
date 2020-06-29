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
            this.battonLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // battonClients
            // 
            this.battonClients.Location = new System.Drawing.Point(160, 134);
            this.battonClients.Name = "battonClients";
            this.battonClients.Size = new System.Drawing.Size(75, 23);
            this.battonClients.TabIndex = 0;
            this.battonClients.Text = "Заказчики";
            this.battonClients.UseVisualStyleBackColor = true;
            this.battonClients.Click += new System.EventHandler(this.button1_Click);
            // 
            // battonSale
            // 
            this.battonSale.Location = new System.Drawing.Point(160, 210);
            this.battonSale.Name = "battonSale";
            this.battonSale.Size = new System.Drawing.Size(75, 23);
            this.battonSale.TabIndex = 1;
            this.battonSale.Text = "Продажа";
            this.battonSale.UseVisualStyleBackColor = true;
            this.battonSale.Click += new System.EventHandler(this.battonSale_Click);
            // 
            // battonStaff
            // 
            this.battonStaff.Location = new System.Drawing.Point(160, 261);
            this.battonStaff.Name = "battonStaff";
            this.battonStaff.Size = new System.Drawing.Size(75, 23);
            this.battonStaff.TabIndex = 2;
            this.battonStaff.Text = "Разработчики";
            this.battonStaff.UseVisualStyleBackColor = true;
            this.battonStaff.Click += new System.EventHandler(this.battonStaff_Click);
            // 
            // battonLog
            // 
            this.battonLog.Location = new System.Drawing.Point(160, 327);
            this.battonLog.Name = "battonLog";
            this.battonLog.Size = new System.Drawing.Size(75, 23);
            this.battonLog.TabIndex = 3;
            this.battonLog.Text = "Журнал";
            this.battonLog.UseVisualStyleBackColor = true;
            this.battonLog.Click += new System.EventHandler(this.battonLog_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.battonLog);
            this.Controls.Add(this.battonStaff);
            this.Controls.Add(this.battonSale);
            this.Controls.Add(this.battonClients);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button battonClients;
        private System.Windows.Forms.Button battonSale;
        private System.Windows.Forms.Button battonStaff;
        private System.Windows.Forms.Button battonLog;
    }
}

