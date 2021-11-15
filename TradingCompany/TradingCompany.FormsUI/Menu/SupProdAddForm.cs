using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Services.Abstract;
using TradingCompany.DAL.Models.Entities.Impl;

namespace TradingCompany.FormsUI.Menu
{
    public partial class SupProdAddFformcs : Form
    {
        readonly private SuppToProdDTO _sp;

        readonly private ISuppToProdService _suppProdService;
        readonly private IProductService _productService;
        readonly private ISupplierService _supplierService;


        public SupProdAddFformcs(SuppToProdDTO spDTO, IProductService productService,
            ISupplierService supplierService,
            ISuppToProdService suppProdService)
        {
            _sp = spDTO;
            _productService = productService;
            _suppProdService = suppProdService;
            _supplierService = supplierService;

            InitializeComponent();
            SetUpForm();
        }
        private void SetUpForm()
        {
            //combobox_user.Items.AddRange(_userService.GetUserNames().ToArray());
            combobox_product.Items.AddRange(_productService.GetProducts().ToArray());
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            //TODO validation

            SuppToProdViewModel sp = new SuppToProdViewModel();
            sp.Product = combobox_product.SelectedItem.ToString();
            sp.Supplier = combobox_supplier.SelectedItem.ToString();
            sp.Id = _sp.Id;

            _suppProdService.Create(sp);
            MessageBox.Show(
                "Order was added successully!",
                "OK",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        private void Combobox_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Combobox_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_supplier.Items.AddRange(_supplierService.GetSupplierByProduct(combobox_product.SelectedItem.ToString()).ToArray());
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupProdAddFformcs_Load(object sender, EventArgs e)
        {

        }
    }
}
