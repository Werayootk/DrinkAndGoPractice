using DrinkAndGo.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace DrinkAndGo.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                    new Drink
                    {
                        Name = "Beer",
                        Price = 7.95M,
                        ShortDescription = "The most widely consumed alcohol",
                        LongDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://cdn.shopify.com/s/files/1/0066/2791/7914/products/13291.jpg?v=1560179923",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0066/2791/7914/products/13291_480x480.jpg?v=1588047064"
                    },
                    new Drink
                    {
                        Name = "Rum & Coke",
                        Price = 12.95M,
                        ShortDescription = "Cocktail made of cola, lime and rum.",
                        LongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://lh3.googleusercontent.com/proxy/IXB-tXWiLvsAYqDXrTjZlpRMoYeWlrp0MP7brTabmi4QUSJZ2fh4oDo1b6E70DwfuKcC0mh2INicz2tzXUZEL14zMzIfWdKKknmwGubviDjR4gCteutVb-T86U089poVefhw5gwAkQn1CZgBEI4",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcT87we5aaLIgcDLGRWhsOrbb1PTcyi0C3oeC0o1Kxqw9-oqLbAA&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Tequila ",
                        Price = 12.95M,
                        ShortDescription = "Beverage made from the blue agave plant.",
                        LongDescription = "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1584997500-eljimsil_1200x1200.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTmFcw9fCaqxyyMw7W2xUMB1F8pkaNqnM3lS2L1pPnb_HkF99gN&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Wine ",
                        Price = 16.75M,
                        ShortDescription = "A very elegant alcoholic drink",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://cdn.shopify.com/s/files/1/0025/1265/0352/products/lazo-cab_327286bb-43a0-4d04-b4a1-dd991c91e9aa_600x.png?v=1539000865",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRtYSX6cGNU461xnjgdRpm51rUPhNe2xRM96_wM8UIJfC2zptIK&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Margarita",
                        Price = 17.95M,
                        ShortDescription = "A cocktail with sec, tequila and lime",
                        Category = Categories["Alcoholic"],
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        ImageUrl = "https://assets.bonappetit.com/photos/5b69f16006027f654a27cd19/master/pass/ba-margarita-1.jpgs",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRtu_RdH7K1EahiwTVqneWhjQT9AQKC1x5Qlgm3hu7vm15LscQs&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Whiskey with Ice",
                        Price = 15.95M,
                        ShortDescription = "The best way to taste whiskey",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://previews.123rf.com/images/gresei/gresei1404/gresei140400062/27709569-glass-of-scotch-whiskey-and-ice-on-a-white-background.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRvHsmmQdMyOHSDHkcEM7_WxxhUvFk0_HXRF1mRHbkem1Y3rKu_&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Jägermeister",
                        Price = 15.95M,
                        ShortDescription = "A German digestif made with 56 herbs",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://d3r6kbofdnmd8.cloudfront.net/media/catalog/product/cache/image/1536x/a4e40ebdc3e371adff845072e1c73f37/9/9/99078_jaegermeister_1750.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS6-To94sSBDezo4q3NA9ZWkV109qH-BpZg5-qgzopthoGWn674&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Champagne",
                        Price = 15.95M,
                        ShortDescription = "That is how sparkling wine can be called",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://www.totalwine.com/dynamic/x490,sq/media/sys_master/twmmedia/hc2/h0b/12291720347678.png",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS3CpjCLreJOfd3LATIHX-m56Qg07W5LtVrjheCmnb_7xpq3n7N&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Piña colada ",
                        Price = 15.95M,
                        ShortDescription = "A sweet cocktail made with rum.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://hips.hearstapps.com/del.h-cdn.co/assets/16/17/1461680019-shot-1-187.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcROd3f2JWPEKB7eFBfEFqsjYtAzGQvpBXg-mzSa8zl5plxVYBmI&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "White Russian",
                        Price = 15.95M,
                        ShortDescription = "A cocktail made with vodka ",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://cdn.diffords.com/contrib/stock-images/2017/4/25/2017a6deb984f34e6171ba7e7c5c36b6df6c.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRGF1G9EnyLIzjGNKlju8eS8eMfdKGTipZk3Q6qE1fLG1ro4-8o&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Long Island Iced Tea",
                        Price = 15.95M,
                        ShortDescription = "Aa mixed drink made with tequila.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://www.supergoldenbakes.com/wordpress/wp-content/uploads/2019/07/Long_island_iced_tea-1-4s.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRxwzdfcN9fBK9dohXlzzhGl1-moPn8JT_H13-MymMQrQ8LFgSd&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Vodka",
                        Price = 15.95M,
                        ShortDescription = "A distilled beverage with water and ethanol.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://d3r6kbofdnmd8.cloudfront.net/media/catalog/product/cache/image/1536x/a4e40ebdc3e371adff845072e1c73f37/9/9/99033_absolut_1l_edo_3.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQ3fEPh_8ZqmFV7a70d0rzEWubilYx_VAUlw-mPfmseItAkrHze&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Gin and tonic",
                        Price = 15.95M,
                        ShortDescription = "Made with gin and tonic water poured over ice.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://www.thespruceeats.com/thmb/1ePl8zEkTLtgerd56-HJF8oqyO0=/668x668/smart/filters:no_upscale()/gin-tonic-5a8f334b8e1b6e0036a9631d.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRkpEBD9td1WHxFopIStw9qa16lTUvy7UCy_cZdrSSb_hys6pbi&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Cosmopolitan",
                        Price = 15.95M,
                        ShortDescription = "Made with vodka, triple sec, cranberry juice.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://mixthatdrink.com/wp-content/uploads/2009/05/cosmopolitan-cocktail-2-735x735.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSPriUQUlEY85u1XsCJp5mz30ze-5YVtWup8v4rZ51XlsTCXYYP&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Tea ",
                        Price = 12.95M,
                        ShortDescription = "Made by leaves of the tea plant in hot water.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://d2c7ipcroan06u.cloudfront.net/wp-content/uploads/2019/03/tea-696x392.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTJgDd3h_jZfYDPFlzAGCaU-GxLrjvZdqDZgW9wwuMuW1Y0vB6S&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Water ",
                        Price = 12.95M,
                        ShortDescription = " It makes up more than half of your body weight ",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://www.marcozanetti.info/wp-content/uploads/2019/03/water.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQX3pLaWZQU-8jw3AONt3Lxf5WPHFPbn-ezHMLhhVm0mf8cy9P3&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Coffee ",
                        Price = 12.95M,
                        ShortDescription = " A beverage prepared from coffee beans",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://lensdrop.imgix.net/photos/5g34q/stock-photo-5g34q.jpeg?mark=%2Fwm.png&markalign=center%2Cmiddle&markh=0.1&w=1200&h=650&s=a1d886c61d4c3318484f6c71647b462b",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR2ywuxx3oLZNofSO9NcQroH7h3fYM6VFfVTU5eclJidbQk-jNe&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Kvass",
                        Price = 12.95M,
                        ShortDescription = "A very refreshing Russian beverage",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://natashaskitchen.com/wp-content/uploads/2010/07/Russian-kvas-600x600.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS2UEiZwx7hMJcDpiS6a9IltGUF4Wv6niYUm_cGY_Nn1qeyME3m&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Juice ",
                        Price = 12.95M,
                        ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://res.klook.com/image/upload/c_fill,w_960,h_460,f_auto/w_80,x_15,y_15,g_south_west,l_klook_water/activities/akbvlx0q0jjlsa33wamt.webp",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQqOnEDOuWFkjhcJg2IuXTkUf9zYn2DfaYe6HOe51ERyBBX3-ms&usqp=CAU"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Alcoholic", Description="All alcoholic drinks" },
                        new Category { CategoryName = "Non-alcoholic", Description="All non-alcoholic drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}