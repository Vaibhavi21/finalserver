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
    public class TouristController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET api/values/Faith
        [HttpGet("{title}")]
        public ActionResult<string> Get()
        {
            var tourist = "<p>The museum began as the Boston Society of Natural History in 1830, founded by a collection of men who wished to share scientific interests.Their first meeting was held on February 9, 1830 with seven original members in attendance: Walter Channing, Benjamin E.Green, George Hayward, John Ware, Edward Brooks, Amos Binney, and George B.Emerson.It was more commonly called the Boston Museum of Natural History in the 19th century, and this name occurs frequently in the literature.In 1862, after the society had gone through several temporary facilities, a building was constructed in the Back Bay area of the city and dubbed the New England Museum of Natural History. The museum was located next to the original Rogers Building of the Massachusetts Institute of Technology (MIT), and both neoclassical structures were designed by William G.Preston.The original MIT building was demolished in 1939, but the Natural History Museum building survives today, as a home furnishings showcase." +
                        "A great deal of scientific work was done by the society, especially around geology, and the results of this work can be found in the Proceedings of the Boston Society of Natural History which are now freely available online.A library and children's rooms were added to the museum around 1900. It was renamed the Museum of Science in 1939, under the directorship of Henry Bradford Washburn, Jr., a renown American mountaineer." +
                        "The Boston Museum of Natural History of 1830/1864–1945 should not be confused with the private Warren Museum of Natural History(1858–1906, formerly on Chestnut Street in Boston). The contents of the latter collection, including the first intact mastodon, were relocated to the American Museum of Natural History of New York City in 1906" +
                        "Museum Then and Now, an exhibit of artifacts from the early years of the society, is located near the second floor Blue Wing entrance to the Theater of Electricity in today's museum.</p></br>"+
                        "<p>Boston's Back Bay, including the land the garden sits on, was mudflats until filling began in the early 1800s. The land of the Public Garden was the earliest filled, as the area that is now Charles Street had been used as a ropewalk since 1796.[4] The town of Boston granted ropemakers use of the land on July 30, 1794,[5] after a fire had destroyed the ropewalks in a more populated area of the city. As a condition of its use, the ropewalk's proprietors were required to build a seawall and fill in the land which is now Charles Street and the land immediately bordering it (now a part of the Public Garden)."+
                        "In February 1824, the city of Boston purchased back the land granted to the ropemakers, for a cost of $50, 000.[6] The next year, a proposal to turn the land into a graveyard was defeated by a vote of 1632 to 176.The Public Garden was established in 1837, when philanthropist Horace Gray[7] petitioned for the use of land as the first public botanical garden in the United States.By 1839, a corporation was formed, called Horace Gray and Associates, and made the " +
                        "Proprietors of the Botanic Garden in Boston."+" The corporation was chartered with creating what is now the Boston Public Garden.Nonetheless, there was constant pressure for the land to be sold to private interests for the construction of new housing."+
                        "While most of the land of the present-day garden had been filled in by the mid-1800s, the area of the Back Bay remained an undeveloped tidal basin.In 1842, the state legislature created The Commissioners on Boston Harbor and the Back Bay, in order to determine how to best develop the land; the state wanted to control the lands and to build an upper-class neighborhood in the area beyond the Public Garden.The City of Boston petitioned the state to grant control over the basin (which was controlled by the then-independent city of Roxbury), in hopes of generating significant revenue from any developments that would be built after filling it in. When the state commission rejected Boston's petition, the Boston City Council threatened to sell the garden to housing developers, which would have significantly reduced the desirability of the area for the upper class elite that the state was hoping to attract.</p></br>";
            return tourist;
        }
    }
}