---
# REPOSITORY: udemy-vidly-mvc-5
# FOR: The Complete ASP.NET MVC5 Course
---

This is my personal progress work on Udemy: The Complete ASP.NET MVC 5 Course by Mosh Hamedani. I started this course on 10/13/2020 to build up some knowledge for a project at work.

---
## Resources

[The Complete ASP.NET MVC Course](https://www.udemy.com/course/the-complete-aspnet-mvc-5-course)

[Mosh Hamedani on GitHub](https://github.com/mosh-hamedani)

---
## Section 1: Getting Started
#### Quiz Questions and Answers...

**Question 1:** What is the role of a controller in MVC architectural pattern?

**Answer:** It is responsible for handling an HTTP request.

---
**Question 2:** A view in the MVC pattern

Answer: Includes the HTML markup we display to the user

---
**Question 3:** A request to /customers/delete/1 by convention is handled by

**Answer:** CustomersController.Delete(int id)

---
**Question 4:** What is an action?

**Answer:** A method in a controller responsible for handling a request.

>A rule that determines what method in a controller should be called is part of the routing.

---
**Question 5:** Which statement is wrong about NuGet?

**Answer:** We use it to auto-generate a controller.

---
**Question 6:** What statement is correct about a model in an ASP.NET MVC app?

**Answer:**
It's a class
It's independent of the UI
It's independent of persistence
ALL OF THE ABOVE

---
## Section 2: ASP.NET MVC Fundamentals

Learned about:
- Action Results
- Action Parameters
- Convention-based Routing
- Attribute Routing
- Razor Views

### Types of Action Results
>Type                     Helper Method
ViewResult               View()
PartialViewResult        PartialView()
ContentResult            Content()
RedirectResult           Redirect()
RedirectToRouteResult    RedirectToAction()
JsonResult               Json()
FileResult               File()
HttpNotFoundResult       HttpNotFound()
EmptyResult

>return new ViewResult();

>return Content("HelloWorld!");
return HttpNotFound();
return new EmptyResult();
return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

Instead of a quiz, we had an exercise. :star: **My results should be the initial commit in this repository**. :star:

---
## Section 3: Working with Data

- Code-First Migrations
- Seeding the Database
- Overriding Conventions
- Querying Objects
- Eager Loading

---
## Section 4: Building Forms

>try { _context.SaveChanges(); }
catch (DbEntityValidationException e) { Console.WriteLine(e); }

**switch [Required] on GenreId**

- Markup
- Overriding Labels
- Rendering dropdown lists
- Adding data
- Updating data

---
## Section 5: Validation

**Three Steps**
1. Add Data Annotations
2. Use ModelState.IsValid to change the flow of the program
3. Add validation messages to the form

**Data Annotations**
- [Required]
- [StringLength(255)]
- [Range(1,10)]
- [Compare("OtherProperty")]
- [Phone]
- [EmailAddress]
- [Url]
- [RegularExpression("...")]

---
**Summary**
- Data Annotations
- Custom Validation
- Client-side Validation
- Anti-forgery Tokens

---
## Section 6: Building RESTful Services with ASP.NET Web API

**Before working with external APIs**, test the API with Postman extension to see if you can send requests to it.

**Header:** content-type
**Value:** application/json
**Status of request should be:** 200

**AutoMapper**, but really, don't have to worry about it.

**Summary**
- Postman Chrome Extension
- Data Transfer Objects (DTOs)
- AutoMapper
- Action Results
- Camel Notation

---
## Section 7: Client-side Development






---
*<EOF>*
