# UML Class Diagram and Relationship Examples  

This repository provides **UML Class Diagram** concepts and demonstrates how to implement them in C#.  
It is a guide for those who want to learn and practice various **relationship types** based on Object-Oriented Programming (OOP) principles.  

---

## 🔍 Overview  
This project includes examples of the following relationship types:  
1. **Uni-directional Association**  
2. **Bi-directional Association**  
3. **Aggregation**  
4. **Composition**  

**🎯 Purpose:**  
- Understand UML Class Diagrams.  
- Model relationships between objects and write effective code.  
- Learn and practice different relationship types in OOP.  

---

## 📂 Included Examples  

### 1️⃣ Uni-directional Association  
**Definition:**  
One class can access another class, but the reverse is not possible.  

**Examples:**  
- `Student` ➡️ `School`  
- `Writer` ➡️ `Book`  
- `Employee` ➡️ `Department`  

---

### 2️⃣ Bi-directional Association  
**Definition:**  
Two classes can access each other mutually.  

**Examples:**  
- `Student` ↔️ `Course`  
- `Doctor` ↔️ `Patient`  
- `Company` ↔️ `Employee`  

---

### 3️⃣ Aggregation  
**Definition:**  
A "whole-part" relationship where the parts can exist independently of the whole.  

**Examples:**  
- `Car` 🛞 `Wheel`  
- `House` 🛋️ `Room`  
- `Library` 📚 `Book`  

---

### 4️⃣ Composition  
**Definition:**  
A "whole-part" relationship where the parts cannot exist without the whole.  

**Examples:**  
- `Human` ❤️ `Heart`  
- `Computer` 🖥️ `Processor`  
- `Car` ⚙️ `Engine`  

---

## 🛠️ How to Use  
1. **Clone the repository:**  
   ```bash  
   git clone https://github.com/username/UML-Relationship-Examples.git  
Open the project in Visual Studio.
Explore and run the code examples to understand the concepts.

🎓 Project Purpose
Learn UML Class Diagram concepts.
Practice implementing object relationships in code.
Explore various relationship types in Object-Oriented Programming (OOP).


🤝 Contribute
To contribute to this project:

Add new examples.
Optimize or improve existing code.
Expand the README file.
