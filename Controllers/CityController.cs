using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Json;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET api/values/Faith
        [HttpGet("{title}")]
        public ActionResult<string> Get()
        { 
            var about="<p>Boston is the capital and most populous city of the Commonwealth of Massachusetts in the United States. The city proper covers 48 square miles (124 km2) with an estimated population of 694,583 in 2018, making it also the most populous city in New England. Boston is the seat of Suffolk County as well, although the county government was disbanded on July 1, 1999. The city is the economic and cultural anchor of a substantially larger metropolitan area known as Greater Boston, a metropolitan statistical area (MSA) home to a census-estimated 4.8 million people in 2016 and ranking as the tenth-largest such area in the country. As a combined statistical area (CSA), this wider commuting region is home to some 8.2 million people, making it the sixth most populous in the United States.</p></br>"+
                "<p>Boston is one of the oldest cities in the United States, founded on the Shawmut Peninsula in 1630 by Puritan settlers from England. It was the scene of several key events of the American Revolution, such as the Boston Massacre, the Boston Tea Party, the Battle of Bunker Hill, and the Siege of Boston. Upon gaining U.S. independence from Great Britain, it continued to be an important port and manufacturing hub as well as a center for education and culture. The city has expanded beyond the original peninsula through land reclamation and municipal annexation. Its rich history attracts many tourists, with Faneuil Hall alone drawing more than 20 million visitors per year. Boston's many firsts include the United States' first public park (Boston Common, 1634), first public or state school (Boston Latin School, 1635) and first subway system (Tremont Street Subway, 1897).</p></br>"+
                "<p>Today, Boston is a thriving port city. The Boston area's many colleges and universities make it an international center of higher education, including law, medicine, engineering, and business, and the city is considered to be a world leader in innovation and entrepreneurship, with nearly 2,000 startups. Boston's economic base also inclu Households in the city claim the highest average rate of philanthropy in the United States;businesses and institutions rank among the top in the country for environmental sustainability and investment. The city has one of the highest costs of living in the United State as it has undergone gentrification, though it remains high on world livability rankings.</p></br>"+
                "<p>Boston's early European settlers had first called the area Trimountaine (after its three mountains, only traces of which remain today) but later renamed it Boston after Boston, Lincolnshire, England, the origin of several prominent colonists. The renaming on September 7, 1630, (Old Style) was by Puritan colonists from England who had moved over from Charlestown earlier that year in quest for fresh water. Their settlement was initially limited to the Shawmut Peninsula, at that time surrounded by the Massachusetts Bay and Charles River and connected to the mainland by a narrow isthmus. The peninsula is thought to have been inhabited as early as 5000 BC.</p></br>";
            
            return about;
        }
    }
}