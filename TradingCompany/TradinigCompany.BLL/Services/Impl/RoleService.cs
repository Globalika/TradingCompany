using AutoMapper;
using System.Collections.Generic;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Abstract;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.UnitOfWork;

namespace TradingCompany.BLL.Services.Impl
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RoleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<UserViewModel> GetAllRoles()
        {
            //UserDTO userDTO = new UserDTO();
            List<UserViewModel> usersView = new List<UserViewModel>();
            //List<UserDTO> usersDTO = new List<UserDTO>();
            //List<User> users = Users.GetAll().ToList();

            //foreach ( User user in users)
            //{
            //    UserDTO userDTO = mapper.Map<User, UserDTO>(user);
            //    userDTO.Role = Roles.Get(new RoleFilter() { Id = user.RoleId }) ;
            //    usersDTO.Add(userDTO);
            //    usersView.Add(mapper.Map<UserDTO, UserViewModel>(userDTO));
            //}

            return usersView;
        }
        public void CreateRole(UserRegistrationModel model)
        {
            //if (Users.Get(new UserFilter() { Email = model.Email }) != null)
            //{
            //    UserDTO user = mapper.Map<UserRegistrationModel, UserDTO>(model);

            //}

        }
        public IEnumerable<string> GetRoleNames()
        {
            List<string> roleNames = new List<string>();
            var roles = _unitOfWork.RolesRepository.GetAll();
            foreach (Role role in roles)
            {
                roleNames.Add(role.Name);
            }
            return roleNames;
        }
    }
}
