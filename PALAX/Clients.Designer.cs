namespace PALAX
{
    partial class Clients
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
            this.buttonClientsYour = new System.Windows.Forms.Button();
            this.buttonClientsFiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClientsYour
            // 
            this.buttonClientsYour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClientsYour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientsYour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientsYour.ForeColor = System.Drawing.Color.LightGray;
            this.buttonClientsYour.Location = new System.Drawing.Point(55, 41);
            this.buttonClientsYour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClientsYour.Name = "buttonClientsYour";
            this.buttonClientsYour.Size = new System.Drawing.Size(240, 30);
            this.buttonClientsYour.TabIndex = 0;
            this.buttonClientsYour.Text = "Юридическое лицо";
            this.buttonClientsYour.UseVisualStyleBackColor = false;
            this.buttonClientsYour.Click += new System.EventHandler(this.buttonClientsYour_Click);
            // 
            // buttonClientsFiz
            // 
            this.buttonClientsFiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClientsFiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientsFiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientsFiz.ForeColor = System.Drawing.Color.LightGray;
            this.buttonClientsFiz.Location = new System.Drawing.Point(55, 90);
            this.buttonClientsFiz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClientsFiz.Name = "buttonClientsFiz";
            this.buttonClientsFiz.Size = new System.Drawing.Size(240, 30);
            this.buttonClientsFiz.TabIndex = 1;
            this.buttonClientsFiz.Text = "Физическое лицо";
            this.buttonClientsFiz.UseVisualStyleBackColor = false;
            this.buttonClientsFiz.Click += new System.EventHandler(this.buttonClientsFiz_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 158);
            this.Controls.Add(this.buttonClientsFiz);
            this.Controls.Add(this.buttonClientsYour);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказчик";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClientsYour;
        private System.Windows.Forms.Button buttonClientsFiz;
    }
}