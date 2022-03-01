using Microsoft.VisualStudio.TestTools.UnitTesting;
using PO_Projekt.Controllers;
using PO_Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Projekt.Controllers.Tests
{
    [TestClass()]
    public class ProductNamesControllerTests
    {
        IQueryable<ProductName> productNames;

        [TestInitialize]
        public void setUp()
        {
            productNames = new List<ProductName>() {
                new ProductName()
                {
                    Id = 1,
                    Name = "Xanax",
                    Price = 45.99,
                    RequiresPrescription = true,
                    Description = "Neurologia Psychiatria: nasenne przeciwlękowe przeciwdrgawkowe uspokajające zmniejsza napięcie mięśni",
                    ManufacturerId = 1,
                    ImageFilename = "xanax.jpg",
                    ProductFormId = 1,
                    ProductTypeId = 8
                },
                new ProductName()
                {
                    Id = 2,
                    Name = "Apap",
                    Price = 6.99,
                    RequiresPrescription = false,
                    Description = "Lek przeciwbólowy i przeciwgorączkowy, który jako substancję czynną zawiera paracetamol. Lek stosuje się w bólach różnego pochodzenia, zarówno głowy, zębów, mięśni jak i menstruacyjnych, kostno-stawowych czy nerwobólach.",
                    ManufacturerId = 3,
                    ImageFilename = "apap.jpg",
                    ProductFormId = 1,
                    ProductTypeId = 6
                },
                new ProductName()
                {
                    Id = 3,
                    Name = "Opaska elastyczna z zapinką",
                    Price = 3.99,
                    RequiresPrescription = false,
                    Description = "To wyrób medyczny, wielokrotnego użytku. Produkt może być stosowany jako opaska podtrzymująca opatrunki, uciskowa oraz usztywniająca okolice okołostawowe. Długość opaski po relaksacji wynosi nie mniej niż 1,5 m.",
                    ManufacturerId = 4,
                    ImageFilename = "opaska-elastyczna-tkana-z-zapinka.jpg",
                    ProductFormId = 7,
                    ProductTypeId = 1
                },
                new ProductName()
                {
                    Id = 4,
                    Name = "Ibuprom Max, 400 mg, tabletki drażowane, 48 szt. (butelka)",
                    Price = 26.49,
                    RequiresPrescription = false,
                    Description = "Ibuprom Max to lek przeciwbólowy, ale także stosuje się go w leczeniu stanu zapalnego. Lek również obniża gorączkę.",
                    ManufacturerId = 1,
                    ImageFilename = "",
                    ProductFormId = 1,
                    ProductTypeId = 8
                },
                new ProductName()
                {
                    Id = 5,
                    Name = "Ibuprom, 200 mg, tabletki powlekane, 10 szt.",
                    Price = 6.99,
                    RequiresPrescription = false,
                    Description = "Produkt leczniczy Ibuprom działa przeciwbólowo, przeciwzapalnie i przeciwgorączkowo. Stosuje się go w bólach głowy, zębów, mięśniowych, okolicy lędźwiowo-krzyżowej, kostnych i stawowych oraz w bolesnym miesiączkowaniu oraz w gorączce.",
                    ManufacturerId = 2,
                    ImageFilename = "",
                    ProductFormId = 1,
                    ProductTypeId = 8
                },
                new ProductName()
                {
                    Id = 6,
                    Name = "Plaster z opatrunkiem, tkaninowy, 1 m x 6 cm, 1 szt.",
                    Price = 5.99,
                    RequiresPrescription = false,
                    Description = "To wyrób medyczny, z opatrunkiem do cięcia, który chroni przed zarazkami i zabrudzeniem. Utrzymuje skórę w czystości, nie powoduje uczuleń i nie przywiera do rany. Rozmiar: 1 m x 6 cm.",
                    ManufacturerId = 3,
                    ImageFilename = "plastry.png",
                    ProductFormId = 2,
                    ProductTypeId = 9
                },
                new ProductName()
                {
                    Id = 7,
                    Name = "Pikabu Baby Care, kremowy szampon i płyn do kąpieli, 300 ml",
                    Price = 24.99,
                    RequiresPrescription = false,
                    Description = "Kremowy szampon i płyn do kąpieli – w łagodny sposób myje oraz pielęgnuje skórę i włosy dziecka. Kosmetyk może być stosowany już od pierwszego dnia życia maluszka. Szampon w swoim składzie zawiera między innymi: bisabolol, który łagodzi podrażnienia.",
                    ManufacturerId = 4,
                    ImageFilename = "baby_care.png",
                    ProductFormId = 8,
                    ProductTypeId = 7
                },
                new ProductName()
                {
                    Id = 8,
                    Name = "Fervex Junior, granulat bez cukru, 8 saszetek",
                    Price = 19.19,
                    RequiresPrescription = false,
                    Description = "Fervex Junior to lek w postaci granulatu do sporządzania roztworu doustnego dla dzieci od 6 roku życia. Ma działanie przeciwbólowe i przeciwgorączkowe, udrażnia przewody nosowe, hamuje odruch kichania i łzawienie oczu, uzupełnia niedobory witaminy C.",
                    ManufacturerId = 1,
                    ImageFilename = "fervex.png",
                    ProductFormId = 3,
                    ProductTypeId = 6
                },
                new ProductName()
                {
                    Id = 9,
                    Name = "Sumatriptan Medical Valley, 50 mg, tabletki, 6 szt.",
                    Price = 25.59,
                    RequiresPrescription = true,
                    Description = "Doustnie. Dawkę i częstotliwość przyjmowania preparatu ustala lekarz. Lek należy przyjąć jak najszybciej po wystąpieniu objawów migreny. Jeśli ból nie ustąpił dawkę można powtórzyć po upływie 2 godzin. Tabletki należy połykać w całości, popijając wodą.",
                    ManufacturerId = 3,
                    ImageFilename = "",
                    ProductFormId = 1,
                    ProductTypeId = 8
                },
                new ProductName()
                {
                    Id = 10,
                    Name = "Cital, 20 mg, tabletki powlekane, 60 szt.",
                    Price = 36.99,
                    RequiresPrescription = true,
                    Description = "",
                    ManufacturerId = 4,
                    ImageFilename = "",
                    ProductFormId = 1,
                    ProductTypeId = 8
                },
                new ProductName()
                {
                    Id = 11,
                    Name = "JuniorMag, płyn, smak truskawkowy, 120 ml",
                    Price = 13.99,
                    RequiresPrescription = false,
                    Description = "suplement diety w formie płynu, który uzupełnia codzienną dietę w magnez i witaminę B6. Produkt przeznaczony dla dzieci od 3 roku życia i osób dorosłych.",
                    ManufacturerId = 3,
                    ImageFilename = "syrop.png",
                    ProductFormId = 4,
                    ProductTypeId = 3
                },
                new ProductName()
                {
                    Id = 12,
                    Name = "InVag, kapsułki twarde, dopochwowe, 7 szt.",
                    Price = 34.99,
                    RequiresPrescription = true,
                    Description = "InVag to produkt leczniczy zawierający bakterie kwasy mlekowego, które przywracają równowagę pH pochwy do stosowania w zaburzeń mikroflory spowodowanej m.in. stosowaniem antybiotyków czy zmianami hormonalnymi.",
                    ManufacturerId = 2,
                    ImageFilename = "p_antybiotyk.png",
                    ProductFormId = 1,
                    ProductTypeId = 5
                },
                new ProductName()
                {
                    Id = 13,
                    Name = "Tribiotic",
                    Price = 16.59,
                    RequiresPrescription = true,
                    Description = "Tribiotic to produkt leczniczy zawierający 3 antybiotyki, które wykazują działanie przeciwbakteryjne. Lek do stosowania w przypadku zadrapań, ran, oparzeń.",
                    ManufacturerId = 4,
                    ImageFilename = "m_antybiotyk.png",
                    ProductFormId = 6,
                    ProductTypeId = 5
                },
                new ProductName()
                {
                    Id = 14,
                    Name = "Polibiotic, (5 mg+5000 j.m.+400 j.m.g), maść, 15 g (tuba)",
                    Price = 11.89,
                    RequiresPrescription = true,
                    Description = "Polibiotic to produkt leczniczy zawierający 3 antybiotyki działające w przypadku zakażeń skórnych, maść do stosowania w przypadku ran, owrzodzeń i oparzeń.",
                    ManufacturerId = 1,
                    ImageFilename = "m_antybiotyk_2.png",
                    ProductFormId = 6,
                    ProductTypeId = 5
                },
                new ProductName()
                {
                    Id = 15,
                    Name = "Witamina C 1000 mg Forte, tabletki do ssania, smak pomarańczowy, 60 szt.",
                    Price = 14.99,
                    RequiresPrescription = false,
                    Description = "suplement diety wspomagający układ odpornościowy. Produkt przeznaczony dla osób dorosłych.",
                    ManufacturerId = 2,
                    ImageFilename = "witamina_c.png",
                    ProductFormId = 1,
                    ProductTypeId = 3
                }
            }.AsQueryable();
        }

        [TestMethod()]
        public void TestFilters()
        {
            IQueryable <ProductName> filtered1 = ProductNamesController.getFilteredList(productNames, null, null, null, null, null);
            IQueryable <ProductName> filtered2 = ProductNamesController.getFilteredList(productNames, null, null, null, null, "false");
            CollectionAssert.AreEqual(filtered1.ToList(), filtered2.ToList());
        }


        [TestMethod()]
        public void TestFiltersPrescription()
        {
            IQueryable<ProductName> filtered1 = ProductNamesController.getFilteredList(productNames, null, null, null, null, null);
            Assert.IsFalse(filtered1.Select(item => item.RequiresPrescription).Aggregate(false, (prod, next) => prod || next));

            IQueryable<ProductName> filtered3 = ProductNamesController.getFilteredList(productNames, null, null, null, null, "true");
            Assert.IsTrue(filtered3.Select(item => item.RequiresPrescription).Aggregate(true, (prod, next) => prod && next));
        }

        [TestMethod()]
        public void TestFiltersSearch()
        {
            IQueryable<ProductName> filtered1 = ProductNamesController.getFilteredList(productNames, null, null, null, "ibuprom", null);
            CollectionAssert.AreEqual(filtered1.Select(item => item.Name).ToList(), 
                new List<String>() { "Ibuprom Max, 400 mg, tabletki drażowane, 48 szt. (butelka)", "Ibuprom, 200 mg, tabletki powlekane, 10 szt." });
        }

        [TestMethod()]
        public void TestFiltersProductType()
        {
            IQueryable<ProductName> filtered1 = ProductNamesController.getFilteredList(productNames, 0, null, null, null, null);
            Assert.IsTrue(filtered1.Select(item => item.ProductTypeId == 0).Aggregate(true, (prev, next) => prev && next));
        }

        [TestMethod()]
        public void TestSorters()
        {
            IQueryable<ProductName> sortedDefault = ProductNamesController.getSortedList(productNames, null);
            IQueryable<ProductName> sortedPriceDown = ProductNamesController.getSortedList(productNames, 0);
            IQueryable<ProductName> sortedPriceUp = ProductNamesController.getSortedList(productNames, 1);

            CollectionAssert.AreEqual(sortedPriceUp.Select(item => item.Price).ToList(), 
                new List<double>() { 3.99, 5.99, 6.99, 6.99, 11.89, 13.99, 14.99, 16.59, 19.19, 24.99, 25.59, 26.49, 34.99, 36.99, 45.99 });

            CollectionAssert.AreEqual(sortedPriceDown.Select(item => item.Price).ToList(),
                new List<double>() { 45.99, 36.99, 34.99, 26.49, 25.59, 24.99, 19.19, 16.59, 14.99, 13.99, 11.89, 6.99, 6.99, 5.99, 3.99 });
        }
    }
}