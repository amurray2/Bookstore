using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthFirstName = "Victor",
                        AuthLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Fiction = true,
                        Category = "Classic",
                        Price = 9.95m,
                        NumberPages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthFirstName = "Doris",
                        AuthMiddleName = "Kearns",
                        AuthLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Fiction = false,
                        Category = "Biography",
                        Price = 14.58m,
                        NumberPages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthFirstName = "Alice",
                        AuthLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Fiction = false,
                        Category = "Biography",
                        Price = 21.54m,
                        NumberPages = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthFirstName = "Ronald",
                        AuthMiddleName = "C.",
                        AuthLastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Fiction = false,
                        Category = "Biography",
                        Price = 11.61m,
                        NumberPages = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthFirstName = "Laura",
                        AuthLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Fiction = false,
                        Category = "Historical",
                        Price = 13.33m,
                        NumberPages = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthFirstName = "Michael",
                        AuthLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Fiction = true,
                        Category = "Historical Fiction",
                        Price = 15.95m,
                        NumberPages = 288
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthFirstName = "Cal",
                        AuthLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Fiction = false,
                        Category = "Self-Help",
                        Price = 14.99m,
                        NumberPages = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthFirstName = "Michael",
                        AuthLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Fiction = false,
                        Category = "Self-Help",
                        Price = 21.66m,
                        NumberPages = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthFirstName = "Richard",
                        AuthLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Fiction = false,
                        Category = "Business",
                        Price = 29.16m,
                        NumberPages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthFirstName = "John",
                        AuthLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Fiction = true,
                        Category = "Thrillers",
                        Price = 15.03m,
                        NumberPages = 642
                    },

                    new Book
                    {
                        Title = "The Hobbit",
                        AuthFirstName = "J. R.",
                        AuthMiddleName = "R.",
                        AuthLastName = "Tolkien",
                        Publisher = "Allen & Unwin",
                        ISBN = "978-0551303613",
                        Fiction = true,
                        Category = "Fantasy",
                        Price = 17.95m,
                        NumberPages = 310
                    },

                    new Book
                    {
                        Title = "To Kill a Mockingbird",
                        AuthFirstName = "Harper",
                        AuthLastName = "Lee",
                        Publisher = "J.B. Lippincott & Co.",
                        ISBN = "978-0551301067",
                        Fiction = true,
                        Category = "Thrillers",
                        Price = 6.49m,
                        NumberPages = 281
                    },

                    new Book
                    {
                        Title = "My Side of the Mountain",
                        AuthFirstName = "Jean",
                        AuthMiddleName = "Craighead",
                        AuthLastName = "George",
                        Publisher = "E.P. Dutton",
                        ISBN = "978-8531301667",
                        Fiction = true,
                        Category = "Adventure",
                        Price = 3.39m,
                        NumberPages = 177
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
