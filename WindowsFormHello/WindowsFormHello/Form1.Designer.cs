namespace WindowsFormHello
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelHello = new System.Windows.Forms.Label();
            this.BTNHello = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHello
            // 
            this.LabelHello.AutoSize = true;
            this.LabelHello.Location = new System.Drawing.Point(71, 81);
            this.LabelHello.Name = "LabelHello";
            this.LabelHello.Size = new System.Drawing.Size(0, 13);
            this.LabelHello.TabIndex = 0;
            this.LabelHello.Visible = false;
            this.LabelHello.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTNHello
            // 
            this.BTNHello.BackColor = System.Drawing.SystemColors.GrayText;
            this.BTNHello.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNHello.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BTNHello.Location = new System.Drawing.Point(202, 175);
            this.BTNHello.Name = "BTNHello";
            this.BTNHello.Size = new System.Drawing.Size(417, 177);
            this.BTNHello.TabIndex = 1;
            this.BTNHello.Text = "Pressiona-me!";
            this.BTNHello.UseVisualStyleBackColor = false;
            this.BTNHello.Click += new System.EventHandler(this.BTNHello_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "TESTE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormHello.Properties.Resources.RUCAAA;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 398);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(756, 406);
            this.Controls.Add(this.BTNHello);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelHello);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1st APP";
            this.Load += new System.EventHandler(this.Btn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHello;
        private System.Windows.Forms.Button BTNHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

