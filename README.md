# 🎮 GameStore API  

A lightweight **.NET Minimal API** for managing games with full **CRUD operations**. Built with clean architecture and easily testable using a `games.http` file in VS Code.  

## 🚀 Features  
✅ Minimal API with `MapGroup()` for clean and structured routing  
✅ CRUD operations with proper status codes (`200`, `201`, `204`, `404`)  
✅ DTOs (`CreateGameDto`, `UpdateGameDto`) for structured data handling  
✅ **Easily testable** using a `games.http` file in VS Code (with REST Client extension)  

## 🛠 Installation & Setup  
1️⃣ Clone this repository:  
   ```sh
   git clone https://github.com/yourusername/GameStoreAPI.git
   cd GameStoreAPI
```
2️⃣ Run the project:
  ```sh
  dotnet run
```
📂 API Endpoints
```sh
Method	    Endpoint                                  	Description
GET        	https://localhost:5001/games	              Get all games
GET	        https://localhost:5001/games/{id}          	Get a game by ID
POST      	https://localhost:5001/games              	Add a new game
PUT	        https://localhost:5001/games/{id}	          Update an existing game
DELETE    	https://localhost:5001/games/{id}	          Delete a game by ID
```
## 📸 Screenshots  

Here are some screenshots of the project in action:  

![Screenshot 1](https://github.com/Harishp001/GameStore.Api/blob/baea9946a33c89cf450abce95699fd8c2c5eaa28/Screenshots/Screenshot%202025-02-09%20205315.png)  
*Game List*

![Screenshot 2](https://github.com/Harishp001/GameStore.Api/blob/baea9946a33c89cf450abce95699fd8c2c5eaa28/Screenshots/Screenshot%202025-02-09%20205248.png)  
*Game list using Id*

![Screenshot 3](https://github.com/Harishp001/GameStore.Api/blob/baea9946a33c89cf450abce95699fd8c2c5eaa28/Screenshots/Screenshot%202025-02-09%20205232.png)  
*create new Game using post*

![Screenshot 4](https://github.com/Harishp001/GameStore.Api/blob/baea9946a33c89cf450abce95699fd8c2c5eaa28/Screenshots/Screenshot%202025-02-09%20205210.png)  
*Invalid post configuration.*

