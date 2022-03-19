
namespace PlaneClient
{
    partial class PlaneForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridPlane = new Telerik.WinControls.UI.RadGridView();
            this.BtnDelete = new Telerik.WinControls.UI.RadButton();
            this.BtnEdit = new Telerik.WinControls.UI.RadButton();
            this.BtnAdd = new Telerik.WinControls.UI.RadButton();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.txtPrice = new Telerik.WinControls.UI.RadTextBox();
            this.txtBrand = new Telerik.WinControls.UI.RadTextBox();
            this.txtSize = new Telerik.WinControls.UI.RadTextBox();
            this.txtId = new Telerik.WinControls.UI.RadTextBox();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.txtKeyword = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlane.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPlane
            // 
            this.gridPlane.Location = new System.Drawing.Point(46, 115);
            // 
            // 
            // 
            this.gridPlane.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridPlane.Name = "gridPlane";
            this.gridPlane.Size = new System.Drawing.Size(603, 313);
            this.gridPlane.TabIndex = 0;
            this.gridPlane.Click += new System.EventHandler(this.gridPlane_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(973, 379);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(110, 24);
            this.BtnDelete.TabIndex = 42;
            this.BtnDelete.Text = "Delete";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(836, 379);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(110, 24);
            this.BtnEdit.TabIndex = 41;
            this.BtnEdit.Text = "Edit";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(704, 379);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 24);
            this.BtnAdd.TabIndex = 40;
            this.BtnAdd.Text = "Add";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(684, 329);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(26, 18);
            this.radLabel6.TabIndex = 39;
            this.radLabel6.Text = "Size";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(684, 287);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(30, 18);
            this.radLabel5.TabIndex = 38;
            this.radLabel5.Text = "Price";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(684, 287);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(30, 18);
            this.radLabel4.TabIndex = 37;
            this.radLabel4.Text = "Price";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(680, 236);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(36, 18);
            this.radLabel3.TabIndex = 36;
            this.radLabel3.Text = "Name";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(680, 195);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(35, 18);
            this.radLabel2.TabIndex = 35;
            this.radLabel2.Text = "Brand";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(684, 149);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(16, 18);
            this.radLabel1.TabIndex = 34;
            this.radLabel1.Text = "Id";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(745, 236);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(338, 20);
            this.txtName.TabIndex = 33;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(745, 285);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(338, 20);
            this.txtPrice.TabIndex = 32;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(745, 193);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(338, 20);
            this.txtBrand.TabIndex = 31;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(745, 329);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(338, 20);
            this.txtSize.TabIndex = 30;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(745, 147);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(338, 20);
            this.txtId.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(595, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 20);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Search";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(57, 65);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(532, 20);
            this.txtKeyword.TabIndex = 43;
            // 
            // PlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 492);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.gridPlane);
            this.Name = "PlaneForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PlaneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPlane.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridPlane;
        private Telerik.WinControls.UI.RadButton BtnDelete;
        private Telerik.WinControls.UI.RadButton BtnEdit;
        private Telerik.WinControls.UI.RadButton BtnAdd;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadTextBox txtPrice;
        private Telerik.WinControls.UI.RadTextBox txtBrand;
        private Telerik.WinControls.UI.RadTextBox txtSize;
        private Telerik.WinControls.UI.RadTextBox txtId;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadTextBox txtKeyword;
    }
}

