using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YellowBucket.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace YellowBucket.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new YellowBucketContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<YellowBucketContext>>()))
            {
                if (context.Kiosk.Any())
                {
                    return;
                }

                context.Kiosk.AddRange(

                    new Kiosk
                    {
                        Location = " Walmart in Monaca",
                        Address = "3942 Brodhead Rd",
                        City = "Monaca",
                        State = "PA",
                        Zip = "15061",
                    },

                    new Kiosk
                    {
                        Location = "Geneva College",
                        Address = "3200 College Ave",
                        City = "Beaver Falls",
                        State = "PA",
                        Zip = "15010",
                    },

                    new Kiosk
                    {
                        Location = "Rochester Giant Eagle",
                        Address = "111 W Madison St",
                        City = "Rochester",
                        State = "PA",
                        Zip = "15074",

                    }

                    );
                context.SaveChanges();
            }

        }
    }
}
