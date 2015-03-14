namespace HomeWork
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }


        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxId = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxType = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxModel = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxCreate = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxRepair = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.linkLabelInternet = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRemoveRow = new System.Windows.Forms.Button();
            this.toolTipId = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxSearch = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMostPopular = new System.Windows.Forms.CheckBox();
            this.checkBoxPopularYears = new System.Windows.Forms.CheckBox();
            this.checkBoxOldRepaired = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1874, 47);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileCreate,
            this.menuFileOpen,
            this.toolStripSeparator,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator1,
            this.menuFilePrint,
            this.toolStripSeparator2,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(86, 39);
            this.menuFile.Text = "&Файл";
            // 
            // menuFileCreate
            // 
            this.menuFileCreate.Image = ((System.Drawing.Image)(resources.GetObject("menuFileCreate.Image")));
            this.menuFileCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileCreate.Name = "menuFileCreate";
            this.menuFileCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileCreate.Size = new System.Drawing.Size(294, 40);
            this.menuFileCreate.Text = "&Создать";
            this.menuFileCreate.Click += new System.EventHandler(this.menuFileCreate_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(294, 40);
            this.menuFileOpen.Text = "&Открыть";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(291, 6);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(294, 40);
            this.menuFileSave.Text = "&Сохранить";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(294, 40);
            this.menuFileSaveAs.Text = "Сохранить &как";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(291, 6);
            // 
            // menuFilePrint
            // 
            this.menuFilePrint.Image = ((System.Drawing.Image)(resources.GetObject("menuFilePrint.Image")));
            this.menuFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFilePrint.Name = "menuFilePrint";
            this.menuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuFilePrint.Size = new System.Drawing.Size(294, 40);
            this.menuFilePrint.Text = "&Печать";
            this.menuFilePrint.Click += new System.EventHandler(this.menuFilePrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(291, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuFileExit.Size = new System.Drawing.Size(294, 40);
            this.menuFileExit.Text = "&Выход";
            this.menuFileExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuFileExit.ToolTipText = "Выйти из приложения";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(122, 39);
            this.menuHelp.Text = "Спра&вка";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(262, 40);
            this.menuHelpAbout.Text = "&О программе...";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolButtonNew,
            this.toolButtonOpen,
            this.toolButtonSave,
            this.toolButtonPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 47);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1874, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolButtonNew
            // 
            this.toolButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonNew.Image")));
            this.toolButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonNew.Name = "toolButtonNew";
            this.toolButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolButtonNew.Text = "&Создать";
            this.toolButtonNew.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // toolButtonOpen
            // 
            this.toolButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonOpen.Image")));
            this.toolButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonOpen.Name = "toolButtonOpen";
            this.toolButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolButtonOpen.Text = "&Открыть";
            this.toolButtonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // toolButtonSave
            // 
            this.toolButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonSave.Image")));
            this.toolButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonSave.Name = "toolButtonSave";
            this.toolButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolButtonSave.Text = "Сохранить";
            this.toolButtonSave.Click += new System.EventHandler(this.saveToolButton_Click);
            // 
            // toolButtonPrint
            // 
            this.toolButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonPrint.Image")));
            this.toolButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonPrint.Name = "toolButtonPrint";
            this.toolButtonPrint.Size = new System.Drawing.Size(23, 22);
            this.toolButtonPrint.Text = "&Печать";
            this.toolButtonPrint.Click += new System.EventHandler(this.toolButtonPrint_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "trains";
            this.openFileDialog1.Filter = "Файлы данных .trains|*.trains|Все файлы|*.*";
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.Title = "Открыть файл данных";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSelect,
            this.id,
            this.type,
            this.model,
            this.create,
            this.repair});
            this.dataGridView1.Location = new System.Drawing.Point(24, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(1120, 769);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 832);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            this.dataGridView1.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridView_SortCompare);
            // 
            // columnSelect
            // 
            this.columnSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnSelect.DividerWidth = 1;
            this.columnSelect.FalseValue = "1";
            this.columnSelect.HeaderText = "";
            this.columnSelect.IndeterminateValue = 2;
            this.columnSelect.Name = "columnSelect";
            this.columnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnSelect.ToolTipText = "Выборка множества локомотивов для сортировки";
            this.columnSelect.TrueValue = "0";
            this.columnSelect.Width = 20;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "ИН";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.ToolTipText = "Инвентарный номер";
            this.id.Width = 69;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.type.DefaultCellStyle = dataGridViewCellStyle3;
            this.type.HeaderText = "Тип";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.ToolTipText = "Тип локомотива";
            this.type.Width = 73;
            // 
            // model
            // 
            this.model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.model.DefaultCellStyle = dataGridViewCellStyle4;
            this.model.HeaderText = "Модель";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.ToolTipText = "Модель локомотива";
            // 
            // create
            // 
            this.create.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            this.create.DefaultCellStyle = dataGridViewCellStyle5;
            this.create.HeaderText = "Дата создания";
            this.create.Name = "create";
            this.create.ReadOnly = true;
            this.create.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.create.ToolTipText = "Дата создания локомотива";
            // 
            // repair
            // 
            this.repair.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.repair.DefaultCellStyle = dataGridViewCellStyle6;
            this.repair.HeaderText = "Дата ремонта";
            this.repair.Name = "repair";
            this.repair.ReadOnly = true;
            this.repair.ToolTipText = "Дата последнего ремонта локомитива";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1186, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Инвентарный &номер:";
            // 
            // richTextBoxId
            // 
            this.richTextBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxId.DetectUrls = false;
            this.richTextBoxId.EnableAutoDragDrop = true;
            this.richTextBoxId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxId.Location = new System.Drawing.Point(1454, 144);
            this.richTextBoxId.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBoxId.Multiline = false;
            this.richTextBoxId.Name = "richTextBoxId";
            this.richTextBoxId.Size = new System.Drawing.Size(386, 31);
            this.richTextBoxId.TabIndex = 7;
            this.richTextBoxId.Text = "";
            this.richTextBoxId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxes_Validating);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "trains";
            this.saveFileDialog.Filter = "Файлы данных .trains|*.trains|Все файлы|*.*";
            this.saveFileDialog.Title = "Сохранить базу локомотивов";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1334, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Информация о локомотиве";
            // 
            // richTextBoxType
            // 
            this.richTextBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxType.DetectUrls = false;
            this.richTextBoxType.EnableAutoDragDrop = true;
            this.richTextBoxType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxType.Location = new System.Drawing.Point(1454, 190);
            this.richTextBoxType.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBoxType.Multiline = false;
            this.richTextBoxType.Name = "richTextBoxType";
            this.richTextBoxType.Size = new System.Drawing.Size(386, 31);
            this.richTextBoxType.TabIndex = 10;
            this.richTextBoxType.Text = "";
            this.richTextBoxType.TextChanged += new System.EventHandler(this.richTextBoxType_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1374, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "&Тип:";
            // 
            // richTextBoxModel
            // 
            this.richTextBoxModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxModel.DetectUrls = false;
            this.richTextBoxModel.EnableAutoDragDrop = true;
            this.richTextBoxModel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxModel.Location = new System.Drawing.Point(1454, 237);
            this.richTextBoxModel.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBoxModel.Multiline = false;
            this.richTextBoxModel.Name = "richTextBoxModel";
            this.richTextBoxModel.Size = new System.Drawing.Size(386, 31);
            this.richTextBoxModel.TabIndex = 12;
            this.richTextBoxModel.Text = "";
            this.richTextBoxModel.TextChanged += new System.EventHandler(this.richTextBoxModel_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1334, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "&Модель:";
            // 
            // richTextBoxCreate
            // 
            this.richTextBoxCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCreate.DetectUrls = false;
            this.richTextBoxCreate.EnableAutoDragDrop = true;
            this.richTextBoxCreate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxCreate.Location = new System.Drawing.Point(1454, 283);
            this.richTextBoxCreate.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBoxCreate.Multiline = false;
            this.richTextBoxCreate.Name = "richTextBoxCreate";
            this.richTextBoxCreate.Size = new System.Drawing.Size(386, 31);
            this.richTextBoxCreate.TabIndex = 14;
            this.richTextBoxCreate.Text = "";
            this.richTextBoxCreate.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxes_Validating);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1254, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Дата &создания:";
            // 
            // richTextBoxRepair
            // 
            this.richTextBoxRepair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxRepair.DetectUrls = false;
            this.richTextBoxRepair.EnableAutoDragDrop = true;
            this.richTextBoxRepair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxRepair.Location = new System.Drawing.Point(1454, 329);
            this.richTextBoxRepair.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBoxRepair.Multiline = false;
            this.richTextBoxRepair.Name = "richTextBoxRepair";
            this.richTextBoxRepair.Size = new System.Drawing.Size(386, 31);
            this.richTextBoxRepair.TabIndex = 16;
            this.richTextBoxRepair.Text = "";
            this.richTextBoxRepair.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxes_Validating);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1204, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Последний &ремонт:";
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddRow.Location = new System.Drawing.Point(1209, 499);
            this.buttonAddRow.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(280, 63);
            this.buttonAddRow.TabIndex = 24;
            this.buttonAddRow.Text = "Создать запись";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // linkLabelInternet
            // 
            this.linkLabelInternet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelInternet.AutoSize = true;
            this.linkLabelInternet.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelInternet.Location = new System.Drawing.Point(1448, 381);
            this.linkLabelInternet.Margin = new System.Windows.Forms.Padding(6);
            this.linkLabelInternet.MaximumSize = new System.Drawing.Size(392, 26);
            this.linkLabelInternet.Name = "linkLabelInternet";
            this.linkLabelInternet.Size = new System.Drawing.Size(161, 26);
            this.linkLabelInternet.TabIndex = 17;
            this.linkLabelInternet.TabStop = true;
            this.linkLabelInternet.Text = "www.yandex.ru";
            this.linkLabelInternet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelInternet.UseMnemonic = false;
            this.linkLabelInternet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInternet_LinkClicked);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1210, 379);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "Найти в интернете:";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSaveChanges.Location = new System.Drawing.Point(1560, 499);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(280, 63);
            this.buttonSaveChanges.TabIndex = 23;
            this.buttonSaveChanges.Text = "Сохранить изменения";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // buttonRemoveRow
            // 
            this.buttonRemoveRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveRow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRemoveRow.Location = new System.Drawing.Point(1209, 574);
            this.buttonRemoveRow.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRemoveRow.Name = "buttonRemoveRow";
            this.buttonRemoveRow.Size = new System.Drawing.Size(280, 63);
            this.buttonRemoveRow.TabIndex = 26;
            this.buttonRemoveRow.Text = "Удалить запись";
            this.buttonRemoveRow.UseVisualStyleBackColor = true;
            this.buttonRemoveRow.Click += new System.EventHandler(this.buttonRemoveRow_Click);
            // 
            // toolTipId
            // 
            this.toolTipId.AutoPopDelay = 5000;
            this.toolTipId.InitialDelay = 500;
            this.toolTipId.IsBalloon = true;
            this.toolTipId.ReshowDelay = 100;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.DetectUrls = false;
            this.textBoxSearch.EnableAutoDragDrop = true;
            this.textBoxSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(1454, 423);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSearch.Multiline = false;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(386, 31);
            this.textBoxSearch.TabIndex = 22;
            this.textBoxSearch.Text = "";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1208, 427);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 27);
            this.label8.TabIndex = 23;
            this.label8.Text = "&Поисковый запрос:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxMostPopular);
            this.groupBox1.Controls.Add(this.checkBoxPopularYears);
            this.groupBox1.Controls.Add(this.checkBoxOldRepaired);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1209, 666);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 268);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выделить:";
            // 
            // checkBoxMostPopular
            // 
            this.checkBoxMostPopular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMostPopular.Font = new System.Drawing.Font("Arial", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMostPopular.Location = new System.Drawing.Point(17, 206);
            this.checkBoxMostPopular.Name = "checkBoxMostPopular";
            this.checkBoxMostPopular.Size = new System.Drawing.Size(614, 56);
            this.checkBoxMostPopular.TabIndex = 29;
            this.checkBoxMostPopular.Text = "Наиболее представленные модели";
            this.checkBoxMostPopular.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxPopularYears
            // 
            this.checkBoxPopularYears.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPopularYears.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxPopularYears.Font = new System.Drawing.Font("Arial", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPopularYears.Location = new System.Drawing.Point(17, 111);
            this.checkBoxPopularYears.Name = "checkBoxPopularYears";
            this.checkBoxPopularYears.Size = new System.Drawing.Size(614, 89);
            this.checkBoxPopularYears.TabIndex = 28;
            this.checkBoxPopularYears.Text = "Годы, в которые было построено\r\nбольше всего локомотивов\r\n";
            this.checkBoxPopularYears.UseVisualStyleBackColor = true;
            this.checkBoxPopularYears.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxOldRepaired
            // 
            this.checkBoxOldRepaired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOldRepaired.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxOldRepaired.Font = new System.Drawing.Font("Arial", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxOldRepaired.Location = new System.Drawing.Point(17, 40);
            this.checkBoxOldRepaired.Name = "checkBoxOldRepaired";
            this.checkBoxOldRepaired.Size = new System.Drawing.Size(614, 61);
            this.checkBoxOldRepaired.TabIndex = 27;
            this.checkBoxOldRepaired.Text = "Локомотивы, ремонтировавшиеся \r\nболее пяти лет назад";
            this.checkBoxOldRepaired.UseVisualStyleBackColor = true;
            this.checkBoxOldRepaired.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSelectAll.Location = new System.Drawing.Point(1560, 574);
            this.buttonSelectAll.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(280, 63);
            this.buttonSelectAll.TabIndex = 25;
            this.buttonSelectAll.Text = "Выделить все строки";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1874, 951);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRemoveRow);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabelInternet);
            this.Controls.Add(this.buttonAddRow);
            this.Controls.Add(this.richTextBoxRepair);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBoxModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1900, 1020);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа для работы с базой локомотивов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.eventFormShown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileCreate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolButtonNew;
        private System.Windows.Forms.ToolStripButton toolButtonOpen;
        private System.Windows.Forms.ToolStripButton toolButtonSave;
        private System.Windows.Forms.ToolStripButton toolButtonPrint;
        protected System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox richTextBoxType;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox richTextBoxModel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RichTextBox richTextBoxCreate;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.RichTextBox richTextBoxRepair;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RichTextBox richTextBoxId;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.LinkLabel linkLabelInternet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSaveChanges;
        protected System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonRemoveRow;
        protected System.Windows.Forms.ToolTip toolTipId;
        public System.Windows.Forms.RichTextBox textBoxSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxMostPopular;
        private System.Windows.Forms.CheckBox checkBoxPopularYears;
        private System.Windows.Forms.CheckBox checkBoxOldRepaired;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn create;
        private System.Windows.Forms.DataGridViewTextBoxColumn repair;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

