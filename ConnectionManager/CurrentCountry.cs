using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ConnectionManager
{
    public static class CurrentCountry
    {
        #region Local variables
        static string __CountryCode;
        static string __CountryName;
        static string __UPSDrive;
        static string __PhoneNo;
        static string __PurolatorDrive;
        static bool __IsSage;
        #endregion

        #region Property
        public static string CountryCode
        {
            get
            {
                return __CountryCode;
            }
            set
            {
                __CountryCode = value;
            }
        }

        public static string CountryName
        {
            get
            {
                return __CountryName;
            }
            set
            {
                __CountryName = value;
            }
        }

        public static string UPSDrive
        {
            get
            {
                return __UPSDrive;
            }
            set
            {
                __UPSDrive = value;
            }
        }

        public static string PurolatorDrive
        {
            get
            {
                return __PurolatorDrive;
            }
            set
            {
                __PurolatorDrive = value;
            }
        }

        public static bool IsSage
        {
            get
            {
                return __IsSage;
            }
            set
            {
                __IsSage = value;
            }
        }

        public static string PhoneNo
        {
            get
            {
                return __PhoneNo;
            }
            set
            {
                __PhoneNo = value;
            }
        }
        #endregion

        //#region Methods
        //private static void SetUPSDrive()
        //{
        //    if (__CountryCode == "GB" || __CountryCode == "TA" || __CountryCode == "BH") __UPSDrive = @"J:\";
        //    else if (__CountryCode == "US") __UPSDrive = @"U:\";
        //    else if (__CountryCode == "DE") __UPSDrive = @"U:\";
        //    else if (__CountryCode == "MX") __UPSDrive = @"J:\";

        //    else if (__CountryCode == "NL") __UPSDrive = @"U:\";
        //    else if (__CountryCode == "PL") __UPSDrive = @"U:\";
        //    else if (__CountryCode == "FR") __UPSDrive = @"U:\";
        //    else if (__CountryCode == "TR") __UPSDrive = @"U:\";
        //    else if (__CountryCode == "IT") __UPSDrive = @"U:\";
        //    else if (__CountryCode == "CA") __UPSDrive = @"J:\";
        //    else if (__CountryCode == "ES") __UPSDrive = @"U:\";
        //}

        //private static void SetPhoneNo()
        //{
        //    if (__CountryCode == "GB" || CountryCode == "TA") __PhoneNo = "+44 1634 687 222";
        //    else if (__CountryCode == "BH") __PhoneNo = "+44 20 8748 6593";
        //    else if (__CountryCode == "US") __PhoneNo = "+1 508 822 4490";
        //    else if (__CountryCode == "DE") __PhoneNo = "+49 40 42 94 73 70";
        //    else if (__CountryCode == "MX") __PhoneNo = "+52(686) 561 9556";
        //    else if (__CountryCode == "NL") __PhoneNo = "+31 30 2625262";
        //    else if (__CountryCode == "PL") __PhoneNo = "+0048124105095";
        //    else if (__CountryCode == "FR") __PhoneNo = "+33 491754270";
        //    else if (__CountryCode == "TR") __PhoneNo = "00905323584358";
        //    else if (__CountryCode == "IT") __PhoneNo = "+39 02 9318 5004";
        //    else if (__CountryCode == "CA") __PhoneNo = "+1 508 822 4490";
        //    else if (__CountryCode == "ES") __PhoneNo = "+34 934 809 679";
        //}
        //#endregion
    }
}
