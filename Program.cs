using LibrarieStore.Data;
using LibrarieStore.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var BconnectionString = builder.Configuration.GetConnectionString("RBook") ?? "Data Source=AllBook.db";
var CconnectionString = builder.Configuration.GetConnectionString("RCategorie") ?? "Data Source=AllCategorie.db";
var IconnectionString = builder.Configuration.GetConnectionString("RInfo") ?? "Data Source=AllInfo.db";
var RconnectionString = builder.Configuration.GetConnectionString("RRent") ?? "Data Source=AllRent.db";
var UconnectionString = builder.Configuration.GetConnectionString("RUser") ?? "Data Source=AllUser.db";

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSqlite<BookDb>(BconnectionString);
builder.Services.AddSqlite<CategorieDb>(CconnectionString);
builder.Services.AddSqlite<InfoDb>(IconnectionString);
builder.Services.AddSqlite<RentDb>(RconnectionString);
builder.Services.AddSqlite<UserDb>(UconnectionString);

builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "No data");
app.MapGet("/Books", async (BookDb db) => await db.AllBook.ToListAsync());
app.MapGet("/rents", async (RentDb db) => await db.AllRent.ToListAsync());
app.MapGet("/users", async (UserDb db) => await db.AllUser.ToListAsync());
app.MapGet("/infos", async (InfoDb db) => await db.AllInfo.ToListAsync());
app.MapGet("/categories", async (CategorieDb db) => await db.AllCategorie.ToListAsync());

app.MapPost("/book", async (BookDb db, Book book) =>
{
    await db.AllBook.AddAsync(book);
    await db.SaveChangesAsync();
    return Results.Created($"/book/{book.Id}", book);
});
app.MapPost("/categorie", async (CategorieDb db, Categorie categorie) =>
{
    await db.AllCategorie.AddAsync(categorie);
    await db.SaveChangesAsync();
    return Results.Created($"/categorie/{categorie.Id}", categorie);
});
app.MapPost("/info", async (InfoDb db, Info info) =>
{
    await db.AllInfo.AddAsync(info);
    await db.SaveChangesAsync();
    return Results.Created($"/info/{info.Id}", info);
});
app.MapPost("/rent", async (RentDb db, Rent rent) =>
{
    await db.AllRent.AddAsync(rent);
    await db.SaveChangesAsync();
    return Results.Created($"/rent/{rent.Id}", rent);
});
app.MapPost("/user", async (UserDb db, User user) =>
{
    await db.AllUser.AddAsync(user);
    await db.SaveChangesAsync();
    return Results.Created($"/user/{user.Id}", user);
});

app.MapGet("/book/{id}", async (BookDb db, int id) => await db.AllBook.FindAsync(id));
app.MapGet("/categorie/{id}", async (CategorieDb db, int id) => await db.AllCategorie.FindAsync(id));
app.MapGet("/info/{id}", async (InfoDb db, int id) => await db.AllInfo.FindAsync(id));
app.MapGet("/rent/{id}", async (RentDb db, int id) => await db.AllRent.FindAsync(id));
app.MapGet("/user/{id}", async (UserDb db, int id) => await db.AllUser.FindAsync(id));

app.MapPut("/book/{id}", async (BookDb db, Book updatebook, int id) =>
{
    var book = await db.AllBook.FindAsync(id);
    if (book is null) return Results.NotFound();
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
    var categorie = await db.AllCategorie.FindAsync(id);
    if (categorie is null) return Results.NotFound();
    categorie.Code = updatecategorie.Code;
    categorie.Name = updatecategorie.Name;
    await db.SaveChangesAsync();
    return Results.NoContent();
});
app.MapPut("/info/{id}", async (InfoDb db, Info updateinfo, int id) =>
{
    var info = await db.AllInfo.FindAsync(id);
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
    var rent = await db.AllRent.FindAsync(id);
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
    var user = await db.AllUser.FindAsync(id);
    if (user is null) return Results.NotFound();
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
    var book = await db.AllBook.FindAsync(id);
    if (book is null)
    {
        return Results.NotFound();
    }
    db.AllBook.Remove(book);
    await db.SaveChangesAsync();
    return Results.Ok();
});
app.MapDelete("/categorie/{id}", async (CategorieDb db, int id) =>
{
    var categorie = await db.AllCategorie.FindAsync(id);
    if (categorie is null)
    {
        return Results.NotFound();
    }
    db.AllCategorie.Remove(categorie);
    await db.SaveChangesAsync();
    return Results.Ok();
});
app.MapDelete("/info/{id}", async (InfoDb db, int id) =>
{
    var info = await db.AllInfo.FindAsync(id);
    if (info is null)
    {
        return Results.NotFound();
    }
    db.AllInfo.Remove(info);
    await db.SaveChangesAsync();
    return Results.Ok();
});
app.MapDelete("/rent/{id}", async (RentDb db, int id) =>
{
    var rent = await db.AllRent.FindAsync(id);
    if (rent is null)
    {
        return Results.NotFound();
    }
    db.AllRent.Remove(rent);
    await db.SaveChangesAsync();
    return Results.Ok();
});
app.MapDelete("/user/{id}", async (UserDb db, int id) =>
{
    var user = await db.AllUser.FindAsync(id);
    if (user is null)
    {
        return Results.NotFound();
    }
    db.AllUser.Remove(user);
    await db.SaveChangesAsync();
    return Results.Ok();
});

app.Run();

