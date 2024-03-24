﻿using Subscription;
using AbstractFactory;

//=================================FACTORY METHOD TEST=================================
Subscription.ISubscriptionFactoryMethod webSiteResponse = new Subscription.WebSite(); //Працюємо з абстрактним творцем-фабрикою

Subscription.Subscription subscription;//загальний ти підписки

subscription = webSiteResponse.CreateSubscription("ForPremium");

subscription.GetStatus(); //об'єкт має властивості типу PremiumSubscription
//=================================FACTORY METHOD TEST=================================


//=================================ABSTRACT FABRIC TEST=================================
IAbstractFactory factoryOne = new ArasakaFacroty();

ILaptop laptopOne = factoryOne.CreateLaptop();

laptopOne.GetLaptop();//Створення ноутбуку з першої фабрики


IAbstractFactory factoryTwo = new SasungFacroty();

ISmartphone SmatphoneTwo = factoryTwo.CreateSmartphone();

SmatphoneTwo.GetSmartphone();//Створення смартфона з дургої фабрики

//=================================ABSTRACT FABRIC TEST=================================

