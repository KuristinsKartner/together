using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WebApplication8.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebApplication8.Pages
{
    public class IndexModel : PageModel
    {
        // проблема в option
        private readonly ILogger<IndexModel> _logger;
        List<MyType> types;
        public List<MyType> MyTypes { set; get; }
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            types = new List<MyType>()
            {
                new MyType{MyName="Фотография"},
                new MyType{MyName="Открытка"},
                new MyType{MyName="Письмо"},
                new MyType{MyName="Проповедь"},
                new MyType{MyName="Записки технические"},
                new MyType{MyName="Записки богословские"},
                new MyType{MyName="Записки бытовые, документы"}
            };
        }
        

        public void OnGet()
        {

        }
        public void OnPostSave()
        {
            Note record = new Note();
            record.Author = Request.Form["author"];
            DBConnection db = new DBConnection();
            //MySqlCommand command = new MySqlCommand("", db.getConnection());
            string curr_command = "";
            if (record.Author != "")
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("", db.getConnection());
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                curr_command = "SELECT * FROM dtype";
               // curr_command = "SELECT id FROM author WHERE name = @A";
                command.CommandText = curr_command;
               // command.Parameters.Add("@A", MySqlDbType.VarChar).Value = record.Author;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    table.Rows[0].Field<string>("id");
                }

                db.closeConnection();
            }
        }
    }
}
