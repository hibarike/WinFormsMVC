namespace View
{
    partial class EditingView
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
            this.dTDateofIssue = new System.Windows.Forms.DateTimePicker();
            this.labelIssueDate = new System.Windows.Forms.Label();
            this.labelValidUntil = new System.Windows.Forms.Label();
            this.dTValidUntil = new System.Windows.Forms.DateTimePicker();
            this.pDocument = new System.Windows.Forms.Panel();
            this.panelInvItem = new System.Windows.Forms.Panel();
            this.btnDelII = new System.Windows.Forms.Button();
            this.btnChangeII = new System.Windows.Forms.Button();
            this.btnAddII = new System.Windows.Forms.Button();
            this.grdInventoryItems = new System.Windows.Forms.ListView();
            this.tbNumberOfII = new System.Windows.Forms.TextBox();
            this.labelNumberOfII = new System.Windows.Forms.Label();
            this.tbIIUnit = new System.Windows.Forms.TextBox();
            this.labelIIUnit = new System.Windows.Forms.Label();
            this.tbIIName = new System.Windows.Forms.TextBox();
            this.labelIIName = new System.Windows.Forms.Label();
            this.labelInvItemPanel = new System.Windows.Forms.Label();
            this.tbIINum = new System.Windows.Forms.TextBox();
            this.labelNumberII = new System.Windows.Forms.Label();
            this.panelDoc = new System.Windows.Forms.Panel();
            this.tbContract = new System.Windows.Forms.TextBox();
            this.labelDocPanel = new System.Windows.Forms.Label();
            this.panelOrg = new System.Windows.Forms.Panel();
            this.tbOrg = new System.Windows.Forms.TextBox();
            this.labelOrg = new System.Windows.Forms.Label();
            this.labelOrgpanel = new System.Windows.Forms.Label();
            this.labelDocDate = new System.Windows.Forms.Label();
            this.dTDateDoc = new System.Windows.Forms.DateTimePicker();
            this.panelWho = new System.Windows.Forms.Panel();
            this.panelPass = new System.Windows.Forms.Panel();
            this.labelDatePass = new System.Windows.Forms.Label();
            this.dtPassDate = new System.Windows.Forms.DateTimePicker();
            this.tbPassGiven = new System.Windows.Forms.TextBox();
            this.labelPassGiven = new System.Windows.Forms.Label();
            this.tbPassNumber = new System.Windows.Forms.TextBox();
            this.labelPassNumber = new System.Windows.Forms.Label();
            this.tbPassSerial = new System.Windows.Forms.TextBox();
            this.labelPassSerial = new System.Windows.Forms.Label();
            this.cBIdentDoc = new System.Windows.Forms.ComboBox();
            this.tBPatronymic = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.tBSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPerson = new System.Windows.Forms.Label();
            this.tBNumber = new System.Windows.Forms.TextBox();
            this.labelDocNumber = new System.Windows.Forms.Label();
            this.labelEmpowerment = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pDocument.SuspendLayout();
            this.panelInvItem.SuspendLayout();
            this.panelDoc.SuspendLayout();
            this.panelOrg.SuspendLayout();
            this.panelWho.SuspendLayout();
            this.panelPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTDateofIssue
            // 
            this.dTDateofIssue.Location = new System.Drawing.Point(48, 70);
            this.dTDateofIssue.Name = "dTDateofIssue";
            this.dTDateofIssue.Size = new System.Drawing.Size(200, 22);
            this.dTDateofIssue.TabIndex = 0;
            // 
            // labelIssueDate
            // 
            this.labelIssueDate.AutoSize = true;
            this.labelIssueDate.Location = new System.Drawing.Point(53, 48);
            this.labelIssueDate.Name = "labelIssueDate";
            this.labelIssueDate.Size = new System.Drawing.Size(95, 17);
            this.labelIssueDate.TabIndex = 1;
            this.labelIssueDate.Text = "Дата выдачи";
            // 
            // labelValidUntil
            // 
            this.labelValidUntil.AutoSize = true;
            this.labelValidUntil.Location = new System.Drawing.Point(254, 48);
            this.labelValidUntil.Name = "labelValidUntil";
            this.labelValidUntil.Size = new System.Drawing.Size(130, 17);
            this.labelValidUntil.TabIndex = 3;
            this.labelValidUntil.Text = "Действительна до";
            // 
            // dTValidUntil
            // 
            this.dTValidUntil.Location = new System.Drawing.Point(249, 70);
            this.dTValidUntil.Name = "dTValidUntil";
            this.dTValidUntil.Size = new System.Drawing.Size(200, 22);
            this.dTValidUntil.TabIndex = 2;
            // 
            // pDocument
            // 
            this.pDocument.Controls.Add(this.panelInvItem);
            this.pDocument.Controls.Add(this.panelDoc);
            this.pDocument.Controls.Add(this.panelOrg);
            this.pDocument.Controls.Add(this.labelDocDate);
            this.pDocument.Controls.Add(this.dTDateDoc);
            this.pDocument.Controls.Add(this.panelWho);
            this.pDocument.Controls.Add(this.tBNumber);
            this.pDocument.Controls.Add(this.labelDocNumber);
            this.pDocument.Controls.Add(this.labelEmpowerment);
            this.pDocument.Location = new System.Drawing.Point(48, 122);
            this.pDocument.Name = "pDocument";
            this.pDocument.Size = new System.Drawing.Size(691, 697);
            this.pDocument.TabIndex = 4;
            // 
            // panelInvItem
            // 
            this.panelInvItem.Controls.Add(this.btnDelII);
            this.panelInvItem.Controls.Add(this.btnChangeII);
            this.panelInvItem.Controls.Add(this.btnAddII);
            this.panelInvItem.Controls.Add(this.grdInventoryItems);
            this.panelInvItem.Controls.Add(this.tbNumberOfII);
            this.panelInvItem.Controls.Add(this.labelNumberOfII);
            this.panelInvItem.Controls.Add(this.tbIIUnit);
            this.panelInvItem.Controls.Add(this.labelIIUnit);
            this.panelInvItem.Controls.Add(this.tbIIName);
            this.panelInvItem.Controls.Add(this.labelIIName);
            this.panelInvItem.Controls.Add(this.labelInvItemPanel);
            this.panelInvItem.Controls.Add(this.tbIINum);
            this.panelInvItem.Controls.Add(this.labelNumberII);
            this.panelInvItem.Location = new System.Drawing.Point(37, 375);
            this.panelInvItem.Name = "panelInvItem";
            this.panelInvItem.Size = new System.Drawing.Size(650, 318);
            this.panelInvItem.TabIndex = 8;
            // 
            // btnDelII
            // 
            this.btnDelII.Location = new System.Drawing.Point(115, 76);
            this.btnDelII.Name = "btnDelII";
            this.btnDelII.Size = new System.Drawing.Size(85, 30);
            this.btnDelII.TabIndex = 17;
            this.btnDelII.Text = "Удалить";
            this.btnDelII.UseVisualStyleBackColor = true;
            this.btnDelII.Click += new System.EventHandler(this.btnDelII_Click);
            // 
            // btnChangeII
            // 
            this.btnChangeII.Enabled = false;
            this.btnChangeII.Location = new System.Drawing.Point(206, 76);
            this.btnChangeII.Name = "btnChangeII";
            this.btnChangeII.Size = new System.Drawing.Size(117, 30);
            this.btnChangeII.TabIndex = 16;
            this.btnChangeII.Text = "Изменить";
            this.btnChangeII.UseVisualStyleBackColor = true;
            this.btnChangeII.Click += new System.EventHandler(this.btnChangeII_Click);
            // 
            // btnAddII
            // 
            this.btnAddII.Location = new System.Drawing.Point(24, 76);
            this.btnAddII.Name = "btnAddII";
            this.btnAddII.Size = new System.Drawing.Size(85, 30);
            this.btnAddII.TabIndex = 15;
            this.btnAddII.Text = "Добавить";
            this.btnAddII.UseVisualStyleBackColor = true;
            this.btnAddII.Click += new System.EventHandler(this.btnAddII_Click);
            // 
            // grdInventoryItems
            // 
            this.grdInventoryItems.FullRowSelect = true;
            this.grdInventoryItems.GridLines = true;
            this.grdInventoryItems.Location = new System.Drawing.Point(8, 112);
            this.grdInventoryItems.Name = "grdInventoryItems";
            this.grdInventoryItems.Size = new System.Drawing.Size(635, 203);
            this.grdInventoryItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.grdInventoryItems.TabIndex = 14;
            this.grdInventoryItems.UseCompatibleStateImageBehavior = false;
            this.grdInventoryItems.View = System.Windows.Forms.View.Details;
            this.grdInventoryItems.SelectedIndexChanged += new System.EventHandler(this.grdInventoryItems_SelectedIndexChanged);
            // 
            // tbNumberOfII
            // 
            this.tbNumberOfII.Enabled = false;
            this.tbNumberOfII.Location = new System.Drawing.Point(172, 48);
            this.tbNumberOfII.Name = "tbNumberOfII";
            this.tbNumberOfII.Size = new System.Drawing.Size(471, 22);
            this.tbNumberOfII.TabIndex = 13;
            // 
            // labelNumberOfII
            // 
            this.labelNumberOfII.AutoSize = true;
            this.labelNumberOfII.Location = new System.Drawing.Point(7, 48);
            this.labelNumberOfII.Name = "labelNumberOfII";
            this.labelNumberOfII.Size = new System.Drawing.Size(164, 17);
            this.labelNumberOfII.TabIndex = 12;
            this.labelNumberOfII.Text = "Количество (прописью)";
            // 
            // tbIIUnit
            // 
            this.tbIIUnit.Enabled = false;
            this.tbIIUnit.Location = new System.Drawing.Point(540, 20);
            this.tbIIUnit.Name = "tbIIUnit";
            this.tbIIUnit.Size = new System.Drawing.Size(103, 22);
            this.tbIIUnit.TabIndex = 11;
            // 
            // labelIIUnit
            // 
            this.labelIIUnit.AutoSize = true;
            this.labelIIUnit.Location = new System.Drawing.Point(403, 23);
            this.labelIIUnit.Name = "labelIIUnit";
            this.labelIIUnit.Size = new System.Drawing.Size(133, 17);
            this.labelIIUnit.TabIndex = 10;
            this.labelIIUnit.Text = "Едница измерения";
            // 
            // tbIIName
            // 
            this.tbIIName.Enabled = false;
            this.tbIIName.Location = new System.Drawing.Point(280, 20);
            this.tbIIName.Name = "tbIIName";
            this.tbIIName.Size = new System.Drawing.Size(117, 22);
            this.tbIIName.TabIndex = 9;
            // 
            // labelIIName
            // 
            this.labelIIName.AutoSize = true;
            this.labelIIName.Location = new System.Drawing.Point(178, 20);
            this.labelIIName.Name = "labelIIName";
            this.labelIIName.Size = new System.Drawing.Size(106, 17);
            this.labelIIName.TabIndex = 8;
            this.labelIIName.Text = "Наименование";
            // 
            // labelInvItemPanel
            // 
            this.labelInvItemPanel.AutoSize = true;
            this.labelInvItemPanel.Location = new System.Drawing.Point(-3, -3);
            this.labelInvItemPanel.Name = "labelInvItemPanel";
            this.labelInvItemPanel.Size = new System.Drawing.Size(232, 17);
            this.labelInvItemPanel.TabIndex = 7;
            this.labelInvItemPanel.Text = "Товарно-материальные ценности";
            // 
            // tbIINum
            // 
            this.tbIINum.Enabled = false;
            this.tbIINum.Location = new System.Drawing.Point(59, 20);
            this.tbIINum.Name = "tbIINum";
            this.tbIINum.Size = new System.Drawing.Size(117, 22);
            this.tbIINum.TabIndex = 6;
            // 
            // labelNumberII
            // 
            this.labelNumberII.AutoSize = true;
            this.labelNumberII.Location = new System.Drawing.Point(7, 20);
            this.labelNumberII.Name = "labelNumberII";
            this.labelNumberII.Size = new System.Drawing.Size(46, 17);
            this.labelNumberII.TabIndex = 5;
            this.labelNumberII.Text = "№ п/п";
            // 
            // panelDoc
            // 
            this.panelDoc.Controls.Add(this.tbContract);
            this.panelDoc.Controls.Add(this.labelDocPanel);
            this.panelDoc.Location = new System.Drawing.Point(37, 317);
            this.panelDoc.Name = "panelDoc";
            this.panelDoc.Size = new System.Drawing.Size(650, 52);
            this.panelDoc.TabIndex = 7;
            // 
            // tbContract
            // 
            this.tbContract.Location = new System.Drawing.Point(10, 20);
            this.tbContract.Name = "tbContract";
            this.tbContract.Size = new System.Drawing.Size(387, 22);
            this.tbContract.TabIndex = 9;
            // 
            // labelDocPanel
            // 
            this.labelDocPanel.AutoSize = true;
            this.labelDocPanel.Location = new System.Drawing.Point(-3, 0);
            this.labelDocPanel.Name = "labelDocPanel";
            this.labelDocPanel.Size = new System.Drawing.Size(63, 17);
            this.labelDocPanel.TabIndex = 7;
            this.labelDocPanel.Text = "Договор";
            // 
            // panelOrg
            // 
            this.panelOrg.Controls.Add(this.tbOrg);
            this.panelOrg.Controls.Add(this.labelOrg);
            this.panelOrg.Controls.Add(this.labelOrgpanel);
            this.panelOrg.Location = new System.Drawing.Point(37, 232);
            this.panelOrg.Name = "panelOrg";
            this.panelOrg.Size = new System.Drawing.Size(650, 79);
            this.panelOrg.TabIndex = 6;
            // 
            // tbOrg
            // 
            this.tbOrg.Location = new System.Drawing.Point(10, 49);
            this.tbOrg.Name = "tbOrg";
            this.tbOrg.Size = new System.Drawing.Size(387, 22);
            this.tbOrg.TabIndex = 6;
            // 
            // labelOrg
            // 
            this.labelOrg.AutoSize = true;
            this.labelOrg.Location = new System.Drawing.Point(7, 29);
            this.labelOrg.Name = "labelOrg";
            this.labelOrg.Size = new System.Drawing.Size(160, 17);
            this.labelOrg.TabIndex = 5;
            this.labelOrg.Text = "Название организации";
            // 
            // labelOrgpanel
            // 
            this.labelOrgpanel.AutoSize = true;
            this.labelOrgpanel.Location = new System.Drawing.Point(-3, 0);
            this.labelOrgpanel.Name = "labelOrgpanel";
            this.labelOrgpanel.Size = new System.Drawing.Size(95, 17);
            this.labelOrgpanel.TabIndex = 1;
            this.labelOrgpanel.Text = "Организация";
            // 
            // labelDocDate
            // 
            this.labelDocDate.AutoSize = true;
            this.labelDocDate.Location = new System.Drawing.Point(165, 2);
            this.labelDocDate.Name = "labelDocDate";
            this.labelDocDate.Size = new System.Drawing.Size(116, 17);
            this.labelDocDate.TabIndex = 5;
            this.labelDocDate.Text = "Дата документа";
            // 
            // dTDateDoc
            // 
            this.dTDateDoc.Location = new System.Drawing.Point(160, 24);
            this.dTDateDoc.Name = "dTDateDoc";
            this.dTDateDoc.Size = new System.Drawing.Size(200, 22);
            this.dTDateDoc.TabIndex = 4;
            // 
            // panelWho
            // 
            this.panelWho.Controls.Add(this.panelPass);
            this.panelWho.Controls.Add(this.cBIdentDoc);
            this.panelWho.Controls.Add(this.tBPatronymic);
            this.panelWho.Controls.Add(this.labelPatronymic);
            this.panelWho.Controls.Add(this.tBName);
            this.panelWho.Controls.Add(this.labelName);
            this.panelWho.Controls.Add(this.tBSurname);
            this.panelWho.Controls.Add(this.labelSurname);
            this.panelWho.Controls.Add(this.labelPerson);
            this.panelWho.Location = new System.Drawing.Point(37, 52);
            this.panelWho.Name = "panelWho";
            this.panelWho.Size = new System.Drawing.Size(650, 164);
            this.panelWho.TabIndex = 3;
            // 
            // panelPass
            // 
            this.panelPass.Controls.Add(this.labelDatePass);
            this.panelPass.Controls.Add(this.dtPassDate);
            this.panelPass.Controls.Add(this.tbPassGiven);
            this.panelPass.Controls.Add(this.labelPassGiven);
            this.panelPass.Controls.Add(this.tbPassNumber);
            this.panelPass.Controls.Add(this.labelPassNumber);
            this.panelPass.Controls.Add(this.tbPassSerial);
            this.panelPass.Controls.Add(this.labelPassSerial);
            this.panelPass.Location = new System.Drawing.Point(233, 38);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(411, 114);
            this.panelPass.TabIndex = 10;
            // 
            // labelDatePass
            // 
            this.labelDatePass.AutoSize = true;
            this.labelDatePass.Location = new System.Drawing.Point(215, 13);
            this.labelDatePass.Name = "labelDatePass";
            this.labelDatePass.Size = new System.Drawing.Size(95, 17);
            this.labelDatePass.TabIndex = 12;
            this.labelDatePass.Text = "Дата выдачи";
            // 
            // dtPassDate
            // 
            this.dtPassDate.Location = new System.Drawing.Point(210, 35);
            this.dtPassDate.Name = "dtPassDate";
            this.dtPassDate.Size = new System.Drawing.Size(200, 22);
            this.dtPassDate.TabIndex = 11;
            // 
            // tbPassGiven
            // 
            this.tbPassGiven.Location = new System.Drawing.Point(87, 63);
            this.tbPassGiven.Multiline = true;
            this.tbPassGiven.Name = "tbPassGiven";
            this.tbPassGiven.Size = new System.Drawing.Size(323, 48);
            this.tbPassGiven.TabIndex = 10;
            // 
            // labelPassGiven
            // 
            this.labelPassGiven.AutoSize = true;
            this.labelPassGiven.Location = new System.Drawing.Point(11, 63);
            this.labelPassGiven.Name = "labelPassGiven";
            this.labelPassGiven.Size = new System.Drawing.Size(79, 17);
            this.labelPassGiven.TabIndex = 9;
            this.labelPassGiven.Text = "Кем выдан";
            // 
            // tbPassNumber
            // 
            this.tbPassNumber.Location = new System.Drawing.Point(87, 35);
            this.tbPassNumber.Name = "tbPassNumber";
            this.tbPassNumber.Size = new System.Drawing.Size(117, 22);
            this.tbPassNumber.TabIndex = 8;
            // 
            // labelPassNumber
            // 
            this.labelPassNumber.AutoSize = true;
            this.labelPassNumber.Location = new System.Drawing.Point(11, 35);
            this.labelPassNumber.Name = "labelPassNumber";
            this.labelPassNumber.Size = new System.Drawing.Size(51, 17);
            this.labelPassNumber.TabIndex = 7;
            this.labelPassNumber.Text = "Номер";
            // 
            // tbPassSerial
            // 
            this.tbPassSerial.Location = new System.Drawing.Point(87, 10);
            this.tbPassSerial.Name = "tbPassSerial";
            this.tbPassSerial.Size = new System.Drawing.Size(117, 22);
            this.tbPassSerial.TabIndex = 6;
            // 
            // labelPassSerial
            // 
            this.labelPassSerial.AutoSize = true;
            this.labelPassSerial.Location = new System.Drawing.Point(11, 10);
            this.labelPassSerial.Name = "labelPassSerial";
            this.labelPassSerial.Size = new System.Drawing.Size(49, 17);
            this.labelPassSerial.TabIndex = 5;
            this.labelPassSerial.Text = "Серия";
            // 
            // cBIdentDoc
            // 
            this.cBIdentDoc.FormattingEnabled = true;
            this.cBIdentDoc.Location = new System.Drawing.Point(232, 3);
            this.cBIdentDoc.Name = "cBIdentDoc";
            this.cBIdentDoc.Size = new System.Drawing.Size(121, 24);
            this.cBIdentDoc.TabIndex = 9;
            this.cBIdentDoc.Text = "Пасспорт";
            this.cBIdentDoc.SelectedIndexChanged += new System.EventHandler(this.cBIdentDoc_SelectedIndexChanged);
            // 
            // tBPatronymic
            // 
            this.tBPatronymic.Location = new System.Drawing.Point(83, 76);
            this.tBPatronymic.Name = "tBPatronymic";
            this.tBPatronymic.Size = new System.Drawing.Size(117, 22);
            this.tBPatronymic.TabIndex = 8;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(7, 76);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(71, 17);
            this.labelPatronymic.TabIndex = 7;
            this.labelPatronymic.Text = "Отчество";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(83, 48);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(117, 22);
            this.tBName.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Имя";
            // 
            // tBSurname
            // 
            this.tBSurname.Location = new System.Drawing.Point(83, 20);
            this.tBSurname.Name = "tBSurname";
            this.tBSurname.Size = new System.Drawing.Size(117, 22);
            this.tBSurname.TabIndex = 4;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(7, 20);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(70, 17);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelPerson
            // 
            this.labelPerson.AutoSize = true;
            this.labelPerson.Location = new System.Drawing.Point(-3, -3);
            this.labelPerson.Name = "labelPerson";
            this.labelPerson.Size = new System.Drawing.Size(86, 17);
            this.labelPerson.TabIndex = 1;
            this.labelPerson.Text = "Кому выдан";
            // 
            // tBNumber
            // 
            this.tBNumber.Location = new System.Drawing.Point(37, 24);
            this.tBNumber.Name = "tBNumber";
            this.tBNumber.Size = new System.Drawing.Size(117, 22);
            this.tBNumber.TabIndex = 2;
            // 
            // labelDocNumber
            // 
            this.labelDocNumber.AutoSize = true;
            this.labelDocNumber.Location = new System.Drawing.Point(9, 27);
            this.labelDocNumber.Name = "labelDocNumber";
            this.labelDocNumber.Size = new System.Drawing.Size(22, 17);
            this.labelDocNumber.TabIndex = 1;
            this.labelDocNumber.Text = "№";
            // 
            // labelEmpowerment
            // 
            this.labelEmpowerment.AutoSize = true;
            this.labelEmpowerment.Location = new System.Drawing.Point(-3, 0);
            this.labelEmpowerment.Name = "labelEmpowerment";
            this.labelEmpowerment.Size = new System.Drawing.Size(95, 17);
            this.labelEmpowerment.TabIndex = 0;
            this.labelEmpowerment.Text = "Довереность";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(451, 825);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 39);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(598, 825);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 39);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EditingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 867);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pDocument);
            this.Controls.Add(this.labelValidUntil);
            this.Controls.Add(this.dTValidUntil);
            this.Controls.Add(this.labelIssueDate);
            this.Controls.Add(this.dTDateofIssue);
            this.Name = "EditingView";
            this.Text = "Довереность";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditingView_Paint);
            this.pDocument.ResumeLayout(false);
            this.pDocument.PerformLayout();
            this.panelInvItem.ResumeLayout(false);
            this.panelInvItem.PerformLayout();
            this.panelDoc.ResumeLayout(false);
            this.panelDoc.PerformLayout();
            this.panelOrg.ResumeLayout(false);
            this.panelOrg.PerformLayout();
            this.panelWho.ResumeLayout(false);
            this.panelWho.PerformLayout();
            this.panelPass.ResumeLayout(false);
            this.panelPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dTDateofIssue;
        private System.Windows.Forms.Label labelIssueDate;
        private System.Windows.Forms.Label labelValidUntil;
        public System.Windows.Forms.DateTimePicker dTValidUntil;
        private System.Windows.Forms.Panel pDocument;
        private System.Windows.Forms.Label labelDocDate;
        public System.Windows.Forms.DateTimePicker dTDateDoc;
        private System.Windows.Forms.Panel panelWho;
        public System.Windows.Forms.TextBox tBNumber;
        private System.Windows.Forms.Label labelDocNumber;
        private System.Windows.Forms.Label labelEmpowerment;
        public System.Windows.Forms.TextBox tBPatronymic;
        private System.Windows.Forms.Label labelPatronymic;
        public System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label labelName;
        public System.Windows.Forms.TextBox tBSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.Panel panelPass;
        public System.Windows.Forms.TextBox tbPassGiven;
        private System.Windows.Forms.Label labelPassGiven;
        public System.Windows.Forms.TextBox tbPassNumber;
        private System.Windows.Forms.Label labelPassNumber;
        public System.Windows.Forms.TextBox tbPassSerial;
        private System.Windows.Forms.Label labelPassSerial;
        private System.Windows.Forms.ComboBox cBIdentDoc;
        private System.Windows.Forms.Label labelDatePass;
        public System.Windows.Forms.DateTimePicker dtPassDate;
        private System.Windows.Forms.Panel panelOrg;
        private System.Windows.Forms.Label labelOrgpanel;
        private System.Windows.Forms.Panel panelDoc;
        public System.Windows.Forms.TextBox tbContract;
        private System.Windows.Forms.Label labelDocPanel;
        public System.Windows.Forms.TextBox tbOrg;
        private System.Windows.Forms.Label labelOrg;
        private System.Windows.Forms.Panel panelInvItem;
        private System.Windows.Forms.Label labelInvItemPanel;
        public System.Windows.Forms.ListView grdInventoryItems;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelII;
        private System.Windows.Forms.Button btnChangeII;
        private System.Windows.Forms.Button btnAddII;
        private System.Windows.Forms.TextBox tbNumberOfII;
        private System.Windows.Forms.Label labelNumberOfII;
        private System.Windows.Forms.TextBox tbIIUnit;
        private System.Windows.Forms.Label labelIIUnit;
        private System.Windows.Forms.TextBox tbIIName;
        private System.Windows.Forms.Label labelIIName;
        private System.Windows.Forms.TextBox tbIINum;
        private System.Windows.Forms.Label labelNumberII;
    }
}