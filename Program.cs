using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "OK");

app.MapPost("/encrypt", ([FromBody] TextRequest req) =>
{
    var encrypted = Caesar(req.Text ?? "", 3);
    return Results.Ok(new TextResponse(encrypted));
});

app.MapPost("/decrypt", ([FromBody] TextRequest req) =>
{
    var decrypted = Caesar(req.Text ?? "", -3);
    return Results.Ok(new TextResponse(decrypted));
});

app.Run();

static string Caesar(string input, int shift)
{
    shift %= 26;

    return new string(input.Select(c =>
    {
        if (!char.IsLetter(c)) return c;

        var a = char.IsUpper(c) ? 'A' : 'a';
        var offset = (c - a + shift + 26) % 26;
        return (char)(a + offset);
    }).ToArray());
}

public record TextRequest(string Text);
public record TextResponse(string Result);
