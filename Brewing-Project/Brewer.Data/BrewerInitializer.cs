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
            context.Grains.Add(new Grain()
            {
                Id = 50,
                Name = "Grits",
                Origin = "United States",
                Type = "Adjunct",
                Color = 1.0,
                Potential = 1.037,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 51,
                Name = "Honey",
                Origin = "United States",
                Type = "Sugar",
                Color = 1.0,
                Potential = 1.035,
                Max = 100.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 52,
                Name = "Honey Malt",
                Origin = "Canada",
                Type = "Grain",
                Color = 25.0,
                Potential = 1.037,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 53,
                Name = "Invert Sugar",
                Origin = "United Kingdom",
                Type = "Sugar",
                Color = 0.0,
                Potential = 1.046,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 54,
                Name = "Lager Malt",
                Origin = "",
                Type = "Grain",
                Color = 2.0,
                Potential = 1.038,
                Max = 100.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 55,
                Name = "Light Dry Extract",
                Origin = "United States",
                Type = "Dry Extract",
                Color = 8.0,
                Potential = 1.044,
                Max = 100.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 56,
                Name = "Lyle's Golden Syrup",
                Origin = "United Kingdom",
                Type = "Extract",
                Color = 0.0,
                Potential = 1.036,
                Max = 20.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 57,
                Name = "Maltodextrin",
                Origin = "United States",
                Type = "Sugar",
                Color = 3.0,
                Potential = 1.035,
                Max = 100.0,
                Inventory = 0,
                Price = 24.00
            });
            context.Grains.Add(new Grain()
            {
                Id = 58,
                Name = "Maple Syrup",
                Origin = "United States",
                Type = "Sugar",
                Color = 35.0,
                Potential = 1.030,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 59,
                Name = "Melanoiden Malt",
                Origin = "Germany",
                Type = "Grain",
                Color = 4.0,
                Potential = 1.037,
                Max = 100.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 60,
                Name = "Mild Malt",
                Origin = "United Kingdom",
                Type = "Grain",
                Color = 4.0,
                Potential = 1.037,
                Max = 100.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 61,
                Name = "Milk Sugar (Lactose)",
                Origin = "United States",
                Type = "Sugar",
                Color = 0.0,
                Potential = 1.035,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 62,
                Name = "Molasses",
                Origin = "United States",
                Type = "Sugar",
                Color = 80.0,
                Potential = 1.036,
                Max = 5.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 63,
                Name = "Munic Malt",
                Origin = "Germany",
                Type = "Grain",
                Color = 9.0,
                Potential = 1.037,
                Max = 80.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 64,
                Name = "Munic Malt - 10L",
                Origin = "United States",
                Type = "Sugar",
                Color = 10.0,
                Potential = 1.035,
                Max = 80.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 65,
                Name = "Munic Malt - 20L",
                Origin = "United States",
                Type = "Grain",
                Color = 20,
                Potential = 1.035,
                Max = 80.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 66,
                Name = "Oats, Flaked",
                Origin = "United States",
                Type = "Grain",
                Color = 1.0,
                Potential = 1.037,
                Max = 30.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 67,
                Name = "Oats, Malted",
                Origin = "United States",
                Type = "Extract",
                Color = 1.0,
                Potential = 1.037,
                Max = 10.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 68,
                Name = "Pale Liquid Extract",
                Origin = "United States",
                Type = "Extract",
                Color = 8.0,
                Potential = 1.036,
                Max = 100.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 69,
                Name = "Pale Malt (2 Row) Bel",
                Origin = "Belgium",
                Type = "Grain",
                Color = 3.0,
                Potential = 1.037,
                Max = 100.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 70,
                Name = "Pale Malt (2 Row) UK",
                Origin = "United Kingdom",
                Type = "Grain",
                Color = 3.0,
                Potential = 1.036,
                Max = 100.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 71,
                Name = "Pale Malt (2 Row) US",
                Origin = "United States",
                Type = "Grain",
                Color = 2.0,
                Potential = 1.036,
                Max = 100.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 72,
                Name = "Pale Malt (6 Row) US",
                Origin = "United States",
                Type = "Grain",
                Color = 2.0,
                Potential = 1.035,
                Max = 100.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 73,
                Name = "Pale Malt, Maris Otter",
                Origin = "United Kingdom",
                Type = "Grain",
                Color = 3.0,
                Potential = 1.038,
                Max = 5.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 74,
                Name = "Peat Smoked Malt",
                Origin = "United Kingdom",
                Type = "Grain",
                Color = 2.8,
                Potential = 1.034,
                Max = 20.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 75,
                Name = "Pilsner (2 Row) Bel",
                Origin = "Belgium",
                Type = "Grain",
                Color = 2.0,
                Potential = 1.036,
                Max = 100.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 76,
                Name = "Pilsner (2 Row) Ger",
                Origin = "Germany",
                Type = "Grain",
                Color = 2.0,
                Potential = 1.037,
                Max = 100.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 77,
                Name = "Pilsner (2 Row) UK",
                Origin = "United Kingdom",
                Type = "Grain",
                Color = 1.0,
                Potential = 1.036,
                Max = 100.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 78,
                Name = "Pilsner Liquid Extract",
                Origin = "United States",
                Type = "Extract",
                Color = 3.5,
                Potential = 1.036,
                Max = 100.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 79,
                Name = "Rice Extract Syrup",
                Origin = "United States",
                Type = "Extract",
                Color = 7.0,
                Potential = 1.032,
                Max = 15.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 80,
                Name = "Rice Hulls",
                Origin = "United States",
                Type = "Adjunct",
                Color = 0.0,
                Potential = 1.000,
                Max = 5.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 81,
                Name = "Rice, Flaked",
                Origin = "United States",
                Type = "Grain",
                Color = 1.0,
                Potential = 1.032,
                Max = 25.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 82,
                Name = "Roasted Barley",
                Origin = "United States",
                Type = "Grain",
                Color = 300.0,
                Potential = 1.025,
                Max = 25.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 83,
                Name = "Rye Malt",
                Origin = "United States",
                Type = "Grain",
                Color = 4.7,
                Potential = 1.029,
                Max = 15.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 84,
                Name = "Rye, Flaked",
                Origin = "United States",
                Type = "Grain",
                Color = 2.0,
                Potential = 1.036,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 85,
                Name = "Smoked Malt",
                Origin = "Germany",
                Type = "Grain",
                Color = 9.0,
                Potential = 1.037,
                Max = 100.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 86,
                Name = "Special B Malt",
                Origin = "Belgium",
                Type = "Grain",
                Color = 180.0,
                Potential = 1.030,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 87,
                Name = "Special Roast",
                Origin = "United States",
                Type = "Grain",
                Color = 50.0,
                Potential = 1.033,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 88,
                Name = "Sugar, Table (Sucrose)",
                Origin = "United States",
                Type = "Sugar",
                Color = 1.0,
                Potential = 1.046,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 89,
                Name = "Toasted Malt",
                Origin = "United Kingdom",
                Type = "Grain",
                Color = 27.0,
                Potential = 1.033,
                Max = 10.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 90,
                Name = "Treacle",
                Origin = "United Kingdom",
                Type = "Extract",
                Color = 100.0,
                Potential = 1.036,
                Max = 15.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 91,
                Name = "Turbinado",
                Origin = "United Kingdom",
                Type = "Sugar",
                Color = 10.0,
                Potential = 1.044,
                Max = 10.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 92,
                Name = "Victory Malt",
                Origin = "United States",
                Type = "Grain",
                Color = 25.0,
                Potential = 1.034,
                Max = 15.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 93,
                Name = "Vienna Malt",
                Origin = "Germany",
                Type = "Grain",
                Color = 3.5,
                Potential = 1.036,
                Max = 90.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Grains.Add(new Grain()
            {
                Id = 94,
                Name = "Wheat Dry Extract",
                Origin = "United States",
                Type = "Dry Extract",
                Color = 8.0,
                Potential = 1.044,
                Max = 100.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 95,
                Name = "Wheat Liquid Extract",
                Origin = "United States",
                Type = "Extract",
                Color = 8.0,
                Potential = 1.036,
                Max = 100.0,
                Inventory = 0,
                Price = 3.04
            });
            context.Grains.Add(new Grain()
            {
                Id = 96,
                Name = "Wheat Malt, Bel",
                Origin = "Belgium",
                Type = "Grain",
                Color = 2.0,
                Potential = 1.037,
                Max = 60.0,
                Inventory = 0,
                Price = 1.28
            });
            context.Hops.Add(new Hop()
            {
                Id = 1,
                Name = "Admiral",
                Origin = "United Kingdom",
                Alpha = 14.75,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 2,
                Name = "Agnus",
                Origin = "Czech Republic",
                Alpha = 10.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 3,
                Name = "Ahtanum",
                Origin = "United States",
                Alpha = 6.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 4,
                Name = "Amarillo",
                Origin = "United States",
                Alpha = 9.20,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.19
            });
            context.Hops.Add(new Hop()
            {
                Id = 5,
                Name = "Amarillo Gold",
                Origin = "United States",
                Alpha = 8.50,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 6,
                Name = "Apollo",
                Origin = "United States",
                Alpha = 17.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.50
            });
            context.Hops.Add(new Hop()
            {
                Id = 7,
                Name = "Aquila",
                Origin = "United States",
                Alpha = 6.50,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 8,
                Name = "Aramis",
                Origin = "France",
                Alpha = 8.10,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 9,
                Name = "Atlas",
                Origin = "Slovenia",
                Alpha = 9.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 10,
                Name = "Atlas (Styrian Atlas)",
                Origin = "Slovenia",
                Alpha = 9.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 11,
                Name = "Aurora",
                Origin = "Slovenia",
                Alpha = 8.25,
                Type = "Both",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 12,
                Name = "Aurora (Super Styrian Aurora)",
                Origin = "Slovenia",
                Alpha = 8.00,
                Type = "Both",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 13,
                Name = "Azacca",
                Origin = "United States",
                Alpha = 15.00,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 14,
                Name = "Banner",
                Origin = "United States",
                Alpha = 10.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 15,
                Name = "Belma",
                Origin = "United States",
                Alpha = 10.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 16,
                Name = "Bitter Gold",
                Origin = "United States",
                Alpha = 9.80,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 17,
                Name = "Boadicea",
                Origin = "United Kingdom",
                Alpha = 8.50,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 18,
                Name = "Bobek",
                Origin = "Slovenia",
                Alpha = 5.25,
                Type = "Both",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 19,
                Name = "Bobek (Styrian Golding B)",
                Origin = "Slovenia",
                Alpha = 5.25,
                Type = "Both",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 20,
                Name = "Bramling Cross",
                Origin = "United Kingdom",
                Alpha = 6.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 21,
                Name = "Bravo",
                Origin = "United States",
                Alpha = 15.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 22,
                Name = "Brewer's Gold",
                Origin = "United States",
                Alpha = 8.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.59
            });
            context.Hops.Add(new Hop()
            {
                Id = 23,
                Name = "Brewer's Gold, Germany",
                Origin = "Germany",
                Alpha = 7.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 24,
                Name = "Brewer's Gold, UK",
                Origin = "United Kingdom",
                Alpha = 7.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 25,
                Name = "Brooklyn",
                Origin = "New Zealand",
                Alpha = 18.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 26,
                Name = "Bullion",
                Origin = "United States",
                Alpha = 7.50,
                Type = "Both",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 27,
                Name = "Bullion",
                Origin = "United Kingdom",
                Alpha = 8.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 28,
                Name = "Calypso",
                Origin = "United Kingdom",
                Alpha = 13.00,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 29,
                Name = "Cascade",
                Origin = "United States",
                Alpha = 5.50,
                Type = "Both",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 30,
                Name = "Cascade, New Zealand",
                Origin = "New Zealand",
                Alpha = 7.00,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 31,
                Name = "Cashmere",
                Origin = "United States",
                Alpha = 8.50,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 32,
                Name = "Celeia",
                Origin = "Slovenia",
                Alpha = 4.50,
                Type = "Both",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 33,
                Name = "Centennial",
                Origin = "United States",
                Alpha = 10.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 34,
                Name = "Callenger",
                Origin = "United Kingdom",
                Alpha = 7.50,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 35,
                Name = "Chelan",
                Origin = "United States",
                Alpha = 13.25,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 36,
                Name = "Chinook",
                Origin = "United States",
                Alpha = 13.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 37,
                Name = "Chinook, New Zealand",
                Origin = "New Zealand",
                Alpha = 12.10,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 38,
                Name = "Citra",
                Origin = "United States",
                Alpha = 12.00,
                Type = "Both",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 39,
                Name = "Cluster",
                Origin = "United States",
                Alpha = 7.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 40,
                Name = "Columbia",
                Origin = "United Kingdom",
                Alpha = 5.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 41,
                Name = "Columbus (Tomahawk)",
                Origin = "United States",
                Alpha = 14.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 42,
                Name = "Columbus/Tomahawk/Zeus (CTZ)",
                Origin = "United States",
                Alpha = 15.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.59
            });
            context.Hops.Add(new Hop()
            {
                Id = 43,
                Name = "Comet",
                Origin = "United States",
                Alpha = 9.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 44,
                Name = "Crystal",
                Origin = "United States",
                Alpha = 3.50,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 45,
                Name = "Delta",
                Origin = "United States",
                Alpha = 6.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 46,
                Name = "Dr. Rudi",
                Origin = "New Zealand",
                Alpha = 11.00,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 47,
                Name = "East Kent Goldings (EKG)",
                Origin = "United Kingdom",
                Alpha = 5.00,
                Type = "Both",
                Inventory = 0,
                Price = 1.99
            });
            context.Hops.Add(new Hop()
            {
                Id = 48,
                Name = "El Dorado",
                Origin = "United States",
                Alpha = 15.00,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 49,
                Name = "Ella (Stella)",
                Origin = "Australia",
                Alpha = 15.00,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 50,
                Name = "Equinoz (HBC 366)",
                Origin = "United States",
                Alpha = 15.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 51,
                Name = "Eroica",
                Origin = "United States",
                Alpha = 13.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 52,
                Name = "Eureka!",
                Origin = "United States",
                Alpha = 18.00,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 53,
                Name = "Falconer's Flight",
                Origin = "United States",
                Alpha = 11.00,
                Type = "Both",
                Inventory = 0,
                Price = 1.79
            });
            context.Hops.Add(new Hop()
            {
                Id = 54,
                Name = "Falconer's Flight 7C's Blend",
                Origin = "United States",
                Alpha = 9.50,
                Type = "Both",
                Inventory = 0,
                Price = 1.99
            });
            context.Hops.Add(new Hop()
            {
                Id = 55,
                Name = "Feux Coeur Francais",
                Origin = "Australia",
                Alpha = 14.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 56,
                Name = "First Gold",
                Origin = "United Kingdom",
                Alpha = 7.50,
                Type = "Both",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 57,
                Name = "Fuggle",
                Origin = "United Kingdom",
                Alpha = 4.50,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.09
            });
            context.Hops.Add(new Hop()
            {
                Id = 58,
                Name = "Fuggle, New Zealand",
                Origin = "New Zealand",
                Alpha = 6.10,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 59,
                Name = "Fuggle, Organic",
                Origin = "United Kingdom",
                Alpha = 4.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 60,
                Name = "Fuggle, United States",
                Origin = "United States",
                Alpha = 4.75,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 61,
                Name = "Fuggles",
                Origin = "United Kingdom",
                Alpha = 4.50,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 62,
                Name = "Galaxy",
                Origin = "Australia",
                Alpha = 14.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 63,
                Name = "Galena",
                Origin = "United States",
                Alpha = 12.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 64,
                Name = "German Tradition",
                Origin = "Germany",
                Alpha = 6.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.60
            });
            context.Hops.Add(new Hop()
            {
                Id = 65,
                Name = "Gesho Kitel",
                Origin = "Ethiopia",
                Alpha = 5.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.74
            });
            context.Hops.Add(new Hop()
            {
                Id = 66,
                Name = "Glacier",
                Origin = "United States",
                Alpha = 5.60,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 67,
                Name = "Golding, New Zealand",
                Origin = "New Zealand",
                Alpha = 4.20,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 68,
                Name = "Golding, United States",
                Origin = "United States",
                Alpha = 5.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 59,
                Name = "Golding, British Columbia",
                Origin = "Canada",
                Alpha = 5.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 60,
                Name = "Goldings, East Kent",
                Origin = "United Kingdom",
                Alpha = 5.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 61,
                Name = "Green Bullet",
                Origin = "New Zealand",
                Alpha = 13.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 62,
                Name = "Greenburg",
                Origin = "United States",
                Alpha = 5.20,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 63,
                Name = "HBC 291 (Experimental)",
                Origin = "United States",
                Alpha = 12.10,
                Type = "Bittering",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 64,
                Name = "HBC 342 (Experiemntal)",
                Origin = "United States",
                Alpha = 5.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 65,
                Name = "HBC 366 (Experiemntal)",
                Origin = "United States",
                Alpha = 15.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 66,
                Name = "Hallertau",
                Origin = "United States",
                Alpha = 4.50,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.79
            });
            context.Hops.Add(new Hop()
            {
                Id = 67,
                Name = "Hallertau Blanc",
                Origin = "Germany",
                Alpha = 10.50,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 68,
                Name = "Hallertau Magnum",
                Origin = "Germany",
                Alpha = 14.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.69
            });
            context.Hops.Add(new Hop()
            {
                Id = 69,
                Name = "Hallertau Taurus",
                Origin = "Germany",
                Alpha = 14.80,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 70,
                Name = "Hallertauer",
                Origin = "Germany",
                Alpha = 4.80,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 71,
                Name = "Hallertauer Hersbrucker",
                Origin = "Germany",
                Alpha = 4.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 72,
                Name = "Hallertauer Mittelfrueh",
                Origin = "Germany",
                Alpha = 4.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 73,
                Name = "Hallertauer, New Zealand",
                Origin = "New Zealand",
                Alpha = 8.50,
                Type = "Both",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 74,
                Name = "Harmonie",
                Origin = "Czech Republic",
                Alpha = 6.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 75,
                Name = "Helga (Southern Hallertaue)",
                Origin = "Australia",
                Alpha = 5.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 76,
                Name = "Herald",
                Origin = "United Kingdom",
                Alpha = 12.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 77,
                Name = "Herkules",
                Origin = "Germany",
                Alpha = 14.50,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.59
            });
            context.Hops.Add(new Hop()
            {
                Id = 68,
                Name = "Hersbrucker",
                Origin = "Germany",
                Alpha = 2.75,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.79
            });
            context.Hops.Add(new Hop()
            {
                Id = 69,
                Name = "HopShot",
                Origin = "",
                Alpha = 65.00,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 70,
                Name = "Horizon",
                Origin = "United States",
                Alpha = 12.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 71,
                Name = "Huell Melon",
                Origin = "Germany",
                Alpha = 7.20,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 72,
                Name = "Idaho #7",
                Origin = "United States",
                Alpha = 13.00,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 73,
                Name = "Jarrylo",
                Origin = "United States",
                Alpha = 11.00,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 74,
                Name = "Kohatu",
                Origin = "New Zealand",
                Alpha = 6.50,
                Type = "Aroma",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 75,
                Name = "Lemondrop",
                Origin = "United States",
                Alpha = 6.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 76,
                Name = "Libery",
                Origin = "United States",
                Alpha = 4.30,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 77,
                Name = "Liberty, New Zealand",
                Origin = "New Zealand",
                Alpha = 5.90,
                Type = "Both",
                Inventory = 0,
                Price = 2.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 78,
                Name = "Lublin",
                Origin = "Poland",
                Alpha = 5.00,
                Type = "Bittering",
                Inventory = 0,
                Price = 1.00
            });
            context.Hops.Add(new Hop()
            {
                Id = 79,
                Name = "Lublin (Lubelski)",
                Origin = "Poland",
                Alpha = 4.00,
                Type = "Aroma",
                Inventory = 0,
                Price = 1.00
            });


        }
    }
}
