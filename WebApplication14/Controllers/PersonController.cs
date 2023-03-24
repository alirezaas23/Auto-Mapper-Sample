using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication14.Services;
using WebApplication14.ViewModels;

namespace WebApplication14.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonsRepository _personsRepository;
        private readonly IMapper _mapper;

        public PersonController(IPersonsRepository personsRepository, IMapper mapper)
        {
            _personsRepository = personsRepository ?? throw new ArgumentNullException(nameof(personsRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonsListViewModel>>> GetPersons()
        {
            var persons = await _personsRepository.GetPersonsAsync();

            var model = _mapper.Map<IEnumerable<PersonsListViewModel>>(persons);

            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult<PersonInfoViewModel>> PersonInfo(int personId)
        {
            var person = await _personsRepository.GetPersonByIdAsync(personId);

            if (person == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<PersonInfoViewModel>(person);

            return View(model);
        }
    }
}
