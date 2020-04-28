namespace integral
{
    partial class integral__Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(integral__Form));
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.border__a = new System.Windows.Forms.TextBox();
            this.border__b = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.step_in = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eTrap = new System.Windows.Forms.Label();
            this.eSims = new System.Windows.Forms.Label();
            this.Trap_out = new System.Windows.Forms.Label();
            this.Sims_out = new System.Windows.Forms.Label();
            this.hints = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.epTrap = new System.Windows.Forms.Label();
            this.epSims = new System.Windows.Forms.Label();
            this.pTrap_out = new System.Windows.Forms.Label();
            this.pSims_out = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Трапеции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Симпсон";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // border__a
            // 
            this.border__a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.border__a.Location = new System.Drawing.Point(120, 55);
            this.border__a.Margin = new System.Windows.Forms.Padding(4);
            this.border__a.Name = "border__a";
            this.border__a.Size = new System.Drawing.Size(100, 23);
            this.border__a.TabIndex = 2;
            this.border__a.TextChanged += new System.EventHandler(this.border__b_TextChanged);
            // 
            // border__b
            // 
            this.border__b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.border__b.Location = new System.Drawing.Point(120, 24);
            this.border__b.Margin = new System.Windows.Forms.Padding(4);
            this.border__b.Name = "border__b";
            this.border__b.Size = new System.Drawing.Size(100, 23);
            this.border__b.TabIndex = 3;
            this.border__b.TextChanged += new System.EventHandler(this.border__a_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Нижняя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Верхняя";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.step_in);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.border__b);
            this.groupBox1.Controls.Add(this.border__a);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(10, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 120);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "параметры интегрирования";
            // 
            // step_in
            // 
            this.step_in.Location = new System.Drawing.Point(120, 85);
            this.step_in.Name = "step_in";
            this.step_in.Size = new System.Drawing.Size(100, 21);
            this.step_in.TabIndex = 6;
            this.step_in.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(69, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Шаг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.eTrap);
            this.groupBox2.Controls.Add(this.eSims);
            this.groupBox2.Controls.Add(this.Trap_out);
            this.groupBox2.Controls.Add(this.Sims_out);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(9, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 294);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "результаты вычислений [последовательно]";
            // 
            // eTrap
            // 
            this.eTrap.AutoSize = true;
            this.eTrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eTrap.Location = new System.Drawing.Point(25, 246);
            this.eTrap.Name = "eTrap";
            this.eTrap.Size = new System.Drawing.Size(31, 20);
            this.eTrap.TabIndex = 11;
            this.eTrap.Text = "0.0";
            // 
            // eSims
            // 
            this.eSims.AutoSize = true;
            this.eSims.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eSims.Location = new System.Drawing.Point(25, 116);
            this.eSims.Name = "eSims";
            this.eSims.Size = new System.Drawing.Size(31, 20);
            this.eSims.TabIndex = 11;
            this.eSims.Text = "0.0";
            // 
            // Trap_out
            // 
            this.Trap_out.AutoSize = true;
            this.Trap_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trap_out.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Trap_out.ForeColor = System.Drawing.Color.Black;
            this.Trap_out.Location = new System.Drawing.Point(21, 195);
            this.Trap_out.Name = "Trap_out";
            this.Trap_out.Size = new System.Drawing.Size(65, 40);
            this.Trap_out.TabIndex = 10;
            this.Trap_out.Text = "0.0";
            // 
            // Sims_out
            // 
            this.Sims_out.AutoSize = true;
            this.Sims_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sims_out.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sims_out.ForeColor = System.Drawing.Color.Black;
            this.Sims_out.Location = new System.Drawing.Point(21, 63);
            this.Sims_out.Name = "Sims_out";
            this.Sims_out.Size = new System.Drawing.Size(65, 40);
            this.Sims_out.TabIndex = 10;
            this.Sims_out.Text = "0.0";
            // 
            // hints
            // 
            this.hints.AutoSize = true;
            this.hints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hints.ForeColor = System.Drawing.Color.Black;
            this.hints.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.hints.Location = new System.Drawing.Point(10, 18);
            this.hints.Name = "hints";
            this.hints.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hints.Size = new System.Drawing.Size(325, 20);
            this.hints.TabIndex = 18;
            this.hints.Text = "Введите параметры интегрирования";
            this.hints.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::integral.Properties.Resources.интеграл2;
            this.pictureBox1.Location = new System.Drawing.Point(28, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 62);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.epTrap);
            this.groupBox3.Controls.Add(this.epSims);
            this.groupBox3.Controls.Add(this.pTrap_out);
            this.groupBox3.Controls.Add(this.pSims_out);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(350, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 294);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "результаты вычислений [параллельно]";
            // 
            // epTrap
            // 
            this.epTrap.AutoSize = true;
            this.epTrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epTrap.Location = new System.Drawing.Point(25, 246);
            this.epTrap.Name = "epTrap";
            this.epTrap.Size = new System.Drawing.Size(31, 20);
            this.epTrap.TabIndex = 11;
            this.epTrap.Text = "0.0";
            // 
            // epSims
            // 
            this.epSims.AutoSize = true;
            this.epSims.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epSims.Location = new System.Drawing.Point(25, 116);
            this.epSims.Name = "epSims";
            this.epSims.Size = new System.Drawing.Size(31, 20);
            this.epSims.TabIndex = 11;
            this.epSims.Text = "0.0";
            // 
            // pTrap_out
            // 
            this.pTrap_out.AutoSize = true;
            this.pTrap_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pTrap_out.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pTrap_out.ForeColor = System.Drawing.Color.Black;
            this.pTrap_out.Location = new System.Drawing.Point(21, 195);
            this.pTrap_out.Name = "pTrap_out";
            this.pTrap_out.Size = new System.Drawing.Size(65, 40);
            this.pTrap_out.TabIndex = 10;
            this.pTrap_out.Text = "0.0";
            // 
            // pSims_out
            // 
            this.pSims_out.AutoSize = true;
            this.pSims_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pSims_out.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pSims_out.ForeColor = System.Drawing.Color.Black;
            this.pSims_out.Location = new System.Drawing.Point(21, 63);
            this.pSims_out.Name = "pSims_out";
            this.pSims_out.Size = new System.Drawing.Size(65, 40);
            this.pSims_out.TabIndex = 10;
            this.pSims_out.Text = "0.0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(25, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Трапеции";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(25, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Симпсон";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(350, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 120);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "расчитываемый интеграл";
            // 
            // integral__Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 489);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.hints);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "integral__Form";
            this.Text = "Integrals (Егоров, Журавлев 3-46 )";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox border__a;
        private System.Windows.Forms.TextBox border__b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label eTrap;
        private System.Windows.Forms.Label eSims;
        private System.Windows.Forms.Label Trap_out;
        private System.Windows.Forms.Label Sims_out;
        private System.Windows.Forms.Label hints;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox step_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label epTrap;
        private System.Windows.Forms.Label epSims;
        private System.Windows.Forms.Label pTrap_out;
        private System.Windows.Forms.Label pSims_out;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

