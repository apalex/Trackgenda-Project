CREATE DATABASE IF NOT EXISTS trackgenda;

USE trackgenda;

CREATE TABLE IF NOT EXISTS user_info (
    uid INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    u_email VARCHAR(255) NOT NULL UNIQUE,
    username VARCHAR(255) NOT NULL UNIQUE,
    u_password VARCHAR(255) NOT NULL
);