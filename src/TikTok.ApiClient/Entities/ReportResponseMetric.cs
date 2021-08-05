﻿using Newtonsoft.Json;

namespace TikTok.ApiClient.Entities
{
    /// <summary>
    /// Contain report metrics available at TikTok Reporting endpoint.
    /// See <a href="https://ads.tiktok.com/marketing_api/docs?id=1701890951192578"></a>
    /// </summary>
    public class ReportResponseMetric : IApiEntity
    {
        [JsonProperty("total_add_payment_info")]
        public string TotalAddPaymentInfo { get; set; }

        [JsonProperty("total_in_app_ad_click")]
        public string TotalInAppAdClick { get; set; }

        [JsonProperty("total_unlock_achievement_value")]
        public string TotalUnlockAchievementValue { get; set; }

        [JsonProperty("sales_lead")]
        public string SalesLead { get; set; }

        [JsonProperty("comments")] 
        public string Comments { get; set; }

        [JsonProperty("add_payment_info")] 
        public string AddPaymentInfo { get; set; }

        [JsonProperty("total_add_to_wishlist_value")]
        public string TotalAddToWishlistValue { get; set; }

        [JsonProperty("product_details_page_browse")]
        public string ProductDetailsPageBrowse { get; set; }

        [JsonProperty("total_loan_credit")] 
        public string TotalLoanCredit { get; set; }

        [JsonProperty("total_next_day_open")] 
        public string TotalNextDayOpen { get; set; }

        [JsonProperty("total_in_app_ad_click_value")]
        public string TotalInAppAdClickValue { get; set; }

        [JsonProperty("total_user_registration_value")]
        public string TotalUserRegistrationValue { get; set; }

        [JsonProperty("web_event_add_to_cart")]
        public string WebEventAddToCart { get; set; }

        [JsonProperty("total_create_gamerole")]
        public string TotalCreateGamerole { get; set; }

        [JsonProperty("tt_app_name")] 
        public string TtAppName { get; set; }

        [JsonProperty("total_complete_tutorial")]
        public string TotalCompleteTutorial { get; set; }

        [JsonProperty("loan_credit")] 
        public string LoanCredit { get; set; }

        [JsonProperty("user_registration")] 
        public string UserRegistration { get; set; }

        [JsonProperty("loan_disbursement")] 
        public string LoanDisbursement { get; set; }

        [JsonProperty("ad_text")] 
        public string AdText { get; set; }

        [JsonProperty("total_launch_app")] 
        public string TotalLaunchApp { get; set; }

        [JsonProperty("app_event_add_to_cart")]
        public string AppEventAddToCart { get; set; }

        [JsonProperty("ad_name")] 
        public string AdName { get; set; }

        [JsonProperty("total_purchase")] 
        public string TotalPurchase { get; set; }

        [JsonProperty("complete_payment")] 
        public string CompletePayment { get; set; }

        [JsonProperty("total_create_gamerole_value")]
        public string TotalCreateGameroleValue { get; set; }

        [JsonProperty("total_form_detail_value")]
        public string TotalFormDetailValue { get; set; }

        [JsonProperty("complete_payment_roas")]
        public string CompletePaymentRoas { get; set; }

        [JsonProperty("video_watched_6s")] 
        public string VideoWatched6s { get; set; }

        [JsonProperty("follows")] 
        public string Follows { get; set; }

        [JsonProperty("secondary_goal_result")]
        public string SecondaryGoalResult { get; set; }

        [JsonProperty("total_product_details_page_browse_value")]
        public string TotalProductDetailsPageBrowseValue { get; set; }

        [JsonProperty("next_day_open")] 
        public string NextDayOpen { get; set; }

        [JsonProperty("total_online_consult_value")]
        public string TotalOnlineConsultValue { get; set; }

        [JsonProperty("button_click")] 
        public string ButtonClick { get; set; }

        [JsonProperty("total_active_pay_roas")]
        public string TotalActivePayRoas { get; set; }

        [JsonProperty("mobile_app_id")] 
        public string MobileAppId { get; set; }

        [JsonProperty("total_download_start_value")]
        public string TotalDownloadStartValue { get; set; }

        [JsonProperty("campaign_id")] 
        public long CampaignId { get; set; }

        [JsonProperty("profile_visits")] public string ProfileVisits { get; set; }

        [JsonProperty("total_join_group")] public string TotalJoinGroup { get; set; }

        [JsonProperty("total_checkout_value")] public string TotalCheckoutValue { get; set; }

