using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingCompany.BLL;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Abstract;
using Unity.Resolution;

namespace TradingCompany.FormsUI.Menu
{
    public partial class OrdersManagerForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly ISupplierService _supplierService;
        private readonly ISuppToProdService _spService;


        private IEnumerable<OrderViewModel> _dataGridObjects;
        private IEnumerable<OrderViewModel> _filtedDataGridObjects;
        private IEnumerable<SupplierDTO> _suppDataGridObjects;
        private IEnumerable<SupplierDTO> _suppFiltedDataGridObjects;
        private IEnumerable<SuppToProdViewModel> _spDataGridObjects;
        private IEnumerable<SuppToProdViewModel> _spFiltedDataGridObjects;

        private Regex filter = new Regex(@"\w *");
        private Regex supFilter = new Regex(@"\w *");
        private Regex spFilter = new Regex(@"\w *");


        public OrdersManagerForm(IOrderService orderService, ISupplierService supplierService, ISuppToProdService suppToProdService)
        {
            _orderService = orderService;
            _supplierService = supplierService;
            _spService = suppToProdService;

            InitializeComponent();
            SetUpForm();
        }
        private void SetUpForm()
        {
            RestoreDataGrid();
        }
        private void RestoreDataGrid()
        {
            _dataGridObjects = _orderService.GetViewModels();
            _suppDataGridObjects = _supplierService.GetAll();
            _spDataGridObjects = _spService.GetViewModels();
            UpdateDataGrid();
        }
        private void UpdateDataGrid()
        {
            _filtedDataGridObjects = (_dataGridObjects).Where(u => filter.IsMatch(u.OrderDate.ToString()) ||
                filter.IsMatch(u.User) ||
                filter.IsMatch(u.Destination));
            orderViewModelBindingSource.DataSource = _filtedDataGridObjects;

            _suppFiltedDataGridObjects = (_suppDataGridObjects).Where(u => supFilter.IsMatch(u.Id.ToString()) ||
                filter.IsMatch(u.Name));
            supplierDTOBindingSource.DataSource = _suppFiltedDataGridObjects;


            _spFiltedDataGridObjects = (_spDataGridObjects).Where(u => spFilter.IsMatch(u.Id.ToString()) ||
                filter.IsMatch(u.Product) ||
                filter.IsMatch(u.Supplier));
            suppToProdViewModelBindingSource.DataSource = _spFiltedDataGridObjects;
        }
        //private void Datagrid_recent_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    OrderViewModel order = (_filtedDataGridObjects.ToList()[e.RowIndex]);
        //    var orderForm = DependencyInjectorBLL.Resolve<OrderEditForm>(new ParameterOverride("order", order));
        //    orderForm.Show();
        //}


        private void Button_add_order_Click(object sender, EventArgs e)
        {
            var form = DependencyInjectorBLL.Resolve<OrderAddForm>();
            form.Show();
        }
        private void Textbox_search_KeyPressed(object sender, EventArgs e)
        {
            var option = textbox_search.Text;
            filter = new Regex(string.Format(@"\w*{0}\w*", option));
            UpdateDataGrid();
        }

        private void Button_reload_Click(object sender, EventArgs e)
        {
            RestoreDataGrid();
        }
        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Datagrid_recent_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderViewModel order = (_filtedDataGridObjects.ToList()[e.RowIndex]);
            var orderForm = DependencyInjectorBLL.Resolve<OrderEditForm>(new ParameterOverride("order", order));
            orderForm.Show();

        }

        private void Button_supp_add_Click(object sender, EventArgs e)
        {

        }

        private void Button_supp_reload_Click(object sender, EventArgs e)
        {

        }

        private void UserDTOBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void OrderViewModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Button_sp_add_Click(object sender, EventArgs e)
        {
            var form = DependencyInjectorBLL.Resolve<SupProdAddFformcs>();
            form.Show();
        }

        private void Textbox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_search_KeyUp(object sender, KeyEventArgs e)
        {
            var option = textbox_search.Text;
            filter = new Regex(string.Format(@"\w*{0}\w*", option));
            UpdateDataGrid();
        }

        private void Textbox_supp_search_KeyUp(object sender, KeyEventArgs e)
        {
            var option = textbox_supp_search.Text;
            supFilter = new Regex(string.Format(@"\w*{0}\w*", option));
            UpdateDataGrid();
        }

        private void Datagrid_sp_KeyUp(object sender, KeyEventArgs e)
        {
            var option = textbox_sp.Text;
            spFilter = new Regex(string.Format(@"\w*{0}\w*", option));
            UpdateDataGrid();
        }

        private void OrdersManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
