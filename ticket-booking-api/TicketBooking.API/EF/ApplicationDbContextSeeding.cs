using Microsoft.EntityFrameworkCore;
using TicketBooking.API.Models;
using TicketBooking.API.Enum;

namespace TicketBooking.API.EF
{
  public class ApplicationDbContextSeeding
  {
    public static void Seed(ref ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Event>().HasData(
        new Event
        {
          Id = Guid.NewGuid(),
          Title = "BlackPink world tour Ha Noi",
          Image = "https://cdn-i.vtcnews.vn/resize/Da9xKKWytSr4nFIRCPjyxBQ21LK9PQ2a0/upload/2023/06/30/blackpink-07424148.jpg",
          MinPrice = 1000000,
          Date = new DateTime(),
          Location = "My Dinh stadium, Ha Noi",
          Type = EventType.Concert
        },
        new Event
        {
          Id = Guid.NewGuid(),
          Title = "Thor: Love and Thunder",
          Image = "https://i.ytimg.com/vi/Qmlio2iEaJo/maxresdefault.jpg",
          MinPrice = 100000,
          Date = new DateTime(),
          Location = "CGV Hung Vuong Plaza, Ho Chi Minh City",
          Type = EventType.Movie
        },
        new Event {
          Id = Guid.NewGuid(),
          Title = "Viettel vs. Song Lam Nghe An",
          Image = "https://cdn.bongdaplus.vn/Assets/Media/2021/01/13/62/lich-thi-dau-v-league-2021-giai-doan-1.jpg",
          MinPrice = 120000,
          Date = new DateTime(),
          Location = "Phu Tho Stadium, Ho Chi Minh City",
          Type = EventType.Sport
        },
        new Event {
          Id = Guid.NewGuid(),
          Title = "Becamex Binh Duong vs. Hoang Anh Gia Lai",
          Image = "https://cdn.bongdaplus.vn/Assets/Media/2021/01/13/62/lich-thi-dau-v-league-2021-giai-doan-1.jpg",
          MinPrice = 120000,
          Date = new DateTime(),
          Location = "Sam Son Stadium, Binh Duong",
          Type = EventType.Sport
        },
        new Event {
          Id = Guid.NewGuid(),
          Title = "Liveshow Nu Cuoi Moi",
          Image = "https://i.ytimg.com/vi/J7xEJnqlIuU/maxresdefault.jpg",
          MinPrice = 200000,
          Date = new DateTime(),
          Location = "Nu Cuoi Moi theater, Ho Chi Minh City",
          Type = EventType.Comedy
        }
      );
    }
  }
}