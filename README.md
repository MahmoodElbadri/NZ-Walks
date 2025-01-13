
# NZ Walks Project  

The **NZ Walks** application is a .NET Core project that provides APIs and a user interface for managing walks and regions in New Zealand. It also supports image uploads with file validation.  

---

## API Endpoints  

### **Regions API**  
- **GET /api/Regions**  
  Retrieves all regions.  

- **GET /api/Regions/{id}**  
  Retrieves a specific region by ID.  

- **POST /api/Regions**  
  Adds a new region.  
  - **Request Body:** JSON with region details (e.g., Name, Code, etc.).  

- **PUT /api/Regions/{id}**  
  Updates an existing region by ID.  

- **DELETE /api/Regions/{id}**  
  Deletes a region by ID.  

---

### **Walks API**  
- **GET /api/Walks**  
  Retrieves all walks.  

- **GET /api/Walks/{id}**  
  Retrieves a specific walk by ID.  

- **POST /api/Walks**  
  Adds a new walk.  
  - **Request Body:** JSON with walk details (e.g., Name, Length, etc.).  

- **PUT /api/Walks/{id}**  
  Updates an existing walk by ID.  

- **DELETE /api/Walks/{id}**  
  Deletes a walk by ID.  

---

### **Images API**  
#### **Upload Image**  
- **POST /api/Images/Upload**  
  - **Description:** Uploads an image file with validation for file type and size.  
  - **Validation Rules:**  
    - Allowed file types: `.jpg`, `.jpeg`, `.png`.  
    - Maximum file size: **10 MB**.  
  - **Request Body:**  
    - Content-Type: `multipart/form-data`.  
    - Form Fields:  
      - **File**: The image file to upload.  
      - **FileName**: A name for the file.  
      - **FileDescription**: Optional description of the file.  
  - **Responses:**  
    - `200 OK`: On successful upload.  
    - `400 Bad Request`: On validation failure.  

---

## UI Functionality  

### **Regions**  
- Displays a list of all regions.  
- Allows adding and editing regions.  

### **Walks**  
- Displays a list of all walks.  

---

## Setup  

1. Clone the repository:  
   ```bash
   https://github.com/MahmoodElbadri/NZ-Walks.git
   ```  
2. Navigate to the solution directory and restore packages:  
   ```bash
   dotnet restore
   ```  
3. Run the API project:  
   ```bash
   cd NZ_Walks.api  
   dotnet run
   ```  
4. Run the UI project:  
   ```bash
   cd NZ_Walks.UI  
   dotnet run
   ```  

---

## Technologies Used  
- **Backend:** .NET Core, ASP.NET Core Web API.  
- **Frontend:** Razor Pages with MVC pattern.  
- **Database:** Entity Framework Core.  
- **HTTP Client:** `IHttpClientFactory` for API calls.  

---  
