namespace queuecuts_backend.Models
{
    public class BarberModel
    {
        /// <summary>
        /// barber's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Contain client's who have favorited this barber
        /// </summary>
        public HashSet<ClientModel> Clients { get; set; }



    }
}
