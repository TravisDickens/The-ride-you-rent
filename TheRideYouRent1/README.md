# Rental Management System

The Rental Company is a start-up called "The Ride You Rent" that aims to provide a solution for e-hailing drivers who require convenient and affordable access to rental cars for their daily work. To streamline their operations and move towards a paperless system, they have decided to develop a Rental Management System. This system will enable them to manage drivers, rentals, returns, and track any late fees incurred due to late returns.

## Features

- **Driver Management:** Maintain a database of drivers, including their personal information, such as name, address, email, and mobile number.

- **Inspector Management:** Keep track of vehicle inspectors who collect the rental cars at pick-up points. Store their details, including inspector number, name, email, and mobile number.

- **Vehicle Management:** Manage a fleet of rental vehicles, including car make, model, body type, kilometers traveled, and service kilometers available.

- **Rental Management:** Track rental information, including the car number, inspector assigned, driver renting the vehicle, rental fee, start date, and end date.

- **Return Management:** Log the return of rental vehicles, capturing the car number, inspector handling the return, driver returning the vehicle, return date, and any late fees incurred.

## System Access

The Rental Management System should be accessible from both desktop computers and mobile phones. Inspectors, who collect the vehicles at pick-up points, should be able to log returns using their mobile phones immediately upon vehicle collection.

## Future Expansion

While the initial focus is on developing the core functionalities mentioned above (Driver, Inspector, Vehicle, Rental, and Return Management), The Ride You Rent plans to expand the system in the future to add more functionality.

## Installation and Deployment

1. Clone the project repository from GitHub.

```
git clone https://github.com/therideyourent/rental-management-system.git
```

2. Install the required dependencies and libraries.

```
cd rental-management-system
npm install
```

3. Configure the database connection in the `.env` file.

```
DB_HOST=your_database_host
DB_USERNAME=your_database_username
DB_PASSWORD=your_database_password
```

4. Build and deploy the system.

```
npm run build
npm start
```

5. Access the system from your web browser at https://therideyourentmvc.azurewebsites.net
6. Use budbarnes@therideyourent.com as the username and pass@I101 as the password
