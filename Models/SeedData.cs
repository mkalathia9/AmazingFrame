using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AmazingFrame.Data;
using System;
using System.Linq;

namespace AmazingFrame.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AmazingFrameContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AmazingFrameContext>>()))
            {
                // Look for any movies.
                if (context.Frame.Any())
                {
                    return;   // DB has been seeded
                }

                context.Frame.AddRange(
                    new Frame
                    {
                        Name = "Beauty1",
                        Color = "Black",
                        Material = "Wood",
                        Style = "Fency",
                        Price = 150,
                        Rating = 4
                    },
                    new Frame
                    {
                        Name = "Modern Frame",
                        Color = "Black",
                        Material = "Plastic",
                        Style = "Fency",
                        Price = 50,
                        Rating = 3
                    },
                    new Frame
                    {
                        Name = "Floating Frame",
                        Color = "White",
                        Material = "Wood",
                        Style = "Unique",
                        Price = 250,
                        Rating = 5
                    },
                     new Frame
                     {
                         Name = "Deep-Set Frames",
                         Color = "Blue",
                         Material = "Wood",
                         Style = "Fency",
                         Price = 280,
                         Rating = 4
                     },
                     new Frame
                     {
                         Name = "Canvas",
                         Color = "Grey",
                         Material = "Metal",
                         Style = "20's",
                         Price = 190,
                         Rating = 4
                     },
                     new Frame
                     {
                         Name = "Tabletop Frames",
                         Color = "Black",
                         Material = "Wood",
                         Style = "Steel",
                         Price = 89,
                         Rating = 4
                     },
                     new Frame
                     {
                         Name = "Poster",
                         Color = "Black",
                         Material = "ThikPaper",
                         Style = "Titanium",
                         Price = 449,
                         Rating = 5
                     },
                     new Frame
                     {
                         Name = "OldGold",
                         Color = "Golden",
                         Material = "GoldPlated",
                         Style = "Premium",
                         Price = 999,
                         Rating = 5
                     },
                     new Frame
                     {
                         Name = "Silver",
                         Color = "SIlver",
                         Material = "SilverPlated",
                         Style = "Premium",
                         Price = 699,
                         Rating = 5
                     },
                     new Frame
                     {
                         Name = "Poly",
                         Color = "Red",
                         Material = "Polycarbonate",
                         Style = "Classic",
                         Price = 199,
                         Rating = 3
                     }
                ); ;
                context.SaveChanges();
            }
        }
    }
}