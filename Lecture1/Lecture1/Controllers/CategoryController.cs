using Lecture1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Lecture1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public static List<Category> listofCategories = new List<Category>
        {
            new Category{ Id= 1, Title="Samsung", DisplayOrder= 1},
            new Category{ Id= 2, Title="Huawie", DisplayOrder= 2},
            new Category{ Id= 3, Title="Vivo", DisplayOrder= 3},
            new Category{ Id= 4, Title="Techno", DisplayOrder= 4},
            new Category{ Id= 5, Title="Apple", DisplayOrder= 5},
        };
        [HttpGet]

        public IEnumerable<Category> Get()
        {
            return listofCategories;
        }
        [HttpPost]

        public void Post([FromBody] Category category)
        {
            listofCategories.Add(category);
        }

        [HttpPut("{id}")]

        public void Put(int id, [FromBody] Category category)
        {
            listofCategories[id] = category;
        }

        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            listofCategories.RemoveAt(id);
        }
    }
}
