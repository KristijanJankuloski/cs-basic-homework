using MovieStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.App.Services
{
    public class MemberService
    {
        public List<Member> Members { get; set; }

        public MemberService()
        {
            Members = new List<Member>() { };
        }
    }
}
