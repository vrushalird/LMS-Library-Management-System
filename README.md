# LMS-Library-Management-System

## Overview
The **Library Management System (LMS)** is a project designed to manage library operations such as adding books, registering members, borrowing books, and returning books. This project demonstrates the use of **Object-Oriented Programming (OOP)** concepts to model real-world entities and their interactions.

---

## Object-Oriented Programming (OOP) Concepts Demonstrated

### 1. Encapsulation
- Classes like `Book`, `Member`, and `Library` encapsulate their data (fields) and provide methods to interact with them.
- Access modifiers (`private`, `public`, `protected`) are used to restrict direct access to class members, ensuring data integrity.

### 2. Abstraction
- The project hides implementation details and exposes only the necessary functionalities through methods like:
  - `AddBook()`
  - `RemoveMember()`
  - `LendBook()`
- This simplifies the interaction with complex operations.

### 3. Inheritance
- A `PremiumMember` class inherits from the `Member` class to have additional features like extended borrowing limits.
- Further extensions can be added using inheritance. For example:
    - A `DigitalBook` class can inherit from the `Book` class to add properties like `fileSize` or `format`.

### 4. Polymorphism
- Polymorphism is demonstrated through method overriding. 
  - A method `BorrowBook()` is overridden in derived class `Premium Member` to borrow a book upto higher limits than a normal `Member` class.
- It can be demonstrated though method overloading as well. For example:
  - Methods like `DisplayBookDetails()` are overloaded in `Book` class to display specific details of books.

### 5. Classes and Objects
- The project defines multiple classes (`Book`, `Member`, `Library`, etc.) to represent real-world entities.
- Objects of these classes are created to perform operations like borrowing books or registering members.

### 6. Static Members
- Static members are used to store global data. For example:
  - A static counter `nextId` in the `Book` class to generate unique IDs for each book.
  - A static counter `nextId` in the `Member` class to generate unique IDs for each member.

### 7. Relationships Between Classes
- **Association**: The `Library` class maintains a list of `Book` and `Member` objects.
- **Aggregation**: The `Member` class contains a list of borrowed `Book` objects.
- **Composition**: The `LibraryManager` class uses `Library` objects as its own part. It cannot exist without a `Library` class.
    - Similarly, `BooksManager` and `MembersManager` classes depend on `Book` and `Member` objects respectively to manage specific functionalities.

### 8. Error Handling
- Basic error handling is implemented using conditional checks. For example:
  - Checking if a book is available before lending it.
  - Ensuring a member exists before performing operations.

### 9. Separation of Concerns
- Responsibilities are divided into different classes:
  - `BooksManager` handles book-related operations.
  - `MembersManager` handles member-related operations.
  - `LibraryManager` coordinates overall library operations.

### 10. Code Reusability
- Methods like `DisplayBookDetails()` and `DisplayMemberDetails()` are reusable across different parts of the application, reducing redundancy.

---

## Features
- Add, update, and delete books.
- Register and manage library members.
- Borrow and return books.
- View details of books and members.

---

## How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/vrushalird/LMS-Library-Management-System.git
2. Run the solution from terminal:
   ```bash
   dotnet run