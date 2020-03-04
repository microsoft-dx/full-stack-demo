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
    public class CuteAnimal
    {
        public string type { get; set; }
        public string name { get; set; }
        public string photo { get; set; }
        public int score { get; set; }

        public CuteAnimal(string type, string name, string photo, int score)
        {
            this.type = type;
            this.name = name;
            this.photo = photo;
            this.score = score;
        }

        public CuteAnimal()
        {
            // we need this when adding a new cute animal
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(type)
                && !string.IsNullOrWhiteSpace(name)
                && !string.IsNullOrWhiteSpace(photo);
        }
    }

    public class IndexModel : PageModel
    {
        private const string connectionString = "Server=tcp:full-stack-demo.database.windows.net,1433;Initial Catalog=demo;Persist Security Info=False;User ID=ioana;Password=P@ssw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private readonly ILogger<IndexModel> _logger;
        public List<CuteAnimal> animals { get; set;}

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var conn = new SqlConnection(connectionString);
            conn.Open();

            animals = new List<CuteAnimal>();

            using(var command = new SqlCommand("SELECT * FROM CUTE_ANIMALS ORDER BY CUTENESS_LEVEL DESC", conn))
            {
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string type = reader["ANIMAL_TYPE"].ToString();
                    string name = reader["ANIMAL_NAME"].ToString();
                    string photo = reader["PHOTO"].ToString();
                    int score = int.Parse(reader["CUTENESS_LEVEL"].ToString());

                    animals.Add(new CuteAnimal(type, name, photo, score));
                }
            }

            conn.Close();
        }
    }
}
