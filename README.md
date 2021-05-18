# RESTful API with ASP.NET Core 3.0 
 Simple answer is CRUD API that uses GET, POST, PUT, PATCH, and DELETE verbs to manipulate the resources for music Bands and the Bands Albums. However we’ll do so much more than that! We will also let our API to filter and sort resources; apply pagination to limit the number of resources per page; implement Data Shaping to allow the user specify which properties should be returned and which ones can be ignored; we’ll let the user to create a collection of resources with a single API request; support Json and XML; add Upserting, which is creating a new resource with update, if the resource doesn’t yet exists, and we’ll implementing it both for PUT and PATCH verbs; we’ll implement input validation, both with IValidatable Object and we’ll also create a Custom Validation Attribute; we’ll have a close look at status codes and make sure they adhere to REST principles; we’ll use OPTIONS and HEAD verbs and explore how and why to use them; and we’ll add custom headers to our responses. Of course, we will work heavily with Entities and Data Transfer Objects (DTO). And all of that will be implemented via Repository Pattern.
