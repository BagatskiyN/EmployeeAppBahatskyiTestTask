using AutoMapper;
using BusinessLogic.Dtos;
using BusinessLogic.Interfaces;
using DataAccess.Entities;
using DataAccess.Interfaces;

namespace BusinessLogic.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllAsync(string searchTerm)
        {
            var employees = await _employeeRepository.SearchEmployeesAsync(searchTerm);
            return _mapper.Map<IEnumerable<EmployeeDto>>(employees);
        }

        public async Task<EmployeeDto> GetByIdAsync(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null) throw new KeyNotFoundException("Employee not found.");
            return _mapper.Map<EmployeeDto>(employee);
        }

        public async Task CreateAsync(CreateEmployeeDto createEmployeeDto)
        {
            var employee = _mapper.Map<Employee>(createEmployeeDto);

            await _employeeRepository.AddAsync(employee);
        }

        public async Task UpdateAsync(UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = await _employeeRepository.GetByIdAsync(updateEmployeeDto.Id);
            if (employee == null) throw new KeyNotFoundException("Employee not found.");

            _mapper.Map(updateEmployeeDto, employee);
            await _employeeRepository.UpdateAsync(employee);
        }

        public async Task SoftDeleteAsync(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null) throw new KeyNotFoundException("Employee not found.");

            employee.IsDeleted = true;
            await _employeeRepository.UpdateAsync(employee);
        }
    }
}
