CREATE TABLE IF NOT EXISTS person (
	id bigint(20) PRIMARY KEY AUTO_INCREMENT,
    first_name varchar(30) NOT NULL,
    last_name varchar(40) NOT NULL,
    address varchar(150) NOT NULL,
    gender varchar(20) NOT NULL
);