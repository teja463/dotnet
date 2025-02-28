using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UserManagement.Data;
using UserManagement.Models;

namespace UserManagement.Pages.UserCrud
{
    public class IndexModel : PageModel
    {
        private readonly UserManagement.Data.ContosoPizza2Context _context;

        public IndexModel(UserManagement.Data.ContosoPizza2Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
            foreach (var user in User)
            {
                ICollection<Post> posts = user.Posts;
                Console.WriteLine(posts.Count());
            }
        }
    }
}
