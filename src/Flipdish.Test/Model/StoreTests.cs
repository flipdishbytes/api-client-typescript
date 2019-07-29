/* 
 * Flipdish Open API v1.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Flipdish.Api;
using Flipdish.Model;
using Flipdish.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Flipdish.Test
{
    /// <summary>
    ///  Class for testing Store
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class StoreTests
    {
        // TODO uncomment below to declare an instance variable for Store
        //private Store instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Store
            //instance = new Store();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Store
        /// </summary>
        [Test]
        public void StoreInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Store
            //Assert.IsInstanceOfType<Store> (instance, "variable 'instance' is a Store");
        }


        /// <summary>
        /// Test the property 'StoreId'
        /// </summary>
        [Test]
        public void StoreIdTest()
        {
            // TODO unit test for the property 'StoreId'
        }
        /// <summary>
        /// Test the property 'StoreGroupId'
        /// </summary>
        [Test]
        public void StoreGroupIdTest()
        {
            // TODO unit test for the property 'StoreGroupId'
        }
        /// <summary>
        /// Test the property 'Address'
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO unit test for the property 'Address'
        }
        /// <summary>
        /// Test the property 'DeliveryZones'
        /// </summary>
        [Test]
        public void DeliveryZonesTest()
        {
            // TODO unit test for the property 'DeliveryZones'
        }
        /// <summary>
        /// Test the property 'ApmPhoneNumber'
        /// </summary>
        [Test]
        public void ApmPhoneNumberTest()
        {
            // TODO unit test for the property 'ApmPhoneNumber'
        }
        /// <summary>
        /// Test the property 'PickupHours'
        /// </summary>
        [Test]
        public void PickupHoursTest()
        {
            // TODO unit test for the property 'PickupHours'
        }
        /// <summary>
        /// Test the property 'DeliveryHours'
        /// </summary>
        [Test]
        public void DeliveryHoursTest()
        {
            // TODO unit test for the property 'DeliveryHours'
        }
        /// <summary>
        /// Test the property 'MenuId'
        /// </summary>
        [Test]
        public void MenuIdTest()
        {
            // TODO unit test for the property 'MenuId'
        }
        /// <summary>
        /// Test the property 'OrderConfirmationMessageOverrideDelivery'
        /// </summary>
        [Test]
        public void OrderConfirmationMessageOverrideDeliveryTest()
        {
            // TODO unit test for the property 'OrderConfirmationMessageOverrideDelivery'
        }
        /// <summary>
        /// Test the property 'OrderConfirmationMessageOverridePickup'
        /// </summary>
        [Test]
        public void OrderConfirmationMessageOverridePickupTest()
        {
            // TODO unit test for the property 'OrderConfirmationMessageOverridePickup'
        }
        /// <summary>
        /// Test the property 'PrintoutLayoutType'
        /// </summary>
        [Test]
        public void PrintoutLayoutTypeTest()
        {
            // TODO unit test for the property 'PrintoutLayoutType'
        }
        /// <summary>
        /// Test the property 'StoreNotes'
        /// </summary>
        [Test]
        public void StoreNotesTest()
        {
            // TODO unit test for the property 'StoreNotes'
        }
        /// <summary>
        /// Test the property 'MicrosoftTimeZone'
        /// </summary>
        [Test]
        public void MicrosoftTimeZoneTest()
        {
            // TODO unit test for the property 'MicrosoftTimeZone'
        }
        /// <summary>
        /// Test the property 'IanaTimeZone'
        /// </summary>
        [Test]
        public void IanaTimeZoneTest()
        {
            // TODO unit test for the property 'IanaTimeZone'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Test]
        public void PhoneNumberTest()
        {
            // TODO unit test for the property 'PhoneNumber'
        }
        /// <summary>
        /// Test the property 'AlwaysAppearOpen'
        /// </summary>
        [Test]
        public void AlwaysAppearOpenTest()
        {
            // TODO unit test for the property 'AlwaysAppearOpen'
        }
        /// <summary>
        /// Test the property 'PreOrderEnabled'
        /// </summary>
        [Test]
        public void PreOrderEnabledTest()
        {
            // TODO unit test for the property 'PreOrderEnabled'
        }
        /// <summary>
        /// Test the property 'TakeOutEnabled'
        /// </summary>
        [Test]
        public void TakeOutEnabledTest()
        {
            // TODO unit test for the property 'TakeOutEnabled'
        }
        /// <summary>
        /// Test the property 'TableServiceEnabled'
        /// </summary>
        [Test]
        public void TableServiceEnabledTest()
        {
            // TODO unit test for the property 'TableServiceEnabled'
        }
        /// <summary>
        /// Test the property 'DineInEnabled'
        /// </summary>
        [Test]
        public void DineInEnabledTest()
        {
            // TODO unit test for the property 'DineInEnabled'
        }
        /// <summary>
        /// Test the property 'AllowPreOrdersAndTableService'
        /// </summary>
        [Test]
        public void AllowPreOrdersAndTableServiceTest()
        {
            // TODO unit test for the property 'AllowPreOrdersAndTableService'
        }
        /// <summary>
        /// Test the property 'PickupEnabled'
        /// </summary>
        [Test]
        public void PickupEnabledTest()
        {
            // TODO unit test for the property 'PickupEnabled'
        }
        /// <summary>
        /// Test the property 'DeliveryEnabled'
        /// </summary>
        [Test]
        public void DeliveryEnabledTest()
        {
            // TODO unit test for the property 'DeliveryEnabled'
        }
        /// <summary>
        /// Test the property 'CardOrderDeliveryEnabled'
        /// </summary>
        [Test]
        public void CardOrderDeliveryEnabledTest()
        {
            // TODO unit test for the property 'CardOrderDeliveryEnabled'
        }
        /// <summary>
        /// Test the property 'CashOrdersDeliveryEnabled'
        /// </summary>
        [Test]
        public void CashOrdersDeliveryEnabledTest()
        {
            // TODO unit test for the property 'CashOrdersDeliveryEnabled'
        }
        /// <summary>
        /// Test the property 'CardOrdersPickupEnabled'
        /// </summary>
        [Test]
        public void CardOrdersPickupEnabledTest()
        {
            // TODO unit test for the property 'CardOrdersPickupEnabled'
        }
        /// <summary>
        /// Test the property 'CashOrdersPickupEnabled'
        /// </summary>
        [Test]
        public void CashOrdersPickupEnabledTest()
        {
            // TODO unit test for the property 'CashOrdersPickupEnabled'
        }
        /// <summary>
        /// Test the property 'TipsEnabled'
        /// </summary>
        [Test]
        public void TipsEnabledTest()
        {
            // TODO unit test for the property 'TipsEnabled'
        }
        /// <summary>
        /// Test the property 'AutomaticallyAcceptOrders'
        /// </summary>
        [Test]
        public void AutomaticallyAcceptOrdersTest()
        {
            // TODO unit test for the property 'AutomaticallyAcceptOrders'
        }
        /// <summary>
        /// Test the property 'OpenForDelivery'
        /// </summary>
        [Test]
        public void OpenForDeliveryTest()
        {
            // TODO unit test for the property 'OpenForDelivery'
        }
        /// <summary>
        /// Test the property 'OpenForPickup'
        /// </summary>
        [Test]
        public void OpenForPickupTest()
        {
            // TODO unit test for the property 'OpenForPickup'
        }
        /// <summary>
        /// Test the property 'MinimumPickupOrderAmount'
        /// </summary>
        [Test]
        public void MinimumPickupOrderAmountTest()
        {
            // TODO unit test for the property 'MinimumPickupOrderAmount'
        }
        /// <summary>
        /// Test the property 'RequireCustomerNameForPickup'
        /// </summary>
        [Test]
        public void RequireCustomerNameForPickupTest()
        {
            // TODO unit test for the property 'RequireCustomerNameForPickup'
        }
        /// <summary>
        /// Test the property 'GdprCustomerPhoneNumbers'
        /// </summary>
        [Test]
        public void GdprCustomerPhoneNumbersTest()
        {
            // TODO unit test for the property 'GdprCustomerPhoneNumbers'
        }
        /// <summary>
        /// Test the property 'RequireCustomerNameForDelivery'
        /// </summary>
        [Test]
        public void RequireCustomerNameForDeliveryTest()
        {
            // TODO unit test for the property 'RequireCustomerNameForDelivery'
        }
        /// <summary>
        /// Test the property 'EtaInPickupConfirmationSmsEnabled'
        /// </summary>
        [Test]
        public void EtaInPickupConfirmationSmsEnabledTest()
        {
            // TODO unit test for the property 'EtaInPickupConfirmationSmsEnabled'
        }
        /// <summary>
        /// Test the property 'EtaInDeliveryConfirmationSmsEnabled'
        /// </summary>
        [Test]
        public void EtaInDeliveryConfirmationSmsEnabledTest()
        {
            // TODO unit test for the property 'EtaInDeliveryConfirmationSmsEnabled'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'EmailAddress'
        /// </summary>
        [Test]
        public void EmailAddressTest()
        {
            // TODO unit test for the property 'EmailAddress'
        }
        /// <summary>
        /// Test the property 'StaffLanguage'
        /// </summary>
        [Test]
        public void StaffLanguageTest()
        {
            // TODO unit test for the property 'StaffLanguage'
        }

    }

}
