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
                        Price = 9.95m
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
                        Price = 14.58m
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
                        Price = 21.54m
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
                        Price = 11.61m
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
                        Price = 13.33m
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
                        Price = 15.95m
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
                        Price = 14.99m
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
                        Price = 21.66m
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
                        Price = 29.16m
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
                        Price = 15.03m
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
