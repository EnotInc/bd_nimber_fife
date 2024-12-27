namespace DB_laba5
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mosovLabaOneDataSet = new DB_laba5.MosovLabaOneDataSet();
            this.LabelName = new System.Windows.Forms.Label();
            this.YearOfPublishLabel = new System.Windows.Forms.Label();
            this.YearOfBublishBox = new System.Windows.Forms.TextBox();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.PublisherBox = new System.Windows.Forms.MaskedTextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.книгиTableAdapter = new DB_laba5.MosovLabaOneDataSetTableAdapters.КнигиTableAdapter();
            this.OpenBooksForm = new System.Windows.Forms.Button();
            this.EmptyFieldsBox = new System.Windows.Forms.TextBox();
            this.LabelEmptyFields = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RedactButton = new System.Windows.Forms.Button();
            this.PagesAmountBox = new System.Windows.Forms.TextBox();
            this.PagesAmountLabel = new System.Windows.Forms.Label();
            this.AuthorCodeBox = new System.Windows.Forms.TextBox();
            this.BookCodeBox = new System.Windows.Forms.TextBox();
            this.BookCodeLabel = new System.Windows.Forms.Label();
            this.AuthorCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mosovLabaOneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PageNameLabel
            // 
            this.PageNameLabel.AutoSize = true;
            this.PageNameLabel.Location = new System.Drawing.Point(351, 49);
            this.PageNameLabel.Name = "PageNameLabel";
            this.PageNameLabel.Size = new System.Drawing.Size(37, 13);
            this.PageNameLabel.TabIndex = 0;
            this.PageNameLabel.Text = "Книги";
            this.PageNameLabel.Click += new System.EventHandler(this.PageNameLable_Click);
            // 
            // NameBox
            // 
            this.NameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Название", true));
            this.NameBox.Location = new System.Drawing.Point(192, 129);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(256, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.mosovLabaOneDataSet;
            // 
            // mosovLabaOneDataSet
            // 
            this.mosovLabaOneDataSet.DataSetName = "MosovLabaOneDataSet";
            this.mosovLabaOneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(454, 132);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(89, 13);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Название книги";
            // 
            // YearOfPublishLabel
            // 
            this.YearOfPublishLabel.AutoSize = true;
            this.YearOfPublishLabel.Location = new System.Drawing.Point(454, 158);
            this.YearOfPublishLabel.Name = "YearOfPublishLabel";
            this.YearOfPublishLabel.Size = new System.Drawing.Size(72, 13);
            this.YearOfPublishLabel.TabIndex = 4;
            this.YearOfPublishLabel.Text = "Год Издания";
            // 
            // YearOfBublishBox
            // 
            this.YearOfBublishBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Год_издания", true));
            this.YearOfBublishBox.Location = new System.Drawing.Point(192, 155);
            this.YearOfBublishBox.Name = "YearOfBublishBox";
            this.YearOfBublishBox.Size = new System.Drawing.Size(256, 20);
            this.YearOfBublishBox.TabIndex = 3;
            this.YearOfBublishBox.TextChanged += new System.EventHandler(this.YearOfBublishBox_TextChanged);
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Location = new System.Drawing.Point(454, 184);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(79, 13);
            this.PublisherLabel.TabIndex = 6;
            this.PublisherLabel.Text = "Издательство";
            // 
            // PublisherBox
            // 
            this.PublisherBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Издательство", true));
            this.PublisherBox.Location = new System.Drawing.Point(192, 181);
            this.PublisherBox.Name = "PublisherBox";
            this.PublisherBox.Size = new System.Drawing.Size(256, 20);
            this.PublisherBox.TabIndex = 7;
            this.PublisherBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PublisherBox_MaskInputRejected);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.книгиBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 8;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Visible = false;
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.mosovLabaOneDataSet;
            this.bindingSource1.Position = 0;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // OpenBooksForm
            // 
            this.OpenBooksForm.Location = new System.Drawing.Point(287, 45);
            this.OpenBooksForm.Name = "OpenBooksForm";
            this.OpenBooksForm.Size = new System.Drawing.Size(58, 21);
            this.OpenBooksForm.TabIndex = 17;
            this.OpenBooksForm.Text = "Авторы";
            this.OpenBooksForm.UseVisualStyleBackColor = true;
            this.OpenBooksForm.Click += new System.EventHandler(this.OpenAuthorsForm_Click);
            // 
            // EmptyFieldsBox
            // 
            this.EmptyFieldsBox.Enabled = false;
            this.EmptyFieldsBox.Location = new System.Drawing.Point(192, 245);
            this.EmptyFieldsBox.Name = "EmptyFieldsBox";
            this.EmptyFieldsBox.Size = new System.Drawing.Size(256, 20);
            this.EmptyFieldsBox.TabIndex = 18;
            // 
            // LabelEmptyFields
            // 
            this.LabelEmptyFields.AutoSize = true;
            this.LabelEmptyFields.Location = new System.Drawing.Point(454, 252);
            this.LabelEmptyFields.Name = "LabelEmptyFields";
            this.LabelEmptyFields.Size = new System.Drawing.Size(72, 13);
            this.LabelEmptyFields.TabIndex = 19;
            this.LabelEmptyFields.Text = "Пустые поля";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(192, 297);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 35);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RedactButton
            // 
            this.RedactButton.Location = new System.Drawing.Point(331, 297);
            this.RedactButton.Name = "RedactButton";
            this.RedactButton.Size = new System.Drawing.Size(117, 35);
            this.RedactButton.TabIndex = 21;
            this.RedactButton.Text = "Изменить";
            this.RedactButton.UseVisualStyleBackColor = true;
            this.RedactButton.Click += new System.EventHandler(this.RedactButton_Click);
            // 
            // PagesAmountBox
            // 
            this.PagesAmountBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Колво_стр", true));
            this.PagesAmountBox.Location = new System.Drawing.Point(192, 207);
            this.PagesAmountBox.Name = "PagesAmountBox";
            this.PagesAmountBox.Size = new System.Drawing.Size(256, 20);
            this.PagesAmountBox.TabIndex = 22;
            this.PagesAmountBox.TextChanged += new System.EventHandler(this.PagesAmountBox_TextChanged);
            // 
            // PagesAmountLabel
            // 
            this.PagesAmountLabel.AutoSize = true;
            this.PagesAmountLabel.Location = new System.Drawing.Point(454, 210);
            this.PagesAmountLabel.Name = "PagesAmountLabel";
            this.PagesAmountLabel.Size = new System.Drawing.Size(86, 13);
            this.PagesAmountLabel.TabIndex = 23;
            this.PagesAmountLabel.Text = "Кол-во Страниц";
            // 
            // AuthorCodeBox
            // 
            this.AuthorCodeBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Код_Автора", true));
            this.AuthorCodeBox.Location = new System.Drawing.Point(348, 77);
            this.AuthorCodeBox.Name = "AuthorCodeBox";
            this.AuthorCodeBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorCodeBox.TabIndex = 24;
            this.AuthorCodeBox.TextChanged += new System.EventHandler(this.AuthorCodeBox_TextChanged);
            // 
            // BookCodeBox
            // 
            this.BookCodeBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Код_книги", true));
            this.BookCodeBox.Location = new System.Drawing.Point(348, 103);
            this.BookCodeBox.Name = "BookCodeBox";
            this.BookCodeBox.Size = new System.Drawing.Size(100, 20);
            this.BookCodeBox.TabIndex = 25;
            this.BookCodeBox.TextChanged += new System.EventHandler(this.BookCodeBox_TextChanged);
            // 
            // BookCodeLabel
            // 
            this.BookCodeLabel.AutoSize = true;
            this.BookCodeLabel.Location = new System.Drawing.Point(454, 106);
            this.BookCodeLabel.Name = "BookCodeLabel";
            this.BookCodeLabel.Size = new System.Drawing.Size(59, 13);
            this.BookCodeLabel.TabIndex = 26;
            this.BookCodeLabel.Text = "Код Книги";
            // 
            // AuthorCodeLabel
            // 
            this.AuthorCodeLabel.AutoSize = true;
            this.AuthorCodeLabel.Location = new System.Drawing.Point(454, 80);
            this.AuthorCodeLabel.Name = "AuthorCodeLabel";
            this.AuthorCodeLabel.Size = new System.Drawing.Size(65, 13);
            this.AuthorCodeLabel.TabIndex = 27;
            this.AuthorCodeLabel.Text = "Код Автора";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AuthorCodeLabel);
            this.Controls.Add(this.BookCodeLabel);
            this.Controls.Add(this.BookCodeBox);
            this.Controls.Add(this.AuthorCodeBox);
            this.Controls.Add(this.PagesAmountLabel);
            this.Controls.Add(this.PagesAmountBox);
            this.Controls.Add(this.RedactButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LabelEmptyFields);
            this.Controls.Add(this.EmptyFieldsBox);
            this.Controls.Add(this.OpenBooksForm);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.PublisherBox);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.YearOfPublishLabel);
            this.Controls.Add(this.YearOfBublishBox);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PageNameLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mosovLabaOneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label YearOfPublishLabel;
        private System.Windows.Forms.TextBox YearOfBublishBox;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.MaskedTextBox PublisherBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MosovLabaOneDataSet mosovLabaOneDataSet;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private MosovLabaOneDataSetTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.Button OpenBooksForm;
        private System.Windows.Forms.TextBox EmptyFieldsBox;
        private System.Windows.Forms.Label LabelEmptyFields;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RedactButton;
        private System.Windows.Forms.TextBox PagesAmountBox;
        private System.Windows.Forms.Label PagesAmountLabel;
        private System.Windows.Forms.TextBox AuthorCodeBox;
        private System.Windows.Forms.TextBox BookCodeBox;
        private System.Windows.Forms.Label BookCodeLabel;
        private System.Windows.Forms.Label AuthorCodeLabel;
    }
}