namespace WindowsFormsApp1
{
    partial class sarf_cihaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sarf_cihaz));
            this.hastanessDataSet = new WindowsFormsApp1.hastanessDataSet();
            this.consumableDeviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumableDeviceTableAdapter = new WindowsFormsApp1.hastanessDataSetTableAdapters.consumableDeviceTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.hastanessDataSetTableAdapters.TableAdapterManager();
            this.consumableDeviceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.consumableDeviceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.consumableDeviceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hastanessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumableDeviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumableDeviceBindingNavigator)).BeginInit();
            this.consumableDeviceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumableDeviceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hastanessDataSet
            // 
            this.hastanessDataSet.DataSetName = "hastanessDataSet";
            this.hastanessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consumableDeviceBindingSource
            // 
            this.consumableDeviceBindingSource.DataMember = "consumableDevice";
            this.consumableDeviceBindingSource.DataSource = this.hastanessDataSet;
            // 
            // consumableDeviceTableAdapter
            // 
            this.consumableDeviceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.consumableDeviceTableAdapter = this.consumableDeviceTableAdapter;
            this.tableAdapterManager.consumableMedicineTableAdapter = null;
            this.tableAdapterManager.deviceTableAdapter = null;
            this.tableAdapterManager.hospitalTableAdapter = null;
            this.tableAdapterManager.medicineTableAdapter = null;
            this.tableAdapterManager.partTableAdapter = null;
            this.tableAdapterManager.patientTableAdapter = null;
            this.tableAdapterManager.productionTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.hastanessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consumableDeviceBindingNavigator
            // 
            this.consumableDeviceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consumableDeviceBindingNavigator.BindingSource = this.consumableDeviceBindingSource;
            this.consumableDeviceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consumableDeviceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consumableDeviceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consumableDeviceBindingNavigatorSaveItem});
            this.consumableDeviceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consumableDeviceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consumableDeviceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consumableDeviceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consumableDeviceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consumableDeviceBindingNavigator.Name = "consumableDeviceBindingNavigator";
            this.consumableDeviceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consumableDeviceBindingNavigator.Size = new System.Drawing.Size(273, 25);
            this.consumableDeviceBindingNavigator.TabIndex = 0;
            this.consumableDeviceBindingNavigator.Text = "bindingNavigator1";
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
            // consumableDeviceBindingNavigatorSaveItem
            // 
            this.consumableDeviceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consumableDeviceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consumableDeviceBindingNavigatorSaveItem.Image")));
            this.consumableDeviceBindingNavigatorSaveItem.Name = "consumableDeviceBindingNavigatorSaveItem";
            this.consumableDeviceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.consumableDeviceBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.consumableDeviceBindingNavigatorSaveItem.Click += new System.EventHandler(this.consumableDeviceBindingNavigatorSaveItem_Click);
            // 
            // consumableDeviceDataGridView
            // 
            this.consumableDeviceDataGridView.AutoGenerateColumns = false;
            this.consumableDeviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consumableDeviceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.consumableDeviceDataGridView.DataSource = this.consumableDeviceBindingSource;
            this.consumableDeviceDataGridView.Location = new System.Drawing.Point(12, 28);
            this.consumableDeviceDataGridView.Name = "consumableDeviceDataGridView";
            this.consumableDeviceDataGridView.Size = new System.Drawing.Size(245, 220);
            this.consumableDeviceDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sseriNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "sseriNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "scname";
            this.dataGridViewTextBoxColumn2.HeaderText = "scname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // sarf_cihaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 272);
            this.Controls.Add(this.consumableDeviceDataGridView);
            this.Controls.Add(this.consumableDeviceBindingNavigator);
            this.Name = "sarf_cihaz";
            this.Text = "sarf_cihaz";
            this.Load += new System.EventHandler(this.sarf_cihaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastanessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumableDeviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumableDeviceBindingNavigator)).EndInit();
            this.consumableDeviceBindingNavigator.ResumeLayout(false);
            this.consumableDeviceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumableDeviceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hastanessDataSet hastanessDataSet;
        private System.Windows.Forms.BindingSource consumableDeviceBindingSource;
        private hastanessDataSetTableAdapters.consumableDeviceTableAdapter consumableDeviceTableAdapter;
        private hastanessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consumableDeviceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consumableDeviceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView consumableDeviceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}