using Microsoft.AspNetCore.Mvc;
using bank_transaction_analyzer.Models;
using bank_transaction_analyzer.Data;
using System.Linq;
using System.Threading.Tasks;

namespace bank_transaction_analyzer.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransactionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Transaction
        public async Task<IActionResult> Index()
        {
            var transactions = await _context.Transactions.ToListAsync();
            return View(transactions);
        }

        // GET: Transaction/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);
        }

        // GET: Transaction/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transaction/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionId,Amount,Date,AccountId")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transaction);
        }
    }
}