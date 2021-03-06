﻿using System;
using System.Linq;
using System.Collections.Generic;
using SmartStore.Core.Domain.Catalog;

namespace SmartStore.Data.Setup
{
    public abstract partial class InvariantSeedData
    {
        public IList<Category> CategoriesFirstLevel()
        {
            var sampleImagesPath = this._sampleImagesPath;
            var categoryTemplateInGridAndLines = this.CategoryTemplates().Where(pt => pt.ViewPath == "CategoryTemplate.ProductsInGridOrLines").FirstOrDefault();

            #region category definitions

            var categoryFurniture = new Category
            {
                Name = "Furniture",
                Alias = "Furniture",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/furniture.jpg"),
                Published = true,
                DisplayOrder = 1,
                MetaTitle = "Furniture",
                ShowOnHomePage = true
            };

            var categoryApple = new Category
            {
                Name = "Apple",
                Alias = "Apple",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/apple.png"),
                Published = true,
                DisplayOrder = 1,
                MetaTitle = "Apple",
                ShowOnHomePage = true
            };

            var categorySports = new Category
            {
                Name = "Sports",
                Alias = "Sports",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/sports.jpg"),
                Published = true,
                DisplayOrder = 1,
                MetaTitle = "Sports",
                ShowOnHomePage = true
            };

            var categoryBooks = new Category
            {
                Name = "Books",
                Alias = "Books",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/emblem_library.png", GetSeName("Books")),
                Published = true,
                DisplayOrder = 1,
                MetaTitle = "Books"
            };

            //var categoryComputers = new Category
            //{
            //	Name = "Computers",
            //             Alias = "Computers",
            //	CategoryTemplateId = categoryTemplateInGridAndLines.Id,
            //             Picture = CreatePicture("category/computers.png"),
            //	Published = true,
            //	DisplayOrder = 2,
            //	MetaTitle = "Computers"
            //};

            var categoryFashion = new Category
            {
                Name = "Fashion",
                Alias = "Fashion",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/fashion.jpg"),
                Published = true,
                DisplayOrder = 2,
                MetaTitle = "Fashion",
                ShowOnHomePage = true,
                BadgeText = "SALE",
                BadgeStyle = 4
            };

            var categoryGaming = new Category
            {
                Name = "Gaming",
                Alias = "Gaming",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("product/ps4_bundle_minecraft.jpg", GetSeName("Gaming")),
                Published = true,
                DisplayOrder = 3,
                ShowOnHomePage = true,
                MetaTitle = "Gaming"
            };

            //var categoryCellPhones = new Category
            //{
            //	Name = "Cell phones",
            //             Alias = "Cell phones",
            //	CategoryTemplateId = categoryTemplateInGridAndLines.Id,
            //	//ParentCategoryId = categoryElectronics.Id,
            //             Picture = CreatePicture("category/cellphone.png"),
            //	Published = true,
            //	DisplayOrder = 4,
            //	MetaTitle = "Cell phones"
            //};

            var categoryDigitalDownloads = new Category
            {
                Name = "Digital Products",
                Alias = "Digital Products",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/digitalproducts.jpg"),
                Published = true,
                DisplayOrder = 6,
                MetaTitle = "Digital Products",
                ShowOnHomePage = true
            };

            var categoryGiftCards = new Category
            {
                Name = "Gift Cards",
                Alias = "Gift Cards",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/gift-cards.png"),
                Published = true,
                DisplayOrder = 12,
                MetaTitle = "Gift cards",
                ShowOnHomePage = true,
            };

            var categoryWatches = new Category
            {
                Name = "Watches",
                Alias = "Watches",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/watches.png"),
                Published = true,
                DisplayOrder = 10,
                MetaTitle = "Watches",
                ShowOnHomePage = true,
                BadgeText = "%",
                BadgeStyle = 5
            };

            #endregion

            var entities = new List<Category>
            {
                categoryApple, categorySports, categoryBooks, categoryFurniture, categoryDigitalDownloads, categoryGaming,
                categoryGiftCards, categoryFashion, categoryWatches
            };

            this.Alter(entities);
            return entities;
        }

