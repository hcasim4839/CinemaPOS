using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOLayer;
using DALayer;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            List<MovieTicketDTO> objDTO = new List<MovieTicketDTO>();


            

            for (int i = 0; i < 10; i++)
            {
                MovieTicketDTO dto = new MovieTicketDTO();
                dto.Name = "pokemon" + i;
                objDTO.Add(dto);
            }

            objDTO.ForEach(entry => Console.WriteLine(entry.Name));
            string query = "DELETE FROM Product WHERE Name IN (";

            for (int i = 0; i < objDTO.Count; i++)
            {
                if (i < 10 - 1)
                    query += "@Name" + i + ",";
                else
                    query += "@Name" + i;

            }

            query += ")";


            for (int i = 0; i < objDTO.Count; i++)
            {

                Console.WriteLine("In the parameter.addWithValue loop: " + objDTO[i].Name);
            }
            Console.WriteLine(query);
        }
        
      
    }
}
