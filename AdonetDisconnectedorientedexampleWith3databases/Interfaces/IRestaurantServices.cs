using AdonetDisconnectedorientedexampleWith3databases.Dtos;
using AdonetDisconnectedorientedexampleWith3databases.Models;

namespace AdonetDisconnectedorientedexampleWith3databases.Interfaces
{
    public interface IRestaurantServices
    {//in services we used Dto classes.
        Task<bool> AddRestaurant(Restaurant Objres);
        Task<bool> UpdateRestaurant(Restaurant Objres);
        Task<bool> DeleteRestaurant(int Id);
        Task<List<Restaurant>> GetallRestaurants();
        Task<Restaurant> GetRestaurantById(int Id);
        
    }
}