        public IList<Category> CategoriesSecondLevel()
        {
            var sampleImagesPath = this._sampleImagesPath;
            var categoryTemplateInGridAndLines = this.CategoryTemplates().Where(pt => pt.ViewPath == "CategoryTemplate.ProductsInGridOrLines").FirstOrDefault();

            #region category definitions

            #region new

            var categoryFashionJackets = new Category
            {
                Name = "Jackets",
                Alias = "Jackets",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/jackets.jpg"),
                Published = true,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Fashion").First().Id,
                DisplayOrder = 1,
                MetaTitle = "Jackets",
                ShowOnHomePage = true
            };

            var categoryFashionLeatherJackets = new Category
            {
                Name = "Leather jackets",
                Alias = "Leather jackets",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/leather_jackets.jpg"),
                Published = true,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Fashion").First().Id,
                DisplayOrder = 1,
                MetaTitle = "Leather jackets",
                ShowOnHomePage = true
            };

            var categoryFashionShoes = new Category
            {
                Name = "Shoes",
                Alias = "Shoes",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/shoes.png"),
                Published = true,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Fashion").First().Id,
                DisplayOrder = 1,
                MetaTitle = "Shoes",
                ShowOnHomePage = true
            };

            var categoryFashionTrousers = new Category
            {
                Name = "Trousers",
                Alias = "Pants",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/trousers.png"),
                Published = true,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Fashion").First().Id,
                DisplayOrder = 1,
                MetaTitle = "Trousers",
                ShowOnHomePage = true
            };

            var categoryFashionTracksuits = new Category
            {
                Name = "Tracksuits",
                Alias = "Tracksuits",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/tracksuit.png"),
                Published = true,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Fashion").First().Id,
                DisplayOrder = 1,
                MetaTitle = "Tracksuits",
                ShowOnHomePage = true
            };

            #endregion



            var categorySportsGolf = new Category
            {
                Name = "Golf",
                Alias = "Golf",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/golf.jpg"),
                Published = true,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Sports").First().Id,
                DisplayOrder = 1,
                MetaTitle = "Golf",
                ShowOnHomePage = true
            };

            var categorySportsSunglasses = new Category
            {
                Name = "Sunglasses",
                Alias = "Sunglasses",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/glasses.png"),
                Published = true,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Fashion").First().Id,
                DisplayOrder = 1,
                MetaTitle = "Sunglasses",
                ShowOnHomePage = true
            };

            var categorySportsSoccer = new Category
            {
                Name = "Soccer",
                Alias = "Soccer",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/soccer.png"),
                Published = true,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Sports").First().Id,
                DisplayOrder = 1,
                MetaTitle = "Soccer",
                ShowOnHomePage = true
            };

            var categorySportsBasketball = new Category
            {
                Name = "Basketball",
                Alias = "Basketball",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/basketball.png"),
                Published = true,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Sports").First().Id,
                DisplayOrder = 1,
                MetaTitle = "Basketball",
                ShowOnHomePage = true
            };

            var categoryBooksSpiegel = new Category
            {
                Name = "SPIEGEL-Bestseller",
                Alias = "SPIEGEL-Bestseller",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/0000930_spiegel-bestseller.png", GetSeName("SPIEGEL-Bestseller")),
                Published = true,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Books").First().Id,
                DisplayOrder = 1,
                MetaTitle = "SPIEGEL-Bestseller"
            };

            var categoryBooksCookAndEnjoy = new Category
            {
                Name = "Cook and enjoy",
                Alias = "Cook and enjoy",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                MediaFile = CreatePicture("category/0000936_kochen-geniesen.jpeg", GetSeName("Cook and enjoy")),
                Published = true,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Books").First().Id,
                DisplayOrder = 2,
                MetaTitle = "Cook and enjoy"
            };

            //var categoryDesktops = new Category
            //{
            //	Name = "Desktops",
            //             Alias = "Desktops",
            //	CategoryTemplateId = categoryTemplateInGridAndLines.Id,
            //	ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Computers").First().Id,
            //	Picture = CreatePicture("category/desktops.png"),
            //	Published = true,
            //	DisplayOrder = 1,
            //	MetaTitle = "Desktops"
            //};

            //var categoryNotebooks = new Category
            //{
            //	Name = "Notebooks",
            //             Alias = "Notebooks",
            //	CategoryTemplateId = categoryTemplateInGridAndLines.Id,
            //	ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Computers").First().Id,
            //             Picture = CreatePicture("category/notebooks.png"),
            //	Published = true,
            //	DisplayOrder = 2,
            //	MetaTitle = "Notebooks"
            //};

            var categoryGamingAccessories = new Category
            {
                Name = "Gaming Accessories",
                Alias = "Gaming Accessories",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Gaming").First().Id,
                MediaFile = CreatePicture("category/gaming_accessories.png"),
                Published = true,
                DisplayOrder = 2,
                MetaTitle = "Gaming Accessories"
            };

            var categoryGamingGames = new Category
            {
                Name = "Games",
                Alias = "Games",
                CategoryTemplateId = categoryTemplateInGridAndLines.Id,
                ParentCategoryId = _ctx.Set<Category>().Where(x => x.MetaTitle == "Gaming").First().Id,
                MediaFile = CreatePicture("category/games.jpg"),
                Published = true,
                DisplayOrder = 3,
                MetaTitle = "Games"
            };

            #endregion

            var entities = new List<Category>
            {
                categorySportsSunglasses,categorySportsSoccer, categorySportsBasketball,categorySportsGolf, categoryBooksSpiegel, categoryBooksCookAndEnjoy,
                categoryGamingAccessories, categoryGamingGames, categoryFashionJackets, categoryFashionLeatherJackets, categoryFashionShoes, categoryFashionTrousers,
                categoryFashionTracksuits
            };

            this.Alter(entities);
            return entities;
        }
    }
}
