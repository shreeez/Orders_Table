namespace Orders_Table
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Sourse = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cltarButton1 = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.searchPik = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.proizvLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.comentLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.newNoteButton = new System.Windows.Forms.Button();
            this.ChangeNoteButton = new System.Windows.Forms.Button();
            this.deliteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Sourse.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Sourse);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1134, 661);
            this.tabControl1.TabIndex = 1;
            // 
            // Sourse
            // 
            this.Sourse.BackColor = System.Drawing.Color.Gainsboro;
            this.Sourse.Controls.Add(this.groupBox1);
            this.Sourse.Controls.Add(this.dataGridView1);
            this.Sourse.Controls.Add(this.panel1);
            this.Sourse.Location = new System.Drawing.Point(4, 22);
            this.Sourse.Name = "Sourse";
            this.Sourse.Padding = new System.Windows.Forms.Padding(3);
            this.Sourse.Size = new System.Drawing.Size(1126, 635);
            this.Sourse.TabIndex = 0;
            this.Sourse.Text = "Основная";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.proizvLabel);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.searchPik);
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.cltarButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 56);
            this.panel1.TabIndex = 0;
            // 
            // cltarButton1
            // 
            this.cltarButton1.BackColor = System.Drawing.Color.Transparent;
            this.cltarButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cltarButton1.BackgroundImage")));
            this.cltarButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cltarButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cltarButton1.Location = new System.Drawing.Point(723, 8);
            this.cltarButton1.Name = "cltarButton1";
            this.cltarButton1.Size = new System.Drawing.Size(41, 36);
            this.cltarButton1.TabIndex = 0;
            this.cltarButton1.UseVisualStyleBackColor = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshButton.Location = new System.Drawing.Point(770, 8);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(38, 36);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // searchPik
            // 
            this.searchPik.Image = ((System.Drawing.Image)(resources.GetObject("searchPik.Image")));
            this.searchPik.Location = new System.Drawing.Point(835, 8);
            this.searchPik.Name = "searchPik";
            this.searchPik.Size = new System.Drawing.Size(36, 36);
            this.searchPik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchPik.TabIndex = 2;
            this.searchPik.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(877, 10);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(218, 34);
            this.searchTextBox.TabIndex = 3;
            // 
            // proizvLabel
            // 
            this.proizvLabel.AutoSize = true;
            this.proizvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proizvLabel.Location = new System.Drawing.Point(9, 10);
            this.proizvLabel.Name = "proizvLabel";
            this.proizvLabel.Size = new System.Drawing.Size(230, 31);
            this.proizvLabel.TabIndex = 4;
            this.proizvLabel.Text = "Производство 50";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1120, 573);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(952, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Управление записями";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.countTextBox);
            this.panel2.Controls.Add(this.commentTextBox);
            this.panel2.Controls.Add(this.IdTextBox);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.countLabel);
            this.panel2.Controls.Add(this.comentLabel);
            this.panel2.Controls.Add(this.idLabel);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 149);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.saveButton);
            this.panel3.Controls.Add(this.deliteButton);
            this.panel3.Controls.Add(this.ChangeNoteButton);
            this.panel3.Controls.Add(this.newNoteButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(945, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 143);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Запись:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1126, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(194, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Имя:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(153, 40);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 20);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID заказа:";
            // 
            // comentLabel
            // 
            this.comentLabel.AutoSize = true;
            this.comentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comentLabel.Location = new System.Drawing.Point(121, 74);
            this.comentLabel.Name = "comentLabel";
            this.comentLabel.Size = new System.Drawing.Size(117, 20);
            this.comentLabel.TabIndex = 4;
            this.comentLabel.Text = "Комментраий:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(124, 126);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(114, 20);
            this.countLabel.TabIndex = 5;
            this.countLabel.Text = "Колличество:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(244, 11);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(680, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(244, 40);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(190, 20);
            this.IdTextBox.TabIndex = 7;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(244, 66);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(680, 54);
            this.commentTextBox.TabIndex = 8;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(244, 126);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(56, 20);
            this.countTextBox.TabIndex = 9;
            // 
            // newNoteButton
            // 
            this.newNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newNoteButton.Location = new System.Drawing.Point(3, 19);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(86, 52);
            this.newNoteButton.TabIndex = 0;
            this.newNoteButton.Text = "Новая запись";
            this.newNoteButton.UseVisualStyleBackColor = true;
            // 
            // ChangeNoteButton
            // 
            this.ChangeNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeNoteButton.Location = new System.Drawing.Point(3, 82);
            this.ChangeNoteButton.Name = "ChangeNoteButton";
            this.ChangeNoteButton.Size = new System.Drawing.Size(84, 58);
            this.ChangeNoteButton.TabIndex = 1;
            this.ChangeNoteButton.Text = "Изменить";
            this.ChangeNoteButton.UseVisualStyleBackColor = true;
            this.ChangeNoteButton.Click += new System.EventHandler(this.ChangeNoteButton_Click);
            // 
            // deliteButton
            // 
            this.deliteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliteButton.Location = new System.Drawing.Point(92, 19);
            this.deliteButton.Name = "deliteButton";
            this.deliteButton.Size = new System.Drawing.Size(77, 52);
            this.deliteButton.TabIndex = 2;
            this.deliteButton.Text = "Удалить";
            this.deliteButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(91, 82);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 58);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 685);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Основная";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Sourse.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Sourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox searchPik;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button cltarButton1;
        private System.Windows.Forms.Label proizvLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deliteButton;
        private System.Windows.Forms.Button ChangeNoteButton;
        private System.Windows.Forms.Button newNoteButton;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label comentLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}

