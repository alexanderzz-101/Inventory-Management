# Inventory-Management

**Main purpose:** Modernizing small sari-sari store in Philippines. This will serve as an inventory and checkout protocols of a store to properly manage the numbers of stocks in the inventory. Prevent inventory loss and correct stock management. (this is still open for suggestions of the purpose)

**Features:** It will be a web scanner type of application where the user, to add a product in the inventory, will scan the barcode of the product, input its product name, the price of the product, category (food, beverage, etc.). It will also have a checkout feature where when a customer buys a product, the user will scan the product's barcode to checkout the item and successfully removing the scanned item in the inventory.

**Languages:** Preferably, python, html, css, js, and flash for the framework, we can also consider using react to make the app more functionable and presentable (I need your opinion on this one, whether flask or react)

**Audience/User:** Instead of medium to big business owner who probably already have a running system for their inventory management, by targeting the demographic population of small time business owners this will skyrocket their efficiency and prevent losses in their business. 

## Sari-Scan 

**Sari-Sari Smart Scan** aims to modernize traditional sari-sari stores in the Philippines by providing a simple, barcode-based web application that streamlines inventory tracking and checkout processes. This project is designed specifically for small-time business owners who often rely on manual stock monitoring, making them vulnerable to inventory loss, theft, and mismanagement.

### By implementing a digital system that supports barcode scanning for product registration and checkout, this project will:

- Prevent inventory loss due to human error or outdated tracking methods

- Improve stock level awareness, enabling timely restocks

- Accelerate checkout operations for better customer service

- Empower micro-entrepreneurs with digital tools often only available to larger businesses

### Features
**Core Functionalities**:

**Barcode Scanner Integration**: Scan product barcodes using a webcam or mobile camera.

**Product Registration**: Input name, price, and category (e.g., Food, Beverage, Hygiene).

**Checkout Module**: Scan products to deduct them from inventory in real-time.

**Inventory Monitoring**: View stock levels, get notified when items are low.

**Basic Sales Report**: Track product sales over time (optional Phase 2 feature).

**Future Improvements**:

Stock Alerts via SMS/Email

PWA (Progressive Web App) for mobile optimization

User login/account system for store staff



---
## Prompted

**Frontend**

HTML, CSS, JavaScript, jQuery
For building a responsive and interactive UI. jQuery simplifies DOM manipulation and AJAX calls — great for rapid development.

**Backend / API Logic**
ASP.NET Core
A modern, cross-platform, high-performance web framework from Microsoft. It will serve as your REST API provider, handling routes for:

- Product registration (with barcode)

- Inventory updates

- Checkout logic

- Stock monitoring and reports

Database
- Microsoft SQL Server a robust, enterprise-grade relational database to store your inventory, transaction logs, and user data.

ORM (Object Relational Mapping)
- Entity Framework Core (EF Core) to handle database interactions using strongly-typed C# objects, making CRUD operations simpler and more maintainable.

**⚖️ Pros of This Stack**
- Great performance and scalability via ASP.NET Core

- Strong type safety with C# and EF Core

- Easier integration with Windows-based deployments or local development environments using Visual Studio

- MSSQL is ideal for relational, structured inventory data

- jQuery is lightweight and gets the job done for simpler UI interactions

**💡 Things to Consider**
- If your app is intended to be used offline or on very low-resource machines, ASP.NET Core might be heavier compared to Flask. But if you're planning cloud deployment or internal hosting, it’s a great long-term choice.

- Make sure to plan for barcode scanner input on the frontend — this usually mimics keyboard input, so jQuery key/event listeners will work well.



