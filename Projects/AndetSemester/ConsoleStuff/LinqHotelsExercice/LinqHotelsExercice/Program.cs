using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LinqHotelsExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotels = new Hotel[]
            {
                new Hotel() {HotelNo = 1, Name = "The Pope", Address = "Vaticanstreet 1  1111 Bishopcity"},
                new Hotel() {HotelNo = 2, Name = "Lucky Star", Address = "Lucky Road 12  2222 Hometown"},
                new Hotel() {HotelNo = 3, Name = "Discount", Address = "Inexpensive Road 7 3333 Cheaptown"},
                new Hotel() {HotelNo = 4, Name = "deLuxeCapital", Address = "Luxury Road 99  4444 Luxus"},
                new Hotel() {HotelNo = 5, Name = "Discount", Address = "Inexpensive Road 7 3333 Cheaptown"},
                new Hotel() {HotelNo = 6, Name = "Prindsen", Address = "Algade 5, 4000 Roskilde"},
                new Hotel() {HotelNo = 7, Name = "Scandic", Address = "Algade 5, 4000 Roskilde"},
            };

            var rooms = new Room[]
            {
                new Room() {RoomNo = 1, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 2, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 3, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 4, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 11, Hotel=hotels[0], Types = 'S', Price = 150},
                new Room() {RoomNo = 12, Hotel=hotels[0], Types = 'S', Price = 150},
                new Room() {RoomNo = 13, Hotel=hotels[0], Types = 'S', Price = 150},
                new Room() {RoomNo = 21, Hotel=hotels[0], Types = 'F', Price = 220},
                new Room() {RoomNo = 22, Hotel=hotels[0], Types = 'F', Price = 220},
                new Room() {RoomNo = 23, Hotel=hotels[0], Types = 'F', Price = 220},
                new Room() {RoomNo = 1, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 2, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 3, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 4, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 11, Hotel=hotels[1], Types = 'S', Price = 180},
                new Room() {RoomNo = 12, Hotel=hotels[1], Types = 'S', Price = 180},
                new Room() {RoomNo = 21, Hotel=hotels[1], Types = 'F', Price = 300},
                new Room() {RoomNo = 22, Hotel=hotels[1], Types = 'F', Price = 300},
                new Room() {RoomNo = 1, Hotel=hotels[2], Types = 'D', Price = 175},
                new Room() {RoomNo = 2, Hotel=hotels[2], Types = 'D', Price = 180},
                new Room() {RoomNo = 11, Hotel=hotels[2], Types = 'S', Price = 100},
                new Room() {RoomNo = 21, Hotel=hotels[2], Types = 'S', Price = 100},
                new Room() {RoomNo = 31, Hotel=hotels[2], Types = 'F', Price = 200},
                new Room() {RoomNo = 32, Hotel=hotels[2], Types = 'F', Price = 230},
                new Room() {RoomNo = 1, Hotel=hotels[3], Types = 'D', Price = 500},
                new Room() {RoomNo = 2, Hotel=hotels[3], Types = 'D', Price = 550},
                new Room() {RoomNo = 3, Hotel=hotels[3], Types = 'D', Price = 550},
                new Room() {RoomNo = 11, Hotel=hotels[3], Types = 'S', Price = 350},
                new Room() {RoomNo = 12, Hotel=hotels[3], Types = 'S', Price = 360},
                new Room() {RoomNo = 1, Hotel=hotels[4], Types = 'D', Price = 250},
                new Room() {RoomNo = 2, Hotel=hotels[4], Types = 'D', Price = 170},
                new Room() {RoomNo = 11, Hotel=hotels[4], Types = 'S', Price = 150},
                new Room() {RoomNo = 21, Hotel=hotels[4], Types = 'F', Price = 300},
                new Room() {RoomNo = 22, Hotel=hotels[4], Types = 'F', Price = 310},
                new Room() {RoomNo = 23, Hotel=hotels[4], Types = 'F', Price = 320},
                new Room() {RoomNo = 24, Hotel=hotels[4], Types = 'F', Price = 320},
                new Room() {RoomNo = 1, Hotel=hotels[5], Types = 'D', Price = 290},
                new Room() {RoomNo = 11, Hotel=hotels[5], Types = 'S', Price = 185},
                new Room() {RoomNo = 21, Hotel=hotels[5], Types = 'F', Price = 360},
                new Room() {RoomNo = 22, Hotel=hotels[5], Types = 'F', Price = 370},
                new Room() {RoomNo = 23, Hotel=hotels[5], Types = 'F', Price = 380},
                new Room() {RoomNo = 24, Hotel=hotels[5], Types = 'F', Price = 380},
                new Room() {RoomNo = 1, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 2, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 3, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 4, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 11, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 12, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 13, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 14, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 21, Hotel=hotels[6], Types = 'F', Price = 220},
                new Room() {RoomNo = 22, Hotel=hotels[6], Types = 'F', Price = 220},
                new Room() {RoomNo = 23, Hotel=hotels[6], Types = 'F', Price = 220},
                new Room() {RoomNo = 24, Hotel=hotels[6], Types = 'F', Price = 220}
            };

            //Exercise, use LINQ to retrive the following information about Hotels and Rooms:

            // 1) List full details of all Hotels:

            //var allHotels = from hotel in hotels select hotel;
            //foreach (var hotel in allHotels)
            //{
            //    Console.WriteLine(hotel);
            //}

            // 2) List full details of all hotels in Roskilde:

            //var roskildeHotels = from hotel in hotels where hotel.Address.ToLower().Contains("roskilde") select hotel;
            //foreach (var hotel in roskildeHotels)
            //{
            //    Console.WriteLine(hotel);
            //}

            // 3) List the names of all hotels in Roskilde:

            //var myHotels = from hotel in hotels where hotel.Address.ToLower().Contains("roskilde") select hotel.Name;
            //foreach (var hotel in myHotels)
            //{
            //    Console.WriteLine(hotel);
            //}

            // 4) List all double rooms with a price below 400 pr night:

            //var doubleRooms = from room in rooms where room.Price < 400 && room.Types.Equals('D') select room;
            //foreach (var room in doubleRooms)
            //{
            //    Console.WriteLine(room);
            //}

            // 5) List all double or family rooms with a price below 400 pr night in ascending order of price:

            //var roomList = from room in rooms
            //    where room.Price < 400 && (room.Types.Equals('D') || room.Types.Equals('F'))
            //    orderby room.Price
            //    select room;
            //foreach (var room in roomList)
            //{
            //    Console.WriteLine(room);
            //}


            // 6) List all hotels that starts with 'P':

            //var pHotels = from hotel in hotels where hotel.Name.StartsWith("P") select hotel;
            //foreach (var hotel in pHotels)
            //{
            //    Console.WriteLine(hotel);
            //}


            // 7) List the number of hotels:
            //var amtnHotels = hotels.Length;
            //Console.WriteLine(amtnHotels);

            // 8) List the number of hotels in Roskilde:

            //var hotRoskilde = hotels.Count(h => h.Address.ToLower().Contains("roskilde"));
            //Console.WriteLine(hotRoskilde);

            // 9) what is the avarage price of a room:
            //var average = rooms.Average(r => r.Price);
            //Console.WriteLine(average);

            //10) what is the avarage price of a room at Hotel Scandic:
            var avgRoom = rooms.Where(r => r.Hotel.Name.Equals("Scandic")).Average(r => r.Price);
            Console.WriteLine(avgRoom);

            //11) what is the total reveneue per night from all double rooms:
            var totalRev = rooms.Where(r => r.Types.Equals('D')).Sum(r => r.Price);
            Console.WriteLine(totalRev);

            //12) List price and type of all rooms at Hotel Prindsen:
            //var priceNType = (
            //    from room in rooms
            //    join hotel in hotels on room.Hotel.HotelNo equals hotel.HotelNo
            //    where hotel.Name.Equal<s("Prindsen")
            //    select new {price = room.Price, type = room.Types});
            //foreach (var varia in priceNType)
            //{
            //    Console.WriteLine($"Price: {varia.price} - Type: {varia.type}");   
            //}

            //13) List distinct price and type of all rooms at Hotel Prindsen:

            var priceNTypes = (
                from room in rooms
                join hotel in hotels on room.Hotel.HotelNo equals hotel.HotelNo
                where hotel.Name.Equals("Prindsen")
                select new { price = room.Price, type = room.Types }).Distinct();
            foreach (var varia in priceNTypes)
            {
                Console.WriteLine($"Price: {varia.price} - Type: {varia.type}");
            }

            Console.WriteLine("...");
            Console.ReadKey();
        }
    }
}
