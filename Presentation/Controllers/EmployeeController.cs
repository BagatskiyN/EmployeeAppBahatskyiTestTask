using AutoMapper;
using BusinessLogic.Dtos;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Presentation.Models;
using Presentation.Models.Requests;

namespace Presentation.Controllers
{
    [Route("")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        private readonly IProgrammingLanguageService _programmingLanguageService;
        private readonly IMapper _mapper;

        public EmployeeController(
            IEmployeeService employeeService,
            IDepartmentService departmentService,
            IProgrammingLanguageService programmingLanguageService,
            IMapper mapper)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            _programmingLanguageService = programmingLanguageService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string searchTerm)
        {
            var employees = await _employeeService.GetAllAsync(searchTerm);

            var employeeViews = _mapper.Map<List<EmployeeViewModel>>(employees);

            return View(employeeViews);
        }

        [HttpGet("add")]
        public async Task<IActionResult> Add()
        {
            ViewBag.Departments = await _departmentService.GetAllAsync();
            ViewBag.ProgrammingLanguages = await _programmingLanguageService.GetAllAsync();

            return View(new CreateEmployeeRequest());
        }

        [HttpPost("add")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(CreateEmployeeRequest createEmployeeRequest)
        {
            if (!ModelState.IsValid)
            {
                return View(createEmployeeRequest);
            }

            var createEmployeeDto = _mapper.Map<CreateEmployeeDto>(createEmployeeRequest);
            await _employeeService.CreateAsync(createEmployeeDto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var employeeDto = await _employeeService.GetByIdAsync(id);
            if (employeeDto == null) return NotFound();

            ViewBag.Departments = new SelectList(await _departmentService.GetAllAsync(), "Id", "Name", employeeDto.DepartmentId);
            ViewBag.ProgrammingLanguages = new SelectList(await _programmingLanguageService.GetAllAsync(), "Id", "Name", employeeDto.ProgrammingLanguageIds);

            var updateEmployeeRequest = _mapper.Map<UpdateEmployeeRequest>(employeeDto);
            return View(updateEmployeeRequest);
        }

        [HttpPost("edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateEmployeeRequest updateEmployeeRequest) 
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = new SelectList(await _departmentService.GetAllAsync(),"Id", "Name", updateEmployeeRequest.DepartmentId);
                ViewBag.ProgrammingLanguages = new SelectList(await _programmingLanguageService.GetAllAsync(), "Id", "Name", updateEmployeeRequest.ProgrammingLanguageIds);

                return View(updateEmployeeRequest);
            }

            var existingEmployeeDto = await _employeeService.GetByIdAsync(updateEmployeeRequest.Id);
            if (existingEmployeeDto == null)
            {
                return NotFound("Employee not found.");
            }

            var updateEmployeeDto = new UpdateEmployeeDto
            {
                Id = updateEmployeeRequest.Id,
                FirstName = updateEmployeeRequest.FirstName,
                LastName = updateEmployeeRequest.LastName,
                Age = updateEmployeeRequest.Age,
                DepartmentId = updateEmployeeRequest.DepartmentId,
                ProgrammingLanguageIds = updateEmployeeRequest.ProgrammingLanguageIds
            };

            try
            {
                await _employeeService.UpdateAsync(updateEmployeeDto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Unable to update employee. Please try again.");

                ViewBag.Departments = await _departmentService.GetAllAsync();
                ViewBag.ProgrammingLanguages = await _programmingLanguageService.GetAllAsync();

                return View(updateEmployeeRequest);
            }
        }

        [HttpPost("delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _employeeService.SoftDeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("autocomplete")]
        public async Task<IActionResult> Autocomplete(string term)
        {
            var employees = await _employeeService.GetAllAsync(term);
            return Json(employees);
        }
    }
}
