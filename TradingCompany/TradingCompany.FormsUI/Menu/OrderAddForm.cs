using System;
using System.Linq;
using System.Windows.Forms;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Abstract;

namespace TradingCompany.FormsUI.Menu
{
    public partial class OrderAddForm : Form
    {
        readonly private OrderDTO _order;
        readonly private IUserService _userService;
        readonly private IOrderService _orderService;

        public OrderAddForm(OrderDTO orderDTO, IUserService userService, IOrderService orderService)
        {
            _order = orderDTO;
            _orderService = orderService;
            _userService = userService;
            InitializeComponent();
            SetUpForm();
        }
        private void SetUpForm()
        {
            combobox_user.Items.AddRange(_userService.GetUserNames().ToArray());
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            //TODO validation



            OrderViewModel order = new OrderViewModel();
            order.Destination = textbox_destination.Text;
            order.OrderDate = datetime_picker_date.Value;
            order.User = combobox_user.SelectedItem.ToString();
            order.Id = _order.Id;

            _orderService.Create(order);
            MessageBox.Show(
                "Order was added successully!",
                "OK",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
            this.Close();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Combobox_user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_datetime_Click(object sender, EventArgs e)
        {

        }

        private void Label_yser_Click(object sender, EventArgs e)
        {

        }

        private void Label_destination_Click(object sender, EventArgs e)
        {

        }

        private void Datetime_picker_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OrderAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
