# INTRODUCCIÓN A C# CON .NET

Hola mundo, Bienvenidos a este breve curso de fundamentos básicos de **C#** y **.NET**; aquí vamos a 
aprender los fundamentos básicos de la programación con C#, además del manejo de algunas de 
las herramientas fundamentales como dotnetCLI.

## Generar un proyecto desde cero con C# y .NET
Esta guía va dirigida a programadores que manejen el **VsCode IDE** y **.NET 8** 

### Generar una Plantilla con dotnetCLI
dotnetCLI o también conocido como el Command Line Interface de dotnet, es el SDK
que Microsoft nos ofrece para manejar el framework **.NET** con el lenguaje **C#**.  
Dotnet cuenta con algunas plantillas ya disponibles (Revisar la sección [01_Plantillas](01_Plantillas.md))

Para generar la plantilla, utilizaremos la siguiente estructura de comando en nuestra terminal:

```bash
dotnet new console -n HelloWorld

