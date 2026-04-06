using AdonetDisconnectedorientedexampleWith3databases.Models;

namespace AdonetDisconnectedorientedexampleWith3databases.Interfaces
{
    public interface IRestaurantRepository
    {//in repository we used model classes.
        Task<bool> AddRestaurant(Restaurant Objres);
        Task<bool> UpdateRestaurant(Restaurant Objres);
        Task<bool> DeleteRestaurant(int Id);
        Task<List<Restaurant>> GetallRestaurants();
        Task<Restaurant> GetRestaurantById(int Id);
    }
}
