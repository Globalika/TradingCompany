using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Abstract;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.UnitOfWork;

namespace TradingCompany.BLL.Services.Impl
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<OrderViewModel> GetViewModels()
        {
            IEnumerable<OrderDTO> orderDTO = this.GetAll();
            var ordersView = orderDTO.ToList().ConvertAll(x => _mapper.Map<OrderDTO, OrderViewModel>(x));
            return ordersView;
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            List<OrderDTO> ordersDTO = new List<OrderDTO>();
            foreach (var order in _unitOfWork.OrdersRepository.GetAll())
            {
                OrderDTO OrderDTO = _mapper.Map<Order, OrderDTO>(order);
                OrderDTO.User = _unitOfWork.UsersRepository.Get(new UserFilter() { Id = order.Id });
                ordersDTO.Add(OrderDTO);
            }
            return ordersDTO;
        }
        public OrderDTO GetById(ulong id)
        {
            Order order = _unitOfWork.OrdersRepository.Get(new OrderFilter() { Id = id });
            OrderDTO OrderDTO = _mapper.Map<Order, OrderDTO>(order);
            OrderDTO.User = _unitOfWork.UsersRepository.Get(new UserFilter() { Id = order.Id });
            return OrderDTO;
        }
        public bool Create(OrderViewModel model)
        {
            try
            {
                Order order = _mapper.Map<OrderViewModel, Order>(model);
                order.UserId = _unitOfWork.UsersRepository.Get(new UserFilter() { Email = model.User }).Id;
                _unitOfWork.OrdersRepository.Create(order);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Create(OrderDTO model)
        {
            try
            {
                Order order = _mapper.Map<OrderDTO, Order>(model);
                _unitOfWork.OrdersRepository.Create(order);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Update(OrderViewModel model)
        {
            try
            {

                Order order = _mapper.Map<OrderViewModel, Order>(model);
                order.UserId = _unitOfWork.UsersRepository.Get(new UserFilter() { Email = model.User }).Id;
                _unitOfWork.OrdersRepository.Update(order, new OrderFilter() { Id = order.Id });
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Delete(ulong id)
        {
            try
            {
                _unitOfWork.OrdersRepository.Delete(new OrderFilter() { Id = id });
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
