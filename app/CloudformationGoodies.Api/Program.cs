using CloudformationGoodies.Api.Context;
using CloudformationGoodies.Api.Service;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StackContext>(opts => opts.UseNpgsql());
builder.Services.AddScoped<IStackService, StackService>();
builder.Services.AddScoped<IStackComponentsService, StackComponentsService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/stack", async (StackContext ctx, IStackService service) =>
{
    return await service.GetAll();
});


app.MapGet("/stack/{stackId}/component", async (StackContext ctx, IStackComponentsService src, string stackId) =>
{
    Console.WriteLine(stackId);
    return await src.GetAll();
});

app.MapGet("/stack/{stackId}/component/{componentId}/enviroment", async (StackContext ctx) =>
{
    return await ctx.Stacks.ToListAsync();
});

app.MapGet("/stack/{stackId}/component/{componentId}/code", async (StackContext ctx) =>
{
    return await ctx.Stacks.ToListAsync();
});

//upserts only

app.MapPut("/stack", async (StackContext ctx) =>
{
    return await ctx.Stacks.ToListAsync();
});

app.MapPut("/stack/{stackId}/component", async (StackContext ctx) =>
{
    return await ctx.Stacks.ToListAsync();
});

app.MapPut("/stack/{stackId}/component/{componentId}/enviroment", async (StackContext ctx) =>
{
    return await ctx.Stacks.ToListAsync();
});

app.MapPut("/stack/{stackId}/component/{componentId}/code", async (StackContext ctx) =>
{
    return await ctx.Stacks.ToListAsync();
});

//delete only

app.MapDelete("/stack", async (StackContext ctx) =>
{
    return await ctx.Stacks.ToListAsync();
});

app.MapDelete("/stack/{stackId}/component", async (StackContext ctx) =>
{
    return await ctx.Stacks.ToListAsync();
});

app.MapDelete("/stack/{stackId}/component/{componentId}/enviroment", async (StackContext ctx) =>
{
    return await ctx.Stacks.ToListAsync();
});

app.MapDelete("/stack/{stackId}/component/{componentId}/code", async (StackContext ctx) =>
{
    return await ctx.Stacks.ToListAsync();
});


app.Run();