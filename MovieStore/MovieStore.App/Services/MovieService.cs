using MovieStore.Models.Enums;
using MovieStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.App.Services
{
    public class MovieService
    {
        public List<Movie> Movies { get; set; }
        public MovieService()
        {
            Movies = new List<Movie>()
            {
                new Movie("The Lord of the Rings: Fellowship of the Ring", "A young hobbit, Frodo, who has found the One Ring that belongs to the Dark Lord Sauron, begins his journey with eight companions to Mount Doom, the only place where it can be destroyed.", 2001, MovieGenres.Fantasy),
                new Movie("The Lord of the Rings: The Two Towers", "Frodo and Sam arrive in Mordor with the help of Gollum. A number of new allies join their former companions to defend Isengard as Saruman launches an assault from his domain.", 2002, MovieGenres.Fantasy),
                new Movie("The Lord of the Rings: The Return of the King", "The former Fellowship members prepare for the final battle. While Frodo and Sam approach Mount Doom to destroy the One Ring, they follow Gollum, unaware of the path he is leading them to.", 2003, MovieGenres.Fantasy),
                new Movie("Inception", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", 2010, MovieGenres.SciFi),
                new Movie("The Shawshank Redemption", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", 1994, MovieGenres.Drama),
                new Movie("The Godfather", "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", 1972, MovieGenres.Crime),
                new Movie("The Dark Knight", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", 2008, MovieGenres.Action),
                new Movie("Pulp Fiction", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", 1994, MovieGenres.Crime),
                new Movie("Forrest Gump", "The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate, and other historical events unfold through the perspective of an Alabama man with an IQ of 75.", 1994, MovieGenres.Drama),
                new Movie("Star Wars: Episode IV - A New Hope", "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.", 1977, MovieGenres.SciFi),
                new Movie("The Matrix", "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", 1999, MovieGenres.SciFi),
                new Movie("The Silence of the Lambs", "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.", 1991, MovieGenres.Thriller),
                new Movie("The Usual Suspects", "A sole survivor tells of the twisty events leading up to a horrific gun battle on a boat, which began when five criminals met at a seemingly random police lineup.", 1995, MovieGenres.Crime),
                new Movie("Fight Club", "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into something much, much more.", 1999, MovieGenres.Drama),
                new Movie("Goodfellas", "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.", 1990, MovieGenres.Crime),
                new Movie("The Lion King", "A young lion prince is cast out of his pride by his cruel uncle, who claims he killed his father. While the uncle rules with an iron paw, the prince grows up beyond the savannah, living by a philosophy: No worries for the rest of your days.", 1994, MovieGenres.Animated),
                new Movie("Jurassic Park", "During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run amok.", 1993, MovieGenres.Adventure),
                new Movie("Deadpool", "Ajax, a twisted scientist, experiments on Wade Wilson, a mercenary, to cure him of cancer and give him healing powers. However, the experiment leaves Wade disfigured and he decides to exact revenge.", 2016, MovieGenres.Action),
                new Movie("Interstellar", "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", 2014, MovieGenres.SciFi),
                new Movie("The Revenant", "A frontiersman on a fur trading expedition in the 1820s fights for survival after being mauled by a bear and left for dead by members of his own hunting team.", 2015, MovieGenres.Adventure),
                new Movie("Parasite", "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.", 2019, MovieGenres.Drama),
                new Movie("La La Land", "While pursuing their dreams in Hollywood, a pianist and an actress fall in love while attempting to reconcile their aspirations for the future.", 2016, MovieGenres.Musical),
                new Movie("Whiplash", "A promising young drummer enrolls at a cut-throat music conservatory where his dreams of greatness are mentored by an instructor who will stop at nothing to realize a student's potential.", 2014, MovieGenres.Drama),
                new Movie("Get Out", "A young African-American visits his white girlfriend's parents for the weekend, where his simmering uneasiness about their reception of him eventually reaches a boiling point.", 2017, MovieGenres.Horror),
                new Movie("Her", "In a near future, a lonely writer develops an unlikely relationship with an operating system designed to meet his every need.", 2013, MovieGenres.SciFi),
                new Movie("Moonlight", "A young African-American man grapples with his identity and sexuality while experiencing the everyday struggles of childhood, adolescence, and burgeoning adulthood.", 2016, MovieGenres.Drama),
                new Movie("Mad Max: Fury Road", "In a post-apocalyptic wasteland, a woman rebels against a tyrannical ruler in search for her homeland with the aid of a group of female prisoners, a psychotic worshiper, and a drifter named Max.", 2015, MovieGenres.Action),
                new Movie("The Grand Budapest Hotel", "The adventures of Gustave H, a legendary concierge at a famous European hotel, and Zero Moustafa, the lobby boy who becomes his most trusted friend.", 2014, MovieGenres.Comedy)
            };
        }
        public void Add(Movie movie)
        {
            Movies.Add(movie);
        }
        public List<Movie> ListAvalable()
        {
            return Movies.Where(m => m.IsAvalable).ToList();
        }
        public Movie CheckOut(Movie movie)
        {
            int movIndex = Movies.IndexOf(movie);
            Movies[movIndex].IsAvalable = false;
            return Movies[movIndex];
        }
        public void Return(Movie movie)
        {
            int movIndex = Movies.IndexOf(movie);
            Movies[movIndex].IsAvalable = true;
        }
    }
}
