using System.Collections.Generic;

namespace PersonalWebsite.Models
{
    public class RealDatabase
    {
        public static readonly List<Project> Projects = new List<Project>
        {
            new Project {
                Title="Project Euler Solutions", 
                Description="This is my personal repo to store solutions to various problems on projecteuler.net. " +
                "From their website: \"Project Euler is a series of challenging mathematical/computer programming problems " +
                "that will require more than just mathematical insights to solve. " +
                "Although mathematics will help you arrive at elegant and efficient methods, " +
                "the use of a computer and programming skills will be required to solve most problems.\" " +
                "At the time of writing, I have solved 107 / 773 problems (a total of 13.8%), " +
                "although I did have to review existing solutions occasionally.",
                GitHubLink="https://github.com/ethanrweber/ProjectEuler"
            },

            new Project
            {
                Title="My Personal Website",
                Description="You're looking at it! " +
                "I made this website in ASP.NET Core (.NET 5) using Razor Pages. " +
                "I work with ASP.NET currently so making this personal project was relatively easy. " +
                "I enjoyed finding inspiration from around the web while making this!",
                GitHubLink="https://github.com/ethanrweber/PersonalWebsite"
            }
        };
    }
}
