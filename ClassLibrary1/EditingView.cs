using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormEmpowerment.Controller;
using WinFormEmpowerment.Model;

namespace View
{
    public partial class EditingView : Form, IInventoryItemView
    {
        public EditingView()
        {
            InitializeComponent();
            

        }
        //Событие нажатия сохранения на другой форме
        public event EventHandler SaveButtonClicked;
        //контроллер
        InventoryItemController _controllerII;
        #region Events raised  back to controller
        private void EditingView_Paint(object sender, PaintEventArgs e)
        {
            tbIIName.Enabled = false;
            tbIINum.Enabled = false;
            tbIIUnit.Enabled = false;
            tbNumberOfII.Enabled = false;
        }
        //Событие изменения выбраного элемента
        private void cBIdentDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBIdentDoc.SelectedIndex == 0)
                panelPass.Visible = true;
        }

        //Событие ажатия кнопки Сохранения
        private void btnSave_Click(object sender, EventArgs e)
        {
            OnSaveButtonClicked(EventArgs.Empty);
        }
        //Перехват события другой формы
        protected void OnSaveButtonClicked(EventArgs e)
        {
            var evt = SaveButtonClicked;
            if (evt != null) evt(this, e);
        }
        //Добавление 
        private void btnAddII_Click(object sender, EventArgs e)
        {
            
            this._controllerII.AddNewInventoryItem();
            btnChangeII.Text = "Сохранить";
            btnAddII.Enabled = false;
            btnChangeII.Enabled = true;
            tbIIName.Enabled = true;
            tbIINum.Enabled = true;
            tbIIUnit.Enabled = true;
            tbNumberOfII.Enabled = true;

        }

        //Удаление
        private void btnDelII_Click(object sender, EventArgs e)
        {
            this._controllerII.RemoveInventoryItem();
        }

        //Изменене-Сохранение
        private void btnChangeII_Click(object sender, EventArgs e)
        {
            this._controllerII.Save();
            btnChangeII.Text = "Изменить";
            btnAddII.Enabled = true;
            btnChangeII.Enabled = false;
            tbIIName.Enabled = false;
            tbIINum.Enabled = false;
            tbIIUnit.Enabled = false;
            tbNumberOfII.Enabled = false;
        }
    
        //Событие изменения индекса
        private void grdInventoryItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.grdInventoryItems.SelectedItems.Count > 0)
            {
                this._controllerII.SelectedInventoryItemChanged(this.grdInventoryItems.SelectedItems[0].Text);
               
            }
            btnChangeII.Text = "Сохранить";
            btnChangeII.Enabled = true;
            tbIIName.Enabled = true;
            tbIINum.Enabled = true;
            tbIIUnit.Enabled = true;
            tbNumberOfII.Enabled = true;

        }
        #endregion

        #region ICatalogView implementation
        
        public void SetController(InventoryItemController controller)
        {
            _controllerII = controller;
        }

        
        public void ClearGrid()
        {
            // Define columns in grid
            this.grdInventoryItems.Columns.Clear();

            this.grdInventoryItems.Columns.Add("№ п/п", 150, HorizontalAlignment.Left);
            this.grdInventoryItems.Columns.Add("Наименование", 150, HorizontalAlignment.Left);
            this.grdInventoryItems.Columns.Add("ед. измерения", 150, HorizontalAlignment.Left);
            this.grdInventoryItems.Columns.Add("количество прописью", 300, HorizontalAlignment.Left);
            

            // Add rows to grid
            this.grdInventoryItems.Items.Clear();
        }

        
        public void AddInventoryItemToGrid(InventoryItem inventoryItem)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.grdInventoryItems.Items)
            {
                if (row.Text == "")
                {
                    rowToUpdate = row;
                }
            }
            if (rowToUpdate != null)
            {
                rowToUpdate.Text = inventoryItem.ID;
                rowToUpdate.SubItems[1].Text = inventoryItem.Name;
                rowToUpdate.SubItems[2].Text = inventoryItem.Unit;
                rowToUpdate.SubItems[3].Text = inventoryItem.NumberOfItemString;

            }
            else
            {
                ListViewItem parent;
                parent = this.grdInventoryItems.Items.Add(inventoryItem.ID);
                parent.SubItems.Add(inventoryItem.Name);
                parent.SubItems.Add(inventoryItem.Unit);
                parent.SubItems.Add(inventoryItem.NumberOfItemString);
            }
           
        }

        public void UpdateGridWithChangedInventoryItem(InventoryItem inventoryItem)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.grdInventoryItems.Items)
            {
                if (row.Text == inventoryItem.ID)
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Text = inventoryItem.ID;
                rowToUpdate.SubItems[1].Text = inventoryItem.Name;
                rowToUpdate.SubItems[2].Text = inventoryItem.Unit;
                rowToUpdate.SubItems[3].Text = inventoryItem.NumberOfItemString;
               
            }
        }

        public void RemoveInventoryItemFromGrid(InventoryItem inventoryItem)
        {

            ListViewItem rowToRemove = null;

            foreach (ListViewItem row in this.grdInventoryItems.Items)
            {
                if (row.Text == inventoryItem.ID)
                {
                    rowToRemove = row;
                }
            }

            if (rowToRemove != null)
            {
                this.grdInventoryItems.Items.Remove(rowToRemove);
                this.grdInventoryItems.Focus();
            }
        }

        public string GetIdOfSelectedInventoryItemInGrid()
        {
            if (this.grdInventoryItems.SelectedItems.Count > 0)
                return this.grdInventoryItems.SelectedItems[0].Text;
            else
                return "";
        }

        public void SetSelectedInventoryItemInGrid(InventoryItem inventoryItem)
        {
            foreach (ListViewItem row in this.grdInventoryItems.Items)
            {
                if (row.Text == inventoryItem.ID)
                {
                    row.Selected = true;
                }
            }
            
        }

        public string ID
        {
            get { return this.tbIINum.Text; }
            set { this.tbIINum.Text = value; }
        }

        public string NameII
        {
            get { return this.tbIIName.Text; }
            set { this.tbIIName.Text = value; }
        }

        public string Unit
        {
            get { return this.tbIIUnit.Text; }
            set { this.tbIIUnit.Text = value; }
        }


        public string NumberOfItemString
        {
            get { return this.tbNumberOfII.Text; }
            set { this.tbNumberOfII.Text = value; }
        }

        public bool CanModifyID
        {
            set { this.tbIINum.Enabled = value; }
        }






        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
