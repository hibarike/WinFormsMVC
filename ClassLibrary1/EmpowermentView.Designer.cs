namespace View
{
    partial class EmpowermentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpowermentView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddEmpowerment = new System.Windows.Forms.ToolStripButton();
            this.EditEmp = new System.Windows.Forms.ToolStripButton();
            this.DelEmpowerment = new System.Windows.Forms.ToolStripButton();
            this.grdEmpowerment = new System.Windows.Forms.ListView();
            this.foradd = new View.EditingView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEmpowerment,
            this.EditEmp,
            this.DelEmpowerment});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // AddEmpowerment
            // 
            this.AddEmpowerment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddEmpowerment.Image = ((System.Drawing.Image)(resources.GetObject("AddEmpowerment.Image")));
            this.AddEmpowerment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddEmpowerment.Name = "AddEmpowerment";
            this.AddEmpowerment.Size = new System.Drawing.Size(173, 24);
            this.AddEmpowerment.Text = "Добавить довереность";
            this.AddEmpowerment.Click += new System.EventHandler(this.AddEmpowerment_Click);
            // 
            // EditEmp
            // 
            this.EditEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditEmp.Image = ((System.Drawing.Image)(resources.GetObject("EditEmp.Image")));
            this.EditEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditEmp.Name = "EditEmp";
            this.EditEmp.Size = new System.Drawing.Size(115, 24);
            this.EditEmp.Text = "Редактировать";
            this.EditEmp.Click += new System.EventHandler(this.EditEmp_Click);
            // 
            // DelEmpowerment
            // 
            this.DelEmpowerment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DelEmpowerment.Image = ((System.Drawing.Image)(resources.GetObject("DelEmpowerment.Image")));
            this.DelEmpowerment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelEmpowerment.Name = "DelEmpowerment";
            this.DelEmpowerment.Size = new System.Drawing.Size(162, 24);
            this.DelEmpowerment.Text = "Удалить довереность";
            this.DelEmpowerment.Click += new System.EventHandler(this.DelEmpowerment_Click);
            // 
            // grdEmpowerment
            // 
            this.grdEmpowerment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdEmpowerment.FullRowSelect = true;
            this.grdEmpowerment.GridLines = true;
            this.grdEmpowerment.Location = new System.Drawing.Point(0, 42);
            this.grdEmpowerment.Name = "grdEmpowerment";
            this.grdEmpowerment.Size = new System.Drawing.Size(800, 408);
            this.grdEmpowerment.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.grdEmpowerment.TabIndex = 2;
            this.grdEmpowerment.UseCompatibleStateImageBehavior = false;
            this.grdEmpowerment.View = System.Windows.Forms.View.Details;
            this.grdEmpowerment.SelectedIndexChanged += new System.EventHandler(this.grdEmpowerment_SelectedIndexChanged);
            // 
            // foradd
            // 
            this.foradd.ClientSize = new System.Drawing.Size(753, 867);
            this.foradd.ID = "";
            this.foradd.Location = new System.Drawing.Point(64, 64);
            this.foradd.Name = "foradd";
            this.foradd.NameII = "";
            this.foradd.NumberOfItemString = "";
            this.foradd.Text = "Довереность";
            this.foradd.Unit = "";
            this.foradd.Visible = false;
            // 
            // EmpowermentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdEmpowerment);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EmpowermentView";
            this.Text = "Доверености";
            this.Load += new System.EventHandler(this.EmpowermentView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddEmpowerment;
        private System.Windows.Forms.ToolStripButton DelEmpowerment;
        private EditingView foradd;
        internal System.Windows.Forms.ListView grdEmpowerment;
        private System.Windows.Forms.ToolStripButton EditEmp;
    }
}