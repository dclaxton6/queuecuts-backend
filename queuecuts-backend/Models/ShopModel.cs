namespace queuecuts_backend.Models
{
    public class ShopModel
    {
        /// <summary>
        /// shop id
        /// </summary>
        public int shopId { get; set; }

        /// <summary>
        /// The shop name
        /// </summary>
        public string shopName { get; set; }

        /// <summary>
        /// Contains all barbers associated with shop
        /// </summary>
        public HashSet<BarberModel> Barbers { get; set; }

        /// <summary>
        /// Contains reviews for all barbers within shop
        /// </summary>
        public HashSet<ReviewModel> Reviews { get; set; }

        /// <summary>
        /// Contains all service provided by barbers in the shop
        /// </summary>
        // public HashSet<Services> { get; set; }
    }
}
