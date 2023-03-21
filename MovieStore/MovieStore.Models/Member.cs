using MovieStore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class Member : User
    {
        public int Id { get; set; }
        public Subscriptions Subscription { get; set; }
        public List<Movie> RentedMovies { get; set; }
    }
}
