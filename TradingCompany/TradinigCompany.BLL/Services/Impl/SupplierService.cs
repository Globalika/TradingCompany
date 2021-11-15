using AutoMapper;
using System.Collections.Generic;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Services.Abstract;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.UnitOfWork;

namespace TradingCompany.BLL.Services.Impl
{
    public class SupplierService : ISupplierService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SupplierService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<SupplierDTO> GetAll()
        {
            List<SupplierDTO> suppliersDTO = new List<SupplierDTO>();
            foreach (var supplier in _unitOfWork.SuppliersRepository.GetAll())
            {
                SupplierDTO SupplierDTO = _mapper.Map<Supplier, SupplierDTO>(supplier);
                suppliersDTO.Add(SupplierDTO);
            }
            return suppliersDTO;
        }
        public SupplierDTO GetById(ulong id)
        {
            Supplier supplier = _unitOfWork.SuppliersRepository.Get(new SupplierFilter() { Id = id });
            SupplierDTO SupplierDTO = _mapper.Map<Supplier, SupplierDTO>(supplier);
            return SupplierDTO;
        }
        public bool Create(SupplierDTO dto)
        {
            try
            {
                Supplier supplier = _mapper.Map<SupplierDTO, Supplier>(dto);
                _unitOfWork.SuppliersRepository.Create(supplier);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Update(SupplierDTO dto)
        {
            try
            {

                Supplier supplier = _mapper.Map<SupplierDTO, Supplier>(dto);
                _unitOfWork.SuppliersRepository.Update(supplier, new SupplierFilter() { Id = supplier.Id });
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
                _unitOfWork.SuppliersRepository.Delete(new SupplierFilter() { Id = id });
            }
            catch
            {
                return false;
            }
            return true;
        }
        public IEnumerable<string> GetSupplierByProduct(string productName)
        {
            List<string> supplierNames = new List<string>();
            Product product = _unitOfWork.ProductsRepository.Get(new ProductFilter() { Name = productName });
            var suppliersProd = _unitOfWork.SuppToProdRepository.GetAll(new SupplierToProductFilter() { ProductId = product.Id });
            foreach (SupplierToProduct sp in suppliersProd)
            {
                supplierNames.Add(_unitOfWork.SuppliersRepository.Get(new SupplierFilter() { Id = sp.SupplierId }).Name);
            }
            return supplierNames;
        }
    }
}
