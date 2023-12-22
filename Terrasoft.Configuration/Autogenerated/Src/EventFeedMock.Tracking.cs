﻿namespace Terrasoft.Configuration.Tracking
{
    using System.Collections.Generic;

    #region Class: EventFeedMock

    /// <summary>
    /// Mock event feed response data.
    /// </summary>
    public static class EventFeedMock
    {

        #region Methods: Public

        /// <summary>
        /// Get mocked events.
        /// </summary>
        /// <returns>List of EventFeedRecord's.</returns>
        public static List<EventFeedRecord> GetEvents() {
            return new List<EventFeedRecord>(){
                new EventFeedRecord {
                        Timestamp = "2020-08-15T14:10:00.000",
                        EventType = "page-load [DEMO]",
                        EventName = "Home page",
                        EventValue = "https://example.com",
                        EventCost = "",
                        Href = "https://example.com",
                        Referrer = "https://google.com/?query_string",
                        Browser = "Chrome",
                        Platform = "Win32",
                        Languages = "en-US, fr",
                        Language = "en-US",
                        ScreenWidth = 1920,
                        ScreenHeight = 1080,
                        ScreenPixelDepth = 24,
                        ScreenColorDepth = 24,
                        ScreenAvailWidth = 1920,
                        ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:11:00.000",
                    EventType = "page-load [DEMO]",
                    EventName = "Smartphones",
                    EventValue = "https://example.com/smartphones",
                    EventCost = "",
                    Href = "https://example.com/smartphones",
                    Referrer = "https://example.com",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:12:00.000",
                    EventType = "page-load [DEMO]",
                    EventName = "Laptops",
                    EventValue = "https://example.com/laptops",
                    EventCost = "",
                    Href = "https://example.com/laptops",
                    Referrer = "https://example.com/smartphones",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:13:00.000",
                    EventType = "search [DEMO]",
                    EventName = "Suggestion search",
                    EventValue = "Gigabook model ",
                    EventCost = "",
                    Href = "https://example.com/laptops",
                    Referrer = "https://example.com/smartphones",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:14:00.000",
                    EventType = "view_item [DEMO]",
                    EventName = "Laptop Gigabook model 100",
                    EventValue = "In category",
                    EventCost = "",
                    Href = "https://example.com/laptops",
                    Referrer = "https://example.com/smartphones",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:15:00.000",
                    EventType = "view_item [DEMO]",
                    EventName = "Laptop Gigabook model 200",
                    EventValue = "In category",
                    EventCost = "",
                    Href = "https://example.com/laptops",
                    Referrer = "https://example.com/smartphones",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:16:00.000",
                    EventType = "view_item [DEMO]",
                    EventName = "Laptop Gigabook model 300",
                    EventValue = "In category",
                    EventCost = "",
                    Href = "https://example.com/laptops",
                    Referrer = "https://example.com/smartphones",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:17:00.000",
                    EventType = "add_to_basket [DEMO]",
                    EventName = "Laptop Gigabook model 200",
                    EventValue = "In category",
                    EventCost = "850",
                    Href = "https://example.com/laptops",
                    Referrer = "https://example.com/smartphones",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:18:00.000",
                    EventType = "page-load [DEMO]",
                    EventName = "Shopping cart",
                    EventValue = "https://example.com/cart",
                    EventCost = "",
                    Href = "https://example.com/cart",
                    Referrer = "https://example.com/laptops",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:19:00.000",
                    EventType = "remove_from_cart [DEMO]",
                    EventName = "Laptop Gigabook model 200",
                    EventValue = "1",
                    EventCost = "850",
                    Href = "https://example.com/cart",
                    Referrer = "https://example.com/laptops",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:20:00.000",
                    EventType = "page-load [DEMO]",
                    EventName = "Laptops",
                    EventValue = "https://example.com/laptops",
                    EventCost = "",
                    Href = "https://example.com/laptops",
                    Referrer = "https://example.com/cart",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:21:00.000",
                    EventType = "view_item [DEMO]",
                    EventName = "Laptop Gigabook model 300",
                    EventValue = "In category",
                    EventCost = "",
                    Href = "https://example.com/laptops",
                    Referrer = "https://example.com/cart",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:22:00.000",
                    EventType = "add_to_basket [DEMO]",
                    EventName = "Laptop Gigabook model 300",
                    EventValue = "1",
                    EventCost = "1150",
                    Href = "https://example.com/laptops",
                    Referrer = "https://example.com/cart",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:23:00.000",
                    EventType = "start_checkout [DEMO]",
                    EventName = "Checkout process are starting",
                    EventValue = "https://example.com/checkout",
                    EventCost = "",
                    Href = "https://example.com/checkout",
                    Referrer = "https://example.com/laptops",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:24:00.000",
                    EventType = "add_payment_info [DEMO]",
                    EventName = "Payment details added",
                    EventValue = "credit card (vendor name)",
                    EventCost = "",
                    Href = "https://example.com/checkout",
                    Referrer = "https://example.com/laptops",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-15T14:25:00.000",
                    EventType = "complete_checkout [DEMO]",
                    EventName = "Complete order",
                    EventValue = "https://example.com/checkout",
                    EventCost = "1150",
                    Href = "https://example.com/checkout",
                    Referrer = "https://example.com/laptops",
                    Browser = "Chrome",
                    Platform = "Win32",
                    Languages = "en-US, fr",
                    Language = "en-US",
                    ScreenWidth = 1920,
                    ScreenHeight = 1080,
                    ScreenPixelDepth = 24,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 1920,
                    ScreenAvailHeight = 1050

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-17T09:31:00.000",
                    EventType = "page-load [DEMO]",
                    EventName = "Exhibition Center home page",
                    EventValue = "https://example-center1.com",
                    EventCost = "",
                    Href = "https://example-center1.com",
                    Referrer = "https://google.com/?query_string",
                    Browser = "Safari",
                    Platform = "MacIntel",
                    Languages = "ja-JP, br",
                    Language = "ja-JP",
                    ScreenWidth = 2560,
                    ScreenHeight = 1600,
                    ScreenPixelDepth = 64,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 2560,
                    ScreenAvailHeight = 1600

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-17T09:32:00.000",
                    EventType = "page-load [DEMO]",
                    EventName = "Exhibition Services Plans",
                    EventValue = "https://example-center1.com/plans",
                    EventCost = "",
                    Href = "https://example-center1.com/plans",
                    Referrer = "https://example-center1.com",
                    Browser = "Safari",
                    Platform = "MacIntel",
                    Languages = "ja-JP, br",
                    Language = "ja-JP",
                    ScreenWidth = 2560,
                    ScreenHeight = 1600,
                    ScreenPixelDepth = 64,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 2560,
                    ScreenAvailHeight = 1600

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-17T09:33:00.000",
                    EventType = "view_item [DEMO]",
                    EventName = "Service Plan \"Medium\"",
                    EventValue = "At the list of services",
                    EventCost = "",
                    Href = "https://example-center1.com/plans",
                    Referrer = "https://example-center1.com",
                    Browser = "Safari",
                    Platform = "MacIntel",
                    Languages = "ja-JP, br",
                    Language = "ja-JP",
                    ScreenWidth = 2560,
                    ScreenHeight = 1600,
                    ScreenPixelDepth = 64,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 2560,
                    ScreenAvailHeight = 1600

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-17T09:34:00.000",
                    EventType = "view_item [DEMO]",
                    EventName = "Service Plan \"Starter\"",
                    EventValue = "At the list of services",
                    EventCost = "",
                    Href = "https://example-center1.com/plans",
                    Referrer = "https://example-center1.com",
                    Browser = "Safari",
                    Platform = "MacIntel",
                    Languages = "ja-JP, br",
                    Language = "ja-JP",
                    ScreenWidth = 2560,
                    ScreenHeight = 1600,
                    ScreenPixelDepth = 64,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 2560,
                    ScreenAvailHeight = 1600

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-17T09:35:00.000",
                    EventType = "view_item [DEMO]",
                    EventName = "Service Plan \"Premium\"",
                    EventValue = "At the list of services",
                    EventCost = "",
                    Href = "https://example-center1.com/plans",
                    Referrer = "https://example-center1.com",
                    Browser = "Safari",
                    Platform = "MacIntel",
                    Languages = "ja-JP, br",
                    Language = "ja-JP",
                    ScreenWidth = 2560,
                    ScreenHeight = 1600,
                    ScreenPixelDepth = 64,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 2560,
                    ScreenAvailHeight = 1600

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-17T09:36:00.000",
                    EventType = "fill_field [DEMO]",
                    EventName = "field \"Budget\"",
                    EventValue = "150",
                    EventCost = "",
                    Href = "https://example-center1.com/plans",
                    Referrer = "https://example-center1.com",
                    Browser = "Safari",
                    Platform = "MacIntel",
                    Languages = "ja-JP, br",
                    Language = "ja-JP",
                    ScreenWidth = 2560,
                    ScreenHeight = 1600,
                    ScreenPixelDepth = 64,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 2560,
                    ScreenAvailHeight = 1600

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-17T09:37:00.000",
                    EventType = "change_field [DEMO]",
                    EventName = "field \"Budget\"",
                    EventValue = "450",
                    EventCost = "",
                    Href = "https://example-center1.com/plans",
                    Referrer = "https://example-center1.com",
                    Browser = "Safari",
                    Platform = "MacIntel",
                    Languages = "ja-JP, br",
                    Language = "ja-JP",
                    ScreenWidth = 2560,
                    ScreenHeight = 1600,
                    ScreenPixelDepth = 64,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 2560,
                    ScreenAvailHeight = 1600

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-17T09:38:00.000",
                    EventType = "fill_field [DEMO]",
                    EventName = "field \"Name\"",
                    EventValue = "Peter Lord",
                    EventCost = "",
                    Href = "https://example-center1.com/plans",
                    Referrer = "https://example-center1.com",
                    Browser = "Safari",
                    Platform = "MacIntel",
                    Languages = "ja-JP, br",
                    Language = "ja-JP",
                    ScreenWidth = 2560,
                    ScreenHeight = 1600,
                    ScreenPixelDepth = 64,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 2560,
                    ScreenAvailHeight = 1600

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-17T09:39:00.000",
                    EventType = "fill_field [DEMO]",
                    EventName = "field \"Email\"",
                    EventValue = "peter.lord@1goodcompany.com",
                    EventCost = "",
                    Href = "https://example-center1.com/plans",
                    Referrer = "https://example-center1.com",
                    Browser = "Safari",
                    Platform = "MacIntel",
                    Languages = "ja-JP, br",
                    Language = "ja-JP",
                    ScreenWidth = 2560,
                    ScreenHeight = 1600,
                    ScreenPixelDepth = 64,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 2560,
                    ScreenAvailHeight = 1600

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-17T09:40:00.000",
                    EventType = "send_form [DEMO]",
                    EventName = "Service Plan Order form",
                    EventValue = "",
                    EventCost = "",
                    Href = "https://example-center1.com/plans",
                    Referrer = "https://example-center1.com",
                    Browser = "Safari",
                    Platform = "MacIntel",
                    Languages = "ja-JP, br",
                    Language = "ja-JP",
                    ScreenWidth = 2560,
                    ScreenHeight = 1600,
                    ScreenPixelDepth = 64,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 2560,
                    ScreenAvailHeight = 1600

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-17T09:41:00.000",
                    EventType = "complete_registration [DEMO]",
                    EventName = "Plan \"Premium\" is ordered",
                    EventValue = "",
                    EventCost = "500",
                    Href = "https://example-center1.com/confirmation",
                    Referrer = "https://example-center1.com/plans",
                    Browser = "Safari",
                    Platform = "MacIntel",
                    Languages = "ja-JP, br",
                    Language = "ja-JP",
                    ScreenWidth = 2560,
                    ScreenHeight = 1600,
                    ScreenPixelDepth = 64,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 2560,
                    ScreenAvailHeight = 1600

                },
                new EventFeedRecord {
                    Timestamp = "2020-08-17T09:42:00.000",
                    EventType = "download_file [DEMO]",
                    EventName = "Guide for customer",
                    EventValue = "guide_for_customers.pdf",
                    EventCost = "",
                    Href = "https://example-center1.com/confirmation",
                    Referrer = "https://example-center1.com/plans",
                    Browser = "Safari",
                    Platform = "MacIntel",
                    Languages = "ja-JP, br",
                    Language = "ja-JP",
                    ScreenWidth = 2560,
                    ScreenHeight = 1600,
                    ScreenPixelDepth = 64,
                    ScreenColorDepth = 24,
                    ScreenAvailWidth = 2560,
                    ScreenAvailHeight = 1600
                }
            };
        }
        
        #endregion
    }

    #endregion
}













