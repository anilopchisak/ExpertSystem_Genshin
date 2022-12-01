namespace ExpertSystem_Genshin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_no = new System.Windows.Forms.Button();
            this.label_q = new System.Windows.Forms.RichTextBox();
            this.btn_yes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_no
            // 
            this.btn_no.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_no.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.Location = new System.Drawing.Point(200, 174);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(97, 29);
            this.btn_no.TabIndex = 1;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = false;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // label_q
            // 
            this.label_q.BackColor = System.Drawing.Color.LightBlue;
            this.label_q.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_q.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_q.ForeColor = System.Drawing.Color.Black;
            this.label_q.Location = new System.Drawing.Point(25, 21);
            this.label_q.Name = "label_q";
            this.label_q.ReadOnly = true;
            this.label_q.ShowSelectionMargin = true;
            this.label_q.Size = new System.Drawing.Size(323, 130);
            this.label_q.TabIndex = 6;
            this.label_q.Text = "";
            // 
            // btn_yes
            // 
            this.btn_yes.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yes.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yes.Location = new System.Drawing.Point(74, 174);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(97, 29);
            this.btn_yes.TabIndex = 3;
            this.btn_yes.Text = "Yes";
            this.btn_yes.UseVisualStyleBackColor = false;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox1.Location = new System.Drawing.Point(460, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 392);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(135, 220);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(98, 34);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.label_q);
            this.panel1.Controls.Add(this.btn_yes);
            this.panel1.Controls.Add(this.btn_no);
            this.panel1.Location = new System.Drawing.Point(41, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 268);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 742);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.RichTextBox label_q;
        private System.Windows.Forms.Panel panel1;
    }
}

