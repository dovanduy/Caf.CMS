using CAF.WebSite.Domain.Seedwork.Shop.Orders;
using CAF.WebSite.Domain.Seedwork.Users;
using System;
using System.Collections.Generic;
 

namespace CAF.WebSite.Application.Services.Orders
{
    /// <summary>
    /// Gift card service interface
    /// </summary>
    public partial interface IGiftCardService
    {
        /// <summary>
        /// Deletes a gift card
        /// </summary>
        /// <param name="giftCard">Gift card</param>
        void DeleteGiftCard(GiftCard giftCard);

        /// <summary>
        /// Gets a gift card
        /// </summary>
        /// <param name="giftCardId">Gift card identifier</param>
        /// <returns>Gift card entry</returns>
        GiftCard GetGiftCardById(int giftCardId);

        /// <summary>
        /// Gets all gift cards
        /// </summary>
        /// <param name="purchasedWithOrderId">Associated order ID; null to load all records</param>
        /// <param name="startTime">Order start time; null to load all records</param>
        /// <param name="endTime">Order end time; null to load all records</param>
        /// <param name="isGiftCardActivated">Value indicating whether gift card is activated; null to load all records</param>
        /// <param name="giftCardCouponCode">Gift card coupon code; null or string.empty to load all records</param>
        /// <returns>Gift cards</returns>
        IList<GiftCard> GetAllGiftCards(int? purchasedWithOrderId, DateTime? startTime = null, DateTime? endTime = null,
            bool? isGiftCardActivated = null, string giftCardCouponCode = "");

        /// <summary>
        /// Inserts a gift card
        /// </summary>
        /// <param name="giftCard">Gift card</param>
        void InsertGiftCard(GiftCard giftCard);

        /// <summary>
        /// Updates the gift card
        /// </summary>
        /// <param name="giftCard">Gift card</param>
        void UpdateGiftCard(GiftCard giftCard);

        /// <summary>
        /// Gets gift cards by 'PurchasedWithOrderItemId'
        /// </summary>
        /// <param name="purchasedWithOrderItemId">Purchased with order item identifier</param>
        /// <returns>Gift card entries</returns>
        IList<GiftCard> GetGiftCardsByPurchasedWithOrderItemId(int purchasedWithOrderItemId);
        
        /// <summary>
        /// Get active gift cards that are applied by a user
        /// </summary>
        /// <param name="user">User</param>
        /// <returns>Active gift cards</returns>
        IList<GiftCard> GetActiveGiftCardsAppliedByUser(User user);

        /// <summary>
        /// Generate new gift card code
        /// </summary>
        /// <returns>Result</returns>
        string GenerateGiftCardCode();
    }
}
