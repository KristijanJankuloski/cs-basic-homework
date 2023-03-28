using MovieStore.Models.Enums;
using MovieStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.App.Services
{
    public class MemberService
    {
        public Dictionary<string, Member> Members { get; set; }

        public MemberService()
        {
            Members = new Dictionary<string, Member>() { };
        }

        public void Add(string username, string firstName, string lastName, string password, int age, Subscriptions sub)
        {
            Member member = new Member(Members.Count, firstName, lastName, age, username, password, sub);
            if (Members.ContainsKey(member.UserName))
            {
                throw new Exception("User already exists");
            }
            Members.Add(member.UserName, member);
        }
        public void Delete(string username)
        {
            bool removed = Members.Remove(username);
            if (!removed)
                throw new Exception();
        }
        public bool IsUsernameTaken(string username)
        {
            return Members.ContainsKey(username);
        }
        public Member Login(string username, string password)
        {
            if (!Members.ContainsKey(username))
                throw new Exception("Username or password is incorrect");
            if (!Members[username].ChechPassword(password))
                throw new Exception("Username or password is incorrect");
            return Members[username];
        }
        public string GetUserInfo(string useranme)
        {
            return Members[useranme].GetInfo();
        }
        public void RentMovie(string username, Movie movie)
        {
            if (!Members.ContainsKey(username))
                throw new Exception("No user with that username exists.");
            Members[username].RentedMovies.Add(movie);
        }

        public void ReturnMovie(string username, Movie movie)
        {
            if (!Members.ContainsKey(username))
                throw new Exception("No user with that username exists.");
            Members[username].RentedMovies.Remove(movie);
        }

        public List<Movie> GetRentedMovies(string username)
        {
            return Members[username].RentedMovies;
        }
    }
}
