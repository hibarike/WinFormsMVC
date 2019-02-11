using System;
using System.Collections;
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
    public partial class EmpowermentView : Form, IEmpowermentView
    {
        public EmpowermentView()
        {
            InitializeComponent();
            foradd.SaveButtonClicked += EditingViewSaveButtonClicked;
        }
        EmpowermentController _controllerE;
        bool firstAdd = false;
        private void AddEmpowerment_Click(object sender, EventArgs e)
        {
            this._controllerE.AddNewEmpowerment();
            IList inventoryItems = new ArrayList();
            inventoryItems.Add(new InventoryItem(""
                , "", "", ""));
            InventoryItemController controller = new InventoryItemController(foradd, inventoryItems);
            controller.LoadView();
            firstAdd =true;
            foradd.ShowDialog();
        }
        private void grdEmpowerment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.grdEmpowerment.SelectedItems.Count > 0 /*&& firstAdd*/)
            {
               
                this._controllerE.SelectedEmpowermentChanged(Convert.ToInt32(this.grdEmpowerment.SelectedItems[0].Text));
                
            }
        }
        private void EditEmp_Click(object sender, EventArgs e)
        {
            if (this.grdEmpowerment.SelectedItems.Count > 0 /*&& firstAdd*/)
            {

                this._controllerE.SelectedEmpowermentChanged(Convert.ToInt32(this.grdEmpowerment.SelectedItems[0].Text));
                IList inventoryItems = new ArrayList();
                //inventoryItems.Add(new InventoryItem ("","","",""));
                foreach (InventoryItem inv in _controllerE.SelectedEmpowermentItem.InventoryItems)
                    inventoryItems.Add(inv);
                InventoryItemController controller = new InventoryItemController(foradd, inventoryItems);
                controller.LoadView();
               
                // foradd.Visible = false;
                foradd.ShowDialog();
                
            }
            
        }
        private void DelEmpowerment_Click(object sender, EventArgs e)
        {

            this._controllerE.RemoveEmpowerment();
        }

        
        private void EditingViewSaveButtonClicked(object sender, EventArgs e)
        {
            _controllerE.Save();
            foradd.Visible = false;
        }
        #region ICatalogView implementation

        public void SetController(EmpowermentController controller)
        {
            _controllerE = controller;
        }

        public void ClearGrid()
        {
            // Define columns in grid
            this.grdEmpowerment.Columns.Clear();

            this.grdEmpowerment.Columns.Add("ID", 150, HorizontalAlignment.Left);
            this.grdEmpowerment.Columns.Add("ТМЦ", 150, HorizontalAlignment.Left);
            this.grdEmpowerment.Columns.Add("Количество", 150, HorizontalAlignment.Left);
            this.grdEmpowerment.Columns.Add("№ доверености", 150, HorizontalAlignment.Left);
            this.grdEmpowerment.Columns.Add("Дата выдачи", 150, HorizontalAlignment.Left);
            this.grdEmpowerment.Columns.Add("Действительна до", 150, HorizontalAlignment.Left);


            // Add rows to grid
            this.grdEmpowerment.Items.Clear();
        }

        public void AddEmpowermentToGrid(Empowerment empowerment)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.grdEmpowerment.Items)
            {
                if (row.Text == "")
                {
                    rowToUpdate = row;
                }
            }
            if (rowToUpdate != null)
            {
                
                
                foreach (InventoryItem inv in empowerment.InventoryItems)
                {
                    rowToUpdate.Text = empowerment.ID.ToString();
                    rowToUpdate.SubItems[1].Text = inv.Name;
                    rowToUpdate.SubItems[2].Text = inv.NumberOfItemString;
                    rowToUpdate.SubItems[3].Text = empowerment.DocumentNumber;
                    rowToUpdate.SubItems[4].Text = empowerment.DateOfIssue.ToShortDateString();
                    rowToUpdate.SubItems[5].Text = empowerment.ValidUntil.ToShortDateString();

                }
                

            }
            else
            {
                ListViewItem parent;
                
                foreach (InventoryItem inv in empowerment.InventoryItems)
                {
                    parent = this.grdEmpowerment.Items.Add(empowerment.ID.ToString());
                    parent.SubItems.Add(inv.Name);
                    parent.SubItems.Add(inv.NumberOfItemString);
                    parent.SubItems.Add(empowerment.DocumentNumber);
                    parent.SubItems.Add(empowerment.DateOfIssue.ToShortDateString());
                    parent.SubItems.Add(empowerment.ValidUntil.ToShortDateString());
                }
            }

        }

        public void UpdateGridWithChangedEmpowerment(Empowerment empowerment)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.grdEmpowerment.Items)
            {
                if (row.Text == empowerment.ID.ToString())
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                
                foreach (InventoryItem inv in empowerment.InventoryItems)
                {
                    rowToUpdate.Text = empowerment.ID.ToString();
                    rowToUpdate.SubItems[1].Text = inv.Name;
                    rowToUpdate.SubItems[2].Text = inv.NumberOfItemString;
                    rowToUpdate.SubItems[3].Text = empowerment.DocumentNumber;
                    rowToUpdate.SubItems[4].Text = empowerment.DateOfIssue.ToShortDateString();
                    rowToUpdate.SubItems[5].Text = empowerment.ValidUntil.ToShortDateString();

                }

            }
        }

        public void RemoveEmpowermentFromGrid(Empowerment empowerment)
        {

            ListViewItem rowToRemove = null;

            foreach (ListViewItem row in this.grdEmpowerment.Items)
            {
                if (row.Text == empowerment.ID.ToString())
                {
                    rowToRemove = row;
                }
            }

            if (rowToRemove != null)
            {
                this.grdEmpowerment.Items.Remove(rowToRemove);
                this.grdEmpowerment.Focus();
            }
        }

        public string GetIdOfSelectedEmpowermentInGrid()
        {
            if (this.grdEmpowerment.SelectedItems.Count > 0)
                return this.grdEmpowerment.SelectedItems[0].Text;
            else
                return "";
        }

        public void SetSelectedEmpowermentInGrid(Empowerment empowerment)
        {
            foreach (ListViewItem row in this.grdEmpowerment.Items)
            {
                if (row.Text == empowerment.ID.ToString())
                {
                    row.Selected = true;
                }
            }

        }

        

        int iD =0;
        public int ID { get; set; }
        public Contract Contract
        {
            get
            {
                return new Contract(foradd.tbContract.Text);
            }
            set
            {
                foradd.tbContract.Text = value.ContractId;
            }
        }
        public DateTime DateOfIssue
        {
            get
            {
                return foradd.dTDateofIssue.Value;
            }
            set
            {
                foradd.dTDateofIssue.Value = value;
            }
        }
        public DateTime DocumentDate
        {
            get
            {
                return foradd.dTDateDoc.Value;
            }
            set
            {
                foradd.dTDateDoc.Value = value;
            }
        }
        public string DocumentNumber
        {
            get
            {
                return foradd.tBNumber.Text;
            }
            set
            {
                foradd.tBNumber.Text = value;
            }
        }

        public IList InventoryItems
        {
            get
            {
                IList ret = new ArrayList();
                foreach (ListViewItem row in foradd.grdInventoryItems.Items)
                {
                    ret.Add(new InventoryItem(row.Text, row.SubItems[1].Text, row.SubItems[2].Text, row.SubItems[3].Text));
                }
                return ret;
            }
            set

            {
                ListViewItem parent;
                foreach (InventoryItem inv in value)
                {

                    parent = foradd.grdInventoryItems.Items.Add(inv.ID);
                    parent.SubItems.Add(inv.Name);
                    parent.SubItems.Add(inv.Unit);
                    parent.SubItems.Add(inv.NumberOfItemString);
                }
            }
        }
        public Organisation Organisation
        {
            get
            {
                return new Organisation(foradd.tbOrg.Text);
            }
            set
            {
                foradd.tbOrg.Text = value.NameOrganisation;
            }
        }
        public Person Person
        {
            get
            {
                return new Person(
                    foradd.tBName.Text,
                    foradd.tBSurname.Text,
                    foradd.tBPatronymic.Text,
                    new Passport(
                        foradd.tbPassSerial.Text,
                        Convert.ToInt32(foradd.tbPassNumber.Text),
                        foradd.dtPassDate.Value,
                        foradd.tbPassGiven.Text)
                        );                       
            }
            set
            {
                foradd.tBName.Text = value.Name;
                foradd.tBSurname.Text = value.Surname;
                foradd.tBPatronymic.Text = value.Patronymic;
                foradd.tbPassSerial.Text = value.IdentityDocument.Serial;
                foradd.tbPassNumber.Text = value.IdentityDocument.Number.ToString();
                foradd.dtPassDate.Value = value.IdentityDocument.WhenGet;
                foradd.tbPassGiven.Text = value.IdentityDocument.WhoGive;
            }
        }

        public DateTime ValidUntil
        {
            get
            {
                return foradd.dTValidUntil.Value;
            }
            set
            {
                foradd.dTValidUntil.Value = value;
            }
        }







        //bool CanModifyID { set; }





        #endregion

        private void foradd_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void EmpowermentView_Load(object sender, EventArgs e)
        {
           
            MessageBox.Show(_controllerE.CriticalValid(),"Внимание",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
    }
}
