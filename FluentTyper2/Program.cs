using System;
using System.Linq;
using System.Collections.Generic;
using MarcusMedina.Fluent.Text.Extensions.Casing;
using MarcusMedina.Fluent.Text.Extensions.Extraction;
using MarcusMedina.Fluent.Text.Extensions.Counting;
using MarcusMedina.Fluent.Text.Extensions.Manipulation;
using MarcusMedina.Fluent.Text.Extensions.DataFormat;
using MarcusMedina.Fluent.Text.Extensions.Pattern;
using MarcusMedina.Fluent.Text.Extensions.LineEndings;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Divider("Fluent Typer 2 – The Builder Saga");
Intro();

DemoCasing();
DemoExtraction();
DemoCounting();
DemoManipulation();
DemoDataFormat();
DemoPatternMatching();
DemoLineEndings();
BossBattle();

Divider("GAME OVER – Now go write fluent code like a boss.");

void Divider(string title)
{
    Console.WriteLine("\n=============================================");
    Console.WriteLine(" " + title);
    Console.WriteLine("=============================================\n");
}

void Intro()
{
    Console.WriteLine("Welcome hero! Watch the Fluent Text magic unfold.\n");
}

void DemoCasing()
{
    Divider("Casing Spells");
    string words = "fluent builder saga";
    Console.WriteLine($"PascalCase: {words.ToPascalCase()}");
    Console.WriteLine($"CamelCase : {words.ToCamelCase()}");
    Console.WriteLine($"KebabCase : {words.ToKebabCase()}");
    Console.WriteLine($"SnakeCase : {words.ToSnakeCase()}");
    Console.WriteLine($"TitleCase : {words.ToTitleCase()}");
}

void DemoExtraction()
{
    Divider("Extraction Magic");
    string text = "Contact me at hero@test.com or visit https://dotnet.run #fluent";
    Console.WriteLine("Emails: " + string.Join(", ", text.ExtractEmails()));
    Console.WriteLine("URLs  : " + string.Join(", ", text.ExtractUrls()));
    Console.WriteLine("Tags  : " + string.Join(", ", text.ExtractHashtags()));
}

void DemoCounting()
{
    Divider("Counting Runes");
    string spell = "Hello World, The Fluent Saga Begins!";
    Console.WriteLine($"Words: {spell.CountWords()}");
    Console.WriteLine($"Vowels: {spell.CountVowels()}");
    Console.WriteLine($"Uppercase: {spell.CountUppercase()}");
}

void DemoManipulation()
{
    Divider("Manipulation Arts");
    string phrase = "this is your destiny";
    Console.WriteLine($"Reverse: {phrase.Reverse()}");
    Console.WriteLine($"ShuffleWords: {phrase.ShuffleWords()}");
    Console.WriteLine($"Repeat(2): {"Ha".Repeat(2)}");
    Console.WriteLine($"Mask(3,3): {"1234567890".Mask(3,3)}");
    Console.WriteLine($"Truncate(10): {"This is an epic quest sentence".Truncate(10)}");
}

void DemoDataFormat()
{
    Divider("Data Format Alchemy");
    string plain = "fluent builders unite";
    Console.WriteLine($"Base64: {plain.ToBase64()}");
    Console.WriteLine($"URL Enc: {plain.ToUrlEncoded()}");
    Console.WriteLine($"HTML Enc: {"<div>".ToHtmlEncoded()}");
    Console.WriteLine($"Hex Enc: {"OK".ToHex()}");
    Console.WriteLine($"Valid JSON?: {"{\"test\":1}".IsValidJson()}");
}

void DemoPatternMatching()
{
    Divider("Pattern Matching Tricks");
    string hero = "Marcus";
    Console.WriteLine($"IsLike(\"M%us\"): {hero.IsLike("M%us")}");
    Console.WriteLine($"Between(\"A\",\"Z\"): {hero.Between("A","Z")}");
    Console.WriteLine($"In([...]): {hero.In(new[] { "Lyra", "Marcus", "Clara" })}");
}

void DemoLineEndings()
{
    Divider("Line Endings Sorcery");
    string winText = "Line1\\r\\nLine2";
    Console.WriteLine("ToUnixLineEndings():");
    Console.WriteLine(winText.ToUnixLineEndings().Replace("\\n", "\\n»"));
}

void BossBattle()
{
    Divider("Boss Battle – The Sentence Forge");
    string input = "once upon a time in the land of builders";
    Console.WriteLine($"Original: {input}");
    string forged = input.ToTitleCase()
        .ShuffleWords()
        .ToSnakeCase()
        .ToBase64();
    Console.WriteLine($"\nForged Sentence: {forged}");
    Console.WriteLine("\nDecode Hint: Base64 → SnakeCase → Words of Power!");
}
