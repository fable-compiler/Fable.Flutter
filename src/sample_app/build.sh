#!/bin/sh -x

dotnet tool restore
dotnet fable watch src -o lib --lang dart
