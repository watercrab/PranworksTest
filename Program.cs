using Library.Data;
using Library.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var BconnectionString = builder.Configuration.GetConnectionString("RBook") ?? "Data Source=Bookss.db";
var CconnectionString = builder.Configuration.GetConnectionString("RCategorie") ?? "Data Source=Categoriess.db";
var IconnectionString = builder.Configuration.GetConnectionString("RInfo") ?? "Data Source=Infoss.db";
var RconnectionString = builder.Configuration.GetConnectionString("RRent") ?? "Data Source=Rentss.db";
var UconnectionString = builder.Configuration.GetConnectionString("RUser") ?? "Data Source=Userss.db";

// var BconnectionString = builder.Configuration.GetConnectionString("BookDb") ?? "Data Source=Books.db";
// var CconnectionString = builder.Configuration.GetConnectionString("SQLite") ?? "Data Source=Categories.db";
// var IconnectionString = builder.Configuration.GetConnectionString("SQLite") ?? "Data Source=Infos.db";
// var RconnectionString = builder.Configuration.GetConnectionString("SQLite") ?? "Data Source=Rents.db";
// var UconnectionString = builder.Configuration.GetConnectionString("SQLite") ?? "Data Source=Users.db";

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddDbContext<BookDb>(BookOptions => BookOptions.UseInMemoryDatabase("items"));
// builder.Services.AddDbContext<CategorieDb>(CategorieOptions => CategorieOptions.UseInMemoryDatabase("items"));
// builder.Services.AddDbContext<InfoDb>(InfoOptions => InfoOptions.UseInMemoryDatabase("items"));
// builder.Services.AddDbContext<RentDb>(Rentoptions => Rentoptions.UseInMemoryDatabase("items"));
// builder.Services.AddDbContext<UserDb>(InfoOptions => InfoOptions.UseInMemoryDatabase("items"));

builder.Services.AddSqlite<BookDb>(BconnectionString);
builder.Services.AddSqlite<CategorieDb>(CconnectionString);
builder.Services.AddSqlite<InfoDb>(IconnectionString);
builder.Services.AddSqlite<RentDb>(RconnectionString);
builder.Services.AddSqlite<UserDb>(UconnectionString);

builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "ไม่มีข้อมูล");
app.MapGet("/books", async (BookDb db) => await db.Bookss.ToListAsync());
app.MapGet("/categories", async (CategorieDb db) => await db.Categoriess.ToListAsync());
app.MapGet("/infos", async (InfoDb db) => await db.Infoss.ToListAsync());
app.MapGet("/rents", async (RentDb db) => await db.Rentss.ToListAsync());
app.MapGet("/users", async (UserDb db) => await db.Userss.ToListAsync());

app.MapPost("/book", async (BookDb db, Book book) =>
{
    await db.Bookss.AddAsync(book);
    await db.SaveChangesAsync();
    return Results.Created($"/book/{book.Id}", book);
});
app.MapPost("/categorie", async (CategorieDb db, Categorie categorie) =>
{
    await db.Categoriess.AddAsync(categorie);
    await db.SaveChangesAsync();
    return Results.Created($"/categorie/{categorie.Id}", categorie);
});
app.MapPost("/info", async (InfoDb db, Info info) =>
{
    await db.Infoss.AddAsync(info);
    await db.SaveChangesAsync();
    return Results.Created($"/info/{info.Id}", info);
});
app.MapPost("/rent", async (RentDb db, Rent rent) =>
{
    await db.Rentss.AddAsync(rent);
    await db.SaveChangesAsync();
    return Results.Created($"/rent/{rent.Id}", rent);
});
app.MapPost("/user", async (UserDb db, User user) =>
{
    await db.Userss.AddAsync(user);
    await db.SaveChangesAsync();
    return Results.Created($"/user/{user.Id}", user);
});

app.MapGet("/book/{id}", async (BookDb db, int id) => await db.Bookss.FindAsync(id));
app.MapGet("/categorie/{id}", async (CategorieDb db, int id) => await db.Categoriess.FindAsync(id));
app.MapGet("/info/{id}", async (InfoDb db, int id) => await db.Infoss.FindAsync(id));
app.MapGet("/rent/{id}", async (RentDb db, int id) => await db.Rentss.FindAsync(id));
app.MapGet("/user/{id}", async (UserDb db, int id) => await db.Userss.FindAsync(id));

