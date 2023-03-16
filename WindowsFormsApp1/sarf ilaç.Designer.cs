namespace WindowsFormsApp1
{
    partial class sarf_ilaç
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sarf_ilaç));
            this.hastanessDataSet = new WindowsFormsApp1.hastanessDataSet();
            this.consumableMedicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumableMedicineTableAdapter = new WindowsFormsApp1.hastanessDataSetTableAdapters.consumableMedicineTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.hastanessDataSetTableAdapters.TableAdapterManager();
            this.consumableMedicineBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.consumableMedicineBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.consumableMedicineDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hastanessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumableMedicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumableMedicineBindingNavigator)).BeginInit();
            this.consumableMedicineBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumableMedicineDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hastanessDataSet
            // 
            this.hastanessDataSet.DataSetName = "hastanessDataSet";
            this.hastanessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consumableMedicineBindingSource
            // 
            this.consumableMedicineBindingSource.DataMember = "consumableMedicine";
            this.consumableMedicineBindingSource.DataSource = this.hastanessDataSet;
            // 
            // consumableMedicineTableAdapter
            // 
            this.consumableMedicineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.consumableDeviceTableAdapter = null;
            this.tableAdapterManager.consumableMedicineTableAdapter = this.consumableMedicineTableAdapter;
            this.tableAdapterManager.deviceTableAdapter = null;
            this.tableAdapterManager.hospitalTableAdapter = null;
            this.tableAdapterManager.medicineTableAdapter = null;
            this.tableAdapterManager.partTableAdapter = null;
            this.tableAdapterManager.patientTableAdapter = null;
            this.tableAdapterManager.productionTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.hastanessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consumableMedicineBindingNavigator
            // 
            this.consumableMedicineBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consumableMedicineBindingNavigator.BindingSource = this.consumableMedicineBindingSource;
            this.consumableMedicineBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consumableMedicineBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consumableMedicineBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consumableMedicineBindingNavigatorSaveItem});
            this.consumableMedicineBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consumableMedicineBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consumableMedicineBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consumableMedicineBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consumableMedicineBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consumableMedicineBindingNavigator.Name = "consumableMedicineBindingNavigator";
            this.consumableMedicineBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consumableMedicineBindingNavigator.Size = new System.Drawing.Size(314, 25);
            this.consumableMedicineBindingNavigator.TabIndex = 0;
            this.consumableMedicineBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Konum";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 15);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Yeni ekle";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Sil";
            // 
            // consumableMedicineBindingNavigatorSaveItem
            // 
            this.consumableMedicineBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consumableMedicineBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consumableMedicineBindingNavigatorSaveItem.Image")));
            this.consumableMedicineBindingNavigatorSaveItem.Name = "consumableMedicineBindingNavigatorSaveItem";
            this.consumableMedicineBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.consumableMedicineBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.consumableMedicineBindingNavigatorSaveItem.Click += new System.EventHandler(this.consumableMedicineBindingNavigatorSaveItem_Click);
            // 
            // consumableMedicineDataGridView
            // 
            this.consumableMedicineDataGridView.AutoGenerateColumns = false;
            this.consumableMedicineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consumableMedicineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.consumableMedicineDataGridView.DataSource = this.consumableMedicineBindingSource;
            this.consumableMedicineDataGridView.Location = new System.Drawing.Point(31, 43);
            this.consumableMedicineDataGridView.Name = "consumableMedicineDataGridView";
            this.consumableMedicineDataGridView.Size = new System.Drawing.Size(247, 220);
            this.consumableMedicineDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sbarkod";
            this.dataGridViewTextBoxColumn1.HeaderText = "sbarkod";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "siname";
            this.dataGridViewTextBoxColumn2.HeaderText = "siname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // sarf_ilaç
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 315);
            this.Controls.Add(this.consumableMedicineDataGridView);
            this.Controls.Add(this.consumableMedicineBindingNavigator);
            this.Name = "sarf_ilaç";
            this.Text = "sarf_ilaç";
            this.Load += new System.EventHandler(this.sarf_ilaç_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastanessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumableMedicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumableMedicineBindingNavigator)).EndInit();
            this.consumableMedicineBindingNavigator.ResumeLayout(false);
            this.consumableMedicineBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumableMedicineDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hastanessDataSet hastanessDataSet;
        private System.Windows.Forms.BindingSource consumableMedicineBindingSource;
        private hastanessDataSetTableAdapters.consumableMedicineTableAdapter consumableMedicineTableAdapter;
        private hastanessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consumableMedicineBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consumableMedicineBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView consumableMedicineDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}