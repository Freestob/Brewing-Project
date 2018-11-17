using Brewer.Domain.Models;
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
                Form = "Grain",
                Color = 3.0,
                Potential = 1.027,
            });
            context.Grains.Add(new Grain()
            {
                Id = 2,
                Name = "Amber Dry Extract",
                Origin = "United States",
                Form = "Dry Extract",
                Color = 12.5,
                Potential = 1.044,
            });
            context.Grains.Add(new Grain()
            {
                Id = 3,
                Name = "Amber Liquid Extract",
                Origin = "United States",
                Form = "Extract",
                Color = 12.5,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 4,
                Name = "Amber Malt",
                Origin = "United Kingdom",
                Form = "Grain",
                Color = 22.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 5,
                Name = "Aromatic Malt",
                Origin = "Belgium",
                Form = "Grain",
                Color = 26.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 6,
                Name = "Barley Hulls",
                Origin = "United States",
                Form = "Ajunct",
                Color = 0.0,
                Potential = 1.000,
            });
            context.Grains.Add(new Grain()
            {
                Id = 7,
                Name = "Barley, Flaked",
                Origin = "United States",
                Form = "Grain",
                Color = 1.7,
                Potential = 1.032,
            });
            context.Grains.Add(new Grain()
            {
                Id = 8,
                Name = "Barley, Raw",
                Origin = "United States",
                Form = "Grain",
                Color = 2.0,
                Potential = 1.028,
            });
            context.Grains.Add(new Grain()
            {
                Id = 9,
                Name = "Barley Torrefied",
                Origin = "United States",
                Form = "Grain",
                Color = 1.7,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 10,
                Name = "Biscuit Malt",
                Origin = "Belgian",
                Form = "Grain",
                Color = 23.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 11,
                Name = "Black (Patent) Malt",
                Origin = "United States",
                Form = "Grain",
                Color = 500.0,
                Potential = 1.025,
            });
            context.Grains.Add(new Grain()
            {
                Id = 12,
                Name = "Black Barley (Stout)",
                Origin = "United States",
                Form = "Grain",
                Color = 500.0,
                Potential = 1.025,
            });
            context.Grains.Add(new Grain()
            {
                Id = 13,
                Name = "Brown Malt",
                Origin = "United Kingdom",
                Form = "Grain",
                Color = 65.0,
                Potential = 1.032,
            });
            context.Grains.Add(new Grain()
            {
                Id = 14,
                Name = "Brown Sugar, Dark",
                Origin = "United States",
                Form = "Sugar",
                Color = 50.0,
                Potential = 1.046,
            });
            context.Grains.Add(new Grain()
            {
                Id = 15,
                Name = "Brown Sugar, Light",
                Origin = "United States",
                Form = "Sugar",
                Color = 8.0,
                Potential = 1.046,
            });
            context.Grains.Add(new Grain()
            {
                Id = 16,
                Name = "Brumalt",
                Origin = "Germany",
                Form = "Grain",
                Color = 23.0,
                Potential = 1.033,
            });
            context.Grains.Add(new Grain()
            {
                Id = 17,
                Name = "Candi Sugar,Amber",
                Origin = "Belgium",
                Form = "Sugar",
                Color = 75.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 18,
                Name = "Candi Sugar, Clear",
                Origin = "Belgium",
                Form = "Sugar",
                Color = 0.5,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 19,
                Name = "Candi Sugar, Dark",
                Origin = "Belgium",
                Form = "Sugar",
                Color = 275.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 20,
                Name = "Cane (Beet) Sugar",
                Origin = "United States",
                Form = "Sugar",
                Color = 0.0,
                Potential = 1.046,
            });
            context.Grains.Add(new Grain()
            {
                Id = 21,
                Name = "Cara-Pils/Dextrine",
                Origin = "United States",
                Form = "Grain",
                Color = 2.0,
                Potential = 1.033,
            });
            context.Grains.Add(new Grain()
            {
                Id = 22,
                Name = "Caraamber",
                Origin = "United States",
                Form = "Grain",
                Color = 30.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 23,
                Name = "Caraaroma",
                Origin = "Germany",
                Form = "Grain",
                Color = 130.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 24,
                Name = "Carafa I",
                Origin = "Germany",
                Form = "Grain",
                Color = 337.0,
                Potential = 1.032,
            });
            context.Grains.Add(new Grain()
            {
                Id = 25,
                Name = "Carafa II",
                Origin = "Germany",
                Form = "Grain",
                Color = 412.0,
                Potential = 1.032,
            });
            context.Grains.Add(new Grain()
            {
                Id = 26,
                Name = "Carafa III",
                Origin = "Germany",
                Form = "Grain",
                Color = 525.0,
                Potential = 1.032,
            });
            context.Grains.Add(new Grain()
            {
                Id = 27,
                Name = "Carafoam",
                Origin = "United States",
                Form = "Grain",
                Color = 2.0,
                Potential = 1.033,
            });
            context.Grains.Add(new Grain()
            {
                Id = 28,
                Name = "Caramel Wheat Malt",
                Origin = "Germany",
                Form = "Grain",
                Color = 46.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 29,
                Name = "Caramel/Crystal Malt - 10L",
                Origin = "United States",
                Form = "Grain",
                Color = 10.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 30,
                Name = "Caramel/Crystal Malt - 20L",
                Origin = "United States",
                Form = "Grain",
                Color = 20.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 31,
                Name = "Caramel/Crystal Malt - 30L",
                Origin = "United States",
                Form = "Grain",
                Color = 30.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 32,
                Name = "Caramel/Crystal Malt - 40L",
                Origin = "United States",
                Form = "Grain",
                Color = 40.0,
                Potential = 1.034,
            });
            context.Grains.Add(new Grain()
            {
                Id = 33,
                Name = "Caramel/Crystal Malt - 60L",
                Origin = "United States",
                Form = "Grain",
                Color = 60.0,
                Potential = 1.034,
            });
            context.Grains.Add(new Grain()
            {
                Id = 34,
                Name = "Caramel/Crystal Malt - 80L",
                Origin = "United States",
                Form = "Grain",
                Color = 80.0,
                Potential = 1.034,
            });
            context.Grains.Add(new Grain()
            {
                Id = 35,
                Name = "Caramel/Crystal Malt - 120L",
                Origin = "United States",
                Form = "Grain",
                Color = 120.0,
                Potential = 1.033,
            });
            context.Grains.Add(new Grain()
            {
                Id = 36,
                Name = "Caramunich Malt",
                Origin = "Belgium",
                Form = "Grain",
                Color = 56.0,
                Potential = 1.033,
            });
            context.Grains.Add(new Grain()
            {
                Id = 37,
                Name = "Carared",
                Origin = "United States",
                Form = "Grain",
                Color = 20.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 38,
                Name = "Caravienne Malt",
                Origin = "Belgium",
                Form = "Grain",
                Color = 22.0,
                Potential = 1.034,
            });
            context.Grains.Add(new Grain()
            {
                Id = 39,
                Name = "Chocolate Malt",
                Origin = "United States",
                Form = "Grain",
                Color = 350.0,
                Potential = 1.028,
            });
            context.Grains.Add(new Grain()
            {
                Id = 40,
                Name = "Chocolate Malt",
                Origin = "United Kingdom",
                Form = "Grain",
                Color = 450.0,
                Potential = 1.034,
            });
            context.Grains.Add(new Grain()
            {
                Id = 41,
                Name = "Chocolate Rye Malt",
                Origin = "Germany",
                Form = "Grain",
                Color = 250.0,
                Potential = 1.031,
            });
            context.Grains.Add(new Grain()
            {
                Id = 42,
                Name = "Chocolate Wheat Malt",
                Origin = "Germany",
                Form = "Grain",
                Color = 400.0,
                Potential = 1.033,
            });
            context.Grains.Add(new Grain()
            {
                Id = 43,
                Name = "Corn Sugar (Dextrose)",
                Origin = "United States",
                Form = "Sugar",
                Color = 0.0,
                Potential = 1.046,
            });
            context.Grains.Add(new Grain()
            {
                Id = 44,
                Name = "Corn Syrup",
                Origin = "United States",
                Form = "Sugar",
                Color = 1.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 45,
                Name = "Corn, Flaked",
                Origin = "United States",
                Form = "Grain",
                Color = 1.3,
                Potential = 1.037,
            });
            context.Grains.Add(new Grain()
            {
                Id = 46,
                Name = "Dark Dry Extract",
                Origin = "United States",
                Form = "Dry Extract",
                Color = 17.5,
                Potential = 1.044,
            });
            context.Grains.Add(new Grain()
            {
                Id = 47,
                Name = "Dark Liquid Extract",
                Origin = "United States",
                Form = "Extract",
                Color = 17.5,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 48,
                Name = "Dememera Sugar",
                Origin = "United Kingdom",
                Form = "Sugar",
                Color = 2.0,
                Potential = 1.046,
            });
            context.Grains.Add(new Grain()
            {
                Id = 49,
                Name = "Extra Light Dry Extract",
                Origin = "United States",
                Form = "Dry Extract",
                Color = 3.0,
                Potential = 1.044,
            });
            context.Grains.Add(new Grain()
            {
                Id = 50,
                Name = "Grits",
                Origin = "United States",
                Form = "Adjunct",
                Color = 1.0,
                Potential = 1.037,
            });
            context.Grains.Add(new Grain()
            {
                Id = 51,
                Name = "Honey",
                Origin = "United States",
                Form = "Sugar",
                Color = 1.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 52,
                Name = "Honey Malt",
                Origin = "Canada",
                Form = "Grain",
                Color = 25.0,
                Potential = 1.037,
            });
            context.Grains.Add(new Grain()
            {
                Id = 53,
                Name = "Invert Sugar",
                Origin = "United Kingdom",
                Form = "Sugar",
                Color = 0.0,
                Potential = 1.046,
            });
            context.Grains.Add(new Grain()
            {
                Id = 54,
                Name = "Lager Malt",
                Origin = "",
                Form = "Grain",
                Color = 2.0,
                Potential = 1.038,
            });
            context.Grains.Add(new Grain()
            {
                Id = 55,
                Name = "Light Dry Extract",
                Origin = "United States",
                Form = "Dry Extract",
                Color = 8.0,
                Potential = 1.044,
            });
            context.Grains.Add(new Grain()
            {
                Id = 56,
                Name = "Lyle's Golden Syrup",
                Origin = "United Kingdom",
                Form = "Extract",
                Color = 0.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 57,
                Name = "Maltodextrin",
                Origin = "United States",
                Form = "Sugar",
                Color = 3.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 58,
                Name = "Maple Syrup",
                Origin = "United States",
                Form = "Sugar",
                Color = 35.0,
                Potential = 1.030,
            });
            context.Grains.Add(new Grain()
            {
                Id = 59,
                Name = "Melanoiden Malt",
                Origin = "Germany",
                Form = "Grain",
                Color = 4.0,
                Potential = 1.037,
            });
            context.Grains.Add(new Grain()
            {
                Id = 60,
                Name = "Mild Malt",
                Origin = "United Kingdom",
                Form = "Grain",
                Color = 4.0,
                Potential = 1.037,
            });
            context.Grains.Add(new Grain()
            {
                Id = 61,
                Name = "Milk Sugar (Lactose)",
                Origin = "United States",
                Form = "Sugar",
                Color = 0.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 62,
                Name = "Molasses",
                Origin = "United States",
                Form = "Sugar",
                Color = 80.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 63,
                Name = "Munic Malt",
                Origin = "Germany",
                Form = "Grain",
                Color = 9.0,
                Potential = 1.037,
            });
            context.Grains.Add(new Grain()
            {
                Id = 64,
                Name = "Munic Malt - 10L",
                Origin = "United States",
                Form = "Sugar",
                Color = 10.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 65,
                Name = "Munic Malt - 20L",
                Origin = "United States",
                Form = "Grain",
                Color = 20,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 66,
                Name = "Oats, Flaked",
                Origin = "United States",
                Form = "Grain",
                Color = 1.0,
                Potential = 1.037,
            });
            context.Grains.Add(new Grain()
            {
                Id = 67,
                Name = "Oats, Malted",
                Origin = "United States",
                Form = "Extract",
                Color = 1.0,
                Potential = 1.037,
            });
            context.Grains.Add(new Grain()
            {
                Id = 68,
                Name = "Pale Liquid Extract",
                Origin = "United States",
                Form = "Extract",
                Color = 8.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 69,
                Name = "Pale Malt (2 Row) Bel",
                Origin = "Belgium",
                Form = "Grain",
                Color = 3.0,
                Potential = 1.037,
            });
            context.Grains.Add(new Grain()
            {
                Id = 70,
                Name = "Pale Malt (2 Row) UK",
                Origin = "United Kingdom",
                Form = "Grain",
                Color = 3.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 71,
                Name = "Pale Malt (2 Row) US",
                Origin = "United States",
                Form = "Grain",
                Color = 2.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 72,
                Name = "Pale Malt (6 Row) US",
                Origin = "United States",
                Form = "Grain",
                Color = 2.0,
                Potential = 1.035,
            });
            context.Grains.Add(new Grain()
            {
                Id = 73,
                Name = "Pale Malt, Maris Otter",
                Origin = "United Kingdom",
                Form = "Grain",
                Color = 3.0,
                Potential = 1.038,
            });
            context.Grains.Add(new Grain()
            {
                Id = 74,
                Name = "Peat Smoked Malt",
                Origin = "United Kingdom",
                Form = "Grain",
                Color = 2.8,
                Potential = 1.034,
            });
            context.Grains.Add(new Grain()
            {
                Id = 75,
                Name = "Pilsner (2 Row) Bel",
                Origin = "Belgium",
                Form = "Grain",
                Color = 2.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 76,
                Name = "Pilsner (2 Row) Ger",
                Origin = "Germany",
                Form = "Grain",
                Color = 2.0,
                Potential = 1.037,
            });
            context.Grains.Add(new Grain()
            {
                Id = 77,
                Name = "Pilsner (2 Row) UK",
                Origin = "United Kingdom",
                Form = "Grain",
                Color = 1.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 78,
                Name = "Pilsner Liquid Extract",
                Origin = "United States",
                Form = "Extract",
                Color = 3.5,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 79,
                Name = "Rice Extract Syrup",
                Origin = "United States",
                Form = "Extract",
                Color = 7.0,
                Potential = 1.032,
            });
            context.Grains.Add(new Grain()
            {
                Id = 80,
                Name = "Rice Hulls",
                Origin = "United States",
                Form = "Adjunct",
                Color = 0.0,
                Potential = 1.000,
            });
            context.Grains.Add(new Grain()
            {
                Id = 81,
                Name = "Rice, Flaked",
                Origin = "United States",
                Form = "Grain",
                Color = 1.0,
                Potential = 1.032,
            });
            context.Grains.Add(new Grain()
            {
                Id = 82,
                Name = "Roasted Barley",
                Origin = "United States",
                Form = "Grain",
                Color = 300.0,
                Potential = 1.025,
            });
            context.Grains.Add(new Grain()
            {
                Id = 83,
                Name = "Rye Malt",
                Origin = "United States",
                Form = "Grain",
                Color = 4.7,
                Potential = 1.029,
            });
            context.Grains.Add(new Grain()
            {
                Id = 84,
                Name = "Rye, Flaked",
                Origin = "United States",
                Form = "Grain",
                Color = 2.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 85,
                Name = "Smoked Malt",
                Origin = "Germany",
                Form = "Grain",
                Color = 9.0,
                Potential = 1.037,
            });
            context.Grains.Add(new Grain()
            {
                Id = 86,
                Name = "Special B Malt",
                Origin = "Belgium",
                Form = "Grain",
                Color = 180.0,
                Potential = 1.030,
            });
            context.Grains.Add(new Grain()
            {
                Id = 87,
                Name = "Special Roast",
                Origin = "United States",
                Form = "Grain",
                Color = 50.0,
                Potential = 1.033,
            });
            context.Grains.Add(new Grain()
            {
                Id = 88,
                Name = "Sugar, Table (Sucrose)",
                Origin = "United States",
                Form = "Sugar",
                Color = 1.0,
                Potential = 1.046,
            });
            context.Grains.Add(new Grain()
            {
                Id = 89,
                Name = "Toasted Malt",
                Origin = "United Kingdom",
                Form = "Grain",
                Color = 27.0,
                Potential = 1.033,
            });
            context.Grains.Add(new Grain()
            {
                Id = 90,
                Name = "Treacle",
                Origin = "United Kingdom",
                Form = "Extract",
                Color = 100.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 91,
                Name = "Turbinado",
                Origin = "United Kingdom",
                Form = "Sugar",
                Color = 10.0,
                Potential = 1.044,
            });
            context.Grains.Add(new Grain()
            {
                Id = 92,
                Name = "Victory Malt",
                Origin = "United States",
                Form = "Grain",
                Color = 25.0,
                Potential = 1.034,
            });
            context.Grains.Add(new Grain()
            {
                Id = 93,
                Name = "Vienna Malt",
                Origin = "Germany",
                Form = "Grain",
                Color = 3.5,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 94,
                Name = "Wheat Dry Extract",
                Origin = "United States",
                Form = "Dry Extract",
                Color = 8.0,
                Potential = 1.044,
            });
            context.Grains.Add(new Grain()
            {
                Id = 95,
                Name = "Wheat Liquid Extract",
                Origin = "United States",
                Form = "Extract",
                Color = 8.0,
                Potential = 1.036,
            });
            context.Grains.Add(new Grain()
            {
                Id = 96,
                Name = "Wheat Malt, Bel",
                Origin = "Belgium",
                Form = "Grain",
                Color = 2.0,
                Potential = 1.037,
            });
            context.Hops.Add(new Hop()
            {
                Id = 1,
                Name = "Admiral",
                Origin = "United Kingdom",
                Alpha = 14.75,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 2,
                Name = "Agnus",
                Origin = "Czech Republic",
                Alpha = 10.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 3,
                Name = "Ahtanum",
                Origin = "United States",
                Alpha = 6.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 4,
                Name = "Amarillo",
                Origin = "United States",
                Alpha = 9.20,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 5,
                Name = "Amarillo Gold",
                Origin = "United States",
                Alpha = 8.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 6,
                Name = "Apollo",
                Origin = "United States",
                Alpha = 17.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 7,
                Name = "Aquila",
                Origin = "United States",
                Alpha = 6.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 8,
                Name = "Aramis",
                Origin = "France",
                Alpha = 8.10,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 9,
                Name = "Atlas",
                Origin = "Slovenia",
                Alpha = 9.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 10,
                Name = "Atlas (Styrian Atlas)",
                Origin = "Slovenia",
                Alpha = 9.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 11,
                Name = "Aurora",
                Origin = "Slovenia",
                Alpha = 8.25,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 12,
                Name = "Aurora (Super Styrian Aurora)",
                Origin = "Slovenia",
                Alpha = 8.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 13,
                Name = "Azacca",
                Origin = "United States",
                Alpha = 15.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 14,
                Name = "Banner",
                Origin = "United States",
                Alpha = 10.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 15,
                Name = "Belma",
                Origin = "United States",
                Alpha = 10.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 16,
                Name = "Bitter Gold",
                Origin = "United States",
                Alpha = 9.80,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 17,
                Name = "Boadicea",
                Origin = "United Kingdom",
                Alpha = 8.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 18,
                Name = "Bobek",
                Origin = "Slovenia",
                Alpha = 5.25,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 19,
                Name = "Bobek (Styrian Golding B)",
                Origin = "Slovenia",
                Alpha = 5.25,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 20,
                Name = "Bramling Cross",
                Origin = "United Kingdom",
                Alpha = 6.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 21,
                Name = "Bravo",
                Origin = "United States",
                Alpha = 15.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 22,
                Name = "Brewer's Gold",
                Origin = "United States",
                Alpha = 8.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 23,
                Name = "Brewer's Gold, Germany",
                Origin = "Germany",
                Alpha = 7.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 24,
                Name = "Brewer's Gold, UK",
                Origin = "United Kingdom",
                Alpha = 7.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 25,
                Name = "Brooklyn",
                Origin = "New Zealand",
                Alpha = 18.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 26,
                Name = "Bullion",
                Origin = "United States",
                Alpha = 7.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 27,
                Name = "Bullion",
                Origin = "United Kingdom",
                Alpha = 8.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 28,
                Name = "Calypso",
                Origin = "United Kingdom",
                Alpha = 13.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 29,
                Name = "Cascade",
                Origin = "United States",
                Alpha = 5.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 30,
                Name = "Cascade, New Zealand",
                Origin = "New Zealand",
                Alpha = 7.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 31,
                Name = "Cashmere",
                Origin = "United States",
                Alpha = 8.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 32,
                Name = "Celeia",
                Origin = "Slovenia",
                Alpha = 4.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 33,
                Name = "Centennial",
                Origin = "United States",
                Alpha = 10.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 34,
                Name = "Callenger",
                Origin = "United Kingdom",
                Alpha = 7.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 35,
                Name = "Chelan",
                Origin = "United States",
                Alpha = 13.25,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 36,
                Name = "Chinook",
                Origin = "United States",
                Alpha = 13.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 37,
                Name = "Chinook, New Zealand",
                Origin = "New Zealand",
                Alpha = 12.10,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 38,
                Name = "Citra",
                Origin = "United States",
                Alpha = 12.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 39,
                Name = "Cluster",
                Origin = "United States",
                Alpha = 7.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 40,
                Name = "Columbia",
                Origin = "United Kingdom",
                Alpha = 5.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 41,
                Name = "Columbus (Tomahawk)",
                Origin = "United States",
                Alpha = 14.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 42,
                Name = "Columbus/Tomahawk/Zeus (CTZ)",
                Origin = "United States",
                Alpha = 15.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 43,
                Name = "Comet",
                Origin = "United States",
                Alpha = 9.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 44,
                Name = "Crystal",
                Origin = "United States",
                Alpha = 3.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 45,
                Name = "Delta",
                Origin = "United States",
                Alpha = 6.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 46,
                Name = "Dr. Rudi",
                Origin = "New Zealand",
                Alpha = 11.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 47,
                Name = "East Kent Goldings (EKG)",
                Origin = "United Kingdom",
                Alpha = 5.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 48,
                Name = "El Dorado",
                Origin = "United States",
                Alpha = 15.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 49,
                Name = "Ella (Stella)",
                Origin = "Australia",
                Alpha = 15.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 50,
                Name = "Equinoz (HBC 366)",
                Origin = "United States",
                Alpha = 15.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 51,
                Name = "Eroica",
                Origin = "United States",
                Alpha = 13.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 52,
                Name = "Eureka!",
                Origin = "United States",
                Alpha = 18.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 53,
                Name = "Falconer's Flight",
                Origin = "United States",
                Alpha = 11.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 54,
                Name = "Falconer's Flight 7C's Blend",
                Origin = "United States",
                Alpha = 9.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 55,
                Name = "Feux Coeur Francais",
                Origin = "Australia",
                Alpha = 14.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 56,
                Name = "First Gold",
                Origin = "United Kingdom",
                Alpha = 7.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 57,
                Name = "Fuggle",
                Origin = "United Kingdom",
                Alpha = 4.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 58,
                Name = "Fuggle, New Zealand",
                Origin = "New Zealand",
                Alpha = 6.10,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 59,
                Name = "Fuggle, Organic",
                Origin = "United Kingdom",
                Alpha = 4.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 60,
                Name = "Fuggle, United States",
                Origin = "United States",
                Alpha = 4.75,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 61,
                Name = "Fuggles",
                Origin = "United Kingdom",
                Alpha = 4.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 62,
                Name = "Galaxy",
                Origin = "Australia",
                Alpha = 14.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 63,
                Name = "Galena",
                Origin = "United States",
                Alpha = 12.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 64,
                Name = "German Tradition",
                Origin = "Germany",
                Alpha = 6.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 65,
                Name = "Gesho Kitel",
                Origin = "Ethiopia",
                Alpha = 5.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 66,
                Name = "Glacier",
                Origin = "United States",
                Alpha = 5.60,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 67,
                Name = "Golding, New Zealand",
                Origin = "New Zealand",
                Alpha = 4.20,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 68,
                Name = "Golding, United States",
                Origin = "United States",
                Alpha = 5.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 59,
                Name = "Golding, British Columbia",
                Origin = "Canada",
                Alpha = 5.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 60,
                Name = "Goldings, East Kent",
                Origin = "United Kingdom",
                Alpha = 5.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 61,
                Name = "Green Bullet",
                Origin = "New Zealand",
                Alpha = 13.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 62,
                Name = "Greenburg",
                Origin = "United States",
                Alpha = 5.20,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 63,
                Name = "HBC 291 (Experimental)",
                Origin = "United States",
                Alpha = 12.10,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 64,
                Name = "HBC 342 (Experiemntal)",
                Origin = "United States",
                Alpha = 5.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 65,
                Name = "HBC 366 (Experiemntal)",
                Origin = "United States",
                Alpha = 15.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 66,
                Name = "Hallertau",
                Origin = "United States",
                Alpha = 4.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 67,
                Name = "Hallertau Blanc",
                Origin = "Germany",
                Alpha = 10.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 68,
                Name = "Hallertau Magnum",
                Origin = "Germany",
                Alpha = 14.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 69,
                Name = "Hallertau Taurus",
                Origin = "Germany",
                Alpha = 14.80,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 70,
                Name = "Hallertauer",
                Origin = "Germany",
                Alpha = 4.80,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 71,
                Name = "Hallertauer Hersbrucker",
                Origin = "Germany",
                Alpha = 4.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 72,
                Name = "Hallertauer Mittelfrueh",
                Origin = "Germany",
                Alpha = 4.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 73,
                Name = "Hallertauer, New Zealand",
                Origin = "New Zealand",
                Alpha = 8.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 74,
                Name = "Harmonie",
                Origin = "Czech Republic",
                Alpha = 6.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 75,
                Name = "Helga (Southern Hallertaue)",
                Origin = "Australia",
                Alpha = 5.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 76,
                Name = "Herald",
                Origin = "United Kingdom",
                Alpha = 12.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 77,
                Name = "Herkules",
                Origin = "Germany",
                Alpha = 14.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 78,
                Name = "Hersbrucker",
                Origin = "Germany",
                Alpha = 2.75,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 79,
                Name = "HopShot",
                Origin = "",
                Alpha = 65.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 80,
                Name = "Horizon",
                Origin = "United States",
                Alpha = 12.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 81,
                Name = "Huell Melon",
                Origin = "Germany",
                Alpha = 7.20,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 82,
                Name = "Idaho #7",
                Origin = "United States",
                Alpha = 13.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 83,
                Name = "Jarrylo",
                Origin = "United States",
                Alpha = 11.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 84,
                Name = "Kohatu",
                Origin = "New Zealand",
                Alpha = 6.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 85,
                Name = "Lemondrop",
                Origin = "United States",
                Alpha = 6.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 86,
                Name = "Libery",
                Origin = "United States",
                Alpha = 4.30,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 87,
                Name = "Liberty, New Zealand",
                Origin = "New Zealand",
                Alpha = 5.90,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 88,
                Name = "Lublin",
                Origin = "Poland",
                Alpha = 5.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 89,
                Name = "Lublin (Lubelski)",
                Origin = "Poland",
                Alpha = 4.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 90,
                Name = "Magnum",
                Origin = "United States",
                Alpha = 12.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 91,
                Name = "Mandarina Bavaria",
                Origin = "Germany",
                Alpha = 8.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 92,
                Name = "Marynka",
                Origin = "Poland",
                Alpha = 10.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 93,
                Name = "Markur (Hallertauer Merkur)",
                Origin = "Germany",
                Alpha = 14.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 94,
                Name = "Millenium",
                Origin = "United States",
                Alpha = 14.25,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 95,
                Name = "Mosaic (HBC 369)",
                Origin = "United States",
                Alpha = 12.25,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 96,
                Name = "Motueka",
                Origin = "New Zealand",
                Alpha = 7.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 97,
                Name = "Mt. Hood",
                Origin = "United States",
                Alpha = 6.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 98,
                Name = "Mt. Rainer",
                Origin = "United States",
                Alpha = 7.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 99,
                Name = "Nelson Sauvin",
                Origin = "New Zealand",
                Alpha = 12.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 100,
                Name = "Newport",
                Origin = "United States",
                Alpha = 13.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 101,
                Name = "Northdown",
                Origin = "United Kingdom",
                Alpha = 8.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 102,
                Name = "Northern Brewer",
                Origin = "Germany",
                Alpha = 8.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 103,
                Name = "Nugget",
                Origin = "United States",
                Alpha = 13.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 104,
                Name = "Olympic",
                Origin = "United States",
                Alpha = 11.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 105,
                Name = "Opal",
                Origin = "Germany",
                Alpha = 6.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 106,
                Name = "Orion",
                Origin = "Germany",
                Alpha = 7.25,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 107,
                Name = "Pacific Gem",
                Origin = "New Zealand",
                Alpha = 15.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 108,
                Name = "Pacific Hallertau (Pacifica)",
                Origin = "New Zealand",
                Alpha = 5.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 109,
                Name = "Pacific Jade",
                Origin = "New Zealand",
                Alpha = 13.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 110,
                Name = "Palisade",
                Origin = "United States",
                Alpha = 7.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 111,
                Name = "Pekko",
                Origin = "United States",
                Alpha = 15.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 112,
                Name = "Perle",
                Origin = "Germany",
                Alpha = 8.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 113,
                Name = "Perle, United States",
                Origin = "United States",
                Alpha = 8.25,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 114,
                Name = "Phoenix",
                Origin = "United Kingdom",
                Alpha = 8.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 115,
                Name = "Pilgrim",
                Origin = "United Kingdom",
                Alpha = 11.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 116,
                Name = "Pilot",
                Origin = "United Kingdom",
                Alpha = 11.50,
                Purpose = "Bitter",
            });
            context.Hops.Add(new Hop()
            {
                Id = 117,
                Name = "Pioneer",
                Origin = "United Kingdom",
                Alpha = 9.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 118,
                Name = "Polaris",
                Origin = "Germany",
                Alpha = 21.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 119,
                Name = "Premiant",
                Origin = "Czech Republic",
                Alpha = 7.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 120,
                Name = "Pride of Ringwood",
                Origin = "Australia",
                Alpha = 9.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 121,
                Name = "Progress",
                Origin = "United Kingdom",
                Alpha = 6.25,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 122,
                Name = "Rakau (Alpharoma)",
                Origin = "New Zealand",
                Alpha = 10.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 123,
                Name = "Riwaka",
                Origin = "New Zealand",
                Alpha = 5.25,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 124,
                Name = "Rubin",
                Origin = "Czech Republic",
                Alpha = 12.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 125,
                Name = "Saaz",
                Origin = "United States",
                Alpha = 3.75,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 126,
                Name = "Santiam",
                Origin = "United States",
                Alpha = 6.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 127,
                Name = "Saphir",
                Origin = "Germany",
                Alpha = 3.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 128,
                Name = "Satus",
                Origin = "United States",
                Alpha = 13.25,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 129,
                Name = "Select Spalt",
                Origin = "Germany",
                Alpha = 4.75,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 130,
                Name = "Simcoe",
                Origin = "United States",
                Alpha = 13.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 131,
                Name = "Sladek",
                Origin = "Czech Republic",
                Alpha = 5.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 132,
                Name = "Smaragd (Emerald)",
                Origin = "Germany",
                Alpha = 5.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 133,
                Name = "Sonenet Golding",
                Origin = "United States",
                Alpha = 4.80,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 134,
                Name = "Sorachi Ace",
                Origin = "Japan",
                Alpha = 13.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 135,
                Name = "Southern Cross",
                Origin = "New Zealand",
                Alpha = 13.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 136,
                Name = "Sovereign",
                Origin = "United Kingdom",
                Alpha = 5.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 137,
                Name = "Spalt Spalter",
                Origin = "Germany",
                Alpha = 3.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 138,
                Name = "Spalter",
                Origin = "Germany",
                Alpha = 4.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 139,
                Name = "Spalter Select",
                Origin = "Germany",
                Alpha = 4.75,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 140,
                Name = "Sterling",
                Origin = "United States",
                Alpha = 7.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 141,
                Name = "Sticklebract",
                Origin = "New Zealand",
                Alpha = 13.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 142,
                Name = "Strisslespalt",
                Origin = "France",
                Alpha = 4.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 143,
                Name = "Styrian Aurora (Super Styrian)",
                Origin = "Austria",
                Alpha = 7.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 144,
                Name = "Styrian Bobek",
                Origin = "Austria",
                Alpha = 5.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 145,
                Name = "Styrian Celja",
                Origin = "Austria",
                Alpha = 4.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 146,
                Name = "Styrian Golding (Savinja Golding)",
                Origin = "Slovenia",
                Alpha = 5.25,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 147,
                Name = "Styrian Goldings",
                Origin = "Slovenia",
                Alpha = 5.40,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 148,
                Name = "Summer (Summer Saaz)",
                Origin = "Australia",
                Alpha = 5.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 149,
                Name = "Summit",
                Origin = "United States",
                Alpha = 17.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 150,
                Name = "Sun",
                Origin = "United States",
                Alpha = 14.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 151,
                Name = "Super Alpha",
                Origin = "New Zealand",
                Alpha = 13.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 152,
                Name = "Super Galena",
                Origin = "United States",
                Alpha = 14.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 153,
                Name = "Super Pride",
                Origin = "Australia",
                Alpha = 14.25,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 154,
                Name = "Sussex",
                Origin = "United Kingdom",
                Alpha = 5.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 155,
                Name = "Sylva",
                Origin = "Australia",
                Alpha = 5.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 156,
                Name = "Tahoma",
                Origin = "United States",
                Alpha = 7.80,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 157,
                Name = "Target",
                Origin = "United Kingdom",
                Alpha = 11.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 158,
                Name = "Tettnang",
                Origin = "Germany",
                Alpha = 4.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 159,
                Name = "Tettnang (Tettnang Tettnager)",
                Origin = "Germany",
                Alpha = 4.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 160,
                Name = "Tettnang, United States",
                Origin = "United States",
                Alpha = 4.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 161,
                Name = "Tillicum",
                Origin = "United States",
                Alpha = 13.25,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 162,
                Name = "Tomahawk",
                Origin = "United States",
                Alpha = 15.50,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 163,
                Name = "Topaz",
                Origin = "Australia",
                Alpha = 17.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 164,
                Name = "Tradition",
                Origin = "Germany",
                Alpha = 6.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 165,
                Name = "Triple Pearl",
                Origin = "United States",
                Alpha = 10.70,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 166,
                Name = "Triskel",
                Origin = "France",
                Alpha = 2.60,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 167,
                Name = "Tsingtao Flower",
                Origin = "China",
                Alpha = 7.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 168,
                Name = "Ultra",
                Origin = "United States",
                Alpha = 3.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 169,
                Name = "Vanguard",
                Origin = "United States",
                Alpha = 5.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 170,
                Name = "Vic Secret",
                Origin = "Australia",
                Alpha = 15.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 171,
                Name = "Victoria",
                Origin = "Australia",
                Alpha = 13.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 172,
                Name = "Wai-iti",
                Origin = "New Zealand",
                Alpha = 3.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 173,
                Name = "Waimea",
                Origin = "New Zealand",
                Alpha = 17.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 174,
                Name = "Wakatu (Hallertau Aroma)",
                Origin = "New Zealand",
                Alpha = 7.50,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 175,
                Name = "Warrior",
                Origin = "United States",
                Alpha = 15.00,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 176,
                Name = "Whitbread Golding Variety (WGV)",
                Origin = "United Kingdom",
                Alpha = 6.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 177,
                Name = "Willamette",
                Origin = "United States",
                Alpha = 5.50,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 178,
                Name = "Willamette, New Zealand",
                Origin = "New Zealand",
                Alpha = 5.00,
                Purpose = "Aroma",
            });
            context.Hops.Add(new Hop()
            {
                Id = 179,
                Name = "Wye Challenger",
                Origin = "New Zealand",
                Alpha = 8.90,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 180,
                Name = "Yakima Gold",
                Origin = "United States",
                Alpha = 9.60,
                Purpose = "Both",
            });
            context.Hops.Add(new Hop()
            {
                Id = 181,
                Name = "Zeus",
                Origin = "United States",
                Alpha = 14.00,
                Purpose = "Bittering",
            });
            context.Hops.Add(new Hop()
            {
                Id = 182,
                Name = "Zythos",
                Origin = "United States",
                Alpha = 10.90,
                Purpose = "Bittering",
            });
        }
    }
}
