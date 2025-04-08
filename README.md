# simplyBooksBE

Welcome to Simply Books!
This is an API that allows you st search for authors and thier corraspoding books.

Users
The purpose of this app is to alow the user to organize thier books and the authors of those books.

Key features

Reattime data via Pgadmin
The user can view all details for the both books and authors
The user can CRUD on the books and authors
Programs Used
c#
PGadmin
Postman

API Endpoints

GET /api/authors
  {
        "id": 101,
        "uid": "A1",
        "first_Name": "Alice",
        "last_Name": "Johnson",
        "email": "alice.johnson@email.com",
        "favorite": true,
        "imageUrl": "https://randomuser.me/api/portraits/women/71.jpg",
        "book": null
    },
    {
        "id": 102,
        "uid": "A2",
        "first_Name": "Benjamin",
        "last_Name": "Lee",
        "email": "benjiman.lee@email.com",
        "favorite": false,
        "imageUrl": "https://randomuser.me/api/portraits/men/74.jpg",
        "book": null
    },

    GET /api/authors/{id}
     {
        "id": 102,
        "uid": "A2",
        "first_Name": "Benjamin",
        "last_Name": "Lee",
        "email": "benjiman.lee@email.com",
        "favorite": false,
        "imageUrl": "https://randomuser.me/api/portraits/men/74.jpg",
        "book": null
    }

    POST /api/authors
    {
    "id": 107,
    "uid": "A1",
    "first_Name": "Alice",
    "last_Name": "Johnson",
    "email": "alice.johnson@email.com",
    "favorite": true,
    "imageUrl": "https://randomuser.me/api/portraits/women/71.jpg",
    "book": null
}

PUT /api/authors
{
    "id": 108,
    "uid": "A1",
    "first_Name": "Alice",
    "last_Name": "Johnson",
    "email": "alice.johnson@email.com",
    "favorite": true,
    "imageUrl": "https://randomuser.me/api/portraits/women/71.jpg",
    "book": null
}

DELETE /api/authors
Respose of 204

Books Endpoints

GET /api/books
    {
        "id": 201,
        "uid": "B1",
        "title": "The Great Gatsby",
        "author": "F. Scott Fitzgerald",
        "genre": "Fiction",
        "publishedYear": 1925,
        "favorite": true,
        "imageUrl": "https://example.com/gatsby.jpg"
    },
    {
        "id": 202,
        "uid": "B2",
        "title": "To Kill a Mockingbird",
        "author": "Harper Lee",
        "genre": "Fiction",
        "publishedYear": 1960,
        "favorite": false,
        "imageUrl": "https://example.com/mockingbird.jpg"
    },

    GET api/books/{id}
    {
        "id": 202,
        "uid": "B2",
        "title": "To Kill a Mockingbird",
        "author": "Harper Lee",
        "genre": "Fiction",
        "publishedYear": 1960,
        "favorite": false,
        "imageUrl": "https://example.com/mockingbird.jpg"
    }

    POST /api/books
    {
        "id": 207,
        "uid": "B1",
        "title": "The Great Gatsby",
        "author": "F. Scott Fitzgerald",
        "genre": "Fiction",
        "publishedYear": 1925,
        "favorite": true,
        "imageUrl": "https://example.com/gatsby.jpg"
    }

    PUT /api/books
    {
        "id": 208,
        "uid": "B1",
        "title": "The Great Gatsby",
        "author": "F. Scott Fitzgerald",
        "genre": "Fiction",
        "publishedYear": 1925,
        "favorite": true,
        "imageUrl": "https://example.com/gatsby.jpg"
    }

    DELETE /api/books
    Response of 204

    GET /api/Books/{id}
 {
        "id": 201,
        "author_Id": 101,
        "uid": "B1",
        "title": "The Secret",
        "price": 10,
        "sale": true,
        "imageUrl": "https://images-na.ssl-images-amazon.com/images/I/51aOZmIj8LL._SX331_BO1,204,203,200_.jpg",
        "description": "The Secret is a best-selling 2006 self-help book by Rhonda Byrne, based on the earlier film of the same name. It is based on the belief of the law of attraction, which claims that thoughts can change a person's life directly.",
        "author": null
    }
