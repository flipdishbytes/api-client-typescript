/* 
 * Flipdish Open API v1.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Flipdish.Client.SwaggerDateConverter;

namespace Flipdish.Model
{
    /// <summary>
    /// App
    /// </summary>
    [DataContract]
    public partial class App :  IEquatable<App>, IValidatableObject
    {
        /// <summary>
        /// App access level for the logged in user
        /// </summary>
        /// <value>App access level for the logged in user</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AppAccessLevelEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Owner for value: Owner
            /// </summary>
            [EnumMember(Value = "Owner")]
            Owner = 2,
            
            /// <summary>
            /// Enum StoreOwner for value: StoreOwner
            /// </summary>
            [EnumMember(Value = "StoreOwner")]
            StoreOwner = 3,
            
            /// <summary>
            /// Enum ManagedOwner for value: ManagedOwner
            /// </summary>
            [EnumMember(Value = "ManagedOwner")]
            ManagedOwner = 4,
            
            /// <summary>
            /// Enum StoreManager for value: StoreManager
            /// </summary>
            [EnumMember(Value = "StoreManager")]
            StoreManager = 5,
            
            /// <summary>
            /// Enum StoreStaff for value: StoreStaff
            /// </summary>
            [EnumMember(Value = "StoreStaff")]
            StoreStaff = 6,
            
            /// <summary>
            /// Enum StoreReadOnlyAccess for value: StoreReadOnlyAccess
            /// </summary>
            [EnumMember(Value = "StoreReadOnlyAccess")]
            StoreReadOnlyAccess = 7,
            
            /// <summary>
            /// Enum FinanceManger for value: FinanceManger
            /// </summary>
            [EnumMember(Value = "FinanceManger")]
            FinanceManger = 8
        }

        /// <summary>
        /// App access level for the logged in user
        /// </summary>
        /// <value>App access level for the logged in user</value>
        [DataMember(Name="AppAccessLevel", EmitDefaultValue=false)]
        public AppAccessLevelEnum? AppAccessLevel { get; set; }
        /// <summary>
        /// Defines AppResourceSet
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AppResourceSetEnum
        {
            
            /// <summary>
            /// Enum ViewApp for value: ViewApp
            /// </summary>
            [EnumMember(Value = "ViewApp")]
            ViewApp = 1,
            
            /// <summary>
            /// Enum CreateApp for value: CreateApp
            /// </summary>
            [EnumMember(Value = "CreateApp")]
            CreateApp = 2,
            
            /// <summary>
            /// Enum UpdateApp for value: UpdateApp
            /// </summary>
            [EnumMember(Value = "UpdateApp")]
            UpdateApp = 3,
            
            /// <summary>
            /// Enum UpdateAppName for value: UpdateAppName
            /// </summary>
            [EnumMember(Value = "UpdateAppName")]
            UpdateAppName = 4,
            
            /// <summary>
            /// Enum EditAppAssets for value: EditAppAssets
            /// </summary>
            [EnumMember(Value = "EditAppAssets")]
            EditAppAssets = 5,
            
            /// <summary>
            /// Enum ViewTeammates for value: ViewTeammates
            /// </summary>
            [EnumMember(Value = "ViewTeammates")]
            ViewTeammates = 6,
            
            /// <summary>
            /// Enum EditTeammates for value: EditTeammates
            /// </summary>
            [EnumMember(Value = "EditTeammates")]
            EditTeammates = 7,
            
            /// <summary>
            /// Enum CreateTeammateOwner for value: CreateTeammateOwner
            /// </summary>
            [EnumMember(Value = "CreateTeammateOwner")]
            CreateTeammateOwner = 8,
            
            /// <summary>
            /// Enum CreateTeammateManagedOwner for value: CreateTeammateManagedOwner
            /// </summary>
            [EnumMember(Value = "CreateTeammateManagedOwner")]
            CreateTeammateManagedOwner = 9,
            
            /// <summary>
            /// Enum CreateTeammateStoreOwner for value: CreateTeammateStoreOwner
            /// </summary>
            [EnumMember(Value = "CreateTeammateStoreOwner")]
            CreateTeammateStoreOwner = 10,
            
            /// <summary>
            /// Enum CreateTeammateStoreManager for value: CreateTeammateStoreManager
            /// </summary>
            [EnumMember(Value = "CreateTeammateStoreManager")]
            CreateTeammateStoreManager = 11,
            
            /// <summary>
            /// Enum CreateTeammateStoreStaff for value: CreateTeammateStoreStaff
            /// </summary>
            [EnumMember(Value = "CreateTeammateStoreStaff")]
            CreateTeammateStoreStaff = 12,
            
            /// <summary>
            /// Enum CreateTeammateStoreReadAccess for value: CreateTeammateStoreReadAccess
            /// </summary>
            [EnumMember(Value = "CreateTeammateStoreReadAccess")]
            CreateTeammateStoreReadAccess = 13,
            
            /// <summary>
            /// Enum CreateTeammateFinanceManager for value: CreateTeammateFinanceManager
            /// </summary>
            [EnumMember(Value = "CreateTeammateFinanceManager")]
            CreateTeammateFinanceManager = 14,
            
            /// <summary>
            /// Enum ViewApmConfigurations for value: ViewApmConfigurations
            /// </summary>
            [EnumMember(Value = "ViewApmConfigurations")]
            ViewApmConfigurations = 15,
            
            /// <summary>
            /// Enum EditApmConfigurations for value: EditApmConfigurations
            /// </summary>
            [EnumMember(Value = "EditApmConfigurations")]
            EditApmConfigurations = 16,
            
            /// <summary>
            /// Enum ViewCampaignsConfigurations for value: ViewCampaignsConfigurations
            /// </summary>
            [EnumMember(Value = "ViewCampaignsConfigurations")]
            ViewCampaignsConfigurations = 17,
            
            /// <summary>
            /// Enum CreateCampaignsConfigurations for value: CreateCampaignsConfigurations
            /// </summary>
            [EnumMember(Value = "CreateCampaignsConfigurations")]
            CreateCampaignsConfigurations = 18,
            
            /// <summary>
            /// Enum UpdateCampaignsConfigurations for value: UpdateCampaignsConfigurations
            /// </summary>
            [EnumMember(Value = "UpdateCampaignsConfigurations")]
            UpdateCampaignsConfigurations = 19,
            
            /// <summary>
            /// Enum ViewDevelopersSettings for value: ViewDevelopersSettings
            /// </summary>
            [EnumMember(Value = "ViewDevelopersSettings")]
            ViewDevelopersSettings = 20,
            
            /// <summary>
            /// Enum EditDevelopersSettings for value: EditDevelopersSettings
            /// </summary>
            [EnumMember(Value = "EditDevelopersSettings")]
            EditDevelopersSettings = 21,
            
            /// <summary>
            /// Enum ViewOrders for value: ViewOrders
            /// </summary>
            [EnumMember(Value = "ViewOrders")]
            ViewOrders = 22,
            
            /// <summary>
            /// Enum UpdateOrdersAccept for value: UpdateOrdersAccept
            /// </summary>
            [EnumMember(Value = "UpdateOrdersAccept")]
            UpdateOrdersAccept = 23,
            
            /// <summary>
            /// Enum UpdateOrdersReject for value: UpdateOrdersReject
            /// </summary>
            [EnumMember(Value = "UpdateOrdersReject")]
            UpdateOrdersReject = 24,
            
            /// <summary>
            /// Enum UpdateOrdersRefund for value: UpdateOrdersRefund
            /// </summary>
            [EnumMember(Value = "UpdateOrdersRefund")]
            UpdateOrdersRefund = 25,
            
            /// <summary>
            /// Enum UpdateOrdersDispatch for value: UpdateOrdersDispatch
            /// </summary>
            [EnumMember(Value = "UpdateOrdersDispatch")]
            UpdateOrdersDispatch = 26,
            
            /// <summary>
            /// Enum ViewStores for value: ViewStores
            /// </summary>
            [EnumMember(Value = "ViewStores")]
            ViewStores = 27,
            
            /// <summary>
            /// Enum EditStores for value: EditStores
            /// </summary>
            [EnumMember(Value = "EditStores")]
            EditStores = 28,
            
            /// <summary>
            /// Enum ViewStoresOpeningHours for value: ViewStoresOpeningHours
            /// </summary>
            [EnumMember(Value = "ViewStoresOpeningHours")]
            ViewStoresOpeningHours = 29,
            
            /// <summary>
            /// Enum UpdateStoresOpenForCollectionOrDelivery for value: UpdateStoresOpenForCollectionOrDelivery
            /// </summary>
            [EnumMember(Value = "UpdateStoresOpenForCollectionOrDelivery")]
            UpdateStoresOpenForCollectionOrDelivery = 30,
            
            /// <summary>
            /// Enum UpdateStoresOpeningHours for value: UpdateStoresOpeningHours
            /// </summary>
            [EnumMember(Value = "UpdateStoresOpeningHours")]
            UpdateStoresOpeningHours = 31,
            
            /// <summary>
            /// Enum ViewStoresOpeningHoursOverride for value: ViewStoresOpeningHoursOverride
            /// </summary>
            [EnumMember(Value = "ViewStoresOpeningHoursOverride")]
            ViewStoresOpeningHoursOverride = 32,
            
            /// <summary>
            /// Enum EditStoresOpeningHoursOverride for value: EditStoresOpeningHoursOverride
            /// </summary>
            [EnumMember(Value = "EditStoresOpeningHoursOverride")]
            EditStoresOpeningHoursOverride = 33,
            
            /// <summary>
            /// Enum EditStoresOpeningHoursOverrideTemporary for value: EditStoresOpeningHoursOverrideTemporary
            /// </summary>
            [EnumMember(Value = "EditStoresOpeningHoursOverrideTemporary")]
            EditStoresOpeningHoursOverrideTemporary = 34,
            
            /// <summary>
            /// Enum UpdateStoresName for value: UpdateStoresName
            /// </summary>
            [EnumMember(Value = "UpdateStoresName")]
            UpdateStoresName = 35,
            
            /// <summary>
            /// Enum UpdatePrinterTerminalsAssign for value: UpdatePrinterTerminalsAssign
            /// </summary>
            [EnumMember(Value = "UpdatePrinterTerminalsAssign")]
            UpdatePrinterTerminalsAssign = 36,
            
            /// <summary>
            /// Enum UpdatePrinterTerminalsToggle for value: UpdatePrinterTerminalsToggle
            /// </summary>
            [EnumMember(Value = "UpdatePrinterTerminalsToggle")]
            UpdatePrinterTerminalsToggle = 37,
            
            /// <summary>
            /// Enum EditStoreNotifications for value: EditStoreNotifications
            /// </summary>
            [EnumMember(Value = "EditStoreNotifications")]
            EditStoreNotifications = 38,
            
            /// <summary>
            /// Enum ViewStoreGroups for value: ViewStoreGroups
            /// </summary>
            [EnumMember(Value = "ViewStoreGroups")]
            ViewStoreGroups = 39,
            
            /// <summary>
            /// Enum CreateStoreGroups for value: CreateStoreGroups
            /// </summary>
            [EnumMember(Value = "CreateStoreGroups")]
            CreateStoreGroups = 40,
            
            /// <summary>
            /// Enum UpdateStoreGroups for value: UpdateStoreGroups
            /// </summary>
            [EnumMember(Value = "UpdateStoreGroups")]
            UpdateStoreGroups = 41,
            
            /// <summary>
            /// Enum DeleteStoreGroups for value: DeleteStoreGroups
            /// </summary>
            [EnumMember(Value = "DeleteStoreGroups")]
            DeleteStoreGroups = 42,
            
            /// <summary>
            /// Enum ViewDeliveryZones for value: ViewDeliveryZones
            /// </summary>
            [EnumMember(Value = "ViewDeliveryZones")]
            ViewDeliveryZones = 43,
            
            /// <summary>
            /// Enum CreateDeliveryZones for value: CreateDeliveryZones
            /// </summary>
            [EnumMember(Value = "CreateDeliveryZones")]
            CreateDeliveryZones = 44,
            
            /// <summary>
            /// Enum UpdateDeliveryZones for value: UpdateDeliveryZones
            /// </summary>
            [EnumMember(Value = "UpdateDeliveryZones")]
            UpdateDeliveryZones = 45,
            
            /// <summary>
            /// Enum DeleteDeliveryZones for value: DeleteDeliveryZones
            /// </summary>
            [EnumMember(Value = "DeleteDeliveryZones")]
            DeleteDeliveryZones = 46,
            
            /// <summary>
            /// Enum ViewMenu for value: ViewMenu
            /// </summary>
            [EnumMember(Value = "ViewMenu")]
            ViewMenu = 47,
            
            /// <summary>
            /// Enum CreateMenu for value: CreateMenu
            /// </summary>
            [EnumMember(Value = "CreateMenu")]
            CreateMenu = 48,
            
            /// <summary>
            /// Enum UpdateMenu for value: UpdateMenu
            /// </summary>
            [EnumMember(Value = "UpdateMenu")]
            UpdateMenu = 49,
            
            /// <summary>
            /// Enum DeleteMenu for value: DeleteMenu
            /// </summary>
            [EnumMember(Value = "DeleteMenu")]
            DeleteMenu = 50,
            
            /// <summary>
            /// Enum UpdateMenuLock for value: UpdateMenuLock
            /// </summary>
            [EnumMember(Value = "UpdateMenuLock")]
            UpdateMenuLock = 51,
            
            /// <summary>
            /// Enum UpdateMenuItemsHideTemporarily for value: UpdateMenuItemsHideTemporarily
            /// </summary>
            [EnumMember(Value = "UpdateMenuItemsHideTemporarily")]
            UpdateMenuItemsHideTemporarily = 52,
            
            /// <summary>
            /// Enum EditMenuImage for value: EditMenuImage
            /// </summary>
            [EnumMember(Value = "EditMenuImage")]
            EditMenuImage = 53,
            
            /// <summary>
            /// Enum ViewVouchers for value: ViewVouchers
            /// </summary>
            [EnumMember(Value = "ViewVouchers")]
            ViewVouchers = 54,
            
            /// <summary>
            /// Enum EditVouchers for value: EditVouchers
            /// </summary>
            [EnumMember(Value = "EditVouchers")]
            EditVouchers = 55,
            
            /// <summary>
            /// Enum UpdateVouchersExtendDisable for value: UpdateVouchersExtendDisable
            /// </summary>
            [EnumMember(Value = "UpdateVouchersExtendDisable")]
            UpdateVouchersExtendDisable = 56,
            
            /// <summary>
            /// Enum ViewWebsiteContent for value: ViewWebsiteContent
            /// </summary>
            [EnumMember(Value = "ViewWebsiteContent")]
            ViewWebsiteContent = 57,
            
            /// <summary>
            /// Enum EditWebsiteContent for value: EditWebsiteContent
            /// </summary>
            [EnumMember(Value = "EditWebsiteContent")]
            EditWebsiteContent = 58,
            
            /// <summary>
            /// Enum ViewBankAccounts for value: ViewBankAccounts
            /// </summary>
            [EnumMember(Value = "ViewBankAccounts")]
            ViewBankAccounts = 59,
            
            /// <summary>
            /// Enum CreateBankAccounts for value: CreateBankAccounts
            /// </summary>
            [EnumMember(Value = "CreateBankAccounts")]
            CreateBankAccounts = 60,
            
            /// <summary>
            /// Enum UpdateBankAccounts for value: UpdateBankAccounts
            /// </summary>
            [EnumMember(Value = "UpdateBankAccounts")]
            UpdateBankAccounts = 61,
            
            /// <summary>
            /// Enum UpdateBankAccountsAssign for value: UpdateBankAccountsAssign
            /// </summary>
            [EnumMember(Value = "UpdateBankAccountsAssign")]
            UpdateBankAccountsAssign = 62,
            
            /// <summary>
            /// Enum ViewAssignedBankAccount for value: ViewAssignedBankAccount
            /// </summary>
            [EnumMember(Value = "ViewAssignedBankAccount")]
            ViewAssignedBankAccount = 63,
            
            /// <summary>
            /// Enum VerifyBankAccounts for value: VerifyBankAccounts
            /// </summary>
            [EnumMember(Value = "VerifyBankAccounts")]
            VerifyBankAccounts = 64,
            
            /// <summary>
            /// Enum ViewFeesConfigurations for value: ViewFeesConfigurations
            /// </summary>
            [EnumMember(Value = "ViewFeesConfigurations")]
            ViewFeesConfigurations = 65,
            
            /// <summary>
            /// Enum EditFeesConfigurations for value: EditFeesConfigurations
            /// </summary>
            [EnumMember(Value = "EditFeesConfigurations")]
            EditFeesConfigurations = 66,
            
            /// <summary>
            /// Enum ViewAppStatistics for value: ViewAppStatistics
            /// </summary>
            [EnumMember(Value = "ViewAppStatistics")]
            ViewAppStatistics = 67,
            
            /// <summary>
            /// Enum ViewApmStatistics for value: ViewApmStatistics
            /// </summary>
            [EnumMember(Value = "ViewApmStatistics")]
            ViewApmStatistics = 68,
            
            /// <summary>
            /// Enum ViewCampaignsStatistics for value: ViewCampaignsStatistics
            /// </summary>
            [EnumMember(Value = "ViewCampaignsStatistics")]
            ViewCampaignsStatistics = 69,
            
            /// <summary>
            /// Enum ViewCustomerStatistics for value: ViewCustomerStatistics
            /// </summary>
            [EnumMember(Value = "ViewCustomerStatistics")]
            ViewCustomerStatistics = 70,
            
            /// <summary>
            /// Enum ViewLiveStatistics for value: ViewLiveStatistics
            /// </summary>
            [EnumMember(Value = "ViewLiveStatistics")]
            ViewLiveStatistics = 71,
            
            /// <summary>
            /// Enum ViewOrderStatistics for value: ViewOrderStatistics
            /// </summary>
            [EnumMember(Value = "ViewOrderStatistics")]
            ViewOrderStatistics = 72,
            
            /// <summary>
            /// Enum ViewSalesStatistics for value: ViewSalesStatistics
            /// </summary>
            [EnumMember(Value = "ViewSalesStatistics")]
            ViewSalesStatistics = 73,
            
            /// <summary>
            /// Enum ViewSalesEndOfDayStatistics for value: ViewSalesEndOfDayStatistics
            /// </summary>
            [EnumMember(Value = "ViewSalesEndOfDayStatistics")]
            ViewSalesEndOfDayStatistics = 74,
            
            /// <summary>
            /// Enum ViewVouchersStatistics for value: ViewVouchersStatistics
            /// </summary>
            [EnumMember(Value = "ViewVouchersStatistics")]
            ViewVouchersStatistics = 75,
            
            /// <summary>
            /// Enum ViewApmAuditLogs for value: ViewApmAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewApmAuditLogs")]
            ViewApmAuditLogs = 76,
            
            /// <summary>
            /// Enum ViewStoreAuditLogs for value: ViewStoreAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewStoreAuditLogs")]
            ViewStoreAuditLogs = 77,
            
            /// <summary>
            /// Enum ViewMenuAuditLogs for value: ViewMenuAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewMenuAuditLogs")]
            ViewMenuAuditLogs = 78,
            
            /// <summary>
            /// Enum ViewBankAccountAuditLogs for value: ViewBankAccountAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewBankAccountAuditLogs")]
            ViewBankAccountAuditLogs = 79,
            
            /// <summary>
            /// Enum ViewFeeConfigurationsAuditLogs for value: ViewFeeConfigurationsAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewFeeConfigurationsAuditLogs")]
            ViewFeeConfigurationsAuditLogs = 80,
            
            /// <summary>
            /// Enum ViewOrdersAuditLogs for value: ViewOrdersAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewOrdersAuditLogs")]
            ViewOrdersAuditLogs = 81,
            
            /// <summary>
            /// Enum ViewVouchersAuditLogs for value: ViewVouchersAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewVouchersAuditLogs")]
            ViewVouchersAuditLogs = 82,
            
            /// <summary>
            /// Enum ViewUserEventsAuditLogs for value: ViewUserEventsAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewUserEventsAuditLogs")]
            ViewUserEventsAuditLogs = 83,
            
            /// <summary>
            /// Enum ViewCampaignsAuditLogs for value: ViewCampaignsAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewCampaignsAuditLogs")]
            ViewCampaignsAuditLogs = 84,
            
            /// <summary>
            /// Enum ViewTeammatesAuditLogs for value: ViewTeammatesAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewTeammatesAuditLogs")]
            ViewTeammatesAuditLogs = 85,
            
            /// <summary>
            /// Enum ViewAppAuditLogs for value: ViewAppAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewAppAuditLogs")]
            ViewAppAuditLogs = 86,
            
            /// <summary>
            /// Enum ViewCustomerAuditLogs for value: ViewCustomerAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewCustomerAuditLogs")]
            ViewCustomerAuditLogs = 87,
            
            /// <summary>
            /// Enum ViewPrinterAuditLogs for value: ViewPrinterAuditLogs
            /// </summary>
            [EnumMember(Value = "ViewPrinterAuditLogs")]
            ViewPrinterAuditLogs = 88,
            
            /// <summary>
            /// Enum SendPushNotificationToCustomer for value: SendPushNotificationToCustomer
            /// </summary>
            [EnumMember(Value = "SendPushNotificationToCustomer")]
            SendPushNotificationToCustomer = 89
        }


        /// <summary>
        /// Constitutes a list of available resources
        /// </summary>
        /// <value>Constitutes a list of available resources</value>
        [DataMember(Name="AppResourceSet", EmitDefaultValue=false)]
        public List<AppResourceSetEnum> AppResourceSet { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// </summary>
        /// <param name="appId">App Identifier.</param>
        /// <param name="name">App name.</param>
        /// <param name="mapCenter">Center of the map coordinates.</param>
        /// <param name="mapNorthEast">North East(Top Right) Corner of the map coordinates.</param>
        /// <param name="mapSouthWest">South West (Bottom Left) Corner of the map coordinates.</param>
        /// <param name="appAccessLevel">App access level for the logged in user.</param>
        /// <param name="iconUrl">Icon url.</param>
        /// <param name="iconThumbnailUrl">Icon thumbnail url.</param>
        /// <param name="countryId">Country identifier.</param>
        /// <param name="availableAppLanguages">Available Languages for Apps\\Staff.</param>
        /// <param name="appResourceSet">Constitutes a list of available resources.</param>
        public App(string appId = default(string), string name = default(string), Coordinates mapCenter = default(Coordinates), Coordinates mapNorthEast = default(Coordinates), Coordinates mapSouthWest = default(Coordinates), AppAccessLevelEnum? appAccessLevel = default(AppAccessLevelEnum?), string iconUrl = default(string), string iconThumbnailUrl = default(string), string countryId = default(string), List<Language> availableAppLanguages = default(List<Language>), List<AppResourceSetEnum> appResourceSet = default(List<AppResourceSetEnum>))
        {
            this.AppId = appId;
            this.Name = name;
            this.MapCenter = mapCenter;
            this.MapNorthEast = mapNorthEast;
            this.MapSouthWest = mapSouthWest;
            this.AppAccessLevel = appAccessLevel;
            this.IconUrl = iconUrl;
            this.IconThumbnailUrl = iconThumbnailUrl;
            this.CountryId = countryId;
            this.AvailableAppLanguages = availableAppLanguages;
            this.AppResourceSet = appResourceSet;
        }
        
        /// <summary>
        /// App Identifier
        /// </summary>
        /// <value>App Identifier</value>
        [DataMember(Name="AppId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// App name
        /// </summary>
        /// <value>App name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Center of the map coordinates
        /// </summary>
        /// <value>Center of the map coordinates</value>
        [DataMember(Name="MapCenter", EmitDefaultValue=false)]
        public Coordinates MapCenter { get; set; }

        /// <summary>
        /// North East(Top Right) Corner of the map coordinates
        /// </summary>
        /// <value>North East(Top Right) Corner of the map coordinates</value>
        [DataMember(Name="MapNorthEast", EmitDefaultValue=false)]
        public Coordinates MapNorthEast { get; set; }

        /// <summary>
        /// South West (Bottom Left) Corner of the map coordinates
        /// </summary>
        /// <value>South West (Bottom Left) Corner of the map coordinates</value>
        [DataMember(Name="MapSouthWest", EmitDefaultValue=false)]
        public Coordinates MapSouthWest { get; set; }


        /// <summary>
        /// Icon url
        /// </summary>
        /// <value>Icon url</value>
        [DataMember(Name="IconUrl", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Icon thumbnail url
        /// </summary>
        /// <value>Icon thumbnail url</value>
        [DataMember(Name="IconThumbnailUrl", EmitDefaultValue=false)]
        public string IconThumbnailUrl { get; set; }

        /// <summary>
        /// Country identifier
        /// </summary>
        /// <value>Country identifier</value>
        [DataMember(Name="CountryId", EmitDefaultValue=false)]
        public string CountryId { get; set; }

        /// <summary>
        /// Available Languages for Apps\\Staff
        /// </summary>
        /// <value>Available Languages for Apps\\Staff</value>
        [DataMember(Name="AvailableAppLanguages", EmitDefaultValue=false)]
        public List<Language> AvailableAppLanguages { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class App {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MapCenter: ").Append(MapCenter).Append("\n");
            sb.Append("  MapNorthEast: ").Append(MapNorthEast).Append("\n");
            sb.Append("  MapSouthWest: ").Append(MapSouthWest).Append("\n");
            sb.Append("  AppAccessLevel: ").Append(AppAccessLevel).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  IconThumbnailUrl: ").Append(IconThumbnailUrl).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  AvailableAppLanguages: ").Append(AvailableAppLanguages).Append("\n");
            sb.Append("  AppResourceSet: ").Append(AppResourceSet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as App);
        }

        /// <summary>
        /// Returns true if App instances are equal
        /// </summary>
        /// <param name="input">Instance of App to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(App input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MapCenter == input.MapCenter ||
                    (this.MapCenter != null &&
                    this.MapCenter.Equals(input.MapCenter))
                ) && 
                (
                    this.MapNorthEast == input.MapNorthEast ||
                    (this.MapNorthEast != null &&
                    this.MapNorthEast.Equals(input.MapNorthEast))
                ) && 
                (
                    this.MapSouthWest == input.MapSouthWest ||
                    (this.MapSouthWest != null &&
                    this.MapSouthWest.Equals(input.MapSouthWest))
                ) && 
                (
                    this.AppAccessLevel == input.AppAccessLevel ||
                    (this.AppAccessLevel != null &&
                    this.AppAccessLevel.Equals(input.AppAccessLevel))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.IconThumbnailUrl == input.IconThumbnailUrl ||
                    (this.IconThumbnailUrl != null &&
                    this.IconThumbnailUrl.Equals(input.IconThumbnailUrl))
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
                ) && 
                (
                    this.AvailableAppLanguages == input.AvailableAppLanguages ||
                    this.AvailableAppLanguages != null &&
                    this.AvailableAppLanguages.SequenceEqual(input.AvailableAppLanguages)
                ) && 
                (
                    this.AppResourceSet == input.AppResourceSet ||
                    this.AppResourceSet != null &&
                    this.AppResourceSet.SequenceEqual(input.AppResourceSet)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MapCenter != null)
                    hashCode = hashCode * 59 + this.MapCenter.GetHashCode();
                if (this.MapNorthEast != null)
                    hashCode = hashCode * 59 + this.MapNorthEast.GetHashCode();
                if (this.MapSouthWest != null)
                    hashCode = hashCode * 59 + this.MapSouthWest.GetHashCode();
                if (this.AppAccessLevel != null)
                    hashCode = hashCode * 59 + this.AppAccessLevel.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.IconThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.IconThumbnailUrl.GetHashCode();
                if (this.CountryId != null)
                    hashCode = hashCode * 59 + this.CountryId.GetHashCode();
                if (this.AvailableAppLanguages != null)
                    hashCode = hashCode * 59 + this.AvailableAppLanguages.GetHashCode();
                if (this.AppResourceSet != null)
                    hashCode = hashCode * 59 + this.AppResourceSet.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // CountryId (string) maxLength
            if(this.CountryId != null && this.CountryId.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryId, length must be less than 2.", new [] { "CountryId" });
            }

            // CountryId (string) minLength
            if(this.CountryId != null && this.CountryId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryId, length must be greater than 0.", new [] { "CountryId" });
            }

            yield break;
        }
    }

}
