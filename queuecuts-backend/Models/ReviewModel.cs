namespace queuecuts_backend.Models
{
    public class ReviewModel
    {
        /// <summary>
        /// The Client's Name
        /// </summary>
        public string clientName { get; set; }

        /// <summary>
        /// Id associated with shop model 
        /// </summary>
        public string shopId { get; set; }

        /// <summary>
        /// id associated with barber model
        /// </summary>
        public string barberId { get; set; }

        /// <summary>
        /// Name of service the client recieved
        /// </summary>
        private string service { get; set; }

        /// <summary>
        /// The clients rating for the service/barber
        /// </summary>
        public int rating { get; set; }
        
        /// <summary>
        /// Date the review was written
        /// </summary>
        public DateOnly ratingDate { get; set; }

        /// <summary>
        /// review for the service/barber
        /// </summary>
        public string review { get; set; }

    }
}