        [JsonProperty("result")] public string Result { get; set; }

        [JsonProperty("campaign_name")] public string CampaignName { get; set; }

        [JsonProperty("impressions")] public string Impressions { get; set; }

        [JsonProperty("spend_credits")] public string SpendCredits { get; set; }

        [JsonProperty("adgroup_id")] public long AdgroupId { get; set; }

        [JsonProperty("total_unlock_achievement")]
        public string TotalUnlockAchievement { get; set; }

        [JsonProperty("total_in_app_ad_impr")] public string TotalInAppAdImpr { get; set; }

        [JsonProperty("total_in_app_ad_impr_value")]
        public string TotalInAppAdImprValue { get; set; }

        [JsonProperty("shares")] public string Shares { get; set; }

        [JsonProperty("total_achieve_level_value")]
        public string TotalAchieveLevelValue { get; set; }

        [JsonProperty("initiate_checkout")] 
        public string InitiateCheckout { get; set; }

        [JsonProperty("total_sales_lead_value")]
        public string TotalSalesLeadValue { get; set; }

        [JsonProperty("total_create_group_value")]
        public string TotalCreateGroupValue { get; set; }

        [JsonProperty("download_start")] 
        public string DownloadStart { get; set; }

        [JsonProperty("create_group")] 
        public string CreateGroup { get; set; }

        [JsonProperty("total_add_to_wishlist")]
        public string TotalAddToWishlist { get; set; }

        [JsonProperty("video_views_p25")] 
        public string VideoViewsP25 { get; set; }

        [JsonProperty("form_button")] 
        public string FormButton { get; set; }

        [JsonProperty("total_spend_credits")] 
        public string TotalSpendCredits { get; set; }

        [JsonProperty("join_group")] 
        public string JoinGroup { get; set; }

        [JsonProperty("total_subscribe_value")]
        public string TotalSubscribeValue { get; set; }

        [JsonProperty("search")] public string Search { get; set; }

        [JsonProperty("total_on_web_order_value")]
        public string TotalOnWebOrderValue { get; set; }

        [JsonProperty("total_achieve_level")] public string TotalAchieveLevel { get; set; }

        [JsonProperty("in_app_ad_click")] public string InAppAdClick { get; set; }

        [JsonProperty("total_view_content")] public string TotalViewContent { get; set; }

        [JsonProperty("real_time_conversion")] public string RealTimeConversion { get; set; }

        [JsonProperty("total_form_value")] public string TotalFormValue { get; set; }

        [JsonProperty("total_view_content_value")]
        public string TotalViewContentValue { get; set; }

        [JsonProperty("login")] public string Login { get; set; }

        [JsonProperty("total_sales_lead")] public string TotalSalesLead { get; set; }

        [JsonProperty("loan_apply")] public string LoanApply { get; set; }

        [JsonProperty("online_consult")] public string OnlineConsult { get; set; }

        [JsonProperty("download_button")] public string DownloadButton { get; set; }

        [JsonProperty("on_web_order")] public string OnWebOrder { get; set; }

        [JsonProperty("total_search")] public string TotalSearch { get; set; }

        [JsonProperty("subscribe")] public string Subscribe { get; set; }

        [JsonProperty("likes")] public string Likes { get; set; }

        [JsonProperty("registration")] public string Registration { get; set; }

        [JsonProperty("real_time_app_install")]
        public string RealTimeAppInstall { get; set; }

        [JsonProperty("create_gamerole")] public string CreateGamerole { get; set; }

        [JsonProperty("total_loan_apply")] public string TotalLoanApply { get; set; }

        [JsonProperty("real_time_result")] public string RealTimeResult { get; set; }

        [JsonProperty("button_click_consultation")]
        public string ButtonClickConsultation { get; set; }

        [JsonProperty("total_form_button_value")]
        public string TotalFormButtonValue { get; set; }

        [JsonProperty("video_views_p100")] public string VideoViewsP100 { get; set; }

        [JsonProperty("total_start_trial")] public string TotalStartTrial { get; set; }

        [JsonProperty("total_web_event_add_to_cart_value")]
        public string TotalWebEventAddToCartValue { get; set; }

        [JsonProperty("consultation")] public string Consultation { get; set; }

        [JsonProperty("page_event_search")] public string PageEventSearch { get; set; }

        [JsonProperty("total_consultation_value")]
        public string TotalConsultationValue { get; set; }

