using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;

namespace Demo.Pages
{
    public class AddCuteAnimalModel : PageModel
    {
        private const string connectionString = "Server=tcp:full-stack-demo.database.windows.net,1433;Initial Catalog=demo;Persist Security Info=False;User ID=ioana;Password=P@ssw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public CuteAnimal Model { get; set; }
        public bool ShowError { get; private set; }

        public AddCuteAnimalModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ShowError = false;
        }

        public IActionResult OnPost()
        {
            if(!Model.IsValid())
            {
                ShowError = true;
                return Page();
            }

            var conn = new SqlConnection(connectionString);
            conn.Open();

            var query = string.Format(
                "INSERT INTO CUTE_ANIMALS VALUES('{0}', '{1}', '{2}', {3})",
                Model.type,
                Model.name,
                Model.photo,
                Model.score);

            using (var command = new SqlCommand(query, conn))
            {
                command.ExecuteNonQuery();
            }

            conn.Close();

            return Redirect("/");
        }
    }
}
