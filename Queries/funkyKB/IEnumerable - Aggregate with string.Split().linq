<Query Kind="Statements">
  <NuGetReference>NAudio</NuGetReference>
</Query>

var x = "a.b.c.d";
x.Split('.')
    .Take(2)
    .Aggregate((output, current) => string.Concat(output, ".", current))
    .Dump();