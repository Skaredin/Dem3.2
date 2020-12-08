
namespace Ddem3._2
{
    partial class RedaktirovanieToIsmenenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedaktirovanieToIsmenenie));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label mainImagePathLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label manufacturerIDLabel;
            System.Windows.Forms.Label Nazad;
            this.___Dem3SkaredinDataSet = new Ddem3._2.@__Dem3SkaredinDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Ddem3._2.@__Dem3SkaredinDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Ddem3._2.@__Dem3SkaredinDataSetTableAdapters.TableAdapterManager();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.mainImagePathComboBox = new System.Windows.Forms.ComboBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.manufacturerIDTextBox = new System.Windows.Forms.TextBox();
            this.ImagePB = new System.Windows.Forms.PictureBox();
            this.LeftBUT = new System.Windows.Forms.Button();
            this.RigihtBUT = new System.Windows.Forms.Button();
            this.SaveBUT = new System.Windows.Forms.Button();
            this.DobavlenieBUT = new System.Windows.Forms.Button();
            this.YdalenieBUT = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            mainImagePathLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            manufacturerIDLabel = new System.Windows.Forms.Label();
            Nazad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.___Dem3SkaredinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // ___Dem3SkaredinDataSet
            // 
            this.___Dem3SkaredinDataSet.DataSetName = "__Dem3SkaredinDataSet";
            this.___Dem3SkaredinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.___Dem3SkaredinDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachedProductTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientServiceTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DocumentByServiceTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductPhotoTableAdapter = null;
            this.tableAdapterManager.ProductSaleTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.ServicePhotoTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TagOfClientTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ddem3._2.@__Dem3SkaredinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(569, 25);
            this.productBindingNavigator.TabIndex = 0;
            this.productBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(24, 92);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(120, 89);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(121, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(24, 118);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(120, 115);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(121, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(24, 144);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 5;
            costLabel.Text = "Cost:";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(120, 141);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(121, 20);
            this.costTextBox.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(24, 170);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(120, 167);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(121, 20);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // mainImagePathLabel
            // 
            mainImagePathLabel.AutoSize = true;
            mainImagePathLabel.Location = new System.Drawing.Point(24, 196);
            mainImagePathLabel.Name = "mainImagePathLabel";
            mainImagePathLabel.Size = new System.Drawing.Size(90, 13);
            mainImagePathLabel.TabIndex = 9;
            mainImagePathLabel.Text = "Main Image Path:";
            // 
            // mainImagePathComboBox
            // 
            this.mainImagePathComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MainImagePath", true));
            this.mainImagePathComboBox.FormattingEnabled = true;
            this.mainImagePathComboBox.Location = new System.Drawing.Point(120, 193);
            this.mainImagePathComboBox.Name = "mainImagePathComboBox";
            this.mainImagePathComboBox.Size = new System.Drawing.Size(121, 21);
            this.mainImagePathComboBox.TabIndex = 10;
            this.mainImagePathComboBox.SelectedIndexChanged += new System.EventHandler(this.mainImagePathComboBox_SelectedIndexChanged);
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(24, 225);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(51, 13);
            isActiveLabel.TabIndex = 11;
            isActiveLabel.Text = "Is Active:";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "IsActive", true));
            this.isActiveCheckBox.Location = new System.Drawing.Point(120, 220);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(121, 24);
            this.isActiveCheckBox.TabIndex = 12;
            this.isActiveCheckBox.Text = "checkBox1";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // manufacturerIDLabel
            // 
            manufacturerIDLabel.AutoSize = true;
            manufacturerIDLabel.Location = new System.Drawing.Point(24, 253);
            manufacturerIDLabel.Name = "manufacturerIDLabel";
            manufacturerIDLabel.Size = new System.Drawing.Size(87, 13);
            manufacturerIDLabel.TabIndex = 13;
            manufacturerIDLabel.Text = "Manufacturer ID:";
            // 
            // manufacturerIDTextBox
            // 
            this.manufacturerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ManufacturerID", true));
            this.manufacturerIDTextBox.Location = new System.Drawing.Point(120, 250);
            this.manufacturerIDTextBox.Name = "manufacturerIDTextBox";
            this.manufacturerIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.manufacturerIDTextBox.TabIndex = 14;
            // 
            // ImagePB
            // 
            this.ImagePB.Location = new System.Drawing.Point(247, 89);
            this.ImagePB.Name = "ImagePB";
            this.ImagePB.Size = new System.Drawing.Size(179, 181);
            this.ImagePB.TabIndex = 15;
            this.ImagePB.TabStop = false;
            // 
            // LeftBUT
            // 
            this.LeftBUT.Location = new System.Drawing.Point(27, 287);
            this.LeftBUT.Name = "LeftBUT";
            this.LeftBUT.Size = new System.Drawing.Size(75, 23);
            this.LeftBUT.TabIndex = 16;
            this.LeftBUT.Text = "Left";
            this.LeftBUT.UseVisualStyleBackColor = true;
            this.LeftBUT.Click += new System.EventHandler(this.LeftBUT_Click);
            // 
            // RigihtBUT
            // 
            this.RigihtBUT.Location = new System.Drawing.Point(108, 287);
            this.RigihtBUT.Name = "RigihtBUT";
            this.RigihtBUT.Size = new System.Drawing.Size(75, 23);
            this.RigihtBUT.TabIndex = 17;
            this.RigihtBUT.Text = "Rigiht";
            this.RigihtBUT.UseVisualStyleBackColor = true;
            this.RigihtBUT.Click += new System.EventHandler(this.RigihtBUT_Click);
            // 
            // SaveBUT
            // 
            this.SaveBUT.Location = new System.Drawing.Point(189, 287);
            this.SaveBUT.Name = "SaveBUT";
            this.SaveBUT.Size = new System.Drawing.Size(75, 23);
            this.SaveBUT.TabIndex = 18;
            this.SaveBUT.Text = "Save";
            this.SaveBUT.UseVisualStyleBackColor = true;
            this.SaveBUT.Click += new System.EventHandler(this.SaveBUT_Click);
            // 
            // DobavlenieBUT
            // 
            this.DobavlenieBUT.Location = new System.Drawing.Point(270, 287);
            this.DobavlenieBUT.Name = "DobavlenieBUT";
            this.DobavlenieBUT.Size = new System.Drawing.Size(75, 23);
            this.DobavlenieBUT.TabIndex = 19;
            this.DobavlenieBUT.Text = "Dobavlenie";
            this.DobavlenieBUT.UseVisualStyleBackColor = true;
            this.DobavlenieBUT.Click += new System.EventHandler(this.DobavlenieBUT_Click);
            // 
            // YdalenieBUT
            // 
            this.YdalenieBUT.Location = new System.Drawing.Point(351, 287);
            this.YdalenieBUT.Name = "YdalenieBUT";
            this.YdalenieBUT.Size = new System.Drawing.Size(75, 23);
            this.YdalenieBUT.TabIndex = 20;
            this.YdalenieBUT.Text = "Ydalenie";
            this.YdalenieBUT.UseVisualStyleBackColor = true;
            // 
            // Nazad
            // 
            Nazad.AutoSize = true;
            Nazad.Location = new System.Drawing.Point(24, 59);
            Nazad.Name = "Nazad";
            Nazad.Size = new System.Drawing.Size(25, 13);
            Nazad.TabIndex = 21;
            Nazad.Text = "<----";
            Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // RedaktirovanieToIsmenenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(Nazad);
            this.Controls.Add(this.YdalenieBUT);
            this.Controls.Add(this.DobavlenieBUT);
            this.Controls.Add(this.SaveBUT);
            this.Controls.Add(this.RigihtBUT);
            this.Controls.Add(this.LeftBUT);
            this.Controls.Add(this.ImagePB);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(mainImagePathLabel);
            this.Controls.Add(this.mainImagePathComboBox);
            this.Controls.Add(isActiveLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(manufacturerIDLabel);
            this.Controls.Add(this.manufacturerIDTextBox);
            this.Controls.Add(this.productBindingNavigator);
            this.Name = "RedaktirovanieToIsmenenie";
            this.Text = "RedaktirovanieToIsmenenie";
            this.Load += new System.EventHandler(this.RedaktirovanieToIsmenenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.___Dem3SkaredinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private __Dem3SkaredinDataSet ___Dem3SkaredinDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private __Dem3SkaredinDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private __Dem3SkaredinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox mainImagePathComboBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.TextBox manufacturerIDTextBox;
        private System.Windows.Forms.PictureBox ImagePB;
        private System.Windows.Forms.Button LeftBUT;
        private System.Windows.Forms.Button RigihtBUT;
        private System.Windows.Forms.Button SaveBUT;
        private System.Windows.Forms.Button DobavlenieBUT;
        private System.Windows.Forms.Button YdalenieBUT;
    }
}