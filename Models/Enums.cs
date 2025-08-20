namespace AmadeusIntegration.Models.Enums
{
        
        public enum EOtherPaymentMethod
    {
        ACCOUNT, 
        CHECK,
        CASH,
        NONREFUNDABLE
    }
        public enum  EWeightUnits
        {
        // Weight units used in CO2 emissions
        //still need to figure out what else is used 
        KG
            
        }
        public enum EFlightOfferSource
        {
            GDS
        }
        public enum EGender
        {
            MALE,
            FEMALE,
            UNSPECIFIED,
            UNDISCLOSED
        }
    /// <summary>
    /// traveler type
    /// age restrictions : CHILD < 12y, HELD_INFANT < 2y, SEATED_INFANT < 2y, SENIOR >=60y
    /// </summary>
    public enum ETravelerType
        {

    
            ADULT,
            CHILD,
            SENIOR,
            YOUNG,
            HELD_INFANT,
            SEATED_INFANT,
            STUDENT
        }
        public enum EPhoneDeviceType
        {
            MOBILE,
            LANDLINE,
            FAX
        }
        public enum EFeeType
        {
            TICKETING,
            FORM_OF_PAYMENT,
            SUPPLIER
        }
        public enum EAdditionalServiceType
        {
            CHECKED_BAGS,
            MEALS,
            SEATS,
            OTHER_SERVICES
        }
        public enum ETravelClassType
        {
            ECONOMY,
            PREMIUM_ECONOMY,
            BUSINESS,
            FIRST
        }
       
        public enum EPricingOptionsFareType
        {
        PUBLISHED, 
        NEGOTIATED, 
        CORPORATE
    }
        public enum EFareOption
        {
            STANDARD,
            INCLUSIVE_TOUR,
            SPANISH_MELILLA_RESIDENT,
            SPANISH_CEUTA_RESIDENT,
            SPANISH_CANARY_RESIDENT,
            SPANISH_BALEARIC_RESIDENT,
            AIR_FRANCE_METROPOLITAN_DISCOUNT_PASS,
            AIR_FRANCE_DOM_DISCOUNT_PASS,
            AIR_FRANCE_COMBINED_DISCOUNT_PASS,
            AIR_FRANCE_FAMILY,
            ADULT_WITH_COMPANION,
            COMPANION
        }
        public enum ESliceAndDiceIndicator
        {
            LOCAL_AVAILABILITY,
            SUB_OD_AVAILABILITY_1,
            SUB_OD_AVAILABILITY_2
        }
        public enum EServiceName
        {
            PRIORITY_BOARDING,
            AIRPORT_CHECKIN
        }
        public enum EDocumentType
        {
            VISA,
            PASSPORT,
            IDENTITY_CARD,
            KNOWN_TRAVELER,
            REDRESS
        }
        public enum EIdentificationType
        {
            DRIVERS_LICENSE,
            PASSPORT,
            NATIONAL_IDENTITY_CARD,
            BOOKING_CONFIRMATION,
            TICKET,
            OTHER_ID
        }
        public enum EDiscountType
        {
            SPANISH_RESIDENT,
            AIR_FRANCE_DOMESTIC,
            AIR_FRANCE_COMBINED,
            AIR_FRANCE_METROPOLITAN
        }
        public enum DiscountTravelerType
        {  
        SPANISH_CITIZEN,
        EUROPEAN_CITIZEN, 
        GOVERNMENT_WORKER, 
        MILITARY,
        MINOR_WITHOUT_ID
        }

        public enum EContactPurpose
        {
            STANDARD,
            INVOICE,
            STANDARD_WITHOUT_TRANSMISSION
        }
        public enum ETicketingAgreementOption
        {
            CONFIRM,
            DELAY_TO_QUEUE,
            DELAY_TO_CANCEL
        }
    public enum EGeneralRemarkType
    {
        GENERAL_MISCELLANEOUS, 
        CONFIDENTIAL,
        INVOICE, 
        QUALITY_CONTROL,
        BACKOFFICE,
        FULFILLMENT,
        ITINERARY, 
        TICKETING_MISCELLANEOUS, 
        TOUR_CODE
    }
    public enum EAirlineRemarkType
    {
        OTHER_SERVICE_INFORMATION,
        KEYWORD,
        OTHER_SERVICE,
        CLIENT_ID,
        ADVANCED_TICKET_TIME_LIMIT

    }
    public enum EAutomatedProcessCode
    {
        IMMEDIATE,
        DELAYED,
        ERROR
    }
    public enum ECreditCardBrand
    {
        VISA,
        AMERICAN_EXPRESS,
        MASTERCARD,
        VISA_ELECTRON,
        VISA_DEBIT, 
        MASTERCARD_DEBIT,
        MAESTRO,
        DINERS, 
        EASYPAY
    }
    public enum EPaymentBrand
    {
        VISA, 
        AMERICAN_EXPRESS,
        MASTERCARD,
        VISA_ELECTRON, 
        VISA_DEBIT,
        MASTERCARD_DEBIT, 
        MAESTRO, 
        DINERS, 
        MASTERCARD_IXARIS, 
        VISA_IXARIS, 
        MASTERCARD_AIRPLUS, 
        UATP_AIRPLUS
    }
    public enum  EDocumentStatus
    {
        ISSUED,
        REFUNDED,
        VOID,
        ORIGINAL,
        EXCHANGED

    }
    public enum EInclude
    {
        credit_card_fees,
        bags,
        other_services,
        detailed_fareRules
    }
    public enum EModificationType
    {
        REFUND,
        EXCHANGE,
        REVALIDATION,
        REISSUE,
        REBOOK, 
        CANCELLATION
    }

}

    