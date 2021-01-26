using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Guestly.Models
{
  public class GuestlyContext : IdentityDbContext<ApplicationUser>
  {
    public GuestlyContext(DbContextOptions<GuestlyContext> options)
      : base(options)
      {
      }

    public DbSet<Guest> Guests { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<GuestRoom> GuestRoom { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.Entity<Guest>()
        .HasData(
          new Guest {GuestId = 1, FirstName = "Jack", LastName = "Daniel", Email =  "jd@email.com", PhoneNumber = "1223334444", LifetimeNights = 2, LifetimeRevenue = 250.00f },
          new Guest {GuestId = 2, FirstName = "Drew", LastName = "Mason", Email = "thisisdrew@email.com", PhoneNumber = "5673451231", LifetimeNights = 1, LifetimeRevenue = 220.00f},
          new Guest {GuestId = 3, FirstName = "Matthew", LastName = "Patel", Email = "matthewpatel@email.com", PhoneNumber = "192837465", LifetimeNights = 4, LifetimeRevenue = 340.00f},
          new Guest {GuestId = 4, FirstName = "Seth", LastName = "Doray", Email = "sethdoray@email.com", PhoneNumber = "5033505003", LifetimeNights = 5, LifetimeRevenue = 750.00f},
          new Guest {GuestId = 5, FirstName = "Richard", LastName = "Richardson", Email = "doublerich@email.com", PhoneNumber = "9717717771", LifetimeNights = 3, LifetimeRevenue = 450.00f},
          new Guest {GuestId = 6, FirstName = "Caleb", LastName = "Edwards", Email = "cal3b3dwards@email.com", PhoneNumber = "2736498710", LifetimeNights = 2, LifetimeRevenue = 190.00f},
          new Guest {GuestId = 7, FirstName = "Shoyo", LastName = "Hinita", Email = "volleyballrox@email.com", PhoneNumber = "1133224433", LifetimeNights = 1, LifetimeRevenue = 85.00f},
          new Guest {GuestId = 8, FirstName = "Riley", LastName = "Keys", Email = "rileykeys@email.com", PhoneNumber = "4252075079", LifetimeNights = 4, LifetimeRevenue = 340.00f},
          new Guest {GuestId = 9, FirstName = "Parker", LastName = "Wallenburger", Email = "heyyouparkit@email.com", PhoneNumber = "5555599999", LifetimeNights = 5, LifetimeRevenue = 475.00f},
          new Guest {GuestId = 10, FirstName = "Nigel", LastName = "Dogo", Email = "mydognigel@email.com", PhoneNumber = "3333333333", LifetimeNights = 3, LifetimeRevenue = 450.00f},
          new Guest {GuestId = 11, FirstName = "Rick", LastName = "Ellis", Email = "rickiede@email.com", PhoneNumber = "4155558956", LifetimeNights = 2, LifetimeRevenue = 250.00f},
          new Guest {GuestId = 12, FirstName = "Alex", LastName = "Calder", Email = "acathome@email.com", PhoneNumber = "5065558989", LifetimeNights = 1, LifetimeRevenue = 95.00f},
          new Guest {GuestId = 13, FirstName = "Erica", LastName = "Bell", Email = "elbell@email.com", PhoneNumber = "9715558562", LifetimeNights = 4, LifetimeRevenue = 440.00f},
          new Guest {GuestId = 14, FirstName = "Bobby", LastName = "DeNicola", Email = "denicolab@email.com", PhoneNumber = "7075559846", LifetimeNights = 5, LifetimeRevenue = 550.00f},
          new Guest {GuestId = 15, FirstName = "Ellie", LastName = "Munoz", Email = "emmunoz@email.com", PhoneNumber = "5035556231", LifetimeNights = 3, LifetimeRevenue = 255.00f},
          new Guest {GuestId = 16, FirstName = "Joshua", LastName = "McTeller", Email = "jmcteller@email.com", PhoneNumber = "4155558894", LifetimeNights = 2, LifetimeRevenue = 170.00f},
          new Guest {GuestId = 17, FirstName = "Natalie", LastName = "Lass", Email = "nnatell@email.com", PhoneNumber = "5415558896", LifetimeNights = 1, LifetimeRevenue = 110.00f},
          new Guest {GuestId = 18, FirstName = "Tripp", LastName = "Ford", Email = "tridoublep@email.com", PhoneNumber = "5035552483", LifetimeNights = 4, LifetimeRevenue = 500.00f },
          new Guest {GuestId = 19, FirstName = "Willie", LastName = "Ford", Email = "wilford@email.com", PhoneNumber = "4155556472", LifetimeNights = 1, LifetimeRevenue = 110.00f },
          new Guest {GuestId = 20, FirstName = "Kaitlin", LastName = "Wozniak", Email = "katwoz@email.com", PhoneNumber = "5035558258", LifetimeNights = 3, LifetimeRevenue = 375.00f },
          new Guest {GuestId = 21, FirstName = "Madalyn", LastName = "Lathem", Email = "madalynl11@email.com", PhoneNumber = "6514553861", LifetimeNights = 2, LifetimeRevenue = 220.00f },
          new Guest {GuestId = 22, FirstName = "Sean", LastName = "Mercado", Email = "sean.mercado04@email.com", PhoneNumber = "5018988936", LifetimeNights = 1, LifetimeRevenue = 125.00f },
          new Guest {GuestId = 23, FirstName = "Viktoria", LastName = "Nielsen", Email = "viktoriaaksnes@email.com", PhoneNumber = "7843247148", LifetimeNights = 4, LifetimeRevenue = 440.00f },
          new Guest {GuestId = 24, FirstName = "Nao", LastName = "Oka", Email = "now@email.com", PhoneNumber = "3193198947", LifetimeNights = 5, LifetimeRevenue = 425.00f },
          new Guest {GuestId = 25, FirstName = "Bernie", LastName = "Hancock", Email = "bernie@mittens.com", PhoneNumber = "2778649180", LifetimeNights = 3, LifetimeRevenue = 255.00f },
          new Guest {GuestId = 26, FirstName = "Eleanor", LastName = "Pratte", Email = "pratte16@email.com", PhoneNumber = "4529407334", LifetimeNights = 2, LifetimeRevenue = 220.00f },
          new Guest {GuestId = 27, FirstName = "Aurora", LastName = "Berg", Email = "aurorabergen@email.com", PhoneNumber = "1338214188", LifetimeNights = 1, LifetimeRevenue = 110.00f },
          new Guest {GuestId = 28, FirstName = "Frodo", LastName = "Baggins", Email = "mr.underhill@email.com", PhoneNumber = "5385970949", LifetimeNights = 4, LifetimeRevenue = 380.00f },
          new Guest {GuestId = 29, FirstName = "Aya", LastName = "Takano", Email = "takanoart@email.com", PhoneNumber = "2969397018", LifetimeNights = 5, LifetimeRevenue = 625.00f },
          new Guest {GuestId = 30, FirstName = "Rick", LastName = "Deckard", Email = "deckard.rick@email.com", PhoneNumber = "6192533993", LifetimeNights = 3, LifetimeRevenue = 450.00f },
          new Guest {GuestId = 31, FirstName = "Happy", LastName = "Gilmore", Email = "happy_golfmore@email.com", PhoneNumber = "1234578900", LifetimeNights = 2, LifetimeRevenue = 190.00f },
          new Guest {GuestId = 32, FirstName = "Joyce", LastName= "Summers", Email= "joycesummers@email.com", PhoneNumber= "1987899876", LifetimeNights = 1, LifetimeRevenue = 85.00f },
          new Guest {GuestId = 33, FirstName = "Harmony", LastName= "Kendall", Email= "KHarm123@email.com", PhoneNumber= "1465768945", LifetimeNights = 4, LifetimeRevenue = 340.00f },
          new Guest {GuestId = 34, FirstName = "Jenny", LastName= "Calendar", Email= "JennyCal@email.com", PhoneNumber= "2343546754", LifetimeNights = 5, LifetimeRevenue = 475.00f },
          new Guest {GuestId = 35, FirstName = "Annointed", LastName= "One", Email= "anointed1_66@email.com", PhoneNumber= "6894562341", LifetimeNights = 3, LifetimeRevenue = 450.00f },
          new Guest {GuestId = 36, FirstName = "Hank", LastName= "Summers", Email= "H.Sums@email.com", PhoneNumber= "1029384234", LifetimeNights = 2, LifetimeRevenue = 300.00f },
          new Guest {GuestId = 37, FirstName = "Jesse", LastName= "McNally", Email= "jessekmcjay@email.com", PhoneNumber= "4675823123", LifetimeNights = 1, LifetimeRevenue = 85.00f },
          new Guest {GuestId = 38, FirstName = "Jonathan", LastName= "Levinson", Email= "JonLev@email.com", PhoneNumber= "9858673452", LifetimeNights = 4, LifetimeRevenue = 440.00f },
          new Guest {GuestId = 39, FirstName = "Ethan", LastName= "Rayne", Email= "eRayne@email.com", PhoneNumber= "2384655432", LifetimeNights = 5, LifetimeRevenue = 625.00f },
          new Guest {GuestId = 40, FirstName = "Faith", LastName= "Lehane", Email= "gottahavefaith@email.com", PhoneNumber= "2349853456", LifetimeNights = 3, LifetimeRevenue = 330.00f },
          new Guest {GuestId = 41, FirstName = "Quentin", LastName= "Travers", Email= "notTaratino@email.com", PhoneNumber= "3458768676", LifetimeNights = 12, LifetimeRevenue = 1020.00f },
          new Guest {GuestId = 42, FirstName = "Scott", LastName= "Hope", Email= "scott!@email.com", PhoneNumber= "5436667534", LifetimeNights = 1, LifetimeRevenue = 150.00f },
          new Guest {GuestId = 43, FirstName = "Wesley", LastName= "Pryce", Email= "asYouWish@email.com", PhoneNumber= "2345674564", LifetimeNights = 4, LifetimeRevenue = 600.00f },
          new Guest {GuestId = 44, FirstName = "Cordelia", LastName= "Chase", Email= "PromQueen@email.com", PhoneNumber= "5543234321", LifetimeNights = 5, LifetimeRevenue = 475.00f },
          new Guest {GuestId = 45, FirstName = "Buffy", LastName= "Summers", Email= "OnlyBuffyWillJudge@email.com", PhoneNumber= "8778887634", LifetimeNights = 13, LifetimeRevenue = 1105.00f },
          new Guest {GuestId = 46, FirstName = "Rupert", LastName= "Giles", Email= "Bookguy@email.com", PhoneNumber= "4756566879", LifetimeNights = 2, LifetimeRevenue = 170.00f },
          new Guest {GuestId = 47, FirstName = "Willow", LastName= "Rosenberg", Email= "witchStuff@email.com", PhoneNumber= "7998884475", LifetimeNights = 1, LifetimeRevenue = 95.00f },
          new Guest {GuestId = 48, FirstName = "Xander", LastName= "Harris", Email= "jokesDotCom@email.com", PhoneNumber= "3334958679", LifetimeNights = 4, LifetimeRevenue = 600.00f },
          new Guest {GuestId = 49, FirstName = "William", LastName= "Pratt", Email= "BadBois@email.com", PhoneNumber= "4445556634", LifetimeNights = 5, LifetimeRevenue = 625.00f },
          new Guest {GuestId = 50, FirstName = "Amy", LastName= "Madison", Email= "ImaMouse@email.com", PhoneNumber= "2873345543", LifetimeNights = 3, LifetimeRevenue = 285.00f },
          new Guest {GuestId = 51, FirstName = "Cassie", LastName= "Newton", Email= "TwoNewtons@email.com", PhoneNumber= "9987896786", LifetimeNights = 2, LifetimeRevenue = 220.00f },
          new Guest {GuestId = 52, FirstName = "Chao", LastName= "Ahn", Email= "Alternate@email.com", PhoneNumber= "6675844776", LifetimeNights = 1, LifetimeRevenue = 110.00f },
          new Guest {GuestId = 53, FirstName = "Count", LastName= "Dracula", Email= "SeattleResident@email.com", PhoneNumber= "9980987867", LifetimeNights = 4, LifetimeRevenue = 340.00f },
          new Guest {GuestId = 54, FirstName = "Forrest", LastName= "Gates", Email= "militarystuff@email.com", PhoneNumber= "8009978865", LifetimeNights = 5, LifetimeRevenue = 425.00f },
          new Guest {GuestId = 55, FirstName = "India", LastName= "Cohen", Email= "Indiacohen@email.com", PhoneNumber= "9078788986", LifetimeNights = 3, LifetimeRevenue = 330.00f },
          new Guest {GuestId = 56, FirstName = "Janice", LastName= "Penshaw", Email= "janicePenshaw@email.com", PhoneNumber= "6678745632", LifetimeNights = 2, LifetimeRevenue = 250.00f },
          new Guest {GuestId = 57, FirstName = "Kathy", LastName= "Newman", Email= "KathyNewman@email.com", PhoneNumber= "1122212345", LifetimeNights = 1, LifetimeRevenue = 110.00f },
          new Guest {GuestId = 58, FirstName = "Kendra", LastName= "Young", Email= "KendraYoung@email.com", PhoneNumber= "4645534233", LifetimeNights = 4, LifetimeRevenue = 500.00f },
          new Guest {GuestId = 59, FirstName = "Satan", LastName= "Lucifer", Email= "TheDevil@email.com", PhoneNumber= "6666666666", LifetimeNights = 5, LifetimeRevenue = 550.00f },
          new Guest {GuestId = 60, FirstName = "Jenny", LastName= "Jenny", Email= "TheJenny@email.com", PhoneNumber= "2018675309", LifetimeNights = 3, LifetimeRevenue = 375.00f }
        );
      builder.Entity<Room>()
        .HasData(
          new Room {RoomId = 1, RoomNumber = "105", RoomType = "King", Price = 125.00f },
          new Room {RoomId = 2, RoomNumber = "110", RoomType = "Queen", Price = 110.00f },
          new Room {RoomId = 3, RoomNumber = "111", RoomType = "Baby", Price = 85.00f },
          new Room {RoomId = 4, RoomNumber = "188", RoomType = "Suite", Price = 150.00f },
          new Room {RoomId = 5, RoomNumber = "190", RoomType = "Suite", Price = 150.00f },
          new Room {RoomId = 6, RoomNumber = "210", RoomType = "Full", Price = 95.00f },
          new Room {RoomId = 7, RoomNumber = "211", RoomType = "Baby", Price = 85.00f },
          new Room {RoomId = 8, RoomNumber = "215", RoomType = "Baby", Price = 85.00f },
          new Room {RoomId = 9, RoomNumber = "220", RoomType = "Full", Price = 95.00f },
          new Room {RoomId = 10, RoomNumber = "237", RoomType = "Suite", Price = 150.00f },
          new Room {RoomId = 11, RoomNumber = "279", RoomType = "King", Price = 125.00f },
          new Room {RoomId = 12, RoomNumber = "311", RoomType = "Full", Price = 95.00f },
          new Room {RoomId = 13, RoomNumber = "333", RoomType = "Queen", Price = 110.00f },
          new Room {RoomId = 14, RoomNumber = "345", RoomType = "Queen", Price = 110.00f },
          new Room {RoomId = 15, RoomNumber = "366", RoomType = "Baby", Price = 85.00f },
          new Room {RoomId = 16, RoomNumber = "369", RoomType = "Baby", Price = 85.00f },
          new Room {RoomId = 17, RoomNumber = "375", RoomType = "Queen", Price = 110.00f },
          new Room {RoomId = 18, RoomNumber = "380", RoomType = "King", Price = 125.00f },
          new Room {RoomId = 19, RoomNumber = "387", RoomType = "Queen", Price = 110.00f },
          new Room {RoomId = 20, RoomNumber = "399", RoomType = "King", Price = 125.00f }
        );
      builder.Entity<GuestRoom>()
        .HasData(
          new GuestRoom {GuestRoomId = 1, GuestId = 1, RoomId = 1, Nights = 2},
          new GuestRoom {GuestRoomId = 2, GuestId = 2, RoomId = 2, Nights = 1},
          new GuestRoom {GuestRoomId = 3, GuestId = 3, RoomId = 3, Nights = 4},
          new GuestRoom {GuestRoomId = 4, GuestId = 4, RoomId = 4, Nights = 5},
          new GuestRoom {GuestRoomId = 5, GuestId = 5, RoomId = 5, Nights = 3},
          new GuestRoom {GuestRoomId = 6, GuestId = 6, RoomId = 6, Nights = 2},
          new GuestRoom {GuestRoomId = 7, GuestId = 7, RoomId = 7, Nights = 1},
          new GuestRoom {GuestRoomId = 8, GuestId = 8, RoomId = 8, Nights = 4},
          new GuestRoom {GuestRoomId = 9, GuestId = 9, RoomId = 9, Nights = 5},
          new GuestRoom {GuestRoomId = 10, GuestId = 10, RoomId = 10, Nights = 3},
          new GuestRoom {GuestRoomId = 11, GuestId = 11, RoomId = 11, Nights = 2},
          new GuestRoom {GuestRoomId = 12, GuestId = 12, RoomId = 12, Nights = 1},
          new GuestRoom {GuestRoomId = 13, GuestId = 13, RoomId = 13, Nights = 4},
          new GuestRoom {GuestRoomId = 14, GuestId = 14, RoomId = 14, Nights = 5},
          new GuestRoom {GuestRoomId = 15, GuestId = 15, RoomId = 15, Nights = 3},
          new GuestRoom {GuestRoomId = 16, GuestId = 16, RoomId = 16, Nights = 2},
          new GuestRoom {GuestRoomId = 17, GuestId = 17, RoomId = 17, Nights = 1},
          new GuestRoom {GuestRoomId = 18, GuestId = 18, RoomId = 18, Nights = 4},
          new GuestRoom {GuestRoomId = 19, GuestId = 19, RoomId = 19, Nights = 1},
          new GuestRoom {GuestRoomId = 20, GuestId = 20, RoomId = 20, Nights = 3},
          new GuestRoom {GuestRoomId = 21, GuestId = 21, RoomId = 19, Nights = 2},
          new GuestRoom {GuestRoomId = 22, GuestId = 22, RoomId = 18, Nights = 1},
          new GuestRoom {GuestRoomId = 23, GuestId = 23, RoomId = 17, Nights = 4},
          new GuestRoom {GuestRoomId = 24, GuestId = 24, RoomId = 16, Nights = 5},
          new GuestRoom {GuestRoomId = 25, GuestId = 25, RoomId = 15, Nights = 3},
          new GuestRoom {GuestRoomId = 26, GuestId = 26, RoomId = 14, Nights = 2},
          new GuestRoom {GuestRoomId = 27, GuestId = 27, RoomId = 13, Nights = 1},
          new GuestRoom {GuestRoomId = 28, GuestId = 28, RoomId = 12, Nights = 4},
          new GuestRoom {GuestRoomId = 29, GuestId = 29, RoomId = 11, Nights = 5},
          new GuestRoom {GuestRoomId = 30, GuestId = 30, RoomId = 10, Nights = 3},
          new GuestRoom {GuestRoomId = 31, GuestId = 31, RoomId = 9, Nights = 2},
          new GuestRoom {GuestRoomId = 32, GuestId = 32, RoomId = 8, Nights = 1},
          new GuestRoom {GuestRoomId = 33, GuestId = 33, RoomId = 7, Nights = 4},
          new GuestRoom {GuestRoomId = 34, GuestId = 34, RoomId = 6, Nights = 5},
          new GuestRoom {GuestRoomId = 35, GuestId = 35, RoomId = 5, Nights = 3},
          new GuestRoom {GuestRoomId = 36, GuestId = 36, RoomId = 4, Nights = 2},
          new GuestRoom {GuestRoomId = 37, GuestId = 37, RoomId = 3, Nights = 1},
          new GuestRoom {GuestRoomId = 38, GuestId = 38, RoomId = 2, Nights = 4},
          new GuestRoom {GuestRoomId = 39, GuestId = 39, RoomId = 1, Nights = 5},
          new GuestRoom {GuestRoomId = 40, GuestId = 40, RoomId = 2, Nights = 3},
          new GuestRoom {GuestRoomId = 41, GuestId = 41, RoomId = 3, Nights = 12},
          new GuestRoom {GuestRoomId = 42, GuestId = 42, RoomId = 4, Nights = 1},
          new GuestRoom {GuestRoomId = 43, GuestId = 43, RoomId = 5, Nights = 4},
          new GuestRoom {GuestRoomId = 44, GuestId = 44, RoomId = 6, Nights = 5},
          new GuestRoom {GuestRoomId = 45, GuestId = 45, RoomId = 7, Nights = 13},
          new GuestRoom {GuestRoomId = 46, GuestId = 46, RoomId = 8, Nights = 2},
          new GuestRoom {GuestRoomId = 47, GuestId = 47, RoomId = 9, Nights = 1},
          new GuestRoom {GuestRoomId = 48, GuestId = 48, RoomId = 10, Nights = 4},
          new GuestRoom {GuestRoomId = 49, GuestId = 49, RoomId = 11, Nights = 5},
          new GuestRoom {GuestRoomId = 50, GuestId = 50, RoomId = 12, Nights = 3},
          new GuestRoom {GuestRoomId = 51, GuestId = 51, RoomId = 13, Nights = 2},
          new GuestRoom {GuestRoomId = 52, GuestId = 52, RoomId = 14, Nights = 1},
          new GuestRoom {GuestRoomId = 53, GuestId = 53, RoomId = 15, Nights = 4},
          new GuestRoom {GuestRoomId = 54, GuestId = 54, RoomId = 16, Nights = 5},
          new GuestRoom {GuestRoomId = 55, GuestId = 55, RoomId = 17, Nights = 3},
          new GuestRoom {GuestRoomId = 56, GuestId = 56, RoomId = 18, Nights = 2},
          new GuestRoom {GuestRoomId = 57, GuestId = 57, RoomId = 19, Nights = 1},
          new GuestRoom {GuestRoomId = 58, GuestId = 58, RoomId = 20, Nights = 4},
          new GuestRoom {GuestRoomId = 59, GuestId = 59, RoomId = 19, Nights = 5},
          new GuestRoom {GuestRoomId = 60, GuestId = 60, RoomId = 18, Nights = 3}
        );        
    }
  }
}