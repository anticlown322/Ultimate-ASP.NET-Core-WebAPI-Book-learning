# :eyes: Overview

This repository contains my version of source code for the book "Ultimate ASP.NET Core Web API"

**_Huge thanks to the authors!!!_**

## :mag: Details

### Book

You may buy this book [here](https://courses.code-maze.com/courses/ultimate-aspnet-core-webapi/) with all bonus files and full source code.

Or you may try to find it [somewhere](https://dl.ebooksworld.ir/books/Ultimate.ASP.NET.Core.Web.API.Marinko.Spasojevic.Vladimir.Pecanac.CodeMaze.EBooksWorld.ir.pdf) else:grin:.
Even in [this repo](/assests/documents/Ultimate.ASP.NET.Core.Web.API.Marinko.Spasojevic.Vladimir.Pecanac.CodeMaze.EBooksWorld.ir.pdf).

### Project structure

My project structure differs from book because it looked to messy for me. So I've separated solution into solution folders and renamed some assemblies.

![project-structure](/assests/images/project-structure.png)

It might be better to rename `Presentation.Presentation` and other main assemblies in solution folders to something simple like `Presentation`. But I'll leave it like this.

### Deployment

I haven't deployed my app to IIS because I've liked the dockerizing way. So I removed the `Publish` folder. Docker files won't be provided.

### Bonus chapters

## :jigsaw: Issues I faced

### Deprecated packages

Some of the packages in the book are deprecated as of December 2024. But don't be afraid to use them, there are no major changes compared to previous versions. They are still useful.

### Source code

Since I didn't have the source code I've struggled sometimes to implement different things. [This repository](https://github.com/edpelaezc/netcore) might be useful if you have any issues while reading this book. Code is separated according to chapters.

### Migration process [Chapter 3]

Provided in book migration process is dependent on Visual Studio tools so it is not portable and might be confusing for users of other IDEs. I've been using Rider during reading so i searched for more universal method. These links helped me a lot:

- [Data source creation in Rider](https://blog.jetbrains.com/datagrip/2016/10/07/connecting-datagrip-to-sql-server-express-localdb/)
- [Migration process](https://blog.jetbrains.com/dotnet/2017/08/09/running-entity-framework-core-commands-rider/)

My settings for data source in Rider:

```
Instance: MSSQLLocalDB
Auth:     No auth
Database: CompanyEmployee
URL:      Server=(localdb)\MSSQLLocalDB;Database=CompanyEmployee
```

### Entity class [Chapter 20]

> All you have to do is to create the Entity class and copy the content
> from our Entity class that resides in the Entities/Models folder.

The required code for the entity class is not provided in the book. I used the source code from the [repository mentioned earlier](#source-code) and it worked nice for me.

### Refresh token implementation [Chapter 28]

I didn't follow the advice:

> If for some reason you get the message that you need to review your
> migration due to possible data loss, you should inspect the migration file

and applied migration for couple of times. Postman requests didn't work as expected.
After searching for a while a finally understood the problem and edited the database fields that are responsible for roles ids.

![edited-ids](/assests/images/roles-ids.png)
