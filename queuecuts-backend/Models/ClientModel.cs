namespace queuecuts_backend.Models
{
    public class ClientModel
    {
        /// <summary>
        /// client's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// client's email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// client's phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// client's favorite barbers
        /// </summary>
        public HashSet<BarberModel> FavoriteBarbers { get; set; }
    }
}
