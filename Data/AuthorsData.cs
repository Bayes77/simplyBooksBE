using simplyBooksBE.Models;
using System.Net.NetworkInformation;

namespace simplyBooksBE.Data
{
    public class AuthorsData
    {
        public static List<Authors> Author = new()
        {
            new() {ID = 101, First_Name = "Alice" , Last_Name = "Johnson", Email = "alice.johnson@email.com", Favorite = true, ImageUrl = "https://randomuser.me/api/portraits/women/71.jpg", Uid = "A1"  },
             new() {ID = 102, First_Name = "Benjamin" , Last_Name = "Lee", Email = "benjiman.lee@email.com", Favorite = false, ImageUrl = "https://randomuser.me/api/portraits/men/74.jpg", Uid = "A2"  },
            new() {ID = 103, First_Name = "Carla" , Last_Name = "Martinez", Email = "carla.martinez@email.com", Favorite = true, ImageUrl = "https://randomuser.me/api/portraits/women/8.jpg", Uid = "A3"  },
            new() {ID = 104, First_Name = "David" , Last_Name = "Roberts", Email = "david.roberts@email.com", Favorite = false, ImageUrl = "https://randomuser.me/api/portraits/men/54.jpg", Uid = "A4"  },
            new() {ID = 105, First_Name = "Emma" , Last_Name = "Zhang", Email = "emma.zhang@email.com", Favorite = true, ImageUrl = "https://randomuser.me/api/portraits/women/35.jpg", Uid = "A5"  },
        };
    }
}
