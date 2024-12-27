namespace DB_laba5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SureNameBox = new System.Windows.Forms.TextBox();
            this.авторыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mosovLabaOneDataSet = new DB_laba5.MosovLabaOneDataSet();
            this.LabelSurename = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelMiddleName = new System.Windows.Forms.Label();
            this.LabelBooksAmount = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.авторыTableAdapter = new DB_laba5.MosovLabaOneDataSetTableAdapters.АвторыTableAdapter();
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
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгиTableAdapter = new DB_laba5.MosovLabaOneDataSetTableAdapters.КнигиTableAdapter();
            this.книгиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RedactButton = new System.Windows.Forms.Button();
            this.LabelDateOfBirth = new System.Windows.Forms.Label();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.OpenBooksForm = new System.Windows.Forms.Button();
            this.NationalityBox = new System.Windows.Forms.TextBox();
            this.OccupationBox = new System.Windows.Forms.TextBox();
            this.LabelOccupaton = new System.Windows.Forms.Label();
            this.LabelNationality = new System.Windows.Forms.Label();
            this.AuthorCodeBox = new System.Windows.Forms.TextBox();
            this.AuthorCodeLabel = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.авторыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mosovLabaOneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // SureNameBox
            // 
            this.SureNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.авторыBindingSource, "Фамилия", true));
            this.SureNameBox.Location = new System.Drawing.Point(228, 118);
            this.SureNameBox.Name = "SureNameBox";
            this.SureNameBox.Size = new System.Drawing.Size(256, 20);
            this.SureNameBox.TabIndex = 0;
            this.SureNameBox.TextChanged += new System.EventHandler(this.SureNameBox_TextChanged);
            // 
            // авторыBindingSource
            // 
            this.авторыBindingSource.DataMember = "Авторы";
            this.авторыBindingSource.DataSource = this.mosovLabaOneDataSet;
            // 
            // mosovLabaOneDataSet
            // 
            this.mosovLabaOneDataSet.DataSetName = "MosovLabaOneDataSet";
            this.mosovLabaOneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LabelSurename
            // 
            this.LabelSurename.AutoSize = true;
            this.LabelSurename.Location = new System.Drawing.Point(490, 121);
            this.LabelSurename.Name = "LabelSurename";
            this.LabelSurename.Size = new System.Drawing.Size(56, 13);
            this.LabelSurename.TabIndex = 3;
            this.LabelSurename.Text = "Фамилия";
            this.LabelSurename.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(490, 147);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(29, 13);
            this.LabelName.TabIndex = 4;
            this.LabelName.Text = "Имя";
            // 
            // LabelMiddleName
            // 
            this.LabelMiddleName.AutoSize = true;
            this.LabelMiddleName.Location = new System.Drawing.Point(490, 173);
            this.LabelMiddleName.Name = "LabelMiddleName";
            this.LabelMiddleName.Size = new System.Drawing.Size(48, 13);
            this.LabelMiddleName.TabIndex = 5;
            this.LabelMiddleName.Text = "Отчесто";
            // 
            // LabelBooksAmount
            // 
            this.LabelBooksAmount.AutoSize = true;
            this.LabelBooksAmount.Location = new System.Drawing.Point(490, 277);
            this.LabelBooksAmount.Name = "LabelBooksAmount";
            this.LabelBooksAmount.Size = new System.Drawing.Size(106, 13);
            this.LabelBooksAmount.TabIndex = 7;
            this.LabelBooksAmount.Text = "Кол-во книг Автора";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.mosovLabaOneDataSet;
            this.bindingSource1.Position = 0;
            // 
            // авторыTableAdapter
            // 
            this.авторыTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.авторыBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(802, 25);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click_1);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.авторыBindingSource, "Отчество", true));
            this.MiddleNameBox.Location = new System.Drawing.Point(228, 170);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(256, 20);
            this.MiddleNameBox.TabIndex = 2;
            this.MiddleNameBox.TextChanged += new System.EventHandler(this.MiddleNameBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.авторыBindingSource, "Имя", true));
            this.NameBox.Location = new System.Drawing.Point(228, 144);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(256, 20);
            this.NameBox.TabIndex = 9;
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.mosovLabaOneDataSet;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // книгиBindingSource1
            // 
            this.книгиBindingSource1.DataMember = "Книги";
            this.книгиBindingSource1.DataSource = this.mosovLabaOneDataSet;
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(384, 274);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(100, 20);
            this.AmountBox.TabIndex = 10;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(228, 319);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 35);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавть";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RedactButton
            // 
            this.RedactButton.Location = new System.Drawing.Point(367, 323);
            this.RedactButton.Name = "RedactButton";
            this.RedactButton.Size = new System.Drawing.Size(117, 31);
            this.RedactButton.TabIndex = 12;
            this.RedactButton.Text = "Изменить";
            this.RedactButton.UseVisualStyleBackColor = true;
            this.RedactButton.Click += new System.EventHandler(this.RedactButton_Click);
            // 
            // LabelDateOfBirth
            // 
            this.LabelDateOfBirth.AutoSize = true;
            this.LabelDateOfBirth.Location = new System.Drawing.Point(490, 199);
            this.LabelDateOfBirth.Name = "LabelDateOfBirth";
            this.LabelDateOfBirth.Size = new System.Drawing.Size(87, 13);
            this.LabelDateOfBirth.TabIndex = 14;
            this.LabelDateOfBirth.Text = "Дата Рождения";
            // 
            // PageNameLabel
            // 
            this.PageNameLabel.AutoSize = true;
            this.PageNameLabel.Location = new System.Drawing.Point(342, 55);
            this.PageNameLabel.Name = "PageNameLabel";
            this.PageNameLabel.Size = new System.Drawing.Size(45, 13);
            this.PageNameLabel.TabIndex = 15;
            this.PageNameLabel.Text = "Авторы";
            this.PageNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // OpenBooksForm
            // 
            this.OpenBooksForm.Location = new System.Drawing.Point(393, 51);
            this.OpenBooksForm.Name = "OpenBooksForm";
            this.OpenBooksForm.Size = new System.Drawing.Size(58, 21);
            this.OpenBooksForm.TabIndex = 16;
            this.OpenBooksForm.Text = "Книги";
            this.OpenBooksForm.UseVisualStyleBackColor = true;
            this.OpenBooksForm.Click += new System.EventHandler(this.OpenBooksForm_Click);
            // 
            // NationalityBox
            // 
            this.NationalityBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.авторыBindingSource, "Национальность", true));
            this.NationalityBox.Location = new System.Drawing.Point(228, 222);
            this.NationalityBox.Name = "NationalityBox";
            this.NationalityBox.Size = new System.Drawing.Size(256, 20);
            this.NationalityBox.TabIndex = 17;
            // 
            // OccupationBox
            // 
            this.OccupationBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.авторыBindingSource, "Род_деятельности", true));
            this.OccupationBox.Location = new System.Drawing.Point(228, 248);
            this.OccupationBox.Name = "OccupationBox";
            this.OccupationBox.Size = new System.Drawing.Size(256, 20);
            this.OccupationBox.TabIndex = 18;
            // 
            // LabelOccupaton
            // 
            this.LabelOccupaton.AutoSize = true;
            this.LabelOccupaton.Location = new System.Drawing.Point(490, 251);
            this.LabelOccupaton.Name = "LabelOccupaton";
            this.LabelOccupaton.Size = new System.Drawing.Size(102, 13);
            this.LabelOccupaton.TabIndex = 20;
            this.LabelOccupaton.Text = "Род Деятельности";
            // 
            // LabelNationality
            // 
            this.LabelNationality.AutoSize = true;
            this.LabelNationality.Location = new System.Drawing.Point(490, 225);
            this.LabelNationality.Name = "LabelNationality";
            this.LabelNationality.Size = new System.Drawing.Size(92, 13);
            this.LabelNationality.TabIndex = 19;
            this.LabelNationality.Text = "Национальность";
            // 
            // AuthorCodeBox
            // 
            this.AuthorCodeBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.авторыBindingSource, "Код_Автора", true));
            this.AuthorCodeBox.Location = new System.Drawing.Point(384, 92);
            this.AuthorCodeBox.Name = "AuthorCodeBox";
            this.AuthorCodeBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorCodeBox.TabIndex = 21;
            this.AuthorCodeBox.TextChanged += new System.EventHandler(this.AuthorCodeBox_TextChanged);
            // 
            // AuthorCodeLabel
            // 
            this.AuthorCodeLabel.AutoSize = true;
            this.AuthorCodeLabel.Location = new System.Drawing.Point(490, 95);
            this.AuthorCodeLabel.Name = "AuthorCodeLabel";
            this.AuthorCodeLabel.Size = new System.Drawing.Size(65, 13);
            this.AuthorCodeLabel.TabIndex = 22;
            this.AuthorCodeLabel.Text = "Код Автора";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.авторыBindingSource, "Дата_рожения", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(228, 196);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(256, 20);
            this.maskedTextBox1.TabIndex = 24;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.AuthorCodeLabel);
            this.Controls.Add(this.AuthorCodeBox);
            this.Controls.Add(this.LabelOccupaton);
            this.Controls.Add(this.LabelNationality);
            this.Controls.Add(this.OccupationBox);
            this.Controls.Add(this.NationalityBox);
            this.Controls.Add(this.OpenBooksForm);
            this.Controls.Add(this.PageNameLabel);
            this.Controls.Add(this.LabelDateOfBirth);
            this.Controls.Add(this.RedactButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.LabelBooksAmount);
            this.Controls.Add(this.LabelMiddleName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelSurename);
            this.Controls.Add(this.MiddleNameBox);
            this.Controls.Add(this.SureNameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.авторыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mosovLabaOneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SureNameBox;
        private System.Windows.Forms.Label LabelSurename;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelMiddleName;
        private System.Windows.Forms.Label LabelBooksAmount;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MosovLabaOneDataSet mosovLabaOneDataSet;
        private System.Windows.Forms.BindingSource авторыBindingSource;
        private MosovLabaOneDataSetTableAdapters.АвторыTableAdapter авторыTableAdapter;
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
        private System.Windows.Forms.TextBox MiddleNameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private MosovLabaOneDataSetTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.BindingSource книгиBindingSource1;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RedactButton;
        private System.Windows.Forms.Label LabelDateOfBirth;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.Button OpenBooksForm;
        private System.Windows.Forms.TextBox NationalityBox;
        private System.Windows.Forms.TextBox OccupationBox;
        private System.Windows.Forms.Label LabelOccupaton;
        private System.Windows.Forms.Label LabelNationality;
        private System.Windows.Forms.TextBox AuthorCodeBox;
        private System.Windows.Forms.Label AuthorCodeLabel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

