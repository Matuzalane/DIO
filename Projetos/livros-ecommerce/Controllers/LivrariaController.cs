using livros_ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace livros_ecommerce.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class LivrariaController : ControllerBase
    {
        private readonly ToDoContext _context;

        public LivrariaController(ToDoContext context) 
        {
            _context = context;

            if (_context.todoProducts.Count() == 0)
            {
                _context.todoProducts.Add(new Produto { Id = 1, Nome = "Book1", Preco = 24.00M, Quantidade = 1, Categoria = "Ação", Img = "img1" });
                _context.todoProducts.Add(new Produto { Id = 2, Nome = "Book2", Preco = 25.80M, Quantidade = 2, Categoria = "Ação", Img = "img2" });
                _context.todoProducts.Add(new Produto { Id = 3, Nome = "Book3", Preco = 30.00M, Quantidade = 8, Categoria = "Ação", Img = "img3" });
                _context.todoProducts.Add(new Produto { Id = 4, Nome = "Book4", Preco = 22.70M, Quantidade = 4, Categoria = "Ação", Img = "img4" });
                _context.todoProducts.Add(new Produto { Id = 5, Nome = "Book5", Preco = 120.00M, Quantidade = 3, Categoria = "Ação", Img = "img5" });
                _context.todoProducts.Add(new Produto { Id = 6, Nome = "Book6", Preco = 18.00M, Quantidade = 7, Categoria = "Ação", Img = "img6" });


                _context.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            return await _context.todoProducts.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetItem(int id)
        {
            var item = await _context.todoProducts.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        {
            _context.todoProducts.Add(produto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetItem), new { id = produto.Id }, produto);
        }
    }
}