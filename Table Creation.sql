--Creating the database
CREATE DATABASE CityData;

USE CityData;
--Creating the table

CREATE TABLE City
(
	City_Id int not null primary key identity(1,1),
	City varchar(40),
	State varchar(40),
	Location varchar(20),
	Pincode bigint,
	Area_SqKm bigint,
	CricketStadium varchar(80)
);