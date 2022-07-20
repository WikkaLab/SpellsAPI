using Microsoft.AspNetCore.Mvc;

namespace SpellsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpellController : ControllerBase
    {
        private readonly ILogger<SpellController> _logger;

        public SpellController(ILogger<SpellController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSpells")]
        public IEnumerable<Spell> Get()
        {
            return GetSpells().ToArray();
        }

        private List<Spell> GetSpells()
        {
            return new List<Spell>
            {
                new Spell
                {
                    Title = "Dancing Lights",
                    School = "Evocation"
                },
                new Spell
                {
                    Title = "Acid Splash",
                    School = "Conjuration"
                },
                new Spell
                {
                    Title = "Frostbite",
                    School = "Evocation"
                },
                new Spell
                {
                    Title = "Control Flames",
                    School = "Transmutation"
                }
            };
        }
    }
}