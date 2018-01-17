import request = require('request');
import http = require('http');
import Promise = require('bluebird');
export declare class Accept {
    'EstimatedMinutesForDelivery': number;
}
export declare class BusinessHoursPeriod {
    'DayOfWeek': BusinessHoursPeriod.DayOfWeekEnum;
    'StartTime': string;
    'Period': string;
    'StartTimeEarly': string;
    'PeriodEarly': string;
    'Early': Range;
    'Late': Range;
    'Ranges': Array<Range>;
}
export declare namespace BusinessHoursPeriod {
    enum DayOfWeekEnum {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
}
export declare class Coordinates {
    'Latitude': number;
    'Longitude': number;
}
export declare class CustomerSummary {
    'Id': number;
    'Name': string;
    'EmailAddress': string;
    'PhoneNumberLocalFormat': string;
    'PhoneNumber': string;
}
export declare class DeliveryFeeArea {
    'DeliveryFee': number;
    'MinimumDeliveryOrder': number;
}
export declare class DeliveryLocation {
    'Coordinates': Coordinates;
    'Building': string;
    'Street': string;
    'Town': string;
    'PostCode': string;
    'DeliveryInstructions': string;
    'PrettyAddressString': string;
}
export declare class FeeSummary {
    'FeeAmount': number;
    'PercentageRate': number;
    'PerTransactionFee': number;
}
export declare class Menu {
    'MenuId': number;
    'VersionNumber': number;
    'ModifiedTime': Date;
    'MenuSections': Array<MenuSectionBase>;
    'ImageUrl': string;
}
export declare class MenuItemOptionSet {
    'MenuItemOptionSetId': number;
    'MenuItemOptionSetItems': Array<MenuItemOptionSetItem>;
    'Name': string;
    'IsMasterOptionSet': boolean;
    'DisplayOrder': number;
    'MinSelectCount': number;
    'MaxSelectCount': number;
    'ImageUrl': string;
    'CellLayoutType': MenuItemOptionSet.CellLayoutTypeEnum;
}
export declare namespace MenuItemOptionSet {
    enum CellLayoutTypeEnum {
        Small,
        Medium,
        Large,
    }
}
export declare class MenuItemOptionSetBase {
    'Name': string;
    'IsMasterOptionSet': boolean;
    'DisplayOrder': number;
    'MinSelectCount': number;
    'MaxSelectCount': number;
    'ImageUrl': string;
    'CellLayoutType': MenuItemOptionSetBase.CellLayoutTypeEnum;
}
export declare namespace MenuItemOptionSetBase {
    enum CellLayoutTypeEnum {
        Small,
        Medium,
        Large,
    }
}
export declare class MenuItemOptionSetItem {
    'MenuItemOptionSetItemId': number;
    'ImageUrl': string;
    'Name': string;
    'Price': number;
    'IsAvailable': boolean;
    'DisplayOrder': number;
    'CellLayoutType': MenuItemOptionSetItem.CellLayoutTypeEnum;
}
export declare namespace MenuItemOptionSetItem {
    enum CellLayoutTypeEnum {
        Small,
        Medium,
        Large,
    }
}
export declare class MenuItemOptionSetItemBase {
    'Name': string;
    'Price': number;
    'IsAvailable': boolean;
    'DisplayOrder': number;
    'CellLayoutType': MenuItemOptionSetItemBase.CellLayoutTypeEnum;
}
export declare namespace MenuItemOptionSetItemBase {
    enum CellLayoutTypeEnum {
        Small,
        Medium,
        Large,
    }
}
export declare class MenuSection {
    'MenuSectionId': number;
    'ImageUrl': string;
    'MenuItems': Array<MenuSectionItem>;
    'MenuSectionAvailability': MenuSectionAvailability;
    'Name': string;
    'Description': string;
    'DisplayOrder': number;
    'IsAvailable': boolean;
    'IsHiddenFromCustomers': boolean;
}
export declare class MenuSectionAvailability {
    'AvailableTimes': Array<BusinessHoursPeriod>;
    'AvailabilityMode': MenuSectionAvailability.AvailabilityModeEnum;
}
export declare namespace MenuSectionAvailability {
    enum AvailabilityModeEnum {
        DisplayAlways,
        DisplayBasedOnTimes,
        DisplayAlwaysStartCollapsed,
        DisplayAlwaysStartCollapsedBasedOnTimes,
    }
}
export declare class MenuSectionBase {
    'Name': string;
    'Description': string;
    'DisplayOrder': number;
    'IsAvailable': boolean;
    'IsHiddenFromCustomers': boolean;
}
export declare class MenuSectionItem {
    'MenuItemId': number;
    'MenuItemOptionSets': Array<MenuItemOptionSet>;
    'Name': string;
    'Description': string;
    'SpicinessRating': MenuSectionItem.SpicinessRatingEnum;
    'Price': number;
    'ActualPrice': number;
    'DisplayOrder': number;
    'Alcohol': boolean;
    'IsAvailable': boolean;
    'ImageUrl': string;
}
export declare namespace MenuSectionItem {
    enum SpicinessRatingEnum {
        NotRated,
        Mild,
        Medium,
        Hot,
    }
}
export declare class MenuSectionItemBase {
    'Name': string;
    'Description': string;
    'SpicinessRating': MenuSectionItemBase.SpicinessRatingEnum;
    'Price': number;
    'ActualPrice': number;
    'DisplayOrder': number;
    'Alcohol': boolean;
    'IsAvailable': boolean;
    'ImageUrl': string;
}
export declare namespace MenuSectionItemBase {
    enum SpicinessRatingEnum {
        NotRated,
        Mild,
        Medium,
        Hot,
    }
}
export declare class Metadata {
    'Key': string;
    'Value': string;
}
export declare class OAuthClient {
    'ClientId': string;
    'ClientName': string;
    'OwnerUserId': number;
    'LogoUri': string;
}
export declare class OAuthTokenModel {
    'Key': string;
    'TokenType': string;
    'SubjectId': string;
    'ClientId': string;
    'Expiry': Date;
}
export declare class OauthClientRedirectUri {
    'Id': number;
    'Uri': string;
}
export declare class Order {
    'OrderId': number;
    'Store': StoreSummary;
    'Customer': CustomerSummary;
    'Voucher': VoucherSummary;
    'Fees': FeeSummary;
    'DeliveryType': Order.DeliveryTypeEnum;
    'PickupLocationType': Order.PickupLocationTypeEnum;
    'OrderItems': Array<OrderItem>;
    'TipAmount': number;
    'DeliveryAmount': number;
    'OrderItemsAmount': number;
    'Amount': number;
    'OnlineOrderingFee': number;
    'PaymentAccountType': Order.PaymentAccountTypeEnum;
    'PaymentAccountDescription': string;
    'DeliveryLocation': DeliveryLocation;
    'CustomerLocation': Coordinates;
    'OrderState': Order.OrderStateEnum;
    'IsPreOrder': boolean;
    'PlacedTime': Date;
    'RequestedForTime': Date;
    'ChefNote': string;
    'AppType': Order.AppTypeEnum;
    'UserRating': number;
}
export declare namespace Order {
    enum DeliveryTypeEnum {
        Delivery,
        Pickup,
    }
    enum PickupLocationTypeEnum {
        TakeOut,
        TableService,
        DineIn,
    }
    enum PaymentAccountTypeEnum {
        Card,
        Cash,
    }
    enum OrderStateEnum {
        Created,
        PlacedCanBeCancelled,
        ReadyToProcess,
        AcceptedByRestaurant,
        Dispatched,
        Delivered,
        Cancelled,
        ManualReview,
        RejectedByStore,
        RejectedByFlipdish,
        RejectedAutomatically,
        RejectedAfterBeingAccepted,
        AcceptedAndRefunded,
    }
    enum AppTypeEnum {
        Unknown,
        Ios,
        Android,
        Web,
        Kiosk,
        Pos,
        TelephoneCall,
        Sms,
        PwaAndroid,
        PwaIos,
    }
}
export declare class OrderItem {
    'MenuSectionName': string;
    'MenuSectionDisplayOrder': number;
    'Name': string;
    'Description': string;
    'Price': number;
    'PriceIncludingOptionSetItems': number;
    'MenuItemId': number;
    'MenuItemDisplayOrder': number;
    'IsAvailable': boolean;
    'OrderItemOptions': Array<OrderItemOption>;
    'Metadata': {
        [key: string]: string;
    };
}
export declare class OrderItemOption {
    'MenuItemOptionId': number;
    'IsMasterOptionSetItem': boolean;
    'Name': string;
    'Price': number;
    'MenuItemOptionDisplayOrder': number;
    'MenuItemOptionSetDisplayOrder': number;
    'Metadata': {
        [key: string]: string;
    };
}
export declare class Range {
    'StartTime': string;
    'Period': string;
    'DayOfWeek': Range.DayOfWeekEnum;
}
export declare namespace Range {
    enum DayOfWeekEnum {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
}
export declare class Refund {
    'RefundReason': string;
    'RefundAmount': number;
    'NotifyCustomer': boolean;
}
export declare class Reject {
    'RejectReason': Reject.RejectReasonEnum;
}
export declare namespace Reject {
    enum RejectReasonEnum {
        TooBusy,
        FoodUnavailable,
        UnableToDeliver,
        UnknownAddress,
        UnknownReason,
        TooSoon,
        TimeUnavailable,
        DontDeliverToArea,
        StoreUncontactable,
    }
}
export declare class RestApiArrayResultMenuItemOptionSet {
    'Data': Array<MenuItemOptionSet>;
}
export declare class RestApiArrayResultMenuItemOptionSetItem {
    'Data': Array<MenuItemOptionSetItem>;
}
export declare class RestApiArrayResultMenuSection {
    'Data': Array<MenuSection>;
}
export declare class RestApiArrayResultMenuSectionItem {
    'Data': Array<MenuSectionItem>;
}
export declare class RestApiArrayResultMetadata {
    'Data': Array<Metadata>;
}
export declare class RestApiArrayResultOAuthClient {
    'Data': Array<OAuthClient>;
}
export declare class RestApiArrayResultOauthClientRedirectUri {
    'Data': Array<OauthClientRedirectUri>;
}
export declare class RestApiArrayResultRestApiDefaultResponse {
    'Data': Array<RestApiDefaultResponse>;
}
export declare class RestApiArrayResultWebhookLog {
    'Data': Array<WebhookLog>;
}
export declare class RestApiArrayResultWebhookSubscription {
    'Data': Array<WebhookSubscription>;
}
export declare class RestApiDefaultResponse {
    'Data': string;
}
export declare class RestApiErrorResult {
    'Message': string;
    'Errors': Array<ValidationErrorResult>;
}
export declare class RestApiForbiddenResult {
    'Message': string;
}
export declare class RestApiIntegerResult {
    'Data': number;
}
export declare class RestApiPaginationResultOAuthTokenModel {
    'Page': number;
    'Limit': number;
    'TotalRecordCount': number;
    'Data': Array<OAuthTokenModel>;
}
export declare class RestApiPaginationResultOrder {
    'Page': number;
    'Limit': number;
    'TotalRecordCount': number;
    'Data': Array<Order>;
}
export declare class RestApiPaginationResultStore {
    'Page': number;
    'Limit': number;
    'TotalRecordCount': number;
    'Data': Array<Store>;
}
export declare class RestApiPaginationResultVoucher {
    'Page': number;
    'Limit': number;
    'TotalRecordCount': number;
    'Data': Array<Voucher>;
}
export declare class RestApiResultMenu {
    'Data': Menu;
}
export declare class RestApiResultMenuItemOptionSet {
    'Data': MenuItemOptionSet;
}
export declare class RestApiResultMenuItemOptionSetBase {
    'Data': MenuItemOptionSetBase;
}
export declare class RestApiResultMenuItemOptionSetItem {
    'Data': MenuItemOptionSetItem;
}
export declare class RestApiResultMenuItemOptionSetItemBase {
    'Data': MenuItemOptionSetItemBase;
}
export declare class RestApiResultMenuSection {
    'Data': MenuSection;
}
export declare class RestApiResultMenuSectionBase {
    'Data': MenuSectionBase;
}
export declare class RestApiResultMenuSectionItem {
    'Data': MenuSectionItem;
}
export declare class RestApiResultMenuSectionItemBase {
    'Data': MenuSectionItemBase;
}
export declare class RestApiResultMetadata {
    'Data': Metadata;
}
export declare class RestApiResultOAuthClient {
    'Data': OAuthClient;
}
export declare class RestApiResultOauthClientRedirectUri {
    'Data': OauthClientRedirectUri;
}
export declare class RestApiResultOrder {
    'Data': Order;
}
export declare class RestApiResultStore {
    'Data': Store;
}
export declare class RestApiResultVoucher {
    'Data': Voucher;
}
export declare class RestApiStringArrayResult {
    'Data': Array<string>;
}
export declare class RestApiStringResult {
    'Data': string;
}
export declare class RestApiUnauthorizedResult {
    'Message': string;
}
export declare class Store {
    'StoreId': number;
    'Name': string;
    'ApmPhoneNumber': string;
    'PhoneNumber': string;
    'EmailAddress': string;
    'Address': StoreAddress;
    'PreOrderEnabled': boolean;
    'TakeOutEnabled': boolean;
    'TableServiceEnabled': boolean;
    'DineInEnabled': boolean;
    'AllowPreOrdersAndTableService': boolean;
    'PickupEnabled': boolean;
    'DeliveryEnabled': boolean;
    'CardOrderDeliveryEnabled': boolean;
    'CashOrdersDeliveryEnabled': boolean;
    'CardOrdersPickupEnabled': boolean;
    'CashOrdersPickupEnabled': boolean;
    'TipsEnabled': boolean;
    'AutomaticallyAcceptOrders': boolean;
    'OpenForDelivery': boolean;
    'OpenForPickup': boolean;
    'MinimumPickupOrderAmount': number;
    'DeliveryFeeAreas': Array<DeliveryFeeArea>;
    'RequireCustomerNameForPickup': boolean;
    'RequireCustomerNameForDelivery': boolean;
    'PickupHours': Array<BusinessHoursPeriod>;
    'DeliveryHours': Array<BusinessHoursPeriod>;
    'MicrosoftTimeZone': string;
    'IanaTimeZone': string;
    'MenuId': number;
    'OrderConfirmationMessageOverrideDelivery': string;
    'OrderConfirmationMessageOverridePickup': string;
    'PrintoutLayoutType': Store.PrintoutLayoutTypeEnum;
    'StoreNotes': Array<StoreNote>;
}
export declare namespace Store {
    enum PrintoutLayoutTypeEnum {
        Default,
        Centra,
    }
}
export declare class StoreAddress {
    'AddressId': number;
    'Line1': string;
    'Postcode': string;
    'City': string;
    'CountryCode': string;
    'DisplayForCustomer': string;
    'Coordinates': Coordinates;
}
export declare class StoreNote {
    'UserId': number;
    'CreateTime': Date;
    'Note': string;
}
export declare class StoreSummary {
    'Id': number;
    'Name': string;
    'MenuId': number;
    'Metadata': {
        [key: string]: string;
    };
    'Currency': StoreSummary.CurrencyEnum;
}
export declare namespace StoreSummary {
    enum CurrencyEnum {
        EUR,
        USD,
        GBP,
        CAD,
        AUD,
        DJF,
        ZAR,
        ETB,
        AED,
        BHD,
        DZD,
        EGP,
        IQD,
        JOD,
        KWD,
        LBP,
        LYD,
        MAD,
        OMR,
        QAR,
        SAR,
        SYP,
        TND,
        YER,
        CLP,
        INR,
        AZN,
        RUB,
        BYN,
        BGN,
        NGN,
        BDT,
        CNY,
        BAM,
        CZK,
        DKK,
        CHF,
        MVR,
        BTN,
        XCD,
        BZD,
        HKD,
        IDR,
        JMD,
        MYR,
        NZD,
        PHP,
        SGD,
        TTD,
        XDR,
        ARS,
        BOB,
        COP,
        CRC,
        CUP,
        DOP,
        GTQ,
        HNL,
        MXN,
        NIO,
        PAB,
        PEN,
        PYG,
        UYU,
        VEF,
        IRR,
        XOF,
        CDF,
        XAF,
        HTG,
        ILS,
        HRK,
        HUF,
        AMD,
        ISK,
        JPY,
        GEL,
        KZT,
        KHR,
        KRW,
        KGS,
        LAK,
        MKD,
        MNT,
        BND,
        MMK,
        NOK,
        NPR,
        PKR,
        PLN,
        AFN,
        BRL,
        MDL,
        RON,
        RWF,
        SEK,
        LKR,
        SOS,
        ALL,
        RSD,
        KES,
        TJS,
        THB,
        ERN,
        TMT,
        BWP,
        TRY,
        UAH,
        UZS,
        VND,
        MOP,
        TWD,
    }
}
export declare class ValidationErrorResult {
    'FieldName': string;
    'Errors': Array<string>;
}
export declare class Voucher {
    'VoucherId': number;
    'VoucherType': Voucher.VoucherTypeEnum;
    'IsEnabled': boolean;
    'IsUsedUp': boolean;
    'VoucherSubType': Voucher.VoucherSubTypeEnum;
    'PublicDescription': string;
    'PrivateDescription': string;
    'ValidFrom': Date;
    'Expiry': Date;
    'VoucherPayer': Voucher.VoucherPayerEnum;
    'IsVisibleToStore': boolean;
    'IsReusable': boolean;
    'IsValidForDeliveryOrders': boolean;
    'IsValidForPickupOrders': boolean;
    'IsValidForCardOrders': boolean;
    'IsValidForCashOrders': boolean;
    'IsValidForFirstOrderOnly': boolean;
    'MinimumOrderAmount': number;
    'IsValidOncePerCustomer': boolean;
    'AutoApply': boolean;
    'AutoApplyOrder': number;
    'IncludeDeliveryFee': boolean;
    'Code': string;
}
export declare namespace Voucher {
    enum VoucherTypeEnum {
        PercentageDiscount,
        LumpDiscount,
        AddItem,
        CreditNote,
    }
    enum VoucherSubTypeEnum {
        None,
        SignUp,
        Loyalty,
        Loyalty25,
        Retention,
        SecondaryRetention,
        Custom,
    }
    enum VoucherPayerEnum {
        Flipdish,
        Store,
    }
}
export declare class VoucherSummary {
    'Name': string;
    'Description': string;
    'Code': string;
    'Amount': number;
    'Type': VoucherSummary.TypeEnum;
    'SubType': VoucherSummary.SubTypeEnum;
}
export declare namespace VoucherSummary {
    enum TypeEnum {
        PercentageDiscount,
        LumpDiscount,
        AddItem,
        CreditNote,
    }
    enum SubTypeEnum {
        None,
        SignUp,
        Loyalty,
        Loyalty25,
        Retention,
        SecondaryRetention,
        Custom,
    }
}
export declare class WebhookLog {
    'WebhookSubscriptionOwnerUserId': number;
    'EventCreated': string;
    'WebhookTriggered': string;
    'WebhookEventName': string;
    'WebhookSubscriptionCallbackUrl': string;
    'HttpResponseStatusCode': string;
    'HttpResponseStatus': string;
    'RequestHeaders': string;
    'RequestBody': string;
    'ResponseHeaders': string;
    'ResponseBody': string;
    'Duration': string;
    'RetryCount': number;
    'FlipdishWebhookId': string;
}
export declare class WebhookSubscription {
    'Id': number;
    'OwnerUserId': number;
    'EventNames': Array<string>;
    'CallbackUrl': string;
    'Enabled': boolean;
    'VerifyToken': string;
}
export interface Authentication {
    applyToRequest(requestOptions: request.Options): void;
}
export declare class HttpBasicAuth implements Authentication {
    username: string;
    password: string;
    applyToRequest(requestOptions: request.Options): void;
}
export declare class ApiKeyAuth implements Authentication {
    private location;
    private paramName;
    apiKey: string;
    constructor(location: string, paramName: string);
    applyToRequest(requestOptions: request.Options): void;
}
export declare class OAuth implements Authentication {
    accessToken: string;
    applyToRequest(requestOptions: request.Options): void;
}
export declare class VoidAuth implements Authentication {
    username: string;
    password: string;
    applyToRequest(_: request.Options): void;
}
export declare enum AuthorizationTokensApiApiKeys {
}
export declare class AuthorizationTokensApi {
    protected _basePath: string;
    protected defaultHeaders: any;
    protected _useQuerystring: boolean;
    protected authentications: {
        'default': Authentication;
        'oauth2': OAuth;
    };
    constructor(basePath?: string);
    useQuerystring: boolean;
    basePath: string;
    setDefaultAuthentication(auth: Authentication): void;
    setApiKey(key: AuthorizationTokensApiApiKeys, value: string): void;
    accessToken: string;
    getAuthorizationTokens(clientId: string, apiVersion: string, page?: number, limit?: number): Promise<{
        response: http.ClientResponse;
        body: RestApiPaginationResultOAuthTokenModel;
    }>;
    revokeToken(key: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
}
export declare enum MenuOptionSetItemsApiApiKeys {
}
export declare class MenuOptionSetItemsApi {
    protected _basePath: string;
    protected defaultHeaders: any;
    protected _useQuerystring: boolean;
    protected authentications: {
        'default': Authentication;
        'oauth2': OAuth;
    };
    constructor(basePath?: string);
    useQuerystring: boolean;
    basePath: string;
    setDefaultAuthentication(auth: Authentication): void;
    setApiKey(key: MenuOptionSetItemsApiApiKeys, value: string): void;
    accessToken: string;
    addMenuItemOptionSetItem(menuId: number, menuSectionId: number, menuSectionItemId: number, optionSetId: number, menuItemOptionSetItem: MenuItemOptionSetItemBase, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: any;
    }>;
    deleteOptionSetItemImage(menuId: number, menuSectionId: number, menuSectionItemId: number, optionSetId: number, menuItemOptionSetItemId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    getMenuItemOptionSetItemById(menuId: number, menuSectionId: number, menuSectionItemId: number, optionSetId: number, menuItemOptionSetItemId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiResultMenuItemOptionSetItem;
    }>;
    getMenuItemOptionSetItems(menuId: number, menuSectionId: number, menuSectionItemId: number, optionSetId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiArrayResultMenuItemOptionSetItem;
    }>;
    removeMenuItemOptionSetItem(menuId: number, menuSectionId: number, menuSectionItemId: number, optionSetId: number, menuItemOptionSetItemId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    updateMenuItemOptionSetItem(menuId: number, menuSectionId: number, menuSectionItemId: number, optionSetId: number, menuItemOptionSetItemId: number, menuItemOptionSetItem: MenuItemOptionSetItemBase, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    uploadOptionSetItemImage(menuId: number, menuSectionId: number, menuSectionItemId: number, optionSetId: number, menuItemOptionSetItemId: number, apiVersion: string, image: Buffer): Promise<{
        response: http.ClientResponse;
        body: RestApiStringResult;
    }>;
}
export declare enum MenuOptionSetsApiApiKeys {
}
export declare class MenuOptionSetsApi {
    protected _basePath: string;
    protected defaultHeaders: any;
    protected _useQuerystring: boolean;
    protected authentications: {
        'default': Authentication;
        'oauth2': OAuth;
    };
    constructor(basePath?: string);
    useQuerystring: boolean;
    basePath: string;
    setDefaultAuthentication(auth: Authentication): void;
    setApiKey(key: MenuOptionSetsApiApiKeys, value: string): void;
    accessToken: string;
    createMenuItemOptionSet(menuId: number, menuSectionItemId: number, menuSectionId: number, menuItemOptionSet: MenuItemOptionSetBase, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: any;
    }>;
    deleteMenuItemOptionSet(menuId: number, menuSectionItemId: number, menuSectionId: number, optionSetId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    deleteOptionSetImage(menuId: number, menuSectionId: number, menuSectionItemId: number, optionSetId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    getMenuItemOptionSetById(menuId: number, menuSectionItemId: number, menuSectionId: number, optionSetId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiResultMenuItemOptionSet;
    }>;
    getMenuItemOptionSets(menuId: number, menuSectionItemId: number, menuSectionId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiArrayResultMenuItemOptionSet;
    }>;
    updateMenuItemOptionSet(menuId: number, menuSectionItemId: number, menuSectionId: number, optionSetId: number, menuItemOptionSet: MenuItemOptionSetBase, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    uploadOptionSetImage(menuId: number, menuSectionId: number, menuSectionItemId: number, optionSetId: number, apiVersion: string, image: Buffer): Promise<{
        response: http.ClientResponse;
        body: RestApiStringResult;
    }>;
}
export declare enum MenuSectionItemsApiApiKeys {
}
export declare class MenuSectionItemsApi {
    protected _basePath: string;
    protected defaultHeaders: any;
    protected _useQuerystring: boolean;
    protected authentications: {
        'default': Authentication;
        'oauth2': OAuth;
    };
    constructor(basePath?: string);
    useQuerystring: boolean;
    basePath: string;
    setDefaultAuthentication(auth: Authentication): void;
    setApiKey(key: MenuSectionItemsApiApiKeys, value: string): void;
    accessToken: string;
    createMenuSectionItem(menuId: number, menuSectionId: number, menuSectionItem: MenuSectionItemBase, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: any;
    }>;
    deleteMenuSectionItem(menuId: number, menuSectionId: number, menuSectionItemId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    deleteMenuSectionItemImage(menuId: number, menuSectionId: number, menuSectionItemId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    getMenuItemById(menuId: number, menuSectionId: number, menuSectionItemId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiResultMenuSectionItem;
    }>;
    getMenuItems(menuId: number, menuSectionId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiArrayResultMenuSectionItem;
    }>;
    updateMenuSectionItem(menuId: number, menuSectionId: number, menuSectionItemId: number, menuSectionItem: MenuSectionItemBase, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    uploadMenuSectionItemImage(menuId: number, menuSectionId: number, menuSectionItemId: number, apiVersion: string, image: Buffer): Promise<{
        response: http.ClientResponse;
        body: RestApiStringResult;
    }>;
}
export declare enum MenuSectionsApiApiKeys {
}
export declare class MenuSectionsApi {
    protected _basePath: string;
    protected defaultHeaders: any;
    protected _useQuerystring: boolean;
    protected authentications: {
        'default': Authentication;
        'oauth2': OAuth;
    };
    constructor(basePath?: string);
    useQuerystring: boolean;
    basePath: string;
    setDefaultAuthentication(auth: Authentication): void;
    setApiKey(key: MenuSectionsApiApiKeys, value: string): void;
    accessToken: string;
    createMenuSection(menuId: number, menuSection: MenuSectionBase, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: any;
    }>;
    deleteMenuSection(menuId: number, menuSectionId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    deleteMenuSectionImage(menuId: number, menuSectionId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    getMenuSectionById(menuId: number, menuSectionId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiResultMenuSection;
    }>;
    getMenuSections(menuId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiArrayResultMenuSection;
    }>;
    updateMenuSection(menuId: number, menuSection: MenuSectionBase, apiVersion: string, menuSectionId: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    uploadMenuSectionImage(menuId: number, menuSectionId: number, apiVersion: string, image: Buffer): Promise<{
        response: http.ClientResponse;
        body: RestApiStringResult;
    }>;
}
export declare enum MenusApiApiKeys {
}
export declare class MenusApi {
    protected _basePath: string;
    protected defaultHeaders: any;
    protected _useQuerystring: boolean;
    protected authentications: {
        'default': Authentication;
        'oauth2': OAuth;
    };
    constructor(basePath?: string);
    useQuerystring: boolean;
    basePath: string;
    setDefaultAuthentication(auth: Authentication): void;
    setApiKey(key: MenusApiApiKeys, value: string): void;
    accessToken: string;
    deleteMenuItemMetadata(menuId: number, storeId: number, menuItemId: number, key: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    deleteMenuItemMetadata_1(menuId: number, storeId: number, menuItemId: number, key: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    deleteMenuSectionImage(menuId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    getMenuById(menuId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiResultMenu;
    }>;
    getMenuItemMetadata(menuId: number, storeId: number, menuItemId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiArrayResultMetadata;
    }>;
    getMenuItemOptionSetItemMetadata(menuId: number, storeId: number, optionSetItemId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiResultMetadata;
    }>;
    setMenuItemMetadata(menuId: number, storeId: number, menuItemId: number, metadata: Metadata, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    setMenuItemOptionSetItemMetadata(menuId: number, storeId: number, optionSetItemId: number, metadata: Metadata, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    uploadMenuSectionImage(menuId: number, apiVersion: string, image: Buffer): Promise<{
        response: http.ClientResponse;
        body: RestApiStringResult;
    }>;
}
export declare enum OAuthClientsApiApiKeys {
}
export declare class OAuthClientsApi {
    protected _basePath: string;
    protected defaultHeaders: any;
    protected _useQuerystring: boolean;
    protected authentications: {
        'default': Authentication;
        'oauth2': OAuth;
    };
    constructor(basePath?: string);
    useQuerystring: boolean;
    basePath: string;
    setDefaultAuthentication(auth: Authentication): void;
    setApiKey(key: OAuthClientsApiApiKeys, value: string): void;
    accessToken: string;
    addRedirectUri(oAuthClientId: string, uri: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiResultOauthClientRedirectUri;
    }>;
    createOAuthClient(oAuthClient: OAuthClient, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    deleteOAuthClient(oAuthClientId: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    getOAuthClientByClientId(clientId: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiResultOAuthClient;
    }>;
    getOAuthClientSecret(clientId: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiStringResult;
    }>;
    getOAuthClients(apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiArrayResultOAuthClient;
    }>;
    getOauthAccessToken(oAuthClientId: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiStringResult;
    }>;
    getRedirectUris(oAuthClientId: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiArrayResultOauthClientRedirectUri;
    }>;
    removeRedirectUri(oAuthClientId: string, uriId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
}
export declare enum OrdersApiApiKeys {
}
export declare class OrdersApi {
    protected _basePath: string;
    protected defaultHeaders: any;
    protected _useQuerystring: boolean;
    protected authentications: {
        'default': Authentication;
        'oauth2': OAuth;
    };
    constructor(basePath?: string);
    useQuerystring: boolean;
    basePath: string;
    setDefaultAuthentication(auth: Authentication): void;
    setApiKey(key: OrdersApiApiKeys, value: string): void;
    accessToken: string;
    acceptOrder(id: number, acceptObject: Accept, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    getOrderById(id: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiResultOrder;
    }>;
    getOrders(apiVersion: string, physicalRestaurantId?: Array<number>, state?: Array<string>, page?: number, limit?: number): Promise<{
        response: http.ClientResponse;
        body: RestApiPaginationResultOrder;
    }>;
    refundOrder(id: number, refundObject: Refund, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    rejectOrder(id: number, rejectObject: Reject, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
}
export declare enum StoresApiApiKeys {
}
export declare class StoresApi {
    protected _basePath: string;
    protected defaultHeaders: any;
    protected _useQuerystring: boolean;
    protected authentications: {
        'default': Authentication;
        'oauth2': OAuth;
    };
    constructor(basePath?: string);
    useQuerystring: boolean;
    basePath: string;
    setDefaultAuthentication(auth: Authentication): void;
    setApiKey(key: StoresApiApiKeys, value: string): void;
    accessToken: string;
    getStoreById(storeId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiResultStore;
    }>;
    getStores(apiVersion: string, searchQuery?: string, page?: number, limit?: number): Promise<{
        response: http.ClientResponse;
        body: RestApiPaginationResultStore;
    }>;
}
export declare enum UsersApiApiKeys {
}
export declare class UsersApi {
    protected _basePath: string;
    protected defaultHeaders: any;
    protected _useQuerystring: boolean;
    protected authentications: {
        'default': Authentication;
        'oauth2': OAuth;
    };
    constructor(basePath?: string);
    useQuerystring: boolean;
    basePath: string;
    setDefaultAuthentication(auth: Authentication): void;
    setApiKey(key: UsersApiApiKeys, value: string): void;
    accessToken: string;
    getRoles(apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiStringArrayResult;
    }>;
}
export declare enum VouchersApiApiKeys {
}
export declare class VouchersApi {
    protected _basePath: string;
    protected defaultHeaders: any;
    protected _useQuerystring: boolean;
    protected authentications: {
        'default': Authentication;
        'oauth2': OAuth;
    };
    constructor(basePath?: string);
    useQuerystring: boolean;
    basePath: string;
    setDefaultAuthentication(auth: Authentication): void;
    setApiKey(key: VouchersApiApiKeys, value: string): void;
    accessToken: string;
    deleteVoucherMetadata(voucherId: number, menuId: number, storeId: number, key: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiArrayResultRestApiDefaultResponse;
    }>;
    getVoucherById(voucherId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiResultVoucher;
    }>;
    getVoucherMetadata(voucherId: number, menuId: number, storeId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiArrayResultMetadata;
    }>;
    getVoucherMetadata_1(voucherId: number, menuId: number, storeId: number, key: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiResultMetadata;
    }>;
    getVouchers(apiVersion: string, filter?: string, pageNumber?: number, pageSize?: number, sortOrder?: string, orderBy?: string, subType?: string, status?: string, code?: string, validFromBegin?: Date, validFromEnd?: Date, expiryBegin?: Date, expiryEnd?: Date, amount?: number, voucherType?: string, description?: string): Promise<{
        response: http.ClientResponse;
        body: RestApiPaginationResultVoucher;
    }>;
    setVoucherMetadata(voucherId: number, menuId: number, storeId: number, key: string, value: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
}
export declare enum WebhooksApiApiKeys {
}
export declare class WebhooksApi {
    protected _basePath: string;
    protected defaultHeaders: any;
    protected _useQuerystring: boolean;
    protected authentications: {
        'default': Authentication;
        'oauth2': OAuth;
    };
    constructor(basePath?: string);
    useQuerystring: boolean;
    basePath: string;
    setDefaultAuthentication(auth: Authentication): void;
    setApiKey(key: WebhooksApiApiKeys, value: string): void;
    accessToken: string;
    craeteWebhookSubscription(clientId: string, webhookSubscription: WebhookSubscription, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiIntegerResult;
    }>;
    createWebhookSubscriptionEventNames(clientId: string, webhookSubscriptionId: number, eventName: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    deleteWebhookSubscription(clientId: string, webhookSubscriptionId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    deleteWebhookSubscriptionEventName(clientId: string, webhookSubscriptionId: number, eventName: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
    getWebhookEventNames(apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiStringArrayResult;
    }>;
    getWebhookEventNamesBySubscriptionId(clientId: string, webhookSubscriptionId: number, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiStringArrayResult;
    }>;
    getWebhookLogs(clientId: string, webhookSubscriptionId: number, start: Date, end: Date, apiVersion: string, take?: number): Promise<{
        response: http.ClientResponse;
        body: RestApiArrayResultWebhookLog;
    }>;
    getWebhookSubscriptions(clientId: string, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body: RestApiArrayResultWebhookSubscription;
    }>;
    updateWebhookSubscription(clientId: string, webhookSubscriptionId: number, webhookSubscription: WebhookSubscription, apiVersion: string): Promise<{
        response: http.ClientResponse;
        body?: any;
    }>;
}