        [JsonProperty("total_create_group")] public string TotalCreateGroup { get; set; }

        [JsonProperty("checkout")] public string Checkout { get; set; }

        [JsonProperty("total_app_event_add_to_cart")]
        public string TotalAppEventAddToCart { get; set; }

        [JsonProperty("average_video_play")] public string AverageVideoPlay { get; set; }

        [JsonProperty("app_install")] public string AppInstall { get; set; }

        [JsonProperty("total_checkout")] public string TotalCheckout { get; set; }

        [JsonProperty("total_spend_credits_value")]
        public string TotalSpendCreditsValue { get; set; }

        [JsonProperty("download_detail")] public string DownloadDetail { get; set; }

        [JsonProperty("total_app_event_add_to_cart_value")]
        public string TotalAppEventAddToCartValue { get; set; }

        [JsonProperty("total_button_click_consultation_value")]
        public string TotalButtonClickConsultationValue { get; set; }

        [JsonProperty("total_download_detail_value")]
        public string TotalDownloadDetailValue { get; set; }

        [JsonProperty("video_watched_2s")] public string VideoWatched2s { get; set; }

        [JsonProperty("total_page_browse_view_value")]
        public string TotalPageBrowseViewValue { get; set; }

        [JsonProperty("unlock_achievement")] public string UnlockAchievement { get; set; }

        [JsonProperty("real_time_app_install_cost")]
        public string RealTimeAppInstallCost { get; set; }

        [JsonProperty("add_to_wishlist")] public string AddToWishlist { get; set; }

        [JsonProperty("page_browse_consultation")]
        public string PageBrowseConsultation { get; set; }

        [JsonProperty("total_page_browse_consultation_value")]
        public string TotalPageBrowseConsultationValue { get; set; }

        [JsonProperty("video_play_actions")] public string VideoPlayActions { get; set; }

        [JsonProperty("total_purchase_value")] public string TotalPurchaseValue { get; set; }

        [JsonProperty("video_views_p75")] public string VideoViewsP75 { get; set; }

        [JsonProperty("form_detail")] public string FormDetail { get; set; }

        [JsonProperty("conversion")] public string Conversion { get; set; }

        [JsonProperty("form")] public string Form { get; set; }

        [JsonProperty("total_button_click_value")]
        public string TotalButtonClickValue { get; set; }

        [JsonProperty("total_join_group_value")]
        public string TotalJoinGroupValue { get; set; }

        [JsonProperty("adgroup_name")] public string AdgroupName { get; set; }

        [JsonProperty("total_login")] public string TotalLogin { get; set; }

        [JsonProperty("tt_app_id")] public string TtAppId { get; set; }

        [JsonProperty("complete_tutorial")] public string CompleteTutorial { get; set; }

        [JsonProperty("video_views_p50")] public string VideoViewsP50 { get; set; }

        [JsonProperty("total_complete_tutorial_value")]
        public string TotalCompleteTutorialValue { get; set; }

        [JsonProperty("total_page_event_search_value")]
        public string TotalPageEventSearchValue { get; set; }

        [JsonProperty("clicks")] public string Clicks { get; set; }

        [JsonProperty("total_add_billing_value")]
        public string TotalAddBillingValue { get; set; }

        [JsonProperty("total_subscribe")] public string TotalSubscribe { get; set; }

        [JsonProperty("total_initiate_checkout_value")]
        public string TotalInitiateCheckoutValue { get; set; }

        [JsonProperty("reach")] public string Reach { get; set; }

        [JsonProperty("page_browse_view")] public string PageBrowseView { get; set; }

        [JsonProperty("launch_app")] public string LaunchApp { get; set; }

        [JsonProperty("add_billing")] public string AddBilling { get; set; }

        [JsonProperty("start_trial")] public string StartTrial { get; set; }

        [JsonProperty("total_download_button_value")]
        public string TotalDownloadButtonValue { get; set; }

        [JsonProperty("in_app_ad_impr")] public string InAppAdImpr { get; set; }

        [JsonProperty("purchase")] public string Purchase { get; set; }

        [JsonProperty("total_loan_disbursement")]
        public string TotalLoanDisbursement { get; set; }

        [JsonProperty("view_content")] public string ViewContent { get; set; }

        [JsonProperty("achieve_level")] public string AchieveLevel { get; set; }

        [JsonProperty("total_registration")] public string TotalRegistration { get; set; }

        [JsonProperty("spend")] public string Spend { get; set; }
    }
}