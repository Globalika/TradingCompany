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
    public class SuppToProdService : ISuppToProdService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SuppToProdService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<SuppToProdViewModel> GetViewModels()
        {
            IEnumerable<SuppToProdDTO> suppToProdDTO = this.GetAll();
            var suppToProdsView = suppToProdDTO.ToList().ConvertAll(x => _mapper.Map<SuppToProdDTO, SuppToProdViewModel>(x));
            return suppToProdsView;
        }

        public IEnumerable<SuppToProdDTO> GetAll()
        {
            List<SuppToProdDTO> suppToProdsDTO = new List<SuppToProdDTO>();
            foreach (var suppToProd in _unitOfWork.SuppToProdRepository.GetAll())
            {
                SuppToProdDTO suppToProdDTO = _mapper.Map<SupplierToProduct, SuppToProdDTO>(suppToProd);
                suppToProdDTO.Supplier = _unitOfWork.SuppliersRepository.Get(new SupplierFilter() { Id = suppToProd.SupplierId });
                suppToProdDTO.Product = _unitOfWork.ProductsRepository.Get(new ProductFilter() { Id = suppToProd.ProductId });

                suppToProdsDTO.Add(suppToProdDTO);
            }
            return suppToProdsDTO;
        }
        public SuppToProdDTO GetById(ulong id)
        {
            SupplierToProduct suppToProd = _unitOfWork.SuppToProdRepository.Get(new SupplierToProductFilter() { Id = id });
            SuppToProdDTO suppToProdDTO = _mapper.Map<SupplierToProduct, SuppToProdDTO>(suppToProd);
            suppToProdDTO.Supplier = _unitOfWork.SuppliersRepository.Get(new SupplierFilter() { Id = suppToProd.SupplierId });
            suppToProdDTO.Product = _unitOfWork.ProductsRepository.Get(new ProductFilter() { Id = suppToProd.ProductId });

            return suppToProdDTO;
        }
        public bool Create(SuppToProdViewModel model)
        {
            try
            {
                SupplierToProduct suppToProd = _mapper.Map<SuppToProdViewModel, SupplierToProduct>(model);
                Product prod = _unitOfWork.ProductsRepository.Get(new ProductFilter() { Name = model.Product });

                SupplierToProduct sup = _unitOfWork.SuppToProdRepository.Get(new SupplierToProductFilter() { ProductId = prod.Id });

                sup.SupplierId = _unitOfWork.SuppliersRepository.Get(new SupplierFilter() { Name = model.Supplier }).Id;
                sup.ProductId = _unitOfWork.ProductsRepository.Get(new ProductFilter() { Name = model.Product }).Id;

                //sup.ProductId = suppToProd.ProductId;
                //sup.SupplierId = suppToProd.SupplierId;

                //_suppToProdDTO.Supplier = _unitOfWork.SuppliersRepository.Get(new SupplierFilter() { Id = suppToProd.SupplierId });
                //_suppToProdDTO.Product = _unitOfWork.ProductsRepository.Get(new ProductFilter() { Id = suppToProd.ProductId 
                _unitOfWork.SuppToProdRepository.Update(sup, new SupplierToProductFilter() { Id = sup.Id });
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Update(SuppToProdViewModel model)
        {
            try
            {

                SupplierToProduct suppToProd = _mapper.Map<SuppToProdViewModel, SupplierToProduct>(model);
                SupplierToProduct sup = _unitOfWork.SuppToProdRepository.Get(new SupplierToProductFilter() { Id = model.Id });

                suppToProd.SupplierId = sup.ProductId; //_unitOfWork.UsersRepository.Get(new UserFilter() { Email = model.User }).Id;
                suppToProd.ProductId = sup.SupplierId;

                _unitOfWork.SuppToProdRepository.Update(suppToProd, new SupplierToProductFilter() { Id = suppToProd.Id });
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
                _unitOfWork.SuppToProdRepository.Delete(new SupplierToProductFilter() { Id = id });
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
