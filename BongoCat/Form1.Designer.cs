namespace BongoCat
{
    partial class App
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.Hands = new System.Windows.Forms.PictureBox();
            this.Cat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.Hands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Cat)).BeginInit();
            this.SuspendLayout();
            // 
            // Hands
            // 
            this.Hands.BackColor = System.Drawing.Color.Transparent;
            this.Hands.Location = new System.Drawing.Point(0, 0);
            this.Hands.Name = "Hands";
            this.Hands.Size = new System.Drawing.Size(630, 415);
            this.Hands.TabIndex = 1;
            this.Hands.TabStop = false;
            // 
            // Cat
            // 
            this.Cat.BackColor = System.Drawing.Color.Transparent;
            this.Cat.BackgroundImage = global::BongoCat.Properties.Resources.cat_table;
            this.Cat.Location = new System.Drawing.Point(0, 0);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(630, 415);
            this.Cat.TabIndex = 0;
            this.Cat.TabStop = false;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 421);
            this.Controls.Add(this.Hands);
            this.Controls.Add(this.Cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "App";
            this.Text = "Bongo Cat | Press \'O\' to open settings";
            ((System.ComponentModel.ISupportInitialize) (this.Hands)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Cat)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.PictureBox Hands;
        public System.Windows.Forms.PictureBox Cat;
    }
}

