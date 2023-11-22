namespace View
{
    partial class UserForms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.displayUserNameComboBox = new View.DisplayUserNameComboBox();
            this.tabUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabUserTableAdapter = new View.DisplayUserNameComboBoxTableAdapters.TabUserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayUserNameComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.searchTextBox.Location = new System.Drawing.Point(29, 30);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(1008, 49);
            this.searchTextBox.TabIndex = 1;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.search.Location = new System.Drawing.Point(887, 30);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(156, 61);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.ItemHeight = 29;
            this.filterComboBox.Items.AddRange(new object[] {
            "BookName",
            "PublishYear",
            "ISBN"});
            this.filterComboBox.Location = new System.Drawing.Point(716, 41);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(165, 37);
            this.filterComboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(1069, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Select a book to reserve";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.Highlight;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout.Location = new System.Drawing.Point(1066, 411);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(238, 56);
            this.logout.TabIndex = 22;
            this.logout.Text = "Back";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(1069, 312);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(238, 53);
            this.returnButton.TabIndex = 19;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.SystemColors.Info;
            this.reserveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveButton.Location = new System.Drawing.Point(1069, 253);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(238, 53);
            this.reserveButton.TabIndex = 18;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.UseVisualStyleBackColor = false;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(1061, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 48);
            this.label1.TabIndex = 24;
            this.label1.Text = "UserName";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tabUserBindingSource;
            this.comboBox1.DisplayMember = "UID";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1066, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 37);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "UID";
            // 
            // displayUserNameComboBox
            // 
            this.displayUserNameComboBox.DataSetName = "DisplayUserNameComboBox";
            this.displayUserNameComboBox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabUserBindingSource
            // 
            this.tabUserBindingSource.DataMember = "TabUser";
            this.tabUserBindingSource.DataSource = this.displayUserNameComboBox;
            // 
            // tabUserTableAdapter
            // 
            this.tabUserTableAdapter.ClearBeforeFill = true;
            // 
            // UserForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserForms";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayUserNameComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DisplayUserNameComboBox displayUserNameComboBox;
        private System.Windows.Forms.BindingSource tabUserBindingSource;
        private DisplayUserNameComboBoxTableAdapters.TabUserTableAdapter tabUserTableAdapter;
    }
}

