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

            Member member = new Member("2");
            MemberDTO memberDTO = member.Select();

            
            


            Console.WriteLine("dfs");
            Console.WriteLine("The member info: " +memberDTO.Name + memberDTO.Points);

        }
    }
}
