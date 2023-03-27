using MovieStore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models.Models
{
    public class Member : User
    {
        public int Id { get; set; }
        public Subscriptions Subscription { get; set; }
        public List<Movie> RentedMovies { get; set; }

        public Member(){}
        public Member(int id, string firstName, string lastName, int age, string username, string password, Subscriptions sub): base(firstName, lastName, age, username, password, UserRoles.Member) 
        {
            Id = id;
            Subscription = sub;
            RentedMovies = new List<Movie>();
        }
    }
}
