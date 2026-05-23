using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;
    public DeleteModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Order Order { get; set; } = null!;

    public IActionResult OnGet(int id)
    {
        Order = _context.Orders.Find(id);
        if (Order == null)
        {
            return NotFound();
        }

        return Page();
    }

    public IActionResult OnPost()
    {
        var order = _context.Orders.Find(Order.Id);
        if (order == null)
        {
            return NotFound();
        }

        _context.Orders.Remove(order);
        _context.SaveChanges();
        return RedirectToPage("Index");
    }

}