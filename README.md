# ProCars

ProCars is a final project created for the "Programowanie obiektowe" course.

### Technology Stack

- C#
- WPF interface
- ORM: Entity Framework for C#
- Database: SQLite

# Navigation

1. [Getting Started](#getting-started)

- [Prerequisites](#prerequisites)
- [How to ...](#how-to)
  - [Dependencies](#dependencies)
  - [How to run application](#how-to-run-application)
  - [Connection string](#connection-string)
  
2. [FAQ](#faq)

1. [DEFINITIONS](#definitions)

- [What is this app?](#what-is-this-app)
- [Contributor](#contributor)

2. [FEATURES](#features)

- [Displaying a list of cars](#displaying-a-list-of-cars)
- [Adding a car](#adding-a-car)
- [Editing a car](#editing-a-car)
- [Displaying details of a particular car](#displaying-details-of-a-particular-car)
- [Deleting a car](#deleting-a-car)

## Getting started

### Prerequisites

### How to

1. #### Dependencies

- Visual Studio

2. #### How to run application

In order to run this application, we need to have the project downloaded.

- Clone this repository via GIT or just download a zip with the content.
- Open the project in Visual Studio.
- On the top of the application, click the green arrow or just simply click **Ctrl + F5**.

3. #### Connection string

Connection string is manually set. <br>
The data will be stored in ProCars.db file. <br>
You can always change it in the *CarsDesignTimeDbContextFactory.cs* file.

## FAQ

If you have some more questions, you may find an answer in the following topics.

1. [DEFINITIONS](#definitions)

- [What is this app?](#what-is-this-app)
- [Contributor](#contributor)

2. [FEATURES](#features)

- [Displaying a list of cars](#displaying-a-list-of-cars)
- [Adding a car](#adding-a-car)
- [Editing a car](#editing-a-car)
- [Displaying details of a particular car](#displaying-details-of-a-particular-car)
- [Deleting a car](#deleting-a-car)

### Definitions

#### What is this app?

This is a standard MVVM application with WPF interface.
It stores data about fancy cars.

#### Contributor

- [Gabriel Brzoskwinia](https://github.com/BrzoskwiPK)

### Features

#### Displaying a list of cars

Left panel is just a list of cars.
Initially it's empty, but after adding some to the database, we can see a list of them.
We can click on each of them in order to see the details.
Also, we can proceed with the dropdown to edit/delete one.

![leftPanel](https://github.com/BrzoskwiPK/ProCars/assets/101000424/f81e5b22-88f9-49eb-ac0a-b04da15fb0a3)

#### Adding a car

We can click "ADD" button and create a new car.

![addCar](https://github.com/BrzoskwiPK/ProCars/assets/101000424/24423eb6-a40b-4499-b677-32efe37606bb)

#### Editing a car

We can edit car details with usage of dropdown visible near every name of the car.

![editCar](https://github.com/BrzoskwiPK/ProCars/assets/101000424/216c03f3-b785-4bdf-8a03-2dbe48d1b7ec)

#### Deleting a car

We can delete chosen car from the database.

![deleteCar](https://github.com/BrzoskwiPK/ProCars/assets/101000424/dba23f4c-346f-4e2c-8b5d-d4ac704f60c4)

#### Displaying details of a particular car

After clicking on the name of the car, details are displayed.

![detailsPanel](https://github.com/BrzoskwiPK/ProCars/assets/101000424/7247923d-704f-480c-9867-45b41c786239)