app.MapPut("/book/{id}", async (BookDb db, Book updatebook, int id) =>
{
    var book = await db.Bookss.FindAsync(id);
    if (book is null) return Results.NotFound();
    // book.BookId = updatebook.BookId;
    book.CategorieId = updatebook.CategorieId;
    book.Code = updatebook.Code;
    book.Name = updatebook.Name;
    book.Publisher = updatebook.Publisher;
    book.Price = updatebook.Price;
    await db.SaveChangesAsync();
    return Results.NoContent();
});
app.MapPut("/categorie/{id}", async (CategorieDb db, Categorie updatecategorie, int id) =>
{
    var categorie = await db.Categoriess.FindAsync(id);
    if (categorie is null) return Results.NotFound();
    // categorie.CategorieId = updatecategorie.CategorieId;
    categorie.Code = updatecategorie.Code;
    categorie.Name = updatecategorie.Name;
    await db.SaveChangesAsync();
    return Results.NoContent();
});
app.MapPut("/info/{id}", async (InfoDb db, Info updateinfo, int id) =>
{
    var info = await db.Infoss.FindAsync(id);
    if (info is null) return Results.NotFound();
    info.UserId = updateinfo.UserId;
    info.Date = updateinfo.Date;
    info.TimeIn = updateinfo.TimeIn;
    info.TimeOut = updateinfo.TimeOut;
    await db.SaveChangesAsync();
    return Results.NoContent();
});
app.MapPut("/rent/{id}", async (RentDb db, Rent updaterent, int id) =>
{
    var rent = await db.Rentss.FindAsync(id);
    if (rent is null) return Results.NotFound();
    rent.BookId = updaterent.BookId;
    rent.UserId = updaterent.UserId;
    rent.DatetimeRent = updaterent.DatetimeRent;
    rent.Datetimeback = updaterent.Datetimeback;
    rent.Return = updaterent.Return;
    await db.SaveChangesAsync();
    return Results.NoContent();
});
app.MapPut("/user/{id}", async (UserDb db, User updateuser, int id) =>
{
    var user = await db.Userss.FindAsync(id);
    if (user is null) return Results.NotFound();
    // user.UserId = updateuser.UserId;
    user.Code = updateuser.Code;
    user.FirstName = updateuser.FirstName;
    user.LastName = updateuser.LastName;
    user.Tel = updateuser.Tel;
    user.Address = updateuser.Address;
    user.Email = updateuser.Email;
    user.Status = updateuser.Status;
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/book/{id}", async (BookDb db, int id) =>
{
    var book = await db.Bookss.FindAsync(id);
    if (book is null)
    {
        return Results.NotFound();
    }
    db.Bookss.Remove(book);
    await db.SaveChangesAsync();
    return Results.Ok();
});
app.MapDelete("/categorie/{id}", async (CategorieDb db, int id) =>
{
    var categorie = await db.Categoriess.FindAsync(id);
    if (categorie is null)
    {
        return Results.NotFound();
    }
    db.Categoriess.Remove(categorie);
    await db.SaveChangesAsync();
    return Results.Ok();
});
app.MapDelete("/info/{id}", async (InfoDb db, int id) =>
{
    var info = await db.Infoss.FindAsync(id);
    if (info is null)
    {
        return Results.NotFound();
    }
    db.Infoss.Remove(info);
    await db.SaveChangesAsync();
    return Results.Ok();
});
app.MapDelete("/rent/{id}", async (RentDb db, int id) =>
{
    var rent = await db.Rentss.FindAsync(id);
    if (rent is null)
    {
        return Results.NotFound();
    }
    db.Rentss.Remove(rent);
    await db.SaveChangesAsync();
    return Results.Ok();
});
app.MapDelete("/user/{id}", async (UserDb db, int id) =>
{
    var user = await db.Userss.FindAsync(id);
    if (user is null)
    {
        return Results.NotFound();
    }
    db.Userss.Remove(user);
    await db.SaveChangesAsync();
    return Results.Ok();
});

app.Run();

