using OnlineStudentManagementSystem.Configuration;
using OnlineStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Services
{
    public class AddressCodeService : IAddressCodeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddressCodeService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<AddressCode>> Get()
        {
            return await _unitOfWork.AddressCode.All();
        }
        public async Task<AddressCode> GetById(int id)
        {
            return await _unitOfWork.AddressCode.GetById(id);
        }
        public async Task CreateAddressCode(AddressCode addressCode)
        {
            try
            {
                await _unitOfWork.AddressCode.Add(addressCode);
                var numberOfRecord = await _unitOfWork.CompleteAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task DeleteAddressCode(int id)
        {
            await _unitOfWork.AddressCode.Delete(id);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<AddressCode> GetAddressCodeByFilter(string city, string state)
        {
            return await _unitOfWork.AddressCode.GetAsync(filter: a => (!string.IsNullOrWhiteSpace(city) ? a.City == city : true) &&
                                                                       (!string.IsNullOrWhiteSpace(state) ? a.State == state : true),
                                                          orderBy: a => a.OrderBy(b => b.City));
        }

    }
}
