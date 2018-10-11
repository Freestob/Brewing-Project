using Brewer.Domain.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewer.Data
{
    class BrewerInitializer : DropCreateDatabaseIfModelChanges<BrewerContext>
    {
        protected override void Seed(BrewerContext context)
        {

            context.Grains.Add(new Grain()
            {
                Id = 1,
                Name = "Acid Malt",
                Origin = "Germany",
                Type = "Grain",
                Color = 3.0,
                Potential = 1.027,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 2,
                Name = "Amber Dry Extract",
                Origin = "United States",
                Type = "Dry Extract",
                Color = 12.5,
                Potential = 1.044,
                Max = 100.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 3,
                Name = "Amber Liquid Extract",
                Origin = "United States",
                Type = "Extract",
                Color = 12.5,
                Potential = 1.036,
                Max = 100.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 4,
                Name = "Amber Malt",
                Origin = "United Kingdom",
                Type = "Grain",
                Color = 22.0,
                Potential = 1.035,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 5,
                Name = "Aromatic Malt",
                Origin = "Belgium",
                Type = "Grain",
                Color = 26.0,
                Potential = 1.036,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 6,
                Name = "Barley Hulls",
                Origin = "United States",
                Type = "Ajunct",
                Color = 0.0,
                Potential = 1.000,
                Max = 5.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 7,
                Name = "Barley, Flaked",
                Origin = "United States",
                Type = "Grain",
                Color = 1.7,
                Potential = 1.032,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 8,
                Name = "Barley, Raw",
                Origin = "United States",
                Type = "Grain",
                Color = 2.0,
                Potential = 1.028,
                Max = 15.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 9,
                Name = "Barley Torrefied",
                Origin = "United States",
                Type = "Grain",
                Color = 1.7,
                Potential = 1.036,
                Max = 40.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 10,
                Name = "Biscuit Malt",
                Origin = "Belgian",
                Type = "Grain",
                Color = 23.0,
                Potential = 1.036,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 11,
                Name = "Black (Patent) Malt",
                Origin = "United States",
                Type = "Grain",
                Color = 500.0,
                Potential = 1.025,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 12,
                Name = "Black Barley (Stout)",
                Origin = "United States",
                Type = "Grain",
                Color = 500.0,
                Potential = 1.025,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 13,
                Name = "Brown Malt",
                Origin = "United Kingdom",
                Type = "Grain",
                Color = 65.0,
                Potential = 1.032,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 14,
                Name = "Brown Sugar, Dark",
                Origin = "United States",
                Type = "Sugar",
                Color = 50.0,
                Potential = 1.046,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 15,
                Name = "Brown Sugar, Light",
                Origin = "United States",
                Type = "Sugar",
                Color = 8.0,
                Potential = 1.046,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 16,
                Name = "Brumalt",
                Origin = "Germany",
                Type = "Grain",
                Color = 23.0,
                Potential = 1.033,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 17,
                Name = "Candi Sugar,Amber",
                Origin = "Belgium",
                Type = "Sugar",
                Color = 75.0,
                Potential = 1.036,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 18,
                Name = "Candi Sugar, Clear",
                Origin = "Belgium",
                Type = "Sugar",
                Color = 0.5,
                Potential = 1.036,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 19,
                Name = "Candi Sugar, Dark",
                Origin = "Belgium",
                Type = "Sugar",
                Color = 275.0,
                Potential = 1.036,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 20,
                Name = "Cane (Beet) Sugar",
                Origin = "United States",
                Type = "Sugar",
                Color = 0.0,
                Potential = 1.046,
                Max = 7.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 21,
                Name = "Cara-Pils/Dextrine",
                Origin = "United States",
                Type = "Grain",
                Color = 2.0,
                Potential = 1.033,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 22,
                Name = "Caraamber",
                Origin = "United States",
                Type = "Grain",
                Color = 30.0,
                Potential = 1.035,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 23,
                Name = "Caraaroma",
                Origin = "Germany",
                Type = "Grain",
                Color = 130.0,
                Potential = 1.035,
                Max = 15.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 24,
                Name = "Carafa I",
                Origin = "Germany",
                Type = "Grain",
                Color = 337.0,
                Potential = 1.032,
                Max = 5.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 25,
                Name = "Carafa II",
                Origin = "Germany",
                Type = "Grain",
                Color = 412.0,
                Potential = 1.032,
                Max = 5.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 26,
                Name = "Carafa III",
                Origin = "Germany",
                Type = "Grain",
                Color = 525.0,
                Potential = 1.032,
                Max = 5.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 27,
                Name = "Carafoam",
                Origin = "United States",
                Type = "Grain",
                Color = 2.0,
                Potential = 1.033,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 28,
                Name = "Caramel Wheat Malt",
                Origin = "Germany",
                Type = "Grain",
                Color = 46.0,
                Potential = 1.035,
                Max = 15.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 29,
                Name = "Caramel/Crystal Malt - 10L",
                Origin = "United States",
                Type = "Grain",
                Color = 10.0,
                Potential = 1.035,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 30,
                Name = "Caramel/Crystal Malt - 20L",
                Origin = "United States",
                Type = "Grain",
                Color = 20.0,
                Potential = 1.035,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 31,
                Name = "Caramel/Crystal Malt - 30L",
                Origin = "United States",
                Type = "Grain",
                Color = 30.0,
                Potential = 1.035,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 32,
                Name = "Caramel/Crystal Malt - 40L",
                Origin = "United States",
                Type = "Grain",
                Color = 40.0,
                Potential = 1.034,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 33,
                Name = "Caramel/Crystal Malt - 60L",
                Origin = "United States",
                Type = "Grain",
                Color = 60.0,
                Potential = 1.034,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 34,
                Name = "Caramel/Crystal Malt - 80L",
                Origin = "United States",
                Type = "Grain",
                Color = 80.0,
                Potential = 1.034,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 35,
                Name = "Caramel/Crystal Malt - 120L",
                Origin = "United States",
                Type = "Grain",
                Color = 120.0,
                Potential = 1.033,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 36,
                Name = "Caramunich Malt",
                Origin = "Belgium",
                Type = "Grain",
                Color = 56.0,
                Potential = 1.033,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 37,
                Name = "Carared",
                Origin = "United States",
                Type = "Grain",
                Color = 20.0,
                Potential = 1.035,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 38,
                Name = "Caravienne Malt",
                Origin = "Belgium",
                Type = "Grain",
                Color = 22.0,
                Potential = 1.034,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 39,
                Name = "Chocolate Malt",
                Origin = "United States",
                Type = "Grain",
                Color = 350.0,
                Potential = 1.028,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 40,
                Name = "Chocolate Malt",
                Origin = "United Kingdom",
                Type = "Grain",
                Color = 450.0,
                Potential = 1.034,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 41,
                Name = "Chocolate Rye Malt",
                Origin = "Germany",
                Type = "Grain",
                Color = 250.0,
                Potential = 1.031,
                Max = 5.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 42,
                Name = "Chocolate Wheat Malt",
                Origin = "Germany",
                Type = "Grain",
                Color = 400.0,
                Potential = 1.033,
                Max = 5.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 43,
                Name = "Corn Sugar (Dextrose)",
                Origin = "United States",
                Type = "Sugar",
                Color = 0.0,
                Potential = 1.046,
                Max = 5.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 44,
                Name = "Corn Syrup",
                Origin = "United States",
                Type = "Sugar",
                Color = 1.0,
                Potential = 1.036,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 45,
                Name = "Corn, Flaked",
                Origin = "United States",
                Type = "Grain",
                Color = 1.3,
                Potential = 1.037,
                Max = 40.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 46,
                Name = "Dark Dry Extract",
                Origin = "United States",
                Type = "Dry Extract",
                Color = 17.5,
                Potential = 1.044,
                Max = 100.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 47,
                Name = "Dark Liquid Extract",
                Origin = "United States",
                Type = "Extract",
                Color = 17.5,
                Potential = 1.036,
                Max = 100.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 48,
                Name = "Dememera Sugar",
                Origin = "United Kingdom",
                Type = "Sugar",
                Color = 2.0,
                Potential = 1.046,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 49,
                Name = "Extra Light Dry Extract",
                Origin = "United States",
                Type = "Dry Extract",
                Color = 3.0,
                Potential = 1.044,
                Max = 100.0,
                Inventory = 0,
                Price = 3.04
            });
        }
    }
}
