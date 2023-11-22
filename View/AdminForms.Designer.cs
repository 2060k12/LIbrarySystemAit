namespace View
{
    partial class AdminForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.reserveBook = new System.Windows.Forms.Button();
            this.manageUserButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.Pages = new System.Windows.Forms.Label();
            this.publishYearTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.Publisher = new System.Windows.Forms.Label();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.reserveBook);
            this.panel1.Controls.Add(this.manageUserButton);
            this.panel1.Controls.Add(this.removeButton);
            this.panel1.Controls.Add(this.pagesTextBox);
            this.panel1.Controls.Add(this.Pages);
            this.panel1.Controls.Add(this.publishYearTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.publisherTextBox);
            this.panel1.Controls.Add(this.Publisher);
            this.panel1.Controls.Add(this.languageTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.categoryTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.authorTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bookNameTextBox);
            this.panel1.Controls.Add(this.isbnTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 310);
            this.panel1.TabIndex = 9;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(820, 229);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(118, 57);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // reserveBook
            // 
            this.reserveBook.BackColor = System.Drawing.Color.Black;
            this.reserveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveBook.ForeColor = System.Drawing.Color.LightYellow;
            this.reserveBook.Location = new System.Drawing.Point(430, 229);
            this.reserveBook.Name = "reserveBook";
            this.reserveBook.Size = new System.Drawing.Size(208, 57);
            this.reserveBook.TabIndex = 11;
            this.reserveBook.Text = "View Reserves";
            this.reserveBook.UseVisualStyleBackColor = false;
            this.reserveBook.Click += new System.EventHandler(this.reserveBook_Click);
            // 
            // manageUserButton
            // 
            this.manageUserButton.BackColor = System.Drawing.Color.Black;
            this.manageUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUserButton.ForeColor = System.Drawing.Color.LightYellow;
            this.manageUserButton.Location = new System.Drawing.Point(644, 229);
            this.manageUserButton.Name = "manageUserButton";
            this.manageUserButton.Size = new System.Drawing.Size(170, 57);
            this.manageUserButton.TabIndex = 10;
            this.manageUserButton.Text = "Management";
            this.manageUserButton.UseVisualStyleBackColor = false;
            this.manageUserButton.Click += new System.EventHandler(this.manageUserButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeButton.Location = new System.Drawing.Point(944, 229);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(164, 57);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pagesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagesTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pagesTextBox.Location = new System.Drawing.Point(223, 165);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(326, 34);
            this.pagesTextBox.TabIndex = 8;
            // 
            // Pages
            // 
            this.Pages.AutoSize = true;
            this.Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pages.Location = new System.Drawing.Point(50, 165);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(95, 32);
            this.Pages.TabIndex = 7;
            this.Pages.Text = "Pages";
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.publishYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishYearTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.publishYearTextBox.Location = new System.Drawing.Point(814, 165);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(294, 34);
            this.publishYearTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(613, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "PublishYear";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Location = new System.Drawing.Point(56, 229);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(185, 57);
            this.add.TabIndex = 4;
            this.add.Text = "Add Book";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateButton.Location = new System.Drawing.Point(247, 229);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(152, 57);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.publisherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.publisherTextBox.Location = new System.Drawing.Point(814, 119);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(294, 34);
            this.publisherTextBox.TabIndex = 1;
            // 
            // Publisher
            // 
            this.Publisher.AutoSize = true;
            this.Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Publisher.Location = new System.Drawing.Point(613, 119);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(134, 32);
            this.Publisher.TabIndex = 0;
            this.Publisher.Text = "Publisher";
            // 
            // languageTextBox
            // 
            this.languageTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.languageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.languageTextBox.Location = new System.Drawing.Point(814, 68);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(294, 34);
            this.languageTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(613, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Language";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.categoryTextBox.Location = new System.Drawing.Point(814, 22);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(294, 34);
            this.categoryTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(613, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            // 
            // authorTextBox
            // 
            this.authorTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.authorTextBox.Location = new System.Drawing.Point(223, 119);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(326, 34);
            this.authorTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(50, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Author";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(50, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "BookName";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bookNameTextBox.Location = new System.Drawing.Point(223, 68);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(326, 34);
            this.bookNameTextBox.TabIndex = 1;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.isbnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.isbnTextBox.Location = new System.Drawing.Point(223, 26);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(326, 34);
            this.isbnTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 426);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 805);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1161, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "StatusStrip";
            // 
            // AdminForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 827);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip);
            this.Name = "AdminForms";
            this.Text = "AdminForms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button reserveBook;
        private System.Windows.Forms.Button manageUserButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.Label Pages;
        private System.Windows.Forms.TextBox publishYearTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}